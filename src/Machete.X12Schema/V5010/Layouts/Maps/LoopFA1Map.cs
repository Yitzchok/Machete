namespace Machete.X12Schema.V5010.Layouts.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopFA1Map :
        X12LayoutMap<LoopFA1, X12Entity>
    {
        public LoopFA1Map()
        {
            Id = "Loop_FA1";
            Name = "Loop FA1";
            
            Segment(x => x.TypeOfFinancialAccountingData, 0);
            Segment(x => x.AccountingData, 1, X => X.IsRequired());
        }
    }
}