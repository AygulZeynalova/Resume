namespace Resume.Models.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public byte Experience { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string Location { get; set; }
        public required string Degree { get; set; }
        public required string Bio { get; set; }
        public required string Fax { get; set; }
        public required string Website { get; set; }
        public required string AttachmentPath { get; set; }
        public required string CareerLevel { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
