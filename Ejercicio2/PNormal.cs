using Ejercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class PPremium : Paquete
    {
        private List<Canal> canales;
        private List<Cliente> clientes;

        public PPremium()
        {
            canales = new List<Canal>();
            clientes = new List<Cliente>();

            // Canales iniciales
            Canal hbo = new Canal("HBO");
            Canal espn = new Canal("ESPN");
            Canal natgeo = new Canal("NatGeo");
            Canal discovery = new Canal("Discovery");

            canales.Add(hbo);
            canales.Add(espn);
            canales.Add(natgeo);
            canales.Add(discovery);

            // === Series HBO ===
            hbo.agregarSerie(new Serie("Chernobyl,1,5,5,95,Drama,JohanRenck"));
            hbo.agregarSerie(new Serie("GameOfThrones,8,73,70,88,Fantasy,DavidBenioff"));
            hbo.agregarSerie(new Serie("TheLastOfUs,1,9,9,92,Drama,CraigMazin"));

            // === Series ESPN ===
            espn.agregarSerie(new Serie("SportsCenter,30,300,120,80,Sports,ESPNStudio"));
            espn.agregarSerie(new Serie("FutbolTotal,12,180,90,78,Sports,ESPNLatam"));
            espn.agregarSerie(new Serie("BoxeoDePrimera,15,200,85,82,Sports,TyC"));

            // === Series NatGeo ===
            natgeo.agregarSerie(new Serie("PlanetEarth,2,11,10,95,Documentary,AlastairFothergill"));
            natgeo.agregarSerie(new Serie("Cosmos,1,13,13,91,Documentary,NeilTyson"));
            natgeo.agregarSerie(new Serie("OneStrangeRock,1,10,10,89,Documentary,DarrenAronofsky"));

            // === Series Discovery ===
            discovery.agregarSerie(new Serie("MythBusters,14,296,120,86,Documentary,PeterRees"));
            discovery.agregarSerie(new Serie("IntoTheWild,3,24,20,82,Documentary,DiscoveryTeam"));
            discovery.agregarSerie(new Serie("GoldRush,12,260,110,79,Documentary,RawTV"));

            // === Clientes Premium ===
            clientes.Add(new Cliente("P001,Roberto,Gómez,12345678"));
            clientes.Add(new Cliente("P002,Ana,Fernández,22345678"));
            clientes.Add(new Cliente("P003,Luis,Martínez,32345678"));
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
            return canales.FirstOr
