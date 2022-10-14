
namespace PresentationLayer
{
    partial class FormPatientsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPacijenti = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPLHeader = new System.Windows.Forms.Label();
            this.panelPLHeader = new System.Windows.Forms.Panel();
            this.btnDodajNovogPacijenta = new System.Windows.Forms.Button();
            this.lblSearchP = new System.Windows.Forms.Label();
            this.textBoxSearchP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacijenti)).BeginInit();
            this.panelPLHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPacijenti
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.dataGridViewPacijenti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPacijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPacijenti.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewPacijenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPacijenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPacijenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPacijenti.ColumnHeadersHeight = 30;
            this.dataGridViewPacijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewPacijenti.EnableHeadersVisualStyles = false;
            this.dataGridViewPacijenti.Location = new System.Drawing.Point(5, 110);
            this.dataGridViewPacijenti.Name = "dataGridViewPacijenti";
            this.dataGridViewPacijenti.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewPacijenti.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPacijenti.Size = new System.Drawing.Size(796, 227);
            this.dataGridViewPacijenti.TabIndex = 1;
            this.dataGridViewPacijenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacijenti_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ime";
            this.Column1.HeaderText = "Ime";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Prezime";
            this.Column2.HeaderText = "Prezime";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DOB";
            this.Column3.HeaderText = "Datum rođenja";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Kontakt";
            this.Column4.HeaderText = "Kontakt";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OIB";
            this.Column5.HeaderText = "OIB";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MBO";
            this.Column6.HeaderText = "MBO";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Spol";
            this.Column7.HeaderText = "Spol";
            this.Column7.Name = "Column7";
            // 
            // lblPLHeader
            // 
            this.lblPLHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPLHeader.Font = new System.Drawing.Font("FreeSans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPLHeader.ForeColor = System.Drawing.Color.White;
            this.lblPLHeader.Location = new System.Drawing.Point(0, 9);
            this.lblPLHeader.Name = "lblPLHeader";
            this.lblPLHeader.Size = new System.Drawing.Size(244, 34);
            this.lblPLHeader.TabIndex = 2;
            this.lblPLHeader.Text = "LISTA PACIJENATA";
            this.lblPLHeader.Click += new System.EventHandler(this.lblPLHeader_Click);
            // 
            // panelPLHeader
            // 
            this.panelPLHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelPLHeader.Controls.Add(this.lblPLHeader);
            this.panelPLHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPLHeader.Location = new System.Drawing.Point(0, 0);
            this.panelPLHeader.Name = "panelPLHeader";
            this.panelPLHeader.Size = new System.Drawing.Size(813, 50);
            this.panelPLHeader.TabIndex = 3;
            // 
            // btnDodajNovogPacijenta
            // 
            this.btnDodajNovogPacijenta.BackColor = System.Drawing.Color.Aqua;
            this.btnDodajNovogPacijenta.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDodajNovogPacijenta.ForeColor = System.Drawing.Color.Black;
            this.btnDodajNovogPacijenta.Location = new System.Drawing.Point(720, 356);
            this.btnDodajNovogPacijenta.Name = "btnDodajNovogPacijenta";
            this.btnDodajNovogPacijenta.Size = new System.Drawing.Size(81, 29);
            this.btnDodajNovogPacijenta.TabIndex = 4;
            this.btnDodajNovogPacijenta.Text = "Dodaj";
            this.btnDodajNovogPacijenta.UseVisualStyleBackColor = false;
            this.btnDodajNovogPacijenta.Click += new System.EventHandler(this.btnDodajNovogPacijenta_Click);
            // 
            // lblSearchP
            // 
            this.lblSearchP.AutoSize = true;
            this.lblSearchP.Font = new System.Drawing.Font("FreeSans", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchP.ForeColor = System.Drawing.Color.White;
            this.lblSearchP.Location = new System.Drawing.Point(12, 73);
            this.lblSearchP.Name = "lblSearchP";
            this.lblSearchP.Size = new System.Drawing.Size(57, 17);
            this.lblSearchP.TabIndex = 5;
            this.lblSearchP.Text = "Pretraži ";
            // 
            // textBoxSearchP
            // 
            this.textBoxSearchP.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchP.Location = new System.Drawing.Point(71, 70);
            this.textBoxSearchP.Name = "textBoxSearchP";
            this.textBoxSearchP.Size = new System.Drawing.Size(128, 24);
            this.textBoxSearchP.TabIndex = 6;
            this.textBoxSearchP.TextChanged += new System.EventHandler(this.textBoxSearchP_TextChanged);
            // 
            // FormPatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.textBoxSearchP);
            this.Controls.Add(this.lblSearchP);
            this.Controls.Add(this.btnDodajNovogPacijenta);
            this.Controls.Add(this.panelPLHeader);
            this.Controls.Add(this.dataGridViewPacijenti);
            this.Name = "FormPatientsList";
            this.Text = "MOJI PACIJENTI";
            this.Load += new System.EventHandler(this.FormPatientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacijenti)).EndInit();
            this.panelPLHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPacijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblPLHeader;
        private System.Windows.Forms.Panel panelPLHeader;
        private System.Windows.Forms.Button btnDodajNovogPacijenta;
        private System.Windows.Forms.Label lblSearchP;
        private System.Windows.Forms.TextBox textBoxSearchP;
    }
}