using Core.Utilities.Exceptions.BusinessExceptions;
using DataAccess.Abstracts;

namespace Business.BusinessRules
{
    public class CourseBusinessRules
    {
        ICourseDal _courseDal;
        public CourseBusinessRules(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void CheckIfCourseAlreadyExists(string courseName)
        {
            var result = _courseDal.GetAll(c => c.CourseName == courseName).Any();
            if (result)
            {
                throw new BusinessRuleException();
            }
            
        }
        public void CheckIfCourseCategoryExceedsLimit(int categoryId)
        {
            var result = _courseDal.GetAll(c => c.CategoryId == categoryId).Count();
            if (result > 10)
            {
                throw new BusinessRuleException();
            }
            
        }



    }
}
