// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O35_INSURANCE (GroupMap) - 
    /// </summary>
    public class OML_O35_INSURANCEMap :
        HL7V26LayoutMap<OML_O35_INSURANCE>
    {
        public OML_O35_INSURANCEMap()
        {
            Segment(x => x.IN1, 0, x => x.Required = true);
            Segment(x => x.IN2, 1);
            Segment(x => x.IN3, 2);
        }
    }
}