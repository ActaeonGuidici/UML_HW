
class ModernStyleHouseBuilder : IHouseBuilder
{
    private House House { get; set; } = new House();
    public ModernStyleHouseBuilder()
    {
        this.Reset();
        House.Name = "Modern Style House";
    }
    public void Reset()
    {
        House = new House();
    }
    public IHouseBuilder BuildDoors(int count)
    {
        House.Doors += count;
        return this;
    }

    public IHouseBuilder BuildGarages(int count)
    {
        House.Garages += count;
        return this;
    }

    public IHouseBuilder BuildGardens(int count)
    {
        House.Gardens += count;
        return this;
    }

    public IHouseBuilder BuildPavilions(int count)
    {
        House.Pavilions += count;
        return this;
    }

    public IHouseBuilder BuildPools(int count)
    {
        House.Pools += count;
        return this;
    }

    public IHouseBuilder BuildRoof()
    {
        House.HasRoof = true;
        return this;
    }

    public IHouseBuilder BuildWalls(int count)
    {
        House.Walls += count;
        return this;
    }

    public IHouseBuilder BuildWindows(int count)
    {
        House.Windows += count;
        return this;
    }
    public House Build()
    {
        House result = this.House;
        this.Reset();
        return result;
    }
}
