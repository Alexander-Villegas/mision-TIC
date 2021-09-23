using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Estacion 1",direccion= "Calle 7 # 10a -24",coord_x= 12,coord_y= 4,Tipo= "Transferencia"},
                new Estaciones{id=2,nombre="Estacion 2",direccion= "Calle 24 # 12 -14",coord_x= 2,coord_y= 24,Tipo= "Transferencia"},
                new Estaciones{id=3,nombre="Estacion 3",direccion= "Carrera 19 # 24 -08",coord_x= 9,coord_y= 33,Tipo= "Transferencia"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetEstacionWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}
