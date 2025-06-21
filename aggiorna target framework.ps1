Get-ChildItem -Recurse -Filter *.csproj | ForEach-Object {
    $path = $_.FullName
    $content = Get-Content $path -Raw

    # Gestione TargetFrameworks
    if ($content -match '<TargetFrameworks>(.+?)</TargetFrameworks>') {
        $frameworks = $matches[1] -split ';'
        if ($frameworks -contains 'netstandard2.0') {
            $frameworks = $frameworks -replace 'netstandard2.0', 'netstandard2.1'
            $content = $content -replace '<TargetFrameworks>.+?</TargetFrameworks>', "<TargetFrameworks>$($frameworks -join ';')</TargetFrameworks>"
            Write-Host "Aggiornato $path a netstandard2.1 (multi-target)"
        } else {
            $content = $content -replace '<TargetFrameworks>.+?</TargetFrameworks>', '<TargetFrameworks>net8.0</TargetFrameworks>'
            Write-Host "Aggiornato $path a net8.0 (multi-target)"
        }
    }
    # Gestione TargetFramework singolo
    elseif ($content -match '<TargetFramework>(.+?)</TargetFramework>') {
        $framework = $matches[1]
        if ($framework -eq 'netstandard2.0') {
            $content = $content -replace '<TargetFramework>netstandard2.0</TargetFramework>', '<TargetFramework>netstandard2.1</TargetFramework>'
            Write-Host "Aggiornato $path a netstandard2.1"
        } elseif ($framework -eq 'netstandard2.1') {
            # Già corretto
        } else {
            $content = $content -replace '<TargetFramework>.+?</TargetFramework>', '<TargetFramework>net8.0</TargetFramework>'
            Write-Host "Aggiornato $path a net8.0"
        }
    }
    Set-Content $path $content
}