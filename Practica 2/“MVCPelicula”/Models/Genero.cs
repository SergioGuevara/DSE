﻿using MVCPelicula.Models;

namespace _MVCPelicula_.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Propiedad de navegación
        public ICollection<Pelicula> Peliculas { get; set; }
    }

}
