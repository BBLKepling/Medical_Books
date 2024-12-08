using RimWorld;
using System;

namespace Medical_Books
{
    public class BookOutcomeProperties_SurgicalBook : BookOutcomeProperties
    {
        public override Type DoerClass => typeof(ReadingOutcomeDoerSurgicalBook);
    }
}
