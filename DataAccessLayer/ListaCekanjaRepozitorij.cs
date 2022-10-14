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
    public class ListaCekanjaRepozitorij
    {
        public String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public List<ListaCekanja> GetWaitingList()
        {
            List<ListaCekanja> waiting_list = new List<ListaCekanja>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Zec_listaCekanja";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        waiting_list.Add(new ListaCekanja()
                        {
                            Id = (int)reader["Id"],
                            Pacijent_Id = (string)reader["Pacijent_Id"],
                            Zakazano = (DateTime)reader["Zakazano"],
                            Ime = (string)reader["Ime"],
                            Prezime = (string)reader["Prezime"]
                        });
                    }
                }
            }
            return waiting_list;
        }


        public void DeleteListaCekanja(string pacijent_id)
        {
            //oPacijent.DOB.ToString("yyyy-MM-dd") pazi na ovo na izlaganju (tamo je radilo bez ToString("yyyy-MM-dd"))

            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Zec_listaCekanja WHERE Pacijent_Id = '" + pacijent_id +"'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                }

            }
        }
        




    }
}
