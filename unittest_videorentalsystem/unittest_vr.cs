using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using video_rental_system
namespace unittest_videorentalsystem
{
    [TestClass]
    public class unittest_vr
    {
        DB_Class Obj_data = new DB_Class();
        [TestMethod]
        public void Test_connection()
        {
            [TestClass]
            public class UnitTest1
        {
            [TestMethod]
            public void TestConnection()
            {
                string connection = obj_Data.connstring;
                Assert.AreEqual(@"LAPTOP-39KQ6SLL\SQLEXPRESS; Initial Catalog=RentingStore; Integrated Security=True", connection);
            }

            }
    }
}
