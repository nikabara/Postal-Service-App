namespace PostalApp.UI
{
    partial class ParcelDetailesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetParcel = new System.Windows.Forms.Button();
            this.createParcel = new System.Windows.Forms.Button();
            this.totalOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deliveryOut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parcelWeightOut = new System.Windows.Forms.Label();
            this.parcelDescrOut = new System.Windows.Forms.Label();
            this.parcelNameOut = new System.Windows.Forms.Label();
            this.parcelWeightText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detailParcel1 = new System.Windows.Forms.Label();
            this.parcelDetailesText = new System.Windows.Forms.Label();
            this.shipMethod = new System.Windows.Forms.Label();
            this.shipTypeText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.shipMethod);
            this.panel1.Controls.Add(this.shipTypeText);
            this.panel1.Controls.Add(this.resetParcel);
            this.panel1.Controls.Add(this.createParcel);
            this.panel1.Controls.Add(this.totalOut);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.deliveryOut);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.toOut);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fromOut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.parcelWeightOut);
            this.panel1.Controls.Add(this.parcelDescrOut);
            this.panel1.Controls.Add(this.parcelNameOut);
            this.panel1.Controls.Add(this.parcelWeightText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.detailParcel1);
            this.panel1.Controls.Add(this.parcelDetailesText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 802);
            this.panel1.TabIndex = 17;
            // 
            // resetParcel
            // 
            this.resetParcel.Location = new System.Drawing.Point(169, 579);
            this.resetParcel.Name = "resetParcel";
            this.resetParcel.Size = new System.Drawing.Size(145, 37);
            this.resetParcel.TabIndex = 22;
            this.resetParcel.Text = "Reset";
            this.resetParcel.UseVisualStyleBackColor = true;
            // 
            // createParcel
            // 
            this.createParcel.Location = new System.Drawing.Point(19, 579);
            this.createParcel.Name = "createParcel";
            this.createParcel.Size = new System.Drawing.Size(145, 37);
            this.createParcel.TabIndex = 21;
            this.createParcel.Text = "Create";
            this.createParcel.UseVisualStyleBackColor = true;
            this.createParcel.Click += new System.EventHandler(this.createParcel_Click);
            // 
            // totalOut
            // 
            this.totalOut.AutoSize = true;
            this.totalOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.totalOut.Location = new System.Drawing.Point(91, 494);
            this.totalOut.Name = "totalOut";
            this.totalOut.Size = new System.Drawing.Size(118, 31);
            this.totalOut.TabIndex = 20;
            this.totalOut.Text = "total here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.label6.Location = new System.Drawing.Point(19, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total :";
            // 
            // deliveryOut
            // 
            this.deliveryOut.AutoSize = true;
            this.deliveryOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliveryOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.deliveryOut.Location = new System.Drawing.Point(182, 420);
            this.deliveryOut.Name = "deliveryOut";
            this.deliveryOut.Size = new System.Drawing.Size(121, 25);
            this.deliveryOut.TabIndex = 18;
            this.deliveryOut.Text = "delivery here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.label5.Location = new System.Drawing.Point(19, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Delivery to home : ";
            // 
            // toOut
            // 
            this.toOut.AutoSize = true;
            this.toOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.toOut.Location = new System.Drawing.Point(56, 317);
            this.toOut.Name = "toOut";
            this.toOut.Size = new System.Drawing.Size(72, 25);
            this.toOut.TabIndex = 16;
            this.toOut.Text = "to here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.label4.Location = new System.Drawing.Point(19, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "To :";
            // 
            // fromOut
            // 
            this.fromOut.AutoSize = true;
            this.fromOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.fromOut.Location = new System.Drawing.Point(80, 281);
            this.fromOut.Name = "fromOut";
            this.fromOut.Size = new System.Drawing.Size(94, 25);
            this.fromOut.TabIndex = 14;
            this.fromOut.Text = "from here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(19, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "From :";
            // 
            // parcelWeightOut
            // 
            this.parcelWeightOut.AutoSize = true;
            this.parcelWeightOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parcelWeightOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.parcelWeightOut.Location = new System.Drawing.Point(148, 222);
            this.parcelWeightOut.Name = "parcelWeightOut";
            this.parcelWeightOut.Size = new System.Drawing.Size(166, 25);
            this.parcelWeightOut.TabIndex = 12;
            this.parcelWeightOut.Text = "parcel weight here";
            // 
            // parcelDescrOut
            // 
            this.parcelDescrOut.AutoSize = true;
            this.parcelDescrOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parcelDescrOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.parcelDescrOut.Location = new System.Drawing.Point(185, 150);
            this.parcelDescrOut.Name = "parcelDescrOut";
            this.parcelDescrOut.Size = new System.Drawing.Size(153, 25);
            this.parcelDescrOut.TabIndex = 11;
            this.parcelDescrOut.Text = "parcel descr here";
            // 
            // parcelNameOut
            // 
            this.parcelNameOut.AutoSize = true;
            this.parcelNameOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parcelNameOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.parcelNameOut.Location = new System.Drawing.Point(134, 98);
            this.parcelNameOut.Name = "parcelNameOut";
            this.parcelNameOut.Size = new System.Drawing.Size(155, 25);
            this.parcelNameOut.TabIndex = 10;
            this.parcelNameOut.Text = "parcel name here";
            // 
            // parcelWeightText
            // 
            this.parcelWeightText.AutoSize = true;
            this.parcelWeightText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parcelWeightText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.parcelWeightText.Location = new System.Drawing.Point(19, 222);
            this.parcelWeightText.Name = "parcelWeightText";
            this.parcelWeightText.Size = new System.Drawing.Size(132, 25);
            this.parcelWeightText.TabIndex = 9;
            this.parcelWeightText.Text = "Parcel weight :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(19, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parcel description :";
            // 
            // detailParcel1
            // 
            this.detailParcel1.AutoSize = true;
            this.detailParcel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.detailParcel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.detailParcel1.Location = new System.Drawing.Point(19, 98);
            this.detailParcel1.Name = "detailParcel1";
            this.detailParcel1.Size = new System.Drawing.Size(121, 25);
            this.detailParcel1.TabIndex = 3;
            this.detailParcel1.Text = "Parcel name :";
            // 
            // parcelDetailesText
            // 
            this.parcelDetailesText.AutoSize = true;
            this.parcelDetailesText.BackColor = System.Drawing.Color.Transparent;
            this.parcelDetailesText.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parcelDetailesText.Location = new System.Drawing.Point(19, 15);
            this.parcelDetailesText.Name = "parcelDetailesText";
            this.parcelDetailesText.Size = new System.Drawing.Size(236, 45);
            this.parcelDetailesText.TabIndex = 1;
            this.parcelDetailesText.Text = "Parcel detailes";
            // 
            // shipMethod
            // 
            this.shipMethod.AutoSize = true;
            this.shipMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shipMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.shipMethod.Location = new System.Drawing.Point(182, 373);
            this.shipMethod.Name = "shipMethod";
            this.shipMethod.Size = new System.Drawing.Size(126, 25);
            this.shipMethod.TabIndex = 24;
            this.shipMethod.Text = "shipping here";
            // 
            // shipTypeText
            // 
            this.shipTypeText.AutoSize = true;
            this.shipTypeText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shipTypeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.shipTypeText.Location = new System.Drawing.Point(19, 373);
            this.shipTypeText.Name = "shipTypeText";
            this.shipTypeText.Size = new System.Drawing.Size(165, 25);
            this.shipTypeText.TabIndex = 23;
            this.shipTypeText.Text = "Shipping method :";
            // 
            // ParcelDetailesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ParcelDetailesUserControl";
            this.Size = new System.Drawing.Size(788, 802);
            this.Load += new System.EventHandler(this.ParcelDetailesUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label parcelWeightText;
        private Label label2;
        private Label detailParcel1;
        private Label parcelDetailesText;
        public Label parcelNameOut;
        public Label deliveryOut;
        public Label toOut;
        public Label fromOut;
        public Label parcelWeightOut;
        public Label parcelDescrOut;
        public Label totalOut;
        private Button resetParcel;
        public Button createParcel;
        public Label shipMethod;
        private Label shipTypeText;
    }
}
