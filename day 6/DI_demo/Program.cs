var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient(typeof(DI_demo.Models.EF.productsWebAPIDBContext));
//builder.Services.AddScoped(typeof(DI_demo.Models.EF.productsWebAPIDBContext));
//builder.Services.AddSingleton(typeof(DI_demo.Models.EF.productsWebAPIDBContext));



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

app.UseAuthorization();

app.MapControllers();

app.Run();
