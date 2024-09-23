using BlogSitesi.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogSitesi.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        // var appten geliyor
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                    {
                    context.Database.Migrate();
                    }
                }

            if(!context.Tags.Any())
            {
                context.Tags.AddRange(
                    new Tag { Text = "web proogramlama", Url = "web proogramlama" , Color= TagColors.warning },
                    new Tag { Text = "frontend", Url = "frontend", Color = TagColors.warning },
                    new Tag { Text = "api", Url = "api", Color = TagColors.success },
                    new Tag { Text = "fullstack", Url = "fullstack", Color = TagColors.secondary },
                    new Tag { Text = "php", Url = "php", Color = TagColors.primary }
                );

                context.SaveChanges();
            }

            if(!context.Users.Any())
            {
                context.Users.AddRange(
                    new User {  UserName = "johndoe", Name="john", Email= "john@contoso.com", Password="Sifre1.", Image = "k1.jpg"},
                    new User { UserName = "tomdoe", Name = "tom", Email = "tom@contoso.com", Password = "Sifre2.", Image = "k2.jpg" }
                );

                context.SaveChanges();
            }

            if (!context.Posts.Any())
            {
                context.Posts.AddRange(
                    new Post { 
                        Title = "Asp.net core",
                        Description = "Asp.net core dersleri",
                        Content = "Asp.net core dersleri",
                        Url="aspnet-core",
                        IsActive = true,
                        PublishedOn = DateTime.Now.AddDays(-10),
                        Tags = context.Tags.Take(3).ToList(),
                        Image="1.jpg",
                        UserId = 1,
                        Comments = new List<Comment>
                        {
                            
                        }
                    },
                    new Post
                    {
                        Title = "Php ",
                        Description = "Php core dersleri",
                        Content = "Php  dersleri",
                        Url = "php",
                        IsActive = true,
                        Image = "2.jpg",
                        PublishedOn = DateTime.Now.AddDays(-5),
                        Tags = context.Tags.Take(2).ToList(),
                        UserId = 1
                    },
                    new Post
                    {
                        Title = "Django",
                        Description = "Django dersleri",
                        Content = "Django dersleri",
                        Url = "django",
                        IsActive = true,
                        Image = "3.jpg",
                        PublishedOn = DateTime.Now.AddDays(-15),
                        Tags = context.Tags.Take(4).ToList(),
                        UserId = 2
                    },
                     new Post
                     {
                         Title = "React",
                         Content = "React dersleri",
                         Url = "react",
                         IsActive = true,
                         Image = "1.jpg",
                         PublishedOn = DateTime.Now.AddDays(-70),
                         Tags = context.Tags.Take(4).ToList(),
                         UserId = 2
                     },
                      new Post
                      {
                          Title = "Angular",
                          Content = "Angular dersleri",
                          Url = "angular",
                          IsActive = true,
                          Image = "2.jpg",
                          PublishedOn = DateTime.Now.AddDays(60),
                          Tags = context.Tags.Take(4).ToList(),
                          UserId = 2
                      }
                       
                );

                context.SaveChanges();
            }
        }
        
    }
}
