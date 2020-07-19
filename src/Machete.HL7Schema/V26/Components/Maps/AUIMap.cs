// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// AUI (ComponentMap) - Authorization Information
    /// </summary>
    public class AUIMap :
        HL7V26ComponentMap<AUI>
    {
        public AUIMap()
        {
            Value(x => x.AuthorizationNumber, 0);
            Value(x => x.Date, 1, x => {x.Converter = HL7.HL7ValueConverters.VariableLongDateTime;});
            Value(x => x.Source, 2);
        }
    }
}