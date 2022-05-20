using ProjectManagementLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLib.Controllers {
    public class WorksController {
        private AppDbContext _context = new AppDbContext();


        //return all projects
        public List<Work> GetWorks() {
            return _context.Works.ToList();
        }


        //return project by Id
        public Work GetWork(int id) {
            return _context.Works.Find(id);
        }


        //add project
        public Work AddWork(Work work) {
            _context.Works.Add(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("AddWork failed");
            }
            return work;
        }


        //change project
        public void UpdateWork(Work work) {
            _context.Entry(work).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("UpdateWorks failed");
            }
        }


        //delete Project
        public void DeleteWork(int id) {
            var work = GetWork(id);
            if (work is null) {
                throw new Exception("Work not found");
            }
            _context.Works.Remove(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("DeleteWork failed!");
            }

        }
    }
}
