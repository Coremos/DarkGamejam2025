using System;

namespace Watermelon
{
    public enum EnvironmentPresetType
    {
        World1,
        World2,
        World3,
        Tent,
        Cave,
    }

    [Flags]
    public enum PartOfDay
    {
        Day = 1,
        Night = 2,
        Evening = 4,
        Morning = 8,
    }
}