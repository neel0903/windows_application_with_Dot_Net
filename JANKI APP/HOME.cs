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
using System.Threading;
using System.Data.SqlClient;
using System.Data;


namespace JANKI_APP
{
    public partial class HOME : Form

    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunat\source\repos\JANKI APP\JANKI APP\JANKIDATABASE.mdf;Integrated Security=True");

        Thread th;
       // SqlConnection con = new SqlConnection("@Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True");
      
        public HOME( )
        {
            InitializeComponent();
             
        }

        private void HOME_Load(object sender, EventArgs e)
        {
           


            flowLayoutPanel1.Hide();
            this.WindowState = FormWindowState.Maximized;

            DateTime dt = new DateTime();
           labeldate.Text = DateTime.Now.ToString("dd-MM-yyyy");
           // dateTimePicker1.Text = DateTime.DaysInMonth.ToString([0,6]);
           
            
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            INVOICE IN = new INVOICE();
            IN.Show();

            this.Hide();
        }

        private void btnchalan_Click(object sender, EventArgs e)
        {
            //this.Close();
            //th = new Thread(opennewform);
            //th.SetApartmentState(ApartmentState.SAT);
            //th
            CHALAN IN = new CHALAN();
            IN.Show();
            this.Hide();
            
        }

        private void btnsaleinfo_Click(object sender, EventArgs e)
        {
            SALEINFO IN = new SALEINFO();
            IN.Show();
            this.Hide();
        }

        private void btnstockinfo_Click(object sender, EventArgs e)
        {
            STOCKINFO IN = new STOCKINFO();
            IN.Show();
            this.Hide();
        }

        private void btnenvelope_Click(object sender, EventArgs e)
        {
            ENVELOPE_PRINTING IN = new ENVELOPE_PRINTING();
            IN.Show();
            this.Hide();

        }

        private void btnpaymentinfo_Click(object sender, EventArgs e)
        {
            PAYMENT_INFO IN = new PAYMENT_INFO();
            IN.Show();
            this.Hide();

        }

       
     

        private void btnminsized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(flowLayoutPanel1.Visible)
            {
                flowLayoutPanel1.Hide();
            }
            else
            {
                flowLayoutPanel1.Show();
            }
           
        }

        private void pictureBoxmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxexit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "EXIT", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            else 
                {
                
            }
                
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
         
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbhomedate_Click(object sender, EventArgs e)
        {

        }

        private void gradientpanelLefttoRight1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void gradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
