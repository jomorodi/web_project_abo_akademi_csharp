using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using backend.Data;
using System;
using System.Linq;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using backend.models;

namespace backend.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new backendContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<backendContext>>()))
        {
            // Look for any movies.
            if (context.User.Any() && context.Item.Any())
            {
                return;   // DB has been seeded
            }
            context.User.AddRange(
                new User
                {
                    UserName = "Alek.Osinski45" ,
                    Password ="F2EAFyTqHbR4Kt6" ,
                    Email = "Aaliyah23@hotmail.com" ,
                    FirstName = "Hayley" ,
                    LastName =  "Reichel-Watsica" ,
                    DateCreated = DateTime.Now ,
                    DateModified = DateTime.Now ,
                    IsLoggedIn = true
                },
                new User
                {
                    UserName = "Edythe_Conroy83" ,
                    Password = "bRtsuoo1tYIHS3b",
                    Email = "Trey_Satterfield80@hotmail.com" ,

                    FirstName = "Keegan",

                    LastName = "Connelly" ,

                    DateCreated = DateTime.Now ,

                    DateModified = DateTime.Now ,

                    IsLoggedIn = false ,
                },
                new User
                {
                    UserName = "Kiley_Corkery26" ,
                    Password = "Kk6KMwvRax5wOXV",
                    Email = "Neoma.Yundt28@yahoo.com",

                    FirstName = "Harley",

                    LastName = "Barton",

                    DateCreated = DateTime.Now ,

                    DateModified = DateTime.Now  ,

                    IsLoggedIn = true ,
                },
                new User
                {
                    UserName = "Kaley.OHara34" ,
                    Password = "TiSQlzXtvTKumDF" ,
                    Email = "Kade.Wiegand@hotmail.com" ,

                    FirstName = "Maximus",

                    LastName = "Brakus" ,

                    DateCreated = DateTime.Now ,

                    DateModified = DateTime.Now  ,

                    IsLoggedIn = false ,
                }
            );
            context.SaveChanges();
            context.Item.AddRange(
                new Item
                {
                    Name = "Nokia 3310",
                    Description = "Used phone in good condition",

                    Price = 20.30M ,

                    SellerID = 1 ,

                    IsSold = false ,
                   
                },

                new Item
                {
                    Name = "Lenovo thinkpad",
                    Description = "Used laptop in good condition",

                    Price = 160.30M,

                    SellerID = 1 ,

                    IsSold = false ,
                   
                }

            );

            context.SaveChanges();
        }
    }
}