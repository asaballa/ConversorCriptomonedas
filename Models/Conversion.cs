namespace ConversorCriptomonedas.Models
{
    public class Conversion
    {
        public int Id { get; set; }
        public string Cryptocurrency { get; set; }
        public string TraditionalCurrency { get; set; }
        public decimal Amount { get; set; }
    }
}
