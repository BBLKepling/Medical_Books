using RimWorld;
using System;
using Verse;

namespace Medical_Books
{
    public class BookOutcomeProperties_AddHediff : BookOutcomeProperties
    {
        public HediffDef hediffDef;
        public override Type DoerClass => typeof(ReadingOutcomeDoerAddHediff);
    }
}
