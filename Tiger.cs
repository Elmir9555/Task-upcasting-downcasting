using System;
namespace Downcastingupcasting
{
    public class Tiger:Animal
    {

        public override void JumpingDistance()
        {
            Console.WriteLine("Daha çox məsafəyə tullana bilir");
        }
        public override void RunOrWalkSpeed()
        {
            Console.WriteLine("Ən sürətli qaça bilən heyvan növüdür");
        }
        public void AnimalType()
        {
            Console.WriteLine($"Heyvanın növü:{Type}");
        }
    }
}
