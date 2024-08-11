namespace Resume.Models.Entities
{
    public class ContactPost
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Subject { get; set; }
        public required string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? AnsweredBy { get; set; }
        public DateTime? AnsweredAt { get; set; }
        public DateTime? AnsweredMessage { get; set; }
    }
}
