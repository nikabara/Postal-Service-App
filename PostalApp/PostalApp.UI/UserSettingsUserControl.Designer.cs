namespace PostalApp.UI
{
    partial class UserSettingsUserControl
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
            this.PasswordInput = new System.Windows.Forms.MaskedTextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.LastNameInput = new System.Windows.Forms.MaskedTextBox();
            this.LastNameText = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.MaskedTextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertMoney = new System.Windows.Forms.MaskedTextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.insertMoneyEmailConf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucParcel
            // 
            this.ucParcel.AutoSize = true;
            this.ucParcel.BackColor = System.Drawing.Color.Transparent;
            this.ucParcel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucParcel.Location = new System.Drawing.Point(15, 17);
            this.ucParcel.Name = "ucParcel";
            this.ucParcel.Size = new System.Drawing.Size(150, 45);
            this.ucParcel.TabIndex = 1;
            this.ucParcel.Text = "Edit user";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(15, 376);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(387, 27);
            this.PasswordInput.TabIndex = 37;
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.PasswordText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordText.Location = new System.Drawing.Point(15, 351);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(264, 20);
            this.PasswordText.TabIndex = 36;
            this.PasswordText.Text = "Confiem password to proceed";
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(216, 179);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(190, 27);
            this.LastNameInput.TabIndex = 31;
            // 
            // LastNameText
            // 
            this.LastNameText.AutoSize = true;
            this.LastNameText.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.LastNameText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LastNameText.Location = new System.Drawing.Point(216, 147);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(139, 20);
            this.LastNameText.TabIndex = 30;
            this.LastNameText.Text = "New last-name";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(20, 179);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(190, 27);
            this.NameInput.TabIndex = 29;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.NameText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NameText.Location = new System.Drawing.Point(19, 147);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 28;
            this.NameText.Text = "New name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 38;
            this.label1.Text = "Insert money";
            // 
            // InsertMoney
            // 
            this.InsertMoney.Location = new System.Drawing.Point(19, 735);
            this.InsertMoney.Name = "InsertMoney";
            this.InsertMoney.Size = new System.Drawing.Size(231, 27);
            this.InsertMoney.TabIndex = 39;
            this.InsertMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InsertMoney_KeyPress);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(15, 443);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(191, 30);
            this.EditButton.TabIndex = 40;
            this.EditButton.Text = "Change user";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(256, 735);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(65, 27);
            this.InsertButton.TabIndex = 41;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(216, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "($)";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(15, 287);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(387, 27);
            this.EmailInput.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Confiem email to proceed";
            // 
            // insertMoneyEmailConf
            // 
            this.insertMoneyEmailConf.Location = new System.Drawing.Point(20, 666);
            this.insertMoneyEmailConf.Name = "insertMoneyEmailConf";
            this.insertMoneyEmailConf.Size = new System.Drawing.Size(387, 27);
            this.insertMoneyEmailConf.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(20, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Confiem email to proceed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(20, 707);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ammout to insert";
            // 
            // UserSettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insertMoneyEmailConf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.InsertMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ucParcel);
            this.Name = "UserSettingsUserControl";
            this.Size = new System.Drawing.Size(1116, 802);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ucParcel;
        private MaskedTextBox PasswordInput;
        private Label PasswordText;
        private MaskedTextBox LastNameInput;
        private Label LastNameText;
        private MaskedTextBox NameInput;
        private Label NameText;
        private Label label1;
        private MaskedTextBox InsertMoney;
        private Button EditButton;
        private Button InsertButton;
        private Label label2;
        private MaskedTextBox EmailInput;
        private Label label3;
        private MaskedTextBox insertMoneyEmailConf;
        private Label label4;
        private Label label5;
    }
}
