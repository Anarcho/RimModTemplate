using Verse;
using RimWorld;

namespace RimModTemplate
{
    public class IncidentWorker_ExampleIncidentWorker : IncidentWorker
    {
        protected override bool CanFireNowSub(IncidentParms parms)
        {
            // Example logic to determine if the incident can fire
            return true; // Change this condition as needed
        }

        protected override bool TryExecuteWorker(IncidentParms parms)
        {
            // Example logic for what happens when the incident is executed
            Log.Message("ExampleIncidentWorker executed.");
            return true; // Return true if the incident was successfully executed
        }
    }
}