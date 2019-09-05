# multi-language-video-player
A simple VLC video player wrapper to watch a video with multiple audiotracks on separate audio devices.

## How to use
1. Download release from https://github.com/brusiks/multi-language-video-player/releases
2. Install VLC Player
3. Open program and browse path to VLC player (vlc.exe)
4. Browse video file
5. Modify two audio configurations: select audiotrack and audiodevice for each of configurations.
   For example: russian audiotrack to speakers, english audiotrack to headphones
6. Select for what audio configuration show video stream (100% sync with video)
7. Press "Play" to start playback. You can "Stop", "Pause" and change current video time position, both audiotracks will be changed simultaneously.

## Known issues
- Audio can be out of sync after seeking (read what to do below)

## Audio out of sync temporary workaround
You can see the fact of out sync on video duration time. The number in parentheses indicates how big is out of sync in seconds. When time indicator turns red it means that audio is out of sync.
To eliminate out of sync you can seek to the current time by clicking on it on a seek bar. Do it multiple times until there will be no out of sync

## Screenshot
![screenshot](https://raw.githubusercontent.com/brusiks/multi-language-video-player/master/screenshot/Screenshot.png)
