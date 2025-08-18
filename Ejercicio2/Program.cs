using Ejercicio2;
using System.Security.Cryptography.X509Certificates;

PNormal pNormal = new PNormal();
PPremium pPremium = new PPremium();
PSilver pSilver = new PSilver();
RepositorioGral repositorioGral = new RepositorioGral();



try
{
    mostrarMenu();
}
catch (Exception ex)
{

}


void mostrarMenu()
{
    int respuesta;
    do
    {
        Console.WriteLine("_______________________FLOW2________________________");
        Console.WriteLine("\n\n  1_ingresar nuevo cliente");
        Console.WriteLine(" 2_ Igresar nuevo canal");
        Console.WriteLine(" 3_ Ingresar nueva serie");
        Console.WriteLine(" 4_ Consultar contenido paquetes");
        Console.WriteLine(" 5_ Total recaudado");
        Console.WriteLine(" 6_ Paquete mas vendido");
        Console.WriteLine(" 7_ Series mayores a 3.5 en el ranking");
        Console.WriteLine(" 8_ salir");

        respuesta = Convert.ToInt32(Console.ReadLine());
    }
    while (respuesta < 1 || respuesta > 7);

    switch (respuesta)
    {
        case 1:
            string clNombre;
            string clCodigo;
            string clApellido;
            int clDni;

            int clPaquete;


            Console.WriteLine("ingrese el nombre del nuevo cliente");
            clNombre = Console.ReadLine();

            Console.WriteLine("ingrese el Codigo del nuevo cliente");
            clCodigo = Console.ReadLine();

            Console.WriteLine("ingrese el apellido del nuevo cliente");
            clApellido = Console.ReadLine();

            Console.WriteLine("ingrese el DNI del nuevo cliente");
            clDni = Convert.ToInt32(Console.ReadLine());

            Cliente cl = new Cliente("" + clCodigo + "," + clNombre + "," + clApellido + "," + clDni + "");



            Console.WriteLine("que plan desea contratar?\n1_ Normal     2_ Silver     3_ Premium");
            clPaquete = Convert.ToInt32(Console.ReadLine());

            if (clPaquete == 1)
            {
                pNormal.agregarCliente(cl);
            }
            else
            {
                if (clPaquete == 2)
                {
                    pSilver.agregarCliente(cl);
                }
                else
                {
                    if (clPaquete == 3)
                    {
                        pPremium.agregarCliente(cl);
                    }
                }
            }

            guardarCambios();
            Console.WriteLine("Cliente agregado con éxito!");

            break;
        case 2:

            string nombre;
            int paquete;

            Console.WriteLine("ingrese el nombre del nuevo canal");
            nombre = Console.ReadLine();


            Canal c = new Canal(nombre);

            Console.WriteLine("a que paquete pertenecera este canal?\n1_ Normal     2_ Silver     3_ Premium");
            paquete = Convert.ToInt32(Console.ReadLine());

            if (paquete == 1)
            {
                pNormal.agregarCanal(c);
            }
            else
            {
                if (paquete == 2)
                {
                    pSilver.agregarCanal(c);
                }
                else
                {
                    if (paquete == 3)
                    {
                        pPremium.agregarCanal(c);
                    }
                }
            }

            guardarCambios();
            Console.WriteLine("Canal agregado con éxito!");
            break;
        case 3:
            string sNombre;
            int sNroTemporadas;
            int sNroEpisodios;
            int sDuracionHoras;
            float sRanking;
            string sGenero;
            string sDirector;

            string canal;

            Console.WriteLine("Ingrese el nombre de la serie:");
            sNombre = Console.ReadLine();

            Console.WriteLine("Ingrese el número de temporadas:");
            sNroTemporadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de episodios:");
            sNroEpisodios = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la duración en horas:");
            sDuracionHoras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el ranking:");
            sRanking = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el género (Accion, Drama, Comedia, Documental):");
            sGenero = Console.ReadLine();

            Console.WriteLine("Ingrese el director:");
            sDirector = Console.ReadLine();

            Serie nuevaSerie = new Serie(
                $"{sNombre},{sNroTemporadas},{sNroEpisodios},{sDuracionHoras},{sRanking},{sGenero},{sDirector}"
            );

            Console.WriteLine("ingrese el nombre del canal al que quiere agregar esta serie");
            canal = Console.ReadLine();

            if (pNormal.buscarCanal(canal) != null)
            {
                pNormal.buscarCanal(canal).agregarSerie(nuevaSerie);
            }
            else
            {
                if (pSilver.buscarCanal(canal) != null)
                {
                    pSilver.buscarCanal(canal).agregarSerie(nuevaSerie);
                }
                else
                {
                    if (pPremium.buscarCanal(canal) != null)
                    {
                        pPremium.buscarCanal(canal).agregarSerie(nuevaSerie);
                    }
                    else
                    {
                        Console.WriteLine("Canal no Encontrado");
                    }
                }
            }


            guardarCambios();
            Console.WriteLine("Serie agregada con éxito!");
            break;
        case 4:

            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;

    }

    void guardarCambios()
    {
        if(repositorioGral != null)
        {
            repositorioGral.quitar(pNormal);
            repositorioGral.quitar(pSilver);
            repositorioGral.quitar(pPremium);
        }

        repositorioGral.agregar(pNormal);
        repositorioGral.agregar(pSilver);
        repositorioGral.agregar(pPremium);
    }
}