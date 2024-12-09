using RimWorld;
using Verse;

namespace Medical_Books
{
    [DefOf]
    public class MedicalBooksDefOf
    {
        static MedicalBooksDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MedicalBooksDefOf));
        }
        public static HediffDef BBLK_FirstAidBook_Knowledge;
        public static HediffDef BBLK_SurgicalBook_Knowledge;
        public static InteractionDef BBLK_PatientStory;
        public static JobDef BBLK_Job_PatientListen;
        public static JobDef BBLK_Job_PatientStory;
        public static TaleDef BBLK_PatientStory_Tale;
    }
}
