using System;
using System.Collections.Generic;

namespace Program
{
    class Producto
    {
        private string nombre; 

        private string codigo; 

        private int precio;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    this.nombre = "Error";
                }
                else
                {
                    this.nombre=value;
                }
            }

        }

        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    this.codigo="Error";
                }
                else
                {
                    this.codigo = value;
                    
                }
            }
        }

        public int Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if(value > 0)
                {
                    this.precio = value;
                }
                else
                {
                    this.precio=-1;
                    
                }
            }
        }


        public Producto(string nombre, string codigo, int precio) 
        { 
            this.Nombre = nombre; 
            this.Codigo = codigo;
            this.Precio = precio;
        } 

        public void VerProducto() 
        { 
            Console.WriteLine( 
                $"Codigo:{this.codigo}, Nombre:{this.nombre}, Precio:{this.precio}"); 
        } 
    }
}
