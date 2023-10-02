using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yılmazmachine
{
    public partial class sk500 : Form
    {
        public sk500()
        {
            InitializeComponent();
            update();
            date();
            timer1.Start();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sk500_Load(object sender, EventArgs e)
        {
            
            this.anatablo2TableAdapter1.Fill(this.yilmazmachineDataSet3.anatablo2);

        }

        private void update()
        {
            string connectionString = "Data Source=.\\MSSQLSERVER01;Initial Catalog=yilmazmachine;Integrated Security=True";
            string query = "SELECT [Total Quantity] FROM t2";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();


                    string labelText = result.ToString();
                    label4.Text = labelText;

                }
            }
        }

        private void date()
        {
            DateTime currentTime = DateTime.Now;
            string formattedDateTime = currentTime.ToString("yyyy-MM-dd    HH:mm:ss");
            label5.Text = formattedDateTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update();
            date();
            this.anatablo2TableAdapter1.Fill(this.yilmazmachineDataSet3.anatablo2);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
