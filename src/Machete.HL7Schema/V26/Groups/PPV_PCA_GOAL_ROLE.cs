// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPV_PCA_GOAL_ROLE (Group) - 
    /// </summary>
    public interface PPV_PCA_GOAL_ROLE :
        HL7V26Layout
    {
        /// <summary>
        /// ROL
        /// </summary>
        Segment<ROL> ROL { get; }

        /// <summary>
        /// VAR
        /// </summary>
        SegmentList<VAR> VAR { get; }
    }
}