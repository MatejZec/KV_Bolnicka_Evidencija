
namespace PresentationLayer
{
    partial class FormBolnickaEvidencija
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelRadnaPovrsina = new System.Windows.Forms.Panel();
            this.listBoxDanas = new System.Windows.Forms.ListBox();
            this.lblDanas = new System.Windows.Forms.Label();
            this.lblRaspored = new System.Windows.Forms.Label();
            this.btnExitToMenu = new System.Windows.Forms.Button();
            this.btnRaspored = new System.Windows.Forms.Button();
            this.btnListaCekanja = new System.Windows.Forms.Button();
            this.btnPacijenti = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelRadnaPovrsina.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Azure;
            this.panelMenu.Controls.Add(this.btnRaspored);
            this.panelMenu.Controls.Add(this.btnListaCekanja);
            this.panelMenu.Controls.Add(this.btnPacijenti);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 568);
            this.panelMenu.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Aqua;
            this.panelTitleBar.Controls.Add(this.btnExitToMenu);
            this.panelTitleBar.Controls.Add(this.lblNaslov);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(897, 80);
            this.panelTitleBar.TabIndex = 2;
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNaslov.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNaslov.Location = new System.Drawing.Point(385, 25);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(120, 25);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "POČETNA";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRadnaPovrsina
            // 
            this.panelRadnaPovrsina.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelRadnaPovrsina.Controls.Add(this.listBoxDanas);
            this.panelRadnaPovrsina.Controls.Add(this.lblDanas);
            this.panelRadnaPovrsina.Controls.Add(this.lblRaspored);
            this.panelRadnaPovrsina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRadnaPovrsina.Location = new System.Drawing.Point(220, 80);
            this.panelRadnaPovrsina.Name = "panelRadnaPovrsina";
            this.panelRadnaPovrsina.Size = new System.Drawing.Size(897, 488);
            this.panelRadnaPovrsina.TabIndex = 3;
            this.panelRadnaPovrsina.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRadnaPovrsina_Paint);
            // 
            // listBoxDanas
            // 
            this.listBoxDanas.Font = new System.Drawing.Font("FreeSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDanas.FormattingEnabled = true;
            this.listBoxDanas.ItemHeight = 21;
            this.listBoxDanas.Location = new System.Drawing.Point(142, 70);
            this.listBoxDanas.Name = "listBoxDanas";
            this.listBoxDanas.Size = new System.Drawing.Size(265, 130);
            this.listBoxDanas.TabIndex = 2;
            // 
            // lblDanas
            // 
            this.lblDanas.AutoSize = true;
            this.lblDanas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDanas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDanas.Location = new System.Drawing.Point(277, 33);
            this.lblDanas.Name = "lblDanas";
            this.lblDanas.Size = new System.Drawing.Size(71, 25);
            this.lblDanas.TabIndex = 1;
            this.lblDanas.Text = "danas";
            this.lblDanas.Click += new System.EventHandler(this.lblDanas_Click);
            // 
            // lblRaspored
            // 
            this.lblRaspored.AutoSize = true;
            this.lblRaspored.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRaspored.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRaspored.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRaspored.Location = new System.Drawing.Point(146, 33);
            this.lblRaspored.Name = "lblRaspored";
            this.lblRaspored.Size = new System.Drawing.Size(134, 25);
            this.lblRaspored.TabIndex = 0;
            this.lblRaspored.Text = "Raspored za";
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExitToMenu.FlatAppearance.BorderSize = 0;
            this.btnExitToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitToMenu.Image = global::PresentationLayer.Properties.Resources.return_home;
            this.btnExitToMenu.Location = new System.Drawing.Point(0, 0);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(75, 80);
            this.btnExitToMenu.TabIndex = 1;
            this.btnExitToMenu.UseVisualStyleBackColor = true;
            this.btnExitToMenu.Click += new System.EventHandler(this.btnExitToMenu_Click);
            // 
            // btnRaspored
            // 
            this.btnRaspored.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaspored.FlatAppearance.BorderSize = 0;
            this.btnRaspored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaspored.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRaspored.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRaspored.Image = global::PresentationLayer.Properties.Resources.raspored;
            this.btnRaspored.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaspored.Location = new System.Drawing.Point(0, 200);
            this.btnRaspored.Name = "btnRaspored";
            this.btnRaspored.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRaspored.Size = new System.Drawing.Size(220, 60);
            this.btnRaspored.TabIndex = 3;
            this.btnRaspored.Text = "   Raspored";
            this.btnRaspored.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaspored.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRaspored.UseVisualStyleBackColor = true;
            this.btnRaspored.Click += new System.EventHandler(this.btnRaspored_Click);
            // 
            // btnListaCekanja
            // 
            this.btnListaCekanja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaCekanja.FlatAppearance.BorderSize = 0;
            this.btnListaCekanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaCekanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnListaCekanja.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnListaCekanja.Image = global::PresentationLayer.Properties.Resources.lista_cekanja;
            this.btnListaCekanja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaCekanja.Location = new System.Drawing.Point(0, 140);
            this.btnListaCekanja.Name = "btnListaCekanja";
            this.btnListaCekanja.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnListaCekanja.Size = new System.Drawing.Size(220, 60);
            this.btnListaCekanja.TabIndex = 2;
            this.btnListaCekanja.Text = "   Lista Čekanja";
            this.btnListaCekanja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaCekanja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaCekanja.UseVisualStyleBackColor = true;
            this.btnListaCekanja.Click += new System.EventHandler(this.btnListaCekanja_Click);
            // 
            // btnPacijenti
            // 
            this.btnPacijenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacijenti.FlatAppearance.BorderSize = 0;
            this.btnPacijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPacijenti.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPacijenti.Image = global::PresentationLayer.Properties.Resources.pacijenti;
            this.btnPacijenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacijenti.Location = new System.Drawing.Point(0, 80);
            this.btnPacijenti.Name = "btnPacijenti";
            this.btnPacijenti.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPacijenti.Size = new System.Drawing.Size(220, 60);
            this.btnPacijenti.TabIndex = 1;
            this.btnPacijenti.Text = "   Pacijenti";
            this.btnPacijenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacijenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPacijenti.UseVisualStyleBackColor = true;
            this.btnPacijenti.Click += new System.EventHandler(this.btnPacijenti_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.BackgroundImage = global::PresentationLayer.Properties.Resources.Untitled;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // FormBolnickaEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1117, 568);
            this.Controls.Add(this.panelRadnaPovrsina);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormBolnickaEvidencija";
            this.Text = "FormBolnickaEvidencija";
            this.Load += new System.EventHandler(this.FormBolnickaEvidencija_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelRadnaPovrsina.ResumeLayout(false);
            this.panelRadnaPovrsina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPacijenti;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnListaCekanja;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panelRadnaPovrsina;
        private System.Windows.Forms.Button btnExitToMenu;
        private System.Windows.Forms.Label lblRaspored;
        private System.Windows.Forms.Label lblDanas;
        private System.Windows.Forms.ListBox listBoxDanas;
        private System.Windows.Forms.Button btnRaspored;
    }
}

