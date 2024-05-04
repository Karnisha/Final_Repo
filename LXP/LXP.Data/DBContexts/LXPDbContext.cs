using System;
using System.Collections.Generic;
using LXP.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace LXP.Data.DBContexts;

public partial class LXPDbContext : DbContext
{
    public LXPDbContext()
    {
    }

    public LXPDbContext(DbContextOptions<LXPDbContext> options)
        : base(options)
    {
    }

}