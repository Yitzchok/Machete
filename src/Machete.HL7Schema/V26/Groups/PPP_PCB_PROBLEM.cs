// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// PPP_PCB_PROBLEM (Group) - 
    /// </summary>
    public interface PPP_PCB_PROBLEM :
        HL7V26Layout
    {
        /// <summary>
        /// PRB
        /// </summary>
        Segment<PRB> PRB { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// VAR
        /// </summary>
        SegmentList<VAR> VAR { get; }

        /// <summary>
        /// PROBLEM_ROLE
        /// </summary>
        LayoutList<PPP_PCB_PROBLEM_ROLE> ProblemRole { get; }

        /// <summary>
        /// PROBLEM_OBSERVATION
        /// </summary>
        LayoutList<PPP_PCB_PROBLEM_OBSERVATION> ProblemObservation { get; }

        /// <summary>
        /// GOAL
        /// </summary>
        LayoutList<PPP_PCB_GOAL> Goal { get; }

        /// <summary>
        /// ORDER
        /// </summary>
        LayoutList<PPP_PCB_ORDER> Order { get; }
    }
}