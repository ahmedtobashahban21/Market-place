﻿using System;
using System.Collections.Generic;

namespace SouqMarket.Models;

public partial class Cart
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantaty { get; set; }

    public virtual Product? Product { get; set; }
}
