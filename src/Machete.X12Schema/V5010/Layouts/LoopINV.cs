namespace Machete.X12Schema.V5010
{
    using X12;


    public interface LoopINV :
        X12Layout
    {
        Segment<INV> InvestmentVehicleSelection { get; }
        
        Segment<DTP> DateOrTimeReference { get; }
    }
}