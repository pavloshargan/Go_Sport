namespace DAL
{
    using DAL.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class DataModel : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<ActivityType> ActivityTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<UnconfirmedUser> UnconfirmedUsers { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public DataModel()
            : base("name=DataModel")
        {
        }

    }
   
}