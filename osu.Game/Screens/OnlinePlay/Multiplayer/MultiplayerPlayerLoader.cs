// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Framework.Screens;
using osu.Game.Screens.Play;

namespace osu.Game.Screens.OnlinePlay.Multiplayer
{
    public class MultiplayerPlayerLoader : PlayerLoader
    {
        public bool GameplayPassed => player?.GameplayState.HasPassed == true;

        private Player player;

        public MultiplayerPlayerLoader(Func<Player> createPlayer)
            : base(createPlayer)
        {
        }

        public override void OnSuspending(ScreenTransitionEvent e)
        {
            base.OnSuspending(e);
            player = (Player)e.Next;
        }
    }
}
