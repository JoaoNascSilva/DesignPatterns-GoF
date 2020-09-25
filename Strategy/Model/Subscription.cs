using System;
namespace Strategy.Model
{
    public class Subscription
    {
        public Guid Id { get; private set; }
        public decimal? Value { get; private set; }
        public DateTime DueDate { get; private set; }

        public Subscription(decimal? value)
        {
            this.Id = Guid.NewGuid();
            this.Value = value;
            this.DueDate = DateTime.Now.AddDays(-1);
        }

        public void Pay()
        {

        }
    }
}