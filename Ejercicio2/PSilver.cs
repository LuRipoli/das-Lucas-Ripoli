using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class PSilver : Paquete
    {
        private List<Canal> canales;
        private List<Cliente> clientes;

        public PSilver()
        {
            canales = new List<Canal>();
            clientes = new List<Cliente>();

            // === Canales iniciales ===
            Canal fox = new Canal("FOX");
            Canal history = new Canal("History");
            Canal c5n = new Canal("C5N");
            Canal tyc = new Canal("TycSport");

            canales.Add(fox);
            canales.Add(history);
            canales.Add(c5n);
            canales.Add(tyc);

            // === Series FOX ===
            fox.agregarSerie(new Serie("TheSimpsons,34,750,300,85,Comedy,MattGroening"));
            fox.agregarSerie(new Serie("PrisonBreak,5,90,65,81,Drama,PaulScheuring"));
            fox.agregarSerie(new Serie("24,9,204,150,83,Action,JoelSurnow"));

            // === Series History ===
            history.agregarSerie(new Serie("Vikings,6,89,70,86,Drama,MichaelHirst"));
            history.agregarSerie(new Serie("TheUniverse,7,88,60,84,Documentary,MorganFreeman"));
            history.agregarSerie(new Serie("AncientAliens,18,200,140,77,Documentary,HistoryTeam"));

            // === Series C5N ===
            c5n.agregarSerie(new Serie("MinutoUno,10,200,100,70,News,GustavoSylvestre"));
            c5n.agregarSerie(new Serie("EconomiaHoy,8,150,80,73,News,C5NTeam"));
            c5n.agregarSerie(new Serie("PoliticaAlDia,12,250,120,75,News,C5NPolitica"));

            // === Series TyC Sports ===
            tyc.agregarSerie(new Serie("PasoAPaso,20,400,150,82,Sports,TyCTeam"));
            tyc.agregarSerie(new Serie("PlanetaGol,15,300,120,84,Sports,ArielRodriguez"));
            tyc.agregarSerie(new Serie("BoxeoDePrimera,10,120,90,79,Sports,OsvaldoPrincipi"));

            // === Clientes iniciales ===
            clientes.Add(new Cliente("S001,Pablo,Rojas,41333444"));
            clientes.Add(new Cliente("S002,María,López,42333444"));
            clientes.Add(new Cliente("S003,Carolina,Sosa,43333444"));
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
