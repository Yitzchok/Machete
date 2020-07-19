// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R23_CONTAINER (GroupMap) - 
    /// </summary>
    public class OUL_R23_CONTAINERMap :
        HL7V26LayoutMap<OUL_R23_CONTAINER>
    {
        public OUL_R23_CONTAINERMap()
        {
            Segment(x => x.SAC, 0, x => x.Required = true);
            Segment(x => x.INV, 1);
            Layout(x => x.Order, 2, x => x.Required = true);
        }
    }
}