$v = Read-Host "Enter version number"
dotnet pack BusinessB/BusinessB/BusinessB.csproj -o ./local -p:PackageVersion=$v -p:Version=$v
