
using DesignPrinciples;

var service = new PaymentService();

var custmerId = 1;

var customersService = new CustomersService();
var customer = customersService.FindById(custmerId);
var account = customer?.Account;
var paymentService = new PaymentService();

paymentService.AddIncome(account, 500);
if (paymentService.Charge(account, 100))
{
    Console.WriteLine($"Customer {custmerId} charged. Actual balace: {account.GetBalance()}");
}
else
{
    Console.WriteLine($"Customer {custmerId} cannot be charged. Actual balace: {account.GetBalance()}");
}