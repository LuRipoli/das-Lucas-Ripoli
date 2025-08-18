using Ejercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class PNormal : Paquete
    {
        private List<Canal> canales;
        private List<Cliente> clientes;

        public PNormal()
        {
            canales = new List<Canal>();
            clientes = new List<Cliente>();

            // Canales iniciales
            Canal tvp = new Canal("TV Pública");
            Canal telefe = new Canal("Telefe");
            Canal nick = new Canal("Nickelodeon");
            Canal cn = new Canal("Cartoon Network");

            canales.Add(tvp);
            canales.Add(telefe);
            canales.Add(nick);
            canales.Add(cn);

            // === Series TV Pública ===
            tvp.agregarSerie(new Serie("CocinerosArgentinos,12,400,150,70,Documental,TVPublica"));
            tvp.agregarSerie(new Serie("FestivalPais,6,90,40,72,Documental,TVPublica"));

            // === Series Telefe ===
            telefe.agregarSerie(new Serie("MasterChef,5,60,50,77,Drama,Endemol"));
            telefe.agregarSerie(new Serie("PequenosGigantes,3,30,25,73,Drama,Telefe"));

            // === Series Nickelodeon ===
            nick.agregarSerie(new Serie("ICarly,6,97,60,78,Comedia,DanSchneider"));
            nick.agregarSerie(new Serie("DrakeAndJosh,4,57,35,79,Comedia,DanSchneider"));

            // === Series Cartoon Network ===
            cn.agregarSerie(new Serie("AdventureTime,10,283,95,88,Accion,PendletonWard"));
            cn.agregarSerie(new Serie("RegularShow,8,261,90,82,Accion,JGQuintel"));

            // === Clientes Normal ===
            clientes.Add(new Cliente("N001,Sofia,Perez,50333444"));
            clientes.Add(new Cliente("N002,Julian,Garcia,51333444"));
            clientes.Add(new Cliente("N003,Valentina,Suarez,52333444"));
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
