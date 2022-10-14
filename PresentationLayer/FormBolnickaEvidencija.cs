using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FormBolnickaEvidencija : Form
    {
        private Button currentButton;
        private Form activeForm;
        private ListaCekanjaRepozitorij _waiting_list = new ListaCekanjaRepozitorij();
        private string danasnji_datum = DateTime.Now.ToString("dd.MM.yyyy");

        

        //private BindingSource _tableBindingSource = new BindingSource();
        //private PacijentRepozitorij _pacijenti = new PacijentRepozitorij();
        public FormBolnickaEvidencija()
        {
            InitializeComponent();
            btnExitToMenu.Visible = false;
        }

        private void FormBolnickaEvidencija_Load(object sender, EventArgs e)
        {
            //dataGridViewPacijenti.DataSource = _tableBindingSource.DataSource = _pacijenti.GetPatients();
            //lblDanas.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblDanas.Text = danasnji_datum;


            foreach (ListaCekanja wl in _waiting_list.GetWaitingList())
            {
                string datum = wl.Zakazano.ToString("dd.MM.yyyy");

                if (danasnji_datum == datum)
                {
                    listBoxDanas.Items.Add(wl.Ime + " " + wl.Prezime);
                }
            }

        }


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.Transparent;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    btnExitToMenu.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Azure;
                    previousBtn.ForeColor = Color.MidnightBlue;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelRadnaPovrsina.Controls.Add(childForm);
            this.panelRadnaPovrsina.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblNaslov.Text = childForm.Text;
        }


        private void dataGridViewPacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPacijenti_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPatientsList(), sender);
        }

        private void btnListaCekanja_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormListaCekanja(), sender);
        }

        

        private void btnExitToMenu_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblNaslov.Text = "POČETNA";
            currentButton = null;
            btnExitToMenu.Visible = false;
        }

        private void panelRadnaPovrsina_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDanas_Click(object sender, EventArgs e)
        {

        }

        private void btnRaspored_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKalendar(), sender);
        }
    }
}
