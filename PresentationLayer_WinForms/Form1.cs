using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer_WinForms
{

    public partial class Form1 : Form
    {
        BindingSource BindingSource = new BindingSource();
        BusinessManager BusinessManager = new BusinessManager();

        public Form1()
        {
            InitializeComponent();

            BindingSource.DataSource = BusinessManager.GetProducts();
            dataGridView1.DataSource = BindingSource.DataSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGetAll(object sender, EventArgs e)
        {
            BindingSource.DataSource = BusinessManager.GetProducts();
            dataGridView1.DataSource = BindingSource.DataSource;
        }

        private void HideColums()
        {
            dataGridView1.Columns["ProductId"].Visible = false;
            dataGridView1.Columns["SupplierId"].Visible = false;
            dataGridView1.Columns["CategoryId"].Visible = false;

            dataGridView1.Columns["Suppliers"].Visible = false;
            dataGridView1.Columns["Categories"].Visible = false;
            dataGridView1.Columns["Order_Details"].Visible = false;
        }

        private void btnStartingWithAll_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = BusinessManager.GetProductsStartingWithA();
            dataGridView1.DataSource = BindingSource.DataSource;
        }
    }
}
