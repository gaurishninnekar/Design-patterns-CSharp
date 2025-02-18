using System;
using PlatformService.Models;

namespace PlatformService.Data;

public static class PrepDb
{
    public static void PrePopulation(IApplicationBuilder app)
    {
        using (var servicesScope = app.ApplicationServices.CreateScope())
        {
            SeedData(servicesScope.ServiceProvider.GetService<AppDbContext>());
        }


    }

    public static void SeedData(AppDbContext context)
    {
        if (!context.Platforms.Any())
        {
            Console.WriteLine("---> seeing the data");
            context.Platforms.AddRange(
                new Platform()
                {
                    Name = "Java",
                    Publisher = "Oracle",
                    Cost = "Free"
                },
                new Platform()
                {
                    Name = "Node.js",
                    Publisher = "OpenJS Foundation",
                    Cost = "Free"
                },
                new Platform()
                {
                    Name = "Python",
                    Publisher = "Python Software Foundation",
                    Cost = "Free"
                },
                new Platform()
                {
                    Name = "Ruby on Rails",
                    Publisher = "Rails Core Team",
                    Cost = "Free"
                },
                new Platform()
                {
                    Name = "Spring Boot",
                    Publisher = "VMware",
                    Cost = "Free"
                }
            );

            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("---> we already have data");
        }
    }
}
