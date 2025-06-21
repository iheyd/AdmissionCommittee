using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace AdmissionCommittee.Views
{
    public partial class Request2UserControl : UserControl
    {
        public Request2UserControl()
        {
            InitializeComponent();
            dataGridViewRequests.CellClick += DataGridView_CellClick;
            dataGridViewRequests.RowHeadersVisible = false;
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadRequests()
        {
            string connString = "Host=127.0.0.1;Port=5432;Database=AdmissionCommittee;Username=postgres;Password=1478";

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(@"
                        SELECT 
                            id,
                            unique_code,
                            full_name,
                            direction_id,
                            math_score,
                            russian_score,
                            additional_discipline_score,
                            additional_points,
                            total_score,
                            submitted_at
                        FROM requests", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var sourceTable = new DataTable();
                        sourceTable.Load(reader);

                        var displayTable = new DataTable("DisplayTable");
                        displayTable.Columns.Add("Номер", typeof(int));
                        displayTable.Columns.Add("Базовый ID", typeof(int));
                        displayTable.Columns.Add("Уникальный код", typeof(string));
                        displayTable.Columns.Add("ФИО", typeof(string));
                        displayTable.Columns.Add("Направление", typeof(string));
                        displayTable.Columns.Add("Математика", typeof(int));
                        displayTable.Columns.Add("Русский язык", typeof(int));
                        displayTable.Columns.Add("Доп. предмет", typeof(int));
                        displayTable.Columns.Add("Достижения", typeof(int));
                        displayTable.Columns.Add("Общий балл", typeof(int));
                        displayTable.Columns.Add("Дата подачи", typeof(DateTime));

                        if (!displayTable.Columns.Contains("Approve"))
                            displayTable.Columns.Add("Approve", typeof(string)).DefaultValue = "Одобрить";
                        if (!displayTable.Columns.Contains("Delete"))
                            displayTable.Columns.Add("Delete", typeof(string)).DefaultValue = "Удалить";

                        int rowNumber = 1;

                        foreach (DataRow row in sourceTable.Rows)
                        {
                            object idObj = row["id"];
                            if (idObj == DBNull.Value || !int.TryParse(idObj.ToString(), out int realId))
                                continue;

                            displayTable.Rows.Add(
                                rowNumber++,
                                realId,
                                row["unique_code"],
                                row["full_name"],
                                GetDirectionNameById(Convert.ToInt32(row["direction_id"])),
                                Convert.ToInt32(row["math_score"]),
                                Convert.ToInt32(row["russian_score"]),
                                DBNull.Value.Equals(row["additional_discipline_score"]) ? 0 : Convert.ToInt32(row["additional_discipline_score"]),
                                DBNull.Value.Equals(row["additional_points"]) ? 0 : Convert.ToInt32(row["additional_points"]),
                                Convert.ToInt32(row["total_score"]),
                                Convert.ToDateTime(row["submitted_at"])
                            );
                        }

                        dataGridViewRequests.DataSource = displayTable;

                        if (dataGridViewRequests.Columns.Contains("Базовый ID"))
                            dataGridViewRequests.Columns["Базовый ID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки заявок: " + ex.Message);
                }
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (e.RowIndex < 0 || grid == null) return;

            string colName = grid.Columns[e.ColumnIndex].Name;

            if (colName == "Approve" || colName == "Delete")
            {
                var cellValue = grid.Rows[e.RowIndex].Cells["Базовый ID"].Value;

                if (cellValue == null || !int.TryParse(cellValue.ToString(), out int requestId) || requestId <= 0)
                {
                    MessageBox.Show("Выберите корректную заявку.");
                    return;
                }

                if (colName == "Approve")
                {
                    MoveToConfirmed(requestId);
                }
                else if (colName == "Delete")
                {
                    DeleteRequest(requestId);
                }

                LoadRequests();
            }
        }

        private void MoveToConfirmed(int requestId)
        {
            string connString = "Host=127.0.0.1;Port=5432;Database=AdmissionCommittee;Username=postgres;Password=1478";

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (var cmdInsert = new NpgsqlCommand(@"
                        INSERT INTO confirmed_requests (
                            direction_id, full_name, math_score, russian_score, 
                            additional_discipline_score, additional_points, total_score
                        )
                        SELECT 
                            direction_id, full_name, math_score, russian_score, 
                            additional_discipline_score, additional_points, total_score
                        FROM requests
                        WHERE id = @id", conn))
                    {
                        cmdInsert.Parameters.AddWithValue("id", requestId);
                        cmdInsert.ExecuteNonQuery();
                    }

                    using (var cmdDelete = new NpgsqlCommand("DELETE FROM requests WHERE id = @id", conn))
                    {
                        cmdDelete.Parameters.AddWithValue("id", requestId);
                        cmdDelete.ExecuteNonQuery();
                    }

                    MessageBox.Show("Заявка одобрена и добавлена в рейтинг.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при одобрении заявки: " + ex.Message);
                }
            }
        }

        private void DeleteRequest(int requestId)
        {
            string connString = "Host=127.0.0.1;Port=5432;Database=AdmissionCommittee;Username=postgres;Password=1478";

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("DELETE FROM requests WHERE id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("id", requestId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Заявка успешно удалена.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении заявки: " + ex.Message);
                }
            }
        }

        private string GetDirectionNameById(int id)
        {
            switch (id)
            {
                case 1: return "Архитектура";
                case 2: return "ИСТ";
                case 3: return "Социология";
                default: return "Неизвестное направление";
            }
        }
    }
}