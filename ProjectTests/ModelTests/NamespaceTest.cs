using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProgram;
using System.Collections.Generic;

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
      Program.ListMaker(10)
      CollectionAssert.AreEqual(primeList = {3,5,7,9}, Program.Remove(2));
    }
  }
}