using Prueba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.API
{
    public class APIWeb
    {
        public Persona EncontrarPersona(int a)
        {
            List<Persona> list = new List<Persona>();
            list.Add(new Persona { Id = 1, Nombre = "Nombre 1", Apellido = "Apellido 1" });
            list.Add(new Persona { Id = 2, Nombre = "Nombre 2", Apellido = "Apellido 2" });
            list.Add(new Persona { Id = 3, Nombre = "Nombre 3", Apellido = "Apellido 3" });
            list.Add(new Persona { Id = 4, Nombre = "Nombre 4", Apellido = "Apellido 4" });
            list.Add(new Persona { Id = 5, Nombre = "Nombre 5", Apellido = "Apellido 5" });

            return list.Where(s => s.Id == a).FirstOrDefault();
        }
    }
}
