git checkout Areas\Admin\Views\HomePageSetting\Edit.cshtml

$content = Get-Content "Areas\Admin\Views\HomePageSetting\Edit.cshtml" -Raw

$content = $content -replace 'asp-action="Update"', 'asp-action="Edit"'

$startIndex = $content.IndexOf('<!-- PRODUCTION POWER SECTION -->')
$endIndex = $content.IndexOf('<!-- COMPONENT TITLES SECTION -->')
$endIndex = $content.IndexOf('</div>', $endIndex)
$endIndex = $content.IndexOf('</div>', $endIndex + 6)
$endIndex = $content.IndexOf('</div>', $endIndex + 6) + 6

if ($startIndex -gt 0 -and $endIndex -gt $startIndex) {
    $part1 = $content.Substring(0, $startIndex)
    $part2 = $content.Substring($endIndex)
    $content = $part1 + "            <div class=\"flex justify-end mt-6\">
                <button type=\"submit\" class=\"btn bg-indigo-500 hover:bg-indigo-600 text-white\">Deðiþiklikleri Kaydet</button>
            </div>
        </form>
    </div>
</div>"
}

[System.IO.File]::WriteAllText("Areas\Admin\Views\HomePageSetting\Edit.cshtml", $content, [System.Text.Encoding]::UTF8)
