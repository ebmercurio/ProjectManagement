using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementLib.Models;

namespace ProjectManagementLib.Controllers {
    public class ResourcesController {
        private AppDbContext _context = new AppDbContext();

        #region GetResources()
        public List<Resources> GetResources() {

            return _context.Resources.ToList();

        }
        #endregion
        #region GetResources()
        public Resources GetResources(int id) {
            return _context.Resources.Find(id)!;
        }
        #endregion

        #region AddResources()
        public Resources AddResources(Resources resources) {
            _context.Resources.Add(resources);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("AddResources failed!");
            }
            return resources;
        }
        #endregion

        #region UpdateResources()
        public void UpdateResources(Resources resources) {
            _context.Entry(resources).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("UpdateResources failed!");
            }
        }
        #endregion

        #region DeleteResources()
        public void DeleteUser(int id) {
            var resources = GetResources(id);
            if (resources is null) {
                throw new Exception("Resources not found!");
            }  
            _context.Resources.Remove(resources);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("DeleteResources Failed!");
            }
        }
        #endregion
    }
}
