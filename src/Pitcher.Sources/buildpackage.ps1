param([String]$nuGetExePath='d:\Devtools\nuget.exe') 

# Copy source file to .pp file
Copy-Item ..\Pitcher\Throw.cs .\Throw.cs.pp

# Replace namespace
(Get-Content .\Throw.cs.pp).replace('namespace Pitcher', 'namespace $rootnamespace$.Helpers') | Set-Content .\Throw.cs.pp
# Make Throw class internal
(Get-Content .\Throw.cs.pp).replace('public static class Throw', 'internal static class Throw') | Set-Content .\Throw.cs.pp

# Create the NuGet package
& $nuGetExePath pack Pitcher.Sources.nuspec