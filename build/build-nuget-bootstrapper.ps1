# Bootstrapper for building

Import-Module ".\packages\psake-4.1.0\psake.psm1"

Invoke-psake -buildFile ".\build\build-nuget.ps1"