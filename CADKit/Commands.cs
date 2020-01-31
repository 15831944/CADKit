﻿using CADKit.Proxy;
using CADKit.Runtime;

namespace CADKit
{
    public static class Commands
    {
        [CommandMethod("CK_FLIPPALETE")]
        public static void FlipPalette()
        {

            if (AppSettings.Get.CADKitPalette != null)
            {
                AppSettings.Get.CADKitPalette.Visible = !AppSettings.Get.CADKitPalette.Visible;
            }
            else
            {
                CADProxy.Editor.WriteMessage("\nPaleta nie zainicjalizowana\n");
            }
        }
    }
}
