using CityDispatcher.Objects;
using CityDispatcher.Objects.Enums;

namespace CityDispatcher;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("City:");
        City szeged = new City("Szeged", 160000);

        szeged.AddTransport(TransportType.Train);
        szeged.AddTransport(TransportType.Trolley);

        Console.WriteLine(szeged.Id);
        Console.WriteLine(szeged.Name);

        foreach (TransportType transportType in szeged.SupportedTransportTypes)
        {
            Console.WriteLine(transportType);
        }

        Console.WriteLine(szeged.HasTransport(TransportType.Train));
        Console.WriteLine(szeged.HasTransport(TransportType.Trolley));

        Console.WriteLine("\nPosition:");
        Position capitalPosition = new Position(0, 0);
        Position cityPosition = new Position(10, -20);

        Console.WriteLine(capitalPosition);
        Console.WriteLine(cityPosition);

        Console.WriteLine(capitalPosition == new Position(0, 0));
    }
}
