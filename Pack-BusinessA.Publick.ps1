$v = Read-Host "Enter version number"
dotnet pack BusinessA/BusinessA.Public/BusinessA.Public.csproj -o ./local -p:Version=$v
