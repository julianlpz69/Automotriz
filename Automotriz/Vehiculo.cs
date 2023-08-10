
namespace Automotriz
{
    public class Vehiculo
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public long kilometraje { get; set; }
   
        public Vehiculo(){}

        public Vehiculo(string Placa, string Modelo, string Marca, string Color, long Kilometraje){

            placa = Placa;
            modelo = Modelo;
            marca = Marca;
            color = Color;
            kilometraje = Kilometraje;
        }


        public void registrarVehiculo( Dictionary<string,Vehiculo> Vehiculos, Vehiculo vehiculo){

            Console.Clear();
            Console.Write("\nIngresa la Placa del vehiculo\t");
            placa = Console.ReadLine();
            Console.Write("\nIngresa el Modelo del Vehiculo\t");
            modelo = Console.ReadLine();
            Console.Write("\nIngresa la Marca del Vehiculo\t");
            marca = Console.ReadLine();
            Console.Write("\nIngresa el color del Vehiculo\t");
            color = Console.ReadLine();
            Console.Write("\nIngresa el kilometraje del Vehiculo\t");
            kilometraje = long.Parse(Console.ReadLine());
            

            Vehiculos.Add(placa,vehiculo);
        }

        public void mostrarVehiculo(Dictionary<string,Vehiculo> Vehiculos){

            Console.Clear();
            Console.WriteLine($"------------------------VEHICULOS-----------------------------");
            Console.WriteLine($"\nPlaca\tModelo\tMArca\tColor\tKilometraje");
            foreach (var elemens in Vehiculos.Values){
                Console.WriteLine($"\n{elemens.placa}\t{elemens.modelo}\t{elemens.marca}\t{elemens.color}\t{elemens.kilometraje}");
            }
            Console.ReadKey();
        }
    }
}