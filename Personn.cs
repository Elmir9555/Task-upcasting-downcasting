using System;
namespace Encapsulationn
{
    public class Personn
    {
       
            public string name;
            public string Surname;
            private string password;

            public string Password
            {
                get
                {
                    return password;
                }

                set
                {
                if (value.Length > 8)
                   {
                    Console.WriteLine("Əməliyyat uğurla yerinə yetirilmişdir");
                    password = value;

                    Console.WriteLine($"Name:{name}   Surname:{Surname}   password:{Password}");

                   



                   }

                    else
                    {
                        Console.WriteLine("Şifrə ən azı 8 simvoldan ibarət olmalıdır");



                    }

                }
            }
            public Personn()
            {

                this.Surname = "Xelilov";
                this.name = "Anar";
            }

       
    }
}
