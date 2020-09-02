namespace Machete.X12Schema.V5010
{
    using X12;


    public interface I310 :
        X12Layout
    {
        Segment<ISA> InterchangeControlHeader { get; }
        
        LayoutList<T310> Transaction { get; }
        
        Segment<IEA> InterchangeControlTrailer { get; }
    }
}