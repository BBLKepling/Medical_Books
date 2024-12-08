using RimWorld;
using Verse;

namespace Medical_Books
{
    public class ReadingOutcomeDoerFirstAidBook : BookOutcomeDoer
    {
        public new BookOutcomeProperties_FirstAidBook Props => (BookOutcomeProperties_FirstAidBook)props;
        public override bool DoesProvidesOutcome(Pawn reader)
        {
            return true;
        }
        public override void OnReadingTick(Pawn reader, float factor)
        {
            if (Find.TickManager.TicksGame % 60 != 0 || !(reader.health is Pawn_HealthTracker health)) return;
            if (!health.hediffSet.TryGetHediff(MedicalBooksDefOf.BBLK_FirstAidBook_Knowledge, out Hediff hediff))
            {
                health.AddHediff(MedicalBooksDefOf.BBLK_FirstAidBook_Knowledge);
                return;
            }
            hediff.Severity += MedicalBooksUtility.Knowledge(Quality);
        }
        public override string GetBenefitsString(Pawn reader = null)
        {
            return string.Format(" - {0}: +{1}", "BBLK_FirstAidBook_Quality".Translate(), MedicalBooksUtility.Knowledge(Quality));
        }
    }
}
