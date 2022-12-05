namespace PostalApp.UI
{
    partial class ParcelUserControl
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
            this.ucParcel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.weightText = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.sentfromText = new System.Windows.Forms.Label();
            this.sentfromInput = new System.Windows.Forms.TextBox();
            this.senttoText = new System.Windows.Forms.Label();
            this.senttoInput = new System.Windows.Forms.TextBox();
            this.shippingtypeButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shippingtypeText = new System.Windows.Forms.Label();
            this.deliveryCheck = new System.Windows.Forms.CheckBox();
            this.createParcel = new System.Windows.Forms.Button();
            this.parcelDetailControlDiv = new System.Windows.Forms.Panel();
            this.awaitingText = new System.Windows.Forms.Label();
            this.parcelDetailControlDiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucParcel
            // 
            this.ucParcel.AutoSize = true;
            this.ucParcel.BackColor = System.Drawing.Color.Transparent;
            this.ucParcel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucParcel.Location = new System.Drawing.Point(12, 15);
            this.ucParcel.Name = "ucParcel";
            this.ucParcel.Size = new System.Drawing.Size(219, 45);
            this.ucParcel.TabIndex = 0;
            this.ucParcel.Text = "Create parcel";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(21, 126);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(293, 27);
            this.nameInput.TabIndex = 1;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.NameText.Location = new System.Drawing.Point(17, 98);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(112, 25);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "Parcel name";
            // 
            // descriptionText
            // 
            this.descriptionText.AutoSize = true;
            this.descriptionText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.descriptionText.Location = new System.Drawing.Point(316, 98);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(160, 25);
            this.descriptionText.TabIndex = 4;
            this.descriptionText.Text = "Parcel description";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(320, 126);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(291, 27);
            this.descriptionInput.TabIndex = 3;
            // 
            // weightText
            // 
            this.weightText.AutoSize = true;
            this.weightText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.weightText.Location = new System.Drawing.Point(16, 202);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(191, 25);
            this.weightText.TabIndex = 6;
            this.weightText.Text = "Parcel weight (grams)";
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(21, 230);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(204, 27);
            this.weightInput.TabIndex = 5;
            this.weightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightInput_KeyPress);
            // 
            // sentfromText
            // 
            this.sentfromText.AutoSize = true;
            this.sentfromText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sentfromText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.sentfromText.Location = new System.Drawing.Point(226, 202);
            this.sentfromText.Name = "sentfromText";
            this.sentfromText.Size = new System.Drawing.Size(64, 25);
            this.sentfromText.TabIndex = 8;
            this.sentfromText.Text = "From :";
            // 
            // sentfromInput
            // 
            this.sentfromInput.Location = new System.Drawing.Point(231, 230);
            this.sentfromInput.Name = "sentfromInput";
            this.sentfromInput.Size = new System.Drawing.Size(184, 27);
            this.sentfromInput.TabIndex = 7;
            // 
            // senttoText
            // 
            this.senttoText.AutoSize = true;
            this.senttoText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.senttoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.senttoText.Location = new System.Drawing.Point(415, 202);
            this.senttoText.Name = "senttoText";
            this.senttoText.Size = new System.Drawing.Size(40, 25);
            this.senttoText.TabIndex = 10;
            this.senttoText.Text = "To :";
            // 
            // senttoInput
            // 
            this.senttoInput.Location = new System.Drawing.Point(421, 230);
            this.senttoInput.Name = "senttoInput";
            this.senttoInput.Size = new System.Drawing.Size(190, 27);
            this.senttoInput.TabIndex = 9;
            // 
            // shippingtypeButton
            // 
            this.shippingtypeButton.Location = new System.Drawing.Point(223, 315);
            this.shippingtypeButton.Name = "shippingtypeButton";
            this.shippingtypeButton.Size = new System.Drawing.Size(388, 29);
            this.shippingtypeButton.TabIndex = 11;
            this.shippingtypeButton.Text = "Choose shipping type    ⬇";
            this.shippingtypeButton.UseVisualStyleBackColor = true;
            this.shippingtypeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // shippingtypeText
            // 
            this.shippingtypeText.AutoSize = true;
            this.shippingtypeText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shippingtypeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.shippingtypeText.Location = new System.Drawing.Point(16, 315);
            this.shippingtypeText.Name = "shippingtypeText";
            this.shippingtypeText.Size = new System.Drawing.Size(201, 25);
            this.shippingtypeText.TabIndex = 12;
            this.shippingtypeText.Text = "Choose shipping type :";
            // 
            // deliveryCheck
            // 
            this.deliveryCheck.AutoSize = true;
            this.deliveryCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliveryCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.deliveryCheck.Location = new System.Drawing.Point(15, 402);
            this.deliveryCheck.Name = "deliveryCheck";
            this.deliveryCheck.Size = new System.Drawing.Size(178, 29);
            this.deliveryCheck.TabIndex = 14;
            this.deliveryCheck.Text = "Delivery to home";
            this.deliveryCheck.UseVisualStyleBackColor = true;
            this.deliveryCheck.CheckedChanged += new System.EventHandler(this.deliveryCheck_CheckedChanged);
            // 
            // createParcel
            // 
            this.createParcel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createParcel.Location = new System.Drawing.Point(199, 397);
            this.createParcel.Name = "createParcel";
            this.createParcel.Size = new System.Drawing.Size(412, 34);
            this.createParcel.TabIndex = 15;
            this.createParcel.Text = "Create parcel";
            this.createParcel.UseVisualStyleBackColor = true;
            this.createParcel.Click += new System.EventHandler(this.createParcel_Click);
            // 
            // parcelDetailControlDiv
            // 
            this.parcelDetailControlDiv.BackColor = System.Drawing.Color.Transparent;
            this.parcelDetailControlDiv.Controls.Add(this.awaitingText);
            this.parcelDetailControlDiv.Dock = System.Windows.Forms.DockStyle.Right;
            this.parcelDetailControlDiv.Location = new System.Drawing.Point(296, 0);
            this.parcelDetailControlDiv.Name = "parcelDetailControlDiv";
            this.parcelDetailControlDiv.Size = new System.Drawing.Size(820, 802);
            this.parcelDetailControlDiv.TabIndex = 17;
            // 
            // awaitingText
            // 
            this.awaitingText.AutoSize = true;
            this.awaitingText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.awaitingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.awaitingText.Location = new System.Drawing.Point(234, 377);
            this.awaitingText.Name = "awaitingText";
            this.awaitingText.Size = new System.Drawing.Size(241, 38);
            this.awaitingText.TabIndex = 0;
            this.awaitingText.Text = "Awaiting result...";
            // 
            // ParcelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.parcelDetailControlDiv);
            this.Controls.Add(this.createParcel);
            this.Controls.Add(this.deliveryCheck);
            this.Controls.Add(this.shippingtypeText);
            this.Controls.Add(this.shippingtypeButton);
            this.Controls.Add(this.senttoText);
            this.Controls.Add(this.senttoInput);
            this.Controls.Add(this.sentfromText);
            this.Controls.Add(this.sentfromInput);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.ucParcel);
            this.Name = "ParcelUserControl";
            this.Size = new System.Drawing.Size(1116, 802);
            this.parcelDetailControlDiv.ResumeLayout(false);
            this.parcelDetailControlDiv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ucParcel;
        private TextBox nameInput;
        private Label NameText;
        private Label descriptionText;
        private TextBox descriptionInput;
        private Label weightText;
        private TextBox weightInput;
        private Label sentfromText;
        private TextBox sentfromInput;
        private Label senttoText;
        private TextBox senttoInput;
        private Button shippingtypeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label shippingtypeText;
        private CheckBox deliveryCheck;
        private Panel parcelDetailControlDiv;
        protected Label awaitingText;
        public Button createParcel;
    }
}
