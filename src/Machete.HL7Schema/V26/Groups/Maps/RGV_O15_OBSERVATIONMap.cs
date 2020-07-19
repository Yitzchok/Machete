// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGV_O15_OBSERVATION (GroupMap) - 
    /// </summary>
    public class RGV_O15_OBSERVATIONMap :
        HL7V26LayoutMap<RGV_O15_OBSERVATION>
    {
        public RGV_O15_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0);
            Segment(x => x.NTE, 1);
        }
    }
}