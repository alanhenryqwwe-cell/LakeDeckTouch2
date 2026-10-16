# Lake Deck Touch — starter source (not a ready-to-install mod)

## What this package currently does
- Provides a SMAPI C# source scaffold.
- Attempts to detect a left mouse click / touch and reports the map tile coordinates.
- Includes a placeholder wood-plank sprite for planning the next step.

## Important limitation
This is **not yet a working deck-building mod**. It does not place planks, make water walkable, or save placed tiles. The Android touch event mapping and compilation against Stardew Valley Android 1.6 / SMAPI 4.3.2.1 have not been tested. Do not copy this folder into `Mods` expecting a working deck.

A real walkable deck requires at least:
1. A compatible compiled `LakeDeckTouch.dll`.
2. A registered plank tilesheet / rendering method.
3. Tile collision and water-passability handling.
4. Save/load persistence and checks that prevent placing pieces on invalid tiles.
5. Testing on the exact Android game + SMAPI build.

## Files
- `manifest.json`: SMAPI manifest template.
- `ModEntry.cs`: C# input-detection prototype.
- `assets/wood_plank_sample.png`: visual mockup, not connected to the game.
- `LakeDeckTouch.csproj`: starter project file; game/SMAPI reference paths must be set for the build environment.

## Android installation
Do **not** install this as a finished mod. It has no compiled DLL. A Windows/Linux/macOS computer with the correct Stardew Valley/SMAPI reference assemblies is normally needed to compile C# source. If you only have a phone, we can continue by preparing the source and then discuss an Android-compatible build workflow, but the result must be tested before use.

## Safety
Back up your save before testing any map-changing mod.
