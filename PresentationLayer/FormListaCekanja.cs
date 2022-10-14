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
    public partial class FormListaCekanja : Form
    {
        private BindingSource _tableBindingSource = new BindingSource();
        private ListaCekanjaRepozitorij _waiting_list = new ListaCekanjaRepozitorij();
        private PacijentRepozitorij _pacijenti = new PacijentRepozitorij();
        public FormListaCekanja()
        {
            InitializeComponent();
        }

        private void FormListaCekanja_Load(object sender, EventArgs e)
        {
            //dataGridViewLC.AutoGenerateColumns = false;
            //dataGridViewLC.DataSource = _tableBindingSource.DataSource = _waiting_list.GetWaitingList();
            BindGrid();



            DataGridViewImageColumn oDetailsbutton = new DataGridViewImageColumn();
            oDetailsbutton.Image = Image.FromFile(@"C:\Users\Gratisfaction\Pictures\pregled.png");
            oDetailsbutton.Width = 20;
            oDetailsbutton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewLC.Columns.Add(oDetailsbutton);
            dataGridViewLC.AutoGenerateColumns = false;

        }
        public void BindGrid()
        {
            dataGridViewLC.DataSource = _tableBindingSource.DataSource = _waiting_list.GetWaitingList();
        }
        private void dataGridViewLC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLC.Rows[e.RowIndex].Selected = true;
            if (dataGridViewLC.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                string pacijent_id = dataGridViewLC.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormPregled formPregled = new FormPregled(pacijent_id);
                formPregled.lblMBO.Text = pacijent_id;
                formPregled.ShowDialog();
                BindGrid();
                /*foreach (Pacijent p in _pacijenti.GetPatients())
                {
                    if (p.MBO == index)
                    {
                        FormMedRecord formMedRecord = new FormMedRecord(index);
                        //int number = dataGridViewPacijenti.CurrentRow.Index; 
                        formMedRecord.lblFirstName.Text = dataGridViewLC.Rows[e.RowIndex].Cells[3].Value.ToString();
                        formMedRecord.lblLastName.Text = dataGridViewLC.Rows[e.RowIndex].Cells[4].Value.ToString();
                        formMedRecord.lblDOB.Text = p.DOB.ToString("dd.MM.yyyy"); ;//dataGridViewLC.Rows[e.RowIndex].Cells[4].Value.ToString();
                        formMedRecord.lblContact.Text = p.Kontakt;//dataGridViewLC.Rows[e.RowIndex].Cells[6].Value.ToString();
                        formMedRecord.lblGender.Text = p.Spol;//dataGridViewLC.Rows[e.RowIndex].Cells[5].Value.ToString();

                        //

                        formMedRecord.Show();
                    }
                }*/








            }
        }
    }
}
