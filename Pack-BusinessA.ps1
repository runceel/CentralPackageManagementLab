$v = Read-Host "Enter version number"
dotnet pack BusinessA/BusinessA/BusinessA.csproj -o ./local -p:Version=$v
