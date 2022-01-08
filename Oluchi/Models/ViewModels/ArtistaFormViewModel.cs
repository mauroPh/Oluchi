using System.Collections.Generic;


namespace Oluchi.Models.ViewModels
{
    public class ArtistaFormViewModel
    {
        public Artista Artista { get; set; }

        public ICollection<Categoria> Categorias { get; set; }

    }
}
