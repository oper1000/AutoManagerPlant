using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReportViewer
{
    public partial class Form1 : Form
    {
        // Instantiate the Merchant class.

        private DefineProduct.Merchant m_merchant = new DefineProduct.Merchant();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bind the Product collection to the DataSource. 
            //this.productBindingSource.DataSource = m_merchant.GetProducts();
            //this.customerBindingSource.DataSource = Customer.GetAllCustomers();
            
            this.reportViewer1.RefreshReport();
        }
    }
}
