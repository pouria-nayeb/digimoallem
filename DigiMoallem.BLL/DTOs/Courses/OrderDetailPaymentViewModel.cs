using System;

namespace DigiMoallem.BLL.DTOs.Courses
{
    public class OrderDetailPaymentViewModel
    {
        public int TeacherId { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public int Price { get; set; }
        public int Payment { get; set; }
        public int TeacherPercent { get; set; }
        public bool IsPayment { get; set; }
        public int OrderTotalPrice { get; set; }
        public bool OrderFinally { get; set; }
    }
}
