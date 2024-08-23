$v = Read-Host "Enter version number"
dotnet pack Common/CommonLibrary/CommonLibrary.csproj -o ./local -p:PackageVersion=$v -p:Version=$v
