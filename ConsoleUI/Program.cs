
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


//ProductManager productManager = new ProductManager(new EfProductDal());

//foreach (var item in productManager.GetByUnitPrice(40,50))
//{
//    Console.WriteLine(item.ProductName);
//}

ProductManager productManager = new ProductManager(new EfProductDal());

var result = productManager.GetProductDetails();
if (result.Success)
{
    foreach (var item in productManager.GetProductDetails().Data)
    {
        Console.WriteLine(item.ProductName + " --------" + item.CategoryName);
    }
}
else
{
    Console.WriteLine(result.Message);
}




Console.ReadLine();

