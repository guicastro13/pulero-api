namespace pulero_back;
class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args);
    }

    public static void CreateHostBuilder(string[] args) 
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<Repository.IUserRepository, Repository.InMemory.InMemoryUserRepository>();
        builder.Services.AddScoped<Services.Create>(); 
        builder.Services.AddScoped<Services.GetUsers>(); 


        var app = builder.Build();

        app.UseHttpsRedirection();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}