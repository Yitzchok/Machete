// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRD_O14_ORDER (GroupMap) - 
    /// </summary>
    public class RRD_O14_ORDERMap :
        HL7V26LayoutMap<RRD_O14_ORDER>
    {
        public RRD_O14_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Layout(x => x.Dispense, 2);
        }
    }
}