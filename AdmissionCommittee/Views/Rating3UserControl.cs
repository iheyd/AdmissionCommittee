using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace AdmissionCommittee.Views
{
    public partial class Rating3UserControl : UserControl
    {
        public Rating3UserControl()
        {
            InitializeComponent();
            dataGridViewRating3.CellClick += DataGridView_CellClick;
            dataGridViewRating3.RowHeadersVisible = false;
            dataGridViewRating3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRating3.CellFormatting += DataGridView_CellFormatting;
            LoadRatingData3();
        }

        public void LoadRatingData3()
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
                            full_name,
                            math_score,
                            russian_score,
                            additional_discipline_score,
                            additional_points,
                            total_score
                        FROM confirmed_requests
                        WHERE direction_id = @directionId
                        ORDER BY total_score DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("directionId", 3);

                        using (var reader = cmd.ExecuteReader())
                        {
                            var sourceTable = new DataTable();
                            sourceTable.Load(reader);

                            var displayTable = new DataTable("DisplayTable");

                            displayTable.Columns.Add("Номер", typeof(int));
                            displayTable.Columns.Add("Базовый ID", typeof(int));
                            displayTable.Columns.Add("ФИО", typeof(string));
                            displayTable.Columns.Add("Математика", typeof(int));
                            displayTable.Columns.Add("Русский язык", typeof(int));
                            displayTable.Columns.Add("Доп. предмет", typeof(int));
                            displayTable.Columns.Add("Достижения", typeof(int));
                            displayTable.Columns.Add("Общий балл", typeof(int));

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
                                    row["full_name"],
                                    row["math_score"],
                                    row["russian_score"],
                                    DBNull.Value.Equals(row["additional_discipline_score"]) ? 0 : Convert.ToInt32(row["additional_discipline_score"]),
                                    DBNull.Value.Equals(row["additional_points"]) ? 0 : Convert.ToInt32(row["additional_points"]),
                                    row["total_score"]
                                );
                            }

                            dataGridViewRating3.DataSource = displayTable;

                            if (dataGridViewRating3.Columns.Contains("Базовый ID"))
                                dataGridViewRating3.Columns["Базовый ID"].Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки рейтинга: " + ex.Message);
                }
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (e.RowIndex < 0 || grid == null) return;

            string colName = grid.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                var cellValue = grid.Rows[e.RowIndex].Cells["Базовый ID"].Value;

                if (cellValue == null || !int.TryParse(cellValue.ToString(), out int requestId) || requestId <= 0)
                {
                    MessageBox.Show("Выберите корректную заявку.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить эту заявку?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteConfirmedRequest(requestId);
                }

                LoadRatingData3();
            }
        }

        private void DeleteConfirmedRequest(int requestId)
        {
            string connString = "Host=127.0.0.1;Port=5432;Database=AdmissionCommittee;Username=postgres;Password=1478";

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("DELETE FROM confirmed_requests WHERE id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("id", requestId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Заявка успешно удалена из рейтинга.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении заявки: " + ex.Message);
                }
            }
        }
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = sender as DataGridView;
            var numberObj = grid.Rows[e.RowIndex].Cells["Номер"].Value;

            if (numberObj != null && int.TryParse(numberObj.ToString(), out int number) && number <= 5)
            {
                e.CellStyle.BackColor = Color.FromArgb(144, 238, 144);
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionBackColor = Color.Green;
            }
        }
    }
}