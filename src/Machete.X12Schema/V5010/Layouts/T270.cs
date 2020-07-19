﻿namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 270 Transaction
    /// </summary>
    public interface T270 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<BHT> BeginningOfHeirarchicalTransaction { get; }
        
        LayoutList<L2000A_270> InformationSourceDetail { get; }
        
        LayoutList<L2000B_270> InformationReceiverDetail { get; }
        
        LayoutList<L2000C_270> SubscriberDetail { get; }
        
        LayoutList<L2000D_270> DependentDetail { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}