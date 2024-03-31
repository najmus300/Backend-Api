using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        
        services.AddSingleton<IMongoClient>(new MongoClient("mongodb+srv://uk24:uk4772@cluster0.dihiixg.mongodb.net/"));
        
        services.AddScoped<UserRepository>();
        
        
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
          
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });


    }
}
