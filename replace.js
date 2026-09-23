const fs = require('fs');
const path = require('path');

const viewsDir = 'Frontends/PamirPlastik.WebUI/Areas/Admin/Views';
const pattern = /if\s*\(\s*confirm\s*\(\s*['"](.*?)['"]\s*\)\s*\)\s*\{/g;

function walkDir(dir) {
    let results = [];
    const list = fs.readdirSync(dir);
    list.forEach(file => {
        const fullPath = path.join(dir, file);
        const stat = fs.statSync(fullPath);
        if (stat && stat.isDirectory()) {
            results = results.concat(walkDir(fullPath));
        } else if (file === 'Index.cshtml') {
            results.push(fullPath);
        }
    });
    return results;
}

const files = walkDir(viewsDir);
files.forEach(file => {
    let content = fs.readFileSync(file, 'utf8');
    if (content.match(pattern)) {
        content = content.replace(pattern, const swalResult = await Swal.fire({
            title: 'Emin misiniz?',
            text: '\',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#ef4444',
            cancelButtonColor: '#64748b',
            confirmButtonText: 'Evet, Sil!',
            cancelButtonText: 'İptal'
        });
        if (swalResult.isConfirmed) {);
        
        fs.writeFileSync(file, content, 'utf8');
    }
});
console.log('Done!');
