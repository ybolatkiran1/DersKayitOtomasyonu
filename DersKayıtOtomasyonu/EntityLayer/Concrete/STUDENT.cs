using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class STUDENT
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentMail { get; set; }
        public string StudentPassword{ get; set; }
        public string StudentTel { get; set; }
        public int StudentPeriod{ get; set; }
        public bool StudentStatus{ get; set; }
        
    }
}
