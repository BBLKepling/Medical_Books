using RimWorld;
using System.Collections.Generic;
using Verse.AI;
using Verse;
using System.Linq;

namespace Medical_Books
{
    public static class MedicalBooksUtility
    {
        private static readonly List<Thing> TmpCandidates = new List<Thing>();
        public static bool TryGetNovelToRead(Pawn pawn, out Book book)
        {
            book = null;
            TmpCandidates.Clear();
            TmpCandidates.AddRange(from thing in pawn.Map.listerThings.ThingsInGroup(ThingRequestGroup.Book)
                                   where IsValidBook(thing)
                                   select thing);
            TmpCandidates.AddRange(from thing in pawn.Map.listerThings.GetThingsOfType<Building_Bookcase>().SelectMany((Building_Bookcase x) => x.HeldBooks)
                                   where IsValidBook(thing)
                                   select thing);
            if (TmpCandidates.NullOrEmpty()) return false;
            book = (Book)TmpCandidates.RandomElement();
            TmpCandidates.Clear();
            return true;
            bool IsValidBook(Thing t)
            {
                return t is Book && !t.IsForbiddenHeld(pawn) && t.def == ThingDefOf.Novel && pawn.CanReserveAndReach(t, PathEndMode.Touch, Danger.None) && t.IsPoliticallyProper(pawn);
            }
        }
        public static float Knowledge(QualityCategory qc)
        {
            switch (qc)
            {
                case QualityCategory.Awful: return 0.001f;
                case QualityCategory.Poor: return 0.002f;
                case QualityCategory.Normal: return 0.003f;
                case QualityCategory.Good: return 0.004f;
                case QualityCategory.Excellent: return 0.005f;
                case QualityCategory.Masterwork: return 0.006f;
                case QualityCategory.Legendary: return 0.007f;
                default: return 0.001f;
            }
        }
    }
}
