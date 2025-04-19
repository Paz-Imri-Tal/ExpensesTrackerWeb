namespace ExpensesTrackerWeb.Models
{
    public class Expense
    {
        public int Id { get; set;}
        public string Particular { get; set; } = string.Empty;

        public double Amount { get; set;}


    }
}
