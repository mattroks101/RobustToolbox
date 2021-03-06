﻿using Robust.Client.State.States;
using Robust.Shared.Enums;
using Robust.Shared.GameObjects;
using Robust.Shared.Input;
using Robust.Shared.Interfaces.GameObjects;
using Robust.Shared.Interfaces.GameObjects.Components;
using Robust.Shared.Map;
using Robust.Shared.Maths;

namespace Robust.Client.Interfaces.GameObjects.Components
{
    public interface IClientClickableComponent : IClickableComponent
    {
        /// <summary>
        /// Used to check whether a click worked.
        /// </summary>
        /// <param name="worldPos">The world position that was clicked.</param>
        /// <param name="drawdepth">
        /// The draw depth for the sprite that captured the click.
        /// Used by <see cref="GameScreen" /> to sort and pick the highest successful one when multiple overlapping entities passed.
        /// </param>
        /// <returns>True if the click worked, false otherwise.</returns>
        bool CheckClick(Vector2 worldPos, out int drawdepth);
    }
}
