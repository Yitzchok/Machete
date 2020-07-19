// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QBP_Q11 (MessageMap) - 
    /// </summary>
    public class QBP_Q11Map :
        HL7V26LayoutMap<QBP_Q11>
    {
        public QBP_Q11Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.QPD, 3, x => x.Required = true);
            Segment(x => x.RCP, 4, x => x.Required = true);
            Segment(x => x.DSC, 5);
        }
    }
}