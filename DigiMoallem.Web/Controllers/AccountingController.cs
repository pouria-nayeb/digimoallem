using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.BLL.Services;
using DigiMoallem.DAL.Entities.Orders;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;

namespace DigiMoallem.Web.Controllers
{
    public class AccountingController : Controller
    {
        private readonly ICourseService courseService;
        private readonly IUserService userService;
        private readonly IAccountingService accountingService;
        private readonly IPermissionService permissionService;

        public AccountingController(ICourseService courseService,
            IUserService userService,
            IAccountingService accountingService,
            IPermissionService permissionService)
        {
            this.courseService = courseService;
            this.userService = userService;
            this.accountingService = accountingService;
            this.permissionService = permissionService;
        }

        [PermissionChecker(22)]
        public IActionResult TeacherTransactions(int teacherId, string startDate, string endDate)
        {
            if (teacherId == userService.GetUserIdByUserName(User.Identity.Name) || permissionService.CheckPermission(2, User.Identity.Name))
            {

                DateTime gorgianStartDate;
                if (!string.IsNullOrEmpty(startDate))
                {
                    // feed start date
                    string[] startDateArray = startDate.Split("/");
                    gorgianStartDate = new DateTime(
                        int.Parse(startDateArray[0]),
                        int.Parse(startDateArray[1]),
                        int.Parse(startDateArray[2]),
                        new PersianCalendar()
                    );
                }
                else
                {
                    gorgianStartDate = DateTime.Now.AddDays(-29);
                }

                DateTime gorgianEndDate;
                if (!string.IsNullOrEmpty(endDate))
                {
                    // feed end date
                    string[] endDateArray = endDate.Split("/");
                    gorgianEndDate = new DateTime(
                        int.Parse(endDateArray[0]),
                        int.Parse(endDateArray[1]),
                        int.Parse(endDateArray[2]),
                        new PersianCalendar()
                    );
                }
                else
                {
                    gorgianEndDate = DateTime.Now.AddDays(2);
                }

                var teacher = userService.GetUserById(teacherId);

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Accounting");
                    var currentRow = 1;
                    worksheet.Cell(currentRow, 1).Value = "شرح";
                    worksheet.Cell(currentRow, 2).Value = "تاریخ";
                    worksheet.Cell(currentRow, 3).Value = "بدهکاری";
                    worksheet.Cell(currentRow, 4).Value = "بستانکاری";
                    worksheet.Cell(currentRow, 5).Value = "مانده کل";

                    List<int> withdraws = new List<int>();
                    List<int> deposits = new List<int>();

                    var orderDetailPayments = courseService.SearchOrderDetailPayments(gorgianStartDate, gorgianEndDate, teacherId,
                        1, 5000).OrderDetailPayments;

                    foreach (var orderDetailPayment in orderDetailPayments)
                    {
                        currentRow++;

                        withdraws.Add(((orderDetailPayment.Price * orderDetailPayment.TeacherPercent) / 100));
                        deposits.Add(orderDetailPayment.Payment);

                        if (orderDetailPayment.IsPayment)
                        {
                            // payment
                            worksheet.Cell(currentRow, 1).Value = $"واریز به {teacher.FirstName} {teacher.LastName} {orderDetailPayment.Title}";
                            worksheet.Cell(currentRow, 2).Value = orderDetailPayment.CreateDate.ToPersianDate();
                            worksheet.Cell(currentRow, 3).Value = orderDetailPayment.Payment;
                            worksheet.Cell(currentRow, 4).Value = 0;
                            worksheet.Cell(currentRow, 5).Value = (withdraws.Sum() - deposits.Sum());
                        }
                        else
                        {
                            // teacher share
                            worksheet.Cell(currentRow, 1).Value = $"درس {orderDetailPayment.Title} با {orderDetailPayment.TeacherPercent} استاد { userService.GetUserById(orderDetailPayment.TeacherId).FirstName} { userService.GetUserById(orderDetailPayment.TeacherId).LastName} {(orderDetailPayment.OrderTotalPrice == 0 ? "(تخفیف 100%)" : string.Empty)}";
                            worksheet.Cell(currentRow, 2).Value = orderDetailPayment.CreateDate.ToPersianDate();
                            worksheet.Cell(currentRow, 3).Value = 0;
                            if (orderDetailPayment.OrderTotalPrice == 0)
                            {
                                worksheet.Cell(currentRow, 4).Value = 0;
                            }
                            else {
                                worksheet.Cell(currentRow, 4).Value = accountingService.TeacherShare(orderDetailPayment.Price, orderDetailPayment.TeacherPercent);
                            }
                            worksheet.Cell(currentRow, 5).Value = (withdraws.Sum() - deposits.Sum());
                        }
                    }

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        var content = stream.ToArray();

                        return File(
                            content,
                            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                            "teacher.xlsx");
                    }
                }
            }

            return Unauthorized();
        }


        [PermissionChecker(2)]
        public IActionResult DigiMoallemTransactions(string startDate, string endDate)
        {

            DateTime gorgianStartDate;
            if (!string.IsNullOrEmpty(startDate))
            {
                // feed start date
                string[] startDateArray = startDate.Split("/");
                gorgianStartDate = new DateTime(
                    int.Parse(startDateArray[0]),
                    int.Parse(startDateArray[1]),
                    int.Parse(startDateArray[2]),
                    new PersianCalendar()
                );
            }
            else
            {
                gorgianStartDate = DateTime.Now.AddDays(-29);
            }

            DateTime gorgianEndDate;
            if (!string.IsNullOrEmpty(endDate))
            {
                // feed end date
                string[] endDateArray = endDate.Split("/");
                gorgianEndDate = new DateTime(
                    int.Parse(endDateArray[0]),
                    int.Parse(endDateArray[1]),
                    int.Parse(endDateArray[2]),
                    new PersianCalendar()
                );
            }
            else
            {
                gorgianEndDate = DateTime.Now.AddDays(2);
            }

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Accounting");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "شرح";
                worksheet.Cell(currentRow, 2).Value = "تاریخ";
                worksheet.Cell(currentRow, 3).Value = "بدهکاری";
                worksheet.Cell(currentRow, 4).Value = "بستانکاری";
                worksheet.Cell(currentRow, 5).Value = "مانده کل";

                List<int> withdraws = new List<int>();
                List<int> deposits = new List<int>();

                var orderDetailPayments = courseService.SearchCashDesk(gorgianStartDate, gorgianEndDate,
                    1, 5000).OrderDetailPayments;

                foreach (var orderDetailPayment in orderDetailPayments)
                {
                    currentRow++;

                    var teacher = userService.GetUserById(orderDetailPayment.TeacherId);

                    withdraws.Add((orderDetailPayment.Price - ((orderDetailPayment.Price * orderDetailPayment.TeacherPercent) / 100)));
                    deposits.Add(orderDetailPayment.Payment);

                    if (orderDetailPayment.IsPayment)
                    {
                        // payment
                        worksheet.Cell(currentRow, 1).Value = $"واریز به {teacher.FirstName} {teacher.LastName} {orderDetailPayment.Title}";
                        worksheet.Cell(currentRow, 2).Value = orderDetailPayment.CreateDate.ToPersianDate();
                        worksheet.Cell(currentRow, 3).Value = orderDetailPayment.Payment;
                        worksheet.Cell(currentRow, 4).Value = 0;
                        worksheet.Cell(currentRow, 5).Value = (withdraws.Sum() - deposits.Sum());
                    }
                    else
                    {
                        // digimallem share
                        worksheet.Cell(currentRow, 1).Value = $"سهم دیجی معلم از درس {orderDetailPayment.Title} با {orderDetailPayment.TeacherPercent} استاد { userService.GetUserById(orderDetailPayment.TeacherId).FirstName} { userService.GetUserById(orderDetailPayment.TeacherId).LastName} {(orderDetailPayment.OrderTotalPrice == 0 ? "(تخفیف 100%)" : string.Empty)}";
                        worksheet.Cell(currentRow, 2).Value = orderDetailPayment.CreateDate.ToPersianDate();
                        worksheet.Cell(currentRow, 3).Value = 0;
                        if (orderDetailPayment.OrderTotalPrice == 0)
                        {
                            worksheet.Cell(currentRow, 4).Value = 0;
                        }
                        else {
                            worksheet.Cell(currentRow, 4).Value = (orderDetailPayment.Price - accountingService.TeacherShare(orderDetailPayment.Price, orderDetailPayment.TeacherPercent));
                        }
                        worksheet.Cell(currentRow, 5).Value = (withdraws.Sum() - deposits.Sum());
                    }
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "digimoallem.xlsx");
                }
            }
        }


    }
}