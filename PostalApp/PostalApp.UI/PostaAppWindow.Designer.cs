namespace PostalApp.UI
{
    partial class PostaAppWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostaAppWindow));
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MainExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hashtag = new System.Windows.Forms.Label();
            this.Userid = new System.Windows.Forms.Label();
            this.personalInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.EmailText = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.placeOrder = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.allParcels = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.UserControlDiv = new System.Windows.Forms.Panel();
            this.nothingHereYet = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.personalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.placeOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.allParcels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.UserControlDiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.MinimizeButton);
            this.panel2.Controls.Add(this.MainExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1468, 36);
            this.panel2.TabIndex = 17;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.MinimizeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinimizeButton.Location = new System.Drawing.Point(1375, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 36);
            this.MinimizeButton.TabIndex = 10;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MainExitButton
            // 
            this.MainExitButton.BackColor = System.Drawing.Color.DarkGray;
            this.MainExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainExitButton.FlatAppearance.BorderSize = 0;
            this.MainExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainExitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainExitButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.MainExitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainExitButton.Location = new System.Drawing.Point(1420, 0);
            this.MainExitButton.Name = "MainExitButton";
            this.MainExitButton.Size = new System.Drawing.Size(48, 36);
            this.MainExitButton.TabIndex = 9;
            this.MainExitButton.Text = "X";
            this.MainExitButton.UseVisualStyleBackColor = false;
            this.MainExitButton.Click += new System.EventHandler(this.MainExitButton_Click);
            this.MainExitButton.MouseLeave += new System.EventHandler(this.MainExitButton_MouseLeave);
            this.MainExitButton.MouseHover += new System.EventHandler(this.MainExitButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.hashtag);
            this.panel1.Controls.Add(this.Userid);
            this.panel1.Controls.Add(this.personalInfo);
            this.panel1.Controls.Add(this.EmailText);
            this.panel1.Controls.Add(this.NameText);
            this.panel1.Controls.Add(this.placeOrder);
            this.panel1.Controls.Add(this.allParcels);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 802);
            this.panel1.TabIndex = 18;
            // 
            // hashtag
            // 
            this.hashtag.AutoSize = true;
            this.hashtag.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hashtag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hashtag.Location = new System.Drawing.Point(14, 68);
            this.hashtag.Name = "hashtag";
            this.hashtag.Size = new System.Drawing.Size(18, 20);
            this.hashtag.TabIndex = 27;
            this.hashtag.Text = "#";
            // 
            // Userid
            // 
            this.Userid.AutoSize = true;
            this.Userid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Userid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Userid.Location = new System.Drawing.Point(28, 68);
            this.Userid.Name = "Userid";
            this.Userid.Size = new System.Drawing.Size(17, 20);
            this.Userid.TabIndex = 28;
            this.Userid.Text = "0";
            // 
            // personalInfo
            // 
            this.personalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(87)))), ((int)(((byte)(121)))));
            this.personalInfo.Controls.Add(this.label1);
            this.personalInfo.Controls.Add(this.pictureBox5);
            this.personalInfo.Location = new System.Drawing.Point(12, 140);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(318, 43);
            this.personalInfo.TabIndex = 26;
            this.personalInfo.Click += new System.EventHandler(this.personalInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personal info";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 43);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // EmailText
            // 
            this.EmailText.AutoSize = true;
            this.EmailText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailText.Location = new System.Drawing.Point(14, 48);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(81, 20);
            this.EmailText.TabIndex = 25;
            this.EmailText.Text = "Email here";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.BackColor = System.Drawing.Color.Transparent;
            this.NameText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameText.Location = new System.Drawing.Point(12, 17);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(128, 31);
            this.NameText.TabIndex = 24;
            this.NameText.Text = "Name here";
            // 
            // placeOrder
            // 
            this.placeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(87)))), ((int)(((byte)(121)))));
            this.placeOrder.Controls.Add(this.label5);
            this.placeOrder.Controls.Add(this.pictureBox4);
            this.placeOrder.Location = new System.Drawing.Point(12, 255);
            this.placeOrder.Name = "placeOrder";
            this.placeOrder.Size = new System.Drawing.Size(318, 43);
            this.placeOrder.TabIndex = 23;
            this.placeOrder.Click += new System.EventHandler(this.placeOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.label5.Location = new System.Drawing.Point(50, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Place order";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 43);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // allParcels
            // 
            this.allParcels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(87)))), ((int)(((byte)(121)))));
            this.allParcels.Controls.Add(this.label4);
            this.allParcels.Controls.Add(this.pictureBox3);
            this.allParcels.Location = new System.Drawing.Point(12, 197);
            this.allParcels.Name = "allParcels";
            this.allParcels.Size = new System.Drawing.Size(318, 43);
            this.allParcels.TabIndex = 22;
            this.allParcels.Click += new System.EventHandler(this.allParcels_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.label4.Location = new System.Drawing.Point(50, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "All parcels";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 43);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // UserControlDiv
            // 
            this.UserControlDiv.Controls.Add(this.nothingHereYet);
            this.UserControlDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControlDiv.Location = new System.Drawing.Point(352, 36);
            this.UserControlDiv.Name = "UserControlDiv";
            this.UserControlDiv.Size = new System.Drawing.Size(1116, 802);
            this.UserControlDiv.TabIndex = 19;
            // 
            // nothingHereYet
            // 
            this.nothingHereYet.AutoSize = true;
            this.nothingHereYet.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nothingHereYet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.nothingHereYet.Location = new System.Drawing.Point(568, 366);
            this.nothingHereYet.Name = "nothingHereYet";
            this.nothingHereYet.Size = new System.Drawing.Size(299, 41);
            this.nothingHereYet.TabIndex = 0;
            this.nothingHereYet.Text = "Nothing here yet...";
            // 
            // PostaAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1468, 838);
            this.Controls.Add(this.UserControlDiv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PostaAppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PostaAppWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.personalInfo.ResumeLayout(false);
            this.personalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.placeOrder.ResumeLayout(false);
            this.placeOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.allParcels.ResumeLayout(false);
            this.allParcels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.UserControlDiv.ResumeLayout(false);
            this.UserControlDiv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button MainExitButton;
        private Panel panel1;
        private Button MinimizeButton;
        private Panel placeOrder;
        private Label label5;
        private PictureBox pictureBox4;
        private Panel allParcels;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel personalInfo;
        private Label label1;
        private PictureBox pictureBox5;
        private Panel UserControlDiv;
        public Label Userid;
        private Label hashtag;
        private Label nothingHereYet;
        public Label NameText;
        public Label EmailText;
    }
}