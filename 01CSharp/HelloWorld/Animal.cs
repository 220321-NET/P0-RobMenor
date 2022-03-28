namespace StackLite;

public class Dog : IWalkable
{
       public void Walk()
   {
       Console.WriteLine("Dog walks");
   }
}

public class Cat : IWalkable
{
       public void Walk()
   {
       Console.WriteLine("Cat walks");
   }
}