using Verse;

namespace RimModTemplate
{
    // This class defines a custom Def for the mod.
    // Defs are used to define various game elements like items, buildings, etc.
    // You can add properties to this class to customize the behavior of your Def.
    public class ExampleCustomDef : Def
    {
        public string customProperty1;
        public string customProperty2;

        public override void PostLoad()
        {
            base.PostLoad();
            Log.Message($"ExampleCustomDef loaded with properties: {customProperty1}, {customProperty2}");
        }
    }
}