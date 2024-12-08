using RimWorld;
using System;

namespace Medical_Books
{
    public class BookOutcomeProperties_FirstAidBook : BookOutcomeProperties
    {
        public override Type DoerClass => typeof(ReadingOutcomeDoerFirstAidBook);
    }
}
