import keyboard
import time


text ="""Just  about any way you can paint a tree, seems like somewhere there's one that looks just about like that. That's the nice thing about doing landscapes. If you paint a portrait of somebody and you put the eyes in the wrong place, chances are they're gonna notice. But if you paint a tree wrong, somebody will come along and say, "Hey, I know that tree. He's an old friend. He lives in my front yard, has for many years." So you can't hardly do him wrong.
"""

time.sleep(3)

for char in text:
    keyboard.write(char)
    time.sleep(0.082)

