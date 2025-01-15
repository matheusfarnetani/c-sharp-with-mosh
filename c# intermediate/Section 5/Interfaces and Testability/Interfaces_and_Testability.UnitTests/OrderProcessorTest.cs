using Interfaces_and_Testability;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces_and_Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTest
    {
        // METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(OrderProcessorTest order)
        {
            return 10f;
        }
    }
}
