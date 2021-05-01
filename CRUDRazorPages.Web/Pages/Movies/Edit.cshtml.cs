using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDRazorPages.Domain.Models.Director.ViewModel;
using CRUDRazorPages.Domain.Models.Movie;
using CRUDRazorPages.Domain.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUDRazorPages.Web.Pages.Movies
{
    public class EditModel : PageModel
    {
        #region DEPENDENCIES
        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;
        #endregion

        #region CONSTRUCTOR
        public EditModel(IMovieService movieService, IDirectorService directorService)
        {
            _movieService = movieService;
            _directorService = directorService;
        }
        #endregion

        #region PROPERTIES
        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Movie Movie { get; set; }

        public IEnumerable<SelectListItem> SelectListDirectors { get; set; }
        #endregion

        #region METHODS
        public async Task OnGet(int id)
        {
            Movie = await _movieService.GetById(id);
            var listDirectorsForDDL = await _directorService.GetForDDL();

            SetDirectorsSelecList(listDirectorsForDDL);
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                await _movieService.Update(Movie);

                Message = "Se modific� correctamente la pelicula";

                return RedirectToPage("Index");
            }
            catch (Exception ex)
            {
                return Redirect("~/Error");
            }
        }
        #endregion

        #region UTILITY METHODS
        private void SetDirectorsSelecList(List<DirectorForDDLViewModel> listDirectorsForDDL)
        {
            var selectListItems = new List<SelectListItem>();

            listDirectorsForDDL.ForEach(d =>
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = d.Name,
                    Value = d.Id.ToString(),
                    Selected = Movie.DirectorId == d.Id
                });
            });

            SelectListDirectors = selectListItems;
        }
        #endregion
    }
}