// Build: 5620ae0ffdfd630b6cd15b65036b8f36
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
