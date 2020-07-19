// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BAR_P01_PROCEDURE (GroupMap) - 
    /// </summary>
    public class BAR_P01_PROCEDUREMap :
        HL7V26LayoutMap<BAR_P01_PROCEDURE>
    {
        public BAR_P01_PROCEDUREMap()
        {
            Segment(x => x.PR1, 0, x => x.Required = true);
            Segment(x => x.ROL, 1);
        }
    }
}