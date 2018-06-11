param([String]$nuGetExePath='d:\Devtools\nuget.exe') 

# Copy source file to .pp file
Copy-Item ..\Pitcher\Throw.cs .\Throw.cs.pp

# Replace namespace
$newNamespaceWithWarning = @'
// THIS IS A SOURCE FILE FROM THE PITCHER.SOURCES PACKAGE. DO NOT EDIT
namespace $rootnamespace$.Helpers
'@

(Get-Content .\Throw.cs.pp).replace('namespace Pitcher', $newNamespaceWithWarning) | Set-Content .\Throw.cs.pp
# Make Throw class internal
(Get-Content .\Throw.cs.pp).replace('public static class Throw', 'internal static class Throw') | Set-Content .\Throw.cs.pp

# Create the NuGet package
& $nuGetExePath pack Pitcher.Sources.nuspec