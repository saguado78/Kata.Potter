using Potter.Logic;
using NUnit.Framework;
namespace Potter.Tests.tests
{
[TestFixture]
    public class PotterCalculator_should_
    {
        const double defaultPrice=8.0;
        [Test]
        public void return_zero_when_buying_no_books(){
            PotterCalculator calc = new PotterCalculator();

            double res= calc.Calculate(new ShoppingCart());

            Assert.AreEqual(res,0,"unexpected result: " + res.ToString()+" // Expected 0");
        }

        [Test]
        public void return_8_when_buying_a_single_book(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=new ShoppingCart();
            cart.CartBooks.Add(new Book(1,defaultPrice));

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,defaultPrice,"unexpected result: " +res.ToString() + " // Expected 16");
        }
        
        [Test]
        public void return_16_when_buying_2_copies_of_a_book(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=new ShoppingCart();
            cart.CartBooks.Add(new Book(1,defaultPrice));
            cart.CartBooks.Add(new Book(1,defaultPrice));

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,2*defaultPrice,"unexpected result: " + res.ToString()+" // Expected 16");
        }

        [Test]
        public void apply_5_percent_discount_when_buying_1_copy_of_2_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=new ShoppingCart();
            cart.CartBooks.Add(new Book(1,defaultPrice));
            cart.CartBooks.Add(new Book(2,defaultPrice));

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,2*defaultPrice*0.95,"unexpected result: " + res.ToString()+" // Expected 15.2");
        }

        [Test]
        public void apply_10_percent_discount_when_buying_1_copy_of_3_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=new ShoppingCart();
            cart.CartBooks.Add(new Book(1,defaultPrice));
            cart.CartBooks.Add(new Book(2,defaultPrice));
            cart.CartBooks.Add(new Book(3,defaultPrice));

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,3*defaultPrice*0.90,"unexpected result: " + res.ToString()+" // Expected 21.6");
        }

        [Test]
        public void apply_20_percent_discount_when_buying_1_copy_of_4_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=new ShoppingCart();
            cart.CartBooks.Add(new Book(1,defaultPrice));
            cart.CartBooks.Add(new Book(2,defaultPrice));
            cart.CartBooks.Add(new Book(3,defaultPrice));
            cart.CartBooks.Add(new Book(4,defaultPrice));
            
            double res= calc.Calculate(cart);

            Assert.AreEqual(res,4*defaultPrice*0.80,"unexpected result: " + res.ToString()+" // Expected 27.2");
        }

        [Test]
        public void apply_25_percent_discount_when_buying_1_copy_of_5_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=new ShoppingCart();
            cart.CartBooks.Add(new Book(1,defaultPrice));
            cart.CartBooks.Add(new Book(2,defaultPrice));
            cart.CartBooks.Add(new Book(3,defaultPrice));
            cart.CartBooks.Add(new Book(4,defaultPrice));
            cart.CartBooks.Add(new Book(5,defaultPrice));
            
            double res= calc.Calculate(cart);

            Assert.AreEqual(res,5*defaultPrice*0.75,"unexpected result: " + res.ToString()+" // Expected 30.0");
        }
    }
}