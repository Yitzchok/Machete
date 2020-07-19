// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPR_I03_PROVIDER (GroupMap) - 
    /// </summary>
    public class RPR_I03_PROVIDERMap :
        HL7V26LayoutMap<RPR_I03_PROVIDER>
    {
        public RPR_I03_PROVIDERMap()
        {
            Segment(x => x.PRD, 0, x => x.Required = true);
            Segment(x => x.CTD, 1);
        }
    }
}