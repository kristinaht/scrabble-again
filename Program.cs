using System.IO;
using Microsoft.AspNetCore.Hosting;

// both Startup.cs and Program.cs files contain code in the same FriendLetter namespace. This ensures the code blocks in Startup.cs and Program.cs have access to each other.
namespace MadLibs
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
// using System;
// using Scrabble.Models;

// namespace Scrabble
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Console.WriteLine("Welcome to Scrabble Scorrer!");

//       Console.WriteLine("Enter a word");

//       string word = Console.ReadLine();
//       string upperWord = word.ToUpper();

//       Game newGame = new Game(upperWord);
//       char[] arrayWord = newGame.MakeArray(upperWord);
//       Console.WriteLine(newGame.Count(arrayWord));
    


//     }
//   }
// }