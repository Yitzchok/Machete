// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SQM_S25_PERSONNEL_RESOURCE (Group) - 
    /// </summary>
    public interface SQM_S25_PERSONNEL_RESOURCE :
        HL7V26Layout
    {
        /// <summary>
        /// AIP
        /// </summary>
        Segment<AIP> AIP { get; }

        /// <summary>
        /// APR
        /// </summary>
        Segment<APR> APR { get; }
    }
}