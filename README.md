
<h1 align="center">AspDotNet</h1>
<h2 align="center">My Web App</h2><br>
<h3 align="center">Unit 1</h3>


# Introduction

In this module, you'll create a cross-platform ASP.NET Core Razor Pages web app with .NET and C#.

This module uses the .NET CLI and Visual Studio Code (Windows, Linux, and macOS) to demonstrate ASP.NET Core Razor Pages development. After completing this module, you can apply its concepts using a development environment like Visual Studio (Windows), Visual Studio for Mac (macOS), or Visual Studio Code.

This module uses the .NET 6.0 SDK. Before beginning the module, ensure that you have .NET 6.0 installed by running the following command in your preferred terminal:
```
dotnet --list-sdks
```
Output similar to the following appears:
```
3.1.100 [C:\program files\dotnet\sdk]
5.0.100 [C:\program files\dotnet\sdk]
6.0.100 [C:\program files\dotnet\sdk]
```

Ensure that a version starting with 6 is listed. If none is listed or the command is not found, [install the most recent .NET 6.0 SDK.](https://dotnet.microsoft.com/download)>> 

# What will you be doing?

In this module, you will:

# Understand when and why to use Razor Pages for your ASP.NET Core app.
Use the .NET CLI to create a Razor Pages app.
Create a form that supports the app's product data management requirements.
Run and test the web app.
At the end of this module, there are links to content providing deeper dives for each feature area introduced.

# Prerequisites
Local installations of the .NET SDK and Visual Studio Code.
C# extension for Visual Studio Code.
Experience with using the command line.
Experience writing C# at the beginner level.
Ability to write HTML at an intermediate level.

# Example Scenario
Suppose you're an employee of a pizza company named Contoso Pizza. Your manager has asked you to develop a pizza inventory management page as a prerequisite for the company's internal admin website. The app should be built in such a way that the view and data model concerns are separated.


<h3 align="center">Unit 2</h3>

# Understand when and why to use Razor Pages

In this unit, you'll learn when and why to use Razor Pages for your ASP.NET Core app.

## What Razor Pages are and the benefit they provide
Razor Pages is a server-side, page-centric programming model for building web UI with ASP.NET Core. Razor Pages provide the following benefits:

Makes it easy to get started building dynamic web apps when all you need is to define UI logic using a combination of HTML, CSS, and C#.
Encourages organization of files by feature, which eases maintenance of your app.
Can be broadly described as an HTML file in which you work with markup as you're used to. You also have the advantage of adding server-side C# code by using Razor syntax.
Razor Pages use a markup language called Razor for embedding server-based code into webpages. Razor syntax is a combination of HTML and C# where the C# code defines the dynamic rendering logic for the page. In a webpage that uses the Razor syntax, there can be two kinds of content: client content and server code:

## Client content: 

Contains what you're used to in webpages: HTML markup (elements), style information such as CSS, maybe some client script such as JavaScript, and plain text.
Server code: Razor enables you to add server code to your client content. If there's server code in the page, the server runs that code first, before it sends the page to the browser. By running on the server, the code can perform more complex tasks than using client content alone. For example, securely accessing databases. Most importantly, server code can dynamically create client content — it can generate HTML markup or other content and send it to the browser along with any static HTML that the page might contain. From the browser's perspective, client content generated on the server is no different than any other client content.

## Separation of concerns in the PageModel
Razor Pages enforces separation of concerns for page-related data properties and logic operations in a C# PageModel class. A model object typically defines data properties and encapsulates any logic or operations related to those data properties. More specifically, a PageModel:

- Encapsulates the data properties and logic operations scoped just to its Razor page.
- Defines page handlers for HTTP requests sent to the page and for the data used to render the page.

# When to use Razor Pages
Use Razor Pages in your ASP.NET Core app when you:

- Want to generate dynamic web UI from your ASP.NET Core app.
- Prefer a page-focused approach to developing web apps, where the page markup and PageModel are in close proximity.
- Want your page-focused ASP.NET Core app to use partial views — mechanisms for reducing duplication of common markup across the site.

Razor Pages allow you to keep your ASP.NET Core pages organized in a simpler way:

- All view (page) specific logic and page properties defined in the Razor page's (PageModel) can be kept together in their own namespace and directory.
- Groups of related pages can be kept in their own namespace and directory.
 
 ### Note
```
ASP.NET Core also supports the MVC pattern for building web apps. The Model defines the fundamental behaviors and data for the app and its components.
The View uses HTML and Razor syntax to provide the UI. The Controller is a class that receives HTTP requests and handles user actions.

Use ASP.NET Core MVC when you prefer to build web apps with a clear separation between the Model, View, and Controller.

Razor Pages is built on the same infrastructure as ASP.NET Core MVC. Both Razor Pages and MVC can be used within the same ASP.NET Core app.
ASP.NET Core MVC is outside of the scope for this module.

```

# Check your knowledge
1. Which following statement is true for Razor Pages?

- [ ] Use Razor Pages for an ASP.NET Core app that isn't focused on generating HTML, such as a web API.

- [ ] Razor Pages can't coexist in an ASP.NET Core MVC app.

- [X] A productivity advantage of Razor Pages is that it keeps together what tends to change together for views in your app.
**Reason:**
  **Use Razor Pages to keep ASP.NET Core pages organized in a simpler way. All view (page) specific logic and page properties (view model) can be kept in the same proximity.**


<h3 align="center">Unit 3</h3>

Exercise - Create new ASP.NET Core app
Completed
100 XP
10 minutes
Imagine you're an employee of a pizza company named Contoso Pizza. Your manager has asked you to develop an internal pizza inventory management site. The site has to support adding, viewing, modifying, and removing types of pizza.

The .NET CLI is the simplest way to create an ASP.NET Core web app. The CLI is pre-installed when you installed the .NET SDK. In this unit, you'll use the .NET CLI to create an ASP.NET Core web app locally. You'll also gain an understanding of the resulting project.

Create a web app project
To set up a .NET project to work with a web app, you'll use Visual Studio Code. Visual Studio Code includes an integrated terminal, which makes creating a new project easy. If you don't want to use another code editor, you can run the commands in this module in a terminal.

In Visual Studio Code, select File > Open Folder.

Create a new folder named RazorPagesPizza in the location of your choice, and then click Select Folder. If you are shown a prompt asking Do you trust the authors of the files in this folder? select the Yes button.

Open the integrated terminal from Visual Studio Code by selecting View > Terminal from the main menu.

In the terminal window, copy and paste the following command.

.NET CLI

Copy
dotnet new webapp -f net6.0
This command creates the files for a basic web app project, along with a C# project file named RazorPagesPizza.csproj.

You may receive a prompt from Visual Studio Code to add assets to debug the project. Click Yes on the dialog.

The command uses an ASP.NET Core project template to scaffold a C#-based web app project. A RazorPagesPizza directory is created, which contains an ASP.NET Core project running on .NET. The project name matches the RazorPagesPizza directory name.

You should now have access to these files.

Bash

Copy
-| obj
-| Pages
   - | Shared
   - | _ViewImports.cshtml
   - | _ViewStart.cshtml
   - | Error.cshtml
   - | Error.cshtml.cs
   - | Index.cshtml
   - | Index.cshtml.cs
   - | Privacy.cshtml
   - | Privacy.cshtml.cs
-| Properties
-| wwwroot
-| appsettings.Development.json
-| appsettings.json
-| Program.cs
-| RazorPagesPizza.csproj
Run the Razor Pages project and explore its UI
Compile and run the project
Run the following .NET Core CLI command in the command shell:

.NET CLI

Copy
dotnet run
The preceding command:

Locates the project file at the current directory.
Retrieves and installs any required project dependencies for this project.
Compiles the project code.
Hosts the web app with ASP.NET Core's Kestrel web server at both an HTTP and HTTPS endpoint.
A port from 5000-5300 will be selected for HTTP, and from 7000-7300 for HTTPS, at the time the project is created. As always, the ports used during development can be easily changed by editing the project’s launchSettings.json file. This module uses the secure localhost URL beginning with https.

A variation of the following output displays to indicate your app is running:

Console

Copy
      Now listening on: https://localhost:7192
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5211
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
  Content root path: /home/<user>/aspnet-learn/src/RazorPagesPizza
If running this app on your own machine, you could direct a browser to the HTTPS link displayed in the output (in the above case, https://localhost:7192) to view the resulting page.

Tour the app
Note the HTTP URL displayed in the terminal output, e.g. https://localhost:7192.

Open the app in your browser by browsing to the HTTPS URL.

Navigate to the Privacy page by clicking on the link in the navigation bar at the top of the page. Notice that the URL ends with Privacy. By convention, Razor Pages apps map page routes to the files within the Pages directory structure.

Stop the application by pressing the Ctrl+C key combination (Command+C on Mac).

You've verified you can successfully compile, run, and deploy the project. Let's modify it so the user can display and update a list of pizzas.

Explore the Razor Pages project
200 XP
10 minutes
In this unit, you'll use the .NET CLI to compile and run a web app. You'll tour the running app to understand the UI experience it provides.

Examine the project
The RazorPagesPizza project directory is currently open in the Visual Studio Code editor. The following table outlines noteworthy project files and directories. Examine each of them in the Visual Studio Code editor window.

EXAMINE THE PROJECT
Name	Description
Pages/	Contains Razor Pages and supporting files. Each Razor page is a pair of files:
* A .cshtml file that contains markup with C# code using Razor syntax.
* A .cshtml.cs PageModel class file that defines page handler methods and data used to render the page.
wwwroot/	Contains static asset files, such as HTML, JavaScript, and CSS.
RazorPagesPizza.csproj	Contains configuration metadata for the project, such as dependencies.
Program.cs	Serves as the app's managed entry point and configures app behavior, such as routing between pages.
Razor page files and their paired PageModel class file
By convention, the Pages directory is where all Razor Pages are stored and organized in an ASP.NET Core app.

A Razor page has a .cshtml file extension. By convention, its associated PageModel C# class file uses the same name but with a .cs appended. For example, the Razor page Index.cshtml has an associated PageModel class file for Index.cshtml.cs.

A model object defines data properties and encapsulates logic or operations related to those data properties. A PageModel is essentially the same thing, but is a model that more specifically encapsulates the data properties and logic operations scoped just to its Razor page. The PageModel class:

Allows for separation of the logic of a Razor page from its presentation.
Defines page handlers for requests sent to the page and for the data used to render the page.
A page handler is the method that's executed as a result of an HTTP request. For example, an OnGet method in the Razor page's PageModel class is automatically executed for an HTTP GET request.

The Pages/Shared directory
Partial markup elements that are shared across several Razor pages are located by convention in a Pages/Shared directory. The RazorPagesPizza app uses two shared partial views, which are included when you create a new ASP.NET Core Web Application project:

_Layout.cshtml: Provides common layout elements across multiple pages.
_ValidationScriptsPartial.cshtml: Provides validation functionality such as client-side form input validation and cross-site antiforgery validation. This partial view is available to all pages in the project.
Layouts and partial view files
Layouts: In ASP.NET Core, layouts are .cshtml files that define a top-level template for views in the app. Apps don't require a layout. Apps can define more than one layout, with different views specifying different layouts. Most web apps have a common layout that provides a consistent user experience. The layout typically includes common UI elements such as the app header, navigation or menu elements, and footer. Common HTML structures such as scripts and stylesheets are also frequently used by many pages within an app. All of these shared elements may be defined in a layout file, which can then be referenced by any view used within the app. Layouts reduce duplicate code in views.

Partial view: A partial view is a Razor markup file (.cshtml) that renders HTML output within another markup file's rendered output. Partial views are used to break up large markup files into smaller components. They also reduce the duplication of common markup content across markup files. Partial views aren't used to maintain common layout elements. Common layout elements are specified in a _Layout.cshtml file.

Layouts and partial views are outside of the scope of this module. At the end of the module, links are provided to take a deeper dive on features and concepts introduced here.

The Pages directory structure and routing requests
Razor Pages uses the directory structure within the Pages directory as the convention for routing requests by default. An index page located in the root of the Pages directory, for example, is the default page for the app's site. In the RazorPagesPizza project's Pages/Products directory, you'll find a collection of Razor pages, including an Index.cshtml page. Requests routed to /Product/ will be directed to use the default Index.cshtml page physically located at Products/Index.cshtml, for example. The project's Razor pages (.cshtml) and accompanying PageModel classes (.cshtml.cs) are grouped conveniently in Pages/Products. Any passed route parameter values are made accessible through a property. ASP.NET Core offers robust routing features.

The following table provides routes to be used in this module's completed project.

THE PAGES DIRECTORY STRUCTURE AND ROUTING REQUESTS
URL	Maps to this Razor page
www.domain.com	Pages/Index.cshtml
www.domain.com/index	Pages/Index.cshtml
www.domain.com/products	Pages/Products/Index.cshtml
www.domain.com/products/create	Pages/Products/Create.cshtml
Check your knowledge
1. What statement best describes a PageModel?

A PageModel encapsulates the logic operations scoped just to its Razor page.

A PageModel provides top-level view templates using Razor syntax.

A PageModel is a partial Razor markup file used to break up large markup files into smaller components.

 ----------
 

<h3 align="center">Unit 4</h3> 
 
# Explore the Razor Pages project
 
In this unit, you'll use the .NET CLI to compile and run a web app. You'll tour the running app to understand the UI experience it provides.

Examine the project
The RazorPagesPizza project directory is currently open in the Visual Studio Code editor. The following table outlines noteworthy project files and directories. Examine each of them in the Visual Studio Code editor window.

EXAMINE THE PROJECT
Name	Description
Pages/	Contains Razor Pages and supporting files. Each Razor page is a pair of files:
* A .cshtml file that contains markup with C# code using Razor syntax.
* A .cshtml.cs PageModel class file that defines page handler methods and data used to render the page.
wwwroot/	Contains static asset files, such as HTML, JavaScript, and CSS.
RazorPagesPizza.csproj	Contains configuration metadata for the project, such as dependencies.
Program.cs	Serves as the app's managed entry point and configures app behavior, such as routing between pages.
Razor page files and their paired PageModel class file
By convention, the Pages directory is where all Razor Pages are stored and organized in an ASP.NET Core app.

A Razor page has a .cshtml file extension. By convention, its associated PageModel C# class file uses the same name but with a .cs appended. For example, the Razor page Index.cshtml has an associated PageModel class file for Index.cshtml.cs.

A model object defines data properties and encapsulates logic or operations related to those data properties. A PageModel is essentially the same thing, but is a model that more specifically encapsulates the data properties and logic operations scoped just to its Razor page. The PageModel class:

Allows for separation of the logic of a Razor page from its presentation.
Defines page handlers for requests sent to the page and for the data used to render the page.
A page handler is the method that's executed as a result of an HTTP request. For example, an OnGet method in the Razor page's PageModel class is automatically executed for an HTTP GET request.

The Pages/Shared directory
Partial markup elements that are shared across several Razor pages are located by convention in a Pages/Shared directory. The RazorPagesPizza app uses two shared partial views, which are included when you create a new ASP.NET Core Web Application project:

_Layout.cshtml: Provides common layout elements across multiple pages.
_ValidationScriptsPartial.cshtml: Provides validation functionality such as client-side form input validation and cross-site antiforgery validation. This partial view is available to all pages in the project.
Layouts and partial view files
Layouts: In ASP.NET Core, layouts are .cshtml files that define a top-level template for views in the app. Apps don't require a layout. Apps can define more than one layout, with different views specifying different layouts. Most web apps have a common layout that provides a consistent user experience. The layout typically includes common UI elements such as the app header, navigation or menu elements, and footer. Common HTML structures such as scripts and stylesheets are also frequently used by many pages within an app. All of these shared elements may be defined in a layout file, which can then be referenced by any view used within the app. Layouts reduce duplicate code in views.

Partial view: A partial view is a Razor markup file (.cshtml) that renders HTML output within another markup file's rendered output. Partial views are used to break up large markup files into smaller components. They also reduce the duplication of common markup content across markup files. Partial views aren't used to maintain common layout elements. Common layout elements are specified in a _Layout.cshtml file.

Layouts and partial views are outside of the scope of this module. At the end of the module, links are provided to take a deeper dive on features and concepts introduced here.

The Pages directory structure and routing requests
Razor Pages uses the directory structure within the Pages directory as the convention for routing requests by default. An index page located in the root of the Pages directory, for example, is the default page for the app's site. In the RazorPagesPizza project's Pages/Products directory, you'll find a collection of Razor pages, including an Index.cshtml page. Requests routed to /Product/ will be directed to use the default Index.cshtml page physically located at Products/Index.cshtml, for example. The project's Razor pages (.cshtml) and accompanying PageModel classes (.cshtml.cs) are grouped conveniently in Pages/Products. Any passed route parameter values are made accessible through a property. ASP.NET Core offers robust routing features.

The following table provides routes to be used in this module's completed project.

# THE PAGES DIRECTORY STRUCTURE AND ROUTING REQUESTS
 
| URL | Maps to this Razor page |
| :-------------: | :-------------: |
| www.domain.com   | Pages/Index.cshtml |
| www.domain.com/products   | Pages/Products/Index.cshtml |
| www.domain.com/products/create   | Pages/Products/Create.cshtml |
 
# Check your knowledge
1. What statement best describes a PageModel?

- [x] A PageModel encapsulates the logic operations scoped just to its Razor page.
 `REASON`
 **A PageModel encapsulates the data properties and logic operations scoped just to its Razor page. By convention, it's defined in a '.cshtml.cs' file using the same name and directory.**
 
- [ ]A PageModel provides top-level view templates using Razor syntax.

- [ ] A PageModel is a partial Razor markup file used to break up large markup files into smaller components.


<p style="color: blue">Para</p>
Update readme

