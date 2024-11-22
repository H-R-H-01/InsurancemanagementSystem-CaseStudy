namespace InsuranceManagementSystem.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public int ClientId { get; set; }

        public Payment() { }

        public Payment(int paymentId, DateTime paymentDate, decimal paymentAmount, int clientId)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            PaymentAmount = paymentAmount;
            ClientId = clientId;
        }
        public void PrintPaymentDetails()
        {
            Console.WriteLine($"PaymentId: {PaymentId}, PaymentDate: {PaymentDate}, Amount: {PaymentAmount}, ClientId: {ClientId}");
        }
    }
}
