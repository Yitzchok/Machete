﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2330A_837DMap :
        X12LayoutMap<Loop2330A_837D, X12Entity>
    {
        public L2330A_837DMap()
        {
            Id = "2330A";
            Name = "Other Subscriber Name";
            
            Segment(x => x.OtherSubscriber, 0, x => x.IsRequired());
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
            Segment(x => x.SecondaryIdentification, 3);
        }
    }
}