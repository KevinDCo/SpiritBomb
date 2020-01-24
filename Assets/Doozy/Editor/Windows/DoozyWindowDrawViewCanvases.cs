// Copyright (c) 2015 - 2019 Doozy Entertainment / Marlink Trading SRL. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

using Doozy.Engine.Utils;
using Doozy.Engine.UI.Base;
using Doozy.Engine.UI.Settings;
using UnityEngine;

namespace Doozy.Editor.Windows
{
    public partial class DoozyWindow
    {
        private static NamesDatabase UICanvasDatabase { get { return UICanvasSettings.Database; } }

        private void InitViewCanvases() { }

        private void DrawViewCanvases()
        {
            if (CurrentView != View.Canvases) return;
            DrawItemsDatabase(UICanvasDatabase, true, View.Canvases);
            
            DrawDynamicViewVerticalSpace(2);
        }
    }
}