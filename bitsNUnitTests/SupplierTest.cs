using System.Collections.Generic;
using System.Linq;
using System;

using NUnit.Framework;
using bitsEFClasses.Models;
using Microsoft.EntityFrameworkCore;

namespace bitsNUnitTests
{
    [TestFixture]
    class SupplierTest
    {
        bitsContext dbContext;
        Supplier s;
        List<Supplier> suppliers;

        [SetUp]
        public void Setup()
        {
            dbContext = new bitsContext();
            dbContext.Database.ExecuteSqlRaw("call usp_testingResetData2()");
        }

        [Test]
        public void GetAllTest()
        {
            suppliers = dbContext.Supplier.OrderBy(s => s.Name).ToList();
            Assert.AreEqual(6, suppliers.Count);
            Assert.AreEqual("BSG Craft Brewing", suppliers[0].Name);
            PrintAll(suppliers);
        }

        [Test]
        public void GetByPrimaryKeyTest()
        {
            s = dbContext.Supplier.Find(1);
            Assert.IsNotNull(s);
            Assert.AreEqual(1, s.SupplierId);
            Console.WriteLine(s);
        }

        [Test]
        public void DeleteTest()
        {
            s = dbContext.Supplier.Find(7);
            dbContext.Supplier.Remove(s);
            dbContext.SaveChanges();
            Assert.IsNull(dbContext.Supplier.Find(7));
        }

        [Test]
        public void CreateTest()
        {
            s = new Supplier();
            s.Name = "CreateTest Name";
            s.Phone = "11111111";
            s.Email = "createTest@email.com";
            s.Website = "createtest.website";
            s.ContactFirstName = "CreateTest fName";
            s.ContactLastName = "CreateTest lName";
            s.ContactPhone = "22222222";
            s.ContactEmail = "createtest@contactemail.com";
            s.Note = "CreateTest Note";
        }

        [Test]
        public void UpdateTest()
        {
            s = dbContext.Supplier.Find(7);
            s.Name = "UpdateTest Name";
            dbContext.Supplier.Update(s);
            dbContext.SaveChanges();
            s = dbContext.Supplier.Find(7);
            Assert.AreEqual("UpdateTest Name", s.Name);
        }

        public void PrintAll(List<Supplier> suppliers)
        {
            foreach (Supplier s in suppliers)
            {
                Console.WriteLine(s);
            }
        }
    }
}
