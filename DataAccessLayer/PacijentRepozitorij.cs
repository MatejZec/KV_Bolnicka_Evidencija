using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class PacijentRepozitorij
    {
        public String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public List<Pacijent> GetPatients()
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Zec_pacijenti";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pacijenti.Add(new Pacijent()
                        {
                            MBO = (string)reader["MBO"],
                            OIB = (string)reader["OIB"],
                            Ime = (string)reader["Ime"],
                            Prezime = (string)reader["Prezime"], 
                            DOB = (DateTime)reader["DOB"],
                            Spol = (string)reader["Spol"],
                            Kontakt = (string)reader["Kontakt"]
                        });
                    }
                }
            }
            return pacijenti;
        }


        public void AddPatients(Pacijent oPacijent)
        {
            //oPacijent.DOB.ToString("yyyy-MM-dd") pazi na ovo na izlaganju (tamo je radilo bez ToString("yyyy-MM-dd"))

            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Zec_pacijenti(MBO, OIB, Ime, Prezime, DOB, Spol, Kontakt) VALUES('" + oPacijent.MBO + "', '" + oPacijent.OIB + "', '" + oPacijent.Ime + "', '" + oPacijent.Prezime + "', '" + oPacijent.DOB.ToString("yyyy-MM-dd") + "', '" + oPacijent.Spol + "', '" + oPacijent.Kontakt + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                }

            }
        }

        /*public List<Pacijent> GetPatientsShort()
        {
            List<Pacijent> pacijenti_short = new List<Pacijent>();
            List<Pacijent> pacijenti = new List<Pacijent>();
            foreach (Pacijent p in pacijenti_short.GetPatients())
            {

            }
        }*/

        public List<Pacijent> GetPatientsSearch(string pretraga)
        {
            List<Pacijent> pacijenti = new List<Pacijent>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Zec_pacijenti where Prezime like '" + pretraga + "%'";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pacijenti.Add(new Pacijent()
                        {
                            MBO = (string)reader["MBO"],
                            OIB = (string)reader["OIB"],
                            Ime = (string)reader["Ime"],
                            Prezime = (string)reader["Prezime"],
                            DOB = (DateTime)reader["DOB"],
                            Spol = (string)reader["Spol"],
                            Kontakt = (string)reader["Kontakt"]
                        });
                    }
                }
            }
            return pacijenti;
        }
    }
}
