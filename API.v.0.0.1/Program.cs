//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
using NoteApi.Models;
using NoteApi.Controllers;
using NoteApi.Services;

var builder = WebApplication.CreateBuilder(args);

// اضافه کردن کنترلرها
builder.Services.AddControllers();

// ثبت سرویس ذخیره‌سازی به صورت Singleton
builder.Services.AddSingleton<FileNoteStore>();

var app = builder.Build();


app.UseRouting();
app.UseAuthorization();
app.UseRouting();
app.MapControllers();

app.Run();



//app.UsePathBase("/api/note");