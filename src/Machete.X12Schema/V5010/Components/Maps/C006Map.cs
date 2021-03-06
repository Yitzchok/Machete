﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class C006Map :
        X12ComponentMap<C006, X12Entity>
    {
        public C006Map()
        {
            Value(x => x.CavityDesignationCode1, 0, x => x.MinLength(1).MaxLength(3).IsRequired());
            Value(x => x.CavityDesignationCode2, 1, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CavityDesignationCode3, 2, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CavityDesignationCode4, 3, x => x.MinLength(1).MaxLength(3));
            Value(x => x.CavityDesignationCode5, 4, x => x.MinLength(1).MaxLength(3));
        }
    }
}