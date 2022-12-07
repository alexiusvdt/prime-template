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
  }
}