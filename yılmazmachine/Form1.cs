using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yılmazmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dk541 click=new dk541();    
            click.ShowDialog();
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sk500 click=new sk500();
            click.ShowDialog();
        }
    }
}
