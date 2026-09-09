namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer? customer, float amount)
        {
            return customer?.Account.Charge(amount) ?? false;
        }

        public void AddIncome(Customer? customer, float amount)
        {
            customer?.Account.AddIncome(amount);
        }
    }
}
