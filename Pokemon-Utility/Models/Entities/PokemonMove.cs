﻿namespace Pokemon;

public partial class PokemonMove
{
    public int? PokemonId { get; set; }

    public int? MoveId { get; set; }

    public string? Method { get; set; }

    public int? Level { get; set; }

    public virtual Move? Move { get; set; }

    public virtual Pokemon? Pokemon { get; set; }
}
