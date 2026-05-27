namespace Proyecto_Red.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalPlanes { get; set; }
        public int TotalObjetivos { get; set; }
        public int TotalEstrategias { get; set; }
        public int TotalIndicadoresKpi { get; set; }
        public int TotalPlanesAccion { get; set; }
        public decimal PresupuestoPlanificado { get; set; }
        public double CumplimientoKpiPromedio { get; set; }
        public double PorcentajeAvance { get; set; }
    }
}
