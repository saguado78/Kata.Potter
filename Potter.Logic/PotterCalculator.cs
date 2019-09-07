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
            foreach(Book aBook in setOfBooks){
                aBook.ApplyDiscount(5.0);
            }
        }
    }
}