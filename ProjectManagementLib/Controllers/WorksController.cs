using ProjectManagementLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLib.Controllers {
    public class WorksController {
        private AppDbContext _context = new AppDbContext();

        private void Recalculate(int projectId) {
            var works = GetWorks();
            var sum = 0;
            foreach (var work in works) {
                if (work.ProjectId == projectId) {
                    sum += work.Hours;
                }
            }
            var project = _context.Projects.Find(projectId);
            project.ActualHours = sum;
            _context.SaveChanges();
        }

        //return all Works
        public List<Work> GetWorks() {
            return _context.Works.ToList();
        }


        //return work by Id
        public Work GetWork(int id) {
            return _context.Works.Find(id);
        }


        //add work
        public Work AddWork(Work work) {
            _context.Works.Add(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("AddWork failed");
            }
            Recalculate(work.ProjectId);
            _context.SaveChanges();
            return work;
        }


        //change work
        public void UpdateWork(Work work) {
            _context.Entry(work).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("UpdateWorks failed");
            }
            Recalculate(work.ProjectId);
            _context.SaveChanges();
        }


        //delete work
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
            Recalculate(work.ProjectId);
            _context.SaveChanges();
        }
    }
}
