﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface L2100A_270 :
        X12Layout
    {
        Segment<NM1> InformationSource { get; }
    }
}