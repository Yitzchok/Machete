﻿namespace Machete.X12.Tests.Layouts
{
    using NUnit.Framework;
    using Testing;
    using X12Schema.V5010;


    [TestFixture]
    public class Layout837Tests :
        X12MacheteTestHarness<X12v5010, X12Entity>
    {
        [Test]
        public void Verify_can_parse_837_Institutional()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
BHT*0019*00*0123*19960918*0932*CH
NM1*41*2*JONES HOSPITAL*Joe****46*12345
PER*IC*JANE DOE*TE*9005555555
NM1*40*2*MEDICARE*****46*00120
HL*1**20*1
PRV*BI*PXC*203BA0200N
NM1*85*2*JONES HOSPITAL*****XX*9876540809
N3*225 MAIN STREET BARKLEY BUILDING
N4*CENTERVILLE*PA*17111
REF*EI*567891234
HL*2*1*22*0
SBR*P*18*******MB
NM1*IL*1*DOE*JOHN*T***MI*030005074A
N3*125 CITY AVENUE
N4*CENTERVILLE*PA*17111
DMG*D8*19261111*M
NM1*PR*2*MEDICARE B*****PI*00435
REF*G2*330127
CLM*756048Q*89.93***14:A:1*Y*A*Y*Y
DTP*434*D8*19960911
CL1*3**01
HI*BK:3669
HI*BF:4019*BF:79431
HI*BH:A1:D8:19261111*BH:A2:D8:19911101*BH:B1:D8:19261111*BH:B2:D8:19870101
HI*BE:A2:::15.31
HI*BG:09
NM1*71*1*JONES*JOHN*J
REF*1G*B99937
SBR*S*01*351630*STATE TEACHERS*****CI
DMG*D8*19271211*F
OI***Y***Y
NM1*IL*1*DOE*JANE*S***MI*222004433
N3*125 CITY AVENUE
N4*CENTERVILLE*PA*17111
NM1*PR*2*STATE TEACHERS*****PI*1135
LX*1
SV2*0305*HC:85025*13.39*UN*1
DTP*472*D8*19960911
LX*2
SV2*0730*HC:93005*76.54*UN*3
DTP*472*D8*19960911
SE*43*987654
GE*1*1
IEA*1*000026531";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837I, X12Entity> layout));

            IParser<X12Entity, HC837I> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HC837I> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result.Select(x => x.Transactions)[0].Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0].Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            string firstName = result.Select(x => x.Transactions)[0]
                .Select(x => x.Loop1000A)[0]
                .Select(x => x.Submitter)
                .Select(x => x.FirstName)
                .ValueOrDefault();
            
            Assert.AreEqual("Joe", firstName);
        }
        
        [Test, Explicit]
        public void Verify_can_parse_837_Dental()
        {
            const string message =
                @"ISA*03*6327      *01*NFMC01    *ZZ*MACHETE        *ZZ*PERSEPVS       *090601*0406*^*00501*000026531*0*P*:
GS*HB*FL0738*PERSEPVS*20090601*040612*1*X*005010X279
ST*837*987654*005010X223A3
BHT*0019*00*0123*19960918*0932*CH
NM1*41*2*JONES HOSPITAL*Joe****46*12345
PER*IC*JANE DOE*TE*9005555555
NM1*40*2*MEDICARE*****46*00120
HL*1**20*1
PRV*BI*PXC*203BA0200N
NM1*85*2*JONES HOSPITAL*****XX*9876540809
N3*225 MAIN STREET BARKLEY BUILDING
N4*CENTERVILLE*PA*17111
REF*EI*567891234
HL*2*1*22*0
SBR*P*18*******MB
NM1*IL*1*DOE*JOHN*T***MI*030005074A
N3*125 CITY AVENUE
N4*CENTERVILLE*PA*17111
DMG*D8*19261111*M
NM1*PR*2*MEDICARE B*****PI*00435
REF*G2*330127
CLM*756048Q*89.93***14:A:1*Y*A*Y*Y
DTP*434*D8*19960911
CL1*3**01
HI*BK:3669
HI*BF:4019*BF:79431
HI*BH:A1:D8:19261111*BH:A2:D8:19911101*BH:B1:D8:19261111*BH:B2:D8:19870101
HI*BE:A2:::15.31
HI*BG:09
NM1*71*1*JONES*JOHN*J
REF*1G*B99937
SBR*S*01*351630*STATE TEACHERS*****CI
DMG*D8*19271211*F
OI***Y***Y
NM1*IL*1*DOE*JANE*S***MI*222004433
N3*125 CITY AVENUE
N4*CENTERVILLE*PA*17111
NM1*PR*2*STATE TEACHERS*****PI*1135
LX*1
SV2*0305*HC:85025*13.39*UN*1
DTP*472*D8*19960911
LX*2
SV2*0730*HC:93005*76.54*UN*3
DTP*472*D8*19960911
SE*43*987654
GE*1*1
IEA*1*000026531";

            EntityResult<X12Entity> entityResult = Parser.Parse(message);

            Assert.IsTrue(Schema.TryGetLayout(out ILayoutParserFactory<HC837D, X12Entity> layout));

            IParser<X12Entity, HC837D> query = entityResult.CreateQuery(layout);

            Result<Cursor<X12Entity>, HC837D> result = entityResult.Query(query);

            var interchangeSegment = result.Select(x => x.InterchangeControlHeader);
            var transactionSetHeader = result
                .Select(x => x.Transactions)[0]
                .Select(x => x.TransactionSetHeader);
            var groupSegment = result.Select(x => x.Transactions)[0]
                .Select(x => x.FunctionalGroupHeader);
            
            Assert.IsTrue(result.HasResult);
            Assert.IsNotNull(interchangeSegment);
            Assert.IsTrue(interchangeSegment.HasValue);
            Assert.IsTrue(groupSegment.HasValue);
            Assert.IsTrue(transactionSetHeader.HasValue);

            string firstName = result.Select(x => x.Transactions)[0]
                .Select(x => x.Loop1000A)[0]
                .Select(x => x.Submitter)
                .Select(x => x.FirstName)
                .ValueOrDefault();

            var test = result.Select(x => x.Transactions)[0]
                .Select(x => x.Loop2000C)[0]
                .Select(x => x.Loop2300)[0]
                .Select(x => x.Loop2310D)
                .Select(x => x.AssistantSurgeon)
                .Select(x => x.FirstName)
                .ValueOrDefault();
            
            Assert.AreEqual("Joe", firstName);
        }
    }
}