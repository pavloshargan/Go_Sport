namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class DataModel : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DataModel()
            : base("name=DataModel")
        {
        }
    }
    public class Country
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public Country()
        {
            Cities = new List<City>();
        }
    }
    public class City
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Country Country { get; set; }
    }
    public class Point
    {
        public int Id { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
    public class Route
    {
        public int Id { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public Route()
        {
            Points = new List<Point>();
        }
    }
    public class Activity
    {
        public int Id { get; set; }
        public virtual Route Route { get; set; }
        public virtual ActivityType Type { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public Activity()
        {
            Users = new List<User>();
        }
    }
    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Firstname { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<User> Folowers { get; set; }
        public virtual ICollection<User> Folowing { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public User()
        {
            Activities = new List<Activity>();
            Folowers = new List<User>();
            Folowing = new List<User>();
        }
    }

}