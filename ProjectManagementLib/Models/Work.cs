using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLib {
    internal class Work {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ResourceId { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; } = 0;

        public virtual Project Project { get; set; }

    }
}
