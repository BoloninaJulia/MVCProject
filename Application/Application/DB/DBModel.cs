namespace Application.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    using System.Linq;

    public class DBModel : DbContext
    {
       
        public DBModel()
            : base("name=DBModel")
        {
            Database.SetInitializer(new Initializer());
        }



        //public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Company> Company { get; set; }
    }


}