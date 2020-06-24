using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TextEditorControl.Models
{
    public class TextEditorModel
    {
        [Display(Name = "User Name")]
        public string Name { get; set; }

        [AllowHtml]
        [Display(Name="Description")]
        public string Message { get; set; }
    }
}