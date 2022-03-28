using StackLite;

// StackLiteMenu slMenu = new StackLiteMenu();
// slMenu.MainMenu();

IWalkable animal;

Console.WriteLine("Which animal would you like? [C/D]");
string input = Console.ReadLine();

if(input == "c")
{
    animal = new Cat();
}
else
{
    animal = new Dog();
}

animal.Walk();