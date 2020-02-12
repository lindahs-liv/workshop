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

        // Listar alla objekt vars enhetspris är högre än 100
        private void btnUnitPriceGreaterThan100(object sender, EventArgs e)
        {
            BindingSource.DataSource = BusinessManager.GetUnitPriceGreaterThan100();
            dataGridView1.DataSource = BindingSource.DataSource;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Sorterar listan stigande
        private void btnSortListAscending_CheckedChanged(object sender, EventArgs e)
        {
            // BindingSource.DataSource = BusinessManager.SortListAscending();
            BindingSource.Sort = "ProductName ASC";
            dataGridView1.DataSource = BindingSource;
        }

        private void btnGetAll(object sender, EventArgs e)
        {
            BindingSource.DataSource = BusinessManager.GetProducts();
            dataGridView1.DataSource = BindingSource.DataSource;
        }

        // Döljer kolumner som inte är relevanta
        private void HideColums()
        {
            dataGridView1.Columns["ProductId"].Visible = false;
            dataGridView1.Columns["SupplierId"].Visible = false;
            dataGridView1.Columns["CategoryId"].Visible = false;

            dataGridView1.Columns["Suppliers"].Visible = false;
            dataGridView1.Columns["Categories"].Visible = false;
            dataGridView1.Columns["Order_Details"].Visible = false;
        }

        // Visar alla objekt som börjar på A/a
        private void btnStartingWithA_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = BusinessManager.GetProductsStartingWithA();
            dataGridView1.DataSource = BindingSource.DataSource;
        }

        // Sorterar listan fallande. Logiken ska ligga här då den tillhör här...
        private void btnSortListDescending_CheckedChanged(object sender, EventArgs e)
        {
            BindingSource.Sort = "ProductName DESC";
            dataGridView1.DataSource = BindingSource;
        }
    }
}
