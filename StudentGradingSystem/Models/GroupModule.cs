using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGradingSystem.Models
{
    public class GroupModule
    {
        public ModuleDetails ModuleDetail { get; set; }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
