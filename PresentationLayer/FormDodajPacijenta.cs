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
    public partial class FormDodajPacijenta : Form
    {
        public FormDodajPacijenta()
        {
            InitializeComponent();
        }


        private void FormDodajPacijenta_Load(object sender, EventArgs e)
        {
            dateTimePickerNoviDOB.Format = DateTimePickerFormat.Custom;
            dateTimePickerNoviDOB.CustomFormat = "yyyy-MM-dd";
        }

        private void btnNoviDodaj_Click(object sender, EventArgs e)
        {
            PacijentRepozitorij p1 = new PacijentRepozitorij();
            Pacijent pacijent = new Pacijent();
            try
            {
                pacijent.MBO = textBoxNoviMBO.Text;
                if (textBoxNoviMBO.Text.Length != 9)
                {
                    throw new Exception("MBO se mora sastojati od 9 brojeva");
                }
                pacijent.OIB = textBoxNoviOIB.Text;
                if (textBoxNoviOIB.Text.Length != 11)
                {
                    throw new Exception("OIB se mora sastojati od 11 brojeva");
                }
                pacijent.Ime = textBoxNoviIme.Text;
                pacijent.Prezime = textBoxNoviPrezime.Text;
                pacijent.DOB = dateTimePickerNoviDOB.Value.Date;
                if (checkBoxNoviSpolM.Checked)
                {
                    pacijent.Spol = checkBoxNoviSpolM.Text;
                }
                else
                {
                    pacijent.Spol = checkBoxNoviSpolF.Text;
                }
                pacijent.Kontakt = textBoxNoviKontakt.Text;
                p1.AddPatients(pacijent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            


            
            this.Hide();
            this.Close();
        }

        private void textBoxNoviKontakt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
