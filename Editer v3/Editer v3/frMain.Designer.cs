namespace Editer_v3
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.listin = new System.Windows.Forms.ListView();
            this.cl1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listout = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbox = new System.Windows.Forms.GroupBox();
            this.txttitile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cban = new System.Windows.Forms.CheckBox();
            this.txtdachay = new System.Windows.Forms.TextBox();
            this.lbvideotong = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.lbpro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEncoder = new System.Windows.Forms.TextBox();
            this.txtlanguage = new System.Windows.Forms.TextBox();
            this.txtcopy = new System.Windows.Forms.TextBox();
            this.txtencode = new System.Windows.Forms.TextBox();
            this.txtpub = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtspeed = new System.Windows.Forms.TextBox();
            this.tcuoi = new System.Windows.Forms.TextBox();
            this.tdau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbox2 = new System.Windows.Forms.GroupBox();
            this.txtcmd = new System.Windows.Forms.TextBox();
            this.btndelete1 = new System.Windows.Forms.Button();
            this.btndelete2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.txtxuat = new System.Windows.Forms.TextBox();
            this.btnlock = new System.Windows.Forms.Button();
            this.tientrinh = new System.Windows.Forms.Timer(this.components);
            this.pcrun = new System.Windows.Forms.PictureBox();
            this.grbox.SuspendLayout();
            this.grbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrun)).BeginInit();
            this.SuspendLayout();
            // 
            // listin
            // 
            this.listin.BackColor = System.Drawing.SystemColors.WindowText;
            this.listin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl1,
            this.cl2});
            this.listin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listin.FullRowSelect = true;
            this.listin.Location = new System.Drawing.Point(12, -1);
            this.listin.Name = "listin";
            this.listin.Size = new System.Drawing.Size(481, 148);
            this.listin.TabIndex = 0;
            this.listin.UseCompatibleStateImageBehavior = false;
            this.listin.View = System.Windows.Forms.View.Details;
            // 
            // cl1
            // 
            this.cl1.Text = "Video";
            this.cl1.Width = 383;
            // 
            // cl2
            // 
            this.cl2.Text = "Times";
            this.cl2.Width = 85;
            // 
            // listout
            // 
            this.listout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listout.Location = new System.Drawing.Point(499, -1);
            this.listout.Name = "listout";
            this.listout.Size = new System.Drawing.Size(475, 148);
            this.listout.TabIndex = 1;
            this.listout.UseCompatibleStateImageBehavior = false;
            this.listout.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Video";
            this.columnHeader1.Width = 361;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Times";
            this.columnHeader2.Width = 85;
            // 
            // grbox
            // 
            this.grbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grbox.Controls.Add(this.txttitile);
            this.grbox.Controls.Add(this.label4);
            this.grbox.Controls.Add(this.label13);
            this.grbox.Controls.Add(this.textBox1);
            this.grbox.Controls.Add(this.label14);
            this.grbox.Controls.Add(this.cban);
            this.grbox.Controls.Add(this.txtdachay);
            this.grbox.Controls.Add(this.lbvideotong);
            this.grbox.Controls.Add(this.label12);
            this.grbox.Controls.Add(this.txtso);
            this.grbox.Controls.Add(this.lbpro);
            this.grbox.Controls.Add(this.label11);
            this.grbox.Controls.Add(this.txtEncoder);
            this.grbox.Controls.Add(this.txtlanguage);
            this.grbox.Controls.Add(this.txtcopy);
            this.grbox.Controls.Add(this.txtencode);
            this.grbox.Controls.Add(this.txtpub);
            this.grbox.Controls.Add(this.txtdate);
            this.grbox.Controls.Add(this.label10);
            this.grbox.Controls.Add(this.label9);
            this.grbox.Controls.Add(this.label8);
            this.grbox.Controls.Add(this.label7);
            this.grbox.Controls.Add(this.label6);
            this.grbox.Controls.Add(this.label5);
            this.grbox.Controls.Add(this.txtspeed);
            this.grbox.Controls.Add(this.tcuoi);
            this.grbox.Controls.Add(this.tdau);
            this.grbox.Controls.Add(this.label3);
            this.grbox.Controls.Add(this.label2);
            this.grbox.Controls.Add(this.label1);
            this.grbox.ForeColor = System.Drawing.Color.Cornsilk;
            this.grbox.Location = new System.Drawing.Point(32, 175);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(942, 210);
            this.grbox.TabIndex = 2;
            this.grbox.TabStop = false;
            this.grbox.Text = "Mô tả";
            // 
            // txttitile
            // 
            this.txttitile.Location = new System.Drawing.Point(88, 52);
            this.txttitile.Name = "txttitile";
            this.txttitile.Size = new System.Drawing.Size(206, 20);
            this.txttitile.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Titile";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(853, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "/100";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(777, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "115";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Aqua;
            this.label14.Location = new System.Drawing.Point(734, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Zoom";
            // 
            // cban
            // 
            this.cban.AutoSize = true;
            this.cban.Location = new System.Drawing.Point(721, 89);
            this.cban.Name = "cban";
            this.cban.Size = new System.Drawing.Size(82, 17);
            this.cban.TabIndex = 27;
            this.cban.TabStop = false;
            this.cban.Text = "Ẩn tiến trình";
            this.cban.UseVisualStyleBackColor = true;
            // 
            // txtdachay
            // 
            this.txtdachay.Location = new System.Drawing.Point(700, 129);
            this.txtdachay.Name = "txtdachay";
            this.txtdachay.Size = new System.Drawing.Size(65, 20);
            this.txtdachay.TabIndex = 26;
            this.txtdachay.Text = "0";
            // 
            // lbvideotong
            // 
            this.lbvideotong.AutoSize = true;
            this.lbvideotong.ForeColor = System.Drawing.Color.Aqua;
            this.lbvideotong.Location = new System.Drawing.Point(769, 133);
            this.lbvideotong.Name = "lbvideotong";
            this.lbvideotong.Size = new System.Drawing.Size(52, 13);
            this.lbvideotong.TabIndex = 25;
            this.lbvideotong.Text = "/số video";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(656, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 24;
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(721, 55);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 20);
            this.txtso.TabIndex = 23;
            this.txtso.Text = "2";
            // 
            // lbpro
            // 
            this.lbpro.AutoSize = true;
            this.lbpro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbpro.Location = new System.Drawing.Point(656, 63);
            this.lbpro.Name = "lbpro";
            this.lbpro.Size = new System.Drawing.Size(60, 13);
            this.lbpro.TabIndex = 22;
            this.lbpro.Text = "Số process";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(673, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "/100";
            // 
            // txtEncoder
            // 
            this.txtEncoder.Location = new System.Drawing.Point(505, 125);
            this.txtEncoder.Name = "txtEncoder";
            this.txtEncoder.Size = new System.Drawing.Size(100, 20);
            this.txtEncoder.TabIndex = 20;
            this.txtEncoder.Text = "Smart Editer v3";
            // 
            // txtlanguage
            // 
            this.txtlanguage.Location = new System.Drawing.Point(505, 93);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.Size = new System.Drawing.Size(100, 20);
            this.txtlanguage.TabIndex = 19;
            this.txtlanguage.Text = "eng";
            // 
            // txtcopy
            // 
            this.txtcopy.Location = new System.Drawing.Point(505, 56);
            this.txtcopy.Name = "txtcopy";
            this.txtcopy.Size = new System.Drawing.Size(100, 20);
            this.txtcopy.TabIndex = 18;
            // 
            // txtencode
            // 
            this.txtencode.Location = new System.Drawing.Point(88, 136);
            this.txtencode.Name = "txtencode";
            this.txtencode.Size = new System.Drawing.Size(100, 20);
            this.txtencode.TabIndex = 17;
            // 
            // txtpub
            // 
            this.txtpub.Location = new System.Drawing.Point(88, 110);
            this.txtpub.Name = "txtpub";
            this.txtpub.Size = new System.Drawing.Size(149, 20);
            this.txtpub.TabIndex = 16;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(88, 84);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 15;
            this.txtdate.Text = "2017";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(440, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Encoder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(440, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Language";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(437, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Copyright";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(16, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Encoded";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(16, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(21, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date";
            // 
            // txtspeed
            // 
            this.txtspeed.Location = new System.Drawing.Point(597, 14);
            this.txtspeed.Name = "txtspeed";
            this.txtspeed.Size = new System.Drawing.Size(72, 20);
            this.txtspeed.TabIndex = 6;
            this.txtspeed.Text = "115";
            // 
            // tcuoi
            // 
            this.tcuoi.Location = new System.Drawing.Point(378, 13);
            this.tcuoi.Name = "tcuoi";
            this.tcuoi.Size = new System.Drawing.Size(72, 20);
            this.tcuoi.TabIndex = 5;
            this.tcuoi.Text = "0:00:08";
            // 
            // tdau
            // 
            this.tdau.Location = new System.Drawing.Point(88, 17);
            this.tdau.Name = "tdau";
            this.tdau.Size = new System.Drawing.Size(72, 20);
            this.tdau.TabIndex = 4;
            this.tdau.Text = "0:00:14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(529, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tốc độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(298, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cắt đít";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cắt đầu";
            // 
            // grbox2
            // 
            this.grbox2.Controls.Add(this.txtcmd);
            this.grbox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.grbox2.Location = new System.Drawing.Point(32, 401);
            this.grbox2.Name = "grbox2";
            this.grbox2.Size = new System.Drawing.Size(942, 166);
            this.grbox2.TabIndex = 3;
            this.grbox2.TabStop = false;
            this.grbox2.Text = "Lệnh";
            // 
            // txtcmd
            // 
            this.txtcmd.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcmd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtcmd.Location = new System.Drawing.Point(46, 19);
            this.txtcmd.Multiline = true;
            this.txtcmd.Name = "txtcmd";
            this.txtcmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcmd.Size = new System.Drawing.Size(890, 122);
            this.txtcmd.TabIndex = 0;
            this.txtcmd.Text = resources.GetString("txtcmd.Text");
            // 
            // btndelete1
            // 
            this.btndelete1.Location = new System.Drawing.Point(295, 153);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Size = new System.Drawing.Size(75, 23);
            this.btndelete1.TabIndex = 5;
            this.btndelete1.Text = "Delete";
            this.btndelete1.UseVisualStyleBackColor = true;
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            // 
            // btndelete2
            // 
            this.btndelete2.Location = new System.Drawing.Point(728, 153);
            this.btndelete2.Name = "btndelete2";
            this.btndelete2.Size = new System.Drawing.Size(75, 23);
            this.btndelete2.TabIndex = 7;
            this.btndelete2.Text = "Delete";
            this.btndelete2.UseVisualStyleBackColor = true;
            this.btndelete2.Click += new System.EventHandler(this.btndelete2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(805, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(672, 576);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 9;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(528, 576);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(12, 155);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(208, 20);
            this.txtnhap.TabIndex = 11;
            this.txtnhap.TextChanged += new System.EventHandler(this.txtnhap_TextChanged);
            // 
            // txtxuat
            // 
            this.txtxuat.Location = new System.Drawing.Point(499, 155);
            this.txtxuat.Name = "txtxuat";
            this.txtxuat.Size = new System.Drawing.Size(208, 20);
            this.txtxuat.TabIndex = 12;
            // 
            // btnlock
            // 
            this.btnlock.Location = new System.Drawing.Point(223, 153);
            this.btnlock.Name = "btnlock";
            this.btnlock.Size = new System.Drawing.Size(75, 23);
            this.btnlock.TabIndex = 13;
            this.btnlock.Text = "Lock";
            this.btnlock.UseVisualStyleBackColor = true;
            this.btnlock.Click += new System.EventHandler(this.btnlock_Click);
            // 
            // tientrinh
            // 
            this.tientrinh.Tick += new System.EventHandler(this.tientrinh_Tick);
            // 
            // pcrun
            // 
            this.pcrun.Image = global::Editer_v3.Properties.Resources.r3;
            this.pcrun.Location = new System.Drawing.Point(472, 569);
            this.pcrun.Name = "pcrun";
            this.pcrun.Size = new System.Drawing.Size(47, 37);
            this.pcrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrun.TabIndex = 14;
            this.pcrun.TabStop = false;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Editer_v3.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 611);
            this.Controls.Add(this.pcrun);
            this.Controls.Add(this.btnlock);
            this.Controls.Add(this.txtxuat);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btndelete2);
            this.Controls.Add(this.btndelete1);
            this.Controls.Add(this.grbox2);
            this.Controls.Add(this.grbox);
            this.Controls.Add(this.listout);
            this.Controls.Add(this.listin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editer v3 design by Phonghk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMain_FormClosed);
            this.Load += new System.EventHandler(this.frMain_Load);
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            this.grbox2.ResumeLayout(false);
            this.grbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listin;
        private System.Windows.Forms.ColumnHeader cl1;
        private System.Windows.Forms.ColumnHeader cl2;
        private System.Windows.Forms.ListView listout;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.GroupBox grbox2;
        private System.Windows.Forms.TextBox txtcmd;
        private System.Windows.Forms.Button btndelete1;
        private System.Windows.Forms.Button btndelete2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcuoi;
        private System.Windows.Forms.TextBox tdau;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtspeed;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.TextBox txtxuat;
        private System.Windows.Forms.Button btnlock;
        private System.Windows.Forms.TextBox txtEncoder;
        private System.Windows.Forms.TextBox txtlanguage;
        private System.Windows.Forms.TextBox txtcopy;
        private System.Windows.Forms.TextBox txtencode;
        private System.Windows.Forms.TextBox txtpub;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdachay;
        private System.Windows.Forms.Label lbvideotong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label lbpro;
        private System.Windows.Forms.Timer tientrinh;
        private System.Windows.Forms.PictureBox pcrun;
        private System.Windows.Forms.CheckBox cban;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttitile;
        private System.Windows.Forms.Label label4;
    }
}

