using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_12_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(12, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader","Star Wars",1977,"George Lucas")]
        [InlineData("Darth Maul","Star Wars",1999,"George Lucas")]
        [InlineData("Darth Sidious","Star Wars",1980,"George Lucas")]
        [InlineData("Luke Skywalker","Star Wars",1977,"George Lucas")]
        [InlineData("Sauron","The Fellowship of the Ring",1954,"J.R.R. Tolkien")]
        [InlineData("Gandalf","The Fellowship of the Ring",1954,"J.R.R. Tolkien")]
        [InlineData("Saruman","The Fellowship of the Ring",1954,"J.R.R. Tolkien")]
        [InlineData("The Wizard Of Oz","The Wizard Of Oz",1939,"Victor Fleming")]
        [InlineData("Harry Potter","Harry Potter and the Philosopher's Stone",1997,"J.K. Rowling")]
        [InlineData("Albus Dumbledore","Harry Potter and the Philosopher's Stone",1997,"J.K. Rowling")]
        [InlineData("Sirius Black","Harry Potter and the Prisoner of Azkaban",1999,"J.K. Rowling")]
        [InlineData("Harry Potter","Harry Potter and the Prisoner of Azkaban",1999,"J.K. Rowling")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}

