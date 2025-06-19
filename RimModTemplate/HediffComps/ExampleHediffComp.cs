using Verse;

namespace RimModTemplate
{
    public class HediffCompProperties_ExampleHediffComp : HediffCompProperties
    {
        public string exampleProperty;

        public HediffCompProperties_ExampleHediffComp()
        {
            this.compClass = typeof(HediffComp_ExampleHediffComp);
        }
    }

    public class HediffComp_ExampleHediffComp : HediffComp
    {
        public HediffCompProperties_ExampleHediffComp Props => (HediffCompProperties_ExampleHediffComp)this.props;

        public override void CompPostMake()
        {
            base.CompPostMake();
            Log.Message("HediffComp_ExampleHediffComp created.");
        }

        public override void CompPostTick(ref float severityAdjustment)
        {
            base.CompPostTick(ref severityAdjustment);
            // Example logic for what happens each tick
            Log.Message("HediffComp_ExampleHediffComp ticking.");
        }
        public override void CompExposeData()
        {
            base.CompExposeData();
            // Example of saving/loading data
            Scribe_Values.Look(ref Props.exampleProperty, "exampleProperty", "default value");
        }


        public override string CompDebugString()
        {
            // This method returns a debug string for the hediff component
            return "HediffComp_ExampleHediffComp Debug Info";
        }
    }
}