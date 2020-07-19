// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDS_O13_ORDER (GroupMap) - 
    /// </summary>
    public class RDS_O13_ORDERMap :
        HL7V26LayoutMap<RDS_O13_ORDER>
    {
        public RDS_O13_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Layout(x => x.OrderDetail, 2);
            Layout(x => x.Encoding, 3);
            Segment(x => x.RXD, 4, x => x.Required = true);
            Segment(x => x.NTE, 5);
            Segment(x => x.RXR, 6, x => x.Required = true);
            Segment(x => x.RXC, 7);
            Layout(x => x.Observation, 8);
            Segment(x => x.FT1, 9);
        }
    }
}