using Database;
using Database.Models;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class PersonService : IService<Person>
    {

        public Serializador Serializador;
        public string Directory;
        public string FileName;

        private readonly PersonRepositoryDatabase _repository;

        public PersonService(SqlConnection connection)
        {
            Serializador = new Serializador();
            Directory = "Persons";
            FileName = "persons.dat";

            _repository = new PersonRepositoryDatabase(connection);
        }

        public void Add(Person item)
        {
            _repository.Add(item);
        }

        public void Edit(Person item)
        {
            _repository.Edit(item);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public DataTable GetAll()
        {
            return _repository.List();
        }

        public int GetLastId()
        {
            return _repository.GetLastId();
        }

        public bool SavePhoto(int id, string destination)
        {
            return _repository.SavePhoto(id, destination);
        }

        public string GetPhotoPath(int id)
        {
            return _repository.GetPhotoPath(id);
        }


    }
}
