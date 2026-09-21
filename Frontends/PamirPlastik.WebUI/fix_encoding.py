import codecs

with codecs.open('Views/Home/Index.cshtml', 'r', encoding='windows-1254', errors='ignore') as f:
    content = f.read()

content = content.replace('Plastik \xddretiminde', 'Plastik Üretiminde')
# Add 3rd badge
badge_html = '''
                <div class="absolute top-1/2 -right-12 bg-white text-[#0f172a] px-6 py-4 rounded-2xl shadow-xl flex items-center gap-3 z-20 animate-bounce" style="animation-duration: 3.5s; animation-delay: 0.5s;">
                    <div class="w-10 h-10 bg-yellow-100 rounded-full flex items-center justify-center text-yellow-600">
                        <svg class="w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M13 10V3L4 14h7v7l9-11h-7z"></path></svg>
                    </div>
                    <div>
                        <div class="font-black text-sm">@Model.HeroBadge3_TR</div>
                        <div class="text-xs text-gray-500 font-medium">Yenilikçi</div>
                    </div>
                </div>
'''
content = content.replace('High Quality</div>\r\n                    </div>\r\n                </div>', 'High Quality</div>\r\n                    </div>\r\n                </div>\n' + badge_html)

# Also fix the text "Sustainable" and "High Quality"
content = content.replace('Sustainable', 'Sürdürülebilir')
content = content.replace('High Quality', 'Yüksek Kalite')

# Also make the badges smaller as requested!
# Original: w-10 h-10 px-6 py-4 text-sm text-xs
content = content.replace('px-6 py-4 rounded-2xl', 'px-4 py-3 rounded-xl')
content = content.replace('w-10 h-10 bg-green-100', 'w-8 h-8 bg-green-100')
content = content.replace('w-10 h-10 bg-blue-100', 'w-8 h-8 bg-blue-100')
content = content.replace('w-10 h-10 bg-yellow-100', 'w-8 h-8 bg-yellow-100')
content = content.replace('text-sm', 'text-xs')
content = content.replace('text-xs text-gray-500', 'text-[10px] text-gray-500')
content = content.replace('w-5 h-5', 'w-4 h-4')

with codecs.open('Views/Home/Index.cshtml', 'w', encoding='utf-8-sig') as f:
    f.write(content)
