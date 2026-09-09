
using DesignPrinciples;

var service = new PaymentService();

var custmerId = 1;

var customer = service.FindById(custmerId);
service.AddIncome(custmerId, 500);
if (service.Charge(custmerId, 100))
{
    Console.WriteLine($"Customer {custmerId} charged. Actual balace: {customer.GetBalance()}");
}
else
{
    Console.WriteLine($"Customer {custmerId} cannot be charged. Actual balace: {customer.GetBalance()}");
}