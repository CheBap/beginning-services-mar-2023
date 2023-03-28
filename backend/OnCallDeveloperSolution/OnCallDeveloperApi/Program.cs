using OnCallDeveloperApi.Models;
using OnCallDeveloperApi.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);



        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddSingleton<ISystemTime, SystemTime>();
        builder.Services.AddScoped<IProvideSupportSchedule, SupportSchedule>();


        var app = builder.Build();



        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }



        app.MapGet("/oncalldeveloper", (IProvideSupportSchedule supportSchedule) =>
        {
            OnCallDeveloperModel response;
            if (supportSchedule.InternalSupportAvailable)
            {
                response = new OnCallDeveloperModel
                {

                };

            }
            var response = new OnCallDeveloperModel
            {
                Name = "Bob Smith",
                Phone = "888-8888",
                Email = "bob@company.com"
            };
            return Results.Ok(response);
        });



        app.Run();




    }
}