# To publish to baget

- cd to desired project // if in root directory, will pack all csproj.
- dotnet pack WebUI.csproj

- cd bin
- cd debug
- dotnet nuget push clean_architecture_grpc.WebUI.1.0.0.nupkg -k test 


