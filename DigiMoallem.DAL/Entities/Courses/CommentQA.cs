﻿using DigiMoallem.DAL.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class CommentQA
    {
        [Key]
        public int CommentQAId { get; set; }

        public int CourseId { get; set; }

        public int UserId { get; set; }

        [Display(Name = "نظر شما")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(750, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Body { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsDelete { get; set; }

        public bool ReadByAdmin { get; set; }

        [Display(Name = "پاسخ")]
        public int? ParentId { get; set; }

        #region Relations - Navigation Properties

        [ForeignKey("ParentId")]
        public List<CommentQA> CommentQAs { get; set; }

        public Course Course { get; set; }

        public User User { get; set; }

        #endregion
    }
}
