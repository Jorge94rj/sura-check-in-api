namespace SuraCheckIn.API.Models
{
    public class Payment
    {
        public enum State { Pending, Done }
        public int Id { get; set; }
        public State Status { get; set; }
        public float Amount { get; set; }
        
        // eventoId
        // userId
    }
}