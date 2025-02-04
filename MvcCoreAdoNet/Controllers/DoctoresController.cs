using Microsoft.AspNetCore.Mvc;
using MvcCoreAdoNet.Models;
using MvcCoreAdoNet.Repositories;

namespace MvcCoreAdoNet.Controllers
{
    public class DoctoresController : Controller
    {
        RepositoryDoctor repo;

        public DoctoresController()
        {
            this.repo = new RepositoryDoctor();
        }

        public async Task<IActionResult> DoctoresEspecialidad()
        {
            List<Doctor> doctores = await this.repo.GetDoctoresAsync();
            return View(doctores);
        }

        [HttpPost]
        public async Task<IActionResult> 
            DoctoresEspecialidad(string especialidad)
        {
            List<Doctor> doctores =
                await this.repo.GetDoctoresEspecialidadAsync(especialidad);
            return View(doctores);
        }
    }
}
