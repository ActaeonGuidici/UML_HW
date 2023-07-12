class Director
{
    private IHouseBuilder houseBuilder;

    public IHouseBuilder Builder { set { houseBuilder = value; } }
    House new_house = new House();

    public House BuildModernStyleHouse()
    {
        houseBuilder.BuildWalls(4);
        houseBuilder.BuildDoors(6);
        houseBuilder.BuildWindows(8);
        houseBuilder.BuildGarages(1);
        houseBuilder.BuildGardens(1);
        houseBuilder.BuildPavilions(1);
        houseBuilder.BuildPools(2);

        new_house = houseBuilder.Build();
        return new_house;
    }


    public House BuildClassicStyleHouse()
    {
        houseBuilder.BuildWalls(4);
        houseBuilder.BuildDoors(4);
        houseBuilder.BuildWindows(3);
        houseBuilder.BuildPools(1);

        new_house = houseBuilder.Build();
        return new_house;
    }
}