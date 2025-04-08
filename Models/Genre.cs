using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string GenseName { get; set; } = null!;

    //навигационные свойства

    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();
}
