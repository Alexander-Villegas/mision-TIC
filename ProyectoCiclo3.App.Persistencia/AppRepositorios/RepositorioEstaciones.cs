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
                new Estaciones{id=1,nombre="Americas - Av Boyaca",coord_x= 456,coord_y= 207,Tipo= "Expresos"},
                new Estaciones{id=2,nombre="Ciudad Universitaria",coord_x= 567,coord_y= 234,Tipo= "Transferencia"},
                new Estaciones{id=3,nombre="Museo Nacional",coord_x= 123,coord_y= 456,Tipo= "Ruta Facil"}
 
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
