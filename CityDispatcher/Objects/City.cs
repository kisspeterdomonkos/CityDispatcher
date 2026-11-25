using System;
using System.Collections.Generic;
using CityDispatcher.Objects.Enums;
using System.Collections.ObjectModel;

namespace CityDispatcher.Objects;

public sealed class City
{
    public Guid Id { get; }
    public string Name { get; private set; }
    public int Population { get; private set; }
    private readonly HashSet<TransportType> _avalibleTransportTypes = new HashSet<TransportType>()
    {
        TransportType.Bus
    };
    
    public City(string name, int population)
    {
        Id = Guid.NewGuid();
        Name = name;
        Population = population;
    }

    public IReadOnlySet<TransportType> SupportedTransportTypes
    {
        get
        {
            return new ReadOnlySet<TransportType>(_avalibleTransportTypes);
        }
    }
    
    public void AddTransport(TransportType transportType)
    {
        _avalibleTransportTypes.Add(transportType);
    }

    public bool HasTransport(TransportType transportType)
    {
        return _avalibleTransportTypes.Contains(transportType);
    }
}
