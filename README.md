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

    3.
### Summary
    In this module, you learned how to create an API by using the minimal API template for .NET 8.

    Minimal API enables you to create an API with only a few lines of code. It has all the major features that you're used to like dependency injection, talking to databases, and route management. A minimal API differs from a controller-based API because you explicitly specify the routes you need instead of relying on a convention-based approach like with a controller-based API.

    There are many benefits to this approach:

    1/ Easier to get started: With four lines of code, you can have an API up and running quickly.
    2/ Progressive enhancement: Add features when you need them. Until then, your program code stays small.
    3/ .NET 8 latest features: Use all the latest features from .NET 8 like top-level statements and records.
    
    As part of this module, you learned how to add Swagger. You also added routes to create, read, update, and delete a resource.