using RimWorld;
using System.Collections.Generic;
using Verse;
using Verse.AI;

namespace Medical_Books
{
    public class JobDriver_PatientListen : JobDriver_LayDownAwake
    {
        public override bool LookForOtherJobs => false;
        private Pawn Reader => (Pawn)job.GetTarget(TargetIndex.B).Thing;
        protected override IEnumerable<Toil> MakeNewToils()
        {
            AddFailCondition(() => Reader.CurJob.def != MedicalBooksDefOf.BBLK_Job_PatientStory);
            foreach (Toil toil in base.MakeNewToils())
            {
                yield return toil;
            }
        }
        public override string GetReport()
        {
            return "BBLK_MedicalBooks_Listen".Translate(Reader.Named("PAWN"));
        }
    }
}
