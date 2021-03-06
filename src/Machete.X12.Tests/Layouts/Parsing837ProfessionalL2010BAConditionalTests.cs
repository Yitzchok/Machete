namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Parsing837ProfessionalL2010BAConditionalTests :
        X12MacheteTestHarness<X12v5010, X12Entity>
    {
        [Test(Description = "Condition : SecondaryIdentification => SY, PropertyAndCasualtyClaimNumber => Y4")]
        public void Test1()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*KEY INSURANCE COMPANY*****46*999996666
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*2U*587654321
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
REF*Y4*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*587654321
REF*G2*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
CLM*26403774*200***11:B:1*Y**Y*I
DTP*472*D8*20061109
REF*D9*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";
 
            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transaction)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("SY", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.PropertyAndCasualtyClaimNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("Y4", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => SY, PropertyAndCasualtyClaimNumber => missing"), Explicit("Issue #65")]
        public void Test2()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*KEY INSURANCE COMPANY*****46*999996666
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*2U*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*SY*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
CLM*26403774*200***11:B:1*Y**Y*I
DTP*472*D8*20061109
REF*D9*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";
 
            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transaction)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsTrue(secondaryIdentification.HasValue);
            Assert.IsTrue(secondaryIdentification.IsPresent);
            Assert.AreEqual("SY", secondaryIdentification.ValueOrDefault());

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.PropertyAndCasualtyClaimNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
        [Test(Description = "Condition : SecondaryIdentification => missing, PropertyAndCasualtyClaimNumber => Y4")]
        public void Test3()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*KEY INSURANCE COMPANY*****46*999996666
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*2U*587654321
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
REF*Y4*587654321
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*587654321
REF*G2*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
CLM*26403774*200***11:B:1*Y**Y*I
DTP*472*D8*20061109
REF*D9*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";
 
            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transaction)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsFalse(secondaryIdentification.HasValue);
            Assert.IsFalse(secondaryIdentification.IsPresent);

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.PropertyAndCasualtyClaimNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsTrue(propertyAndCasualtyClaimNumber.IsPresent);
            Assert.AreEqual("Y4", propertyAndCasualtyClaimNumber.ValueOrDefault());
        }
        
        [Test(Description = "Condition : SecondaryIdentification => missing, PropertyAndCasualtyClaimNumber => missing")]
        public void Test4()
        {
            string message =
                @"ISA*00*          *00*          *ZZ*EMEDNYBAT      *ZZ*00DJ           *180625*0712*^*00501*176073292*0*P*:
GS*HP*EMEDNYBAT*00DJ*20180625*07121200*176073292*X*005010X221A1
ST*837*0002*005010X224A3
BHT*0019*00*0123*20061123*1023*CH
NM1*41*2*PREMIER BILLING SERVICE*****46*567890
PER*IC*JERRY*TE*7176149999
NM1*40*2*KEY INSURANCE COMPANY*****46*999996666
HL*1**20*1
NM1*85*2*DENTAL ASSOCIATES*****XX*4567890123
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*SY*587654321
REF*1G*587654321
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
N3*234 SEAWAY ST
N4*MIAMI*FL*33111
REF*2U*587654321
REF*EIB*587654321
HL*2*1*22*1
SBR*P********CI
NM1*IL*1*SMITH*JANE****MI*JS00111223333
NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666
REF*2U*587654321
REF*G2*587654321
HL*3*2*23*0
PAT*19
NM1*QC*1*SMITH*TED
N3*236 N MAIN ST
N4*MIAMI*FL*33413
DMG*D8*19920501*M
REF*Y4*587654321
REF*1W*587654321
CLM*26403774*200***11:B:1*Y**Y*I
DTP*472*D8*20061109
REF*D9*111222333444
NM1*82*1*KILDARE*BEN****XX*6789012345
PRV*PE*PXC*1223P0221X
LX*1
SV3*AD:D3320*200****1
TOO*JP*5
SE*29*0002
IEA*1*176073292";
 
            var entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837P, X12Entity> layout));

            var query = entityResult.CreateQuery(layout);

            var queryResult = entityResult.Query(query);

            Assume.That(queryResult != null);
            Assume.That(queryResult.HasResult);
            
            var transactions = queryResult.Select(x => x.Transaction)[0];
            
            Assume.That(transactions != null);
            Assume.That(transactions.HasValue);

            var secondaryIdentification = transactions
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.SecondaryIdentification)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(secondaryIdentification != null);
            Assert.IsFalse(secondaryIdentification.HasValue);
            Assert.IsFalse(secondaryIdentification.IsPresent);

            var propertyAndCasualtyClaimNumber = transactions
                .Select(x => x.Loop2000B)[0]
                .Select(x => x.Loop2010BA)
                .Select(x => x.PropertyAndCasualtyClaimNumber)
                .Select(x => x.ReferenceIdentificationQualifier);
            
            Assume.That(propertyAndCasualtyClaimNumber != null);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.HasValue);
            Assert.IsFalse(propertyAndCasualtyClaimNumber.IsPresent);
        }
        
    }
}