using CleanArch.Domain.Commands;

namespace CleanArch.Domain.CommandHandlers
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
