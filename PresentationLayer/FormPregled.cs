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
    public partial class FormPregled : Form
    {
        ListaCekanjaRepozitorij lcr = new ListaCekanjaRepozitorij();
        public string _pacijent_id;
        public FormPregled(string pacijent_id)
        {
            InitializeComponent();
            _pacijent_id = pacijent_id;
        }

        private void FormPregled_Load(object sender, EventArgs e)
        {
            dateTimePickerDP.Format = DateTimePickerFormat.Custom;
            dateTimePickerDP.CustomFormat = "yyyy-MM-dd";
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            KartonRepozitorij k1 = new KartonRepozitorij();
            Karton karton = new Karton();
            //user.UserID = Int32.Parse(textUserName.Text);
            karton.PacijentId = lblMBO.Text;
            karton.Datum = dateTimePickerDP.Value.Date;
            karton.Opis = richTextBoxOpis.Text;
            karton.Dijagnoza = richTextBoxDijagnoza.Text;
            karton.Status = richTextBoxStatus.Text;
            karton.Preporuka = richTextBoxPreporuka.Text;
            //user.UserLastName = textSurname.Text;
            //user.UserPassword = textPassword.Text;
            //user.UserName = textUserName.Text;

            k1.AddKarton(karton);


            lcr.DeleteListaCekanja(_pacijent_id);
            /*FormListaCekanja flc = new FormListaCekanja();
            //flc.dataGridViewLC.DataSource = _tableBindingSource.DataSource = _waiting_list.GetWaitingList();
            flc.BindGrid();
            flc.Show();*/

            this.Hide();
            this.Close();
        }

        private void lblMBO_Click(object sender, EventArgs e)
        {

        }
    }
}
