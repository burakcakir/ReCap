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
            UserTest();
            RentalTest();
            CustomerManager();
            ColorTest();
            BrandTest();
            CarTest();
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName + " " + item.EMail + " " + item.Password);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " " + item.CarId + " " + item.CustomerId + " " + item.RentDate.ToString() + " " + item.ReturnDate.ToString());
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerManager()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetAll();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.UserId + " " + item.CustomerId + " " + item.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Name + " " + item.Id);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Name + " " + item.Id);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarName + " - " + item.BrandName + " - " + item.ColorName + " - " + item.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
