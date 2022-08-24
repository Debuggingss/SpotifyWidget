# SpotifyWidget
A Windows 10 toolbar to show your current Spotify song in the taskbar

![Spotify Widget](https://i.debuggings.dev/Nwiag4WQ.png)

If the song name is too long hovering over the widget will show the full name.  
![Tooltip](https://i.debuggings.dev/garj5pZK.png)

If the song name is shorter than the maximum, the widget will be resized.  
![Resized Widget](https://i.debuggings.dev/0I6bv8MG.png)

The currently played track is grabbed from the Spotify window's title. If Spotify is not running the widget will hide entirely. If the song is paused the widget will simply say "Paused".

## Installation
1) Grab the latest release from the releases page.
2) Unzip it somewhere on your computer.
3) Run `register.bat` as Administrator.
4) Enable the Toolbar in your taskbar.  
<img src="https://i.debuggings.dev/lw7ueEla.png" width=400px>

## Building
If you want to build the .dll yourself you will need to generate a `key.snk`.

1) Go to Properties/Signing.
2) Check `Sign the assembly`.
3) Select `<New...>` and generate your key.

![Signing](https://i.debuggings.dev/Qj9TEiln.png)

4) Finally, you will need to copy `register.bat` and `unregister.bat` into `bin/Debug` and run it there to install/uninstall your widget. You must unregister before building and register after building if you are making modifications to the code.

*Disclaimer: Not affiliated with Spotify*
