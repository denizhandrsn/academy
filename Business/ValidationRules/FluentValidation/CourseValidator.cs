using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator:AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.CourseDetail.CourseName).NotEmpty();
        }
    }
}
