# SwitchAlbumReader
A Windows Forms program to help sort and filter screenshots and videos copied over from a Nintendo Switch

## About
This is a small, very unpolished project I made around the middle of 2020. Was never really intending to release it to others (at least in this state), hence the issues with performance, bugs and the terrible interface. I doubt I'll continue working on this, although if I were to come back to it, I would just remake it from scratch in something more html based (maybe something like Electron?)

## How to Use
### Loading a folder
1. Click "Change Root Folder", then select the "Album" folder copied from your Switch's sd card (selecting a parent directory does not work currently). You should see about 10 images/video descriptions in the right panel. If you selected the wrong folder, it will probably crash.
2. Click "Change Config" (would've made more sense for me to call it "Save Config" but it's close enough). This saves the current config (root folder, game id/name associations) to config.txt (in the same directory as the executable). On subsequent launches of the program you can click "Load Config" to quickly load the previous root folder, the names of each game and display settings.

### Viewing an image
Simply click on the image you want from the gallery and it will be displayed in the bottom-right panel. You can resize the panel by clicking and dragging the borders. The image will even change it's aspect ratio to use as much space as possible! (*probably not actually useful, not sure why I made it do this).

### Viewing a video
Videos are displayed as a textbox in the image gallery (I couldn't find a good way to display thumbnails). To view one, double-click the text. This will open a new window with the video + some basic controls (also has a rare chance of crashing that I never bothered to fix since it happens so inconsistently (for me at least)).

### Filtering/Sorting
In the left panel, go to the "Filter" tab. Here you can sort by date (ascending + descending), and filter by filetype and by game. If you haven't assigned names to game ID's yet, you will need to look at "Assigning Names to Game ID's", otherwise you will only see a list of strings with random-looking letters and numbers. Click "Apply Filter" to manually refresh the gallery if it doesn't update upon changing a setting.

### Changing display settings
In the left panel, go to the "Settings 2" tab. You can change the maximum number of images/videos per row, the minimum width of each image/video in pixels, and the number of images/videos to be loaded at one time. Clicking "Save Settings" will save the current settings to "display.txt" in the same directory as the executable.

### Assigning Names to Game ID's
In the left panel, go to "Settings". You will see a list of ID's with random-looking letters and numbers. Double clicking an entry will open a dialog box allowing you to enter a new name for that ID. The easiest way to find a name for an ID is to adjust the filter to only show images/videos from that ID, then see what game the resulting images/videos are from. Changes made to game names are reflected in the filter settings. Clicking "Change Config" will save any name changes made.