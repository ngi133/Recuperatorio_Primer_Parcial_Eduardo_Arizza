using Recuperatorio_Primer_Parcial_Antes;

class Program
{ 
static void Main(string[] args)
{

    List<IEquipo> equipos = new List<IEquipo>();

    Arquero arquero1 = new Arquero();
    arquero1.nombre = "Jose";
    arquero1.apellido = "Lopez";
    arquero1.club = "Sacachispas";
    arquero1.numero = 1;
    equipos.Add(arquero1);


    Delantero delantero1 = new Delantero();
    delantero1.nombre = "Pedro";
    delantero1.apellido = "Garcia";
    delantero1.club = "Moron";
    delantero1.numero = 9;
    equipos.Add(delantero1);

    //Aca no se cumple con LSP porque se está consultando por el tipo de las instancias Arquero y Delantero,
    //ni con OCP porque si se desea agregar un nuevo tipo de Jugador que implemente una Interfaz conocida,
    //se debe alterar el código cliente

    foreach (IEquipo equipo in equipos)
    {
        if (equipo is Arquero)
        {
            equipo.Atajar();

            Console.WriteLine("El arquero esta atajando");
        }

        else
        {
            equipo.Patear();
            Console.WriteLine("El arquero esta pateando");
        }
    }
    foreach (IEquipo equipo in equipos)
    {
        if (equipo is Delantero)
        {
            equipo.Atajar();

            Console.WriteLine("El delantero esta atajando");
        }

        else
        {
            equipo.Patear();
            Console.WriteLine("El delantero esta pateando");
        }
    }

}
}
