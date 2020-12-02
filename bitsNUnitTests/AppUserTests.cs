using System.Collections.Generic;
using System.Linq;
using System;

using NUnit.Framework;
using bitsEFClasses.Models;
using Microsoft.EntityFrameworkCore;

namespace bitsNUnitTests
{
    [TestFixture]
    public class AppUserTests
    {
        bitsContext dbContext;
        AppUser a;
        List<AppUser> appUsers;

        [SetUp]
        public void Setup()
        {
            dbContext = new bitsContext();
            dbContext.Database.ExecuteSqlRaw("call usp_testingResetData()");
        }

        [Test]
        public void GetAllTest()
        {
            appUsers = dbContext.AppUser.OrderBy(a => a.AppUserId).ToList();
            Assert.AreEqual(5, appUsers.Count);
            Assert.AreEqual("TEST1", appUsers[0].Name);
            PrintAll(appUsers);
        }

        [Test]
        public void GetByPrimaryKeyTest()
        {
            a = dbContext.AppUser.Find(1);
            Assert.IsNotNull(a);
            Assert.AreEqual(1, a.AppUserId);
            Console.WriteLine(a);
        }

        [Test]
        public void DeleteTest()
        {
            a = dbContext.AppUser.Find(1);
            dbContext.AppUser.Remove(a);
            dbContext.SaveChanges();
            Assert.IsNull(dbContext.AppUser.Find(1));
        }

        [Test]
        public void CreateTest()
        {
            a = new AppUser();
            a.Name = "Cool Guy";
        }

        [Test]
        public void UpdateTest()
        {
            a = dbContext.AppUser.Find(5);
            a.Name = "Guy Cool";
            dbContext.AppUser.Update(a);
            dbContext.SaveChanges();
            a = dbContext.AppUser.Find(5);
            Assert.AreEqual("Guy Cool", a.Name);
        }


        public void PrintAll(List<AppUser> appUsers)
        {
            foreach(AppUser a in appUsers)
            {
                Console.WriteLine(a);
            }
        }
    }
}