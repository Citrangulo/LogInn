using System;
using Xunit;
using LogInn.Domain.Entities;
using LogInn.Application;

namespace LogInn.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var Roomx = new Room();

            Assert.True(Roomx != null);
        }
    }
}
