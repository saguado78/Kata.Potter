using System;
using System.Collections.Generic;
using System.Linq;

namespace Potter.Logic
{
    public class PotterCalculator
    {
        public double Calculate(ShoppingCart cart){
            Calculate_discounts(cart);
            double res= (from Book item in cart.CartBooks select item.FinalPrice).Sum();
            return res;
        }

        private void Calculate_discounts(ShoppingCart cart)
        {
            List<Book> setOfBooks=cart.Set_of_different_titles_without_discount();
            int numberOfBooks=setOfBooks.Count();
            foreach(Book aBook in setOfBooks){
                if(numberOfBooks==2){
                    aBook.ApplyDiscount(5.0);
                }
                else if(numberOfBooks==3){
                    aBook.ApplyDiscount(10.0);
                }
                else{
                    aBook.ApplyDiscount(20.0);
                }
                
            }
        }
    }
}