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
    public partial class FormMedRecord : Form
    {
        private BindingSource _tableBindingSource = new BindingSource();
        private PacijentRepozitorij _pacijenti = new PacijentRepozitorij();
        private KartonRepozitorij _kartoni = new KartonRepozitorij();
        public FormMedRecord(string userid)
        {
            InitializeComponent();

            dataGridViewMedRecord.DataSource = _tableBindingSource.DataSource = _kartoni.GetMedRecords(userid);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMedRecord_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewMedRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Gratisfaction\source\repos\FinalBEKVMZ\KVBolnickaEvidencijaMZ\MedKarton.txt");
            try
            {
                string tekst =
                    "Ime: " + lblFirstName.Text + "        " + "Datum rođenja: " + lblDOB.Text +
                    "\nPrezime: " + lblLastName.Text + "        " + "Kontakt: " + lblContact.Text +
                    "\nSpol: " + lblGender.Text;
                file.WriteLine(tekst);


                string sLine = "";
                
                
                for (int r = 0; r <= dataGridViewMedRecord.Rows.Count - 1; r++)
                {
                    
                    for (int c = 0; c <= dataGridViewMedRecord.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dataGridViewMedRecord.Rows[r].Cells[c].Value;
                        if (c != dataGridViewMedRecord.Columns.Count - 1)
                        {
                            
                            sLine = sLine + ",";
                        }
                    }
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                System.Windows.Forms.MessageBox.Show("Ispis završen.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
