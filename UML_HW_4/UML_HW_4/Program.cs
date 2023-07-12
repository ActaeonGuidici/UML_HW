// Without Director

//IHouseBuilder builder = new ModernStyleHouseBuilder();
//House house = builder.BuildWindows(4).BuildDoors(8).BuildWalls(4).BuildPools(2).BuildGarages(1).BuildPavilions(2).BuildGardens(1).Build();
//house.HasRoof = true;
//Console.WriteLine(house);



// With Director

Director director = new();
var builder = new ModernStyleHouseBuilder();

director.Builder = builder;
Console.WriteLine(director.BuildModernStyleHouse());


