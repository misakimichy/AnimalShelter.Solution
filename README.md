# Local Business API - Zomato API

#### _C#, .NET: Local Business API - Zomato API, 01/31/2020_ Created By Misaki Koonce

## Description
Create an API for a local business lookup. The API will list restaurants and shops in town.

<!-- <img src="img/screenshot.png" style="text-align: center;"/> -->

## Application specifications:
- Zomato API API
    - Get a API key from [Zomato API developers account](https://developers.zomato.com/api)

    - Create a EnvironmentVariables.cs in AnimalShelterAPI/Models and paste the API key in the code:
    ```
    namespace AnimalShelterAPI.Models
    {
        public static class EnvironmentVariables
        {
            public static string ApiKey = "paste-api-key-here";
        }
    }
    ```


## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone this-project-url
```

2. Make sure you have added a EnvironmentVariables.cs in AnimalShelterAPI/Models with your api key


3. Run application
```
$ dotnet run
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
misaki.koonce@gmail.com


## Technologies Used
C# and ASP.NET Core MVC, MySQL and Entity Framework

## License
Copyright © 2020 under the MIT License