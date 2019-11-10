﻿using CADKit.Contracts;
using CADKit.Contracts.Entities;
using CADKitElevationMarks.Contracts;

namespace CADKitElevationMarks.Models
{
    public class ElevationMarkConfig : IElevationMarkConfig
    {
        public string Layer { get; set; }
        public IEntityText Sign { get; set; }
        public IEntityText Text { get; set; }
        public IEntityPline Pline { get; set; }
        public IEntityHatch Hatch { get; set; }
        public IEntityPoint Point { get; set; }

        public ElevationMarkConfig()
        {
            // Create fields and read default value from AppSettings
        }

    }
}