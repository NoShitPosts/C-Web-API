using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Owin;
using NoShitPosts.Models;
using Owin;

[assembly: OwinStartup(typeof(NoShitPosts.Startup))]

namespace NoShitPosts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
//            Database.SetInitializer(new DropCreateDatabaseAlways<PersonalUserScoreContext>());
        }
    }
}
