using UML_HW_1;
using UML_HW_1.Abstract;

Logistic logistic = new FoodLogic();
IProduct product = logistic.CreateProduct();
product.Create();