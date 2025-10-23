using System;
using System.Collections.Generic;

namespace EntityFrameWork.Models;

public partial class Wallet
{
    public int Id { get; set; }

    public string Holder { get; set; } = null!;

    public decimal Balance { get; set; }
}
