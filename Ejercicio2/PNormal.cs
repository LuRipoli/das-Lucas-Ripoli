using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class PNormal:Paquete
    {
        private List<Canal> canales;
        private List<Cliente> clientes;

        public PNormal()
        {
            canales = new List<Canal>();
            clientes = new List<Cliente>();
        }

        public void agregarCanal(Canal c)
        {
            canales.Add(c);
        }

        public void agregarCliente(Cliente cl)
        {
            clientes.Add(cl);
        }

        public void borrarCanal(Canal c)
        {
            canales.Remove(c);
        }

        public void borrarCliente(Cliente cl)
        {
            clientes.Remove(cl);
        }

        public Canal buscarCanal(string nombre)
        {
            return canales.FirstOrDefault(x => x.Nombre == nombre);
        }

        public Cliente buscarCliente(string nombre)
        {
            return clientes.FirstOrDefault(x => x.Nombre == nombre);
        }

        public List<Canal> devolverCanales()
        {
            return canales;
        }

        public List<Cliente> devolverClientes()
        {
            return clientes;
        }
    }
}
