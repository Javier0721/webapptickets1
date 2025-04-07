using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;
using WebAPITickets.Models;

public class CrearModel : PageModel
{
    [BindProperty]
    public required Tiquetes Tiquete { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        var cliente = new HttpClient();

        var response = await cliente.PostAsJsonAsync("https://localhost:5001/api/Tiquetes", Tiquete);

        if (response.IsSuccessStatusCode)
        {
            return RedirectToPage("Index");
        }

        return Page();
    }
}
