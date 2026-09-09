namespace DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(PaymentAccount? account, float amount)
        {
            return account?.Charge(amount) ?? false;
        }

        public void AddIncome(PaymentAccount? account, float amount)
        {
            account?.AddIncome(amount);
        }
    }
}
