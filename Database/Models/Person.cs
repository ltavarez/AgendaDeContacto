using System;
using System.ComponentModel;

namespace Database.Models
{
    [Serializable]
    public class Person
    {

        [DisplayName("Codigo")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Apellido")]
        public string LastName { get; set; }

        [DisplayName("Telefono")]
        public string Phone { get; set; }
        public int IdTipoContacto { get; set; }

     


    }
}
