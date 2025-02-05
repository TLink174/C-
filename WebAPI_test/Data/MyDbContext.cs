﻿using Microsoft.EntityFrameworkCore;

namespace WebAPI_test.Data
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        #region DbSet
        public DbSet<HangHoa> HangHoas { get; set; }

        public DbSet<Loai> Loais { get; set; }
        #endregion
    }
}
