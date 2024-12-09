using RimWorld;
using System.Collections.Generic;
using Verse.AI;
using Verse;
using System.Linq;

namespace Medical_Books
{
    public static class MedicalBooksUtility
    {
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
