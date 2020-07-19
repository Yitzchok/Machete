// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PGL_PC6_GOAL (GroupMap) - 
    /// </summary>
    public class PGL_PC6_GOALMap :
        HL7V26LayoutMap<PGL_PC6_GOAL>
    {
        public PGL_PC6_GOALMap()
        {
            Segment(x => x.GOL, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.GoalRole, 3);
            Layout(x => x.Pathway, 4);
            Layout(x => x.Observation, 5);
            Layout(x => x.Problem, 6);
            Layout(x => x.Order, 7);
        }
    }
}