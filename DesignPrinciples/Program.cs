
using DesignPrinciples;

var service = new PaymentService();

var custmerId = 1;

var customersService = new CustomersService();
var customer = customersService.FindById(custmerId);
var paymentService = new PaymentService();
paymentService.AddIncome(customer, 500);
if (paymentService.Charge(customer, 100))
{
    Console.WriteLine($"Customer {custmerId} charged. Actual balace: {customer.Account.GetBalance()}");
}
else
{
    Console.WriteLine($"Customer {custmerId} cannot be charged. Actual balace: {customer.Account.GetBalance()}");
}