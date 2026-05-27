using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_Red.Data;
using Proyecto_Red.Models;
using Proyecto_Red.ViewModels;

namespace Proyecto_Red.Controllers
{
    [Authorize(Roles = "Administrador,Analista")]
    public class PetiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetiController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await BuildViewModelAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearIndicador([Bind(Prefix = "NuevoIndicador")] IndicadorKPI indicador)
        {
            indicador.Semaforo = CalcularSemaforo(indicador.PorcentajeCumplimiento, indicador.Semaforo);

            if (!ModelState.IsValid)
            {
                var model = await BuildViewModelAsync();
                model.NuevoIndicador = indicador;
                return View("Index", model);
            }

            _context.IndicadoresKPI.Add(indicador);
            await _context.SaveChangesAsync();

            TempData["PetiSuccess"] = "Indicador KPI registrado correctamente.";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearPlanAccion([Bind(Prefix = "NuevoPlanAccion")] PlanAccion planAccion)
        {
            planAccion.Estado = string.IsNullOrWhiteSpace(planAccion.Estado) ? "Pendiente" : planAccion.Estado;

            if (!ModelState.IsValid)
            {
                var model = await BuildViewModelAsync();
                model.NuevoPlanAccion = planAccion;
                return View("Index", model);
            }

            _context.PlanesAccion.Add(planAccion);
            await _context.SaveChangesAsync();

            TempData["PetiSuccess"] = "Plan de acción registrado correctamente.";
            return RedirectToAction(nameof(Index));
        }

        private async Task<PetiSeguimientoViewModel> BuildViewModelAsync()
        {
            var indicadores = await _context.IndicadoresKPI
                .AsNoTracking()
                .OrderByDescending(i => i.PorcentajeCumplimiento)
                .ThenBy(i => i.Nombre)
                .ToListAsync();

            var planesAccion = await _context.PlanesAccion
                .AsNoTracking()
                .OrderByDescending(p => p.FechaInicio)
                .ThenBy(p => p.Actividad)
                .ToListAsync();

            return new PetiSeguimientoViewModel
            {
                Indicadores = indicadores,
                PlanesAccion = planesAccion,
                NuevoIndicador = new IndicadorKPI(),
                NuevoPlanAccion = new PlanAccion { Estado = "Pendiente" }
            };
        }

        private static string CalcularSemaforo(int porcentajeCumplimiento, string? semaforoActual)
        {
            if (!string.IsNullOrWhiteSpace(semaforoActual))
            {
                return semaforoActual.Trim();
            }

            if (porcentajeCumplimiento < 40)
            {
                return "Rojo";
            }

            if (porcentajeCumplimiento < 70)
            {
                return "Amarillo";
            }

            return "Verde";
        }
    }
}