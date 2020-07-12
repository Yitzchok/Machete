﻿namespace Machete.HL7
{
    using System;
    using System.Runtime.Serialization;


    [Serializable]
    public class SegmentOutOfRangeException :
        MacheteParserException
    {
        public SegmentOutOfRangeException()
        {
        }

        public SegmentOutOfRangeException(string message)
            : base(message)
        {
        }

        public SegmentOutOfRangeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}