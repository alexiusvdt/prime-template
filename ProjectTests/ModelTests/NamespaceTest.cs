using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProgram;
using System.Collections.Generic;
using System;

namespace MyProgram.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ListConstructor_CreatesInstanceOfList_List()
    {
      CollectionAssert.AreEqual(new List<int> {2,3,4,5,6,7,8,9,10}, Program.ListMaker(10));
    }
    
    [TestMethod]
    public void ListManipulate_RemovesMultiplesOfTwo_List()
    {
      List<int> primeList = new List<int> {2,3,4,5,6,7,8,9,10};
      foreach (int item in primeList)
      {
      Console.WriteLine(item); 
      }
      CollectionAssert.AreEqual(new List<int> {2,3,5,7,9}, Program.Remove(2, primeList));
    }

    [TestMethod]
    public void ListManipulate_RemovesMultiplesOfThree_List()
    {
      List<int> primeList = new List<int> {2,3,4,5,6,7,8,9,10};
      CollectionAssert.AreEqual(new List<int> {2,3,5,7}, Program.Remove(3, Program.Remove(2, primeList)));
    }
    [TestMethod]
    public void ListManipulate_RemovesMultiplesOfFive_List()
    {
      List<int> primeList = new List<int> {2,3,5,7};
      // List<int> tempList = Program.Remove(3, Program.Remove(2, primeList));
      CollectionAssert.AreEqual(new List<int> {2,3,5,7}, Program.Remove(5, primeList));
    }  
    [TestMethod]
    public void ListManipulate_RemovesAllPrimes_List()
    {
      CollectionAssert.AreEqual(new List<int> {2,3,5,7}, Program.NonPrimeRemoval(10));
    }  
    [TestMethod]
    public void ListManipulate_RemovesAllPrimes100_List()
    {
      CollectionAssert.AreEqual(new List<int> {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89}, Program.NonPrimeRemoval(89));
    }  
  }
}