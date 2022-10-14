
namespace PresentationLayer
{
    partial class FormListaCekanja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLC = new System.Windows.Forms.Panel();
            this.lblNaslovLC = new System.Windows.Forms.Label();
            this.dataGridViewLC = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLC
            // 
            this.panelLC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelLC.Controls.Add(this.lblNaslovLC);
            this.panelLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLC.Location = new System.Drawing.Point(0, 0);
            this.panelLC.Name = "panelLC";
            this.panelLC.Size = new System.Drawing.Size(800, 50);
            this.panelLC.TabIndex = 0;
            // 
            // lblNaslovLC
            // 
            this.lblNaslovLC.AutoSize = true;
            this.lblNaslovLC.Font = new System.Drawing.Font("FreeSans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNaslovLC.ForeColor = System.Drawing.Color.White;
            this.lblNaslovLC.Location = new System.Drawing.Point(3, 9);
            this.lblNaslovLC.Name = "lblNaslovLC";
            this.lblNaslovLC.Size = new System.Drawing.Size(169, 27);
            this.lblNaslovLC.TabIndex = 0;
            this.lblNaslovLC.Text = "LISTA ČEKANJA";
            // 
            // dataGridViewLC
            // 
            this.dataGridViewLC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLC.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewLC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLC.ColumnHeadersHeight = 30;
            this.dataGridViewLC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewLC.EnableHeadersVisualStyles = false;
            this.dataGridViewLC.Location = new System.Drawing.Point(8, 56);
            this.dataGridViewLC.Name = "dataGridViewLC";
            this.dataGridViewLC.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("FreeSans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewLC.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLC.Size = new System.Drawing.Size(548, 150);
            this.dataGridViewLC.TabIndex = 1;
            this.dataGridViewLC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLC_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Id";
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Pacijent_Id";
            this.Column5.HeaderText = "MBO";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
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
            this.Column3.DataPropertyName = "Zakazano";
            this.Column3.HeaderText = "Zakazano";
            this.Column3.Name = "Column3";
            // 
            // FormListaCekanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLC);
            this.Controls.Add(this.panelLC);
            this.Name = "FormListaCekanja";
            this.Text = "LISTA ČEKANJA";
            this.Load += new System.EventHandler(this.FormListaCekanja_Load);
            this.panelLC.ResumeLayout(false);
            this.panelLC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLC;
        private System.Windows.Forms.Label lblNaslovLC;
        private System.Windows.Forms.DataGridView dataGridViewLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}