namespace SOLID.S
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        // Odpowiedzialność: logika biznesowa faktury
        public decimal CalculateTax()
        {
            return Amount * 0.23m;
        }
    }

    public class InvoiceRepository
    {
        public void SaveToFile(Invoice invoice, string path)
        {
            System.IO.File.WriteAllText(path, $"Invoice {invoice.Id}, Amount: {invoice.Amount}");
        }
    }

    public class EmailService
    {
        public void SendEmail(Invoice invoice, string email)
        {
            Console.WriteLine($"Sending invoice {invoice.Id} to {email}");
        }
    }

    /*public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        // Odpowiedzialność: logika biznesowa faktury
        public decimal CalculateTax()
        {
            return Amount * 0.23m;
        }

        // Odpowiedzialność: zapis do pliku
        public void SaveToFile(string path)
        {
            File.WriteAllText(path, $"Invoice {Id}, Amount: {Amount}");
        }

        // Odpowiedzialność: wysyłanie e-maila
        public void SendEmail(string email)
        {
            Console.WriteLine($"Sending invoice {Id} to {email}");
        }
    }*/
}
