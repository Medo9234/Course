using Demo1.BLL;

namespace Demo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the (Dependency Injection container).
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IStudent,StudentBLL>();

            var app = builder.Build();

            /*
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Welcome From my app");
            });
            */

            
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseExceptionHandler();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=students}/{action=Index}/{id?}");
           
            app.Run();
        }
    }
}