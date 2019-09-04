namespace Potter.Logic
{
    public class PotterCalculator
    {
        public double Calculate(ShoppingCart cart){
            double res=cart.CartBooks.Count*10;

            return res;
        }
    }
}