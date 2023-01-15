namespace prueba
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("---Animal Race---");
      Console.WriteLine("There are 3 animals: a horse, dog and cat. Choose their names and then they will compete each other into a race for the victory!");

      Console.Write("\n\nWhat's the horse's name? ");
      Caballo horse1 = new Caballo(Console.ReadLine() ?? "Bojack Horseman");

      Console.Write("\n\nDog's name: ");
      Perro dog1 = new Perro(Console.ReadLine() ?? "Marmaduke");

      Console.Write("\n\nCat's name: ");
      Gato cat1 = new Gato(Console.ReadLine() ?? "Garfield");

      Console.WriteLine("\n\nHow much distance would they have to run to win? ");
      int.TryParse(Console.ReadLine(), out int totalDistance);

      Console.WriteLine("Press any key to start!");
      Console.ReadKey(true);

      int step = 1;
      Animals[] players = { horse1, cat1, dog1 };
      Animals winnerAnimal = players[0];
      Animals worstAnimal = players[0];

      while ((horse1.GetDistanceRun() < totalDistance) && (cat1.GetDistanceRun() < totalDistance) && (dog1.GetDistanceRun() < totalDistance))
      {
        Console.WriteLine("\nStep No." + step);

        for (int i = 0; i < players.Length; i++)
        {
          players[i].Moverse();
        }

        foreach (Animals i in players)
        {
          if (i.GetDistanceRun() < worstAnimal.GetDistanceRun()) worstAnimal = i;
          if (i.GetDistanceRun() > winnerAnimal.GetDistanceRun()) winnerAnimal = i;
        }

        Console.WriteLine($"{horse1.GetNombre()} has run {horse1.GetDistanceRun()} in total!");
        Console.WriteLine($"{dog1.GetNombre()} has run {dog1.GetDistanceRun()} in total!");
        Console.WriteLine($"{cat1.GetNombre()} has run {cat1.GetDistanceRun()} in total!");

        if ((horse1.GetDistanceRun() < totalDistance) && (cat1.GetDistanceRun() < totalDistance) && (dog1.GetDistanceRun() < totalDistance))
        {
          Console.WriteLine("Press any key to continue to step " + (step + 1));
          Console.ReadKey(true);
        }
        else
        {
          Console.WriteLine("Press any key to continue");
          Console.ReadKey(true);
        }

        step++;
      }

      Console.WriteLine("\n\n------Final Results-------");
      Console.WriteLine($"{winnerAnimal.GetNombre()} has WONN!!");
      Console.WriteLine($"{worstAnimal.GetNombre()} has been the slowlest animal...");
    }
  }

}