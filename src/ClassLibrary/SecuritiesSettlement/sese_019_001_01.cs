
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



namespace i20022.sese01900101
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id sese.019.001.01 name RequestForPEPOrISAOrPortfolioInformationV01 from Securities Settlement business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>ReqForPEPOrISAOrPrtflInfV01</b> (Request For PEPOr ISAOr Portfolio Information V01) of type RequestForPEPOrISAOrPortfolioInformationV01.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public RequestForPEPOrISAOrPortfolioInformationV01 ReqForPEPOrISAOrPrtflInfV01;
    }

    /// <summary>
    /// Class <b>RequestForPEPOrISAOrPortfolioInformationV01</b> (Request For PEPOr ISAOr Portfolio Information V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class RequestForPEPOrISAOrPortfolioInformationV01
    {

        /// <summary>
        /// Element <b>MsgRef</b> (Message Reference) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MsgRef;

        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AdditionalReference3 PoolRef;

        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public AdditionalReference3 PrvsRef;

        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public AdditionalReference3 RltdRef;

        /// <summary>
        /// Element <b>PmryIndvInvstr</b> (Primary Individual Investor) of type IndividualPerson8.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public IndividualPerson8 PmryIndvInvstr;

        /// <summary>
        /// Element <b>ScndryIndvInvstr</b> (Secondary Individual Investor) of type IndividualPerson8.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public IndividualPerson8 ScndryIndvInvstr;

        /// <summary>
        /// Element <b>OthrIndvInvstr</b> (Other Individual Investor) of type array of IndividualPerson8.
        /// </summary>
        [XmlElementAttribute( "OthrIndvInvstr", Order = 6 )]
        public IndividualPerson8[] OthrIndvInvstr;

        /// <summary>
        /// Element <b>PmryCorpInvstr</b> (Primary Corporate Investor) of type Organisation4.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public Organisation4 PmryCorpInvstr;

        /// <summary>
        /// Element <b>ScndryCorpInvstr</b> (Secondary Corporate Investor) of type Organisation4.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public Organisation4 ScndryCorpInvstr;

        /// <summary>
        /// Element <b>OthrCorpInvstr</b> (Other Corporate Investor) of type array of Organisation4.
        /// </summary>
        [XmlElementAttribute( "OthrCorpInvstr", Order = 9 )]
        public Organisation4[] OthrCorpInvstr;

        /// <summary>
        /// Element <b>ClntAcct</b> (Client Account) of type Account5.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public Account5 ClntAcct;

        /// <summary>
        /// Element <b>NmneeAcct</b> (Nominee Account) of type Account6.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public Account6 NmneeAcct;

        /// <summary>
        /// Element <b>NewPlanMgr</b> (New Plan Manager) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public PartyIdentification2Choice NewPlanMgr;

        /// <summary>
        /// Element <b>PdctTrf</b> (Product Transfer) of type array of PEPISATransfer5.
        /// </summary>
        [XmlElementAttribute( "PdctTrf", Order = 13 )]
        public PEPISATransfer5[] PdctTrf;

        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute( "Xtnsn", Order = 14 )]
        public Extension1[] Xtnsn;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
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
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class Extension1
    {

        /// <summary>
        /// Element <b>PlcAndNm</b> (Place And Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string PlcAndNm;

        /// <summary>
        /// Element <b>Txt</b> (Txt) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Txt;
    }

    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class AlternateSecurityIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "DmstIdSrc", typeof( string ), Order = 1 )]
        [XmlElementAttribute( "PrtryIdSrc", typeof( string ), Order = 1 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01", IncludeInSchema = false )]
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
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class SecurityIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Belgn of type string 
        ///  Blmbrg of type string 
        ///  CTA of type string 
        ///  CUSIP of type string 
        ///  Cmon of type string 
        ///  Dtch of type string 
        ///  ISIN of type string 
        ///  OthrPrtryId of type AlternateSecurityIdentification1 
        ///  QUICK of type string 
        ///  RIC of type string 
        ///  SCVM of type string 
        ///  SEDOL of type string 
        ///  TckrSymb of type string 
        ///  Vlrn of type string 
        ///  Wrtppr of type string 
        /// </summary>
        [XmlElementAttribute( "Belgn", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Blmbrg", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CTA", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CUSIP", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Cmon", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Dtch", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ISIN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrPrtryId", typeof( AlternateSecurityIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "QUICK", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "RIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SCVM", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SEDOL", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "TckrSymb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Vlrn", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Wrtppr", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

        /// <summary>
        /// <b>Belgn - ?undefined</b>.
        /// </summary>
        Belgn,

        /// <summary>
        /// <b>Blmbrg - ?undefined</b>.
        /// </summary>
        Blmbrg,

        /// <summary>
        /// <b>CTA - ?undefined</b>.
        /// </summary>
        CTA,

        /// <summary>
        /// <b>CUSIP - ?undefined</b>.
        /// </summary>
        CUSIP,

        /// <summary>
        /// <b>Cmon - ?undefined</b>.
        /// </summary>
        Cmon,

        /// <summary>
        /// <b>Dtch - ?undefined</b>.
        /// </summary>
        Dtch,

        /// <summary>
        /// <b>ISIN - ?undefined</b>.
        /// </summary>
        ISIN,

        /// <summary>
        /// <b>OthrPrtryId - ?undefined</b>.
        /// </summary>
        OthrPrtryId,

        /// <summary>
        /// <b>QUICK - ?undefined</b>.
        /// </summary>
        QUICK,

        /// <summary>
        /// <b>RIC - ?undefined</b>.
        /// </summary>
        RIC,

        /// <summary>
        /// <b>SCVM - ?undefined</b>.
        /// </summary>
        SCVM,

        /// <summary>
        /// <b>SEDOL - ?undefined</b>.
        /// </summary>
        SEDOL,

        /// <summary>
        /// <b>TckrSymb - ?undefined</b>.
        /// </summary>
        TckrSymb,

        /// <summary>
        /// <b>Vlrn - ?undefined</b>.
        /// </summary>
        Vlrn,

        /// <summary>
        /// <b>Wrtppr - ?undefined</b>.
        /// </summary>
        Wrtppr,
    }

    /// <summary>
    /// Class <b>FinancialInstrument12</b> (Financial Instrument 12).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class FinancialInstrument12
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SecurityIdentification3Choice Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;
    }

    /// <summary>
    /// Class <b>Portfolio1</b> (Portfolio 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class Portfolio1
    {

        /// <summary>
        /// Element <b>PrtflInf</b> (Portfolio Information) of type array of string.
        /// </summary>
        [XmlElementAttribute( "PrtflInf", Order = 0 )]
        public string[] PrtflInf;
    }

    /// <summary>
    /// Class <b>PreviousYearChoice</b> (Previous Year Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class PreviousYearChoice
    {

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of string.
        /// </summary>
        [XmlElementAttribute( "AllPrvsYrs", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SpcfcPrvsYrs", typeof( string ), DataType = "gYear", Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemsElementName" )]
        public string[] Items;

        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute( "ItemsElementName", Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01", IncludeInSchema = false )]
    public enum ItemsChoiceType
    {

        /// <summary>
        /// <b>AllPrvsYrs - ?undefined</b>.
        /// </summary>
        AllPrvsYrs,

        /// <summary>
        /// <b>SpcfcPrvsYrs - ?undefined</b>.
        /// </summary>
        SpcfcPrvsYrs,
    }

    /// <summary>
    /// Class <b>ISAYearsOfIssue2</b> (ISAYears Of Issue 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class ISAYearsOfIssue2
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  CurYrTp of type ISAType2Code 
        ///  XtndedCurYrTp of type string 
        /// </summary>
        [XmlElementAttribute( "CurYrTp", typeof( ISAType2Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedCurYrTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>PrvsYrs</b> (Previous Years) of type PreviousYearChoice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PreviousYearChoice PrvsYrs;
    }

    /// <summary>
    /// Enumeration <b>ISAType2Code</b> (ISAType 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public enum ISAType2Code
    {

        /// <summary>
        /// <b>MINE - Mini Equity</b>.
        /// </summary>
        MINE,

        /// <summary>
        /// <b>MAXI - Maxi</b>.
        /// </summary>
        MAXI,

        /// <summary>
        /// <b>MINC - Mini Cash</b>.
        /// </summary>
        MINC,

        /// <summary>
        /// <b>ANYI - Any</b>.
        /// </summary>
        ANYI,
    }

    /// <summary>
    /// Class <b>PEPISATransfer5</b> (PEPISATransfer 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class PEPISATransfer5
    {

        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MstrRef;

        /// <summary>
        /// Element <b>TrfId</b> (Transfer Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string TrfId;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  ISA of type ISAYearsOfIssue2 
        ///  PEP of type PreviousYearChoice 
        ///  Prtfl of type Portfolio1 
        /// </summary>
        [XmlElementAttribute( "ISA", typeof( ISAYearsOfIssue2 ), Order = 2 )]
        [XmlElementAttribute( "PEP", typeof( PreviousYearChoice ), Order = 2 )]
        [XmlElementAttribute( "Prtfl", typeof( Portfolio1 ), Order = 2 )]
        public object Item;

        /// <summary>
        /// Element <b>FinInstrmAsstForTrf</b> (Financial Instrument Asset For Transfer) of type array of FinancialInstrument12.
        /// </summary>
        [XmlElementAttribute( "FinInstrmAsstForTrf", Order = 3 )]
        public FinancialInstrument12[] FinInstrmAsstForTrf;
    }

    /// <summary>
    /// Class <b>Account6</b> (Account 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class Account6
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Dsgnt</b> (Designation) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Dsgnt;

        /// <summary>
        /// Element <b>Svcr</b> (Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification2Choice Svcr;
    }

    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class PartyIdentification2Choice
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
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
    /// Class <b>Account5</b> (Account 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class Account5
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Dsgnt</b> (Designation) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Dsgnt;

        /// <summary>
        /// Element <b>Svcr</b> (Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification2Choice Svcr;
    }

    /// <summary>
    /// Class <b>PartyIdentification4Choice</b> (Party Identification 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class PartyIdentification4Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BICOrBEI of type string 
        ///  PrtryId of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute( "BICOrBEI", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification1 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>Organisation4</b> (Organisation 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class Organisation4
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification4Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification4Choice Id;

        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Purp;

        /// <summary>
        /// Element <b>TaxtnCtry</b> (Taxation Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string TaxtnCtry;

        /// <summary>
        /// Element <b>RegnCtry</b> (Registration Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string RegnCtry;

        /// <summary>
        /// Element <b>RegnDt</b> (Registration Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 5 )]
        public System.DateTime RegnDt;

        /// <summary>
        /// Element <b>RegnDtSpecified</b> (Registration Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RegnDtSpecified;

        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string TaxIdNb;

        /// <summary>
        /// Element <b>NtlRegnNb</b> (National Registration Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string NtlRegnNb;

        /// <summary>
        /// Element <b>CorpInvstrAdr</b> (Corporate Investor Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public PostalAddress1 CorpInvstrAdr;
    }

    /// <summary>
    /// Class <b>IndividualPerson8</b> (Individual Person 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class IndividualPerson8
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string GvnNm;

        /// <summary>
        /// Element <b>NmPrfx</b> (Name Prefix) of type NamePrefix1Code.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public NamePrefix1Code NmPrfx;

        /// <summary>
        /// Element <b>NmPrfxSpecified</b> (Name Prefix Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NmPrfxSpecified;

        /// <summary>
        /// Element <b>NmSfx</b> (Name Suffix) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string NmSfx;

        /// <summary>
        /// Element <b>Gndr</b> (Gender) of type GenderCode.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public GenderCode Gndr;

        /// <summary>
        /// Element <b>GndrSpecified</b> (Gender Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool GndrSpecified;

        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 5 )]
        public System.DateTime BirthDt;

        /// <summary>
        /// Element <b>BirthDtSpecified</b> (Birth Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BirthDtSpecified;

        /// <summary>
        /// Element <b>SclSctyNb</b> (Social Security Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string SclSctyNb;

        /// <summary>
        /// Element <b>IndvInvstrAdr</b> (Individual Investor Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public PostalAddress1 IndvInvstrAdr;
    }

    /// <summary>
    /// Enumeration <b>NamePrefix1Code</b> (Name Prefix 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public enum NamePrefix1Code
    {

        /// <summary>
        /// <b>DOCT - Doctor</b>.
        /// </summary>
        DOCT,

        /// <summary>
        /// <b>MIST - Mister</b>.
        /// </summary>
        MIST,

        /// <summary>
        /// <b>MISS - Miss</b>.
        /// </summary>
        MISS,

        /// <summary>
        /// <b>MADM - Madam</b>.
        /// </summary>
        MADM,
    }

    /// <summary>
    /// Enumeration <b>GenderCode</b> (Gender Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public enum GenderCode
    {

        /// <summary>
        /// <b>MALE - Male</b>.
        /// </summary>
        MALE,

        /// <summary>
        /// <b>FEMA - Female</b>.
        /// </summary>
        FEMA,
    }

    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.019.001.01" )]
    public class AdditionalReference3
    {

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ref;

        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice RefIssr;

        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string MsgNm;
    }


}
