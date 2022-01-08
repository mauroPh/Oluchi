using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oluchi.Models;
using Oluchi.Models.ViewModels;
using Oluchi.Services;
using Oluchi.Services.Exceptions;


namespace Oluchi.Controllers
{
    public class ArtistasController : Controller
    {

        private readonly ArtistaService _artistaService;
        private readonly CategoriaService _categoriaService;

        public ArtistasController(ArtistaService artistaService, CategoriaService categoriaService)
        {
            _artistaService = artistaService;
            _categoriaService = categoriaService;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _artistaService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var categorias = await _categoriaService.FindAllAsync();
            var viewModel = new ArtistaFormViewModel { Categorias =  categorias };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Artista artista)
        {
            if (!ModelState.IsValid)
            {
                var categorias = await _categoriaService.FindAllAsync();
                var viewModel = new ArtistaFormViewModel { Artista = artista, Categorias = categorias };
                return View(viewModel);
            }
            await _artistaService.InsertAsync(artista);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _artistaService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _artistaService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _artistaService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "CPF inválido" });
            }

            var obj = await _artistaService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Artista não encontrado" });
            }



            List<Categoria> categorias = await _categoriaService.FindAllAsync();
            ArtistaFormViewModel viewModel = new ArtistaFormViewModel { Artista = obj, Categorias = categorias};
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Artista artista)
        {
            if (!ModelState.IsValid)
            {
                var categorias = await _categoriaService.FindAllAsync();
                var viewModel = new ArtistaFormViewModel { Artista = artista, Categorias = categorias };
                return View(viewModel);
            }
            if (id != artista.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "CPF inválido" });
            }
            try
            {
                await _artistaService.UpdateAsync(artista);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }




    }
}
