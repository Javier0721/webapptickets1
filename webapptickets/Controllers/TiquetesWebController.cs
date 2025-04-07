using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using WebAPITickets.Models;

namespace WebAPITickets.Controllers
{
    public class TiquetesWebController : Controller
    {
        private readonly HttpClient _http;

        public TiquetesWebController()
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri("https://localhost:7122/api/");
        }

        public async Task<IActionResult> Index(string estado)
        {
            string endpoint = string.IsNullOrEmpty(estado) ? "Tiquetes" : $"Tiquetes/Estado/{estado}";
            var respuesta = await _http.GetFromJsonAsync<List<Tiquetes>>(endpoint);
            return View(respuesta);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Tiquetes tiquete)
        {
            tiquete.ti_adicionado_por = "sistema";
            tiquete.ti_estado = "Creado";
            tiquete.ti_fecha_adicion = DateTime.Now;

            var respuesta = await _http.PostAsJsonAsync("Tiquetes", tiquete);
            if (respuesta.IsSuccessStatusCode)
                return RedirectToAction("Index");

            ViewBag.Error = "Error al guardar el ticket.";
            return View(tiquete);
        }
    }
}
