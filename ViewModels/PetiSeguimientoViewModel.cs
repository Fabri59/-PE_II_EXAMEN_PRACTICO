using Proyecto_Red.Models;

namespace Proyecto_Red.ViewModels
{
    public class PetiSeguimientoViewModel
    {
        public IEnumerable<IndicadorKPI> Indicadores { get; set; } = Enumerable.Empty<IndicadorKPI>();
        public IEnumerable<PlanAccion> PlanesAccion { get; set; } = Enumerable.Empty<PlanAccion>();
        public IndicadorKPI NuevoIndicador { get; set; } = new();
        public PlanAccion NuevoPlanAccion { get; set; } = new();

        public int TotalIndicadores => Indicadores.Count();
        public int TotalPlanesAccion => PlanesAccion.Count();
        public double CumplimientoPromedio => Indicadores.Any()
            ? Math.Round(Indicadores.Average(i => i.PorcentajeCumplimiento), 2)
            : 0;
        public decimal PresupuestoTotal => PlanesAccion.Sum(p => p.Presupuesto ?? 0m);
    }
}