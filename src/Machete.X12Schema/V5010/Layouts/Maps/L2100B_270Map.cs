﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2100B_270Map :
        X12LayoutMap<L2100B_270, X12Entity>
    {
        public L2100B_270Map()
        {
            Id = "2100B";
            Name = "Information Receiver Name";
            
            Segment(x => x.InformationReceiver, 0, x => x.IsRequired());
            Segment(x => x.AdditionalIdentification, 1);
            Segment(x => x.Address, 2);
            Segment(x => x.GeographicInformation, 3);
            Segment(x => x.ProviderInformation, 4);
        }
    }
}