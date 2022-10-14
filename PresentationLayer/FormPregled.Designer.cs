
namespace PresentationLayer
{
    partial class FormPregled
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
            this.dateTimePickerDP = new System.Windows.Forms.DateTimePicker();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblDijagnoza = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPreporuka = new System.Windows.Forms.Label();
            this.lblDatumPregleda = new System.Windows.Forms.Label();
            this.richTextBoxOpis = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDijagnoza = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPreporuka = new System.Windows.Forms.RichTextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblMBO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerDP
            // 
            this.dateTimePickerDP.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDP.Location = new System.Drawing.Point(172, 413);
            this.dateTimePickerDP.Name = "dateTimePickerDP";
            this.dateTimePickerDP.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDP.TabIndex = 0;
            this.dateTimePickerDP.Value = new System.DateTime(2022, 1, 23, 0, 0, 0, 0);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOpis.Location = new System.Drawing.Point(54, 73);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(42, 20);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "Opis";
            // 
            // lblDijagnoza
            // 
            this.lblDijagnoza.AutoSize = true;
            this.lblDijagnoza.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDijagnoza.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDijagnoza.Location = new System.Drawing.Point(54, 180);
            this.lblDijagnoza.Name = "lblDijagnoza";
            this.lblDijagnoza.Size = new System.Drawing.Size(79, 20);
            this.lblDijagnoza.TabIndex = 2;
            this.lblDijagnoza.Text = "Dijagnoza";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStatus.Location = new System.Drawing.Point(52, 258);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // lblPreporuka
            // 
            this.lblPreporuka.AutoSize = true;
            this.lblPreporuka.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPreporuka.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPreporuka.Location = new System.Drawing.Point(52, 334);
            this.lblPreporuka.Name = "lblPreporuka";
            this.lblPreporuka.Size = new System.Drawing.Size(72, 17);
            this.lblPreporuka.TabIndex = 4;
            this.lblPreporuka.Text = "Preporuka";
            // 
            // lblDatumPregleda
            // 
            this.lblDatumPregleda.AutoSize = true;
            this.lblDatumPregleda.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDatumPregleda.Location = new System.Drawing.Point(52, 413);
            this.lblDatumPregleda.Name = "lblDatumPregleda";
            this.lblDatumPregleda.Size = new System.Drawing.Size(107, 17);
            this.lblDatumPregleda.TabIndex = 5;
            this.lblDatumPregleda.Text = "Datum Pregleda";
            // 
            // richTextBoxOpis
            // 
            this.richTextBoxOpis.Location = new System.Drawing.Point(172, 73);
            this.richTextBoxOpis.Name = "richTextBoxOpis";
            this.richTextBoxOpis.Size = new System.Drawing.Size(393, 76);
            this.richTextBoxOpis.TabIndex = 7;
            this.richTextBoxOpis.Text = "";
            // 
            // richTextBoxDijagnoza
            // 
            this.richTextBoxDijagnoza.Location = new System.Drawing.Point(172, 180);
            this.richTextBoxDijagnoza.Name = "richTextBoxDijagnoza";
            this.richTextBoxDijagnoza.Size = new System.Drawing.Size(393, 48);
            this.richTextBoxDijagnoza.TabIndex = 8;
            this.richTextBoxDijagnoza.Text = "";
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Location = new System.Drawing.Point(172, 258);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(393, 36);
            this.richTextBoxStatus.TabIndex = 9;
            this.richTextBoxStatus.Text = "";
            // 
            // richTextBoxPreporuka
            // 
            this.richTextBoxPreporuka.Location = new System.Drawing.Point(172, 334);
            this.richTextBoxPreporuka.Name = "richTextBoxPreporuka";
            this.richTextBoxPreporuka.Size = new System.Drawing.Size(393, 38);
            this.richTextBoxPreporuka.TabIndex = 10;
            this.richTextBoxPreporuka.Text = "";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSpremi.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(465, 469);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 50);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblMBO
            // 
            this.lblMBO.AutoSize = true;
            this.lblMBO.Location = new System.Drawing.Point(58, 24);
            this.lblMBO.Name = "lblMBO";
            this.lblMBO.Size = new System.Drawing.Size(31, 13);
            this.lblMBO.TabIndex = 12;
            this.lblMBO.Text = "MBO";
            this.lblMBO.Click += new System.EventHandler(this.lblMBO_Click);
            // 
            // FormPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(656, 569);
            this.Controls.Add(this.lblMBO);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.richTextBoxPreporuka);
            this.Controls.Add(this.richTextBoxStatus);
            this.Controls.Add(this.richTextBoxDijagnoza);
            this.Controls.Add(this.richTextBoxOpis);
            this.Controls.Add(this.lblDatumPregleda);
            this.Controls.Add(this.lblPreporuka);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDijagnoza);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.dateTimePickerDP);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "FormPregled";
            this.Text = "Pregled";
            this.Load += new System.EventHandler(this.FormPregled_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDP;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDijagnoza;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPreporuka;
        private System.Windows.Forms.Label lblDatumPregleda;
        private System.Windows.Forms.RichTextBox richTextBoxOpis;
        private System.Windows.Forms.RichTextBox richTextBoxDijagnoza;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.RichTextBox richTextBoxPreporuka;
        private System.Windows.Forms.Button btnSpremi;
        public System.Windows.Forms.Label lblMBO;
    }
}