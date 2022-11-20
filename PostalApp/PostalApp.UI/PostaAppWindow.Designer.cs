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
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainExitButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.MainExitButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 31);
            this.panel2.TabIndex = 17;
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
            this.MainExitButton.Location = new System.Drawing.Point(1130, 0);
            this.MainExitButton.Name = "MainExitButton";
            this.MainExitButton.Size = new System.Drawing.Size(30, 31);
            this.MainExitButton.TabIndex = 9;
            this.MainExitButton.Text = "X";
            this.MainExitButton.UseVisualStyleBackColor = false;
            this.MainExitButton.Click += new System.EventHandler(this.MainExitButton_Click);
            this.MainExitButton.MouseLeave += new System.EventHandler(this.MainExitButton_MouseLeave);
            this.MainExitButton.MouseHover += new System.EventHandler(this.MainExitButton_MouseHover);
            // 
            // PostaAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 630);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostaAppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button MainExitButton;
    }
}