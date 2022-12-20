namespace JANKI_APP
{
    partial class SALEINFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SALEINFO));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbcfrom = new System.Windows.Forms.ComboBox();
            this.cbcto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gradientPanel1 = new JANKI_APP.GradientPanel();
            this.labtrucks = new System.Windows.Forms.Label();
            this.labnoofbags = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labnooftrucks = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btngetinfo = new System.Windows.Forms.Button();
            this.dateTimePickerTO = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFROM = new System.Windows.Forms.DateTimePicker();
            this.cbproduct = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.dgvsaleinfo = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gradientPanel3 = new JANKI_APP.GradientPanel();
            this.pictureBoxHOME = new System.Windows.Forms.PictureBox();
            this.pictureBoxMINI = new System.Windows.Forms.PictureBox();
            this.pictureBoxEXIT = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new JANKI_APP.GradientPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleinfo)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHOME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMINI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(174, 982);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // cbcfrom
            // 
            this.cbcfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cbcfrom.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcfrom.ForeColor = System.Drawing.Color.White;
            this.cbcfrom.FormattingEnabled = true;
            this.cbcfrom.Items.AddRange(new object[] {
            "JANKI RICE MILL\t",
            "JANKI AGRO PROCESSING"});
            this.cbcfrom.Location = new System.Drawing.Point(795, 82);
            this.cbcfrom.Name = "cbcfrom";
            this.cbcfrom.Size = new System.Drawing.Size(598, 89);
            this.cbcfrom.TabIndex = 0;
            // 
            // cbcto
            // 
            this.cbcto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cbcto.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcto.ForeColor = System.Drawing.Color.White;
            this.cbcto.FormattingEnabled = true;
            this.cbcto.Location = new System.Drawing.Point(795, 208);
            this.cbcto.Name = "cbcto";
            this.cbcto.Size = new System.Drawing.Size(598, 89);
            this.cbcto.TabIndex = 0;
            this.cbcto.SelectedIndexChanged += new System.EventHandler(this.cbcto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "COMPANY FROM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(497, 83);
            this.label3.TabIndex = 1;
            this.label3.Text = "COMPANY TO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(595, 83);
            this.label4.TabIndex = 1;
            this.label4.Text = "SELECT PRODUCT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 669);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 83);
            this.label5.TabIndex = 1;
            this.label5.Text = "TO DATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(413, 83);
            this.label6.TabIndex = 1;
            this.label6.Text = "FROM DATE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gradientPanel1);
            this.groupBox1.Controls.Add(this.btngetinfo);
            this.groupBox1.Controls.Add(this.dateTimePickerTO);
            this.groupBox1.Controls.Add(this.dateTimePickerFROM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbproduct);
            this.groupBox1.Controls.Add(this.cbcto);
            this.groupBox1.Controls.Add(this.cbcfrom);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1615, 1996);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(172)))), ((int)(((byte)(168)))));
            this.gradientPanel1.Controls.Add(this.labtrucks);
            this.gradientPanel1.Controls.Add(this.labnoofbags);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.labnooftrucks);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Location = new System.Drawing.Point(73, 806);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1455, 695);
            this.gradientPanel1.TabIndex = 4;
            // 
            // labtrucks
            // 
            this.labtrucks.BackColor = System.Drawing.Color.Transparent;
            this.labtrucks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labtrucks.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtrucks.ForeColor = System.Drawing.Color.White;
            this.labtrucks.Location = new System.Drawing.Point(663, 401);
            this.labtrucks.Name = "labtrucks";
            this.labtrucks.Size = new System.Drawing.Size(471, 83);
            this.labtrucks.TabIndex = 1;
            this.labtrucks.Click += new System.EventHandler(this.labtrucks_Click);
            // 
            // labnoofbags
            // 
            this.labnoofbags.BackColor = System.Drawing.Color.Transparent;
            this.labnoofbags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labnoofbags.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnoofbags.ForeColor = System.Drawing.Color.White;
            this.labnoofbags.Location = new System.Drawing.Point(663, 228);
            this.labnoofbags.Name = "labnoofbags";
            this.labnoofbags.Size = new System.Drawing.Size(471, 83);
            this.labnoofbags.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(99, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(471, 83);
            this.label7.TabIndex = 1;
            this.label7.Text = "NO OF BAGS:";
            // 
            // labnooftrucks
            // 
            this.labnooftrucks.AutoSize = true;
            this.labnooftrucks.BackColor = System.Drawing.Color.Transparent;
            this.labnooftrucks.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnooftrucks.ForeColor = System.Drawing.Color.White;
            this.labnooftrucks.Location = new System.Drawing.Point(608, 377);
            this.labnooftrucks.Name = "labnooftrucks";
            this.labnooftrucks.Size = new System.Drawing.Size(0, 83);
            this.labnooftrucks.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(87, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 83);
            this.label8.TabIndex = 1;
            this.label8.Text = "NO OF TRUCKS:";
            // 
            // btngetinfo
            // 
            this.btngetinfo.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btngetinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btngetinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btngetinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngetinfo.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetinfo.ForeColor = System.Drawing.Color.White;
            this.btngetinfo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btngetinfo.Location = new System.Drawing.Point(522, 1634);
            this.btngetinfo.Name = "btngetinfo";
            this.btngetinfo.Size = new System.Drawing.Size(481, 134);
            this.btngetinfo.TabIndex = 3;
            this.btngetinfo.Text = "GET INFO";
            this.btngetinfo.UseVisualStyleBackColor = true;
            this.btngetinfo.Click += new System.EventHandler(this.btngetinfo_Click);
            // 
            // dateTimePickerTO
            // 
            this.dateTimePickerTO.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTO.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTO.Location = new System.Drawing.Point(795, 653);
            this.dateTimePickerTO.Name = "dateTimePickerTO";
            this.dateTimePickerTO.Size = new System.Drawing.Size(601, 90);
            this.dateTimePickerTO.TabIndex = 2;
            // 
            // dateTimePickerFROM
            // 
            this.dateTimePickerFROM.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFROM.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFROM.Location = new System.Drawing.Point(795, 516);
            this.dateTimePickerFROM.Name = "dateTimePickerFROM";
            this.dateTimePickerFROM.Size = new System.Drawing.Size(601, 90);
            this.dateTimePickerFROM.TabIndex = 2;
            // 
            // cbproduct
            // 
            this.cbproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cbproduct.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbproduct.ForeColor = System.Drawing.Color.White;
            this.cbproduct.FormattingEnabled = true;
            this.cbproduct.Items.AddRange(new object[] {
            "CASTOR SEEDS",
            "MAKAI",
            "PADDY",
            "SOYABEN",
            "MATT",
            "TOOR",
            "VAL",
            "CHANA",
            "MUNG (GREEN GRAM)",
            "MUNG (BLACK GRAM)"});
            this.cbproduct.Location = new System.Drawing.Point(795, 360);
            this.cbproduct.Name = "cbproduct";
            this.cbproduct.Size = new System.Drawing.Size(598, 89);
            this.cbproduct.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnprint);
            this.groupBox2.Controls.Add(this.dgvsaleinfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(1621, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2255, 1996);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnprint
            // 
            this.btnprint.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btnprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(1851, 1610);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(362, 141);
            this.btnprint.TabIndex = 1;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // dgvsaleinfo
            // 
            this.dgvsaleinfo.AllowUserToAddRows = false;
            this.dgvsaleinfo.AllowUserToDeleteRows = false;
            this.dgvsaleinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsaleinfo.Location = new System.Drawing.Point(24, 280);
            this.dgvsaleinfo.Name = "dgvsaleinfo";
            this.dgvsaleinfo.ReadOnly = true;
            this.dgvsaleinfo.RowHeadersWidth = 102;
            this.dgvsaleinfo.RowTemplate.Height = 40;
            this.dgvsaleinfo.Size = new System.Drawing.Size(2189, 1288);
            this.dgvsaleinfo.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.gradientPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gradientPanel3.Controls.Add(this.pictureBoxHOME);
            this.gradientPanel3.Controls.Add(this.pictureBoxMINI);
            this.gradientPanel3.Controls.Add(this.pictureBoxEXIT);
            this.gradientPanel3.Controls.Add(this.pictureBox4);
            this.gradientPanel3.Controls.Add(this.label1);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(3876, 100);
            this.gradientPanel3.TabIndex = 7;
            // 
            // pictureBoxHOME
            // 
            this.pictureBoxHOME.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHOME.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxHOME.Image = global::JANKI_APP.Properties.Resources.c96eaf4f09b3881c0d35e986e964c268;
            this.pictureBoxHOME.Location = new System.Drawing.Point(3565, 0);
            this.pictureBoxHOME.Name = "pictureBoxHOME";
            this.pictureBoxHOME.Size = new System.Drawing.Size(102, 100);
            this.pictureBoxHOME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHOME.TabIndex = 2;
            this.pictureBoxHOME.TabStop = false;
            this.pictureBoxHOME.Click += new System.EventHandler(this.pictureBoxHOME_Click);
            // 
            // pictureBoxMINI
            // 
            this.pictureBoxMINI.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMINI.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMINI.Image = global::JANKI_APP.Properties.Resources.minimize_icon_29;
            this.pictureBoxMINI.Location = new System.Drawing.Point(3667, 0);
            this.pictureBoxMINI.Name = "pictureBoxMINI";
            this.pictureBoxMINI.Size = new System.Drawing.Size(103, 100);
            this.pictureBoxMINI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMINI.TabIndex = 1;
            this.pictureBoxMINI.TabStop = false;
            this.pictureBoxMINI.Click += new System.EventHandler(this.pictureBoxMINI_Click);
            // 
            // pictureBoxEXIT
            // 
            this.pictureBoxEXIT.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEXIT.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxEXIT.Image = global::JANKI_APP.Properties.Resources.Close_512;
            this.pictureBoxEXIT.Location = new System.Drawing.Point(3770, 0);
            this.pictureBoxEXIT.Name = "pictureBoxEXIT";
            this.pictureBoxEXIT.Size = new System.Drawing.Size(106, 100);
            this.pictureBoxEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEXIT.TabIndex = 0;
            this.pictureBoxEXIT.TabStop = false;
            this.pictureBoxEXIT.Click += new System.EventHandler(this.pictureBoxEXIT_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = global::JANKI_APP.Properties.Resources.JANKI_LOGO;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(99, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALE INFORMATION";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.gradientPanel2.Controls.Add(this.label9);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 2096);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(3876, 100);
            this.gradientPanel2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2840, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1036, 74);
            this.label9.TabIndex = 0;
            this.label9.Text = "Design and Develop By Neel Patel";
            // 
            // SALEINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(3876, 2196);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.gradientPanel3);
            this.Controls.Add(this.gradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SALEINFO";
            this.Text = "SALEINFO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SALEINFO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleinfo)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHOME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMINI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxEXIT;
        private System.Windows.Forms.PictureBox pictureBoxMINI;
        private System.Windows.Forms.PictureBox pictureBoxHOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cbcfrom;
        private System.Windows.Forms.ComboBox cbcto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTO;
        private System.Windows.Forms.DateTimePicker dateTimePickerFROM;
        private System.Windows.Forms.ComboBox cbproduct;
        private System.Windows.Forms.Button btngetinfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvsaleinfo;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label labtrucks;
        private System.Windows.Forms.Label labnoofbags;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labnooftrucks;
        private System.Windows.Forms.Label label8;
        private GradientPanel gradientPanel3;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Label label9;
    }
}