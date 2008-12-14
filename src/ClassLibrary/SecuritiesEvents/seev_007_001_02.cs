
//                                      ______    ____  
//                                     |____  | "|__  | 
//                                      _   | |     | | 
//                                     | |  | |   __| | 
//                                     |_|  |_|  |_____| 
//
//  --------------------------------------------------- 
// |     _   ____     ___     ___    ____    ____      |
// |    (_) |___ \   / _ \   / _ \  |___ \  |___ \     |
// |    | |   __) | | | | | | | | |   __) |   __) |    |
// |    | |  / __/  | |_| | | |_| |  / __/   / __/     |
// |    |_| |_____|  \___/   \___/  |_____| |_____|    |
// |                                                   |
// |    AN ISO 20022 OPEN-SOURCE .NET CLASS LIBRARY    |
// |            FOR MESSAGING APPLICATIONS             |
// |                                                   |
// |        Copyright (C) 2008 Mauricio Leventer       |
// |                mleventer@i20022.com               |
// |                                                   |
//  ---------------------------------------------------
//
// L I C E N S E                                         
//                                                       
// This program is free software; you can redistribute it
// and/or modify it under the terms of the GNU General   
// Public License as published by the Free Software      
// Foundation; either version 2 of the License, or (at   
// your option) any later version.                       
//                                                       
// This program is distributed in the hope that it will  
// be useful, but WITHOUT ANY WARRANTY; without even the 
// implied warranty of MERCHANTABILITY or FITNESS FOR A  
// PARTICULAR PURPOSE. See the GNU General Public License
// for more details.                                     
//                                                       
// You should have received a copy of the GNU General    
// Public License along with this program; if not, write 
// to the Free Software Foundation, Inc.,                
// 59 Temple Place, Suite 330, Boston, MA                
// 02111-1307 USA.                                       
//                                                       
//
using System;
using System.Diagnostics;
using System.Xml.Serialization;



namespace i20022.seev00700102
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.007.001.02 name MeetingVoteExecutionConfirmationV02 from Securities Events business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>MtgVoteExctnConf</b> (Meeting Vote Execution Confirmation) of type MeetingVoteExecutionConfirmationV02.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MeetingVoteExecutionConfirmationV02 MtgVoteExctnConf;
    }

    /// <summary>
    /// Class <b>MeetingVoteExecutionConfirmationV02</b> (Meeting Vote Execution Confirmation V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class MeetingVoteExecutionConfirmationV02
    {

        /// <summary>
        /// Element <b>VoteExctnConfId</b> (Vote Execution Confirmation Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 VoteExctnConfId;

        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type MessageIdentification.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public MessageIdentification RltdRef;

        /// <summary>
        /// Element <b>MtgRef</b> (Meeting Reference) of type MeetingReference3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public MeetingReference3 MtgRef;

        /// <summary>
        /// Element <b>RptgPty</b> (Reporting Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PartyIdentification9Choice RptgPty;

        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public SecurityIdentification3 SctyId;

        /// <summary>
        /// Element <b>VoteInstr</b> (Vote Instruction) of type array of DetailedInstructionStatus2.
        /// </summary>
        [XmlElementAttribute( "VoteInstr", Order = 5 )]
        public DetailedInstructionStatus2[] VoteInstr;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class MessageIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CreDtTm;
    }

    /// <summary>
    /// Class <b>Vote4</b> (Vote 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class Vote4
    {

        /// <summary>
        /// Element <b>IssrLabl</b> (Issuer Label) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string IssrLabl;

        /// <summary>
        /// Element <b>For</b> (For) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal For;

        /// <summary>
        /// Element <b>ForSpecified</b> (For Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ForSpecified;

        /// <summary>
        /// Element <b>Agnst</b> (Against) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal Agnst;

        /// <summary>
        /// Element <b>AgnstSpecified</b> (Against Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AgnstSpecified;

        /// <summary>
        /// Element <b>Abstn</b> (Abstn) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal Abstn;

        /// <summary>
        /// Element <b>AbstnSpecified</b> (Abstn Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AbstnSpecified;

        /// <summary>
        /// Element <b>Wthhld</b> (Wthhld) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public decimal Wthhld;

        /// <summary>
        /// Element <b>WthhldSpecified</b> (Wthhld Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WthhldSpecified;

        /// <summary>
        /// Element <b>WthMgmt</b> (With Management) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public decimal WthMgmt;

        /// <summary>
        /// Element <b>WthMgmtSpecified</b> (With Management Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WthMgmtSpecified;

        /// <summary>
        /// Element <b>AgnstMgmt</b> (Against Management) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public decimal AgnstMgmt;

        /// <summary>
        /// Element <b>AgnstMgmtSpecified</b> (Against Management Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AgnstMgmtSpecified;

        /// <summary>
        /// Element <b>Dscrtnry</b> (Dscrtnry) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public decimal Dscrtnry;

        /// <summary>
        /// Element <b>DscrtnrySpecified</b> (Dscrtnry Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DscrtnrySpecified;

        /// <summary>
        /// Element <b>NoActn</b> (No Action) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public decimal NoActn;

        /// <summary>
        /// Element <b>NoActnSpecified</b> (No Action Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NoActnSpecified;
    }

    /// <summary>
    /// Class <b>DetailedInstructionStatus2</b> (Detailed Instruction Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class DetailedInstructionStatus2
    {

        /// <summary>
        /// Element <b>InstrId</b> (Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string InstrId;

        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string AcctId;

        /// <summary>
        /// Element <b>AcctOwnr</b> (Account Owner) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification9Choice AcctOwnr;

        /// <summary>
        /// Element <b>SubAcctId</b> (Sub Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string SubAcctId;

        /// <summary>
        /// Element <b>RghtsHldr</b> (Rights Holder) of type array of PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( "RghtsHldr", Order = 4 )]
        public PartyIdentification9Choice[] RghtsHldr;

        /// <summary>
        /// Element <b>StgInstr</b> (Standing Instruction) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public bool StgInstr;

        /// <summary>
        /// Element <b>VotePerRsltn</b> (Vote Per Resolution) of type array of Vote4.
        /// </summary>
        [XmlElementAttribute( "VotePerRsltn", Order = 6 )]
        public Vote4[] VotePerRsltn;
    }

    /// <summary>
    /// Class <b>PartyIdentification9Choice</b> (Party Identification 9Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class PartyIdentification9Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BICOrBEI of type string 
        ///  NmAndAdr of type NameAndAddress5 
        ///  PrtryId of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute( "BICOrBEI", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress5 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification1 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class NameAndAddress5
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 Adr;
    }

    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class PostalAddress1
    {

        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AddressType2Code AdrTp;

        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdrTpSpecified;

        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute( "AdrLine", Order = 1 )]
        public string[] AdrLine;

        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string StrtNm;

        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string BldgNb;

        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string PstCd;

        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string TwnNm;

        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string CtrySubDvsn;

        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string Ctry;
    }

    /// <summary>
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public enum AddressType2Code
    {

        /// <summary>
        /// <b>ADDR - Postal</b>.
        /// </summary>
        ADDR,

        /// <summary>
        /// <b>PBOX - POBox</b>.
        /// </summary>
        PBOX,

        /// <summary>
        /// <b>HOME - Residential</b>.
        /// </summary>
        HOME,

        /// <summary>
        /// <b>BIZZ - Business</b>.
        /// </summary>
        BIZZ,

        /// <summary>
        /// <b>MLTO - Mail To</b>.
        /// </summary>
        MLTO,

        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
    }

    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class GenericIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string SchmeNm;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Class <b>AlternateFinancialInstrumentIdentification1</b> (Alternate Financial Instrument Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class AlternateFinancialInstrumentIdentification1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "DmstIdSrc", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "PrtryIdSrc", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Id;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType
    {

        /// <summary>
        /// <b>DmstIdSrc - ?undefined</b>.
        /// </summary>
        DmstIdSrc,

        /// <summary>
        /// <b>PrtryIdSrc - ?undefined</b>.
        /// </summary>
        PrtryIdSrc,
    }

    /// <summary>
    /// Class <b>SecurityIdentification3</b> (Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class SecurityIdentification3
    {

        /// <summary>
        /// Element <b>ISIN</b> (ISIN) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string ISIN;

        /// <summary>
        /// Element <b>TckrSymb</b> (Ticker Symbol) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string TckrSymb;

        /// <summary>
        /// Element <b>CUSIP</b> (CUSIP) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string CUSIP;

        /// <summary>
        /// Element <b>SEDOL</b> (SEDOL) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string SEDOL;

        /// <summary>
        /// Element <b>QUICK</b> (QUICK) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string QUICK;

        /// <summary>
        /// Element <b>OthrId</b> (Other Identification) of type AlternateFinancialInstrumentIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public AlternateFinancialInstrumentIdentification1 OthrId;
    }

    /// <summary>
    /// Class <b>MeetingReference3</b> (Meeting Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class MeetingReference3
    {

        /// <summary>
        /// Element <b>MtgId</b> (Meeting Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MtgId;

        /// <summary>
        /// Element <b>IssrMtgId</b> (Issuer Meeting Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IssrMtgId;

        /// <summary>
        /// Element <b>MtgDtAndTm</b> (Meeting Date And Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public System.DateTime MtgDtAndTm;

        /// <summary>
        /// Element <b>Tp</b> (Type) of type MeetingType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public MeetingType2Code Tp;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Clssfctn of type MeetingTypeClassification1Code 
        ///  XtndedClssfctn of type string 
        /// </summary>
        [XmlElementAttribute( "Clssfctn", typeof( MeetingTypeClassification1Code ), Order = 4 )]
        [XmlElementAttribute( "XtndedClssfctn", typeof( string ), Order = 4 )]
        public object Item;

        /// <summary>
        /// Element <b>Lctn</b> (Location) of type array of PostalAddress1.
        /// </summary>
        [XmlElementAttribute( "Lctn", Order = 5 )]
        public PostalAddress1[] Lctn;
    }

    /// <summary>
    /// Enumeration <b>MeetingType2Code</b> (Meeting Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public enum MeetingType2Code
    {

        /// <summary>
        /// <b>XMET - Extraordinary</b>.
        /// </summary>
        XMET,

        /// <summary>
        /// <b>GMET - General</b>.
        /// </summary>
        GMET,

        /// <summary>
        /// <b>MIXD - Mixed</b>.
        /// </summary>
        MIXD,

        /// <summary>
        /// <b>SPCL - Special</b>.
        /// </summary>
        SPCL,
    }

    /// <summary>
    /// Enumeration <b>MeetingTypeClassification1Code</b> (Meeting Type Classification 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public enum MeetingTypeClassification1Code
    {

        /// <summary>
        /// <b>AMET - Annual</b>.
        /// </summary>
        AMET,

        /// <summary>
        /// <b>OMET - Ordinary</b>.
        /// </summary>
        OMET,

        /// <summary>
        /// <b>CLAS - Class</b>.
        /// </summary>
        CLAS,

        /// <summary>
        /// <b>ISSU - Issuer Initiated</b>.
        /// </summary>
        ISSU,

        /// <summary>
        /// <b>VRHI - Voting Rights Holder Initiated</b>.
        /// </summary>
        VRHI,

        /// <summary>
        /// <b>CORT - Court</b>.
        /// </summary>
        CORT,
    }

    /// <summary>
    /// Class <b>MessageIdentification</b> (Message Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02" )]
    public class MessageIdentification
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }
}
