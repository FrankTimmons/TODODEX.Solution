# TODODEX
 
#### By _**Frank Timmons, Max Alvord, Zachary Waggoner, Anthony Difalco, Matt Wilkinson, Grace Kostanich**_  
 
_This is a project containing a website that pings a homemade API to retrieve data from a ToDo character_  
 
---
 
## Technologies Used
 
* _C#_
* _.NET_
* _SQL Workbench_
* _Entity Framework_
* _Swagger_
 
## Setup and Installation Requirements
**⚠️ This Setup assumes you have GitBash and MySQL Workbench pre-installed ⚠️**

If needed, please navigate to these links:  
https://git-scm.com/download/  
Download Git and follow the setup wizard.  
https://dev.mysql.com/downloads/workbench/  
Download MySQL Workbench, follow the setup wizard & create a localhost server on port 3306**
 
 
**Note**: _Keep track of your username and password, this will be used in the connection link under,_  
"**SQL Workbench Configuration**" > "2. Insert the following code:"


---
# ToDoClient.Solution Setup

## Description
 
This is a website built on ASP.NET Core MVC that's using a custom built API   
_Written in C#_
 
---
 
 
<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/FrankTimmons/TODODEX.Solution.git
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,  
<strong>$ git clone https://github.com/FrankTimmons/TODODEX.Solution.git</strong>
<li>In the terminal, navigate to the main root directory, "TODODEX.Solution".
<li> Navigate into the <em>projects</em> root directory, "ToDoClient.Solution".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>
 
<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsettings.json file in the "ToDoClient" directory  
   <pre>ToDoClient.Solution
   └── appsettings.json</pre>
 
<li> Insert the following code: <br>
 
<pre>
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=tododex_users;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>
 
<li>In root directory of the project folder "ToDoClient.Solution", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>
 
<ol>
  <li>Open SQL Workbench.
  <li>Navigate to "tododex_users" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the table, you should see <strong>tododex_users</strong>.
 
</details>
 
<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>TODODEX.Solution
   └── ToDoClient.Solution
      </pre>
 
 
Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>

---

# ToDoAPI.Solution Setup

## Description
 
This is an API built on ASP.NET Core MVC that's populated with seed data of TODO characters   
_Written in C#_
 
 ---
 
 
<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/FrankTimmons/TODODEX.Solution.git
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,  
<strong>$ git clone https://github.com/FrankTimmons/TODODEX.Solution.git</strong>
<li>In the terminal, navigate to the main root directory, "TODODEX.Solution".
<li> Navigate into the <em>projects</em> root directory, "ToDoAPI.Solution".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>
 
<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsettings.json file in the "ToDoAPI" directory  
   <pre>ToDoAPI.Solution
   └── appsettings.json</pre>
 
<li> Insert the following code: <br>
 
<pre>
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=todoapi;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
</pre>

<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>
 
<li>In root directory of the project folder "ToDoAPI", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>
 
<ol>
  <li>Open SQL Workbench.
  <li>Navigate to "todoapi" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the table, you should see <strong>todoapi</strong>.
 
</details>
 
<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>TODODEX.Solution
   └── ToDoAPI.Solution
      </pre>
 
 
Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
 
---
## API Documentation
_This API is using Swagger (an open-source API tool) to describe its structure and display all available endpoints_
 
<details>
<summary><strong>View in Browser</strong></summary>
<ol>
<li> Follow the project <strong>Setup and Installation Requirements</strong> above then run the application in a terminal inside the projects root directory with  
 
```$ dotnet run```
<li> Open the application in a browser by selecting the provided link in your terminal  
 
(Ex:|| https://localhost:5002)
 
<li> Add <strong>"/swagger"</strong> to the end of the URL path to view API structure and all endpoints    
 
(Ex:|| https://localhost:5002/swagger)
 
<br>
</details>
 
---
## Endpoints
 
Base URL: https://localhost:5002
 
#### HTTP Request
 
```
GET api/todos
POST api/todos
DELETE api/todos/{id}
PUT api/todos/{id}
GET api/todos/{id}
```
 
#### Example Query
 
```
https://localhost:5002/api/todos/1
```
 
---
 
This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.
 
---
 
## Known Bugs
 
* _While hosting a live share session, the max user connections may exceed the limit of 10 even if the amount of connections is less than that. This is possibly due to using the API database in conjuction with the client._
* _When using server with Azure, Swagger cannot be found (you'll recieve error 404)_
 
## License
 
[MIT](https://opensource.org/osd)

Copyright (c) 8/22/2022 Frank Timmons, Max Alvord, Zachary Waggoner, Anthony Difalco, Matt Wilkinson, Grace Kostanich
