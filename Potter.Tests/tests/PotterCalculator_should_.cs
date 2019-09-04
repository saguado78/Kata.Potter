using Potter.Logic;
using NUnit.Framework;
namespace Potter.Tests.tests
{
[TestFixture]
    public class PotterCalculator_should_
    {
        [Test]
        public void return_zero_when_buying_no_books(){
            PotterCalculator calc = new PotterCalculator();

            double res= calc.Calculate(new ShoppingCart());

            Assert.AreEqual(res,0,"unexpected result for empty shopping cart");
        }

        [Test]
        public void return_10_when_buying_a_single_book(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=new ShoppingCart();
            cart.CartBooks.Add(new Book(1,10.0));

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,10.0,"unexpected result for empty shopping cart");
        }
        
    }
}