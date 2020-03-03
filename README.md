# Installation

- Download the .NET Core 3.1.101 SDK at https://dotnet.microsoft.com/download/dotnet-core/3.1
- Ensure that Visual Studio 2019 is running version 16.4+
- You may need to install the Blazor Templates for Visual Studio. Open up a Command Prompt window (in administration mode) and run the following:

```
dotnet new -i Microsoft.AspNetCore.Blazor.Templates::3.2.0-preview1.20073.1
```

# Run the Application

- There are two Visual Studio projects:
-- Inside the `BlazorServer` project, there is an example of a Blazor Server application. Open the project in Visual Studio 2019 and run the project.
-- Inside the `BlazorWebAssembly` project, there is an example of a Blazor WebAssembly application. Open the project in Visual Studio 2019. There are two applications within this project. The first is the API that runs on `https://localhost:9000`. The second is the Blazor WebAssembly application that runs on `https://localhost:9001`. Running the project should load both applications.