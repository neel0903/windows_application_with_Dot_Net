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
    public partial class SALEINFO : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
        public SALEINFO()
        {
            InitializeComponent();
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
        protected void FillCombobox()
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
            try
            {
                SqlCommand c1 = con.CreateCommand();
                string query1 = "SELECT CNAME FROM ENVELOPE";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "ENVELOPE");
                cbcto.DisplayMember = "CNAME";
                cbcto.DataSource = set1.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show("Error in fetching data from table saleinfo to combobox cto");
            }
            finally
            {
                con.Close();
            }
        }

        private void SALEINFO_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        private void btngetinfo_Click(object sender, EventArgs e)
        {
           
                try
                {
                    con.Open();
                    SqlCommand c = con.CreateCommand();
                    string query = "SELECT DATE,PRODUCT,CNAMETO,TRUCKNUM,BAGS,BILLNUM,RATE FROM SALEDETAILS WHERE  CNAMETO LIKE '" + cbcto.Text + "' AND PRODUCT LIKE '" + cbproduct.Text + "'   AND   DATE BETWEEN '" + dateTimePickerFROM.Text+ "' AND '" + dateTimePickerTO.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet set = new DataSet();
                    adapter.Fill(set, "SALEDETAILS");
                    dgvsaleinfo.DataSource = set.Tables["SALEDETAILS"];
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error ex ");

                }
                finally
                {

                }
            labnoofbags.Text = "0";
            labtrucks.Text = Convert.ToString(dgvsaleinfo.Rows.Count);
            //labelPRODUCT.Text = Convert.ToString(cbproduct1.SelectedItem);
            for (int i = 0; i < dgvsaleinfo.Rows.Count; i++)
            {
               // labelsalebags.Text = Convert.ToString(float.Parse(labelsalebags.Text) + float.Parse(dgvsale.Rows[j].Cells[2].Value.ToString()));
                labnoofbags.Text = Convert.ToString(float.Parse(labnoofbags.Text) + float.Parse(dgvsaleinfo.Rows[i].Cells[4].Value.ToString()));
            }
        }

    
        Bitmap bitmap;

        private void btnprint_Click(object sender, EventArgs e)
        {
            //printDocument1.DefaultPageSettings.Landscape = true;

            //Resize DataGridView to full height.
            int height = dgvsaleinfo.Height;
            dgvsaleinfo.Height = dgvsaleinfo.RowCount * dgvsaleinfo.RowTemplate.Height * 2;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(dgvsaleinfo.Width, dgvsaleinfo.Height);
            dgvsaleinfo.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvsaleinfo.Width, dgvsaleinfo.Height));

            //Resize DataGridView back to original height.
            dgvsaleinfo.Height = height;

            //Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black), 0, 70, 1000, 70);
            e.Graphics.DrawString("SALE INFORMATION" ,new  Font("Courier New", 30), new SolidBrush(Color.Black), 200, 20);
            e.Graphics.DrawString("COMPANY FROM:" + cbcfrom.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 10,100);
            e.Graphics.DrawString("COMPANY TO  :" + cbcto.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 10, 70);
            e.Graphics.DrawString("PRODUCT     :" + cbproduct.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 10, 130);

            e.Graphics.DrawString("DATE FROM:" + dateTimePickerFROM.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 530, 70);
            e.Graphics.DrawString("DATE TO  :" + dateTimePickerTO.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 530, 110);
            e.Graphics.DrawImage(bitmap, 0, 160);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labtrucks_Click(object sender, EventArgs e)
        {

        }

        private void cbcto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
