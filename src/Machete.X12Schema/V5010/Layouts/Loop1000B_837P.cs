﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop1000B_837P :
        X12Layout
    {
        Segment<NM1> Receiver { get; }
    }
}