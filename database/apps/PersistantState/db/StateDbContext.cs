using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Database.Db
{

    // public class StateDbContextFactiry : IDesignTimeDbContextFactory<StateDbContext>
    // {
    //     // public AppDbContext CreateDbContext(string[] args)
    //     // {
    //     //     var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
    //     //     optionsBuilder.UseMySql("Server=localhost;DataBase.....");

    //     //     return new AppDbContext(optionsBuilder.Options);
    //     // }

    //     StateDbContext IDesignTimeDbContextFactory<StateDbContext>.CreateDbContext(string[] args)
    //     {
    //         Console.WriteLine($"HERE WE ARE! {args.Length}");
    //         foreach (var arg in args)
    //             Console.WriteLine(arg);

    //         var optionsBuilder = new DbContextOptionsBuilder<StateDbContext>();
    //         optionsBuilder.UseMySql("Server=192.168.1.7;port=3306;database=test;user=test;password=test;",
    //             ServerVersion.FromString("10.4.13-MariaDB"));

    //         return new StateDbContext(optionsBuilder.Options);
    //     }
    // }

    public class StateDbContext : DbContext
    {
        private string? _connectionString = "";
        public StateDbContext(string connectionString) : base()
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString)); //"10.4.13-MariaDB"

        public DbSet<State> States => Set<State>();

    }

}