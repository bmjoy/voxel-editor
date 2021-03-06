# N-Space

<img src="https://raw.githubusercontent.com/vanjac/voxel-editor/master/Assets/icon.png" alt="Icon" width="128">

A mobile app for building 3D interactive worlds. This is a work in progress.

- [Google Play](https://play.google.com/store/apps/details?id=com.vantjac.voxel)
- [iOS App Store](https://itunes.apple.com/us/app/n-space/id1448016814)
- [Subreddit](https://www.reddit.com/r/nspace/)
- [Video tutorials](https://www.youtube.com/playlist?list=PLMiQPjIk5IrpgNcQY5EUYaGFDuAf7PLY2)

## Features

- Sculpt indoor/outdoor 3D environments. The interface is designed to allow rapid design and modification.
- Paint surfaces with a selection of over 100 high quality materials, along with custom colors.
- Use the Bevel tool to create complex shapes including rounded edges and stair steps.
- Use "substances" to build dynamic worlds with moving objects, water, and physics.
- Wire components together to respond to game events with a powerful logic system.
- Customize the sky, lighting, and fog.
- Experience your creations from a first person perspective. Make a game or just an interesting environment to explore.
- Interactive tutorials guide you through the interface and more advanced features of the app.
- World files can be sent to/from other apps.

## Using the app

The app opens to a list of "worlds" that you have created. Tap "New" to create a new world. Tap a world to open it in the Editor. Tap the menu button next to a world to access additional options, including sharing the worlds as `.nspace` files. You can open these files in N-Space from another app, like an email attachment or downloaded file.

N-Space has built-in documentation and tutorials, which you can access through the overflow (!["..."](https://github.com/vanjac/voxel-editor/blob/master/Assets/VoxelEditor/GUI/icons/dots-vertical.png)) menu, by tapping Help.

## Building the app yourself

The app has been tested with Unity 2018.4.X on Android and iOS. There is little platform-specific code (only for importing/exporting files). Most of the user interface requires touch input and will not work with a mouse, so you will need to use the Unity Remote App, or build for Android directly.

This repository does not come with textures from [Poliigon](https://www.poliigon.com/), [FreePBR](https://freepbr.com/), [3dtextures](3dtextures.me), and [Genetica](http://spiralgraphics.biz/genetica.htm). You can purchase/download them yourself - look in the folders inside `Assets/GameAssets` for a list of `.meta` files which correspond to the missing textures. It is also possible to test N-Space without the textures at all. Materials will lack texture, but you can paint the walls with colors instead.

The app has four scenes:

- `Menu/menuScene`: The file selection menu
- `VoxelEditor/editScene`: The Editor interface. If you open this scene directly without first choosing a file, it will look for a file called `mapsave`.
- `Game/playScene`: The gameplay interface. Again, without choosing a file it will look for `mapsave`.
- `Menu/fileReceiveScene`: This scene will launch if you try to open a world file from another app using N-Space. This only works on Android.

### Build Environment Setup

These notes are mostly for me, but you can read them too.

- Install latest release of Unity 2018, with build tools for Android/iOS.
- Install Blender
- Clone repo. **Don't open in Unity yet!!**
- Optional: Download/copy textures from Poliigon, FreePBR, and Genetica (see above)
- Open project in Unity, and switch platform to Android
- Open Player settings and browse for the keystore location.
- Open Project Settings > Editor and switch Unity Remote device to Android

### For each build

- Enter keystore password
- Change Device Filter

## More info

[MIT License](https://github.com/vanjac/voxel-editor/blob/master/LICENSE.txt)

See [credits.txt](https://github.com/vanjac/voxel-editor/blob/master/Assets/Menu/credits.txt) for sources of some assets.

## Contact me:

vantjac.dev@gmail.com
