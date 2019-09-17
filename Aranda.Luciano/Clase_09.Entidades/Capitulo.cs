using System;

namespace Clase_09.Entidades
{
    public class Capitulo
    {

        #region Atributos
        // de instancia
        private int numero;
        private string titulo;
        private int paginas;

        //de clase
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;
        #endregion

        #region Propiedades
        public int Numero { get { return this.numero; } }
        public string Titulo { get { return this.titulo; } }
        public int Paginas { get { return this.paginas; } }
        #endregion

        #region Construtores

        static Capitulo()
        {
            generadorDeNumeros = new Random();
            generadorDePaginas = new Random();
        }

        private Capitulo(int num, string ttl, int pag)
        {
            this.numero = num;
            this.titulo = ttl;
            this.paginas = pag;
        }

        public static implicit operator Capitulo(string kevin)
        {
            return new Capitulo(generadorDeNumeros.Next(1, 65), kevin, generadorDePaginas.Next(15, 233));
        }

        public static bool operator  ==(Capitulo cap1 , Capitulo cap2)
        {
            bool retorno = false;
            if ( Object.Equals(cap1.numero, cap2.numero) && Object.Equals(cap1.titulo, cap2.titulo))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Capitulo cap1, Capitulo cap2)
        {
            bool retorno = false;
            if ( !(cap1 == cap2) )
            {
                retorno = true;
            }
            return retorno;
        }

        #endregion


    }
}
