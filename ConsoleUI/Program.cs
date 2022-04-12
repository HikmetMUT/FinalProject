
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var item in productManager.GetAll())
{
    Console.WriteLine(item.ProductName);
}



Console.ReadLine();

