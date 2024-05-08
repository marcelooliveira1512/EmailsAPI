using Microsoft.OpenApi.Models;
using System.Reflection;

namespace EmailsAPI.Extensions
{
    public static class SwaggerDocExtension
    {
        public static IServiceCollection AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options => options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "EmailsApi - BIT Solution",
                    Description = "API para Envio de Emails usando SMTP do Google",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Bululukos IT Solution",
                        Email = "oliveira.mrc@gmail.com"
                    }
                }));
            
            return services;         
        }

        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "EmailsAPI");
            });

            return app;
        }

    }
}
