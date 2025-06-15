using Microsoft.AspNetCore.Mvc;
using parcial.Models;
using System.Collections.Generic;


namespace parcial.Controllers.Controllers // Cambia 'TuProyectoMVC' por el nombre de tu namespace real
{
    public class ClientesController : Controller
    {
        // GET: /Clientes/Lista
        // Esta es la "Acción Lista que devuelva una vista"
        public IActionResult Lista()
        {
            // Simulación de obtención de datos:
            // En una aplicación real, estos datos vendrían de una base de datos,
            // un servicio, un repositorio, etc.
            var clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Ana García", Email = "ana.garcia@dominio.com" },
                new Cliente { Id = 2, Nombre = "Juan Pérez", Email = "juan.perez@dominio.com" },
                new Cliente { Id = 3, Nombre = "María López", Email = "maria.lopez@dominio.com" },
                new Cliente { Id = 4, Nombre = "Pedro Rodríguez", Email = "pedro.rodriguez@dominio.com" }
            };

            // Devuelve la vista y le pasa la lista de clientes como modelo.
            // Esto hace que la vista sea 'fuertemente tipada'.
            return View(clientes);
        }

        // Puedes añadir más acciones aquí (Ej: Detalles, Crear, Editar, Eliminar)
        // public IActionResult Detalles(int id) { ... }
        // public IActionResult Crear() { ... }
        // [HttpPost]
        // public IActionResult Crear(Cliente nuevoCliente) { ... }
    }
}