﻿namespace PostalApp.UI
{
    partial class AllParcelsUserControl
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
            this.getParcels = new System.Windows.Forms.Label();
            this.ParcelHolder = new System.Windows.Forms.Panel();
            this.nothingHereYet = new System.Windows.Forms.Label();
            this.ParcelHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // getParcels
            // 
            this.getParcels.AutoSize = true;
            this.getParcels.BackColor = System.Drawing.Color.Transparent;
            this.getParcels.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getParcels.Location = new System.Drawing.Point(12, 15);
            this.getParcels.Name = "getParcels";
            this.getParcels.Size = new System.Drawing.Size(175, 45);
            this.getParcels.TabIndex = 1;
            this.getParcels.Text = "All parcels";
            // 
            // ParcelHolder
            // 
            this.ParcelHolder.Controls.Add(this.nothingHereYet);
            this.ParcelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParcelHolder.Location = new System.Drawing.Point(0, 0);
            this.ParcelHolder.Margin = new System.Windows.Forms.Padding(0);
            this.ParcelHolder.Name = "ParcelHolder";
            this.ParcelHolder.Padding = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.ParcelHolder.Size = new System.Drawing.Size(1116, 802);
            this.ParcelHolder.TabIndex = 2;
            // 
            // nothingHereYet
            // 
            this.nothingHereYet.AutoSize = true;
            this.nothingHereYet.BackColor = System.Drawing.Color.Transparent;
            this.nothingHereYet.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nothingHereYet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.nothingHereYet.Location = new System.Drawing.Point(507, 392);
            this.nothingHereYet.Name = "nothingHereYet";
            this.nothingHereYet.Size = new System.Drawing.Size(299, 41);
            this.nothingHereYet.TabIndex = 1;
            this.nothingHereYet.Text = "Nothing here yet...";
            this.nothingHereYet.UseWaitCursor = true;
            // 
            // AllParcelsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getParcels);
            this.Controls.Add(this.ParcelHolder);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AllParcelsUserControl";
            this.Size = new System.Drawing.Size(1116, 802);
            this.ParcelHolder.ResumeLayout(false);
            this.ParcelHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label getParcels;
        public Panel ParcelHolder;
        public Label nothingHereYet;
    }
}
