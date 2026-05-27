# Examen II UNIDAD - PETI

**Proyecto:** Sistema de Gestión de Plan Estratégico de TI  
**Tecnología base:** ASP.NET Core MVC (.NET 8)  
**Fecha del informe:** 27 de mayo de 2026  
**Estado general:** Base funcional con ampliación PETI operativa

---

## 1. Resumen ejecutivo

El Sistema PETI es una plataforma web orientada a la formulación, administración y seguimiento de un Plan Estratégico de Tecnologías de Información. La solución integra autenticación, gestión de empresas, consolidación del plan estratégico y una capa de seguimiento que permite controlar indicadores y planes de acción.

Durante este avance se incorporaron dos mejoras relevantes para pasar de una base documental a una herramienta de control operativo: el seguimiento PETI con KPIs y la gestión de planes de acción con presupuesto y estado. Con ello, el sistema deja de limitarse a registrar información y comienza a soportar la toma de decisiones de seguimiento.

---

## 2. Mejoras principales incorporadas

Las dos mejoras más importantes añadidas al sistema durante este avance fueron las siguientes:

1. **Seguimiento PETI con KPIs operativos:** se creó un módulo para registrar y consultar indicadores de cumplimiento, con porcentaje, meta y semáforo de estado.
2. **Planes de acción con presupuesto y control de estado:** se habilitó el registro de actividades, responsables, fechas y presupuesto planificado para dar seguimiento real a la ejecución del PETI.

Estas mejoras convierten el sistema en una herramienta más completa, porque ya no solo documenta el plan, sino que también permite medir su avance y organizar su ejecución.

---

## 3. Objetivo del informe

Presentar el estado actual del sistema, describir las mejoras implementadas y dejar evidencia textual de que el proyecto ya cuenta con una funcionalidad para el control del avance estratégico.

---

## 4. Alcance del sistema

El sistema cubre actualmente los siguientes componentes:

- Autenticación con roles para Administrador y Analista.
- Gestión de empresas mediante CRUD.
- Módulo de Plan Estratégico TI con secciones de presentación, estrategia, análisis y resumen ejecutivo.
- Dashboard principal con métricas de avance.
- Módulo de Seguimiento PETI para KPI y planes de acción.

---

## 5. Mejoras implementadas

### 5.1 Seguimiento PETI con KPIs operativos

Se habilitó un nuevo módulo de seguimiento para registrar, consultar y visualizar indicadores KPI. Este módulo permite registrar nombre, descripción, fórmula, meta, resultado actual, porcentaje de cumplimiento y semáforo de estado. Además, se centraliza en una vista única para facilitar el control del avance.

### 5.2 Planes de acción con presupuesto y estado

Se incorporó la posibilidad de registrar planes de acción asociados al avance PETI. Cada plan admite actividad, responsable, presupuesto, fechas de ejecución, observaciones y estado. Esta mejora permite trasladar la estrategia a acciones concretas y medibles.

---

## 6. Funcionamiento general

El flujo operativo del sistema se resume así:

1. El usuario inicia sesión con credenciales válidas.
2. Ingresa al dashboard principal para revisar métricas globales.
3. Accede al Plan Estratégico TI para consultar las secciones del plan.
4. Entra al módulo de Seguimiento PETI para registrar KPI y planes de acción.
5. Visualiza el progreso y el presupuesto planificado desde el panel de control.

---

## 7. Evidencia de integración funcional

El dashboard fue ampliado para mostrar el total de KPI, el total de planes de acción y el presupuesto planificado. La navegación principal también incluye acceso directo al módulo PETI, lo que confirma que la mejora no quedó solo en documentación sino que se integró a la interfaz del sistema.

---

## 8. Validación técnica

Se ejecutó la compilación del proyecto y el resultado fue satisfactorio. El sistema compila correctamente y solo conserva advertencias previas de nullability y un using duplicado ya existente en la base del proyecto.

---

## 9. Tecnologías utilizadas

| Tecnología | Uso principal |
|---|---|
| ASP.NET Core MVC | Aplicación web |
| Entity Framework Core | Acceso a datos |
| SQLite | Base de datos local |
| Bootstrap 5 | Interfaz responsiva |
| Chart.js | Visualización gráfica |
| DataTables | Tablas dinámicas |
| Font Awesome | Iconografía |

---

## 10. Estado actual del proyecto

El sistema se encuentra funcional en su base principal y con una extensión PETI ya operativa. En esta etapa, el avance más importante es que el proyecto ya cuenta con seguimiento de ejecución, no solo con registro documental del plan.

---

## 11. Próximos módulos sugeridos

- Presupuesto con cálculos automáticos.
- Cronograma visual tipo Gantt.
- Reportes exportables en PDF o Excel.
- Consolidación de matrices estratégicas adicionales.

---

## 12. Conclusión

El Sistema PETI ya dispone de una base sólida para gestión estratégica y de una capa de seguimiento funcional que le da valor operativo. Las dos mejoras implementadas fortalecen el control del avance del plan y preparan el sistema para futuras ampliaciones orientadas a presupuesto, cronograma y reporte ejecutivo.
