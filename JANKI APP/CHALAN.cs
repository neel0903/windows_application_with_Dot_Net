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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;

namespace JANKI_APP
{
   
    public partial class CHALAN : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
        double bags, bachku, netwegibag, totwegi, wegiloss, rate, amo, advamo, paidamo, ratecal, weigcal;
        private SqlCommandBuilder builder;

        public CHALAN()
        {
            InitializeComponent();
            //this.TopMost = true;
           // this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //this.WindowState = FormWindowState.Maximized;
        }
        public void GetBillNo()
        {


                string billno;
                string query = "SELECT BILLNO FROM CHALAN1 ORDER BY BILLNO DESC";
               
                    con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int i = Convert.ToInt32((dr[0].ToString())) + 1;
                    billno = i.ToString();

                }
                else if (Convert.IsDBNull(dr))
                {
                    billno = "1";

                }
                else
                {
                    billno = "1";
                }
            
           
                con.Close();
                tbbillno.Text = billno.ToString();
        }
        private void btnchalanprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnchalanprintreview_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.ShowDialog();
        }
        private void printDocumentchalan_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 12);
            graphics.DrawLine(new Pen(Color.Black), 30, 47, 800, 47);
            graphics.DrawLine(new Pen(Color.Black), 30, 47, 30, 420);
            graphics.DrawLine(new Pen(Color.Black), 30, 420, 800, 420);
            graphics.DrawLine(new Pen(Color.Black), 800, 420, 800, 47);
            graphics.DrawLine(new Pen(Color.Black), 30, 77, 800, 77);
            graphics.DrawLine(new Pen(Color.Black), 30, 107, 800, 107);
            graphics.DrawLine(new Pen(Color.Black), 30, 137, 800, 137);
            graphics.DrawLine(new Pen(Color.Black), 30, 167, 800, 167);
            graphics.DrawLine(new Pen(Color.Black), 30, 197, 800, 197);
            graphics.DrawLine(new Pen(Color.Black), 30, 228, 800, 228);
            graphics.DrawLine(new Pen(Color.Black), 30, 257, 800, 257);
            graphics.DrawLine(new Pen(Color.Black), 30, 287, 800, 287);
            graphics.DrawLine(new Pen(Color.Black), 30, 317, 800, 317);
            graphics.DrawLine(new Pen(Color.Black), 30, 347, 800, 347);
            graphics.DrawLine(new Pen(Color.Black), 30, 377, 800, 377);
            graphics.DrawLine(new Pen(Color.Black), 242, 47, 242, 419);


            graphics.DrawString("DATE:" + dateTimePicker1.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 530, 20);
            graphics.DrawString("       NAME " +" "+ tbname.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 50);
            graphics.DrawString("    VILLAGE " +" " +tbvillage.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 80);
            graphics.DrawString("    PRODUCT " +" " +tbproduct.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 110);
            graphics.DrawString("       BAGS " +" " +tbbags.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 140);
            graphics.DrawString("     BACHKU " +" "+tbbachku.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 170);

            graphics.DrawString(" WEIGHT/BAG " +" " +tbnetweigofbag.Text + "kg", new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 200);
            graphics.DrawString(labelweigloss.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 350, 230);
            graphics.DrawString("WEIGHT LOSS " +" " +tbweigloss.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 230);
            graphics.DrawString(" NET WEIGTH " +" " +tbnetweig.Text + "Kg", new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 260);
            graphics.DrawString("       RATE " +" "+ tbrate.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 290);
            graphics.DrawString(labelrate.Text, new Font("Courier New", 20), new SolidBrush(Color.Black), 350, 290);
            graphics.DrawString("     AMOUNT " +" "+ tbamount.Text + "Rs", new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 320);
            graphics.DrawString("    ADVANCE " +" "+ tbadvance.Text + "Rs", new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 350);
            graphics.DrawString("PAID AMOUNT " +" "+ tbpaidamount.Text + "Rs", new Font("Courier New", 20), new SolidBrush(Color.Black), 30, 380);
        }

       

      

       

       

        private void tbsearchname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT *FROM CHALAN1  WHERE NAME LIKE '" + tbsearchname.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                dataGridView1.DataSource = set.Tables["CHALAN1"];
                con.Close();
            }
            catch(Exception ex )
            {
                MessageBox.Show("error ex ");

            }
            finally
            {

            }


        }

        private void tbsearchvillage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT *FROM CHALAN1  WHERE VILLAGE LIKE '" + tbsearchvillage.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                dataGridView1.DataSource = set.Tables["CHALAN1"];
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

        private void tbsearchproduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT *FROM CHALAN1  WHERE PRODUCT LIKE '" + tbsearchproduct.Text + "%'";
                 SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                //DataSet set = new DataSet();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbbillno.Text = row.Cells["BILLNO"].Value.ToString();
                //dateTimePicker1.Text = row.Cells["DATE"].Value.ToString();
                tbname.Text = row.Cells["NAME"].Value.ToString();
                tbvillage.Text =row.Cells["VILLAGE"].Value.ToString();
                tbproduct.Text= row.Cells["PRODUCT"].Value.ToString();
                tbbags.Text=row.Cells["NOOFBAGS"].Value.ToString();
                tbnetweigofbag.Text=row.Cells["NETWEIGOFBAG"].Value.ToString();
                tbbachku.Text =row.Cells["BACHKU"].Value.ToString();
                tbtotweig.Text =row.Cells["TOTALWEIGHT"].Value.ToString();
                tbweigloss.Text =row.Cells["WEIGHTLOSS"].Value.ToString();
                tbnetweig.Text = row.Cells["NETWEIG"].Value.ToString();
                tbrate.Text =row.Cells["RATE"].Value.ToString();
                tbamount.Text =row.Cells["AMOUNT"].Value.ToString();
                tbadvance.Text = row.Cells["ADVANCE"].Value.ToString();
                tbpaidamount.Text = row.Cells["PAIDAMOUNT"].Value.ToString() ;
            }
        }

        private void tbbags_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl (e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void tbbachku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.' && tbbachku.Text.IndexOf('.') > -1)
            {       
                e.Handled = true;

             }
            

        }

        private void tbnetweigofbag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.' && tbnetweigofbag.Text.IndexOf('.') >-1)
            {
                e.Handled = true;
            }
        }

        private void tbtotweig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar =='.' && tbtotweig.Text.IndexOf('.') >-1)

            {
                e.Handled = true;
            }
        }

        private void tbweigloss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.' && tbweigloss.Text.IndexOf('.') > -1)

            {
                e.Handled = true;
            }
        }

        private void tbnetweig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.' && tbnetweig.Text.IndexOf('.') > -1)

            {
                e.Handled = true;
            }
        }

        private void tbrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.' && tbrate.Text.IndexOf('.') > -1)

            {
                e.Handled = true;
            }
        }

        private void tbamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.' && tbamount.Text.IndexOf('.') > -1)

            {
                e.Handled = true;
            }
        }

        private void tbadvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )

            {
                e.Handled = true;
            }
        }

        private void tbpaidamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.' && tbpaidamount.Text.IndexOf('.') > -1)

            {
                e.Handled = true;
            }
        }

        private void btnchalanreset_Click(object sender, EventArgs e)
        {
            GetBillNo();
            tbname.Text = " ";
            tbvillage.Text = " ";
            tbproduct.Text = " ";
            tbbags.Text = " ";
            tbnetweigofbag.Text = "";
            tbbachku.Text = " ";
            tbtotweig.Text = " ";
            tbweigloss.Text = " ";
            tbrate.Text = " ";
            tbamount.Text = " ";
            tbadvance.Text = " ";
            tbpaidamount.Text = " ";
            tbnetweig.Text = " ";
        }

      

        private void tbbillno_TextChanged(object sender, EventArgs e)
        {

        }

        

       

        private void pictureBoxHOME_Click(object sender, EventArgs e)
        {
            HOME IN = new HOME();
            IN.Show();
            this.Close();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT *FROM CHALAN1  WHERE VILLAGE LIKE '" + tbsearchvillage.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = tb;

                dataGridView1.DataSource = bSource;
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

        private void pictureBoxEXIT_Click(object sender, EventArgs e)
        {
            DialogResult Confirm = MessageBox.Show("Confirm to close", "EXIT", MessageBoxButtons.YesNo);
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

       

      

        private void gbchalan3_Enter(object sender, EventArgs e)
        {

        }

      

        private void btnchalansave_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                SqlCommand c = con.CreateCommand();
                
                string query = "SELECT * FROM CHALAN1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                DataRow row = set.Tables["CHALAN1"].NewRow();
                row["BILLNO"] = tbbillno.Text;
                row["NAME"] = tbname.Text;
                row["VILLAGE"] = tbvillage.Text;
                row["PRODUCT"] = tbproduct.Text;
                row["NOOFBAGS"] = tbbags.Text;
                row["NETWEIGOFBAG"] = tbnetweigofbag.Text;
                row["BACHKU"] = tbbachku.Text;
                row["TOTALWEIGHT"] = tbtotweig.Text;
                row["WEIGHTLOSS"] = tbweigloss.Text;
                row["NETWEIG"] = tbnetweig.Text;
                row["RATE"] = tbrate.Text;
                row["AMOUNT"] = tbamount.Text;
                row["ADVANCE"] = tbadvance.Text;
                row["PAIDAMOUNT"] = tbpaidamount.Text;
                row["DATE"] = dateTimePicker1.Text;
                set.Tables["CHALAN1"].Rows.Add(row);
                
                dataGridView1.DataSource = set.Tables["CHALAN1"];
                
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables["CHALAN1"]);
                MessageBox.Show("Date Save Sucessfully in Database");


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

        private void CHALAN_Load(object sender, EventArgs e)
        {
            GetBillNo();
            this.WindowState = FormWindowState.Maximized;
            DateTime dt = new DateTime();
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void btnchalangetdata_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand c = con.CreateCommand();
                
                string query = "SELECT * FROM CHALAN1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                dataGridView1.DataSource = set.Tables["CHALAN1"];
                

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

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                
                string query = "SELECT * FROM CHALAN1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["BILLNO"] = tbbillno.Text;
               
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["NAME"] = tbname.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["VILLAGE"] = tbvillage.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["PRODUCT"] = tbproduct.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["NOOFBAGS"] = tbbags.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["NETWEIGOFBAG"] = tbnetweigofbag.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["BACHKU"] = tbbachku.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["TOTALWEIGHT"] = tbtotweig.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["WEIGHTLOSS"] = tbweigloss.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["NETWEIG"] = tbnetweig.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["RATE"] = tbrate.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["AMOUNT"] = tbamount.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["ADVANCE"] = tbadvance.Text;
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index]["PAIDAMOUNT"] = tbpaidamount.Text;




                dataGridView1.DataSource = set.Tables["CHALAN1"];
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables["CHALAN1"]);
               
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand c = con.CreateCommand();
                
                string query = "SELECT * FROM CHALAN1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                set.Tables["CHALAN1"].Rows[dataGridView1.SelectedRows[0].Index].Delete();

                dataGridView1.DataSource = set.Tables["CHALAN1"];
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(set.Tables["CHALAN1"]);
                MessageBox.Show("Dataset saved to database Sucessfully");

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

        

        

        private void btncal_Click(object sender, EventArgs e)
        {
           

            if(tbproduct.SelectedItem == "CASTOR SEEDS")
            {

                bags = Convert.ToDouble(tbbags.Text);
                bachku = Convert.ToDouble(tbbachku.Text);
                netwegibag = Convert.ToDouble(tbnetweigofbag.Text);
                //totwegi = Convert.ToDouble(tbtotweig.Text);
                wegiloss = Convert.ToDouble(tbweigloss.Text);
                rate = Convert.ToDouble(tbrate.Text);
                //amo = Convert.ToDouble(tbamount.Text);
                advamo = Convert.ToDouble(tbadvance.Text);
                //paidamo = Convert.ToDouble(tbadvance.Text);

                ratecal = (rate / 20);
                totwegi = ((bags * netwegibag) + bachku);
                weigcal = (totwegi - ((wegiloss*totwegi)/netwegibag));
                amo = (weigcal * ratecal);
                paidamo = amo - advamo;
                tbnetweig.Text = weigcal.ToString("0.00");
                tbtotweig.Text = totwegi.ToString("0.00");
                tbamount.Text = amo.ToString("0.00");
                tbpaidamount.Text = paidamo.ToString("0.00");

            }
           
            
           else if (tbproduct.SelectedItem == "PADDY")
            {
                bags = Convert.ToDouble(tbbags.Text);
                bachku = Convert.ToDouble(tbbachku.Text);
                netwegibag = Convert.ToDouble(tbnetweigofbag.Text);
                //totwegi = Convert.ToDouble(tbtotweig.Text);
                wegiloss = Convert.ToDouble(tbweigloss.Text);
                rate = Convert.ToDouble(tbrate.Text);
                //amo = Convert.ToDouble(tbamount.Text);
                advamo = Convert.ToDouble(tbadvance.Text);
                //paidamo = Convert.ToDouble(tbadvance.Text);

                ratecal = (rate / 300);
                totwegi = ((bags * netwegibag) + bachku);
                weigcal = (totwegi -((wegiloss * totwegi)/netwegibag));
                amo = (weigcal * ratecal);
                paidamo = amo - advamo;
                tbnetweig.Text = weigcal.ToString("0.00");
                tbtotweig.Text = totwegi.ToString("0.00");
                tbamount.Text = amo.ToString("0.00");
                tbpaidamount.Text = paidamo.ToString("0.00");
            }
            else
            {
                bags = Convert.ToDouble(tbbags.Text);
                bachku = Convert.ToDouble(tbbachku.Text);
                netwegibag = Convert.ToDouble(tbnetweigofbag.Text);
                //totwegi = Convert.ToDouble(tbtotweig.Text);
                wegiloss = Convert.ToDouble(tbweigloss.Text);
                rate = Convert.ToDouble(tbrate.Text);
                //amo = Convert.ToDouble(tbamount.Text);
                advamo = Convert.ToDouble(tbadvance.Text);
                //paidamo = Convert.ToDouble(tbadvance.Text);

                ratecal = (rate / 100);
                totwegi = ((bags * netwegibag) + bachku);
                weigcal = (totwegi - ((wegiloss * totwegi)/netwegibag));
                amo = (weigcal * ratecal);
                paidamo = amo - advamo;
                tbnetweig.Text = weigcal.ToString("0.00");
                tbtotweig.Text = totwegi.ToString("0.00");
                tbamount.Text = amo.ToString("0.00");
                tbpaidamount.Text = paidamo.ToString("0.00");
            }

           

        }

        private void tbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbproduct.SelectedItem == "CASTOR SEEDS")
            {
                
                labelrate.Text = "!!PER 20KG";
                labelweigloss.Text = "!!( માટી per bag )";
                labelbachku.Text = "!!ENTER NET WEIGHT ";

                tbbachku.Text = "0";
                tbnetweigofbag.Text = "74";
                tbweigloss.Text = "0";
                tbadvance.Text = "0";


            }
            
           else if (tbproduct.SelectedItem == "PADDY")
            {
                labelrate.Text = "!!PER 300KG";
                labelweigloss.Text = "!!(ફાફડા per bag )";
                labelbachku.Text = "!!ENTER NET WEIGHT ";

                tbbachku.Text = "0";
                tbnetweigofbag.Text = "70";
                tbweigloss.Text = "0";
                tbadvance.Text = "0";

               

            }
            else
            {
                labelrate.Text = "!!PER 100KG";
                labelweigloss.Text = "!!( per bag )";
                labelbachku.Text = "!!ENTER NET WEIGHT ";

                tbbachku.Text = "0";
                tbnetweigofbag.Text = "49.4";
                tbweigloss.Text = "0";
                tbadvance.Text = "0";
            }
             
            //else
            //{
              //  MessageBox.Show("Select or write Product name");
            //}
        }
    }
}
