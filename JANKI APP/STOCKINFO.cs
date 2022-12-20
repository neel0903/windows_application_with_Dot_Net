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
    public partial class STOCKINFO : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");
        public STOCKINFO()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btngetinfo_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand c = con.CreateCommand();
                string query = "SELECT BILLNO,DATE,NAME,VILLAGE,PRODUCT,NOOFBAGS,RATE,PAIDAMOUNT FROM CHALAN1  WHERE PRODUCT LIKE '" + cbselectproduct.Text + "' AND DATE BETWEEN '" + dateTimePickerfrom.Text + "' AND '" + dateTimePickerto.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet set = new DataSet();
                adapter.Fill(set, "CHALAN1");
                dgvstockinfo.DataSource = set.Tables["CHALAN1"];


               
                con.Close();

            }


            catch (Exception ex )
            {

            }
            finally { }


            try
            {
                


                SqlCommand c1 = con.CreateCommand();
                string query1 = "SELECT DATE,PRODUCT,BAGS,CNAMETO,BILLNUM,RATE FROM SALEDETAILS  WHERE PRODUCT LIKE '" + cbselectproduct.Text + "' AND DATE BETWEEN '" + dateTimePickerfrom.Text + "' AND '" + dateTimePickerto.Text + "'";
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, con);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "SALEDETAILS");
                dgvsale.DataSource = set1.Tables["SALEDETAILS"];
                con.Close();

            }


            catch (Exception ex)
            {

            }
            finally { }


            labelnoofbags.Text = "0";
            labelsalebags.Text = "0";
            labelsalerate.Text = "0";
            label10.Text = "0";
           
            int count = dgvstockinfo.Rows.Count;
            int Count1 = dgvsale.Rows.Count;

            for (int j = 0; j < dgvsale.Rows.Count; j++)
            {

                labelsalebags.Text = Convert.ToString(float.Parse(labelsalebags.Text) + float.Parse(dgvsale.Rows[j].Cells[2].Value.ToString()));
                labelsalerate.Text = Convert.ToString(float.Parse(labelsalerate.Text) + float.Parse(dgvsale.Rows[j].Cells[5].Value.ToString()));

            }
            labelsalerate.Text = Convert.ToString(float.Parse(labelsalerate.Text) / Count1); 

            for (int i = 0; i < dgvstockinfo.Rows.Count; i++)
            {

                label10.Text = Convert.ToString(float.Parse(label10.Text) + float.Parse(dgvstockinfo.Rows[i].Cells[5].Value.ToString()));
            }
            labelnoofbags.Text = Convert.ToString(float.Parse(label10.Text )- float.Parse(labelsalebags.Text));
                        
               labelAVGRATE.Text = "0";
                for(int j =0;j<dgvstockinfo.Rows.Count;j++)
                {
                    labelAVGRATE.Text = Convert.ToString(float.Parse(labelAVGRATE.Text) + float.Parse(dgvstockinfo.Rows[j].Cells[6].Value.ToString()));
                }
                labelAVGRATE.Text = Convert.ToString(float.Parse(labelAVGRATE.Text) / count);
            
        }

        private void STOCKINFO_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        Bitmap bitmap;
       

        private void btnprint_Click(object sender, EventArgs e)
        {

            int height = dgvstockinfo.Height;
            dgvstockinfo.Height = dgvstockinfo.RowCount * dgvstockinfo.RowTemplate.Height * 2;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(dgvstockinfo.Width, dgvstockinfo.Height);
            dgvstockinfo.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvstockinfo.Width, dgvstockinfo.Height));

            //Resize DataGridView back to original height.
            dgvstockinfo.Height = height;

            //Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black), 0, 70, 1000, 70);
            e.Graphics.DrawString("STOCK INFORMATION", new Font("Courier New", 30), new SolidBrush(Color.Black), 200, 20);
            e.Graphics.DrawString("COMPANY FROM :" + cbselectproduct.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 10, 100);


            e.Graphics.DrawString("DATE FROM:" + dateTimePickerfrom.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 530, 70);
            e.Graphics.DrawString("DATE TO  :" + dateTimePickerto.Text, new Font("Courier New", 15), new SolidBrush(Color.Black), 530, 110);
            e.Graphics.DrawImage(bitmap, 0, 160);
           
        }

        private void btnexitstockinfo_Click(object sender, EventArgs e)
        {
            HOME IN = new HOME();

            this.Close();
            IN.Show();
            DialogResult confirm = MessageBox.Show("Confirm to Close", "Exit", MessageBoxButtons.YesNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME IN = new HOME();

            this.Close();
            IN.Show();

        }

        

        private void btnexit_Click(object sender, EventArgs e)
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

        private void btnhome_Click(object sender, EventArgs e)
        {
            HOME IN = new HOME();
            IN.Show();
            this.Close();
        }

        private void btnminimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxminimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxhome_Click(object sender, EventArgs e)
        {
            HOME IN = new HOME();
            IN.Show();
            this.Close();
        }

        private void pictureBoxexit_Click(object sender, EventArgs e)
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

       

        private void button3_Click(object sender, EventArgs e)
        {
            int height = dgvsale.Height;
            dgvsale.Height = dgvsale.RowCount * dgvsale.RowTemplate.Height * 2;

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(dgvsale.Width, dgvsale.Height);
            dgvsale.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvsale.Width, dgvsale.Height));

            //Resize DataGridView back to original height.
            dgvsale.Height = height;

            //Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog2.ShowDialog();
        }
    }

   
}
