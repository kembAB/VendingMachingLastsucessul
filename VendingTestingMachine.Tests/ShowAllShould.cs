using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineproject;
namespace VendingTestingMachine.Tests
{
    public class ShowAllShould
    {
        [Fact]
        public void ShowCollection()
        {
            VendingMachine show = new VendingMachine();

            Dictionary<string, Product> ExpectedList = show.ShowAll();
            Dictionary<string, Product> ActuralList = show.ShowAll();

           

            ActuralList = show.ShowAll();

            Assert.Equal(ExpectedList, ActuralList);
        }
    }
}
