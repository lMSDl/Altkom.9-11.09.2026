namespace DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
            IsActive = true;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    
        public PaymentAccount Account { get; } = new PaymentAccount();
    }
}
