﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2310E_837DMap :
        X12LayoutMap<L2310E_837D, X12Entity>
    {
        public L2310E_837DMap()
        {
            Id = "2310E";
            Name = "Supervising Provider Name";
            
            Segment(x => x.Name, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}