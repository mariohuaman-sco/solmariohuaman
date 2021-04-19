using SOL_MARIO_HUAMAN.DAL;
using SOL_MARIO_HUAMAN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SOL_MARIO_HUAMAN.Controllers
{
    public class HomeController : Controller
    {
        private MarioContext db = new MarioContext();
        public ActionResult Index()
        {
            var empleados = db.Empleados.OrderBy(q => q.Nombres).ToList();          
           
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> ObtenerConsultaEmpleados(string DNI)
        {
            var Empleado = db.Empleados.Where(q => q.DNI==DNI).FirstOrDefault();

            var query = from a in db.Empleados
                        join s in db.Departamento.Where(q => q.IdJefe == Empleado.Id) on a.IdDepartamento equals s.IdDepartamento
                       
                        select new
                        {
                            Id = a.Id,
                            Apellidos = a.Apellidos,
                            Nombres = a.Nombres,
                            Correo = a.Correo,
                            Celular = a.NumeroCelular,
                            DNI = a.DNI,
                            Departamento = s.Descripcion

                        };
            return Json(new
            {
                Data = query,
                TotalRows = 0
            });

        }
    }
}