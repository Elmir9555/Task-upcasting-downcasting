using System;

namespace Downcastingupcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();            

            Tiger tiger = new Tiger();
            tiger.Age = 9;
            tiger.FootCount = 4;
            tiger.Type = "Vəhşi";
            tiger.AnimalType();

            Turtle turtle = new Turtle();
            turtle.Age = 10;
            turtle.AgeRange();

            // Upcasting
            Animal tiger1 = new Tiger();

            Animal turtle1 = new Turtle();

            tiger1.JumpingDistance();

            turtle1.RunOrWalkSpeed();
            
            
        }
    }
}
