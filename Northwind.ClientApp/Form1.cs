using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.ClientApp.NorthwindServiceReference;

namespace Northwind.ClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindServiceClient client = new NorthwindServiceClient();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.GetShippers();
        }
    }
}
