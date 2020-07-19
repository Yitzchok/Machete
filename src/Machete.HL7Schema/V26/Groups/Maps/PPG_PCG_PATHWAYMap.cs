// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPG_PCG_PATHWAY (GroupMap) - 
    /// </summary>
    public class PPG_PCG_PATHWAYMap :
        HL7V26LayoutMap<PPG_PCG_PATHWAY>
    {
        public PPG_PCG_PATHWAYMap()
        {
            Segment(x => x.PTH, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.VAR, 2);
            Layout(x => x.PathwayRole, 3);
            Layout(x => x.Goal, 4);
        }
    }
}