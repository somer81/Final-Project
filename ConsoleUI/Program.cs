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

            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();


            if(result.Success == true)
            {
                foreach (var p in result.Data)
                {
                    Console.WriteLine(p.ProductName + " / " + p.CategoryName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }

           

            // CategoryTest();

            //  ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAllByCategoryId(1);

            if(result.Success == true)
            {
            foreach (var p in result.Data)
            {
                Console.WriteLine(p.ProductName + " " + p.CategoryId);
            }
            }
          else
            {
                Console.WriteLine(result.Message);
            }


            //foreach (var p in productManager.GetAllByUnitPrice(100, 1000))
            //{
            //    Console.WriteLine(p.ProductName + " " + p.UnitPrice);
            //}


            //foreach (var p in productManager.GetAll())
            //{
            //    Console.WriteLine(p.ProductName);
            //}
        }
    }
}
