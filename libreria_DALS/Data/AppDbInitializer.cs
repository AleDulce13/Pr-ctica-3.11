using libreria_DALS.Data.Models;
using libreria_DALS.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading;

namespace libreria_DALS.Data
{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a nuestr Db
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Books()
                    {
                        Titulo = "1st Book Title",
                        Descripccion = "1st Book Description",
                        IsRead = true,
                        DataRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,

                    },
                      new Books()
                      {
                          Titulo = "2nd Book Title",
                          Descripccion = "2nd Book Description",
                          IsRead = true,
                          Genero = "Biography",
                          CoverUrl = "https...",
                          DateAdded = DateTime.Now,

                      });
                    context.SaveChanges();
                }
            }
        }

    }

}
