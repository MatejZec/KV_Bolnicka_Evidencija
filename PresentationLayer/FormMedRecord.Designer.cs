
namespace PresentationLayer
{
    partial class FormMedRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMedRecord = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPovijestLijecenja = new System.Windows.Forms.Label();
            this.dataGridViewMedRecord = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIspis = new System.Windows.Forms.Button();
            this.panelMRHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedRecord)).BeginInit();
            this.panelMRHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMedRecord
            // 
            this.lblMedRecord.AutoSize = true;
            this.lblMedRecord.Font = new System.Drawing.Font("Eurostar Black Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedRecord.ForeColor = System.Drawing.Color.White;
            this.lblMedRecord.Location = new System.Drawing.Point(12, 18);
            this.lblMedRecord.Name = "lblMedRecord";
            this.lblMedRecord.Size = new System.Drawing.Size(316, 28);
            this.lblMedRecord.TabIndex = 0;
            this.lblMedRecord.Text = "Zdravstveni Karton";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(32, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ime";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFirstName.Location = new System.Drawing.Point(107, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "_________";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(32, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLastName.Location = new System.Drawing.Point(107, 128);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 17);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "_________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(32, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Spol";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGender.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblGender.Location = new System.Drawing.Point(107, 165);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 17);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "_________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(310, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Datum rođenja";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDOB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDOB.Location = new System.Drawing.Point(416, 94);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(85, 17);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "___________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(310, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kontakt";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContact.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblContact.Location = new System.Drawing.Point(416, 128);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(85, 17);
            this.lblContact.TabIndex = 10;
            this.lblContact.Text = "___________";
            // 
            // lblPovijestLijecenja
            // 
            this.lblPovijestLijecenja.AutoSize = true;
            this.lblPovijestLijecenja.Font = new System.Drawing.Font("Eurostar Black Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPovijestLijecenja.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPovijestLijecenja.Location = new System.Drawing.Point(31, 215);
            this.lblPovijestLijecenja.Name = "lblPovijestLijecenja";
            this.lblPovijestLijecenja.Size = new System.Drawing.Size(212, 22);
            this.lblPovijestLijecenja.TabIndex = 11;
            this.lblPovijestLijecenja.Text = "Povijest liječenja";
            // 
            // dataGridViewMedRecord
            // 
            this.dataGridViewMedRecord.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewMedRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMedRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMedRecord.ColumnHeadersHeight = 30;
            this.dataGridViewMedRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMedRecord.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMedRecord.EnableHeadersVisualStyles = false;
            this.dataGridViewMedRecord.Location = new System.Drawing.Point(35, 240);
            this.dataGridViewMedRecord.Name = "dataGridViewMedRecord";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMedRecord.RowHeadersVisible = false;
            this.dataGridViewMedRecord.Size = new System.Drawing.Size(690, 204);
            this.dataGridViewMedRecord.TabIndex = 12;
            this.dataGridViewMedRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedRecord_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Width = 124;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PacijentId";
            this.Column2.HeaderText = "PacijentId";
            this.Column2.Name = "Column2";
            this.Column2.Width = 124;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Datum";
            this.Column3.HeaderText = "Datum";
            this.Column3.Name = "Column3";
            this.Column3.Width = 124;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Opis";
            this.Column4.HeaderText = "Opis";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Dijagnoza";
            this.Column5.HeaderText = "Dijagnoza";
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "Status";
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.Width = 71;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "Preporuka";
            this.Column7.HeaderText = "Preporuka";
            this.Column7.Name = "Column7";
            this.Column7.Width = 92;
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIspis.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIspis.ForeColor = System.Drawing.Color.White;
            this.btnIspis.Location = new System.Drawing.Point(650, 479);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 36);
            this.btnIspis.TabIndex = 13;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // panelMRHeader
            // 
            this.panelMRHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMRHeader.Controls.Add(this.lblMedRecord);
            this.panelMRHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMRHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMRHeader.Name = "panelMRHeader";
            this.panelMRHeader.Size = new System.Drawing.Size(819, 62);
            this.panelMRHeader.TabIndex = 14;
            // 
            // FormMedRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(819, 595);
            this.Controls.Add(this.panelMRHeader);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.dataGridViewMedRecord);
            this.Controls.Add(this.lblPovijestLijecenja);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblName);
            this.Name = "FormMedRecord";
            this.Text = "ZDRAVSTEVI KARTON";
            this.Load += new System.EventHandler(this.FormMedRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedRecord)).EndInit();
            this.panelMRHeader.ResumeLayout(false);
            this.panelMRHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedRecord;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPovijestLijecenja;
        private System.Windows.Forms.DataGridView dataGridViewMedRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Panel panelMRHeader;
    }
}