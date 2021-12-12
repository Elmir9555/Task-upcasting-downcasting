using System;
namespace Downcastingupcasting
{
    public class Animal
    {
        public string Type { get; set; }
        public int Age { get; set; }
        public int FootCount { get; set; }


        public virtual void JumpingDistance()
        {
            Console.WriteLine("Daha çox gücü olan daha çox məsafəyə tullana bilir");
        }
        public virtual void RunOrWalkSpeed()
        {
            Console.WriteLine("Daha çox cəld olan digərlərinə nisbətən dahada surətli qaça bilir");
        }
    }
}
