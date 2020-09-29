using CleanArch.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

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
