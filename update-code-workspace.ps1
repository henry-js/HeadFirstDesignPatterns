$workspaceFile = ".\HeadFirstDesignPatterns.code-workspace"

$workspace = Get-Content $workspaceFile | ConvertFrom-Json -AsHashtable
[string[]]$workspacePaths = $workspace.folders.path | Resolve-Path -Relative
$paths = Resolve-Path "*/*.csproj" -Relative | Split-Path
$paths += "./"

foreach ($pathsItem in $paths) {
    $resolved = $pathsItem | Resolve-Path -Relative
    if ($resolved -notin $workspacePaths) {
        $workspace.folders += @{path = $($resolved -replace '\\', '/') }
    }
}

$workspace | ConvertTo-Json | Out-File $workspaceFile -Force
