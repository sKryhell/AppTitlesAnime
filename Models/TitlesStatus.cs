using System;
using System.Collections.Generic;

namespace AppTitlesAnime.Models;

public partial class TitlesStatus
{
    public int Id { get; set; }

    public short IdStatus { get; set; }

    public int IdAnime { get; set; }

    public DateOnly? DateStatus { get; set; }


    //навигационные свойства

    public virtual AnimeTitle AnimeTitle { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
