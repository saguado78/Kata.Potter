using System.Collections.Generic;
using System.Linq;

namespace Potter.Logic
{
    public class ShoppingCart
    {
        public List<Book> CartBooks { get; set; }
        
        public ShoppingCart(){
            CartBooks= new List<Book>();
        }

        public List<Book> Set_of_different_titles_without_discount(){
            List<Book> res=new List<Book>();
            int TotalBooksWithoutDiscount=0;
            int numBooks01NoDiscount=CountBooksWihoutDiscountByTitle(1);
            int numBooks02NoDiscount=CountBooksWihoutDiscountByTitle(2);
            int numBooks03NoDiscount=CountBooksWihoutDiscountByTitle(3);
            int numBooks04NoDiscount=CountBooksWihoutDiscountByTitle(4);
            int numBooks05NoDiscount=CountBooksWihoutDiscountByTitle(5);
            TotalBooksWithoutDiscount=numBooks01NoDiscount
                +numBooks02NoDiscount
                +numBooks03NoDiscount
                +numBooks04NoDiscount
                +numBooks05NoDiscount;
            if (!(numBooks01NoDiscount==0 
                && numBooks02NoDiscount==0 
                && numBooks03NoDiscount==0
                && numBooks04NoDiscount==0
                && numBooks05NoDiscount==0))
            {
                if(numBooks01NoDiscount>0 && numBooks01NoDiscount!=TotalBooksWithoutDiscount){
                    res.Add(SelectBookWithoutDiscountByNumber(1));
                }
                if(numBooks02NoDiscount>0 && numBooks02NoDiscount!=TotalBooksWithoutDiscount){
                    res.Add(SelectBookWithoutDiscountByNumber(2));
                }
                if(numBooks03NoDiscount>0 && numBooks03NoDiscount!=TotalBooksWithoutDiscount){
                    res.Add(SelectBookWithoutDiscountByNumber(3));
                }
                if(numBooks04NoDiscount>0 && numBooks04NoDiscount!=TotalBooksWithoutDiscount){
                    res.Add(SelectBookWithoutDiscountByNumber(4));
                }
                if(numBooks05NoDiscount>0 && numBooks05NoDiscount!=TotalBooksWithoutDiscount){
                    res.Add(SelectBookWithoutDiscountByNumber(5));
                }
            }
            return res;
        }

        private int CountBooksWihoutDiscountByTitle(int titleNumber){
            int res=0;
            string titleName=Book.Select_title(titleNumber);
            res=(from Book item in CartBooks
                    where item.Title==titleName
                    && ! item.HasDiscountApplied()  
                    select item).Count();
            return res;
        }

        private Book SelectBookWithoutDiscountByNumber(int titleNumber){
            Book res=null;
            string titleName=Book.Select_title(titleNumber);
            res=(from Book item in CartBooks
                    where item.Title==titleName
                    && ! item.HasDiscountApplied()  
                    select item).First();
            return res;
        }
    }
}