namespace Pronian
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers();

            var app = builder.Build();

            app.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            app.MapControllerRoute("/admin", "{controller=Home}/{action=Admin}");
            //string filePath = @"C:\Users\Amrah\Desktop\Pronia.MVC\Pronian\Views\Home\Admin.cshtml";
            //app.MapGet("/admin", () => Results.Content(filePath, "text/html"));

            app.UseStaticFiles();

            app.Run();
        }
    }
}