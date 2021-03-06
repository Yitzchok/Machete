namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class LoopSAC_1_850Map :
        X12LayoutMap<LoopSAC_1_850, X12Entity>
    {
        public LoopSAC_1_850Map()
        {
            Id = "Loop_SAC_1_850";
            Name = "Loop SAC";
            
            Segment(x => x.ServicePromotionAllowanceOrChargeInformation, 0);
            Segment(x => x.Currency, 1);
        }
    }
}