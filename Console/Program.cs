// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

BrandManager brandManager = new BrandManager(new EfBrandDal());
foreach (var brand in brandManager.GetAll())
{
    Console.WriteLine(brand.BrandId);
}
