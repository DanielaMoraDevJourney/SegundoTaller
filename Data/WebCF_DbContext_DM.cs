using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DanielaMora_PrimerTaller.Models;

    public class WebCF_DbContext_DM : DbContext
    {
        public WebCF_DbContext_DM (DbContextOptions<WebCF_DbContext_DM> options)
            : base(options)
        {
        }

        public DbSet<DanielaMora_PrimerTaller.Models.Burger> Burger { get; set; } = default!;
    }
//cambio