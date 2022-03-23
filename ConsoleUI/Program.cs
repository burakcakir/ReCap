using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());            

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", item.Id.ToString(), item.BrandId.ToString(), item.ColorId.ToString(), item.ModelYear.ToString(), item.DailyPrice.ToString(), item.Explanation.ToString());
            }
        }
    }
}
