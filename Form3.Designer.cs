namespace WindowsFormsApp6
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.sidebar = new System.Windows.Forms.Panel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.MidnightBlue;
            this.sidebar.Controls.Add(this.button7);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.button6);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.label5);
            this.sidebar.ForeColor = System.Drawing.Color.White;
            this.sidebar.Location = new System.Drawing.Point(0, 45);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(259, 793);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8-logout-48.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-dashboard-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-stock-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-dashboard-64.png");
            this.imageList1.Images.SetKeyName(3, "icons8-report-card-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-settings-50.png");
            this.imageList1.Images.SetKeyName(5, "icons8-dashboard-96.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(271, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 603);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "icons8-bulleted-list-48.png");
            this.imageList3.Images.SetKeyName(1, "icons8-bulleted-list-48.png");
            this.imageList3.Images.SetKeyName(2, "icons8-restore-window-48.png");
            this.imageList3.Images.SetKeyName(3, "icons8-minimize-window-48.png");
            this.imageList3.Images.SetKeyName(4, "icons8-close-window-48.png");
            this.imageList3.Images.SetKeyName(5, "icons8-profile-picture-50.png");
            this.imageList3.Images.SetKeyName(6, "icons8-profile-picture-50 (1).png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(57, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELECTRO MART | SALESMAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(276, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "STOCK INQUIRY";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 48);
            this.panel3.TabIndex = 5;
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.button9.ImageIndex = 6;
            this.button9.ImageList = this.imageList3;
            this.button9.Location = new System.Drawing.Point(1234, 54);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 33);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.ImageIndex = 4;
            this.button5.ImageList = this.imageList3;
            this.button5.Location = new System.Drawing.Point(1234, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 30);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.ImageIndex = 3;
            this.button4.ImageList = this.imageList3;
            this.button4.Location = new System.Drawing.Point(1157, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 30);
            this.button4.TabIndex = 1;
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.ImageIndex = 2;
            this.button8.ImageList = this.imageList3;
            this.button8.Location = new System.Drawing.Point(1197, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 30);
            this.button8.TabIndex = 2;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp6.Properties.Resources.icons8_stripes_24;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MidnightBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageIndex = 0;
            this.button7.ImageList = this.imageList2;
            this.button7.Location = new System.Drawing.Point(-17, 608);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(253, 55);
            this.button7.TabIndex = 0;
            this.button7.Text = "   LOG OUT";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(-6, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 65);
            this.button2.TabIndex = 0;
            this.button2.Text = "   STOCK INQUIRY";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(-6, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 65);
            this.button3.TabIndex = 1;
            this.button3.Text = "   DASHBOARD";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MidnightBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageIndex = 4;
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(0, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(259, 65);
            this.button6.TabIndex = 2;
            this.button6.Text = "  ACCOUNT SETTINGS";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageKey = "icons8-report-card-48.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(0, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "  PERFORMANCE REPORT";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 714);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}