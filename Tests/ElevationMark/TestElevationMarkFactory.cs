﻿using CADKit.Contracts;
using CADKit.Models;
using CADKit.Services;
using CADKitElevationMarks.Contracts;
using CADKitElevationMarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.ElevationMark
{
    public class TestElevationMarkFactory
    {
        [Fact]
        public void CreatElevationMarkFatoryReturnPNB01025Factory()
        {
            // Arrange
            // IElevationMark elevationMark = new ElevationMarkFactoryPNB01025().CreateArchitecturalElevationMark(new ElevationValue(), new ElevationMarkConfig());
            // Act
            // Assert
            // Assert.NotNull(elevationMark as ArchitecturalElevationMarkPNB01025);
        }
    }
}