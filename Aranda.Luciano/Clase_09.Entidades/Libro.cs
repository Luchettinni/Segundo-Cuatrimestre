using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_09.Entidades
{
    public class Libro
    {
        string titulo;
        string autor;
        List<Capitulo> capitulos;

        public string Titulo { get { return this.titulo; } }
        public string Autor { get { return this.autor; } }
        public int CantiadDePaginas
        {
            get
            {
                int cantidadDePaginas = 0; 

                foreach ( Capitulo capi in this.capitulos )
                {
                    cantidadDePaginas += capi.Paginas; 
                }

                return cantidadDePaginas;
            }
        }

        public int CantidadDeCapitulos
        {
            get
            {
                return this.capitulos.Count;
            }
        }

        public Capitulo this[int index]
        {
            get
            {
                if ( index < 0 && index > this.capitulos.Count )
                {
                    return null;
                }
                else
                {
                    return capitulos[index];
                }
            }
            set
            {
                if ( index == this.capitulos.Count )
                {
                    this.capitulos.Add(value);
                }
                else
                {
                    if( index >= 0 && index <= this.capitulos.Count  )
                    {
                        this.capitulos[index]= value;
                    }
                    
                }
            }
        }

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.capitulos = new List<Capitulo>();
        }
    }
}
