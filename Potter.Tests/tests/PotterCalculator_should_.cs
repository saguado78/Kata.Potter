using Potter.Logic;
using NUnit.Framework;
namespace Potter.Tests.tests
{
[TestFixture]
    public class PotterCalculator_should_
    {
        const double defaultPrice=8.0;

        private ShoppingCart BuildMeAShoppingCart(int amountBook1
                        ,int amountBook2
                        ,int amountBook3
                        ,int amountBook4
                        ,int amountBook5){
            ShoppingCart res = new ShoppingCart();
            while(amountBook1>0){
                res.CartBooks.Add(new Book(1,defaultPrice));
                amountBook1--;
            }
            while(amountBook2>0){
                res.CartBooks.Add(new Book(2,defaultPrice));
                amountBook2--;
            }
            while(amountBook3>0){
                res.CartBooks.Add(new Book(3,defaultPrice));
                amountBook3--;
            }
            while(amountBook4>0){
                res.CartBooks.Add(new Book(4,defaultPrice));
                amountBook4--;
            }
            while(amountBook5>0){
                res.CartBooks.Add(new Book(5,defaultPrice));
                amountBook5--;
            }
            return res;
        }
        [Test]
        public void return_zero_when_buying_no_books(){
            PotterCalculator calc = new PotterCalculator();

            double res= calc.Calculate(new ShoppingCart());

            Assert.AreEqual(res,0,"unexpected result: " + res.ToString()+" // Expected 0");
        }

        [Test]
        public void return_8_when_buying_a_single_book(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=BuildMeAShoppingCart(1,0,0,0,0);

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,defaultPrice,"unexpected result: " +res.ToString() + " // Expected 16");
        }
        
        [Test]
        public void return_16_when_buying_2_copies_of_a_book(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=BuildMeAShoppingCart(2,0,0,0,0);

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,2*defaultPrice,"unexpected result: " + res.ToString()+" // Expected 16");
        }

        [Test]
        public void apply_5_percent_discount_when_buying_1_copy_of_2_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=BuildMeAShoppingCart(1,1,0,0,0);

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,2*defaultPrice*0.95,"unexpected result: " + res.ToString()+" // Expected 15.2");
        }

        [Test]
        public void apply_10_percent_discount_when_buying_1_copy_of_3_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=BuildMeAShoppingCart(1,1,1,0,0);

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,3*defaultPrice*0.90,"unexpected result: " + res.ToString()+" // Expected 21.6");
        }

        [Test]
        public void apply_20_percent_discount_when_buying_1_copy_of_4_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=BuildMeAShoppingCart(1,1,1,1,0);
            
            double res= calc.Calculate(cart);

            Assert.AreEqual(res,4*defaultPrice*0.80,"unexpected result: " + res.ToString()+" // Expected 27.2");
        }

        [Test]
        public void apply_25_percent_discount_when_buying_1_copy_of_5_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=BuildMeAShoppingCart(1,1,1,1,1);
            
            double res= calc.Calculate(cart);

            Assert.AreEqual(res,5*defaultPrice*0.75,"unexpected result: " + res.ToString()+" // Expected 30.0");
        }

        [Test]
        public void apply_5_percent_discount_when_buying_2_copy_of_2_different_books(){
            PotterCalculator calc = new PotterCalculator();
            ShoppingCart cart=BuildMeAShoppingCart(2,2,0,0,0);

            double res= calc.Calculate(cart);

            Assert.AreEqual(res,4*defaultPrice*0.95,"unexpected result: " + res.ToString()+" // Expected 15.2");
        }
    }
}