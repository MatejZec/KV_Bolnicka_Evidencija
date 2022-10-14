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
    public partial class FormKalendar : Form
    {
        private ListaCekanjaRepozitorij _waiting_list = new ListaCekanjaRepozitorij();
        int mjesec, godina;
        public static int static_mjesec, static_godina;
        public FormKalendar()
        {
            InitializeComponent();
        }

        private void FormKalendar_Load(object sender, EventArgs e)
        {
            PrikaziDane();
        }
        
        public void PrikazTermina(string odabrani_datum)
        {
            /*foreach (ListaCekanja wl in _waiting_list.GetWaitingList())
            {
                string datum = wl.Zakazano.ToString("dd.MM.yyyy");

                if (odabrani_datum == datum)
                {
                    listBoxPrikazTermina.Items.Add(wl.Ime + " " + wl.Prezime);
                    
                }
            }
            listBoxPrikazTermina.Show();*/
            
        }
        private void PrikaziDane()
        {
            
            DateTime now = DateTime.Now;
            mjesec = now.Month;
            godina = now.Year;

            String mjesec_ime = DateTimeFormatInfo.CurrentInfo.GetMonthName(mjesec);
            lblDatumKalendar.Text = mjesec_ime + " " + godina;

            static_mjesec = mjesec;
            static_godina = godina;

            DateTime pocetak_mjeseca = new DateTime(godina, mjesec, 1);

            int dani = DateTime.DaysInMonth(godina, mjesec);

            int dani_u_tjednu = Convert.ToInt32(pocetak_mjeseca.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dani_u_tjednu; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDani.Controls.Add(ucblank);
            }

            for (int i = 1; i <= dani; i++)
            {
                UserControlDani ucdani = new UserControlDani();
                ucdani.Dani(i);
                flowLayoutPanelDani.Controls.Add(ucdani); 
            }
        }

        private void buttonPrethodna_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDani.Controls.Clear();

            if (mjesec != 1)

            {

                mjesec--;

            }

            else

            {

                mjesec = 12;

                godina--;

            }

            //mjesec--;

            static_mjesec = mjesec;
            static_godina = godina;

            String mjesec_ime = DateTimeFormatInfo.CurrentInfo.GetMonthName(mjesec);
            lblDatumKalendar.Text = mjesec_ime + " " + godina;

            DateTime pocetak_mjeseca = new DateTime(godina, mjesec, 1);

            int dani = DateTime.DaysInMonth(godina, mjesec);

            int dani_u_tjednu = Convert.ToInt32(pocetak_mjeseca.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dani_u_tjednu; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDani.Controls.Add(ucblank);
            }

            for (int i = 1; i <= dani; i++)
            {
                UserControlDani ucdani = new UserControlDani();
                ucdani.Dani(i);
                flowLayoutPanelDani.Controls.Add(ucdani);
            }
        }

        private void buttonSljedeca_Click(object sender, EventArgs e)
        {
            //prazan panel za novi mjesec
            flowLayoutPanelDani.Controls.Clear();

            if (mjesec != 12)

            {

                mjesec++;

            }

            else

            {

                mjesec = 1;

                godina++;

            }


            //mjesec++;

            static_mjesec = mjesec;
            static_godina = godina;

            String mjesec_ime = DateTimeFormatInfo.CurrentInfo.GetMonthName(mjesec);
            lblDatumKalendar.Text = mjesec_ime + " " + godina;

            DateTime pocetak_mjeseca = new DateTime(godina, mjesec, 1);

            int dani = DateTime.DaysInMonth(godina, mjesec);

            int dani_u_tjednu = Convert.ToInt32(pocetak_mjeseca.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dani_u_tjednu; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanelDani.Controls.Add(ucblank);
            }

            for (int i = 1; i <= dani; i++)
            {
                UserControlDani ucdani = new UserControlDani();
                ucdani.Dani(i);
                flowLayoutPanelDani.Controls.Add(ucdani);
            }
        }
    }
}
