using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Program
{
    class Gondola
    {

        private List<Producto> gondolaDeProductos;
        
        public ReadOnlyCollection<Producto> GondolaDeProductos
        {
            get
            {
                return this.gondolaDeProductos.AsReadOnly();
            }
        }
        public Gondola() 
        { 
            this.gondolaDeProductos = new List<Producto>();
        } 

        
        public void AgregarProducto(Producto producto)
        {
            this.gondolaDeProductos.Add(producto);
        }

        public void EliminarProducto(string codigoProducto)
        {
            foreach (Producto producto in gondolaDeProductos)
            {
                if (producto.Codigo == codigoProducto)
                {
                    gondolaDeProductos.Remove(producto);
                    Console.WriteLine("Producto eliminado");
                    break;
                }
            }
        }

        

    }
}
