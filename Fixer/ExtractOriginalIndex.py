import json
import re

path = r'C:\Users\Samet\.gemini\antigravity\brain\325130b5-da92-4bf4-a496-9fd508ddd5f1\.system_generated\logs\transcript.jsonl'
out_path = r'C:\Users\Samet\.gemini\antigravity\brain\325130b5-da92-4bf4-a496-9fd508ddd5f1\scratch\original_index.txt'

lines_found = {}

with open(path, 'r', encoding='utf-8') as f:
    for line in f:
        try:
            data = json.loads(line)
            if data.get('source') == 'SYSTEM' and data.get('type') == 'TOOL_RESPONSE':
                content = data.get('content', '')
                if 'Index.cshtml' in content and 'Home' in content and 'File Path:' in content:
                    lines_found[data.get('step_index')] = content
        except:
            pass

with open(out_path, 'w', encoding='utf-8') as out:
    for k in sorted(lines_found.keys()):
        out.write(f"--- STEP {k} ---\n")
        out.write(lines_found[k])
        out.write("\n\n")
