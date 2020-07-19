// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRG_O16_TIMING_GIVE (GroupMap) - 
    /// </summary>
    public class RRG_O16_TIMING_GIVEMap :
        HL7V26LayoutMap<RRG_O16_TIMING_GIVE>
    {
        public RRG_O16_TIMING_GIVEMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segment(x => x.TQ2, 1);
        }
    }
}