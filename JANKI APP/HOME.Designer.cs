namespace JANKI_APP
{
    partial class HOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.saledetailsTableAdapter1 = new JANKI_APP.JANKIDATABASEDataSetTableAdapters.SALEDETAILSTableAdapter();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnsaleinfo = new System.Windows.Forms.Button();
            this.gradientPanel1 = new JANKI_APP.GradientPanel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnchalan = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btninvoice = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnenvelope = new System.Windows.Forms.Button();
            this.btnpaymentinfo = new System.Windows.Forms.Button();
            this.btnstockinfo = new System.Windows.Forms.Button();
            this.gradientPanel2 = new JANKI_APP.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gradientpanelLefttoRight1 = new JANKI_APP.GradientpanelLefttoRight();
            this.pictureBoxmini = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxexit = new System.Windows.Forms.PictureBox();
            this.gradientPanel3 = new JANKI_APP.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientpanelLefttoRight2 = new JANKI_APP.GradientpanelLefttoRight();
            this.labeldate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientpanelLefttoRight1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            this.gradientpanelLefttoRight2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Controls.Add(this.gradientPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(117, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(987, 1908);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.gradientPanel2);
            this.panel4.Controls.Add(this.gradientpanelLefttoRight1);
            this.panel4.Controls.Add(this.gradientPanel3);
            this.panel4.Controls.Add(this.gradientpanelLefttoRight2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3876, 2108);
            this.panel4.TabIndex = 15;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // saledetailsTableAdapter1
            // 
            this.saledetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // btnsaleinfo
            // 
            this.btnsaleinfo.BackColor = System.Drawing.Color.Transparent;
            this.btnsaleinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaleinfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsaleinfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsaleinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnsaleinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnsaleinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaleinfo.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaleinfo.ForeColor = System.Drawing.Color.White;
            this.btnsaleinfo.Location = new System.Drawing.Point(3, 799);
            this.btnsaleinfo.Name = "btnsaleinfo";
            this.btnsaleinfo.Size = new System.Drawing.Size(976, 156);
            this.btnsaleinfo.TabIndex = 4;
            this.btnsaleinfo.Text = "SALE INFO";
            this.btnsaleinfo.UseVisualStyleBackColor = false;
            this.btnsaleinfo.Click += new System.EventHandler(this.btnsaleinfo_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.pictureBox9);
            this.gradientPanel1.Controls.Add(this.pictureBox4);
            this.gradientPanel1.Controls.Add(this.pictureBox8);
            this.gradientPanel1.Controls.Add(this.btnchalan);
            this.gradientPanel1.Controls.Add(this.pictureBox7);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.pictureBox6);
            this.gradientPanel1.Controls.Add(this.btninvoice);
            this.gradientPanel1.Controls.Add(this.pictureBox5);
            this.gradientPanel1.Controls.Add(this.btnsaleinfo);
            this.gradientPanel1.Controls.Add(this.btnenvelope);
            this.gradientPanel1.Controls.Add(this.btnpaymentinfo);
            this.gradientPanel1.Controls.Add(this.btnstockinfo);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.SetFlowBreak(this.gradientPanel1, true);
            this.gradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(986, 1899);
            this.gradientPanel1.TabIndex = 8;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::JANKI_APP.Properties.Resources.export_data;
            this.pictureBox9.Location = new System.Drawing.Point(23, 1470);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(117, 113);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::JANKI_APP.Properties.Resources.bill_generator_1411704_1194193;
            this.pictureBox4.Location = new System.Drawing.Point(32, 657);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(117, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::JANKI_APP.Properties.Resources.envelope_printing;
            this.pictureBox8.Location = new System.Drawing.Point(23, 1306);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(117, 124);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // btnchalan
            // 
            this.btnchalan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnchalan.BackColor = System.Drawing.Color.Transparent;
            this.btnchalan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchalan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnchalan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnchalan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnchalan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnchalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchalan.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchalan.ForeColor = System.Drawing.Color.Transparent;
            this.btnchalan.Location = new System.Drawing.Point(3, 637);
            this.btnchalan.Name = "btnchalan";
            this.btnchalan.Size = new System.Drawing.Size(976, 156);
            this.btnchalan.TabIndex = 3;
            this.btnchalan.Text = "CHALAN";
            this.btnchalan.UseVisualStyleBackColor = false;
            this.btnchalan.Click += new System.EventHandler(this.btnchalan_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::JANKI_APP.Properties.Resources.payment_info;
            this.pictureBox7.Location = new System.Drawing.Point(32, 1144);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(117, 115);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 631);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::JANKI_APP.Properties.Resources.stock;
            this.pictureBox6.Location = new System.Drawing.Point(32, 979);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(117, 127);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // btninvoice
            // 
            this.btninvoice.BackColor = System.Drawing.Color.Transparent;
            this.btninvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninvoice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btninvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btninvoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btninvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btninvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninvoice.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvoice.ForeColor = System.Drawing.Color.White;
            this.btninvoice.Location = new System.Drawing.Point(3, 1447);
            this.btninvoice.Name = "btninvoice";
            this.btninvoice.Size = new System.Drawing.Size(976, 156);
            this.btninvoice.TabIndex = 2;
            this.btninvoice.Text = "EXPORT DATA";
            this.btninvoice.UseVisualStyleBackColor = false;
            this.btninvoice.Click += new System.EventHandler(this.btninvoice_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::JANKI_APP.Properties.Resources.saleinfo;
            this.pictureBox5.Location = new System.Drawing.Point(32, 814);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(117, 129);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // btnenvelope
            // 
            this.btnenvelope.BackColor = System.Drawing.Color.Transparent;
            this.btnenvelope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenvelope.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnenvelope.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnenvelope.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnenvelope.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnenvelope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenvelope.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenvelope.ForeColor = System.Drawing.Color.White;
            this.btnenvelope.Location = new System.Drawing.Point(3, 1285);
            this.btnenvelope.Name = "btnenvelope";
            this.btnenvelope.Size = new System.Drawing.Size(976, 156);
            this.btnenvelope.TabIndex = 6;
            this.btnenvelope.Text = "ENVELOPE PRINTING";
            this.btnenvelope.UseVisualStyleBackColor = false;
            this.btnenvelope.Click += new System.EventHandler(this.btnenvelope_Click);
            // 
            // btnpaymentinfo
            // 
            this.btnpaymentinfo.BackColor = System.Drawing.Color.Transparent;
            this.btnpaymentinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpaymentinfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnpaymentinfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnpaymentinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnpaymentinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnpaymentinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpaymentinfo.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaymentinfo.ForeColor = System.Drawing.Color.White;
            this.btnpaymentinfo.Location = new System.Drawing.Point(3, 1123);
            this.btnpaymentinfo.Name = "btnpaymentinfo";
            this.btnpaymentinfo.Size = new System.Drawing.Size(976, 156);
            this.btnpaymentinfo.TabIndex = 7;
            this.btnpaymentinfo.Text = "PAYMENT INFO";
            this.btnpaymentinfo.UseVisualStyleBackColor = false;
            this.btnpaymentinfo.Click += new System.EventHandler(this.btnpaymentinfo_Click);
            // 
            // btnstockinfo
            // 
            this.btnstockinfo.BackColor = System.Drawing.Color.Transparent;
            this.btnstockinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstockinfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnstockinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnstockinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnstockinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstockinfo.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockinfo.ForeColor = System.Drawing.Color.White;
            this.btnstockinfo.Location = new System.Drawing.Point(3, 961);
            this.btnstockinfo.Name = "btnstockinfo";
            this.btnstockinfo.Size = new System.Drawing.Size(976, 156);
            this.btnstockinfo.TabIndex = 5;
            this.btnstockinfo.Text = "STOCK INFO";
            this.btnstockinfo.UseVisualStyleBackColor = false;
            this.btnstockinfo.Click += new System.EventHandler(this.btnstockinfo_Click);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Controls.Add(this.pictureBox2);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 100);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(117, 1908);
            this.gradientPanel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 525);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gradientpanelLefttoRight1
            // 
            this.gradientpanelLefttoRight1.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.gradientpanelLefttoRight1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gradientpanelLefttoRight1.Controls.Add(this.pictureBoxmini);
            this.gradientpanelLefttoRight1.Controls.Add(this.pictureBox3);
            this.gradientpanelLefttoRight1.Controls.Add(this.pictureBoxexit);
            this.gradientpanelLefttoRight1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientpanelLefttoRight1.Location = new System.Drawing.Point(0, 0);
            this.gradientpanelLefttoRight1.Name = "gradientpanelLefttoRight1";
            this.gradientpanelLefttoRight1.Size = new System.Drawing.Size(3876, 100);
            this.gradientpanelLefttoRight1.TabIndex = 12;
            this.gradientpanelLefttoRight1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientpanelLefttoRight1_Paint);
            // 
            // pictureBoxmini
            // 
            this.pictureBoxmini.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxmini.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxmini.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxmini.Image")));
            this.pictureBoxmini.Location = new System.Drawing.Point(3674, 0);
            this.pictureBoxmini.Name = "pictureBoxmini";
            this.pictureBoxmini.Size = new System.Drawing.Size(102, 100);
            this.pictureBoxmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxmini.TabIndex = 3;
            this.pictureBoxmini.TabStop = false;
            this.pictureBoxmini.Click += new System.EventHandler(this.pictureBoxmini_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxexit
            // 
            this.pictureBoxexit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxexit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxexit.Image")));
            this.pictureBoxexit.Location = new System.Drawing.Point(3776, 0);
            this.pictureBoxexit.Name = "pictureBoxexit";
            this.pictureBoxexit.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxexit.TabIndex = 4;
            this.pictureBoxexit.TabStop = false;
            this.pictureBoxexit.Click += new System.EventHandler(this.pictureBoxexit_Click);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.gradientPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gradientPanel3.Controls.Add(this.label1);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 2008);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(3876, 100);
            this.gradientPanel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2820, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1056, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Design and develop by Neel Patel ";
            // 
            // gradientpanelLefttoRight2
            // 
            this.gradientpanelLefttoRight2.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(196)))), ((int)(((byte)(253)))));
            this.gradientpanelLefttoRight2.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(233)))), ((int)(((byte)(251)))));
            this.gradientpanelLefttoRight2.Controls.Add(this.labeldate);
            this.gradientpanelLefttoRight2.Controls.Add(this.label3);
            this.gradientpanelLefttoRight2.Controls.Add(this.label6);
            this.gradientpanelLefttoRight2.Controls.Add(this.label5);
            this.gradientpanelLefttoRight2.Controls.Add(this.label4);
            this.gradientpanelLefttoRight2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientpanelLefttoRight2.Location = new System.Drawing.Point(0, 0);
            this.gradientpanelLefttoRight2.Name = "gradientpanelLefttoRight2";
            this.gradientpanelLefttoRight2.Size = new System.Drawing.Size(3876, 2108);
            this.gradientpanelLefttoRight2.TabIndex = 17;
            // 
            // labeldate
            // 
            this.labeldate.BackColor = System.Drawing.Color.Transparent;
            this.labeldate.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.ForeColor = System.Drawing.Color.White;
            this.labeldate.Location = new System.Drawing.Point(3400, 139);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(416, 83);
            this.labeldate.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2607, 997);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 191);
            this.label3.TabIndex = 20;
            this.label3.Text = "janki";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3159, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 83);
            this.label6.TabIndex = 21;
            this.label6.Text = "DATE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2492, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(813, 191);
            this.label5.TabIndex = 20;
            this.label5.Text = "welcome";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2740, 719);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 191);
            this.label4.TabIndex = 20;
            this.label4.Text = "to";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // HOME
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CancelButton = this.btnsaleinfo;
            this.ClientSize = new System.Drawing.Size(3876, 2108);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HOME_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientpanelLefttoRight1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxexit)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            this.gradientpanelLefttoRight2.ResumeLayout(false);
            this.gradientpanelLefttoRight2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private GradientpanelLefttoRight gradientpanelLefttoRight1;
        private System.Windows.Forms.PictureBox pictureBoxmini;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxexit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnchalan;
        private System.Windows.Forms.Button btnpaymentinfo;
        private System.Windows.Forms.Button btnsaleinfo;
        private System.Windows.Forms.Button btnstockinfo;
        private System.Windows.Forms.Button btnenvelope;
        private System.Windows.Forms.Button btninvoice;
        private System.Windows.Forms.Panel panel4;
        private GradientPanel gradientPanel2;
        private GradientPanel gradientPanel3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labeldate;
        private JANKIDATABASEDataSetTableAdapters.SALEDETAILSTableAdapter saledetailsTableAdapter1;
        private System.Windows.Forms.Timer timer3;
        private GradientpanelLefttoRight gradientpanelLefttoRight2;
    }
}

