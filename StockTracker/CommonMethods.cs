using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace StockTracker
{
    class CommonMethods
    {
        SqlConnection sc = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StockManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public void ExecuteSQLQuery(string str)
        {
            try
            {
                if (sc.State == ConnectionState.Open)
                    sc.Close();
                sc.Open();
                SqlCommand cmd = new SqlCommand(str, sc);
                cmd.ExecuteNonQuery();
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getstringfromquery(string str, string str1)
        {

            try
            {
                if (sc.State == ConnectionState.Open)
                    sc.Close();
                sc.Open();
                SqlCommand cmd = new SqlCommand(str, sc);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    str1 = dr[0].ToString();
                dr.Close();
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return str1;
        }

        public void loadDataCB(string str, ComboBox cb)
        {

            try
            {
                if (sc.State == ConnectionState.Open)
                    sc.Close();
                sc.Open();
                SqlCommand cmd = new SqlCommand(str, sc);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    str = dr[0].ToString();
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void retrieveData(string str, Control c, int i)
        {

            try
            {
                if (sc.State == ConnectionState.Open)
                    sc.Close();
                sc.Open();
                SqlCommand cmd = new SqlCommand(str, sc);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = dr[i].ToString();
                    }
                }
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void loadDataGrid(string str, DataGridView dgv)
        {

            try
            {
                if (sc.State == ConnectionState.Open)
                    sc.Close();
                sc.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(str, sc);
                sda.Fill(dt);
                dgv.DataSource = dt;
                
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void numericOnly(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.StartsWith("."))
            {
                e.Handled = true;
                (sender as TextBox).Text = "0.";
            }
            var regex = new Regex(@"[^.0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Sayı girmelisiniz.");
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Tek nokta kullanın.");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Length < 1))
            {
                e.Handled = true;
                MessageBox.Show("Geçerli değil.");
            }
        }
    }
}
