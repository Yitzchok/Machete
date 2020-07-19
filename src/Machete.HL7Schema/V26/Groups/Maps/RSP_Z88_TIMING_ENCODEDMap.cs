// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z88_TIMING_ENCODED (GroupMap) - 
    /// </summary>
    public class RSP_Z88_TIMING_ENCODEDMap :
        HL7V26LayoutMap<RSP_Z88_TIMING_ENCODED>
    {
        public RSP_Z88_TIMING_ENCODEDMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segment(x => x.TQ2, 1);
        }
    }
}