using System;
using Verse;
using UnityEngine;

namespace RimModTemplate
{
    public class RimModTemplate : Mod
    {
        public RimModTemplate(ModContentPack content) : base(content)
        {
            // Initialization code can go here
            Log.Message("RimModTemplate initialized successfully.");
        }

        public override void DoSettingsWindowContents(Rect rect)
        {
            // Code to draw settings window contents can go here
            base.DoSettingsWindowContents(rect);
        }

        public override string SettingsCategory()
        {
            // This method returns the name of the settings category for this mod
            return "RimModTemplate Settings";
        }
    }
}