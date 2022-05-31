using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineproject;
namespace VendingTestingMachine.Tests
{
    public class SoftDrinkShould
    {
        [Fact]
        public void TestUse()
        {
            SoftDrinks Sprite = new SoftDrinks("Sprite", "The famous soft drink Sprite", 12, true, 12);
            string outcome = "Drinking soft drink   Sprite sip   sip ..";
           

          

            Assert.Equal(outcome, Sprite.Use());
        }

    

        [Fact]
        public void SoftDrinkConstructor()
        {
            
            SoftDrinks Cola = new SoftDrinks("Cola", "The famous soft drink cola", 12); ;
            
            
            bool sugerfree = false;
            int mililiter = 33;

            Assert.Equal(sugerfree, Cola.sugerfree);
            Assert.Equal(mililiter, Cola.mililiter);
        }

        [Fact]
        public void SoftDrinkSecondConstructor()
        {
            SoftDrinks Sprite = new SoftDrinks("Sprite", "The famous soft drink Sprite", 12, true, 12);
            bool osugerfree = true;
            int omililiter = 12;

            Assert.Equal(osugerfree, Sprite.sugerfree);
            Assert.Equal(omililiter, Sprite.mililiter);
        }
    }
}
