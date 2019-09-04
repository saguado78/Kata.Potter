using System.Collections.Generic;

namespace Potter.Logic
{
    public class ShoppingCart
    {
        public List<Book> CartBooks { get; set; }
        
        public ShoppingCart(){
            CartBooks= new List<Book>();
        }
    }
}