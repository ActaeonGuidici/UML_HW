interface IHouseBuilder
{
    void Reset();

    IHouseBuilder BuildRoof();
    IHouseBuilder BuildDoors(int count);
    IHouseBuilder BuildWindows(int count);
    IHouseBuilder BuildWalls(int count);
    IHouseBuilder BuildGarages(int count);
    IHouseBuilder BuildGardens(int count);
    IHouseBuilder BuildPavilions(int count);
    IHouseBuilder BuildPools(int count);


    House Build();

}
