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
    public class PersonRepositoryDatabase : RepositoyBase , IRepository<Person>
    {

        public PersonRepositoryDatabase(SqlConnection connection) : base(connection) { }

    
        public bool Add(Person item)
        {
            SqlCommand command = new SqlCommand("insert into Persona(Nombre,Apellido,Telefono,IdTipoContacto) " +
                                                "values(@name,@lastname,@phone,@contactType)",
                                                GetConnection());
            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@contactType", item.IdTipoContacto);


            return ExecuteDml(command);

        }

        public bool Edit(Person item)
        {
            SqlCommand command = new SqlCommand("update Persona set Nombre=@name,Apellido=@lastname,Telefono=@phone,IdTipoContacto=@contactType where Id = @id",
               GetConnection());

            command.Parameters.AddWithValue("@id", item.Id);
            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@contactType", item.IdTipoContacto);


            return ExecuteDml(command);
        }

        public bool SavePhoto(int id,string destination)
        {
            SqlCommand command = new SqlCommand("update Persona set FotoPerfil=@foto where Id = @id",
                GetConnection());

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@foto", destination);

            return ExecuteDml(command);
        }

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Persona where Id = @id",
                GetConnection());

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public DataTable List()
        {
            SqlDataAdapter query = new SqlDataAdapter(" select p.Id, p.Nombre, p.Apellido, P.Telefono, tc.Name as 'Tipo de contacto' from Persona p inner join TipoContacto tc on p.IdTipoContacto = tc.Id", GetConnection());
            return LoadData(query);
        }

        public int GetLastId()
        {
            int lastId = 0;

            GetConnection().Open();

            using (SqlCommand command = new SqlCommand("select max(Id) as Id from Persona",GetConnection()))
            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    lastId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                }
                
            }

            GetConnection().Close();

            return lastId;

        }

        public string GetPhotoPath(int id)
        {
            string path = "";

            GetConnection().Open();

            SqlCommand command = new SqlCommand("select FotoPerfil from Persona where Id=@id", GetConnection());
            command.Parameters.AddWithValue("@id", id);


            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    path = reader.IsDBNull(0) ? "" : reader.GetString(0);
                }

            }

            GetConnection().Close();

            return path;

        }
    }
}
