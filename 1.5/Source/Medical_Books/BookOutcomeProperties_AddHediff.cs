using RimWorld;
using System;
using Verse;

namespace Medical_Books
{
    public class BookOutcomeProperties_AddHediff : BookOutcomeProperties
    {
        public HediffDef hediffDef;
        public float severityGain;
        public string benefitsString;
        public override Type DoerClass => typeof(ReadingOutcomeDoerAddHediff);
    }
}
