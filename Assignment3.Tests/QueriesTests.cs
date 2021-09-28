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
                ""
            };
            Assert.Equal(expected, instanceToTest.RowlingWizardsExt(Wizard.Wizards.Value));
        }

        [Fact]
        public void RowlingWizardsLINQ() {
            var instanceToTest = new Queries();
            var expected = new string[] {
                ""
            };
            Assert.Equal(expected, instanceToTest.RowlingWizardsLINQ(Wizard.Wizards.Value));
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
                ("", null)
            };
            Assert.Equal(expected, instanceToTest.UniqueHarryPotterWizardsExt(Wizard.Wizards.Value));
        }

        [Fact]
        public void UniqueHarryPotterWizardsLINQ() {
            var instanceToTest = new Queries();
            var expected = new (string, int?)[] {
                ("", null)
            };
            Assert.Equal(expected, instanceToTest.UniqueHarryPotterWizardsLINQ(Wizard.Wizards.Value));
        }

        [Fact]
        public void WizardsByCreatorExt() {
            var instanceToTest = new Queries();
            var expected = new string[][] {};
            Assert.Equal(expected, instanceToTest.WizardsByCreatorExt(Wizard.Wizards.Value));
        }

        [Fact]
        public void WizardsByCreatorLINQ() {
            var instanceToTest = new Queries();
            var expected = new string[][] {};
            Assert.Equal(expected, instanceToTest.WizardsByCreatorLINQ(Wizard.Wizards.Value));
        }
    }
}
