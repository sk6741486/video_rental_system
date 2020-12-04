using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using video_rental_system;

namespace unittest_videorentalsystem
{
    [TestClass]
    public class unittest_vr//name of unit test 
    {
        DB_Class Obj_data = new DB_Class();
        [TestMethod]
          public void Test_deletecustomer()//test case for testing
           {
            string Message = Obj_data.CustomerDelete();
            Assert.AreEqual("Customer Data Deleted Successfully", Message);
        }
    }
}

