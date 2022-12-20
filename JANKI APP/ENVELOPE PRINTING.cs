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

namespace JANKI_APP
{
    public partial class ENVELOPE_PRINTING : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
        public ENVELOPE_PRINTING()
        {
            InitializeComponent();
        }
        public void GetID()
        {


            try { 
                string ID;
                string query = "SELECT Id FROM SALEDETAILS ORDER BY Id DESC";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int i = Convert.ToInt32((dr[0].ToString())) + 1;
                    ID = i.ToString();

                }
                else if (Convert.IsDBNull(dr))
                {
                    ID = "1";

                }
                else
                {
                    ID = "1";
                }


                con.Close();
                tbid.Text = ID.ToString();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Error");
            }
            finally
            {

            }



        }






        private void ENVELOPE_PRINTING_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbbname.Text)) ;
            {
                rtbtransportd.Text = "";
            }
           

            GetID();
            this.WindowState = FormWindowState.Maximized;

            DateTime dt = new DateTime();
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 12);



            graphics.DrawString("TO," + "", new Font("Courier New", 15), new SolidBrush(Color.Black), 160, 325);
            graphics.DrawString(" " + tbcname.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 200, 350);
            graphics.DrawString(" " + rtbcaddress.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 200, 375);
            graphics.DrawString(" " +"("+ tbtrucknum.Text+")", new Font("Courier New", 15), new SolidBrush(Color.Black), 200, 450);

            graphics.DrawString("BROKER:"+rtbbname.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 350, 475);
            graphics.DrawString("BILL NO.: " + tbbillnum.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 200, 550);
            graphics.DrawString("BAGS: " + tbnumofbag.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 500, 550);
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            int Count = 0;
            if (string.IsNullOrEmpty(rtbbname.Text)) ;
            {
                rtbtransportd.Text = "NULL";
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == tbcname.Text)
                {
                    Count = 1;
                    break;
                }
                else
                {
                    Count = 0;
                }

            }
            if (Count == 1)
            try
            {


                SqlCommand c1 = con.CreateCommand();
                string query1 = "SELECT * FROM SALEDETAILS";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "SALEDETAILS");

                DataRow row1 = set1.Tables["SALEDETAILS"].NewRow();
                row1["Id"] = tbid.Text;
                row1["DATE"] = dateTimePicker1.Text;
                row1["PRODUCT"] = cbproduct.Text;
                row1["CNAMEFROM"] = cbcfrom.Text;
                row1["CNAMETO"] = tbcname.Text;
                row1["CADDRESS"] = rtbcaddress.Text;
                row1["BROKER"] = rtbbname.Text;
                row1["TRANSPORT"] = rtbtransportd.Text;
                row1["TRUCKNUM"] = tbtrucknum.Text;
                row1["BAGS"] = tbnumofbag.Text;
                row1["BILLNUM"] = tbbillnum.Text;
                row1["RATE"] = tbrate.Text;

                set1.Tables["SALEDETAILS"].Rows.Add(row1);
                dataGridView2.DataSource = set1.Tables["SALEDETAILS"];
                SqlCommandBuilder builder1 = new SqlCommandBuilder(adapter1);
                adapter1.Update(set1.Tables["SALEDETAILS"]);
                MessageBox.Show("Data save successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in save date of sale info table ");

            }
            finally
            {

            }
          
            if (Count == 0)
            {



                try
                {

                    con.Open();
                    SqlCommand c = con.CreateCommand();

                    string query = "SELECT * FROM ENVELOPE";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                    DataSet set = new DataSet();
                    adapter.Fill(set, "ENVELOPE");


                    DataRow row = set.Tables["ENVELOPE"].NewRow();
                    row["CNAME"] = tbcname.Text;
                    row["CADDRESS1"] = rtbcaddress.Text;
                    row["BNAME"] = rtbbname.Text;
                    set.Tables["ENVELOPE"].Rows.Add(row);
                    dataGridView1.DataSource = set.Tables["ENVELOPE"];





                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(set.Tables["ENVELOPE"]);
                    MessageBox.Show("DATA SVAE SUCCESSFULLY");




                }
                catch (Exception ex)
                {
                    MessageBox.Show("ex.Message");
                }
                finally
                {
                    con.Close();

                }

                try
                {


                    SqlCommand c1 = con.CreateCommand();
                    string query1 = "SELECT * FROM SALEDETAILS";
                    SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                    DataSet set1 = new DataSet();
                    adapter1.Fill(set1, "SALEDETAILS");

                    DataRow row1 = set1.Tables["SALEDETAILS"].NewRow();
                    row1["Id"] = tbid.Text;
                    row1["DATE"] = dateTimePicker1.Text;
                    row1["PRODUCT"] = cbproduct.Text;
                    row1["CNAMEFROM"] = cbcfrom.Text;
                    row1["CNAMETO"] = tbcname.Text;
                    row1["CADDRESS"] = rtbcaddress.Text;
                    row1["BROKER"] = rtbbname.Text;
                    row1["TRANSPORT"] = rtbtransportd.Text;
                    row1["TRUCKNUM"] = tbtrucknum.Text;
                    row1["BAGS"] = tbnumofbag.Text;
                    row1["BILLNUM"] = tbbillnum.Text;
                    row1["RATE"] = tbrate.Text;

                    set1.Tables["SALEDETAILS"].Rows.Add(row1);
                    dataGridView2.DataSource = set1.Tables["SALEDETAILS"];
                    SqlCommandBuilder builder1 = new SqlCommandBuilder(adapter1);
                    adapter1.Update(set1.Tables["SALEDETAILS"]);
                    MessageBox.Show("Data save successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in save date of sale info table ");

                }
                finally
                {

                }
            }
            
        }

        private void btnprintreview_Click_1(object sender, EventArgs e)
        {
            printDocumenten.DefaultPageSettings.Landscape = true;
            printPreviewDialogen.ShowDialog();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDocumenten.Print();
        }

        private void tnsearchcname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT * FROM ENVELOPE WHERE CNAME LIKE '" + tbsearchcname.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "ENVELOPE");
                dataGridView1.DataSource = set.Tables["ENVELOPE"];
                con.Close();

            }
            catch (Exception ex)

            {
                MessageBox.Show("ERROR");

            }
            finally
            {
               
            }
        }

        private void btnupdateenv_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();

                string query = "SELECT * FROM ENVELOPE";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "ENVELOPE");
                set.Tables["ENVELOPE"].Rows[dataGridView1.SelectedRows[0].Index]["CNAME"] = tbcname.Text;
                set.Tables["ENVELOPE"].Rows[dataGridView1.SelectedRows[0].Index]["CADDRESS1"] = rtbcaddress.Text;
                set.Tables["ENVELOPE"].Rows[dataGridView1.SelectedRows[0].Index]["BNAME"] = rtbbname.Text;

                dataGridView1.DataSource = set.Tables["ENVELOPE"];
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables["ENVELOPE"]);
                MessageBox.Show("Dataset saved to database Sucessfully");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void btndeleteenv_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT * FROM ENVELOPE";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "ENVELOPE");
                set.Tables["ENVELOPE"].Rows[dataGridView1.SelectedRows[0].Index].Delete();
                dataGridView1.DataSource = set.Tables["ENVELOPE"];
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables["ENVELOPE"]);
                MessageBox.Show("Delete successfully from envelop");
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            try
            {
                con1.Open();
                SqlCommand c = con.CreateCommand();

                string query1 = "SELECT * FROM SALEDETAILS";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con1);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "SALEDETAILS");


               // set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["Id"] = tbcname.Text;
               
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["PRODUCT"] = cbproduct.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["CNAMEFROM"] = cbcfrom.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["CNAMETO"] = tbcname.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["CADDRESS"] = rtbcaddress.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["BROKER"] = rtbbname.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["TRANSPORT"] = rtbtransportd.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["TRUCKNUM"] = tbtrucknum.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["BAGS"] = tbnumofbag.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["BILLNUM"] = tbbillnum.Text;
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index]["RATE"] = tbrate.Text;

                dataGridView2.DataSource = set1.Tables["SALEDETAILS"];
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter1);
                adapter1.Update(set1.Tables["SALEDETAILS"]);

                MessageBox.Show("Dataset saved to database Sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in update");
            }
            finally
            {
                con1.Close();
            }
        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c1 = con.CreateCommand();
                string query1 = "SELECT * FROM SALEDETAILS";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "SALEDETAILS");
                set1.Tables["SALEDETAILS"].Rows[dataGridView2.SelectedRows[0].Index].Delete();
                dataGridView2.DataSource = set1.Tables["SALEDETAILS"];
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter1);
                adapter1.Update(set1.Tables["SALEDETAILS"]);
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void tbsearchcname1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT *FROM SALEDETAILS  WHERE CNAMETO LIKE '" + tbsearchcname1.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "SALEDETAILS");
                dataGridView2.DataSource = set.Tables["SALEDETAILS"];
                con.Close();


            }
            catch (Exception ex)

            {
                MessageBox.Show("ERROR");

            }
            finally
            {
               
            }
        }

        private void tbsearchtruckno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c1 = con.CreateCommand();
                string query1 = "SELECT * FROM SALEDETAILS WHERE TRUCKNUM  LIKE '" + tbsearchtruckno.Text + "%'";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "SALEDETAILS");
                dataGridView2.DataSource = set1.Tables["SALEDETAILS"];
                con.Close();

            }
            catch (Exception ex)

            {
                MessageBox.Show("ERROR");

            }
            finally
            {
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c1 = con.CreateCommand();
                string query1 = "SELECT * FROM SALEDETAILS WHERE DATE  LIKE '" + dateTimePicker1.Text + "%'";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "SALEDETAILS");
                dataGridView2.DataSource = set1.Tables["SALEDETAILS"];
                con.Close();

            }
            catch (Exception ex)

            {
                MessageBox.Show("ERROR");

            }
            finally
            {
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbcname.Text = row.Cells["CNAME"].Value.ToString();
                rtbcaddress.Text = row.Cells["CADDRESS1"].Value.ToString();
                rtbbname.Text = row.Cells["BNAME"].Value.ToString();
               
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                tbid.Text = row.Cells["Id"].Value.ToString();
                
               // dateTimePicker1.Text= row.Cells["DATE"].Value.ToString();
                cbproduct.Text = row.Cells["PRODUCT"].Value.ToString();
                cbcfrom.Text = row.Cells["CNAMEFROM"].Value.ToString();
                tbcname.Text = row.Cells["CNAMETO"].Value.ToString();
                rtbcaddress.Text = row.Cells["CADDRESS"].Value.ToString();
                rtbbname.Text = row.Cells["BROKER"].Value.ToString();
                rtbtransportd.Text = row.Cells["TRANSPORT"].Value.ToString();
                tbtrucknum.Text = row.Cells["TRUCKNUM"].Value.ToString();
                tbnumofbag.Text = row.Cells["BAGS"].Value.ToString();
                tbbillnum.Text = row.Cells["BILLNUM"].Value.ToString();
                tbrate.Text = row.Cells["RATE"].Value.ToString();
                
            }
        }

        private void btnsave1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlCommand c1 = con.CreateCommand();
                string query1 = "SELECT * FROM SALEDETAILS";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "SALEDETAILS");

                DataRow row1 = set1.Tables["SALEDETAILS"].NewRow();
                row1["Id"] = tbid.Text;
                row1["DATE"] = dateTimePicker1.Text;
                row1["PRODUCT"] = cbproduct.Text;
                row1["CNAMEFROM"] = cbcfrom.Text;
                row1["CNAMETO"] = tbcname.Text;
                row1["CADDRESS"] = rtbcaddress.Text;
                row1["BROKER"] = rtbbname.Text;
                row1["TRANSPORT"] = rtbtransportd.Text;
                row1["TRUCKNUM"] = tbtrucknum.Text;
                row1["BAGS"] = tbnumofbag.Text;
                row1["BILLNUM"] = tbbillnum.Text;
                row1["RATE"] = tbrate.Text;

                set1.Tables["SALEDETAILS"].Rows.Add(row1);
                dataGridView2.DataSource = set1.Tables["SALEDETAILS"];
                SqlCommandBuilder builder1 = new SqlCommandBuilder(adapter1);
                adapter1.Update(set1.Tables["SALEDETAILS"]);
                MessageBox.Show("Data save successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in save date of sale info table ");

            }
            finally
            {

            }
        }

        private void rtbcaddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void rtbbname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void rtbtransportd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void tbnumofbag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      


       

        private void btnnew_Click(object sender, EventArgs e)
        {
            GetID();
            cbproduct.Text = " ";
            cbcfrom.Text = " ";
            tbcname.Text = " ";
            rtbcaddress.Text = " ";
            rtbbname.Text = " ";
            rtbtransportd.Text = " ";
            tbtrucknum.Text = " ";
            tbnumofbag.Text = " ";
            tbbillnum.Text = " ";
            tbrate.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT * FROM ENVELOPE ";
               
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                

                DataSet set = new DataSet();
                adapter.Fill(set, "ENVELOPE");
               
                dataGridView1.DataSource = set.Tables["ENVELOPE"];
                


            }
            catch (Exception ex)

            {
                MessageBox.Show("Error in display data of envelope table");

            }
            finally
            {
                con.Close();
            }
        }

        private void btngetdatasaleinfo_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                
                string query1 = "SELECT * FROM SALEDETAILS";
                
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);

                DataSet set = new DataSet();
               
                adapter1.Fill(set, "SALEDETAILS");
               
                dataGridView2.DataSource = set.Tables["SALEDETAILS"];


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxEXIT_Click_1(object sender, EventArgs e)
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
    }
}
