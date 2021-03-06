namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class I210Map :
        X12LayoutMap<I210, X12Entity>
    {
        public I210Map()
        {
            Id = "I210";
            Name = "210 Motor Carrier Freight Details and Invoice";

            Segment(x => x.InterchangeControlHeader, 0);
            Layout(x => x.Transaction, 1);
            Segment(x => x.InterchangeControlTrailer, 2);
        }
    }
}