using Catalogo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Catalogo.Controllers
{
    public class CatalogoController : Controller
    {
        // Lista estática para simular una base de datos en memoria
        private static List<Item> _items = new()
        {
            new Item
            {
                Id = 1,
                Titulo = "Devil May Cry",
                Genero = "Hack and Slash",
                Ano = 2001,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego que trata de un cazador..."
            },
            new Item
            {
                Id = 2,
                Titulo = "Castlevania: Symphony of the Night",
                Genero = "Metroidvania",
                Ano = 1997,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego que trata de un cazador..."
            },
            new Item
            {
                Id = 3,
                Titulo = "NieR: Automata",
                Genero = "Action RPG",
                Ano = 2017,
                Consola = "PlayStation 4",
                Descripcion = "Gloria a la humanidad."
            },
            new Item
            {
                Id = 4,
                Titulo = "FURRY DAYS",
                Genero = "no quieres saber ",
                Ano = 2017,
                Consola = "pc",
                Descripcion = "es como dias de furrys."
            },
            new Item
            {
                Id = 5,
                Titulo = "halo",
                Genero = "shooter",
                Ano = 2001,
                Consola = "xbox",
                Descripcion = "videojuego de disparos en primera persona."
            },
        };

        // Lista — con filtro opcional por género
        public IActionResult Index(string? genero)
        {
            var resultado = string.IsNullOrEmpty(genero)
                ? _items
                : _items.Where(i => i.Genero == genero).ToList();

            ViewBag.Generos = _items.Select(i => i.Genero).Distinct().ToList();
            ViewBag.GeneroActual = genero;

            return View(resultado);
        }

        // Detalle de un videojuego por ID
        public IActionResult Detalle(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            return item == null ? NotFound() : View(item);
        }

        // Formulario — GET: Muestra la página para agregar
        public IActionResult Agregar()
        {
            return View();
        }

        // Formulario — POST: Procesa el nuevo videojuego
        [HttpPost]
        public IActionResult Agregar(Item item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
            return RedirectToAction("Index");
        }
    }
}