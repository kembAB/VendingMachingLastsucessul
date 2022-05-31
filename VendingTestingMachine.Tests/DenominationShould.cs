using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineproject;
namespace VendingTestingMachine.Tests
{
    public class DenominationShould
    {
        [Theory]
        [InlineData(1, true, 1)]
        [InlineData(5, true, 5)]
        [InlineData(100, true, 100)]
        [InlineData(500, true, 500)]
        [InlineData(1000, true, 1000)]
        [InlineData(0, false, 0)]
        public void Deposit(int money, bool outcome, int denomiation)
        {
            VendingMachine deno = new VendingMachine();

            Assert.Equal(outcome, deno.InsertMoney(money));
            Assert.Equal(denomiation, deno.Money);
        }

    }
}
