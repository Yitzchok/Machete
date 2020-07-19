// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RTB_K13_ROW_DEFINITION (GroupMap) - 
    /// </summary>
    public class RTB_K13_ROW_DEFINITIONMap :
        HL7V26LayoutMap<RTB_K13_ROW_DEFINITION>
    {
        public RTB_K13_ROW_DEFINITIONMap()
        {
            Segment(x => x.RDF, 0, x => x.Required = true);
            Segment(x => x.RDT, 1);
        }
    }
}