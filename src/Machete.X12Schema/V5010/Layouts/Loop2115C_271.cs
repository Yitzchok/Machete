﻿namespace Machete.X12Schema.V5010
{
    using X12;


    public interface Loop2115C_271 :
        X12Layout
    {
        Segment<EB> EligibilityOrBenefitAdditionalInformation { get; }
    }
}