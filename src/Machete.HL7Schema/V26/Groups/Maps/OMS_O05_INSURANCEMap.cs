// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMS_O05_INSURANCE (GroupMap) - 
    /// </summary>
    public class OMS_O05_INSURANCEMap :
        HL7V26LayoutMap<OMS_O05_INSURANCE>
    {
        public OMS_O05_INSURANCEMap()
        {
            Segment(x => x.IN1, 0, x => x.Required = true);
            Segment(x => x.IN2, 1);
            Segment(x => x.IN3, 2);
        }
    }
}