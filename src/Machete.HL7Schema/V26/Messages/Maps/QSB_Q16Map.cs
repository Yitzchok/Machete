// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// QSB_Q16 (MessageMap) - 
    /// </summary>
    public class QSB_Q16Map :
        HL7V26LayoutMap<QSB_Q16>
    {
        public QSB_Q16Map()
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