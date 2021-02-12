using Business.Concrete;
using DataAccess.Abstract;
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
            //CarTest();

            //ColorTest();

            //BrandTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Description + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            } 

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            // brandManager.Add(new Brand {BrandName="Mercedes" });

            //brandManager.Update(new Brand {BrandId=1002, BrandName = "Bmw" });

            brandManager.Delete(new Brand { BrandId = 1002, BrandName = "Bmw" });



            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine("BrandId=2 brand -> " + brandManager.GetById(2).Data.BrandName);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            // colorManager.Add(new Color {ColorName="Pink" });

            // colorManager.Update(new Color {ColorId=1002, ColorName = "Purple" });

            colorManager.Delete(new Color { ColorId = 1002, ColorName = "Purple" });



            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine("ColorId=3 color -> " + colorManager.GetById(3).Data.ColorName);
        }

        private static void CarTest()
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            CarManager carManager = new CarManager(new EfCarDal());



            //foreach (var car in carManager.GetCarsByBrandId(1).Data)
            //{
            //    Console.WriteLine(car.Description);
            //}

            //foreach (var car in carManager.GetCarsByColorId(2).Data)
            //{
            //    Console.WriteLine(car.Description);
            //}

            //carManager.Add(new Car {BrandId=1,ColorId=3,DailyPrice=1500,Description="H",ModelYear=2014 }); //eklenemez
            //carManager.Add(new Car { BrandId = 1, ColorId = 3, DailyPrice = 1500, Description = "Hyundai", ModelYear = 2014 });
            //carManager.Update(new Car { CarId=1002,BrandId = 1, ColorId = 3, DailyPrice = 1500, Description = "Hyundai Updated", ModelYear = 2014 });
            carManager.Delete(new Car { CarId = 1002, BrandId = 1, ColorId = 3, DailyPrice = 1500, Description = "Hyundai Updated", ModelYear = 2014 });
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
