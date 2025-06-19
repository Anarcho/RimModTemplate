using RimModTemplate;
using RimWorld;
using Verse;

[DefOf]
public static class RimModTemplateDefOf
{
    // DefOfs are used to reference Defs without needing to use strings, which helps avoid typos and makes code cleaner.
    // Also useful for intellisense in IDEs.
    // Define any DefOfs here, for example:
    //public static ThingDef ExampleThingDef;

    // You can add more DefOfs as needed
    // Make sure to initialize them in a static constructor if necessary
    public static JobDef ExampleJobDef;
    public static IncidentDef ExampleIncidentDef;
    public static ExampleCustomDef ExampleCustomDef;

    static RimModTemplateDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(RimModTemplateDefOf));
    }
}