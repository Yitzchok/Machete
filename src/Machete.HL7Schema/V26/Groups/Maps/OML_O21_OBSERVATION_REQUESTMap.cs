// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OML_O21_OBSERVATION_REQUEST (GroupMap) - 
    /// </summary>
    public class OML_O21_OBSERVATION_REQUESTMap :
        HL7V26LayoutMap<OML_O21_OBSERVATION_REQUEST>
    {
        public OML_O21_OBSERVATION_REQUESTMap()
        {
            Segment(x => x.OBR, 0, x => x.Required = true);
            Segment(x => x.TCD, 1);
            Segment(x => x.NTE, 2);
            Segment(x => x.ROL, 3);
            Segment(x => x.CTD, 4);
            Segment(x => x.DG1, 5);
            Layout(x => x.Observation, 6);
            Layout(x => x.Specimen, 7);
            Layout(x => x.PriorResult, 8);
        }
    }
}