﻿using Microsoft.EntityFrameworkCore;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}