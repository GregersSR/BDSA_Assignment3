using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment03
{
    public class Queries
    {
        public IEnumerable<string> RowlingWizardsExt(IEnumerable<Wizard> wizards) {
            return wizards.Where(wizard => wizard.Creator == "J.K. Rowling")
                          .Select(wizard => wizard.Name);
        }

        public IEnumerable<string> RowlingWizardsLINQ(IEnumerable<Wizard> wizards) {
            var query = from w in wizards
                        where w.Creator == "J.K. Rowling"
                        select w.Name;
            return query;
        }

        public int? FirstSithLordYearExt(IEnumerable<Wizard> wizards) {
            return wizards.Where(wizard => wizard.Name.StartsWith("Darth "))
                          .OrderBy(wizard => wizard.Year)
                          .Select(wizard => wizard.Year)
                          .First();
        }

        public int? FirstSithLordYearLINQ(IEnumerable<Wizard> wizards) {
            var query = from w in wizards
                        where w.Name.StartsWith("Darth ")
                        orderby w.Year
                        select w.Year;
            return query.First();
        }

        public IEnumerable<(string, int?)> UniqueHarryPotterWizardsExt(IEnumerable<Wizard> wizards) {
            return wizards.Where(wizard => wizard.Medium.Contains("Harry Potter"))
                          .OrderBy(wizard => wizard.Year)
                          .Select(wizard => (wizard.Name, wizard.Year));
        }

        public IEnumerable<(string, int?)> UniqueHarryPotterWizardsLINQ(IEnumerable<Wizard> wizards) {
            var query = from w in wizards
                        where w.Medium.Contains("Harry Potter")
                        orderby w.Year
                        select (w.Name, w.Year);
            return query;
        }

        public IEnumerable<IEnumerable<string>> WizardsByCreatorExt(IEnumerable<Wizard> wizards) {
            return wizards.OrderByDescending(w => w.Creator)
                          .ThenByDescending(w => w.Name)
                          .GroupBy(w => w.Creator, w => w.Name);
        }

        public IEnumerable<IEnumerable<string>> WizardsByCreatorLINQ(IEnumerable<Wizard> wizards) {
            var query = from wizard in wizards
                        orderby wizard.Creator descending
                        orderby wizard.Name descending
                        group wizard.Name by wizard.Creator;
            return query;
        }
    }
}
