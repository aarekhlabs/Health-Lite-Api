# Health-Lite-Api-AspNetCore

A simple .net core 2.0 based project implementing REST API for monitoring service status.

## Features

* ASP.NET Core 2.0
    * Web API

## Prerequisites

* VS 2017 or VS Code
* dontet core 2.0

## Getting Started

* Clone this repo.
* Open solution file in Visual Studio 2017 or
* Open solution folder into VS Code
    * At VS Code terminal windows, change directory to Api.Health project and 
        * run ``dotnet restore``
        * run ``dotnet run``

### API

Call API using CURL

```
curl -X GET --header 'Accept: application/json' 'http://localhost:8363/api/health/heartbeat''``
```

Response:

``` json
{
  "heartbeat": "OK"
}
```

### Nuget Package

The Health API is available as [nuget package](https://www.nuget.org/packages/AarekhLabs.AspNetCore.Api.Health).

> Make sure that ``/api/health/heartbeat`` is not used in any other controller within your project.

## Note

Currently the API has been implemented as Controller so no middleware configuration is required. API will work as soon as it is referenced.

## License

MIT