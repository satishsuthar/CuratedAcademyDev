using Microsoft.AspNetCore.Mvc;

namespace CuratedAcademy.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(option =>
            {
                option.ReturnHttpNotAcceptable = true;  // pop up error msg, if failed to provide the requested format.
            }).AddXmlDataContractSerializerFormatters(); // supporting the xml formate as well with Json.

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }



            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>{ endpoints.MapControllers();});





            app.Run();
        }
    }
}