// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPT_PCL_PROBLEM_OBSERVATION (GroupMap) - 
    /// </summary>
    public class PPT_PCL_PROBLEM_OBSERVATIONMap :
        HL7V26LayoutMap<PPT_PCL_PROBLEM_OBSERVATION>
    {
        public PPT_PCL_PROBLEM_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}