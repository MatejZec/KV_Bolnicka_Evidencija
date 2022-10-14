using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FormPatientsList : Form
    {
        private BindingSource _tableBindingSource = new BindingSource();
        private PacijentRepozitorij _pacijenti = new PacijentRepozitorij();
        public FormPatientsList()
        {
            InitializeComponent();
        }

        private void FormPatientsList_Load(object sender, EventArgs e)
        {
            dataGridViewPacijenti.DataSource = _tableBindingSource.DataSource = _pacijenti.GetPatients();


            DataGridViewImageColumn oDetailsbutton = new DataGridViewImageColumn();
            oDetailsbutton.Image = Image.FromFile(@"C:\Users\Gratisfaction\Pictures\med-report.png");
            oDetailsbutton.Width = 20;
            oDetailsbutton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPacijenti.Columns.Add(oDetailsbutton);
            dataGridViewPacijenti.AutoGenerateColumns = false;
        }

        private void dataGridViewPacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPacijenti.Rows[e.RowIndex].Selected = true;
            if (dataGridViewPacijenti.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                //DateTime dt = DateTime.ParseExact(dataGridViewPacijenti.Rows[e.RowIndex].Cells[4].Value.ToString(), "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

                //string s = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

                //DateTime dob = dataGridViewPacijenti.Rows[e.RowIndex].Cells[4].Value;
                FormMedRecord formMedRecord = new FormMedRecord(dataGridViewPacijenti.Rows[e.RowIndex].Cells[0].Value.ToString());
                //int number = dataGridViewPacijenti.CurrentRow.Index; 
                formMedRecord.lblFirstName.Text = dataGridViewPacijenti.Rows[e.RowIndex].Cells[2].Value.ToString();
                formMedRecord.lblLastName.Text = dataGridViewPacijenti.Rows[e.RowIndex].Cells[3].Value.ToString();
                formMedRecord.lblDOB.Text = dataGridViewPacijenti.Rows[e.RowIndex].Cells[4].Value.ToString(); 
                formMedRecord.lblContact.Text = dataGridViewPacijenti.Rows[e.RowIndex].Cells[6].Value.ToString();
                formMedRecord.lblGender.Text = dataGridViewPacijenti.Rows[e.RowIndex].Cells[5].Value.ToString();

                //

                formMedRecord.Show();

            }
        }

        private void lblPLHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajNovogPacijenta_Click(object sender, EventArgs e)
        {
            FormDodajPacijenta dodajPacijenta = new FormDodajPacijenta();
            dodajPacijenta.ShowDialog();
            dataGridViewPacijenti.DataSource = _tableBindingSource.DataSource = _pacijenti.GetPatients();
            
        }

        private void textBoxSearchP_TextChanged(object sender, EventArgs e)
        {
            dataGridViewPacijenti.DataSource = _tableBindingSource.DataSource = _pacijenti.GetPatientsSearch(textBoxSearchP.Text);
        }
    }
}
