## Creating an API with minimal API

### New projects are created with the dotnet new command:
    $ dotnet new web -o PizzaStore -f net8.0

### To use Swagger and the Swagger UI in your API, you do two things:
    1. Install a package. To install Swagger, you specify to install a package called Swashbuckle, like this:
        $ dotnet add package Swashbuckle.AspNetCore --version 6.1.4   

    2. Configure it. After the package is installed, you configure it via your code. You add a few different entries:

    Add a namespace. You need this namespace when you later call SwaggerDoc() and provide the header information for your API.
        $ using Microsoft.OpenApi.Models;

### Add data
    1. Add data
        First you need some data. To store and manage data, you'll use an in-memory store.

        Using Visual Studio Code, create a file named `Db.cs` in the project root and give it the following content:
    2. In Program.cs
        using PizzaStore.DB;