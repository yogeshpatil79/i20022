
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



namespace i20022.seev00100102
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.001.001.02 name MeetingNotificationV02 from Securities Events business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>MtgNtfctn</b> (Meeting Notification) of type MeetingNotificationV02.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MeetingNotificationV02 MtgNtfctn;
    }

    /// <summary>
    /// Class <b>MeetingNotificationV02</b> (Meeting Notification V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class MeetingNotificationV02
    {

        /// <summary>
        /// Element <b>MtgNtfctnId</b> (Meeting Notification Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MtgNtfctnId;

        /// <summary>
        /// Element <b>Amdmnt</b> (Amendment) of type AmendInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AmendInformation1 Amdmnt;

        /// <summary>
        /// Element <b>NtfctnSts</b> (Notification Status) of type NotificationStatus1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public NotificationStatus1 NtfctnSts;

        /// <summary>
        /// Element <b>Mtg</b> (Meeting) of type MeetingNotice2.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public MeetingNotice2 Mtg;

        /// <summary>
        /// Element <b>MtgDtls</b> (Meeting Details) of type array of Meeting2.
        /// </summary>
        [XmlElementAttribute( "MtgDtls", Order = 4 )]
        public Meeting2[] MtgDtls;

        /// <summary>
        /// Element <b>NtifngPty</b> (Notifying Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public PartyIdentification9Choice NtifngPty;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public PartyIdentification9Choice Issr;

        /// <summary>
        /// Element <b>IssrAgt</b> (Issuer Agent) of type array of IssuerAgent1.
        /// </summary>
        [XmlElementAttribute( "IssrAgt", Order = 7 )]
        public IssuerAgent1[] IssrAgt;

        /// <summary>
        /// Element <b>Scty</b> (Security) of type array of SecurityPosition5.
        /// </summary>
        [XmlElementAttribute( "Scty", Order = 8 )]
        public SecurityPosition5[] Scty;

        /// <summary>
        /// Element <b>Rsltn</b> (Resolution) of type array of Resolution2.
        /// </summary>
        [XmlElementAttribute( "Rsltn", Order = 9 )]
        public Resolution2[] Rsltn;

        /// <summary>
        /// Element <b>Vote</b> (Vote) of type VoteParameters1.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public VoteParameters1 Vote;

        /// <summary>
        /// Element <b>EntitlmntSpcfctn</b> (Entitlement Spcfctn) of type EntitlementAssessment1.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public EntitlementAssessment1 EntitlmntSpcfctn;

        /// <summary>
        /// Element <b>PwrOfAttnyRqrmnts</b> (Power Of Attorney Requirements) of type PowerOfAttorneyRequirements2.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public PowerOfAttorneyRequirements2 PwrOfAttnyRqrmnts;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    /// Class <b>PowerOfAttorneyRequirements2</b> (Power Of Attorney Requirements 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class PowerOfAttorneyRequirements2
    {

        /// <summary>
        /// Element <b>LglRqrmnt</b> (Legal Requirement) of type array of PowerOfAttorneyLegalisation1Code.
        /// </summary>
        [XmlElementAttribute( "LglRqrmnt", Order = 0 )]
        public PowerOfAttorneyLegalisation1Code[] LglRqrmnt;

        /// <summary>
        /// Element <b>OthrDcmnttn</b> (Other Documentation) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string OthrDcmnttn;
    }

    /// <summary>
    /// Enumeration <b>PowerOfAttorneyLegalisation1Code</b> (Power Of Attorney Legalisation 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum PowerOfAttorneyLegalisation1Code
    {

        /// <summary>
        /// <b>NOTA - Notary</b>.
        /// </summary>
        NOTA,

        /// <summary>
        /// <b>LOCA - Local Authority</b>.
        /// </summary>
        LOCA,

        /// <summary>
        /// <b>APOS - Apostilled</b>.
        /// </summary>
        APOS,

        /// <summary>
        /// <b>COUN - Consularized</b>.
        /// </summary>
        COUN,
    }

    /// <summary>
    /// Class <b>EntitlementAssessment1</b> (Entitlement Assessment 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class EntitlementAssessment1
    {

        /// <summary>
        /// Element <b>SctiesBlckgDdln</b> (Securities Blocking Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public DateFormat2Choice SctiesBlckgDdln;

        /// <summary>
        /// Element <b>SctiesBlckgSTPDdln</b> (Securities Blocking STPDeadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public DateFormat2Choice SctiesBlckgSTPDdln;

        /// <summary>
        /// Element <b>SctiesBlckgMktDdln</b> (Securities Blocking Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DateFormat2Choice SctiesBlckgMktDdln;

        /// <summary>
        /// Element <b>SctiesBlckgPrdEndDt</b> (Securities Blocking Period End Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public System.DateTime SctiesBlckgPrdEndDt;

        /// <summary>
        /// Element <b>SctiesBlckgPrdEndDtSpecified</b> (Securities Blocking Period End Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SctiesBlckgPrdEndDtSpecified;

        /// <summary>
        /// Element <b>EntitlmntFxgDt</b> (Entitlement Fxg Date) of type DateFormat3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public DateFormat3Choice EntitlmntFxgDt;

        /// <summary>
        /// Element <b>RegnSctiesDdln</b> (Registration Securities Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public DateFormat2Choice RegnSctiesDdln;

        /// <summary>
        /// Element <b>RegnSctiesSTPDdln</b> (Registration Securities STPDeadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public DateFormat2Choice RegnSctiesSTPDdln;

        /// <summary>
        /// Element <b>RegnSctiesMktDdln</b> (Registration Securities Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public DateFormat2Choice RegnSctiesMktDdln;

        /// <summary>
        /// Element <b>RegnPrtcptnDdln</b> (Registration Participation Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public DateFormat2Choice RegnPrtcptnDdln;

        /// <summary>
        /// Element <b>RegnPrtcptnSTPDdln</b> (Registration Participation STPDeadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public DateFormat2Choice RegnPrtcptnSTPDdln;

        /// <summary>
        /// Element <b>RegnPrtcptnMktDdln</b> (Registration Participation Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public DateFormat2Choice RegnPrtcptnMktDdln;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  EntitlmntDesc of type string 
        ///  EntitlmntRatio of type decimal 
        /// </summary>
        [XmlElementAttribute( "EntitlmntDesc", typeof( string ), Order = 11 )]
        [XmlElementAttribute( "EntitlmntRatio", typeof( decimal ), Order = 11 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>DateFormat2Choice</b> (Date Format 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class DateFormat2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Dt of type System.DateTime 
        ///  DtCd of type DateType1Code 
        /// </summary>
        [XmlElementAttribute( "Dt", typeof( System.DateTime ), Order = 0 )]
        [XmlElementAttribute( "DtCd", typeof( DateType1Code ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>DateType1Code</b> (Date Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum DateType1Code
    {

        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }

    /// <summary>
    /// Class <b>DateFormat3Choice</b> (Date Format 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class DateFormat3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DtCd of type DateType1Code 
        /// </summary>
        [XmlElementAttribute( "Dt", typeof( System.DateTime ), DataType = "date", Order = 0 )]
        [XmlElementAttribute( "DtCd", typeof( DateType1Code ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAnd13DecimalAmount</b> (Active Or Historic Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class ActiveOrHistoricCurrencyAnd13DecimalAmount
    {

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Ccy;

        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [XmlTextAttribute()]
        public decimal Value;
    }

    /// <summary>
    /// Class <b>PriceRateOrAmountChoice</b> (Price Rate Or Amount Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class PriceRateOrAmountChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Amt of type ActiveOrHistoricCurrencyAnd13DecimalAmount 
        ///  Rate of type decimal 
        /// </summary>
        [XmlElementAttribute( "Amt", typeof( ActiveOrHistoricCurrencyAnd13DecimalAmount ), Order = 0 )]
        [XmlElementAttribute( "Rate", typeof( decimal ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>IncentivePremium2</b> (Incentive Premium 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class IncentivePremium2
    {

        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Desc;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type PriceRateOrAmountChoice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PriceRateOrAmountChoice Amt;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  PerAttndee of type bool 
        ///  PerScty of type decimal 
        ///  PerVote of type decimal 
        /// </summary>
        [XmlElementAttribute( "PerAttndee", typeof( bool ), Order = 2 )]
        [XmlElementAttribute( "PerScty", typeof( decimal ), Order = 2 )]
        [XmlElementAttribute( "PerVote", typeof( decimal ), Order = 2 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;

        /// <summary>
        /// Element <b>PmtDt</b> (Payment Date) of type DateFormat3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public DateFormat3Choice PmtDt;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType2
    {

        /// <summary>
        /// <b>PerAttndee - ?undefined</b>.
        /// </summary>
        PerAttndee,

        /// <summary>
        /// <b>PerScty - ?undefined</b>.
        /// </summary>
        PerScty,

        /// <summary>
        /// <b>PerVote - ?undefined</b>.
        /// </summary>
        PerVote,
    }

    /// <summary>
    /// Class <b>CommunicationAddress4</b> (Communication Address 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class CommunicationAddress4
    {

        /// <summary>
        /// Element <b>EmailAdr</b> (Email Address) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string EmailAdr;

        /// <summary>
        /// Element <b>URLAdr</b> (URLAddress) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string URLAdr;
    }

    /// <summary>
    /// Class <b>VoteMethods</b> (Vote Methods).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class VoteMethods
    {

        /// <summary>
        /// Element <b>VoteThrghNtwk</b> (Vote Through Network) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string VoteThrghNtwk;

        /// <summary>
        /// Element <b>VoteByMail</b> (Vote By Mail) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 VoteByMail;

        /// <summary>
        /// Element <b>ElctrncVote</b> (Electronic Vote) of type CommunicationAddress4.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CommunicationAddress4 ElctrncVote;

        /// <summary>
        /// Element <b>VoteByTel</b> (Vote By Telephone) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string VoteByTel;
    }

    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    /// Class <b>VoteParameters1</b> (Vote Parameters 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class VoteParameters1
    {

        /// <summary>
        /// Element <b>SctiesQtyReqrdToVote</b> (Securities Quantity Required To Vote) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public decimal SctiesQtyReqrdToVote;

        /// <summary>
        /// Element <b>SctiesQtyReqrdToVoteSpecified</b> (Securities Quantity Required To Vote Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SctiesQtyReqrdToVoteSpecified;

        /// <summary>
        /// Element <b>PrtlVoteAllwd</b> (Partial Vote Allowed) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool PrtlVoteAllwd;

        /// <summary>
        /// Element <b>SpltVoteAllwd</b> (Split Vote Allowed) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool SpltVoteAllwd;

        /// <summary>
        /// Element <b>VoteDdln</b> (Vote Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public DateFormat2Choice VoteDdln;

        /// <summary>
        /// Element <b>VoteSTPDdln</b> (Vote STPDeadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public DateFormat2Choice VoteSTPDdln;

        /// <summary>
        /// Element <b>VoteMktDdln</b> (Vote Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public DateFormat2Choice VoteMktDdln;

        /// <summary>
        /// Element <b>VoteMthds</b> (Vote Methods) of type VoteMethods.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public VoteMethods VoteMthds;

        /// <summary>
        /// Element <b>VtngBlltElctrncAdr</b> (Voting Ballot Electronic Address) of type CommunicationAddress4.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public CommunicationAddress4 VtngBlltElctrncAdr;

        /// <summary>
        /// Element <b>VtngBlltReqAdr</b> (Voting Ballot Request Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public PostalAddress1 VtngBlltReqAdr;

        /// <summary>
        /// Element <b>RvcbltyDdln</b> (Rvcblty Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public DateFormat2Choice RvcbltyDdln;

        /// <summary>
        /// Element <b>RvcbltySTPDdln</b> (Rvcblty STPDeadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public DateFormat2Choice RvcbltySTPDdln;

        /// <summary>
        /// Element <b>RvcbltyMktDdln</b> (Rvcblty Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public DateFormat2Choice RvcbltyMktDdln;

        /// <summary>
        /// Element <b>BnfclOwnrDsclsr</b> (Beneficial Owner Disclosure) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public bool BnfclOwnrDsclsr;

        /// <summary>
        /// Element <b>VoteInstrTp</b> (Vote Instruction Type) of type array of VoteInstruction2Code.
        /// </summary>
        [XmlElementAttribute( "VoteInstrTp", Order = 13 )]
        public VoteInstruction2Code[] VoteInstrTp;

        /// <summary>
        /// Element <b>IncntivPrm</b> (Incentive Premium) of type IncentivePremium2.
        /// </summary>
        [XmlElementAttribute( Order = 14 )]
        public IncentivePremium2 IncntivPrm;

        /// <summary>
        /// Element <b>VoteWthPrmDdln</b> (Vote With Premium Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 15 )]
        public DateFormat2Choice VoteWthPrmDdln;

        /// <summary>
        /// Element <b>VoteWthPrmSTPDdln</b> (Vote With Premium STPDeadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public DateFormat2Choice VoteWthPrmSTPDdln;

        /// <summary>
        /// Element <b>VoteWthPrmMktDdln</b> (Vote With Premium Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 17 )]
        public DateFormat2Choice VoteWthPrmMktDdln;

        /// <summary>
        /// Element <b>AddtlVtngRqrmnts</b> (Additional Voting Requirements) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 18 )]
        public string AddtlVtngRqrmnts;
    }

    /// <summary>
    /// Enumeration <b>VoteInstruction2Code</b> (Vote Instruction 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum VoteInstruction2Code
    {

        /// <summary>
        /// <b>CFOR - For</b>.
        /// </summary>
        CFOR,

        /// <summary>
        /// <b>CAGS - Against</b>.
        /// </summary>
        CAGS,

        /// <summary>
        /// <b>ABST - Abstain</b>.
        /// </summary>
        ABST,

        /// <summary>
        /// <b>WTHH - Withhold</b>.
        /// </summary>
        WTHH,

        /// <summary>
        /// <b>WMGT - With Management</b>.
        /// </summary>
        WMGT,

        /// <summary>
        /// <b>AMGT - Against Management</b>.
        /// </summary>
        AMGT,

        /// <summary>
        /// <b>NOAC - No Action</b>.
        /// </summary>
        NOAC,

        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,
    }

    /// <summary>
    /// Class <b>Resolution2</b> (Resolution 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class Resolution2
    {

        /// <summary>
        /// Element <b>IssrLabl</b> (Issuer Label) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string IssrLabl;

        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Desc;

        /// <summary>
        /// Element <b>Titl</b> (Titl) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Titl;

        /// <summary>
        /// Element <b>Tp</b> (Type) of type ResolutionType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public ResolutionType1Code Tp;

        /// <summary>
        /// Element <b>ForInfOnly</b> (For Information Only) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public bool ForInfOnly;

        /// <summary>
        /// Element <b>Sts</b> (Status) of type ResolutionStatus1Code.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public ResolutionStatus1Code Sts;

        /// <summary>
        /// Element <b>SubmittdBySctyHldr</b> (Submitted By Security Holder) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public bool SubmittdBySctyHldr;

        /// <summary>
        /// Element <b>VoteInstrTp</b> (Vote Instruction Type) of type array of VoteInstruction2Code.
        /// </summary>
        [XmlElementAttribute( "VoteInstrTp", Order = 7 )]
        public VoteInstruction2Code[] VoteInstrTp;

        /// <summary>
        /// Element <b>MgmtRcmmndtn</b> (Management Recommendation) of type VoteInstruction1Code.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public VoteInstruction1Code MgmtRcmmndtn;

        /// <summary>
        /// Element <b>MgmtRcmmndtnSpecified</b> (Management Recommendation Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MgmtRcmmndtnSpecified;

        /// <summary>
        /// Element <b>NtifngPtyRcmmndtn</b> (Notifying Party Recommendation) of type VoteInstruction1Code.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public VoteInstruction1Code NtifngPtyRcmmndtn;

        /// <summary>
        /// Element <b>NtifngPtyRcmmndtnSpecified</b> (Notifying Party Recommendation Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NtifngPtyRcmmndtnSpecified;
    }

    /// <summary>
    /// Enumeration <b>ResolutionType1Code</b> (Resolution Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum ResolutionType1Code
    {

        /// <summary>
        /// <b>EXTR - Extraordinary</b>.
        /// </summary>
        EXTR,

        /// <summary>
        /// <b>ORDI - Ordinary</b>.
        /// </summary>
        ORDI,

        /// <summary>
        /// <b>SPCL - Special</b>.
        /// </summary>
        SPCL,
    }

    /// <summary>
    /// Enumeration <b>ResolutionStatus1Code</b> (Resolution Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum ResolutionStatus1Code
    {

        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,

        /// <summary>
        /// <b>WDRA - Withdrawn</b>.
        /// </summary>
        WDRA,
    }

    /// <summary>
    /// Enumeration <b>VoteInstruction1Code</b> (Vote Instruction 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum VoteInstruction1Code
    {

        /// <summary>
        /// <b>CFOR - For</b>.
        /// </summary>
        CFOR,

        /// <summary>
        /// <b>CAGS - Against</b>.
        /// </summary>
        CAGS,

        /// <summary>
        /// <b>ABST - Abstain</b>.
        /// </summary>
        ABST,

        /// <summary>
        /// <b>WTHH - Withhold</b>.
        /// </summary>
        WTHH,

        /// <summary>
        /// <b>NOAC - No Action</b>.
        /// </summary>
        NOAC,
    }

    /// <summary>
    /// Class <b>GenericIdentification5</b> (Generic Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class GenericIdentification5
    {

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Issr;

        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Inf;

        /// <summary>
        /// Element <b>Nrrtv</b> (Nrrtv) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Nrrtv;
    }

    /// <summary>
    /// Class <b>PartyIdentification3</b> (Party Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class PartyIdentification3
    {

        /// <summary>
        /// Element <b>BICOrBEI</b> (BICOr BEI) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BICOrBEI;
    }

    /// <summary>
    /// Class <b>SafekeepingPlaceAsCodeAndPartyIdentification</b> (Safekeeping Place As Code And Party Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class SafekeepingPlaceAsCodeAndPartyIdentification
    {

        /// <summary>
        /// Element <b>PlcSfkpg</b> (Place Safekeeping) of type SafekeepingPlace1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SafekeepingPlace1Code PlcSfkpg;

        /// <summary>
        /// Element <b>Nrrtv</b> (Nrrtv) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nrrtv;

        /// <summary>
        /// Element <b>Pty</b> (Party) of type PartyIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification3 Pty;
    }

    /// <summary>
    /// Enumeration <b>SafekeepingPlace1Code</b> (Safekeeping Place 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum SafekeepingPlace1Code
    {

        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,

        /// <summary>
        /// <b>ICSD - Shares Held At ICSD</b>.
        /// </summary>
        ICSD,

        /// <summary>
        /// <b>NCSD - Shares Held At NCSD</b>.
        /// </summary>
        NCSD,

        /// <summary>
        /// <b>SHHE - Shares Held Elsewhere</b>.
        /// </summary>
        SHHE,
    }

    /// <summary>
    /// Class <b>SafekeepingPlaceFormatChoice</b> (Safekeeping Place Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class SafekeepingPlaceFormatChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Id of type SafekeepingPlaceAsCodeAndPartyIdentification 
        ///  IdAsCtry of type string 
        ///  IdAsDSS of type GenericIdentification5 
        /// </summary>
        [XmlElementAttribute( "Id", typeof( SafekeepingPlaceAsCodeAndPartyIdentification ), Order = 0 )]
        [XmlElementAttribute( "IdAsCtry", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IdAsDSS", typeof( GenericIdentification5 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>UnitOrFaceAmountChoice</b> (Unit Or Face Amount Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class UnitOrFaceAmountChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  FaceAmt of type CurrencyAndAmount 
        ///  Unit of type decimal 
        /// </summary>
        [XmlElementAttribute( "FaceAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "Unit", typeof( decimal ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class CurrencyAndAmount
    {

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Ccy;

        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [XmlTextAttribute()]
        public decimal Value;
    }

    /// <summary>
    /// Class <b>HoldingBalance3</b> (Holding Balance 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class HoldingBalance3
    {

        /// <summary>
        /// Element <b>Bal</b> (Balance) of type UnitOrFaceAmountChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public UnitOrFaceAmountChoice Bal;

        /// <summary>
        /// Element <b>BalTp</b> (Balance Type) of type SecuritiesEntryType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public SecuritiesEntryType2Code BalTp;

        /// <summary>
        /// Element <b>BalTpSpecified</b> (Balance Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BalTpSpecified;

        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type SafekeepingPlaceFormatChoice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public SafekeepingPlaceFormatChoice SfkpgPlc;

        /// <summary>
        /// Element <b>Dt</b> (Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 3 )]
        public System.DateTime Dt;

        /// <summary>
        /// Element <b>DtSpecified</b> (Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DtSpecified;
    }

    /// <summary>
    /// Enumeration <b>SecuritiesEntryType2Code</b> (Securities Entry Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum SecuritiesEntryType2Code
    {

        /// <summary>
        /// <b>BLOK - Blocked</b>.
        /// </summary>
        BLOK,

        /// <summary>
        /// <b>ELIG - Eligible</b>.
        /// </summary>
        ELIG,

        /// <summary>
        /// <b>PEND - Pending Delivery</b>.
        /// </summary>
        PEND,

        /// <summary>
        /// <b>PENR - Pending Receipt</b>.
        /// </summary>
        PENR,

        /// <summary>
        /// <b>NOMI - Nominee</b>.
        /// </summary>
        NOMI,

        /// <summary>
        /// <b>SETD - Settled</b>.
        /// </summary>
        SETD,

        /// <summary>
        /// <b>BORR - Borrowed</b>.
        /// </summary>
        BORR,

        /// <summary>
        /// <b>LOAN - Loan</b>.
        /// </summary>
        LOAN,

        /// <summary>
        /// <b>SPOS - Street Position</b>.
        /// </summary>
        SPOS,

        /// <summary>
        /// <b>TRAD - Trade</b>.
        /// </summary>
        TRAD,

        /// <summary>
        /// <b>COLI - Collateral In</b>.
        /// </summary>
        COLI,

        /// <summary>
        /// <b>COLO - Collateral Out</b>.
        /// </summary>
        COLO,

        /// <summary>
        /// <b>UNBA - Uninstructed Balance</b>.
        /// </summary>
        UNBA,

        /// <summary>
        /// <b>INBA - Instructed Balance</b>.
        /// </summary>
        INBA,

        /// <summary>
        /// <b>REGO - Out For Registration</b>.
        /// </summary>
        REGO,
    }

    /// <summary>
    /// Class <b>EligiblePosition2</b> (Eligible Position 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class EligiblePosition2
    {

        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string AcctId;

        /// <summary>
        /// Element <b>AcctOwnr</b> (Account Owner) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification9Choice AcctOwnr;

        /// <summary>
        /// Element <b>HldgBal</b> (Holding Balance) of type array of HoldingBalance3.
        /// </summary>
        [XmlElementAttribute( "HldgBal", Order = 2 )]
        public HoldingBalance3[] HldgBal;

        /// <summary>
        /// Element <b>RghtsHldr</b> (Rights Holder) of type array of PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( "RghtsHldr", Order = 3 )]
        public PartyIdentification9Choice[] RghtsHldr;
    }

    /// <summary>
    /// Class <b>PartyIdentification9Choice</b> (Party Identification 9Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Id;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType1
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    /// Class <b>SecurityPosition5</b> (Security Position 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class SecurityPosition5
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SecurityIdentification3 Id;

        /// <summary>
        /// Element <b>Pos</b> (Position) of type array of EligiblePosition2.
        /// </summary>
        [XmlElementAttribute( "Pos", Order = 1 )]
        public EligiblePosition2[] Pos;
    }

    /// <summary>
    /// Class <b>IssuerAgent1</b> (Issuer Agent 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class IssuerAgent1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentification9Choice Id;

        /// <summary>
        /// Element <b>Role</b> (Role) of type AgentRole1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AgentRole1Code Role;

        /// <summary>
        /// Element <b>RoleSpecified</b> (Role Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RoleSpecified;
    }

    /// <summary>
    /// Enumeration <b>AgentRole1Code</b> (Agent Role 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum AgentRole1Code
    {

        /// <summary>
        /// <b>PRIN - Principal Agent</b>.
        /// </summary>
        PRIN,

        /// <summary>
        /// <b>SUBA - Sub Agent</b>.
        /// </summary>
        SUBA,
    }

    /// <summary>
    /// Class <b>LocationFormat1Choice</b> (Location Format 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class LocationFormat1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Adr of type PostalAddress1 
        ///  LctnCd of type PlaceType1Code 
        /// </summary>
        [XmlElementAttribute( "Adr", typeof( PostalAddress1 ), Order = 0 )]
        [XmlElementAttribute( "LctnCd", typeof( PlaceType1Code ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>PlaceType1Code</b> (Place Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum PlaceType1Code
    {

        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }

    /// <summary>
    /// Class <b>Meeting2</b> (Meeting 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class Meeting2
    {

        /// <summary>
        /// Element <b>DtAndTm</b> (Date And Time) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public DateFormat2Choice DtAndTm;

        /// <summary>
        /// Element <b>DtSts</b> (Date Status) of type MeetingDateStatus1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public MeetingDateStatus1Code DtSts;

        /// <summary>
        /// Element <b>DtStsSpecified</b> (Date Status Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DtStsSpecified;

        /// <summary>
        /// Element <b>QrmReqrd</b> (Quorum Required) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool QrmReqrd;

        /// <summary>
        /// Element <b>Lctn</b> (Location) of type array of LocationFormat1Choice.
        /// </summary>
        [XmlElementAttribute( "Lctn", Order = 3 )]
        public LocationFormat1Choice[] Lctn;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  QrmQty of type string 
        ///  QrmQtyPctg of type decimal 
        /// </summary>
        [XmlElementAttribute( "QrmQty", typeof( string ), Order = 4 )]
        [XmlElementAttribute( "QrmQtyPctg", typeof( decimal ), Order = 4 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>MeetingDateStatus1Code</b> (Meeting Date Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum MeetingDateStatus1Code
    {

        /// <summary>
        /// <b>TNTA - Tentative</b>.
        /// </summary>
        TNTA,

        /// <summary>
        /// <b>CNFR - Confirmed</b>.
        /// </summary>
        CNFR,

        /// <summary>
        /// <b>CANC - Request To Cancel</b>.
        /// </summary>
        CANC,

        /// <summary>
        /// <b>NOQO - No Quorum</b>.
        /// </summary>
        NOQO,
    }

    /// <summary>
    /// Class <b>ContactIdentification1</b> (Contact Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class ContactIdentification1
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>NmPrfx</b> (Name Prefix) of type NamePrefix1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public NamePrefix1Code NmPrfx;

        /// <summary>
        /// Element <b>NmPrfxSpecified</b> (Name Prefix Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NmPrfxSpecified;

        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string GvnNm;

        /// <summary>
        /// Element <b>Role</b> (Role) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Role;

        /// <summary>
        /// Element <b>PhneNb</b> (Phone Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string PhneNb;

        /// <summary>
        /// Element <b>FaxNb</b> (Fax Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string FaxNb;

        /// <summary>
        /// Element <b>EmailAdr</b> (Email Address) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string EmailAdr;
    }

    /// <summary>
    /// Enumeration <b>NamePrefix1Code</b> (Name Prefix 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    /// Class <b>MeetingContactPerson1</b> (Meeting Contact Person 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class MeetingContactPerson1
    {

        /// <summary>
        /// Element <b>CtctPrsn</b> (Contact Person) of type ContactIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ContactIdentification1 CtctPrsn;

        /// <summary>
        /// Element <b>EmplngPty</b> (Employing Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification9Choice EmplngPty;

        /// <summary>
        /// Element <b>PlcOfListg</b> (Place Of Listing) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string PlcOfListg;
    }

    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class GenericIdentification4
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>IdTp</b> (Identification Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IdTp;
    }

    /// <summary>
    /// Class <b>PersonIdentification2</b> (Person Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class PersonIdentification2
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  AlnRegnNb of type string 
        ///  DrvrsLicNb of type string 
        ///  IdntyCardNb of type string 
        ///  MplyrIdNb of type string 
        ///  OthrId of type GenericIdentification4 
        ///  PsptNb of type string 
        ///  SclSctyNb of type string 
        ///  TaxIdNb of type string 
        /// </summary>
        [XmlElementAttribute( "AlnRegnNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DrvrsLicNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IdntyCardNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "MplyrIdNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrId", typeof( GenericIdentification4 ), Order = 0 )]
        [XmlElementAttribute( "PsptNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SclSctyNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "TaxIdNb", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType
    {

        /// <summary>
        /// <b>AlnRegnNb - ?undefined</b>.
        /// </summary>
        AlnRegnNb,

        /// <summary>
        /// <b>DrvrsLicNb - ?undefined</b>.
        /// </summary>
        DrvrsLicNb,

        /// <summary>
        /// <b>IdntyCardNb - ?undefined</b>.
        /// </summary>
        IdntyCardNb,

        /// <summary>
        /// <b>MplyrIdNb - ?undefined</b>.
        /// </summary>
        MplyrIdNb,

        /// <summary>
        /// <b>OthrId - ?undefined</b>.
        /// </summary>
        OthrId,

        /// <summary>
        /// <b>PsptNb - ?undefined</b>.
        /// </summary>
        PsptNb,

        /// <summary>
        /// <b>SclSctyNb - ?undefined</b>.
        /// </summary>
        SclSctyNb,

        /// <summary>
        /// <b>TaxIdNb - ?undefined</b>.
        /// </summary>
        TaxIdNb,
    }

    /// <summary>
    /// Class <b>IndividualPerson14</b> (Individual Person 14).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class IndividualPerson14
    {

        /// <summary>
        /// Element <b>BirthNm</b> (Birth Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BirthNm;

        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string GvnNm;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type PersonIdentification2.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PersonIdentification2 Id;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PostalAddress1 Adr;

        /// <summary>
        /// Element <b>EmplngPty</b> (Employing Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification9Choice EmplngPty;
    }

    /// <summary>
    /// Class <b>Proxy1</b> (Proxy 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class Proxy1
    {

        /// <summary>
        /// Element <b>PrxyTp</b> (Proxy Type) of type array of ProxyType2Code.
        /// </summary>
        [XmlElementAttribute( "PrxyTp", Order = 0 )]
        public ProxyType2Code[] PrxyTp;

        /// <summary>
        /// Element <b>PrssgndPrxy</b> (Preassigned Proxy) of type IndividualPerson14.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public IndividualPerson14 PrssgndPrxy;
    }

    /// <summary>
    /// Enumeration <b>ProxyType2Code</b> (Proxy Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum ProxyType2Code
    {

        /// <summary>
        /// <b>CHRM - Chairman</b>.
        /// </summary>
        CHRM,

        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,

        /// <summary>
        /// <b>HLDR - Security Holder</b>.
        /// </summary>
        HLDR,
    }

    /// <summary>
    /// Class <b>ProxyAppointmentInformation1</b> (Proxy Appointment Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class ProxyAppointmentInformation1
    {

        /// <summary>
        /// Element <b>RegnMtd</b> (Registration Method) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string RegnMtd;

        /// <summary>
        /// Element <b>Ddln</b> (Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public DateFormat2Choice Ddln;

        /// <summary>
        /// Element <b>STPDdln</b> (STPDeadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DateFormat2Choice STPDdln;

        /// <summary>
        /// Element <b>MktDdln</b> (Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public DateFormat2Choice MktDdln;

        /// <summary>
        /// Element <b>AuthrsdPrxy</b> (Authorised Proxy) of type array of Proxy1.
        /// </summary>
        [XmlElementAttribute( "AuthrsdPrxy", Order = 4 )]
        public Proxy1[] AuthrsdPrxy;
    }

    /// <summary>
    /// Class <b>MeetingNotice2</b> (Meeting Notice 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class MeetingNotice2
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
        /// Element <b>Tp</b> (Type) of type MeetingType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public MeetingType2Code Tp;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Clssfctn of type MeetingTypeClassification1Code 
        ///  XtndedClssfctn of type string 
        /// </summary>
        [XmlElementAttribute( "Clssfctn", typeof( MeetingTypeClassification1Code ), Order = 3 )]
        [XmlElementAttribute( "XtndedClssfctn", typeof( string ), Order = 3 )]
        public object Item;

        /// <summary>
        /// Element <b>AnncmntDt</b> (Announcement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 4 )]
        public System.DateTime AnncmntDt;

        /// <summary>
        /// Element <b>AnncmntDtSpecified</b> (Announcement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AnncmntDtSpecified;

        /// <summary>
        /// Element <b>AttndncReqrd</b> (Attendance Required) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public bool AttndncReqrd;

        /// <summary>
        /// Element <b>AttndncConfInf</b> (Attendance Confirmation Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string AttndncConfInf;

        /// <summary>
        /// Element <b>AttndncConfDdln</b> (Attendance Confirmation Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public DateFormat2Choice AttndncConfDdln;

        /// <summary>
        /// Element <b>AttndncConfSTPDdln</b> (Attendance Confirmation STPDeadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public DateFormat2Choice AttndncConfSTPDdln;

        /// <summary>
        /// Element <b>AttndncConfMktDdln</b> (Attendance Confirmation Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public DateFormat2Choice AttndncConfMktDdln;

        /// <summary>
        /// Element <b>AddtlDcmnttnURLAdr</b> (Additional Documentation URLAddress) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public string AddtlDcmnttnURLAdr;

        /// <summary>
        /// Element <b>RsltnPrpslDdln</b> (Resolution Proposal Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public DateFormat2Choice RsltnPrpslDdln;

        /// <summary>
        /// Element <b>RsltnPrpslMktDdln</b> (Resolution Proposal Market Deadline) of type DateFormat2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public DateFormat2Choice RsltnPrpslMktDdln;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  RsltnPrpslThrshld of type string 
        ///  RsltnPrpslThrshldPctg of type decimal 
        /// </summary>
        [XmlElementAttribute( "RsltnPrpslThrshld", typeof( string ), Order = 13 )]
        [XmlElementAttribute( "RsltnPrpslThrshldPctg", typeof( decimal ), Order = 13 )]
        public object Item1;

        /// <summary>
        /// Element <b>TtlNbOfSctiesOutsdng</b> (Total Number Of Securities Outstanding) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 14 )]
        public CurrencyAndAmount TtlNbOfSctiesOutsdng;

        /// <summary>
        /// Element <b>TtlNbOfVtngRghts</b> (Total Number Of Voting Rights) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 15 )]
        public decimal TtlNbOfVtngRghts;

        /// <summary>
        /// Element <b>TtlNbOfVtngRghtsSpecified</b> (Total Number Of Voting Rights Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TtlNbOfVtngRghtsSpecified;

        /// <summary>
        /// Element <b>PrxyAppntmntNtfctnAdr</b> (Proxy Appointment Notification Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public PostalAddress1 PrxyAppntmntNtfctnAdr;

        /// <summary>
        /// Element <b>Item2</b> (Item 2) of type object.
        /// This element can be:
        ///  Prxy of type ProxyAppointmentInformation1 
        ///  PrxyNotAllwd of type ProxyNotAllowedCode 
        /// </summary>
        [XmlElementAttribute( "Prxy", typeof( ProxyAppointmentInformation1 ), Order = 17 )]
        [XmlElementAttribute( "PrxyNotAllwd", typeof( ProxyNotAllowedCode ), Order = 17 )]
        public object Item2;

        /// <summary>
        /// Element <b>CtctPrsnDtls</b> (Contact Person Details) of type array of MeetingContactPerson1.
        /// </summary>
        [XmlElementAttribute( "CtctPrsnDtls", Order = 18 )]
        public MeetingContactPerson1[] CtctPrsnDtls;

        /// <summary>
        /// Element <b>RsltPblctnDt</b> (Result Publication Date) of type DateFormat3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 19 )]
        public DateFormat3Choice RsltPblctnDt;
    }

    /// <summary>
    /// Enumeration <b>MeetingType2Code</b> (Meeting Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
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
    /// Enumeration <b>ProxyNotAllowedCode</b> (Proxy Not Allowed Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum ProxyNotAllowedCode
    {

        /// <summary>
        /// <b>NPRO - Not Allowed</b>.
        /// </summary>
        NPRO,
    }

    /// <summary>
    /// Class <b>NotificationStatus1</b> (Notification Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class NotificationStatus1
    {

        /// <summary>
        /// Element <b>Sts</b> (Status) of type NotificationStatus2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public NotificationStatus2Code Sts;
    }

    /// <summary>
    /// Enumeration <b>NotificationStatus2Code</b> (Notification Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public enum NotificationStatus2Code
    {

        /// <summary>
        /// <b>ECON - Event Confirmed</b>.
        /// </summary>
        ECON,

        /// <summary>
        /// <b>EUNC - Event Unconfirmed</b>.
        /// </summary>
        EUNC,
    }

    /// <summary>
    /// Class <b>MessageIdentification</b> (Message Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class MessageIdentification
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }

    /// <summary>
    /// Class <b>AmendInformation1</b> (Amend Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.02" )]
    public class AmendInformation1
    {

        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type MessageIdentification.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification PrvsRef;

        /// <summary>
        /// Element <b>RcnfrmInstrs</b> (Reconfirm Instructions) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool RcnfrmInstrs;
    }
}
