﻿using System;

namespace Magitek.Utilities.Routines
{
    internal static class Dancer
    {
        public static bool OnGcd => Spells.Cascade.Cooldown > Globals.AnimationLockTimespan;

    }
}