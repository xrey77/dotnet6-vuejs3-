var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSpaStaticFiles(options => { options.RootPath = "clientapp/dist"; });
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();        

    // app.UseSwagger();
    // app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSpaStaticFiles();
app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.UseSpa(spa =>
     {
         if (app.Environment.IsDevelopment())
             spa.Options.SourcePath = "clientapp/";
         else
             spa.Options.SourcePath = "dist";
     });

app.Run();
