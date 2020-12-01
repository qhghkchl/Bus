using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;

namespace BusProject.Data.Tests
{
    [TestClass()]
    public class CustomerDaoTests
    {
        [TestMethod()]
        public void GetByNameTest()
        {
            DbContextCreator.Context = () => new BusProjectEntities();

           /* Customer customer = Dao.Customer.GetByName("Thomas");
            Assert.IsNotNull(customer);*/
        }
    }
}