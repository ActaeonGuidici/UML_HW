using UML_HW_2.Abstract;
using UML_HW_2.Concreate;

IDrinkFactory factory = new ZeroFactory();
ICola cola = factory.CreateCola();
IPepsi pepsi = factory.CreatePepsi();
IRedBull redbull = factory.CreateRedBull();
ISandora sandora = factory.CreateSandora();