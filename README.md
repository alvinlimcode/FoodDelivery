# Food Delivery Web App
A sample food delivery web app is developed using ASP.NET Core, bootstrap, jQuery, vue.js, and HTML localStorage. This project demo how to structure the solutions into different projects also.

## Getting Started
The homepage demo loading the foods listing by calling ajax Web API in vue.js through the C# backend code. The data is stored in SQL Server and access using Entity Framework with Lambda expressions. 

The frontend UI uses bootstrap3 CSS, vue.js and jQuery. The vue.js is vesatile, flexible and very good at controlling the UI logic with minimal code compare to jQuery.

When the button "Add to Cart" is clicked, the food will be added to the shopping cart which is store in HTML localStorage of the browser. Storing shopping cart in HTML localStorage is better than cookies. When the user view the shopping cart again, the vue.js code will load the data from HTML localStorage again. 

For more information about HTML localStorage https://www.w3schools.com/HTML/html5_webstorage.asp

## Architecture
**FoodDelivery** - The ASP.NET Core MVC project 

**FoodDelivery.Data** - For all the entities and view models

**FoodDelivery.Repository** - For the generic IRepository class and DBContext

**FoodDelivery.Service** - For all the business logic, interfaces and data access operations

**FoodDelivery.Core** - For all the constants, enumerations, extension methods and others

## Prerequisites
.NET Core 2.1, Visual Studio 2017, SQL Server, Vue.js

## Installing
Change the database connection string in appsettings.Development.json to your local database connection.

After that, open "Package Manager Console" in Visual Studio 2017 and type the following command to run the latest migration with default data.

```
update-database
```

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/alvinlimcode/FoodDelivery/blob/master/LICENSE) file for details
