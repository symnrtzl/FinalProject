﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI 
{
    //SOLID
    //Open Closed Principle -> Yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiç bir koda dokunamazsın.
    class Program
    {
        static void Main(string[] args) 
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            /*
             foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
             */

            /*
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            */

            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
