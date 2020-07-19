// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMD_O03_ORDER_TRAY (GroupMap) - 
    /// </summary>
    public class OMD_O03_ORDER_TRAYMap :
        HL7V26LayoutMap<OMD_O03_ORDER_TRAY>
    {
        public OMD_O03_ORDER_TRAYMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.TimingTray, 1);
            Segment(x => x.ODT, 2, x => x.Required = true);
            Segment(x => x.NTE, 3);
        }
    }
}