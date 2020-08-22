# National and State Parks API

#### C# .Net Core Web API Application, 08/21/2020

#### By **Evgeniya Chernaya**

## Description

This Web API application has all CRUD fucntionality, Swagger documentation and JWT authentication.

## Setup/Installation Requirements

* Click the green "Clone or download" button at the right of the screen.

* Select "Download ZIP."

* Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.

* In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.

* Double-click the downloaded .NET Core 2.2 SDK file and run the installer.

* Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.

* Enter the command "dotnet watch run" in the terminal.

## API documentation

* Install Postman on your computer 

* Explore API endpoint in the Postman

#### HTTP Requests

* Base URL: http://localhost:5000
 
* GET /api/nationalparks
* GET(id) /api/nationalparks/{id}
* POST /api/nationalparks
* PUT(id) /api/nationalparks/{id}
* DELETE(id) /api/nationalparks/{id}

#### Example of search query

http://localhost:5000/api/nationalparks/?name=rainier

#### Sample JSON response

{
    "nationalParkId": 1,
    "name": "Rainier National Park",
    "address": "Ashford, WA 98304"
}

#### Explore API using Swagger Documentation: http://localhost:5000/index.html

## Known Bugs

_No known bugs_

## Technologies Used

  * C# .Net Core Web API
  * Entity Framework
  * Visual Studio Code
  * MySQL Workbench

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Evgeniya Chernaya**.