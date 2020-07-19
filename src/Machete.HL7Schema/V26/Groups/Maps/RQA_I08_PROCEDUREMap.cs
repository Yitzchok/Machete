// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQA_I08_PROCEDURE (GroupMap) - 
    /// </summary>
    public class RQA_I08_PROCEDUREMap :
        HL7V26LayoutMap<RQA_I08_PROCEDURE>
    {
        public RQA_I08_PROCEDUREMap()
        {
            Segment(x => x.PR1, 0, x => x.Required = true);
            Layout(x => x.Authorization, 1);
        }
    }
}