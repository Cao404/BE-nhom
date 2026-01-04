using SellerHub.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// CHỈ DÙNG HTTP 5218
builder.WebHost.UseUrls("http://localhost:5218");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("dev", p =>
        p.AllowAnyOrigin()
         .AllowAnyHeader()
         .AllowAnyMethod());
});

// DI cho ADO
builder.Services.AddSingleton<SqlConnectionFactory>();
builder.Services.AddScoped<DanhMucRepository>();
builder.Services.AddScoped<SanPhamRepository>();
builder.Services.AddScoped<KhachHangRepository>();

var app = builder.Build();

// Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SellerHub.Api v1");
    c.RoutePrefix = "swagger"; // ✅ swagger ở /swagger
});

// CORS (đúng thứ tự với routing)
app.UseRouting();
app.UseCors("dev");

app.MapControllers();
app.Run();
