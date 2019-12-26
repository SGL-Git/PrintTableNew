using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PrintTableNew
{
    public partial class BarCodeScaner : Form
    {
        public BarCodeScaner()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=store;User ID=sa;Password=Sergey1955;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrause_Click(object sender, EventArgs e)
        {           
        }

        private void btnGroupId_Click(object sender, EventArgs e)
        {
            int Number = 0;
            con.Open();
            String query = "SELECT * FROM dbo.Groupes ORDER BY[id] ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewGroupe.DataSource = dt;
            if (dt != null)
            {
                DataRow[] dr = dt.Select("[id] = MAX([id])");
                txtGroupId.Text = dr[0][0].ToString();
                string str11 = txtGroupId.Text;
                Number = int.Parse(str11);
                Number = Number + 1;
                string str22 = Number.ToString();
                txtGroupId.Text = str22;
                con.Close();
                int Number2 = 0;
                Number2 = Number2 + 1;
                string str41 = Number2.ToString();
                txtProductId.Text = str41;

            }
            else
            {

                Number = Number + 1;
                string str21 = Number.ToString();
                txtGroupId.Text = str21;
                con.Close();
            }
            txtGroupName.Text = "";
            txtGroupName.Focus();

        }

        private void btnAddGroupe_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT dbo.Groupes (id, Name_of_Groupe) VALUES('" + txtGroupId.Text + "', N'" + txtGroupName.Text + "' )";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ԱՊՐԱՆՔԱՅԻՆ  ԽՄԲԻ  ՄՈՒՏՔԱԳՐՈՒՄԸ  ԿԱՏԱՐՎԵՑ !!!");
            txtGroupId.Focus();
            con.Open();
            String query1 = "SELECT * FROM dbo.Groupes ORDER BY[id]";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            dataGridViewGroupe.DataSource = dt;
            con.Close();
            txtGroupName.Text = "";
            txtGroupId.Clear();
            txtGroupId.Focus();
        }

        private void btnUpdateGroupe_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE dbo.Groupes SET Name_of_Groupe = N'" + txtGroupName.Text + "' WHERE id = '" + txtGroupId.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ԱՊՐԱՆՔԱՅԻՆ  ԽՄԲԻ  ՈՒՂՂՈՒՄԸ  ԿԱՏԱՐՎԵՑ!!!");
            con.Open();
            String query1 = "SELECT * FROM dbo.Groupes ORDER BY[id]";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            dataGridViewGroupe.DataSource = dt;
            con.Close();
            txtGroupName.Text = "";
            txtGroupId.Clear();
            txtGroupId.Focus();

        }

        private void btnViewGroupe_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Groupes ORDER BY[id]";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewGroupe.DataSource = dt;
            con.Close();
            txtGroupId.Clear();
            txtGroupName.Text = "";
            txtGroupId.Focus();
        }

        private void btnSearchGroupe_Click(object sender, EventArgs e)
        {
            txtGroupName.Clear();
            con.Open();
            String query = "SELECT * FROM dbo.Groupes WHERE id =" + txtGroupId.Text + "";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewGroupe.DataSource = dt;
            con.Close();
            txtGroupId.Focus();
        }

        private void btnDeleteGroupe_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM dbo.Groupes WHERE id=" + txtGroupId.Text + "";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ԸՆՏՐՎԱԾ  ԱՊՐԱՆՔԱՅԻՆ  ԽՄԲԻ  ԳՐԱՌՈՒՄԸ  ՀԵՌԱՑՎԵՑ!!!");
            con.Open();
            String query1 = "SELECT * FROM dbo.Groupes ORDER BY[id]";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            dataGridViewGroupe.DataSource = dt;
            con.Close();
            txtGroupId.Focus();
        }

        private void dataGridViewGroupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGroupId.Text = dataGridViewGroupe.SelectedRows[0].Cells[0].Value.ToString();
            txtGroupName.Text = dataGridViewGroupe.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnProductId_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Products WHERE Id_of_Groupe = '" + txtGroupId.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewProducts.DataSource = dt;
            if (dt != null)
            {
                DataRow[] dr = dt.Select("[Id_of_Products] = MAX([Id_of_Products])");
                txtProductId.Text = dr[0][2].ToString();
                string str10 = txtProductId.Text;
                int Number = int.Parse(str10);
                Number = Number + 1;
                string str21 = Number.ToString();
                txtProductId.Text = str21;
                con.Close();
            }
            else
            {

                int Number = 1;
                string str21 = Number.ToString();
                txtProductId.Text = str21;
                con.Close();
            }
            txtBarCode.Clear();
            txtProductName.Text = "";
            txtProductUnit.Text = "";
            txtHolesalePrice.Clear();
            txtRecomendetPrice.Clear();
            txtPrice.Clear();
            txtBarCode.Focus();

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtGroupId.Text = dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
            txtProductId.Text = dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
            txtBarCode.Text = dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
            txtProductName.Text = dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString();
            txtProductUnit.Text = dataGridViewProducts.SelectedRows[0].Cells[5].Value.ToString();
            txtHolesalePrice.Text = dataGridViewProducts.SelectedRows[0].Cells[6].Value.ToString();
            txtPrice.Text = dataGridViewProducts.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnRecomendedPrice_Click(object sender, EventArgs e)
        {
            string strPrice = txtHolesalePrice.Text;
            float Price = float.Parse(strPrice);
            Price = (float)(Price * 1.2);
            string strPrice1 = Price.ToString();
            txtRecomendetPrice.Text = strPrice1;
            txtPrice.Focus();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT dbo.Products (Id_of_Groupe, Id_of_Products, BarCode, Name_of_Products, Unit_of_Products, Holesale_Price, Sale_Price) VALUES(" + txtGroupId.Text + ", " + txtProductId.Text + ", '" + txtBarCode.Text + "', N'" + txtProductName.Text + "', N'" + txtProductUnit.Text + "', '" + txtHolesalePrice.Text + "',  '" + txtPrice.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ԱՊՐԱՆՔԻ  ՄՈՒՏՔԱԳՐՈՒՄԸ  ԿԱՏԱՐՎԵՑ !!!");
            con.Open();
            String query1 = "SELECT * FROM dbo.Products WHERE Id_of_Groupe = '" + txtGroupId.Text + "'";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            con.Close();
            txtBarCode.Clear();
            txtProductName.Text = "";
            txtProductUnit.Text = "";
            txtHolesalePrice.Clear();
            txtRecomendetPrice.Clear();
            txtPrice.Clear();
            txtBarCode.Focus();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE dbo.Products SET  BarCode = '" + txtBarCode.Text + "', Name_of_Products = N'" + txtProductName.Text + "', Unit_of_Products = N'" + txtProductUnit.Text + "', Holesale_Price = '" + txtHolesalePrice.Text + "', Sale_Price = '" + txtPrice.Text + "' WHERE Id_of_Groupe = '" + txtGroupId.Text + "' AND  Id_of_Products = '" + txtProductId.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ԱՊՐԱՆՔԻ ՈՒՂՂՈՒՄԸ  ԿԱՏԱՐՎԵՑ!!!");            
            con.Close();
            txtBarCode.Clear();
            txtProductName.Text = "";
            txtProductUnit.Text = "";
            txtHolesalePrice.Clear();
            txtRecomendetPrice.Clear();
            txtPrice.Clear();            
            btnProductId_Click(sender, e);
            txtBarCode.Focus();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM dbo.Products WHERE Id_of_Groupe = '" + txtGroupId.Text + "'  AND  Id_of_Products = '" + txtProductId.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ԸՆՏՐՎԱԾ  ԱՊՐԱՆՔԻ  ԳՐԱՌՈՒՄԸ  ՀԵՌԱՑՎԵՑ!!!");
            con.Open();
            String query1 = "SELECT * FROM dbo.Products WHERE id_of_Groupe = '" + txtGroupId.Text + "' AND  Id_of_Products = '" + txtProductId.Text + "'";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            dataGridViewProducts.DataSource = dt;
            con.Close();         
            txtBarCode.Focus();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Products WHERE id_of_Groupe = '" + txtGroupId.Text + "' AND  Id_of_Products = '" + txtProductId.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewProducts.DataSource = dt;
            con.Close();
            txtBarCode.Clear();
            txtProductName.Text = "";
            txtProductUnit.Text = "";
            txtHolesalePrice.Clear();
            txtRecomendetPrice.Clear();
            txtPrice.Clear();
            txtBarCode.Focus();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Products ORDER BY [Id_of_GRoupe], [Id_of_Products]";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewProducts.DataSource = dt;
            con.Close();
            txtBarCode.Clear();
            txtProductId.Clear();
            txtProductName.Text = "";
            txtProductUnit.Text = "";
            txtHolesalePrice.Clear();
            txtRecomendetPrice.Clear();
            txtPrice.Clear();
            txtBarCode.Focus();
        }

        private void btnBrause_Click_1(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT * FROM dbo.Products ORDER BY [BarCode]";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridViewProducts.DataSource = dt;
            con.Close();
            txtProductName.Focus();
        }

        private void btnClearproduct_Click(object sender, EventArgs e)
        {
            txtBarCode.Clear();
            txtProductId.Clear();
            txtProductName.Text = "";
            txtProductUnit.Text = "";
            txtHolesalePrice.Clear();
            txtRecomendetPrice.Clear();
            txtPrice.Clear();
            txtProductId.Focus();
        }

        private void txtBarCode_KayDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con.Open();
                String query = "SELECT * FROM dbo.Products WHERE BarCode = '" + txtBarCode.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridViewProducts.DataSource = dt;
                con.Close();
                txtProductName.Focus();
                btnBrause_Click_1(sender, e);
            }
            
        }

        private void lblUnit_Click(object sender, EventArgs e)
        {

        }
    }
}
