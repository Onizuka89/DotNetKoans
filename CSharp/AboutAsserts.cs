using Xunit;

namespace DotNetKoans.CSharp
{
    public class AboutAsserts : Koan
    {
        [Koan(1)]
        public void AssertTruth()
        {
            // We shall contemplate truth by testing reality, via asserts.
            Assert.True(false); //This should be true
        }

        [Koan(2)]
        public void AssertTruthWithMessage()
        {
            // Enlightenment may be more easily achieved with appropriate messages.
            Assert.True(false, "This should be true -- Please fix this");
        }

        [Koan(3)]
        public void AssertEquality()
        {
            // To understand reality, we must compare our expectations against reality
            var expectedValue = 3;
            var actualValue = 1 + 1;
            Assert.True(expectedValue == actualValue);
        }

        [Koan(4)]
        public void ABetterWayOfAssertingEquality()
        {
            // Some ways of asserting equality are better than others
            var expectedValue = 3;
            var actualValue = 1 + 1;
            Assert.Equal(expectedValue, actualValue);
        }

        [Koan(5)]
        public void FillInValues()
        {
            // Sometimes we will ask you to fill in the values
            Assert.Equal(FILL_ME_IN, 1 + 1);
        }
    }
}
