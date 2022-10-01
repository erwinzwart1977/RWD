using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


public class AppContext : DbContext
{
    public string DbPath { get; }
    public AppContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "rewarder.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    public DbSet<Event> Events => Set<Event>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Challenge> Challenges => Set<Challenge>();
}

public class User
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    public DateTime? DayOfBirth { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Email{ get; set; }

    [Required]
    [MaxLength(100)]
    public string? Team { get; set; }

    [Required]
    [MaxLength(20)]
    public string? Phone { get; set; }

    public string? Diets { get; set; }

    public string? Remarks { get; set; }

}

public class Event
{
    public int Id { get; set; }

    public int year { get; set; }

    public ICollection<User>? Users { get; set; }

    public ICollection<Challenge>? Challenges { set; get; }
}

public class Challenge
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    
    [MaxLength(10)]
    public string? Score { get; set; }
}
