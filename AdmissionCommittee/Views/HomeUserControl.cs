using System;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace AdmissionCommittee.Views
{
    public partial class HomeUserControl : UserControl
    {
        private string connString = "Host=127.0.0.1;Port=5432;Database=AdmissionCommittee;Username=postgres;Password=1478";

        public HomeUserControl()
        {
            InitializeComponent();
            LoadStatistics();
        }

        public void LoadStatistics()
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    
                    using (var cmdStats = new NpgsqlCommand("SELECT total_applications FROM stats LIMIT 1", conn))
                    {
                        var result = cmdStats.ExecuteScalar();
                        if (result != null)
                        {
                            total_applications.Text = $"{result.ToString()}";
                        }
                        else
                        {
                            total_applications.Text = "Всего заявлений: 0";
                        }
                    }
                    
                    using (var cmdRequests = new NpgsqlCommand("SELECT COUNT(*) FROM requests", conn))
                    {
                        var count = cmdRequests.ExecuteScalar();
                        requests.Text = $"{count.ToString()}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке статистики: " + ex.Message);
            }
        }
    }
}