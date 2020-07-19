// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQA_I08_OBSERVATION (GroupMap) - 
    /// </summary>
    public class RQA_I08_OBSERVATIONMap :
        HL7V26LayoutMap<RQA_I08_OBSERVATION>
    {
        public RQA_I08_OBSERVATIONMap()
        {
            Segment(x => x.OBR, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Layout(x => x.Results, 2);
        }
    }
}