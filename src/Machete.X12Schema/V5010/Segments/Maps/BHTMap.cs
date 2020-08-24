namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class BHTMap :
        X12SegmentMap<BHT, X12Entity>
    {
        public BHTMap()
        {
            Id = "BHT";
            Name = "Begin Hierarchical Transaction";
            
            Value(x => x.HierarchicalStructureCode, 1, x => x.FixedLength(4).IsRequired());
            Value(x => x.TransactionSetPurposeCode, 2, x => x.FixedLength(2).IsRequired());
            Value(x => x.ReferenceIdentification, 3, x => x.MinLength(1).MaxLength(30));
            Value(x => x.Date, 4, x =>
            {
                x.FixedLength(8);
                x.IsRequired();
            });
            Value(x => x.Time, 5, x =>
            {
                x.MinLength(4);
                x.MaxLength(8);
                x.IsRequired();
            });
            Value(x => x.TransactionTypeCode, 6, x => x.FixedLength(2));
        }
    }
}