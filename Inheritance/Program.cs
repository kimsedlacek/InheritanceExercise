using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile 
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var firstBird = new Bird();

            firstBird.Color = "yellow and blue";
            firstBird.Eats = "worms";
            firstBird.CanFly = true;
            firstBird.Weighs = 8;

            Console.WriteLine($"Our first animal is a bird.  This little {firstBird.Color} bird weighs only" +
                $" {firstBird.Weighs} ounces and loves to hunt for and eat {firstBird.Eats}.  Surprisingly, not all birds " +
                $"can fly, but by looking at this little guy, I'm sure you can see that it's " +
                $"{firstBird.CanFly.ToString().ToLower()} that he can fly.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var reptile = new Reptile();

            reptile.Color = "Green";
            reptile.Eats = "fresh vegetables and fruits";
            reptile.LikesHumans = true;
            reptile.HasTeeth = true;

            Console.WriteLine("Can anyone tell me what they think this next animal is?");
            Console.ReadLine();
            Console.WriteLine($"Good guess, but this is actually a {reptile.Color} Iguana. We can tell that this a young " +
                $"iguana because of the {reptile.Color.ToString().ToLower()} color; as he ages he will turn more brown or " +
                $"grey. Who has a question?");
            Console.ReadLine();
            Console.WriteLine($"I'll answer this one,\"Do {reptile.Color} Iguanas like people?\" The answer is \"Yes\" but, " +
                $"it depends.  {reptile.Color} Iguanas like people when they give them a great place to live and feed them " +
                $"well, and when they gently handle them from a young age.  They make great pets and they are quite docile " +
                $"most of the time, but it is {reptile.HasTeeth.ToString().ToLower()} that they have a lot of very sharp " +
                $"teeth, so be careful and treat them well!");
        }
    }
}
