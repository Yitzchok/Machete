// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRD_O14_DISPENSE (GroupMap) - 
    /// </summary>
    public class RRD_O14_DISPENSEMap :
        HL7V26LayoutMap<RRD_O14_DISPENSE>
    {
        public RRD_O14_DISPENSEMap()
        {
            Segment(x => x.RXD, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.RXR, 2, x => x.Required = true);
            Segment(x => x.RXC, 3);
        }
    }
}