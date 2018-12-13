﻿namespace CADKitElevationMarks.Contract
{
    public interface IElevationMarkFactory
    {
        IElevationMark GetElevationMark(ElevationMarkType type);
        IElevationMark GetElevationMark(ElevationMarkType type, IElevationMarkConfig config);
    }
}