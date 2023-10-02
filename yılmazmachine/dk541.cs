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
    public partial class dk541 : Form
    {
        public dk541()
        {
            InitializeComponent();
            update_quantity();
            timer1.Start();
            date();
        }

        private void dk541_Load(object sender, EventArgs e)
        {
            
           
            
            this.anatabloTableAdapter.Fill(this.yilmazmachineDataSet.anatablo);

        }



        private void update_quantity()
        {
            string connectionString = "Data Source=.\\MSSQLSERVER01;Initial Catalog=yilmazmachine;Integrated Security=True";
            string query = "SELECT [Total Quantity] FROM t";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();


                    string labelText = result.ToString();
                    label1.Text = labelText;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update_quantity();
            date();
            this.anatabloTableAdapter.Fill(this.yilmazmachineDataSet.anatablo);

        }


        private void date()
        {
            DateTime currentTime = DateTime.Now;
            string formattedDateTime = currentTime.ToString("yyyy-MM-dd    HH:mm:ss");
            label5.Text = formattedDateTime;
        }

       
    }


    }

