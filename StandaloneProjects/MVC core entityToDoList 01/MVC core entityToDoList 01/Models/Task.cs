using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_core_entityToDoList_01.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        //foreign key category id
        public int? categoryID { get; set; }
        public virtual Category category { get; set; }
    }
}
