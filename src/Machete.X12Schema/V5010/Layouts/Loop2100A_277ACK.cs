﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2100A_277ACK :
        X12Layout
    {
        Segment<NM1> InformationSourceName { get; }
    }
}