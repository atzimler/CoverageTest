using CoveredLibrary;
using NUnit.Framework;

namespace CoverageTests
{
    [TestFixture]
    public class BusinessLogicCoverageTest
    {
        [Test]
        public void ExecuteCoveredCode()
        {
            var bl = new BusinessLogicClass();
            bl.Execute();
        }
    }
}
