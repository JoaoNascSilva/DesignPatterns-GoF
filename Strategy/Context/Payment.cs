using Strategy.Interface;

namespace Strategy.Context
{
    public class Payment : IPaymentStrategy
    {
        public decimal ApplyFine(decimal? value)
        {
            throw new System.NotImplementedException();
        }
    }
}