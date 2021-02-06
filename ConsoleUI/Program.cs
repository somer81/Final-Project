using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

          //  ProductTest();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());



            foreach (var p in productManager.GetAllByCategoryId(1))
            {
                Console.WriteLine(p.ProductName + " " + p.CategoryId);
            }


            foreach (var p in productManager.GetAllByUnitPrice(100, 1000))
            {
                Console.WriteLine(p.ProductName + " " + p.UnitPrice);
            }


            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName);
            }
        }
    }
}
