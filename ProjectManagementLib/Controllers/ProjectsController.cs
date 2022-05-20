using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementLib.Models;


namespace ProjectManagementLib.Controllers {
    public class ProjectsController {
        private AppDbContext _context = new AppDbContext();


        ////return all projects
        //public List<Project> GetProjects() {
        //    return _context.Projects.ToList();
        //}


        ////return project by Id
        //public Project GetProject(int id) {
        //    return _context.Projects.FindAsync(id);
        //}


        ////add project
        //public Project AddProject(Project project) {
        //    _context.Projects.Add(project);
        //    var rowsAffected = _context.SaveChanges();
        //    if (rowsAffected != 1) {
        //        throw new Exception("AddProject failed");
        //    }
        //    return project;
        //}


        ////change project
        //public void UpdateProject(Project project) {
        //    _context.Entry(project).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    var rowsAffected = _context.SaveChanges();
        //    if (rowsAffected != 1) {
        //        throw new Exception("UpdateProject failed");
        //    }
        //}


        ////delete Project
        //public void DeleteProject(int id) {
        //    var project = GetProject(id);


        //}
    }
}

