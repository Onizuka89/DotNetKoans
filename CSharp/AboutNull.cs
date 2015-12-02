using NUnit.Framework;

namespace DotNetKoans.CSharp
{
    public class AboutNull : Koan
    {
        [Koan(1)]
        public void NullIsNotAnObject()
        {
            // Not everything is an object.
            Assert.True(null is object);
        }

        [Koan(2)]
        public void YouGetNullPointerErrorsWhenCallingMethodsOnNull()
        {
            //What is the Exception that is thrown when you call a method on a null object?
            //Don't be confused by the code below. It is using Anonymous Delegates which we will
            //cover later on. 
            object nothing = null;
            Assert.Throws(typeof(FillMeIn), delegate() { nothing.ToString(); });

            //What's the message of the exception? What substring or pattern could you test
            //against in order to have a good idea of what the string is?
            try
            {
                nothing.ToString();
            }
            catch (System.Exception ex)
            {
                Assert.That(ex.Message, Does.Contain(FILL_IN_THE_STRING));
            }
        }

        [Koan(3)]
        public void CheckingThatAnObjectIsNull()
        {
            object obj = null;
            Assert.True(obj == FILL_ME_IN);
        }

        [Koan(4)]
        public void BetterWaysToCheckThatAnObjectIsNull()
        {
            object obj = null;
            Assert.Null(FILL_ME_IN);
            Assert.That(FILL_ME_IN, Is.Null);
        }

        [Koan(5)]
        public void AWayNotToCheckThatAnObjectIsNull()
        {
            object obj = null;
            Assert.True(obj.Equals(null));
        }
    }
}
