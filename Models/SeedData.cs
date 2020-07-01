using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcWebsite.Data;
using System;
using System.Linq;

namespace MvcWebsite.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcWebsiteContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcWebsiteContext>>()))
            {
                // Look for any movies.
                if (context.Classes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Classes.AddRange(
                    new Classes
                    {
                        UserId = 1,
                        UserEmail = "matthew.p.mitchell@website.com",
                        UserPassword = "HelloKitty",
                        UserIsAdmin = true,
                        ClassName = "Security 101",
                        ClassDescription = "Security for dummies",
                        ClassPrice = 799.50F,
                    }

                );
                context.SaveChanges();
            }
        }
    }
}