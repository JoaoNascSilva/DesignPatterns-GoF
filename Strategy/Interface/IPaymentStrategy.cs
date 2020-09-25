namespace Strategy.Interface
{
    public interface IPaymentStrategy
    {
        decimal ApplyFine(decimal? value);
    }
}