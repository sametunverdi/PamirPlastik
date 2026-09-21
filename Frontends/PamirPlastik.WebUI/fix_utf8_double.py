import codecs

with codecs.open('Views/Home/Index.cshtml', 'r', encoding='utf-8') as f:
    content = f.read()

content = content.replace('Ä°', 'İ')
content = content.replace('Ã¼', 'ü')
content = content.replace('Ã§', 'ç')
content = content.replace('Ã¶', 'ö')
content = content.replace('Ä±', 'ı')
content = content.replace('ÅŸ', 'ş')
content = content.replace('ÄŸ', 'ğ')
content = content.replace('Ãœ', 'Ü')
content = content.replace('Ã‡', 'Ç')
content = content.replace('Ã–', 'Ö')
content = content.replace('Å\x9e', 'Ş') # ÅŸ for lowercase, Åž for uppercase
content = content.replace('Ä\x9e', 'Ğ')

with codecs.open('Views/Home/Index.cshtml', 'w', encoding='utf-8-sig') as f:
    f.write(content)
