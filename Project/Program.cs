using System;
using System.Collections.Generic;
// using otherthings;

namespace MyProgram {
  public class Program {
    static void Main(){
      // get user input
      Console.WriteLine("What number would you like to use?");
      int n = int.Parse(Console.ReadLine());
      NonPrimeRemoval(n);
    }

    public static List<int> NonPrimeRemoval(int n)
    {
    List<int> primeList = ListMaker(n);
      for (int j = 2; j < 8; j++)
        {
        Remove(j, primeList);
        }
      Console.Write("Here are your pimples bro: " + primeList);
      return primeList;
    }


    public static List<int> Remove(int n, List<int> primeList)
    {
      for (int i = 0; i < primeList.Count; i++)
      {
        // Console.WriteLine(primeList.Count);
        // Console.WriteLine(i);
        if (primeList[i] % n == 0 && primeList[i] != n)
        {
          primeList.Remove(primeList[i]);
        }
        else 
        {
          continue;
        }
      }
      foreach (int item in primeList)
      {
      Console.WriteLine(item); 
      }
      Console.WriteLine("===============");
      return primeList;
    }

    public static List<int> ListMaker(int n)
    {
      List<int> primeList = new List<int>{};
      for (int i = 2; i <= n; i++)
      {
        primeList.Add(i);
      }
      return primeList;
    }
  }
}
// Given a number, write a method that returns all of the prime numbers less than that number.

// prime == any # greater than 1 and only divisible by itself (i.e. num/num)


//set index = 2, then remove all multiples
// repeat until we hit n
//return list < n
