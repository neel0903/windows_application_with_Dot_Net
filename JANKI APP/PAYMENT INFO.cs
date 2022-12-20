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
    public partial class PAYMENT_INFO : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
        public PAYMENT_INFO()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT DATE,NAME,VILLAGE,PRODUCT,NOOFBAGS,RATE,PAIDAMOUNT FROM CHALAN1 WHERE PRODUCT LIKE '" + cbproduct1.Text + "'   AND DATE BETWEEN '" + dateTimePickerFROM.Text + "' AND '" + dateTimePickerTO.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                dgvpaymentinfo.DataSource = set.Tables["CHALAN1"];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error ex ");

            }
            finally
            {

            }
            labelamount.Text = "0";
            labnoofbags.Text = "0";
            labproduct1.Text = Convert.ToString(cbproduct1.Text);
            for (int i = 0; i < dgvpaymentinfo.Rows.Count-1; i++)
            {
             labelamount.Text = Convert.ToString(float.Parse(labelamount.Text) + float.Parse(dgvpaymentinfo.Rows[i].Cells[6].Value.ToString()));
             labnoofbags.Text = Convert.ToString(float.Parse(labnoofbags.Text) + float.Parse(dgvpaymentinfo.Rows[i].Cells[4].Value.ToString()));
            }


        }

        private void PAYMENT_INFO_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

           
        }

        private void tbsearchname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT BILLNO,DATE,NAME,VILLAGE,PRODUCT,NOOFBAGS,RATE,PAIDAMOUNT FROM CHALAN1  WHERE NAME LIKE '" + tbsearchname.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                dgvpaymentinfo.DataSource = set.Tables["CHALAN1"];
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
        Bitmap bitmap;
        private void btnprint_Click(object sender, EventArgs e)
        {
            //printDocument1.DefaultPageSettings.Landscape = true;

            //Resize DataGridView to full height.
            int height = dgvpaymentinfo.Height;
            dgvpaymentinfo.Height = dgvpaymentinfo.RowCount * dgvpaymentinfo.RowTemplate.Height *2;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(dgvpaymentinfo.Width, dgvpaymentinfo.Height);
            dgvpaymentinfo.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvpaymentinfo.Width, dgvpaymentinfo.Height));

            //Resize DataGridView back to original height.
            dgvpaymentinfo.Height = height;

            //Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawLine(new Pen(Color.Black), 0, 70, 1000, 70);
            e.Graphics.DrawString("PAYMENT INFORMATION", new Font("Courier New", 30), new SolidBrush(Color.Black), 200, 20);
            e.Graphics.DrawString("COMPANY FROM :" + labelPRODUCT.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 10, 100);
           

            e.Graphics.DrawString("DATE FROM:" + dateTimePickerFROM.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 530, 70);
            e.Graphics.DrawString("DATE TO  :" + dateTimePickerTO.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 530, 110);
            e.Graphics.DrawImage(bitmap, 0, 160);
           
        }

        private void pictureBoxexit_Click(object sender, EventArgs e)
        {
            DialogResult Confirm  = MessageBox.Show("Confirm to Close","EXIT",MessageBoxButtons.YesNo);
            if (Confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxhome_Click(object sender, EventArgs e)
        {
            HOME IN = new HOME();
            IN.Show();
            this.Close();
        }

       
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxnext_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxback_Click(object sender, EventArgs e)
        {
           

            }

        private void dgvpaymentinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labnoofbags_Click(object sender, EventArgs e)
        {

        }
    }
}

