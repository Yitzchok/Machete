﻿namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 271 Transaction
    /// </summary>
    public interface T271 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHeirarchicalTransaction { get; }
        
        LayoutList<L2000A_271> InformationSourceDetail { get; }
        
        LayoutList<L2000B_271> InformationReceiverDetail { get; }
        
        LayoutList<L2000C_271> SubscriberDetail { get; }
        
        LayoutList<L2000D_271> DependentDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}