using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class KartonRepozitorij
    {
        public String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public List<Karton> GetMedRecords(string userid)
        {
            List<Karton> kartoni = new List<Karton>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Zec_kartoni WHERE PacijentId='"+userid+"'";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kartoni.Add(new Karton()
                        {
                            Id = (int)reader["Id"],
                            PacijentId = (string)reader["PacijentId"],
                            Datum = (DateTime)reader["Datum"],
                            Opis = (string)reader["Opis"],
                            Dijagnoza = (string)reader["Dijagnoza"],
                            Status = (string)reader["Status"],
                            Preporuka = (string)reader["Preporuka"]
                        });
                    }
                }
            }
            return kartoni;
        }

        public void AddKarton(Karton oKarton)
        {

            //oKarton.Datum.ToString("yyyy-MM-dd") pazi na ovo na izlaganju (tamo je radilo bez ToString("yyyy-MM-dd"))

            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Zec_kartoni(PacijentId, Datum, Opis, Dijagnoza, Status, Preporuka) VALUES('" + oKarton.PacijentId + "', '" + oKarton.Datum.ToString("yyyy-MM-dd") + "', '" + oKarton.Opis + "', '" + oKarton.Dijagnoza + "', '" + oKarton.Status + "', '" + oKarton.Preporuka+ "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                }

            }
        }
    }
}
