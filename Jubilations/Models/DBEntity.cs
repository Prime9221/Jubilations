using Jubilations.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class DBEntity : DbContext
    {
        public DbSet<User> user { get; set; }

        public DbSet<User_Role_Map> user_role_Maps { get; set; }

        public DbSet<User_Role> user_role { get; set; }

        public DbSet<City> city { get; set; }

        public DbSet<Service_Role> service_role { get; set; }

        public DbSet<Contact> contact { get; set; }

        public DbSet<Blog_Comment> blog_Comment { get; set; }

        public DbSet<Services> services { get; set; }

        public DbSet<SuccessStory> successtory { get; set; }

        public DbSet<Category> category { get; set; }

        public DbSet<Blog> blog { get; set; }

        public DbSet<Service_Role_Map> service_role_map { get; set; }

        public DbSet<Vender_Catalog> vender_catalog { get; set; }

        public DbSet<FeedBack> feedBacks { get; set; }

        public DbSet<Aboutus> aboutuss { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}