using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public enum Genero
    {
        Accion,
        Drama,
        Comedia,
        Documental
    }

    public class Serie
    {
        public Serie(string linea)
        {
            string[] valores = linea.Split(',');

            nroTemporadas = Convert.ToInt32(valores[0]);
            nroEpisodios = Convert.ToInt32(valores[1]);
            duracionHoras = Convert.ToInt32(valores[2]);
            ranking = float.Parse(valores[3]);
            genero = (Genero)Enum.Parse(typeof(Genero), valores[4], true);
            director = valores[5];
        }

        private string nombre;
        private int nroTemporadas;
        private int nroEpisodios;
        private int duracionHoras;
        private float ranking;
        private Genero genero;
        private string director;

        public int NroTemporadas { get { return nroTemporadas; } set { nroTemporadas = value; } }
        public int NroEpisodios { get { return nroEpisodios; } set { nroEpisodios = value; } }
        public int DuracionHoras { get { return duracionHoras; } set { duracionHoras = value; } }
        public float Ranking { get { return ranking; } set { ranking = value; } }
        public Genero Genero { get { return genero; } set { genero = value; } }
        public string Director { get { return director; } set { director = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
    }
}
