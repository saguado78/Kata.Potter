namespace Potter.Logic
{
    public class Book
    {

        public string Title { get; set; }  
        public double BasicPrice{get;set;}
        public double FinalPrice{get;set;}

        public Book(int bookNumber, double price){
            Title=Select_title(bookNumber); 
            BasicPrice=price;
            FinalPrice=price;  
        }

        public bool HasDiscountApplied(){
            return BasicPrice!=FinalPrice;
        }

        public void ApplyDiscount(double discountPercentage){
            FinalPrice=System.Math.Round((100.0-discountPercentage)*BasicPrice/100.0,2,System.MidpointRounding.AwayFromZero);
        }
        
        public const string first_title="First book";
        public const string second_title="second book";
        public const string third_title="third book";
        public const string fourth_title="fourth book";
        public const string fifth_title="fifth book";

        public static string Select_title(int bookNumer){
            string result=string.Empty;
            switch(bookNumer){
                case 1:
                result=first_title;
                break;
                case 2:
                result=second_title;
                break;
                case 3:
                result=third_title;
                break;
                case 4:
                result=fourth_title;
                break;
                case 5:
                result=fifth_title;
                break;
            }
            return result;
        }
    }
}