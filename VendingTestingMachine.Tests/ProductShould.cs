using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineproject;
namespace VendingTestingMachine.Tests
{
   public  class ProductShould
    {
        [Fact]
        public void SnacksUse()
        {
            Product EsterellaChips = new Snacks("EsterellaChips", "A type of snack Esterella", 12, false, 240); 

            string Forvantat = "Eating snack EsterellaChips crush  crush ..";

            Assert.Equal(Forvantat, EsterellaChips.Use());
        }

       
    }
}
