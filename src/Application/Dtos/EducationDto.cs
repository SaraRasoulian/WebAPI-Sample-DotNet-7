namespace Application.Dtos
{
    public class EducationDto
    {
        public Guid Id { get; set; }
        public required string Degree { get; set; }
        public required string FieldOfStudy { get; set; }
        public required string School { get; set; }
        public string? Description { get; set; }
    }
}
