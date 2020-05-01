namespace DigiMoallem.BLL.DTOs.Accountings
{
    public class IncomesViewModel
    {
        public int CourseId { get; set; }

        public int TeacherId { get; set; }

        public int? NewCourseIncome { get; set; }

        public string CourseTitle { get; set; }

        public string TeacherName { get; set; }

        public int TeacherIncome { get; set; }

        public int InstitudeIncome { get; set; }

        public int AllIncome { get; set; }

        public int TeacherPercent { get; set; }
    }
}
