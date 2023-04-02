using Microsoft.Identity.Client.Extensions.Msal;
using MySql.Data.MySqlClient;
using projekt.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

MySqlConnection conn = new MySqlConnection("Data Source=localhost;Database=projekt_bazy_danych;Username=root;password=");
conn.Open();
MySqlCommand cmd = new MySqlCommand("Select idzawodnicy,imie_zawodnika,nazwisko_zawodnika,kraj_pochodzenia From zawodnicy", conn);
MySqlDataReader myreader = cmd.ExecuteReader();
while (myreader.Read())
{
    Console.WriteLine(myreader[0].ToString() + " " + myreader[1].ToString() + "\n");
}

using var context = new ApplicationDbContext();

if (context.Database.CanConnect())
{
    Console.WriteLine("Connected to database");
}
else
{
    Console.WriteLine("Unable to connect to database");
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();


app.MapRazorPages();

app.Run();
