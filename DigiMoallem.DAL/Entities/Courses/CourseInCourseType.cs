using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class CourseInCourseType
    {
        [Key]
        public int CourseInCourseTypeId { get; set; }

        public int CourseId { get; set; }

        public int CourseTypeId { get; set; }

        #region Relations and Properties

        public Course Course { get; set; }

        public CourseType CourseType { get; set; }

        #endregion
    }
}
