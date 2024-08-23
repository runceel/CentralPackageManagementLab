$v = Read-Host "Enter version number"
./nuget pack Common/All/CommonLibrary.Packages.nuspec -OutputDirectory ./local -Version $v
