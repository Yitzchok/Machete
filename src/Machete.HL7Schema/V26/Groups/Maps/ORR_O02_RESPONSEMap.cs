// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORR_O02_RESPONSE (GroupMap) - 
    /// </summary>
    public class ORR_O02_RESPONSEMap :
        HL7V26LayoutMap<ORR_O02_RESPONSE>
    {
        public ORR_O02_RESPONSEMap()
        {
            Layout(x => x.Patient, 0);
            Layout(x => x.Order, 1, x => x.Required = true);
        }
    }
}