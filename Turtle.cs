using System;
namespace Downcastingupcasting
{
    
    public class Turtle:Animal
    {
        public int Weight { get; set; }

        public override void RunOrWalkSpeed()
        {
            Console.WriteLine("Daha yavaş yeriyə və qaça bilir");
        }
        public override void JumpingDistance()
        {
            Console.WriteLine("Balaca olduğundan daha az məsafəyə tullana bilir");
        }
        public void AgeRange()
        {
            Console.WriteLine($"Yaşama müddəti:{50-Age}");
        }
    }
}
