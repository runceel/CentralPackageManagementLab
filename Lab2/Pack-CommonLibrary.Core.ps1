$v = Read-Host "Enter version number"
dotnet pack Common/CommonLibrary.Core/CommonLibrary.Core.csproj -o ./local -p:PackageVersion=$v -p:Version=$v
