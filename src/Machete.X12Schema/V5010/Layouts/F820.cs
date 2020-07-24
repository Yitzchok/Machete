namespace Machete.X12Schema.V5010
{
    using X12;


    public interface F820 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T820> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}