﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class Loop2010AB_837DMap :
        X12LayoutMap<Loop2010AB_837D, X12Entity>
    {
        public Loop2010AB_837DMap()
        {
            Id = "Loop_2010AB_837D";
            Name = "Pay-to Address Name";
            
            Segment(x => x.PayToAddressName, 0);
            Segment(x => x.Address, 1);
            Segment(x => x.GeographicInformation, 2);
        }
    }
}