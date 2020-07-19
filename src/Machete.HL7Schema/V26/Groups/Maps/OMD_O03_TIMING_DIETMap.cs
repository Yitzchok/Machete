// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMD_O03_TIMING_DIET (GroupMap) - 
    /// </summary>
    public class OMD_O03_TIMING_DIETMap :
        HL7V26LayoutMap<OMD_O03_TIMING_DIET>
    {
        public OMD_O03_TIMING_DIETMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segment(x => x.TQ2, 1);
        }
    }
}