namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopFA1_850Map :
        X12LayoutMap<LoopFA1_850, X12Entity>
    {
        public LoopFA1_850Map()
        {
            Id = "Loop_FA1_850";
            Name = "Loop FA1";
            
            Segment(x => x.TypeOfFinancialAccountingData, 0);
            Segment(x => x.AccountingData, 1, X => X.IsRequired());
        }
    }
}