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
    }
}
