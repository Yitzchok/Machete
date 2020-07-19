// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M02_MF_STAFF (GroupMap) - 
    /// </summary>
    public class MFN_M02_MF_STAFFMap :
        HL7V26LayoutMap<MFN_M02_MF_STAFF>
    {
        public MFN_M02_MF_STAFFMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.STF, 1, x => x.Required = true);
            Segment(x => x.PRA, 2);
            Segment(x => x.ORG, 3);
            Segment(x => x.AFF, 4);
            Segment(x => x.LAN, 5);
            Segment(x => x.EDU, 6);
            Segment(x => x.CER, 7);
            Segment(x => x.NTE, 8);
        }
    }
}