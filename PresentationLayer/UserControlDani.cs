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
    public partial class UserControlDani : UserControl
    {

        private ListaCekanjaRepozitorij _waiting_list = new ListaCekanjaRepozitorij();
        public static string static_dan;
        public static string static_mjesec;
        public static string static_godina;
        private BindingSource binding1;
        public UserControlDani()
        {
            InitializeComponent();
        }

        private void UserControlDani_Load(object sender, EventArgs e)
        {

        }

        public void Dani(int broj_dan)
        {
            lblDani.Text = broj_dan + "";
        }

        private void UserControlDani_Click(object sender, EventArgs e)
        {
            static_dan = lblDani.Text;
            static_mjesec = FormKalendar.static_mjesec.ToString();
            static_godina = FormKalendar.static_godina.ToString();
            string odabrani_datum = static_dan + "." + static_mjesec + "." + static_godina;

            //MessageBox.Show(odabrani_datum);
            FormKalendar fk1 = new FormKalendar();
            //fk1.PrikazTermina(odabrani_datum);
            //fk1.ShowDialog();
            List<string> lista_imena = new List<string>();
            binding1 = new BindingSource();
            foreach (ListaCekanja wl in _waiting_list.GetWaitingList())
            {
                string datum = wl.Zakazano.ToString("d.M.yyyy");

                if (odabrani_datum == datum)
                {
                    lista_imena.Add(wl.Ime + " " + wl.Prezime);
                    /*binding1.DataSource = lista_imena;
                    fk1.listBoxPrikazTermina.DataSource = binding1;
                    fk1.listBoxPrikazTermina.Refresh();
                    fk1.listBoxPrikazTermina.Update();
                    //fk1.listBoxPrikazTermina.Items.Add(wl.Ime + " " + wl.Prezime);
                    fk1.Show();*/

                }
            }
            binding1.DataSource = lista_imena;
            fk1.listBoxPrikazTermina.DataSource = binding1;
            fk1.Show();

        }
    }
}
