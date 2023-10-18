// Padrão .NET 

// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp; 
{
  internal class Program
    {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Italo");
      if (args.GetLength(0)>0){
        Console.WriteLine(args.GetValue(0));
      }
    }
  }
}
