using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using VVCyberAware.Components;
using VVCyberAware.Components.Account;
using VVCyberAware.Data;
using VVCyberAware.Shared.Models.Services.CategoryService;
using VVCyberAware.Shared.Models.Services.QuestionService;
using VVCyberAware.Shared.Models.Services.SegmentService;
using VVCyberAware.Shared.Models.Services.SubCategoryService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
builder.Services.AddScoped<CategoryService>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});


builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<ISegmentService, SegmentService>();
builder.Services.AddScoped<ISubCService, SubCService>();
builder.Services.AddScoped<UserManager<ApplicationUser>>();
builder.Services.AddBlazoredLocalStorage();

//using (ServiceProvider sp = builder.Services.BuildServiceProvider())
//{
//    var context = sp.GetRequiredService<ApplicationDbContext>();
//    var roleManager = sp.GetRequiredService<RoleManager<IdentityRole>>();
//    var signInManager = sp.GetRequiredService<SignInManager<ApplicationUser>>();

//	// Skapa en vanlig user
//	ApplicationUser newUser = new()
//	{
//		UserName = "admin",
//	};

//	ApplicationUser newUser1 = new()
//	{
//		UserName = "user"
//	};

//	signInManager.UserManager.CreateAsync(newUser1, "Password1234!").GetAwaiter().GetResult();


//    var user = signInManager.UserManager.FindByNameAsync(newUser.UserName).GetAwaiter().GetResult();


//	if (user == null)
//	{
//		signInManager.UserManager.CreateAsync(newUser, "Password1234!").GetAwaiter().GetResult();

//        //Checka adminrollen

//        if (!roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
//        {
//            IdentityRole adminRole = new()
//            {
//                Name = "Admin"
//            };

//            roleManager.CreateAsync(adminRole).GetAwaiter().GetResult();
//        }

//    }
//    // Tilldela adminrollen till den usern
//    signInManager.UserManager.AddToRoleAsync(newUser, "Admin").GetAwaiter().GetResult();

//    context.SaveChangesAsync();
//}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
