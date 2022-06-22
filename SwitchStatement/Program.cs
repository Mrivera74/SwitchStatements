Console.WriteLine("What is your favorite school subject?");
var response = Console.ReadLine();

switch (response)
{
    case "Science":
        Console.WriteLine("Cool! It's my favorite too");
        break;

    case "science":
        Console.WriteLine("Cool! It's my favorite too");
        break;

    case "Math":
        Console.WriteLine("Nice, this is my second favorite");
        break;

    case "math":
        Console.WriteLine("Nice, this is my second favorite");
        break;

    case "Art":
        Console.WriteLine("I like Art, but not as much as Science & Math");
        break;

    case "art":
        Console.WriteLine("I like Art, but not as much as Science & Math");
        break;

    case "English":
        Console.WriteLine("That's Awesome!");
        break;

    case "english":
        Console.WriteLine("That's Awesome!");
        break;

    case "History":
        Console.WriteLine("Thats cool!");
        break;

    case "history":
        Console.WriteLine("Thats cool!");
        break;

    default:
        Console.WriteLine("Really I did not have to take that one");
        break; a

}
