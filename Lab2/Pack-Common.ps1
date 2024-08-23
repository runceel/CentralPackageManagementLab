$v = Read-Host "Enter version number"
dotnet pack Common/CommonLibrary.Core/CommonLibrary.Core.csproj -o ./local -p:PackageVersion=$v -p:Version=$v
dotnet pack Common/CommonLibrary/CommonLibrary.csproj -o ./local -p:PackageVersion=$v -p:Version=$v
./nuget pack Common/Common.Packages.nuspec -OutputDirectory ./local -Version $v
