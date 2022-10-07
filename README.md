# secret

# To Push package to an artifact repository
#dotnet nuget add source --username svc_*** --password ${{ secrets.JFROG_APIKEY }} --store-password-in-clear-text --name jfrog "https://***.jfrog.io/artifactory/***_virtual"
#dotnet nuget push ./*.nupkg --skip-duplicate --source "github"


