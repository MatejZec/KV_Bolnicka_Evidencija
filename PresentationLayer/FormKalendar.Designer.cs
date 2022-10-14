
namespace PresentationLayer
{
    partial class FormKalendar
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
            this.flowLayoutPanelDani = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSljedeca = new System.Windows.Forms.Button();
            this.buttonPrethodna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDatumKalendar = new System.Windows.Forms.Label();
            this.listBoxPrikazTermina = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelDani
            // 
            this.flowLayoutPanelDani.Location = new System.Drawing.Point(12, 58);
            this.flowLayoutPanelDani.Name = "flowLayoutPanelDani";
            this.flowLayoutPanelDani.Size = new System.Drawing.Size(790, 405);
            this.flowLayoutPanelDani.TabIndex = 0;
            // 
            // buttonSljedeca
            // 
            this.buttonSljedeca.BackColor = System.Drawing.Color.Aqua;
            this.buttonSljedeca.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSljedeca.Location = new System.Drawing.Point(727, 469);
            this.buttonSljedeca.Name = "buttonSljedeca";
            this.buttonSljedeca.Size = new System.Drawing.Size(75, 23);
            this.buttonSljedeca.TabIndex = 1;
            this.buttonSljedeca.Text = "Sljedeća";
            this.buttonSljedeca.UseVisualStyleBackColor = false;
            this.buttonSljedeca.Click += new System.EventHandler(this.buttonSljedeca_Click);
            // 
            // buttonPrethodna
            // 
            this.buttonPrethodna.BackColor = System.Drawing.Color.Aqua;
            this.buttonPrethodna.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrethodna.Location = new System.Drawing.Point(646, 469);
            this.buttonPrethodna.Name = "buttonPrethodna";
            this.buttonPrethodna.Size = new System.Drawing.Size(75, 23);
            this.buttonPrethodna.TabIndex = 2;
            this.buttonPrethodna.Text = "Prethodna";
            this.buttonPrethodna.UseVisualStyleBackColor = false;
            this.buttonPrethodna.Click += new System.EventHandler(this.buttonPrethodna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(123, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ponedjeljak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(249, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Utorak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(360, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Srijeda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(462, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Četvrtak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(580, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Petak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(709, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Subota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("FreeSans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(22, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nedjelja";
            // 
            // lblDatumKalendar
            // 
            this.lblDatumKalendar.Font = new System.Drawing.Font("FreeSans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDatumKalendar.ForeColor = System.Drawing.Color.Azure;
            this.lblDatumKalendar.Location = new System.Drawing.Point(248, -1);
            this.lblDatumKalendar.Name = "lblDatumKalendar";
            this.lblDatumKalendar.Size = new System.Drawing.Size(268, 30);
            this.lblDatumKalendar.TabIndex = 10;
            this.lblDatumKalendar.Text = "MJESEC GODINA";
            this.lblDatumKalendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxPrikazTermina
            // 
            this.listBoxPrikazTermina.Font = new System.Drawing.Font("FreeSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPrikazTermina.FormattingEnabled = true;
            this.listBoxPrikazTermina.ItemHeight = 21;
            this.listBoxPrikazTermina.Location = new System.Drawing.Point(12, 494);
            this.listBoxPrikazTermina.Name = "listBoxPrikazTermina";
            this.listBoxPrikazTermina.Size = new System.Drawing.Size(790, 88);
            this.listBoxPrikazTermina.TabIndex = 11;
            // 
            // FormKalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(814, 595);
            this.Controls.Add(this.listBoxPrikazTermina);
            this.Controls.Add(this.lblDatumKalendar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrethodna);
            this.Controls.Add(this.buttonSljedeca);
            this.Controls.Add(this.flowLayoutPanelDani);
            this.Name = "FormKalendar";
            this.Text = "Kalendar";
            this.Load += new System.EventHandler(this.FormKalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDani;
        private System.Windows.Forms.Button buttonSljedeca;
        private System.Windows.Forms.Button buttonPrethodna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDatumKalendar;
        public System.Windows.Forms.ListBox listBoxPrikazTermina;
    }
}