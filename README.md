## Unity Editor Utils
Constant WIP of some Unity Editor script(s) that might be useful. Place any scripts found under ``Assets/Editor`` in a similar ``Editor`` folder inside your Unity project.<br>
___
### Inspector Lock
**Required scripts:** [Hot Key](Assets/Editor/InspectorLockShortcut.cs) & [Preferences](Assets/Editor/InspectorLockPreferences.cs)<br>
<br>
Locks the selected/active Inspector through a keyboard shortcut - ``Alt + Q`` <i>(default)</i><br>
You can change the shortcut by going to ``Edit/Shortcuts`` and search for "<b>Inspector Lock</b>"<br>
The lock tint colour can be changed <b><i>in-editor</i></b> by going to ``Edit/Preferences/InspectorLock``<br>
___
### Gradient Texture Generator
**Required scripts:** [GG Editor](Assets/Editor/GradientGeneratorEditor.cs) & [GG Script](Assets/Scripts/GradientGenerator.cs)<br>
<br>
Generates a ``.png`` gradient texture of set colour(s) and size under ``Textures/GradientGenerator`` <i>(default)</i><br>
Place the [GG Script](Assets/Scripts/GradientGenerator.cs) on a GameObject in your scene. From there, you can change the default size and path from the Inspector.<br>
___
Tested in Unity 6000.3.14f1 LTS
