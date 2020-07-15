using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;

namespace Database
{
    public class TipoContactoRepositoryDatabase : RepositoyBase
    {

        public TipoContactoRepositoryDatabase(SqlConnection connection) : base(connection) { }

        public List<TipoContacto> GetAll()
        {
            List<TipoContacto> list = new List<TipoContacto>();

            GetConnection().Open();

            using (SqlCommand command = new SqlCommand("Select Id,Name from TipoContacto", GetConnection()))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new TipoContacto
                    {
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Name = reader.IsDBNull(1) ? "" : reader.GetString(1)
                    });

                }

            }

            GetConnection().Close();

            return list;
        }
    
        
    }
}
