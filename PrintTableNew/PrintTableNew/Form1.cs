using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintTableNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGroupes_Click(object sender, EventArgs e)
        {
            Groupes objGroupes = new Groupes();
            objGroupes.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products objProducts = new Products();
            objProducts.Show();
        }

        private void btnDebitors_Click(object sender, EventArgs e)
        {
            Debitors objDebitors = new Debitors();
            objDebitors.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers objSuppliers = new Suppliers();
            objSuppliers.Show();
        }

        private void btnBarCodeScaner_Click(object sender, EventArgs e)
        {
            BarCodeScaner objBarCodeScaner = new BarCodeScaner();
            objBarCodeScaner.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockMain main = new StockMain();
            main.Show();
        }
    }
}
