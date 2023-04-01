# _Parks And Recreation Api_

#### By _**Kai Clausen**_

#### _This API will help keep track of Parks_

## Technologies Used

* _C#_
* _.Net_
* _MySQL_
* _MySQL Workbench_
* _SwashBuckle_

## Description

_This API was created as an independent project to be submitted for code review to demonstrate an understanding of API construction. The styling was not a priority. It's function _

## Setup/Installation Requirements

* _If you do not have C#/.Net, dotnet-script, and MySQL, visit [this page](https://www.learnhowtoprogram.com/c-and-net) and work through the second Pre-Work lesson_
* _Once C#/.Net, dotnet-script, and MySQL are correctly installed and configured, clone down this repository_
* _Navigate to the production directory, labeled ```ParksAndRecreation.Solution```_
* _Once there, in your terminal enter the command ```dotnet tool install --global dotnet-ef --version 6.0.0```_
* _When that is finished enter ```dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0```_
* _Then you will create a new file within the ```ParksAndRecreation.Solution``` directory_
* _Name the file ```appsettings.json```_
* _Copy and paste the following into this file_

```cs
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

* _Replace [YOUR-DB-NAME] with a name of your choice (It's common to use the name of the root or production directory as the name, with each word separated with an underscore '_'), [YOUR-USER-HERE] with your userid, and [YOUR-PASSWORD-HERE] with your password_
* _In the top level of the ```ParksAndRecreation.Solution``` directory, enter the command ```dotnet ef database update``` to create a database based on the existing migrations._
* _Once you have completed the above instructions, you can enter the command in the terminal ```dotnet run``` to launch the API in your browser with Swagger. This lets you interact with the Api without actually having a client, and is useful in getting to know the endpoints and queries_
* _When you are finished, exit the browser window and click into your terminal and press Ctrl+C_

## EndPoints

_Please note that while these endpoints include "v2" in them, it is not necessary nor important to include the version number in the endpoint as there is no difference in functionality between version 1.0 and version 2.0"_
```
GET http://localhost:5000/v2/Parks
GET http://localhost:5000/v2/Parks/{id}
POST http://localhost:5000/v2/Parks
PUT http://localHost:5000/v2/Parks/{id}
DELETE http://localhost:5000/v2/Parks/{id}
```

### Optional Query String Parameters for GET Request

|Field Name                      |Query Name                     | Is Optional?                |Requires Data Type:   |
|--------------------------------|-------------------------------|-----------------------------|----------------------|
|Park Name                       |parkName                       |true                         |String                |
|County                          |county                         |true                         |String                |
|Is State Park?                  |isStatePark                    |true                         |Bool                  |
|Is National Park?               |isNationalPark                 |true                         |Bool                  |
|Has Bathrooms                   |hasBathrooms                   |true                         |Bool                  |
|Has Family Friendly Bathroom    |hasFamilyFriendlyBathroom      |true                         |Bool                  |
|Has Play Structure              |hasPlayStructure               |true                         |Bool                  |
|Page Number                     |page                           |true                         |Int                   |
|Page Size                       |pageSize                       |true                         |Int                   |

### Further Exploration Objectives Included

#### Pagination

_This API implements pagination passively. As such, there is no need to feed it a page number and/or page size to get back a limited number of items. The default is set to 10 per page starting on page 1. This limit can be overidden by including the Query Name with Data formatted in the corresponding Required Data Type. Specifically if you want to see the first 20 entries use ```?page=1&pageSize=20```_

#### Versioning

_This API implements Versioning to allow the user to keep using the version of the API that they built their Client around indefinitely, or as long as the API is hosted. Currently there is no difference between v1.0 and v2.0, but you can see that versioning has been implemented if you interact with it via Swagger. The current used version appears in the top right corner._

## Known Bugs

* _Changing the version does nothing._

## License

_MIT - If you encounter any bugs, please feel free to fix them yourself, or contact me at kaiclausen123@gmail.com_

Copyright (c) _2023_ _Kai Clausen_