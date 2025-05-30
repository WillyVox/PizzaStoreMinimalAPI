using Microsoft.OpenApi.Models;
using PizzaStore.DB;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Minimal API", Description = "Keep track of your tasks", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
// Using: http://localhost:5112/swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Using: http://localhost:5112/
app.MapGet("/", () => "Hello World!");
// Using http://localhost:5112/pizzas/1
app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));
// Using: http://localhost:5112/pizzas
app.MapGet("/pizzas", () => PizzaDB.GetPizzas());
// Using curl -X POST http://localhost:5112/pizzas -H "Content-Type: application/json" -d '{"name":"Best Pizza Ever","id": 4 }'
app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));
// Using: $ curl -X PUT http://localhost:5112/pizzas -H "Content-Type: application/json" -d '{"id":4,"name":"So full now"}'
app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));
// Using: $ curl -X DELETE http://localhost:5112/pizzas/4
app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));

app.Run();
