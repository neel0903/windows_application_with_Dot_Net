using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using PagedList;

namespace JANKI_APP
{
    public partial class INVOICE : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
        public INVOICE()
        {
            InitializeComponent();
           
        }
        int currentPage = 1;
        int pageSize = 40;
        private object chalan1BindingSource;

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbtable.Text == "CHALAN")
            {

                try
                {

                    con.Open();
                    SqlCommand c = con.CreateCommand();

                    string query = "SELECT * FROM  CHALAN1 WHERE DATE BETWEEN '" + dateTimePickerFROM.Text + "' AND '" + dateTimePickerTO.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "CHALAN1");
                    dataGridViewprint.DataSource = set.Tables["CHALAN1"];


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ex.Message");
                }
                finally
                {
                    con.Close();
                }
            }
            if (cbtable.Text== "SALE")
            {
                try
                {
                    con.Open();
                    SqlCommand c = con.CreateCommand();

                    string query1 = "SELECT * FROM SALEDETAILS WHERE DATE BETWEEN '" + dateTimePickerFROM.Text + "' AND '" + dateTimePickerTO.Text + "'";

                    SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);

                    DataSet set = new DataSet();

                    adapter1.Fill(set, "SALEDETAILS");

                    dataGridViewprint.DataSource = set.Tables["SALEDETAILS"];


                }
                catch (Exception ex)

                {
                    MessageBox.Show("Error in display data of saleinfo table");

                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void pictureBoxEXIT_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Confirm to Close", "EXIT", MessageBoxButtons.YesNo);
            if (Confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void pictureBoxMINI_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxHOME_Click(object sender, EventArgs e)
        {
            HOME IN = new HOME();
            IN.Show();
            this.Close();

        }

        private void INVOICE_Load(object sender, EventArgs e)
        {
           
                    
            
        }

        private void pbexel_Click(object sender, EventArgs e)
        {if (cbtable.Text == "CHALAN")
            {
                try
                {
                    con.Open();
                    SqlCommand c = con.CreateCommand();
                    string query = "SELECT *FROM CHALAN1 ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable tb = new DataTable();
                    adapter.Fill(tb);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = tb;

                    dataGridViewprint.DataSource = bSource;
                    adapter.Update(tb);
                    DataSet set = new DataSet();
                    set.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                    adapter.Fill(tb);
                    set.Tables.Add(tb);

                    ExcelLibrary.DataSetHelper.CreateWorkbook("D:\\chalanrecord.xls", set);

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error ex ");

                }
                finally
                {

                }
            }
        if (cbtable.Text== "SALE")
            {
                try
                {
                    con.Open();
                    SqlCommand c = con.CreateCommand();
                    string query = "SELECT *FROM SALEDETAILS ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable tb = new DataTable();
                    adapter.Fill(tb);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = tb;

                    dataGridViewprint.DataSource = bSource;
                    adapter.Update(tb);
                    DataSet set = new DataSet();
                    set.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                    adapter.Fill(tb);
                    set.Tables.Add(tb);

                    ExcelLibrary.DataSetHelper.CreateWorkbook("D:\\SALEDETAILS.xls", set);

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error ex ");

                }
                finally
                {

                }
            }
        }

        private void gradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxnext_Click(object sender, EventArgs e)
        {

        }
    }
}
