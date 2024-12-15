using RimWorld;
using Verse;

namespace Medical_Books
{
    public class ReadingOutcomeDoerAddHediff : BookOutcomeDoer
    {
        public new BookOutcomeProperties_AddHediff Props => (BookOutcomeProperties_AddHediff)props;
        public override bool DoesProvidesOutcome(Pawn reader)
        {
            return true;
        }
        public override void OnReadingTick(Pawn reader, float factor)
        {
            if (Find.TickManager.TicksGame % 60 != 0 || !(reader.health is Pawn_HealthTracker health)) return;
            if (!health.hediffSet.TryGetHediff(Props.hediffDef, out Hediff hediff))
            {
                health.AddHediff(Props.hediffDef);
                return;
            }
            hediff.Severity += MedicalBooksUtility.Knowledge(Quality);
        }
        public override string GetBenefitsString(Pawn reader = null)
        {
            return string.Format(" - {0}: +{1}% {2}", "BBLK_BirthBook_Quality".Translate(), MedicalBooksUtility.Knowledge(Quality) * 100f, "BBLK_Knowledge_PerSec".Translate());
        }
    }
}
