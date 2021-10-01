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
                new Estaciones{id=1,nombre="Americas - Av Boyaca",direccion="Carrera 53",coord_x= 456,coord_y= 207,Tipo= "Expresos"},
                new Estaciones{id=2,nombre="Ciudad Universitaria",direccion="Ac 26 # 33 A",coord_x= 567,coord_y= 234,Tipo= "Transferencia"},
                new Estaciones{id=3,nombre="Museo Nacional",direccion="Carrera 7",coord_x= 123,coord_y= 456,Tipo= "Ruta Facil"}
 
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetEstacionWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }


public Estaciones Create(Estaciones newEstacion)
        {
           if(estaciones.Count > 0){
           newEstacion.id=estaciones.Max(r => r.id) +1; 
            }else{
               newEstacion.id = 1; 
            }
           estaciones.Add(newEstacion);
           return newEstacion;
        }


        public Estaciones Update(Estaciones newEstacion){
            var estacion= estaciones.SingleOrDefault(b => b.id == newEstacion.id);
            if(estacion != null){
                estacion.nombre = newEstacion.nombre;
                estacion.direccion = newEstacion.direccion;
                estacion.coord_x = newEstacion.coord_x;
                estacion.coord_y = newEstacion.coord_y;
                estacion.Tipo = newEstacion.Tipo;
            }
        return estacion;
        }

public Estaciones Delete(int id)
        {
        var estacion = estaciones.SingleOrDefault(e => e.id == id);
        estaciones.Remove(estacion);
        return estacion;
        }


    }
}
