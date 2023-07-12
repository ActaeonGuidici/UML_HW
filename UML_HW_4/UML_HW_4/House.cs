
class House
{
    public string? Name { get; set; }
    public int Walls { get; set; }
    public int Windows { get; set; }
    public int Doors { get; set; }
    public int Garages { get; set; }
    public int Gardens { get; set; }
    public bool HasRoof { get; set; }
    public int Pavilions { get; set; }
    public int Pools { get; set; }


    public override string ToString()
    {
        return @$"  
                    Name: {Name} 
                    Walls: {Walls}
                    Doors: {Doors}
                    Window: {Windows}
                    Garages: {Garages}
                    Gardens: {Gardens}
                    Pavilions: {Pavilions}
                    Pools: {Pools}
                    HasRoof: {HasRoof}
                    ";

    }
}