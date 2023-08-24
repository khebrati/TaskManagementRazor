namespace TaskManagement;
public class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
    }
    public static void Configure(IHostEnvironment env, IApplicationBuilder app)
    {
        if (env.IsProduction())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }
        else
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseStatusCodePagesWithReExecute("/{0}");
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapRazorPages());
        app.UseWelcomePage();
    }
}