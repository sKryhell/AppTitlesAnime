using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class TitlesGenre
{
    public int Id { get; set; }

    public short IdGenre { get; set; }

    public int IdAnime { get; set; }


    //навигационные свойства

    public virtual AnimeTitle AnimeTitle { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;
}
