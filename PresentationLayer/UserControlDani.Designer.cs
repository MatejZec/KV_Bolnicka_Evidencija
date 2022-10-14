
namespace PresentationLayer
{
    partial class UserControlDani
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
            this.lblDani = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDani
            // 
            this.lblDani.AutoSize = true;
            this.lblDani.Font = new System.Drawing.Font("Eurostar Black Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDani.Location = new System.Drawing.Point(12, 10);
            this.lblDani.Name = "lblDani";
            this.lblDani.Size = new System.Drawing.Size(36, 18);
            this.lblDani.TabIndex = 0;
            this.lblDani.Text = "00";
            // 
            // UserControlDani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDani);
            this.Name = "UserControlDani";
            this.Size = new System.Drawing.Size(105, 59);
            this.Load += new System.EventHandler(this.UserControlDani_Load);
            this.Click += new System.EventHandler(this.UserControlDani_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDani;
    }
}
