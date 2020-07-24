namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class T837DMap :
        X12LayoutMap<T837D, X12Entity>
    {
        public T837DMap()
        {
            Id = "837I";
            Name = "837D Transaction";
            
            Segment(x => x.FunctionalGroupHeader, 0);
            Segment(x => x.TransactionSetHeader, 1, x => x.IsRequired());
            Segment(x => x.BeginningOfHierarchicalTransaction, 2, x => x.IsRequired());
            Layout(x => x.Loop1000A, 3);
            Layout(x => x.Loop1000B, 4);
            Layout(x => x.Loop2000A, 5);
            Layout(x => x.Loop1000B, 6);
            Layout(x => x.Loop2000B, 7);
            Layout(x => x.Loop2000C, 8);
            Segment(x => x.TransactionSetTrailer, 9);
            Segment(x => x.FunctionalGroupTrailer, 10);
        }
    }
}