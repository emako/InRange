Set-Location $PSScriptRoot

Write-Host @"
███╗   ██╗██╗   ██╗ ██████╗ ███████╗████████╗
████╗  ██║██║   ██║██╔════╝ ██╔════╝╚══██╔══╝
██╔██╗ ██║██║   ██║██║  ███╗█████╗     ██║   
██║╚██╗██║██║   ██║██║   ██║██╔══╝     ██║   
██║ ╚████║╚██████╔╝╚██████╔╝███████╗   ██║   
╚═╝  ╚═══╝ ╚═════╝  ╚═════╝ ╚══════╝   ╚═╝   
"@

Push-Location "..\src\"
Write-Host "Processing System.InRange ..."
dotnet restore
dotnet build -c Release
dotnet pack -c Release -o ../build/
Pop-Location

Write-Host "`nPress any key to exit..."
[void][System.Console]::ReadKey($true)
