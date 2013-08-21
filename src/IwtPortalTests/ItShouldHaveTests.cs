using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace IwtPortalTests
{
    [TestFixture]
    public class ItShouldHaveTests
    {
        [Test]
        public void AndThePeopleWeptWithJoy()
        {
            "tests for fun and profit".Length.ShouldBe(24);
        }
    }
}
