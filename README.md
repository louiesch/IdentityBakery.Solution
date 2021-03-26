# _Pierre's Sweet and Savory Treats

#### _Independent coding assignment to get experience using ASP.NET Core MVC and Databases with many-to-many relationships, and Identity to allow users to create an account._

#### By _**Louie Schoenknecht**_

## Technologies Used

* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _dotnet script, REPL_
* _Razor View Engine_
* _MySQL and MySQL Workbench_
* _Git_
* _Microsoft Entity Framework Core_


## Setup/Installation Requirements

### Application Setup
* _Install .NET 5.0 [here](https://dotnet.microsoft.com/download/dotnet/5.0)_

* _Clone repository from GitHub to desired location using_
  > git clone https://github.com/louiesch/IdentityBakery.Solution
* _In the terminal navigate to and open project directory_
  > cd IdentityBakery.Solution
* _Navigate to production folder_
  > cd IdentityBakery
* _Create a file in top level of Factory production folder called appsettings.json_
  > touch appsettings.json
* _Add the following code to your .json file_
```
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
}
}
```
* _Make sure that [YOUR DATABASE] and [YOUR PASSWORD] match the database name and password of your local MySql server._


### To Run Application

* _Navigate to IdentityBakery production folder in terminal_
  > cd IdentityBakery

* _To download obj and bin files needed for the program to run, while still in IdentityBakery folder type into the terminal:_
  >dotnet restore

* _The cloned project should come with a Migrations folder. Check that it is there, and then to apply the database structure, type in the terminal_
  >dotnet ef database update

* _To run the program, while still in production folder IdentityBakery type into the terminal:_
  >dotnet run


#### Note: The server will not open automatically. The user will need to click on the live share link in terminal, or enter 'localhost:5000' URL into browser.


## Known Bugs

* _No known bugs_

## License

_[MIT](https://choosealicense.com/licenses/mit/) Copyright (c) 2021 Louie Schoenknecht_


## Contact Information

_Want to get in touch? Send an email to luisesch97@gmail.com_