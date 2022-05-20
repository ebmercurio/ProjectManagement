using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLib {
    public class Resources {

        public int Id { get; set; }
        public int ProjectId { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public int HoursPerDay { get; set; }


    }
}
