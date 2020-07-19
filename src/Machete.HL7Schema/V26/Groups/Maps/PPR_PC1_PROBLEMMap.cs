// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPR_PC1_PROBLEM (GroupMap) - 
    /// </summary>
    public class PPR_PC1_PROBLEMMap :
        HL7V26LayoutMap<PPR_PC1_PROBLEM>
    {
        public PPR_PC1_PROBLEMMap()
        {
            Segment(x => x.PRB, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.ProblemRole, 3);
            Layout(x => x.Pathway, 4);
            Layout(x => x.ProblemObservation, 5);
            Layout(x => x.Goal, 6);
            Layout(x => x.Order, 7);
        }
    }
}