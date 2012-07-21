using System;
using System.Collections.Generic;
using Domain.Repositories;
using Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Moq;
using System.Linq;

namespace Test
{
    [TestClass]
    public class StuffServiceTest
    {
        private List<Stuff> stuffs;

        [TestInitialize]
        public void PreTestInitialize()
        {
            stuffs = new List<Stuff>()
            {
                new Stuff{Name="Pieux Xi", Team="BA", PhotoUrl="~/Assets/images/1.jpg", Content="Hi, I am Pieux Xi"},
                new Stuff{Name="Pieux Xi", Team="BA", PhotoUrl="~/Assets/images/2.jpg", Content="Hi, I am Pieux Xi"},
                new Stuff{Name="Pieux Xi", Team="BA", PhotoUrl="~/Assets/images/3.jpg", Content="Hi, I am Pieux Xi"},
                new Stuff{Name="Pieux Xi", Team="BA", PhotoUrl="~/Assets/images/4.jpg", Content="Hi, I am Pieux Xi"},
                new Stuff{Name="Pieux Xi", Team="BA", PhotoUrl="~/Assets/images/5.jpg", Content="Hi, I am Pieux Xi"},
                new Stuff{Name="Pieux Xi", Team="BA", PhotoUrl="~/Assets/images/6.jpg", Content="Hi, I am Pieux Xi"},
                new Stuff{Name="Pieux Xi", Team="BA", PhotoUrl="~/Assets/images/7.jpg", Content="Hi, I am Pieux Xi"},
            };

           
        }

        [TestMethod]
        public void Can_Get_Stuff_Count()
        {
            // Arrange
            Mock<IStuffRepository> mock = new Mock<IStuffRepository>();
            mock.Setup(_ => _.Get()).Returns(stuffs);

            StuffService target = new StuffService(mock.Object);

            // Act

            // Assert
            Assert.AreEqual(stuffs.Count, target.StuffCount);

        }

        [TestMethod]
        public void Get_Index_Stuff()
        {
            // Arrange
            Mock<IStuffRepository> mock = new Mock<IStuffRepository>();
            mock.Setup(_ => _.Get()).Returns(stuffs);

            StuffService target = new StuffService(mock.Object);
            int stuffCount = target.StuffCount;
            // Act

            // Assert
            Assert.AreEqual(4, target.GetIndexStuff(1).Count<Stuff>());
            Assert.AreEqual(3, target.GetIndexStuff(1+4).Count<Stuff>());
        }
        
    }
}
