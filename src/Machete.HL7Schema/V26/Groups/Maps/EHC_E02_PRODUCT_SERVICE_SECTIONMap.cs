// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E02_PRODUCT_SERVICE_SECTION (GroupMap) - 
    /// </summary>
    public class EHC_E02_PRODUCT_SERVICE_SECTIONMap :
        HL7V26LayoutMap<EHC_E02_PRODUCT_SERVICE_SECTION>
    {
        public EHC_E02_PRODUCT_SERVICE_SECTIONMap()
        {
            Segment(x => x.PSS, 0, x => x.Required = true);
            Layout(x => x.Psg, 1);
        }
    }
}