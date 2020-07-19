// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAS_O17_ORDER_DETAIL_SUPPLEMENT (GroupMap) - 
    /// </summary>
    public class RAS_O17_ORDER_DETAIL_SUPPLEMENTMap :
        HL7V26LayoutMap<RAS_O17_ORDER_DETAIL_SUPPLEMENT>
    {
        public RAS_O17_ORDER_DETAIL_SUPPLEMENTMap()
        {
            Segment(x => x.NTE, 0, x => x.Required = true);
            Segment(x => x.RXR, 1, x => x.Required = true);
            Layout(x => x.Components, 2);
        }
    }
}