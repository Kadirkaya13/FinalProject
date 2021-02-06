using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CategoryText();
            //InMemoryTest();
            ProductText();
            //PersonelTest();
        }

        private static void CategoryText()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void PersonelTest()
        {
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}", personel.Id, personel.Name, personel.Surname);
            }
        }

        private static void InMemoryTest()
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ProductText()
        {
            ProductManager efProductManager = new ProductManager(new EfProductDal());
            foreach (var product in efProductManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }
        }
    }
}
