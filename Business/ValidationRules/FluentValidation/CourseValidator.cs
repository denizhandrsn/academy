using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator:AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.CourseName).NotEmpty();
            RuleFor(c => c.CoursePrice).GreaterThan(0).NotEmpty();
            RuleFor(c => c.CoursePrice).GreaterThanOrEqualTo(40).When(c => c.CategoryId == 1);
        }
    }
}
