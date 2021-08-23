using System;


namespace CollectionInterfacesDemo
{
    class IEnumeratorDemo
    {
        static void Main()
        {
            
            Car car1 = new Car {Year=2020,ModelName="TATA" };
            Car car2 = new Car { Year = 2021, ModelName = "MARUTI" };
            Car car3 = new Car { Year = 2022, ModelName = "KIA" };
            using (Cars cars = new Cars())
            {
                cars[0] = car1;
                cars[1] = car2;
                cars[2] = car3;


                int index = 0;

                while (cars.MoveNext())
                {
                    var car = cars[index];
                    Console.WriteLine("Year={0} Model Name={1}", car.Year, car.ModelName);
                    index++;
                }
            }
            Console.ReadLine();
        }
    }
}
