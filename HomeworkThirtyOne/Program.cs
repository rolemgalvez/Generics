using HomeworkThirtyOne.Library;
using System;

namespace HomeworkThirtyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericModel<PersonModel> person = new GenericModel<PersonModel>();
            Console.WriteLine(person.GetMessage(new PersonModel { HasError = false, Name = "Juan Dela Cruz" }));

            GenericModel<CarModel> car = new GenericModel<CarModel>();
            Console.WriteLine(car.GetMessage(new CarModel { HasError = true, Branch = "Pasay" }));

            Console.ReadLine();
        }
    }
}
