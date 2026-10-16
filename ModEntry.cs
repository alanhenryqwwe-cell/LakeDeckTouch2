using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LakeDeckTouch
{
    /// <summary>
    /// Prototype starter only.
    /// It detects a screen tap and reports the target tile. It does NOT yet place
    /// a walkable deck, alter water collision, or save deck tiles.
    /// Those parts need implementation and testing against the exact Android game build.
    /// </summary>
    internal sealed class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += OnButtonPressed;
            Monitor.Log("Lake Deck Touch prototype loaded. Tap a tile to see its coordinates.", LogLevel.Info);
        }

        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            if (!Context.IsWorldReady)
                return;

            // On many Android setups, screen taps are surfaced as MouseLeft.
            // This must be verified on the user's SMAPI Android build.
            if (e.Button != SButton.MouseLeft)
                return;

            Vector2 tile = Helper.Input.GetCursorPosition().Tile;
            int x = (int)tile.X;
            int y = (int)tile.Y;

            Monitor.Log($"Tap detected at map tile ({x}, {y}) in {Game1.currentLocation.Name}.", LogLevel.Info);
            Game1.addHUDMessage(new HUDMessage(
                $"Deck prototype: tile {x}, {y}. No deck placed yet.",
                HUDMessage.newQuest_type
            ));
        }
    }
}
