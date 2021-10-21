using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Libro
    {
        private string titulo;
        private string autor;
        private string codigo;

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        

       public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public Libro()
        {
            titulo = "";
            autor = "";
            codigo = "";
        }

        public Libro(string titulo, string autor, string codigo)

        {
            this.titulo = titulo;
            this.autor = autor;
            this.codigo = codigo;
        }

        public override string ToString()
        {
            return " El titulo es " + titulo   +  " su autor es " + autor  +  " y su codigo es " + codigo ;
        }
        

    }
}
