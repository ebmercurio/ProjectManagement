using ProjectManagementLib.Models;
using ProjectManagementLib.Controllers;
using ProjectManagementLib;

void Main() { }

var db = new AppDbContext();

var worksCtrl = new WorksController();

var work = new Work() {
    Id = 0, ProjectId = 1, Description = "Depression", Hours = 100, ResourceId = 9
};

// worksCtrl.AddWork(work);
