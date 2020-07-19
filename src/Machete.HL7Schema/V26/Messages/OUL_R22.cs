// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OUL_R22 (Message) - 
    /// </summary>
    public interface OUL_R22 :
        HL7V26Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// SFT
        /// </summary>
        SegmentList<SFT> SFT { get; }

        /// <summary>
        /// UAC
        /// </summary>
        Segment<UAC> UAC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        Segment<NTE> NTE { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        Layout<OUL_R22_PATIENT> Patient { get; }

        /// <summary>
        /// NK1
        /// </summary>
        SegmentList<NK1> NK1 { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        LayoutList<OUL_R22_SPECIMEN> Specimen { get; }

        /// <summary>
        /// DSC
        /// </summary>
        Segment<DSC> DSC { get; }
    }
}