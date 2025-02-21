namespace Core.Domain
{
    public class Loan
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public decimal Amount { get; set; }

        public string Status { get; set; }
    }
}