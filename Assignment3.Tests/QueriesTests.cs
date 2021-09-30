using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void RowlingWizardsExt() {
            var instanceToTest = new Queries();
            var expected = new string[] {
                "Harry Potter",
                "Albus Dumbledore",
                "Sirius Black",
                "Harry Potter",
            };
            var actual = instanceToTest.RowlingWizardsExt(Wizard.Wizards.Value);
            Assert.Equal(expected.OrderBy(item => item), actual.OrderBy(item => item));
        }

        [Fact]
        public void RowlingWizardsLINQ() {
            var instanceToTest = new Queries();
            var expected = new string[] {
                "Harry Potter",
                "Albus Dumbledore",
                "Sirius Black",
                "Harry Potter",
            };
            var actual = instanceToTest.RowlingWizardsLINQ(Wizard.Wizards.Value);
            Assert.Equal(expected.OrderBy(item => item), actual.OrderBy(item => item));
        }

        [Fact]
        public void FirstSithLordYearExt() {
            var instanceToTest = new Queries();
            var expected = 1977;
            Assert.Equal(expected, instanceToTest.FirstSithLordYearExt(Wizard.Wizards.Value));
        }

        [Fact]
        public void FirstSithLordYearLINQ() {
            var instanceToTest = new Queries();
            var expected = 1977;
            Assert.Equal(expected, instanceToTest.FirstSithLordYearLINQ(Wizard.Wizards.Value));
        }

        [Fact]
        public void UniqueHarryPotterWizardsExt() {
            var instanceToTest = new Queries();
            var expected = new (string, int?)[] {
                ("Harry Potter", 1997),
                ("Albus Dumbledore", 1997),
                ("Sirius Black", 1999),
                ("Harry Potter", 1999),
            };
            var actual = instanceToTest.UniqueHarryPotterWizardsExt(Wizard.Wizards.Value);
            Assert.Equal(expected.OrderBy(item => item.Item1).ThenBy(item => item.Item2), actual.OrderBy(item => item.Item1).ThenBy(item => item.Item2));
        }

        [Fact]
        public void UniqueHarryPotterWizardsLINQ() {
            var instanceToTest = new Queries();
            var expected = new (string, int?)[]{
                ("Harry Potter", 1997),
                ("Albus Dumbledore", 1997),
                ("Sirius Black", 1999),
                ("Harry Potter", 1999),
            };
            var actual = instanceToTest.UniqueHarryPotterWizardsLINQ(Wizard.Wizards.Value);
            Assert.Equal(expected.OrderBy(item => item.Item1), actual.OrderBy(item => item.Item1));
        }

        [Fact]
        public void WizardsByCreatorExt() {
            var instanceToTest = new Queries();
            var expected = new string[][] {
                new string[] {"The Wizard Of Oz"}, 
                new string[] {"Sauron", "Saruman", "Gandalf"},
                new string[] {"Sirius Black", "Harry Potter", "Harry Potter", "Albus Dumbledore"},
                new string[] {"Luke Skywalker", "Darth Vader", "Darth Sidious", "Darth Maul"}
            };
            Assert.Equal(expected, instanceToTest.WizardsByCreatorExt(Wizard.Wizards.Value));
        }

        [Fact]
        public void WizardsByCreatorLINQ() {
            var instanceToTest = new Queries();
            var expected = new string[][] {
                new string[] {"The Wizard Of Oz"}, 
                new string[] {"Sauron", "Saruman", "Gandalf"},
                new string[] {"Sirius Black", "Harry Potter", "Harry Potter", "Albus Dumbledore"},
                new string[] {"Luke Skywalker", "Darth Vader", "Darth Sidious", "Darth Maul"}
            };
            Assert.Equal(expected, instanceToTest.WizardsByCreatorLINQ(Wizard.Wizards.Value));
        }
    }
}
