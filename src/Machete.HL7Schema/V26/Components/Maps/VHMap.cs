// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VH (ComponentMap) - Visiting Hours
    /// </summary>
    public class VHMap :
        HL7V26ComponentMap<VH>
    {
        public VHMap()
        {
            Value(x => x.StartDayRange, 0);
            Value(x => x.EndDayRange, 1);
            Value(x => x.StartHourRange, 2, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.EndHourRange, 3, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
        }
    }
}