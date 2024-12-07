using RimWorld;
using Verse;

namespace Medical_Books
{
    public class ReadingOutcomeDoerSurgicalBook : BookOutcomeDoer
    {
        public new BookOutcomeProperties_SurgicalBook Props => (BookOutcomeProperties_SurgicalBook)props;
        public override bool DoesProvidesOutcome(Pawn reader)
        {
            return true;
        }
        public override void OnReadingTick(Pawn reader, float factor)
        {
            if (Find.TickManager.TicksGame % 60 != 0 || !(reader.health is Pawn_HealthTracker health)) return;
            if (!health.hediffSet.TryGetHediff(MedicalBooksDefOf.BBLK_SurgicalBook_Knowledge, out Hediff hediff))
            {
                health.AddHediff(MedicalBooksDefOf.BBLK_SurgicalBook_Knowledge);
                return;
            }
            hediff.Severity += MedicalBooksUtility.Knowledge(Quality);
            //could just be
            //hediff.Severity += 0.001f * (int)Quality;
        }
        public override string GetBenefitsString(Pawn reader = null)
        {
            return string.Format(" - {0}: +{1}", "BBLK_SurgicalBook_Quality".Translate(), MedicalBooksUtility.Knowledge(Quality));
        }
    }
}
