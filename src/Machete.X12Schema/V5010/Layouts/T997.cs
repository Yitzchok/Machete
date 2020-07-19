﻿namespace Machete.X12Schema.V5010
{
    using X12;


    /// <summary>
    /// 997 Transaction
    /// </summary>
    public interface T997 :
        X12Layout
    {
        Segment<GS> FunctionalGroupHeader { get; }
        
        Segment<ST> TransactionSetHeader { get; }
        
        Segment<AK1> FunctionalGroupResponseHeader { get; }
        
        LayoutList<L2000_ACK997> TransactionSetResponseHeader { get; }
        
        Segment<AK9> FunctionalGroupResponseTrailer { get; }
        
        Segment<SE> TransactionSetTrailer { get; }
        
        Segment<GE> FunctionalGroupTrailer { get; }
    }
}