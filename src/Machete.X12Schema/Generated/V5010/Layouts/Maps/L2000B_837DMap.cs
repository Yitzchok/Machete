﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2000B_837DMap :
        X12LayoutMap<L2000B_837D, X12Entity>
    {
        public L2000B_837DMap()
        {
            Id = "2000B";
            Name = "Subscriber Heirarchical Level";
            
            Segment(x => x.SubscriberHierarchicalLevel, 0, x => x.IsRequired());
            Segment(x => x.SubscriberInformation, 1, x => x.IsRequired());
            Layout(x => x.Subscriber, 3);
            Layout(x => x.Payer, 4);
        }
    }
}