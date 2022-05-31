using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineproject;
namespace VendingTestingMachine.Tests
{
    public class ChokladShould
    {
        [Fact]
        public void ChokladTestUse()
        {
            Choklad Twix = new Choklad("Twix", "the famous chocolate twix ", 15, true, 8);
            string outcome = "Eating chocolate Twix yum yum  "; ;




            Assert.Equal(outcome, Twix.Use());
        }

        

        [Fact]
        public void ChokladConstructor()
        {
            Choklad chokladmerci = new Choklad("merci", "the famous chocolate merci", 16, false, 3);
          


            bool expectedhasmilk = false;
            int expectedmililiter = 3;

            Assert.Equal(expectedhasmilk, chokladmerci.hasmilk);
            Assert.Equal(expectedmililiter, chokladmerci.size);
        }

  
    }
}
