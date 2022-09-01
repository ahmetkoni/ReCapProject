// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//BrandTest();
CarTest();
//ColorTest();


 static void BrandTest()
{

    BrandManager brandManager = new BrandManager(new EfBrandDal());
    foreach (var brand in brandManager.GetAll())
    {
        Console.WriteLine(brand.BrandName);
    }
}
static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var car in carManager.GetCarDetails())
    { 
        Console.WriteLine(car.Id+"/"+car.ModelYear+"/"+car.BrandName+"/"+car.ColorName+"/"+car.DailyPrice);
    }
}

//static void CarTest()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    foreach (var car in carManager.GetAll())
//    {
//        Console.WriteLine(car.ModelYear);
//    }

//    Car carTest = new Car()
//    {
//        Description = "asdagfasag",
//        DailyPrice = 0,
//    };


//    carManager.Add(carTest);
//}


static void ColorTest()
{ 
    ColorManager colorManager = new ColorManager(new EfColorDal());
    foreach (var color in colorManager.GetAll())
    {
        Console.WriteLine(color.ColorName);
   }
}



