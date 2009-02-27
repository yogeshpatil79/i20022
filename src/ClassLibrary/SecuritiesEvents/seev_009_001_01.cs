
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;



namespace i20022.seev00900101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.009.001.01 name AgentCANotificationAdviceV01 from Securities Events business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AgtCANtfctnAdvc</b> (Agent CA Notification Advice) of type AgentCANotificationAdviceV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AgentCANotificationAdviceV01 AgtCANtfctnAdvc;
    }
    
    /// <summary>
    /// Class <b>AgentCANotificationAdviceV01</b> (Agent CA Notification Advice V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AgentCANotificationAdviceV01
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification8 Id;
        
        /// <summary>
        /// Element <b>NtfctnTpAndLkg</b> (Notification Type And Linkage) of type LinkedCorporateAction1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public LinkedCorporateAction1 NtfctnTpAndLkg;
        
        /// <summary>
        /// Element <b>NtfctnGnlInf</b> (Notification General Information) of type CorporateActionNotification1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CorporateActionNotification1 NtfctnGnlInf;
        
        /// <summary>
        /// Element <b>CorpActnGnlInf</b> (Corporate Action General Information) of type CorporateActionInformation2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionInformation2 CorpActnGnlInf;
        
        /// <summary>
        /// Element <b>CorpActnDtls</b> (Corporate Action Details) of type CorporateAction2.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public CorporateAction2 CorpActnDtls;
        
        /// <summary>
        /// Element <b>CorpActnOptnDtls</b> (Corporate Action Option Details) of type array of CorporateActionOption1.
        /// </summary>
        [XmlElementAttribute("CorpActnOptnDtls", Order=5)]
        public CorporateActionOption1[] CorpActnOptnDtls;
        
        /// <summary>
        /// Element <b>CtctDtls</b> (Contact Details) of type array of ContactPerson1.
        /// </summary>
        [XmlElementAttribute("CtctDtls", Order=6)]
        public ContactPerson1[] CtctDtls;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type CorporateActionNarrative2.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public CorporateActionNarrative2 AddtlInf;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class DocumentIdentification8
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime CreDtTm;
        
        /// <summary>
        /// Element <b>CreDtTmSpecified</b> (Creation Date Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreDtTmSpecified;
    }
    
    /// <summary>
    /// Class <b>CorporateActionNarrative2</b> (Corporate Action Narrative 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionNarrative2
    {
        
        /// <summary>
        /// Element <b>InfConds</b> (Information Conditions) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string InfConds;
        
        /// <summary>
        /// Element <b>InfToCmplyWth</b> (Information To Comply With) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string InfToCmplyWth;
        
        /// <summary>
        /// Element <b>TaxtnConds</b> (Taxation Conditions) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string TaxtnConds;
        
        /// <summary>
        /// Element <b>DclrtnDtls</b> (Declaration Details) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DclrtnDtls;
        
        /// <summary>
        /// Element <b>RegnDtls</b> (Registration Details) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string RegnDtls;
        
        /// <summary>
        /// Element <b>AddtlTxt</b> (Additional Text) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string AddtlTxt;
    }
    
    /// <summary>
    /// Class <b>ContactIdentification4</b> (Contact Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ContactIdentification4
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>NmPrfx</b> (Name Prefix) of type NamePrefix1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public NamePrefix1Code NmPrfx;
        
        /// <summary>
        /// Element <b>NmPrfxSpecified</b> (Name Prefix Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NmPrfxSpecified;
        
        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string GvnNm;
        
        /// <summary>
        /// Element <b>Role</b> (Role) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Role;
        
        /// <summary>
        /// Element <b>PhneNb</b> (Phone Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string PhneNb;
        
        /// <summary>
        /// Element <b>FaxNb</b> (Fax Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string FaxNb;
        
        /// <summary>
        /// Element <b>EmailAdr</b> (Email Address) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string EmailAdr;
    }
    
    /// <summary>
    /// Enumeration <b>NamePrefix1Code</b> (Name Prefix 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
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
    /// Class <b>ContactPerson1</b> (Contact Person 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ContactPerson1
    {
        
        /// <summary>
        /// Element <b>CtctPrsn</b> (Contact Person) of type ContactIdentification4.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ContactIdentification4 CtctPrsn;
        
        /// <summary>
        /// Element <b>InstnId</b> (Institution Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice InstnId;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PartyIdentification2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class NameAndAddress5
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 Adr;
    }
    
    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PostalAddress1
    {
        
        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AddressType2Code AdrTp;
        
        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdrTpSpecified;
        
        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute("AdrLine", Order=1)]
        public string[] AdrLine;
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string BldgNb;
        
        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string PstCd;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string CtrySubDvsn;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Ctry;
    }
    
    /// <summary>
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class GenericIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>OptionFeatures1FormatChoice</b> (Option Features 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class OptionFeatures1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type OptionFeatures1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(OptionFeatures1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>OptionFeatures1Code</b> (Option Features 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum OptionFeatures1Code
    {
        
        /// <summary>
        /// <b>COND - Conditional</b>.
        /// </summary>
        COND,
        
        /// <summary>
        /// <b>MAXC - Maximum Cash</b>.
        /// </summary>
        MAXC,
        
        /// <summary>
        /// <b>MAXS - Maximum Securities</b>.
        /// </summary>
        MAXS,
        
        /// <summary>
        /// <b>OPLF - Odd Lot Preference</b>.
        /// </summary>
        OPLF,
        
        /// <summary>
        /// <b>PROR - Pro Ration</b>.
        /// </summary>
        PROR,
        
        /// <summary>
        /// <b>QOVE - Over and Above</b>.
        /// </summary>
        QOVE,
        
        /// <summary>
        /// <b>QREC - Quantity to Receive</b>.
        /// </summary>
        QREC,
        
        /// <summary>
        /// <b>VVPR - Reduced Withholding Tax</b>.
        /// </summary>
        VVPR,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification13</b> (Generic Identification 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class GenericIdentification13
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>AgentRole1FormatChoice</b> (Agent Role 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AgentRole1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type AgentRole2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(AgentRole2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>AgentRole2Code</b> (Agent Role 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum AgentRole2Code
    {
        
        /// <summary>
        /// <b>SPAY - SWIFTPay</b>.
        /// </summary>
        SPAY,
        
        /// <summary>
        /// <b>CODO - Sub-Paying Agent</b>.
        /// </summary>
        CODO,
        
        /// <summary>
        /// <b>ISAG - ?undefined?</b>.
        /// </summary>
        ISAG,
        
        /// <summary>
        /// <b>REGR - ?undefined?</b>.
        /// </summary>
        REGR,
        
        /// <summary>
        /// <b>PAYA - ?undefined?</b>.
        /// </summary>
        PAYA,
    }
    
    /// <summary>
    /// Class <b>CorporateActionAgent1</b> (Corporate Action Agent 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionAgent1
    {
        
        /// <summary>
        /// Element <b>AgtId</b> (Agent Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice AgtId;
        
        /// <summary>
        /// Element <b>AgtRole</b> (Agent Role) of type AgentRole1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AgentRole1FormatChoice AgtRole;
        
        /// <summary>
        /// Element <b>CtctPrsn</b> (Contact Person) of type NameAndAddress5.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public NameAndAddress5 CtctPrsn;
    }
    
    /// <summary>
    /// Class <b>CorporateActionAmounts1</b> (Corporate Action Amounts 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionAmounts1
    {
        
        /// <summary>
        /// Element <b>GrssCshAmt</b> (Gross Cash Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAndAmount GrssCshAmt;
        
        /// <summary>
        /// Element <b>NetCshAmt</b> (Net Cash Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount NetCshAmt;
        
        /// <summary>
        /// Element <b>IsseDscntAmt</b> (Issue Discount Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAndAmount IsseDscntAmt;
        
        /// <summary>
        /// Element <b>SlctnFees</b> (Solicitation Fees) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount SlctnFees;
        
        /// <summary>
        /// Element <b>CshInLieuOfShr</b> (Cash In Lieu Of Share) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ActiveCurrencyAndAmount CshInLieuOfShr;
        
        /// <summary>
        /// Element <b>OrgnlAmt</b> (Original Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public ActiveCurrencyAndAmount OrgnlAmt;
        
        /// <summary>
        /// Element <b>CptlGn</b> (Capital Gain) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public ActiveCurrencyAndAmount CptlGn;
        
        /// <summary>
        /// Element <b>IntrstAmt</b> (Interest Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public ActiveCurrencyAndAmount IntrstAmt;
        
        /// <summary>
        /// Element <b>IndmntyAmt</b> (Indemnity Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public ActiveCurrencyAndAmount IndmntyAmt;
        
        /// <summary>
        /// Element <b>RedPrmAmt</b> (Redemption Premium Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public ActiveCurrencyAndAmount RedPrmAmt;
        
        /// <summary>
        /// Element <b>ManfctrdDvddAmt</b> (Manufactured Dividend Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public ActiveCurrencyAndAmount ManfctrdDvddAmt;
        
        /// <summary>
        /// Element <b>PrncplOrCrps</b> (Principal Or Corpus) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public ActiveCurrencyAndAmount PrncplOrCrps;
        
        /// <summary>
        /// Element <b>RinvstmtAmt</b> (Reinvestment Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public ActiveCurrencyAndAmount RinvstmtAmt;
        
        /// <summary>
        /// Element <b>MktClmAmt</b> (Market Claim Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public ActiveCurrencyAndAmount MktClmAmt;
        
        /// <summary>
        /// Element <b>FullyFrnkdAmt</b> (Fully Franked Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public ActiveCurrencyAndAmount FullyFrnkdAmt;
        
        /// <summary>
        /// Element <b>UfrnkdAmt</b> (Unfranked Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public ActiveCurrencyAndAmount UfrnkdAmt;
        
        /// <summary>
        /// Element <b>SndryOrOthrAmt</b> (Sundry Or Other Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public ActiveCurrencyAndAmount SndryOrOthrAmt;
        
        /// <summary>
        /// Element <b>SpclCncssnAmt</b> (Special Concession Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public ActiveCurrencyAndAmount SpclCncssnAmt;
        
        /// <summary>
        /// Element <b>EntitldAmt</b> (Entitled Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public ActiveCurrencyAndAmount EntitldAmt;
        
        /// <summary>
        /// Element <b>CshIncntiv</b> (Cash Incentive) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public ActiveCurrencyAndAmount CshIncntiv;
        
        /// <summary>
        /// Element <b>AddtlSbcptCost</b> (Additional Subscription Cost) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public ActiveCurrencyAndAmount AddtlSbcptCost;
        
        /// <summary>
        /// Element <b>TaxFreeAmt</b> (Tax Free Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=21)]
        public ActiveCurrencyAndAmount TaxFreeAmt;
        
        /// <summary>
        /// Element <b>TaxDfrrdAmt</b> (Tax Deferred Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=22)]
        public ActiveCurrencyAndAmount TaxDfrrdAmt;
        
        /// <summary>
        /// Element <b>GrmnLclTax1Amt</b> (German Local Tax 1Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=23)]
        public ActiveCurrencyAndAmount GrmnLclTax1Amt;
        
        /// <summary>
        /// Element <b>GrmnLclTax2Amt</b> (German Local Tax 2Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=24)]
        public ActiveCurrencyAndAmount GrmnLclTax2Amt;
        
        /// <summary>
        /// Element <b>GrmnLclTax3Amt</b> (German Local Tax 3Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=25)]
        public ActiveCurrencyAndAmount GrmnLclTax3Amt;
        
        /// <summary>
        /// Element <b>GrmnLclTax4Amt</b> (German Local Tax 4Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=26)]
        public ActiveCurrencyAndAmount GrmnLclTax4Amt;
        
        /// <summary>
        /// Element <b>StockXchgTaxAmt</b> (Stock Exchange Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=27)]
        public ActiveCurrencyAndAmount StockXchgTaxAmt;
        
        /// <summary>
        /// Element <b>TrfTaxAmt</b> (Transfer Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=28)]
        public ActiveCurrencyAndAmount TrfTaxAmt;
        
        /// <summary>
        /// Element <b>TxTaxAmt</b> (Transaction Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=29)]
        public ActiveCurrencyAndAmount TxTaxAmt;
        
        /// <summary>
        /// Element <b>ValAddedTaxAmt</b> (Value Added Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=30)]
        public ActiveCurrencyAndAmount ValAddedTaxAmt;
        
        /// <summary>
        /// Element <b>EURtntnTaxAmt</b> (EU Retention Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=31)]
        public ActiveCurrencyAndAmount EURtntnTaxAmt;
        
        /// <summary>
        /// Element <b>LclTaxAmt</b> (Local Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=32)]
        public ActiveCurrencyAndAmount LclTaxAmt;
        
        /// <summary>
        /// Element <b>PmtLevyTaxAmt</b> (Payment Levy Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=33)]
        public ActiveCurrencyAndAmount PmtLevyTaxAmt;
        
        /// <summary>
        /// Element <b>CtryNtlFdrlTaxAmt</b> (Country National Federal Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=34)]
        public ActiveCurrencyAndAmount CtryNtlFdrlTaxAmt;
        
        /// <summary>
        /// Element <b>StmpDtyAmt</b> (Stamp Duty Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=35)]
        public ActiveCurrencyAndAmount StmpDtyAmt;
        
        /// <summary>
        /// Element <b>TaxRclmAmt</b> (Tax Reclaim Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=36)]
        public ActiveCurrencyAndAmount TaxRclmAmt;
        
        /// <summary>
        /// Element <b>TaxCdtAmt</b> (Tax Credit Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=37)]
        public ActiveCurrencyAndAmount TaxCdtAmt;
        
        /// <summary>
        /// Element <b>WhldgOfFrgnTaxAmt</b> (Withholding Of Foreign Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=38)]
        public ActiveCurrencyAndAmount WhldgOfFrgnTaxAmt;
        
        /// <summary>
        /// Element <b>WhldgOfLclTaxAmt</b> (Withholding Of Local Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=39)]
        public ActiveCurrencyAndAmount WhldgOfLclTaxAmt;
        
        /// <summary>
        /// Element <b>AddtlTaxAmt</b> (Additional Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=40)]
        public ActiveCurrencyAndAmount AddtlTaxAmt;
        
        /// <summary>
        /// Element <b>WhldgTaxAmt</b> (Withholding Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=41)]
        public ActiveCurrencyAndAmount WhldgTaxAmt;
        
        /// <summary>
        /// Element <b>FsclStmpAmt</b> (Fiscal Stamp Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=42)]
        public ActiveCurrencyAndAmount FsclStmpAmt;
        
        /// <summary>
        /// Element <b>ExctgBrkrAmt</b> (Executing Broker Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=43)]
        public ActiveCurrencyAndAmount ExctgBrkrAmt;
        
        /// <summary>
        /// Element <b>PngAgtComssnAmt</b> (Paying Agent Commission Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=44)]
        public ActiveCurrencyAndAmount PngAgtComssnAmt;
        
        /// <summary>
        /// Element <b>LclBrkrComssnAmt</b> (Local Broker Commission Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=45)]
        public ActiveCurrencyAndAmount LclBrkrComssnAmt;
        
        /// <summary>
        /// Element <b>PstgFeeAmt</b> (Postage Fee Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=46)]
        public ActiveCurrencyAndAmount PstgFeeAmt;
        
        /// <summary>
        /// Element <b>RgltryFeesAmt</b> (Regulatory Fees Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=47)]
        public ActiveCurrencyAndAmount RgltryFeesAmt;
        
        /// <summary>
        /// Element <b>ShppgFeesAmt</b> (Shipping Fees Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=48)]
        public ActiveCurrencyAndAmount ShppgFeesAmt;
        
        /// <summary>
        /// Element <b>ChrgsAmt</b> (Charges Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=49)]
        public ActiveCurrencyAndAmount ChrgsAmt;
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ActiveCurrencyAndAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Class <b>CorporateActionDate5</b> (Corporate Action Date 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionDate5
    {
        
        /// <summary>
        /// Element <b>FXRateFxgDt</b> (ForeignExchange Rate Fixing Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateFormat4Choice FXRateFxgDt;
        
        /// <summary>
        /// Element <b>ValDt</b> (Value Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DateFormat4Choice ValDt;
        
        /// <summary>
        /// Element <b>PmtDt</b> (Payment Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateFormat4Choice PmtDt;
        
        /// <summary>
        /// Element <b>EarlstPmtDt</b> (Earliest Payment Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DateFormat4Choice EarlstPmtDt;
    }
    
    /// <summary>
    /// Class <b>DateFormat4Choice</b> (Date Format 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class DateFormat4Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Dt (Date) of type DateAndDateTimeChoice 
        /// NotSpcfdDt (Not Specified Date) of type DateType6Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Dt", typeof(DateAndDateTimeChoice), Order=0)]
        [XmlElementAttribute("NotSpcfdDt", typeof(DateType6Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class DateAndDateTimeChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute("Dt", typeof(System.DateTime), DataType="date", Order=0)]
        [XmlElementAttribute("DtTm", typeof(System.DateTime), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public System.DateTime Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>Dt - Date</b>.
        /// </summary>
        Dt,
        
        /// <summary>
        /// <b>DtTm - Date Time</b>.
        /// </summary>
        DtTm,
    }
    
    /// <summary>
    /// Enumeration <b>DateType6Code</b> (Date Type 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum DateType6Code
    {
        
        /// <summary>
        /// <b>OPEN - Open</b>.
        /// </summary>
        OPEN,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>ONGO - Ongoing basis</b>.
        /// </summary>
        ONGO,
    }
    
    /// <summary>
    /// Class <b>CashOption1</b> (Cash Option 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CashOption1
    {
        
        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CreditDebitCode CdtDbtInd;
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Ccy;
        
        /// <summary>
        /// Element <b>DtDtls</b> (Date Details) of type CorporateActionDate5.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CorporateActionDate5 DtDtls;
        
        /// <summary>
        /// Element <b>AmtDtls</b> (Amount Details) of type CorporateActionAmounts1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionAmounts1 AmtDtls;
        
        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type ForeignExchangeTerms8.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ForeignExchangeTerms8 XchgRate;
    }
    
    /// <summary>
    /// Enumeration <b>CreditDebitCode</b> (Credit Debit Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CreditDebitCode
    {
        
        /// <summary>
        /// <b>CRDT - Credit Card</b>.
        /// </summary>
        CRDT,
        
        /// <summary>
        /// <b>DBIT - Debit Card</b>.
        /// </summary>
        DBIT,
    }
    
    /// <summary>
    /// Class <b>ForeignExchangeTerms8</b> (Foreign Exchange Terms 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ForeignExchangeTerms8
    {
        
        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string UnitCcy;
        
        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string QtdCcy;
        
        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public decimal XchgRate;
        
        /// <summary>
        /// Element <b>RsltgAmt</b> (Resulting Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount RsltgAmt;
    }
    
    /// <summary>
    /// Class <b>FractionDispositionType1FormatChoice</b> (Fraction Disposition Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class FractionDispositionType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type FractionDispositionType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(FractionDispositionType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>FractionDispositionType1Code</b> (Fraction Disposition Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum FractionDispositionType1Code
    {
        
        /// <summary>
        /// <b>BUYU - ?undefined?</b>.
        /// </summary>
        BUYU,
        
        /// <summary>
        /// <b>CINL - ?undefined?</b>.
        /// </summary>
        CINL,
        
        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,
        
        /// <summary>
        /// <b>RDDN - ?undefined?</b>.
        /// </summary>
        RDDN,
        
        /// <summary>
        /// <b>RDUP - Round Up</b>.
        /// </summary>
        RDUP,
        
        /// <summary>
        /// <b>STAN - Round To Nearest</b>.
        /// </summary>
        STAN,
    }
    
    /// <summary>
    /// Class <b>CorporateActionPrice4</b> (Corporate Action Price 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionPrice4
    {
        
        /// <summary>
        /// Element <b>IndctvPric</b> (Indicative Price) of type PriceFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PriceFormat2Choice IndctvPric;
        
        /// <summary>
        /// Element <b>MktPric</b> (Market Price) of type PriceFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceFormat2Choice MktPric;
    }
    
    /// <summary>
    /// Class <b>PriceFormat2Choice</b> (Price Format 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PriceFormat2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type AmountPrice1 
        /// NotSpcfd (Not Specified) of type PriceValueType5FormatChoice 
        /// Rate (Rate) of type PriceRate1 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(AmountPrice1), Order=0)]
        [XmlElementAttribute("NotSpcfd", typeof(PriceValueType5FormatChoice), Order=0)]
        [XmlElementAttribute("Rate", typeof(PriceRate1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>AmountPrice1</b> (Amount Price 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AmountPrice1
    {
        
        /// <summary>
        /// Element <b>AmtPricTp</b> (Amount Price Type) of type AmountPriceType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AmountPriceType1FormatChoice AmtPricTp;
        
        /// <summary>
        /// Element <b>PricVal</b> (Price Value) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAnd13DecimalAmount PricVal;
    }
    
    /// <summary>
    /// Class <b>AmountPriceType1FormatChoice</b> (Amount Price Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AmountPriceType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type AmountPriceType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(AmountPriceType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>AmountPriceType1Code</b> (Amount Price Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum AmountPriceType1Code
    {
        
        /// <summary>
        /// <b>ACTU - Actual</b>.
        /// </summary>
        ACTU,
        
        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,
        
        /// <summary>
        /// <b>PLOT - ?undefined?</b>.
        /// </summary>
        PLOT,
        
        /// <summary>
        /// <b>PREM - Premium</b>.
        /// </summary>
        PREM,
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ActiveCurrencyAnd13DecimalAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Class <b>PriceValueType5FormatChoice</b> (Price Value Type 5Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PriceValueType5FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type PriceValueType5Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(PriceValueType5Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>PriceValueType5Code</b> (Price Value Type 5Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum PriceValueType5Code
    {
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>OPEN - Open</b>.
        /// </summary>
        OPEN,
    }
    
    /// <summary>
    /// Class <b>PriceRate1</b> (Price Rate 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PriceRate1
    {
        
        /// <summary>
        /// Element <b>RateTp</b> (Rate Type) of type PriceRateType3FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PriceRateType3FormatChoice RateTp;
        
        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Rate;
    }
    
    /// <summary>
    /// Class <b>PriceRateType3FormatChoice</b> (Price Rate Type 3Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PriceRateType3FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type PriceRateType3Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(PriceRateType3Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>PriceRateType3Code</b> (Price Rate Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum PriceRateType3Code
    {
        
        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,
        
        /// <summary>
        /// <b>PREM - Premium</b>.
        /// </summary>
        PREM,
        
        /// <summary>
        /// <b>PRCT - Percent</b>.
        /// </summary>
        PRCT,
        
        /// <summary>
        /// <b>YIEL - Yield</b>.
        /// </summary>
        YIEL,
    }
    
    /// <summary>
    /// Class <b>CorporateActionDate3</b> (Corporate Action Date 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionDate3
    {
        
        /// <summary>
        /// Element <b>PmtDt</b> (Payment Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateFormat4Choice PmtDt;
        
        /// <summary>
        /// Element <b>AvlblDt</b> (Available Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DateFormat4Choice AvlblDt;
        
        /// <summary>
        /// Element <b>DvddRnkgDt</b> (Dividend Ranking Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateFormat4Choice DvddRnkgDt;
        
        /// <summary>
        /// Element <b>PrpssDt</b> (PariPassu Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DateFormat4Choice PrpssDt;
        
        /// <summary>
        /// Element <b>FrstDealgDt</b> (First Dealing Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public DateFormat4Choice FrstDealgDt;
        
        /// <summary>
        /// Element <b>EarlstPmtDt</b> (Earliest Payment Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public DateFormat4Choice EarlstPmtDt;
    }
    
    /// <summary>
    /// Class <b>ShareRanking1FormatChoice</b> (Share Ranking 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ShareRanking1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ShareRanking1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ShareRanking1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ShareRanking1Code</b> (Share Ranking 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum ShareRanking1Code
    {
        
        /// <summary>
        /// <b>DIVI - Dividend In Scope</b>.
        /// </summary>
        DIVI,
        
        /// <summary>
        /// <b>PARI - Pari Passu</b>.
        /// </summary>
        PARI,
    }
    
    /// <summary>
    /// Class <b>SecurityOption1</b> (Security Option 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class SecurityOption1
    {
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type FinancialInstrumentDescription3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FinancialInstrumentDescription3 SctyId;
        
        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CreditDebitCode CdtDbtInd;
        
        /// <summary>
        /// Element <b>SctiesQty</b> (Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public UnitOrFaceAmount1Choice SctiesQty;
        
        /// <summary>
        /// Element <b>MinExrcblSctiesQty</b> (Minimum Exercisable Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public UnitOrFaceAmount1Choice MinExrcblSctiesQty;
        
        /// <summary>
        /// Element <b>MinExrcblMltplSctiesQty</b> (Minimum Exercisable Multiple Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public UnitOrFaceAmount1Choice MinExrcblMltplSctiesQty;
        
        /// <summary>
        /// Element <b>NewDnmtnSctiesQty</b> (New Denomination Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public UnitOrFaceAmount1Choice NewDnmtnSctiesQty;
        
        /// <summary>
        /// Element <b>NewBrdLotSctiesQty</b> (New Board Lot Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public UnitOrFaceAmount1Choice NewBrdLotSctiesQty;
        
        /// <summary>
        /// Element <b>ShrRnkg</b> (Share Ranking) of type ShareRanking1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public ShareRanking1FormatChoice ShrRnkg;
        
        /// <summary>
        /// Element <b>AddtlQtyForSbcbdRsltntScties</b> (Additional Quantity For Subscribed Resultant Securities) of type QuantityToQuantityRatio1.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public QuantityToQuantityRatio1 AddtlQtyForSbcbdRsltntScties;
        
        /// <summary>
        /// Element <b>DtDtls</b> (Date Details) of type CorporateActionDate3.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public CorporateActionDate3 DtDtls;
        
        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type CorporateActionPrice4.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public CorporateActionPrice4 PricDtls;
        
        /// <summary>
        /// Element <b>TradgPrd</b> (Trading Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public Period1 TradgPrd;
        
        /// <summary>
        /// Element <b>AddtlQtyForExstgScties</b> (Additional Quantity For Existing Securities) of type QuantityToQuantityRatio1.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public QuantityToQuantityRatio1 AddtlQtyForExstgScties;
        
        /// <summary>
        /// Element <b>TempFinInstrmInd</b> (Temporary Financial Instrument Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public bool TempFinInstrmInd;
        
        /// <summary>
        /// Element <b>TempFinInstrmIndSpecified</b> (Temporary Financial Instrument Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TempFinInstrmIndSpecified;
        
        /// <summary>
        /// Element <b>FrctnDspstn</b> (Fraction Disposition) of type FractionDispositionType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public FractionDispositionType1FormatChoice FrctnDspstn;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentDescription3</b> (Financial Instrument Description 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class FinancialInstrumentDescription3
    {
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification7 SctyId;
        
        /// <summary>
        /// Element <b>PlcOfListg</b> (Place Of Listing) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PlcOfListg;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice SfkpgPlc;
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification7</b> (Security Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class SecurityIdentification7
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// ISIN (ISIN) of type string 
        /// OthrId (Other Identification) of type AlternateSecurityIdentification3 
        /// </summary>
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("OthrId", typeof(AlternateSecurityIdentification3), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Desc;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification3</b> (Alternate Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AlternateSecurityIdentification3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("DmstIdSrc", typeof(string), Order=1)]
        [XmlElementAttribute("PrtryIdSrc", typeof(string), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>DmstIdSrc - Domestic Identification Source</b>.
        /// </summary>
        DmstIdSrc,
        
        /// <summary>
        /// <b>PrtryIdSrc - Proprietary Identification Source</b>.
        /// </summary>
        PrtryIdSrc,
    }
    
    /// <summary>
    /// Class <b>UnitOrFaceAmount1Choice</b> (Unit Or Face Amount 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class UnitOrFaceAmount1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// FaceAmt (Face Amount) of type ActiveCurrencyAndAmount 
        /// Unit (Unit) of type decimal 
        /// </summary>
        [XmlElementAttribute("FaceAmt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("Unit", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>QuantityToQuantityRatio1</b> (Quantity To Quantity Ratio 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class QuantityToQuantityRatio1
    {
        
        /// <summary>
        /// Element <b>Qty1</b> (Quantity 1) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Qty1;
        
        /// <summary>
        /// Element <b>Qty2</b> (Quantity 2) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Qty2;
    }
    
    /// <summary>
    /// Class <b>Period1</b> (Period 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class Period1
    {
        
        /// <summary>
        /// Element <b>StartDt</b> (Start Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateFormat4Choice StartDt;
        
        /// <summary>
        /// Element <b>EndDt</b> (End Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DateFormat4Choice EndDt;
    }
    
    /// <summary>
    /// Class <b>CorporateActionPeriod2</b> (Corporate Action Period 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionPeriod2
    {
        
        /// <summary>
        /// Element <b>AssntdLinePrd</b> (Assented Line Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Period1 AssntdLinePrd;
        
        /// <summary>
        /// Element <b>ActnPrd</b> (Action Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Period1 ActnPrd;
        
        /// <summary>
        /// Element <b>PrvlgSspnsnPrd</b> (Privilege Suspension Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Period1 PrvlgSspnsnPrd;
        
        /// <summary>
        /// Element <b>ParllTradgPrd</b> (Parallel Trading Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public Period1 ParllTradgPrd;
        
        /// <summary>
        /// Element <b>SellThruIssrPrd</b> (Sell Thru Issuer Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public Period1 SellThruIssrPrd;
        
        /// <summary>
        /// Element <b>RvcbltyPrd</b> (Revocability Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public Period1 RvcbltyPrd;
        
        /// <summary>
        /// Element <b>PricClctnPrd</b> (Price Calculation Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public Period1 PricClctnPrd;
    }
    
    /// <summary>
    /// Class <b>PriceValueType6FormatChoice</b> (Price Value Type 6Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PriceValueType6FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type PriceValueType6Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(PriceValueType6Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>PriceValueType6Code</b> (Price Value Type 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum PriceValueType6Code
    {
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>OPEN - Open</b>.
        /// </summary>
        OPEN,
        
        /// <summary>
        /// <b>UNSP - ?undefined?</b>.
        /// </summary>
        UNSP,
        
        /// <summary>
        /// <b>TBSP - ?undefined?</b>.
        /// </summary>
        TBSP,
    }
    
    /// <summary>
    /// Class <b>AmountPricePerAmount1</b> (Amount Price Per Amount 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AmountPricePerAmount1
    {
        
        /// <summary>
        /// Element <b>AmtPricTp</b> (Amount Price Type) of type AmountPriceType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AmountPriceType1FormatChoice AmtPricTp;
        
        /// <summary>
        /// Element <b>PricVal</b> (Price Value) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAnd13DecimalAmount PricVal;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
    }
    
    /// <summary>
    /// Class <b>AmountPricePerFinancialInstrumentQuantity1</b> (Amount Price Per Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AmountPricePerFinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>AmtPricTp</b> (Amount Price Type) of type AmountPriceType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AmountPriceType1FormatChoice AmtPricTp;
        
        /// <summary>
        /// Element <b>PricVal</b> (Price Value) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAnd13DecimalAmount PricVal;
        
        /// <summary>
        /// Element <b>FinInstrmQty</b> (Financial Instrument Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public UnitOrFaceAmount1Choice FinInstrmQty;
    }
    
    /// <summary>
    /// Class <b>PriceFormat1Choice</b> (Price Format 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PriceFormat1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type AmountPrice1 
        /// AmtPricPerAmt (Amount Price Per Amount) of type AmountPricePerAmount1 
        /// AmtPricPerFinInstrmQty (Amount Price Per Financial Instrument Quantity) of type AmountPricePerFinancialInstrumentQuantity1 
        /// NotSpcfd (Not Specified) of type PriceValueType6FormatChoice 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(AmountPrice1), Order=0)]
        [XmlElementAttribute("AmtPricPerAmt", typeof(AmountPricePerAmount1), Order=0)]
        [XmlElementAttribute("AmtPricPerFinInstrmQty", typeof(AmountPricePerFinancialInstrumentQuantity1), Order=0)]
        [XmlElementAttribute("NotSpcfd", typeof(PriceValueType6FormatChoice), Order=0)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PriceFormat4Choice</b> (Price Format 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PriceFormat4Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type AmountPrice1 
        /// IndxPts (Index Points) of type decimal 
        /// NotSpcfd (Not Specified) of type PriceValueType5FormatChoice 
        /// Rate (Rate) of type PriceRate1 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(AmountPrice1), Order=0)]
        [XmlElementAttribute("IndxPts", typeof(decimal), Order=0)]
        [XmlElementAttribute("NotSpcfd", typeof(PriceValueType5FormatChoice), Order=0)]
        [XmlElementAttribute("Rate", typeof(PriceRate1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>CorporateActionPrice1</b> (Corporate Action Price 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionPrice1
    {
        
        /// <summary>
        /// Element <b>ExrcPric</b> (Exercise Price) of type PriceFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PriceFormat4Choice ExrcPric;
        
        /// <summary>
        /// Element <b>IssePric</b> (Issue Price) of type PriceFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceFormat2Choice IssePric;
        
        /// <summary>
        /// Element <b>CshInLieuOfShrPric</b> (Cash In Lieu Of Share Price) of type PriceFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PriceFormat2Choice CshInLieuOfShrPric;
        
        /// <summary>
        /// Element <b>TaxblIncmPerDvddShr</b> (Taxable Income Per Dividend Share) of type AmountPrice1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public AmountPrice1 TaxblIncmPerDvddShr;
        
        /// <summary>
        /// Element <b>GncCshPricRcvdPerPdct</b> (Generic Cash Price Received Per Product) of type PriceFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PriceFormat1Choice GncCshPricRcvdPerPdct;
        
        /// <summary>
        /// Element <b>GncCshPricPdPerPdct</b> (Generic Cash Price Paid Per Product) of type PriceFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PriceFormat2Choice GncCshPricPdPerPdct;
        
        /// <summary>
        /// Element <b>OverSbcptDpstPric</b> (Over Subscription Deposit Price) of type PriceFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PriceFormat2Choice OverSbcptDpstPric;
    }
    
    /// <summary>
    /// Class <b>AmountAndRateFormat2Choice</b> (Amount And Rate Format 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AmountAndRateFormat2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAndAmount 
        /// NotSpcfdRate (Not Specified Rate) of type RateType12FormatChoice 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("NotSpcfdRate", typeof(RateType12FormatChoice), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>RateType12FormatChoice</b> (Rate Type 12 Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RateType12FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RateType12Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RateType12Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RateType12Code</b> (Rate Type 12 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum RateType12Code
    {
        
        /// <summary>
        /// <b>OPEN - Open</b>.
        /// </summary>
        OPEN,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>NILP - Nil Payment</b>.
        /// </summary>
        NILP,
    }
    
    /// <summary>
    /// Class <b>NetDividendRateType1FormatChoice</b> (Net Dividend Rate Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class NetDividendRateType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type NetDividendRateType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(NetDividendRateType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>NetDividendRateType1Code</b> (Net Dividend Rate Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum NetDividendRateType1Code
    {
        
        /// <summary>
        /// <b>CAPO - Return Of Capital</b>.
        /// </summary>
        CAPO,
        
        /// <summary>
        /// <b>FLFR - Domestic - Franked Dividend (company)</b>.
        /// </summary>
        FLFR,
        
        /// <summary>
        /// <b>INCO - Incoming</b>.
        /// </summary>
        INCO,
        
        /// <summary>
        /// <b>INTR - Intermediary / Interest Payment</b>.
        /// </summary>
        INTR,
        
        /// <summary>
        /// <b>SOIC - Domestic - Other Income</b>.
        /// </summary>
        SOIC,
        
        /// <summary>
        /// <b>TXBL - ?undefined?</b>.
        /// </summary>
        TXBL,
        
        /// <summary>
        /// <b>TXDF - Tax Deferred</b>.
        /// </summary>
        TXDF,
        
        /// <summary>
        /// <b>TXFR - Tax Free</b>.
        /// </summary>
        TXFR,
        
        /// <summary>
        /// <b>UNFR - Domestic - Unfranked Dividend</b>.
        /// </summary>
        UNFR,
    }
    
    /// <summary>
    /// Class <b>NetDividendRate2</b> (Net Dividend Rate 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class NetDividendRate2
    {
        
        /// <summary>
        /// Element <b>RateTp</b> (Rate Type) of type NetDividendRateType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public NetDividendRateType1FormatChoice RateTp;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Class <b>NetDividendRate1Choice</b> (Net Dividend Rate 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class NetDividendRate1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAndAmount 
        /// NotSpcfdRate (Not Specified Rate) of type RateValueType6FormatChoice 
        /// RateTpAmt (Rate Type Amount) of type NetDividendRate2 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("NotSpcfdRate", typeof(RateValueType6FormatChoice), Order=0)]
        [XmlElementAttribute("RateTpAmt", typeof(NetDividendRate2), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>RateValueType6FormatChoice</b> (Rate Value Type 6Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RateValueType6FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RateValueType6Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RateValueType6Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RateValueType6Code</b> (Rate Value Type 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum RateValueType6Code
    {
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>OPEN - Open</b>.
        /// </summary>
        OPEN,
    }
    
    /// <summary>
    /// Class <b>GrossDividendRateType1FormatChoice</b> (Gross Dividend Rate Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class GrossDividendRateType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type GrossDividendRateType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(GrossDividendRateType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>GrossDividendRateType1Code</b> (Gross Dividend Rate Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum GrossDividendRateType1Code
    {
        
        /// <summary>
        /// <b>CAPO - Return Of Capital</b>.
        /// </summary>
        CAPO,
        
        /// <summary>
        /// <b>FLFR - Domestic - Franked Dividend (company)</b>.
        /// </summary>
        FLFR,
        
        /// <summary>
        /// <b>INCO - Incoming</b>.
        /// </summary>
        INCO,
        
        /// <summary>
        /// <b>INTR - Intermediary / Interest Payment</b>.
        /// </summary>
        INTR,
        
        /// <summary>
        /// <b>SOIC - Domestic - Other Income</b>.
        /// </summary>
        SOIC,
        
        /// <summary>
        /// <b>TXBL - ?undefined?</b>.
        /// </summary>
        TXBL,
        
        /// <summary>
        /// <b>TXDF - Tax Deferred</b>.
        /// </summary>
        TXDF,
        
        /// <summary>
        /// <b>TXFR - Tax Free</b>.
        /// </summary>
        TXFR,
        
        /// <summary>
        /// <b>UNFR - Domestic - Unfranked Dividend</b>.
        /// </summary>
        UNFR,
        
        /// <summary>
        /// <b>LTCG - ?undefined?</b>.
        /// </summary>
        LTCG,
        
        /// <summary>
        /// <b>STCG - ?undefined?</b>.
        /// </summary>
        STCG,
    }
    
    /// <summary>
    /// Class <b>GrossDividendRate2</b> (Gross Dividend Rate 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class GrossDividendRate2
    {
        
        /// <summary>
        /// Element <b>RateTp</b> (Rate Type) of type GrossDividendRateType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public GrossDividendRateType1FormatChoice RateTp;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Class <b>RateValueType2FormatChoice</b> (Rate Value Type 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RateValueType2FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RateValueType2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RateValueType2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RateValueType2Code</b> (Rate Value Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum RateValueType2Code
    {
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>OPEN - Open</b>.
        /// </summary>
        OPEN,
        
        /// <summary>
        /// <b>NILP - Nil Payment</b>.
        /// </summary>
        NILP,
    }
    
    /// <summary>
    /// Class <b>GrossDividendRate1Choice</b> (Gross Dividend Rate 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class GrossDividendRate1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAndAmount 
        /// NotSpcfdRate (Not Specified Rate) of type RateValueType2FormatChoice 
        /// RateTpAmt (Rate Type Amount) of type GrossDividendRate2 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("NotSpcfdRate", typeof(RateValueType2FormatChoice), Order=0)]
        [XmlElementAttribute("RateTpAmt", typeof(GrossDividendRate2), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>TaxType3FormatChoice</b> (Tax Type 3Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class TaxType3FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type TaxType3Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(TaxType3Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>TaxType3Code</b> (Tax Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum TaxType3Code
    {
        
        /// <summary>
        /// <b>LIDT - Local Tax (DE specific)</b>.
        /// </summary>
        LIDT,
        
        /// <summary>
        /// <b>WITF - Withholding of Foreign Tax</b>.
        /// </summary>
        WITF,
        
        /// <summary>
        /// <b>WITL - Withholding of Local Tax</b>.
        /// </summary>
        WITL,
    }
    
    /// <summary>
    /// Class <b>RelatedTaxType1</b> (Related Tax Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RelatedTaxType1
    {
        
        /// <summary>
        /// Element <b>TaxTp</b> (Tax Type) of type TaxType3FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxType3FormatChoice TaxTp;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Class <b>RatioFormat1Choice</b> (Ratio Format 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RatioFormat1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AmtToAmt (Amount To Amount) of type AmountToAmountRatio1 
        /// NotSpcfdRate (Not Specified Rate) of type RateType12FormatChoice 
        /// QtyToQty (Quantity To Quantity) of type QuantityToQuantityRatio1 
        /// </summary>
        [XmlElementAttribute("AmtToAmt", typeof(AmountToAmountRatio1), Order=0)]
        [XmlElementAttribute("NotSpcfdRate", typeof(RateType12FormatChoice), Order=0)]
        [XmlElementAttribute("QtyToQty", typeof(QuantityToQuantityRatio1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>AmountToAmountRatio1</b> (Amount To Amount Ratio 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AmountToAmountRatio1
    {
        
        /// <summary>
        /// Element <b>Amt1</b> (Amount 1) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAndAmount Amt1;
        
        /// <summary>
        /// Element <b>Amt2</b> (Amount 2) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount Amt2;
    }
    
    /// <summary>
    /// Class <b>AmountAndQuantityRatio1</b> (Amount And Quantity Ratio 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AmountAndQuantityRatio1
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>Qty</b> (Quantity) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Qty;
    }
    
    /// <summary>
    /// Class <b>RatioFormat2Choice</b> (Ratio Format 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RatioFormat2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AmtToAmt (Amount To Amount) of type AmountToAmountRatio1 
        /// AmtToQty (Amount To Quantity) of type AmountAndQuantityRatio1 
        /// NotSpcfdRate (Not Specified Rate) of type RateType12FormatChoice 
        /// QtyToAmt (Quantity To Amount) of type AmountAndQuantityRatio1 
        /// QtyToQty (Quantity To Quantity) of type QuantityToQuantityRatio1 
        /// </summary>
        [XmlElementAttribute("AmtToAmt", typeof(AmountToAmountRatio1), Order=0)]
        [XmlElementAttribute("AmtToQty", typeof(AmountAndQuantityRatio1), Order=0)]
        [XmlElementAttribute("NotSpcfdRate", typeof(RateType12FormatChoice), Order=0)]
        [XmlElementAttribute("QtyToAmt", typeof(AmountAndQuantityRatio1), Order=0)]
        [XmlElementAttribute("QtyToQty", typeof(QuantityToQuantityRatio1), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>AmtToAmt - Amount To Amount</b>.
        /// </summary>
        AmtToAmt,
        
        /// <summary>
        /// <b>AmtToQty - Amount To Quantity</b>.
        /// </summary>
        AmtToQty,
        
        /// <summary>
        /// <b>NotSpcfdRate - Not Specified Rate</b>.
        /// </summary>
        NotSpcfdRate,
        
        /// <summary>
        /// <b>QtyToAmt - Quantity To Amount</b>.
        /// </summary>
        QtyToAmt,
        
        /// <summary>
        /// <b>QtyToQty - Quantity To Quantity</b>.
        /// </summary>
        QtyToQty,
    }
    
    /// <summary>
    /// Class <b>CorporateActionRate2</b> (Corporate Action Rate 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionRate2
    {
        
        /// <summary>
        /// Element <b>WhldgTax</b> (Withholding Tax) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RateFormat1Choice WhldgTax;
        
        /// <summary>
        /// Element <b>WhldgOfFrgnTax</b> (Withholding Of Foreign Tax) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public RateAndAmountFormat1Choice WhldgOfFrgnTax;
        
        /// <summary>
        /// Element <b>WhldgOfLclTax</b> (Withholding Of Local Tax) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public RateAndAmountFormat1Choice WhldgOfLclTax;
        
        /// <summary>
        /// Element <b>GrmnLclTax1</b> (German Local Tax 1) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public RateAndAmountFormat1Choice GrmnLclTax1;
        
        /// <summary>
        /// Element <b>GrmnLclTax2</b> (German Local Tax 2) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public RateAndAmountFormat1Choice GrmnLclTax2;
        
        /// <summary>
        /// Element <b>GrmnLclTax3</b> (German Local Tax 3) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public RateAndAmountFormat1Choice GrmnLclTax3;
        
        /// <summary>
        /// Element <b>GrmnLclTax4</b> (German Local Tax 4) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public RateAndAmountFormat1Choice GrmnLclTax4;
        
        /// <summary>
        /// Element <b>TaxOnIncm</b> (Tax On Income) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public RateFormat1Choice TaxOnIncm;
        
        /// <summary>
        /// Element <b>TaxOnPrft</b> (Tax On Profit) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public RateFormat1Choice TaxOnPrft;
        
        /// <summary>
        /// Element <b>TaxRclm</b> (Tax Reclaim) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public RateFormat1Choice TaxRclm;
        
        /// <summary>
        /// Element <b>FsclStmp</b> (Fiscal Stamp) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public RateFormat1Choice FsclStmp;
        
        /// <summary>
        /// Element <b>Prratn</b> (Proration) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public RateFormat1Choice Prratn;
        
        /// <summary>
        /// Element <b>NewToOd</b> (New To Old) of type RatioFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public RatioFormat2Choice NewToOd;
        
        /// <summary>
        /// Element <b>NewSctiesToUndrlygScties</b> (New Securities To Underlying Securities) of type RatioFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public RatioFormat2Choice NewSctiesToUndrlygScties;
        
        /// <summary>
        /// Element <b>AddtlQtyForExstgScties</b> (Additional Quantity For Existing Securities) of type RatioFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public RatioFormat1Choice AddtlQtyForExstgScties;
        
        /// <summary>
        /// Element <b>AddtlQtyForSbcbdRsltntScties</b> (Additional Quantity For Subscribed Resultant Securities) of type RatioFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public RatioFormat1Choice AddtlQtyForSbcbdRsltntScties;
        
        /// <summary>
        /// Element <b>RltdTax</b> (Related Tax) of type RelatedTaxType1.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public RelatedTaxType1 RltdTax;
        
        /// <summary>
        /// Element <b>NonResdtRate</b> (Non Resident Rate) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public RateAndAmountFormat1Choice NonResdtRate;
        
        /// <summary>
        /// Element <b>Chrgs</b> (Charges) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public RateAndAmountFormat1Choice Chrgs;
        
        /// <summary>
        /// Element <b>IntrstForUsdPmt</b> (Interest For Used Payment) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public RateAndAmountFormat1Choice IntrstForUsdPmt;
        
        /// <summary>
        /// Element <b>IndxFctr</b> (Index Factor) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public RateAndAmountFormat1Choice IndxFctr;
        
        /// <summary>
        /// Element <b>FullyFrnkd</b> (Fully Franked) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=21)]
        public RateAndAmountFormat1Choice FullyFrnkd;
        
        /// <summary>
        /// Element <b>GrssDvdd</b> (Gross Dividend) of type GrossDividendRate1Choice.
        /// </summary>
        [XmlElementAttribute(Order=22)]
        public GrossDividendRate1Choice GrssDvdd;
        
        /// <summary>
        /// Element <b>NetDvdd</b> (Net Dividend) of type NetDividendRate1Choice.
        /// </summary>
        [XmlElementAttribute(Order=23)]
        public NetDividendRate1Choice NetDvdd;
        
        /// <summary>
        /// Element <b>FnlDvdd</b> (Final Dividend) of type AmountAndRateFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=24)]
        public AmountAndRateFormat2Choice FnlDvdd;
        
        /// <summary>
        /// Element <b>PrvsnlDvdd</b> (Provisional Dividend) of type AmountAndRateFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=25)]
        public AmountAndRateFormat2Choice PrvsnlDvdd;
        
        /// <summary>
        /// Element <b>CshIncntiv</b> (Cash Incentive) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=26)]
        public RateFormat1Choice CshIncntiv;
        
        /// <summary>
        /// Element <b>SlctnFee</b> (Solicitation Fee) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=27)]
        public RateFormat1Choice SlctnFee;
        
        /// <summary>
        /// Element <b>MaxAllwdOvrsbcpt</b> (Maximum Allowed Oversubscription) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=28)]
        public RateFormat1Choice MaxAllwdOvrsbcpt;
        
        /// <summary>
        /// Element <b>AddtlTax</b> (Additional Tax) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=29)]
        public RateAndAmountFormat1Choice AddtlTax;
        
        /// <summary>
        /// Element <b>OrgnlAmt</b> (Original Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=30)]
        public ActiveCurrencyAndAmount OrgnlAmt;
        
        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type ForeignExchangeTerms8.
        /// </summary>
        [XmlElementAttribute(Order=31)]
        public ForeignExchangeTerms8 XchgRate;
        
        /// <summary>
        /// Element <b>AplblRate</b> (Applicable Rate) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=32)]
        public RateFormat1Choice AplblRate;
    }
    
    /// <summary>
    /// Class <b>RateFormat1Choice</b> (Rate Format 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RateFormat1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// NotSpcfdRate (Not Specified Rate) of type RateType12FormatChoice 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("NotSpcfdRate", typeof(RateType12FormatChoice), Order=0)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>RateAndAmountFormat1Choice</b> (Rate And Amount Format 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RateAndAmountFormat1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAndAmount 
        /// NotSpcfdRate (Not Specified Rate) of type RateType12FormatChoice 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("NotSpcfdRate", typeof(RateType12FormatChoice), Order=0)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>CorporateActionDate4</b> (Corporate Action Date 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionDate4
    {
        
        /// <summary>
        /// Element <b>CpnClpngDt</b> (Coupon Clipping Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateFormat4Choice CpnClpngDt;
        
        /// <summary>
        /// Element <b>CnsntXprtnDt</b> (Consent Expiration Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DateFormat4Choice CnsntXprtnDt;
        
        /// <summary>
        /// Element <b>CnsntRcrdDt</b> (Consent Record Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateFormat4Choice CnsntRcrdDt;
        
        /// <summary>
        /// Element <b>PmtDt</b> (Payment Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DateFormat4Choice PmtDt;
        
        /// <summary>
        /// Element <b>EarlstPmtDt</b> (Earliest Payment Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public DateFormat4Choice EarlstPmtDt;
        
        /// <summary>
        /// Element <b>MktDdln</b> (Market Deadline) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public DateFormat4Choice MktDdln;
        
        /// <summary>
        /// Element <b>RspnDdln</b> (Response Deadline) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public DateFormat4Choice RspnDdln;
        
        /// <summary>
        /// Element <b>DdlnToSplt</b> (Deadline To Split) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public DateFormat4Choice DdlnToSplt;
        
        /// <summary>
        /// Element <b>XpryDt</b> (Expiry Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public DateFormat4Choice XpryDt;
        
        /// <summary>
        /// Element <b>QtnSetngDt</b> (Quotation Setting Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public DateFormat4Choice QtnSetngDt;
        
        /// <summary>
        /// Element <b>SbcptCostDbtDt</b> (Subscription Cost Debit Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public DateFormat4Choice SbcptCostDbtDt;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification2Choice</b> (Account Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AccountIdentification2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("CshAcctId", typeof(string), Order=0)]
        [XmlElementAttribute("SctiesAcctId", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>CshAcctId - Cash Account Identification</b>.
        /// </summary>
        CshAcctId,
        
        /// <summary>
        /// <b>SctiesAcctId - Securities Account Identification</b>.
        /// </summary>
        SctiesAcctId,
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventStatus2FormatChoice</b> (Corporate Action Event Status 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionEventStatus2FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionEventStatus2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionEventStatus2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventStatus2Code</b> (Corporate Action Event Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionEventStatus2Code
    {
        
        /// <summary>
        /// <b>ACTI - ?undefined?</b>.
        /// </summary>
        ACTI,
        
        /// <summary>
        /// <b>CANC - Request To Cancel</b>.
        /// </summary>
        CANC,
        
        /// <summary>
        /// <b>INAC - Invalid Account Servicer</b>.
        /// </summary>
        INAC,
    }
    
    /// <summary>
    /// Class <b>CorporateActionOption1</b> (Corporate Action Option 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionOption1
    {
        
        /// <summary>
        /// Element <b>OptnNb</b> (Option Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string OptnNb;
        
        /// <summary>
        /// Element <b>OptnTp</b> (Option Type) of type CorporateActionOption1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CorporateActionOption1FormatChoice OptnTp;
        
        /// <summary>
        /// Element <b>OptnAvlbtySts</b> (Option Availability Status) of type CorporateActionEventStatus2FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CorporateActionEventStatus2FormatChoice OptnAvlbtySts;
        
        /// <summary>
        /// Element <b>CertfctnInd</b> (Certification Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool CertfctnInd;
        
        /// <summary>
        /// Element <b>CertfctnIndSpecified</b> (Certification Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CertfctnIndSpecified;
        
        /// <summary>
        /// Element <b>CertfctnTp</b> (Certification Type) of type BeneficiaryCertificationType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public BeneficiaryCertificationType1FormatChoice CertfctnTp;
        
        /// <summary>
        /// Element <b>AssntdLineSctyId</b> (Assented Line Security Identification) of type SecurityIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public SecurityIdentification7 AssntdLineSctyId;
        
        /// <summary>
        /// Element <b>AgtSctiesAcctId</b> (Agent Securities Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string AgtSctiesAcctId;
        
        /// <summary>
        /// Element <b>AgtCshAcctId</b> (Agent Cash Account Identification) of type AccountIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public AccountIdentification2Choice AgtCshAcctId;
        
        /// <summary>
        /// Element <b>OfferTp</b> (Offer Type) of type array of OfferType1FormatChoice.
        /// </summary>
        [XmlElementAttribute("OfferTp", Order=8)]
        public OfferType1FormatChoice[] OfferTp;
        
        /// <summary>
        /// Element <b>IntrmdtSctiesDstrbtnTp</b> (Intermediate Securities Distribution Type) of type IntermediateSecurityDistributionType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public IntermediateSecurityDistributionType1FormatChoice IntrmdtSctiesDstrbtnTp;
        
        /// <summary>
        /// Element <b>WdrwlAllwdInd</b> (Withdrawal Allowed Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public bool WdrwlAllwdInd;
        
        /// <summary>
        /// Element <b>ChngAllwdInd</b> (Change Allowed Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public bool ChngAllwdInd;
        
        /// <summary>
        /// Element <b>DtDtls</b> (Date Details) of type CorporateActionDate4.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public CorporateActionDate4 DtDtls;
        
        /// <summary>
        /// Element <b>RateAndAmtDtls</b> (Rate And Amount Details) of type CorporateActionRate2.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public CorporateActionRate2 RateAndAmtDtls;
        
        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type CorporateActionPrice1.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public CorporateActionPrice1 PricDtls;
        
        /// <summary>
        /// Element <b>PrdDtls</b> (Period Details) of type CorporateActionPeriod2.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public CorporateActionPeriod2 PrdDtls;
        
        /// <summary>
        /// Element <b>SctiesMvmntDtls</b> (Securities Movement Details) of type array of SecurityOption1.
        /// </summary>
        [XmlElementAttribute("SctiesMvmntDtls", Order=16)]
        public SecurityOption1[] SctiesMvmntDtls;
        
        /// <summary>
        /// Element <b>CshMvmntDtls</b> (Cash Movement Details) of type array of CashOption1.
        /// </summary>
        [XmlElementAttribute("CshMvmntDtls", Order=17)]
        public CashOption1[] CshMvmntDtls;
        
        /// <summary>
        /// Element <b>CorpActnOthrAgtDtls</b> (Corporate Action Other Agent Details) of type array of CorporateActionAgent1.
        /// </summary>
        [XmlElementAttribute("CorpActnOthrAgtDtls", Order=18)]
        public CorporateActionAgent1[] CorpActnOthrAgtDtls;
        
        /// <summary>
        /// Element <b>FrctnDspstn</b> (Fraction Disposition) of type FractionDispositionType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public FractionDispositionType1FormatChoice FrctnDspstn;
        
        /// <summary>
        /// Element <b>RedChrgsApldInd</b> (Redemption Charges Applied Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public bool RedChrgsApldInd;
        
        /// <summary>
        /// Element <b>RedChrgsApldIndSpecified</b> (Redemption Charges Applied Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RedChrgsApldIndSpecified;
        
        /// <summary>
        /// Element <b>OptnFeatrs</b> (Option Features) of type array of OptionFeatures1FormatChoice.
        /// </summary>
        [XmlElementAttribute("OptnFeatrs", Order=21)]
        public OptionFeatures1FormatChoice[] OptnFeatrs;
        
        /// <summary>
        /// Element <b>CorpActnAddtlInf</b> (Corporate Action Additional Information) of type CorporateActionNarrative1.
        /// </summary>
        [XmlElementAttribute(Order=22)]
        public CorporateActionNarrative1 CorpActnAddtlInf;
    }
    
    /// <summary>
    /// Class <b>CorporateActionOption1FormatChoice</b> (Corporate Action Option 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionOption1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionOptionType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionOptionType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionOptionType1Code</b> (Corporate Action Option Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionOptionType1Code
    {
        
        /// <summary>
        /// <b>BSPL - Bonus Share Plan</b>.
        /// </summary>
        BSPL,
        
        /// <summary>
        /// <b>BUYA - Buy Up</b>.
        /// </summary>
        BUYA,
        
        /// <summary>
        /// <b>CASE - Cash and Securities</b>.
        /// </summary>
        CASE,
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CEXC - Consent and Exchange</b>.
        /// </summary>
        CEXC,
        
        /// <summary>
        /// <b>CTEN - Consent and Tender</b>.
        /// </summary>
        CTEN,
        
        /// <summary>
        /// <b>CONN - Consent Denied</b>.
        /// </summary>
        CONN,
        
        /// <summary>
        /// <b>CONY - Consent Granted</b>.
        /// </summary>
        CONY,
        
        /// <summary>
        /// <b>EXER - Exercise</b>.
        /// </summary>
        EXER,
        
        /// <summary>
        /// <b>LAPS - Lapse</b>.
        /// </summary>
        LAPS,
        
        /// <summary>
        /// <b>MPUT - Retain</b>.
        /// </summary>
        MPUT,
        
        /// <summary>
        /// <b>NOAC - No Action</b>.
        /// </summary>
        NOAC,
        
        /// <summary>
        /// <b>OFFR - Offer / Proposed Rate</b>.
        /// </summary>
        OFFR,
        
        /// <summary>
        /// <b>OVER - Normal Processing Period Lapsed / Oversubscribe</b>.
        /// </summary>
        OVER,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>SLLE - Sell Entitlement</b>.
        /// </summary>
        SLLE,
        
        /// <summary>
        /// <b>SPLI - Split Instruction</b>.
        /// </summary>
        SPLI,
        
        /// <summary>
        /// <b>NOQU - Non Qualified Investor</b>.
        /// </summary>
        NOQU,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>QINV - Qualified Investor</b>.
        /// </summary>
        QINV,
    }
    
    /// <summary>
    /// Class <b>BeneficiaryCertificationType1FormatChoice</b> (Beneficiary Certification Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class BeneficiaryCertificationType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type BeneficiaryCertificationType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(BeneficiaryCertificationType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>BeneficiaryCertificationType1Code</b> (Beneficiary Certification Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum BeneficiaryCertificationType1Code
    {
        
        /// <summary>
        /// <b>ACCI - Accredited Investor</b>.
        /// </summary>
        ACCI,
        
        /// <summary>
        /// <b>DOMI - Domicile Only</b>.
        /// </summary>
        DOMI,
        
        /// <summary>
        /// <b>FULL - ?undefined?</b>.
        /// </summary>
        FULL,
        
        /// <summary>
        /// <b>QIBB - ?undefined?</b>.
        /// </summary>
        QIBB,
        
        /// <summary>
        /// <b>TRBD - ?undefined?</b>.
        /// </summary>
        TRBD,
        
        /// <summary>
        /// <b>NCOM - ?undefined?</b>.
        /// </summary>
        NCOM,
    }
    
    /// <summary>
    /// Class <b>OfferType1FormatChoice</b> (Offer Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class OfferType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type OfferType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(OfferType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>OfferType1Code</b> (Offer Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum OfferType1Code
    {
        
        /// <summary>
        /// <b>DISS - Dissolution</b>.
        /// </summary>
        DISS,
        
        /// <summary>
        /// <b>ERUN - ?undefined?</b>.
        /// </summary>
        ERUN,
        
        /// <summary>
        /// <b>FCFS - ?undefined?</b>.
        /// </summary>
        FCFS,
        
        /// <summary>
        /// <b>FINL - Final</b>.
        /// </summary>
        FINL,
        
        /// <summary>
        /// <b>MINI - ?undefined?</b>.
        /// </summary>
        MINI,
        
        /// <summary>
        /// <b>PART - Formal Partnership</b>.
        /// </summary>
        PART,
        
        /// <summary>
        /// <b>SQUE - ?undefined?</b>.
        /// </summary>
        SQUE,
    }
    
    /// <summary>
    /// Class <b>IntermediateSecurityDistributionType1FormatChoice</b> (Intermediate Security Distribution Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class IntermediateSecurityDistributionType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type IntermediateSecurityDistributionType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(IntermediateSecurityDistributionType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>IntermediateSecurityDistributionType1Code</b> (Intermediate Security Distribution Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum IntermediateSecurityDistributionType1Code
    {
        
        /// <summary>
        /// <b>BIDS - Repurchase Offer/Issuer Bid/Reverse Rights</b>.
        /// </summary>
        BIDS,
        
        /// <summary>
        /// <b>BONU - Bonus Issue / Capitalisation Issue</b>.
        /// </summary>
        BONU,
        
        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
        
        /// <summary>
        /// <b>DVCA - Cash Dividend</b>.
        /// </summary>
        DVCA,
        
        /// <summary>
        /// <b>DVOP - Dividend Option</b>.
        /// </summary>
        DVOP,
        
        /// <summary>
        /// <b>EXRI - Call On Rights</b>.
        /// </summary>
        EXRI,
        
        /// <summary>
        /// <b>PRIO - Priority Issue</b>.
        /// </summary>
        PRIO,
        
        /// <summary>
        /// <b>DVSC - Scrip Dividend/Payment</b>.
        /// </summary>
        DVSC,
        
        /// <summary>
        /// <b>DVSE - Stock Dividend</b>.
        /// </summary>
        DVSE,
        
        /// <summary>
        /// <b>INTR - Intermediary / Interest Payment</b>.
        /// </summary>
        INTR,
        
        /// <summary>
        /// <b>LIQU - Liquidation</b>.
        /// </summary>
        LIQU,
        
        /// <summary>
        /// <b>SOFF - Spin Off</b>.
        /// </summary>
        SOFF,
    }
    
    /// <summary>
    /// Class <b>CorporateActionNarrative1</b> (Corporate Action Narrative 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionNarrative1
    {
        
        /// <summary>
        /// Element <b>InfConds</b> (Information Conditions) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string InfConds;
        
        /// <summary>
        /// Element <b>InfToCmplyWth</b> (Information To Comply With) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string InfToCmplyWth;
        
        /// <summary>
        /// Element <b>TaxtnConds</b> (Taxation Conditions) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string TaxtnConds;
        
        /// <summary>
        /// Element <b>NewCpnyNm</b> (New Company Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string NewCpnyNm;
        
        /// <summary>
        /// Element <b>Offerr</b> (Offeror) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification2Choice Offerr;
        
        /// <summary>
        /// Element <b>URLAdr</b> (URL Address) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string URLAdr;
        
        /// <summary>
        /// Element <b>AddtlTxt</b> (Additional Text) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string AddtlTxt;
    }
    
    /// <summary>
    /// Class <b>DistributionType1FormatChoice</b> (Distribution Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class DistributionType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type DistributionType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(DistributionType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>DistributionType1Code</b> (Distribution Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum DistributionType1Code
    {
        
        /// <summary>
        /// <b>ROLL - ?undefined?</b>.
        /// </summary>
        ROLL,
    }
    
    /// <summary>
    /// Class <b>ConversionType1FormatChoice</b> (Conversion Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ConversionType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ConversionType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ConversionType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ConversionType1Code</b> (Conversion Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum ConversionType1Code
    {
        
        /// <summary>
        /// <b>FINL - Final</b>.
        /// </summary>
        FINL,
        
        /// <summary>
        /// <b>INTE - Interest</b>.
        /// </summary>
        INTE,
    }
    
    /// <summary>
    /// Class <b>RenounceableStatus1FormatChoice</b> (Renounceable Status 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class RenounceableStatus1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RenounceableStatus1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RenounceableStatus1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RenounceableStatus1Code</b> (Renounceable Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum RenounceableStatus1Code
    {
        
        /// <summary>
        /// <b>NREN - Non Renounceable</b>.
        /// </summary>
        NREN,
        
        /// <summary>
        /// <b>RENO - Renounceable</b>.
        /// </summary>
        RENO,
    }
    
    /// <summary>
    /// Class <b>AmountAndRateFormat3Choice</b> (Amount And Rate Format 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class AmountAndRateFormat3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAndAmount 
        /// NotSpcfdRate (Not Specified Rate) of type RateValueType6FormatChoice 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("NotSpcfdRate", typeof(RateValueType6FormatChoice), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>CorporateActionRate1</b> (Corporate Action Rate 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionRate1
    {
        
        /// <summary>
        /// Element <b>Intrst</b> (Interest) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RateAndAmountFormat1Choice Intrst;
        
        /// <summary>
        /// Element <b>RltdIndx</b> (Related Index) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public RateFormat1Choice RltdIndx;
        
        /// <summary>
        /// Element <b>PctgSght</b> (Percentage Sought) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public RateFormat1Choice PctgSght;
        
        /// <summary>
        /// Element <b>RinvstmtDscntToMkt</b> (Reinvestment Discount To Market) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public RateFormat1Choice RinvstmtDscntToMkt;
        
        /// <summary>
        /// Element <b>Sprd</b> (Spread) of type RateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public RateFormat1Choice Sprd;
        
        /// <summary>
        /// Element <b>BidIntrvl</b> (Bid Interval) of type AmountAndRateFormat3Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public AmountAndRateFormat3Choice BidIntrvl;
        
        /// <summary>
        /// Element <b>Chrgs</b> (Charges) of type RateAndAmountFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public RateAndAmountFormat1Choice Chrgs;
    }
    
    /// <summary>
    /// Class <b>CorporateActionPeriod1</b> (Corporate Action Period 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionPeriod1
    {
        
        /// <summary>
        /// Element <b>ActnPrd</b> (Action Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Period1 ActnPrd;
        
        /// <summary>
        /// Element <b>CmplsryPurchsPrd</b> (Compulsory Purchase Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Period1 CmplsryPurchsPrd;
        
        /// <summary>
        /// Element <b>IntrstPrd</b> (Interest Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Period1 IntrstPrd;
        
        /// <summary>
        /// Element <b>BlckgPrd</b> (Blocking Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public Period1 BlckgPrd;
        
        /// <summary>
        /// Element <b>PricClctnPrd</b> (Price Calculation Period) of type Period1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public Period1 PricClctnPrd;
    }
    
    /// <summary>
    /// Class <b>PriceFormat3Choice</b> (Price Format 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class PriceFormat3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type AmountPrice1 
        /// Rate (Rate) of type PriceRate1 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(AmountPrice1), Order=0)]
        [XmlElementAttribute("Rate", typeof(PriceRate1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>CorporateActionPrice2</b> (Corporate Action Price 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionPrice2
    {
        
        /// <summary>
        /// Element <b>MaxPric</b> (Maximum Price) of type PriceFormat3Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PriceFormat3Choice MaxPric;
        
        /// <summary>
        /// Element <b>MinPric</b> (Minimum Price) of type PriceFormat3Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceFormat3Choice MinPric;
    }
    
    /// <summary>
    /// Class <b>CorporateActionDate2</b> (Corporate Action Date 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionDate2
    {
        
        /// <summary>
        /// Element <b>RcrdDt</b> (Record Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateFormat4Choice RcrdDt;
        
        /// <summary>
        /// Element <b>FctvDt</b> (Effective Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DateFormat4Choice FctvDt;
        
        /// <summary>
        /// Element <b>CoverXprtnDt</b> (Cover Expiration Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateFormat4Choice CoverXprtnDt;
        
        /// <summary>
        /// Element <b>EqulstnDt</b> (Equalisation Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DateFormat4Choice EqulstnDt;
        
        /// <summary>
        /// Element <b>MrgnFxgDt</b> (Margin Fixing Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public DateFormat4Choice MrgnFxgDt;
        
        /// <summary>
        /// Element <b>LtryDt</b> (Lottery Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public DateFormat4Choice LtryDt;
        
        /// <summary>
        /// Element <b>PrtctDt</b> (Protect Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public DateFormat4Choice PrtctDt;
        
        /// <summary>
        /// Element <b>UcondlDt</b> (Unconditional Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public DateFormat4Choice UcondlDt;
        
        /// <summary>
        /// Element <b>WhlyUcondlDt</b> (Wholly Unconditional Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public DateFormat4Choice WhlyUcondlDt;
        
        /// <summary>
        /// Element <b>RsltsPblctnDt</b> (Results Publication Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public DateFormat4Choice RsltsPblctnDt;
        
        /// <summary>
        /// Element <b>CrtApprvlDt</b> (Court Approval Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public DateFormat4Choice CrtApprvlDt;
        
        /// <summary>
        /// Element <b>EarlyClsgDt</b> (Early Closing Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public DateFormat4Choice EarlyClsgDt;
        
        /// <summary>
        /// Element <b>ExDvddDt</b> (Ex Dividend Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public DateFormat4Choice ExDvddDt;
        
        /// <summary>
        /// Element <b>IndxFxgDt</b> (Index Fixing Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public DateFormat4Choice IndxFxgDt;
        
        /// <summary>
        /// Element <b>MtrtyDt</b> (Maturity Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public DateFormat4Choice MtrtyDt;
        
        /// <summary>
        /// Element <b>TradgSspdDt</b> (Trading Suspended Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public DateFormat4Choice TradgSspdDt;
        
        /// <summary>
        /// Element <b>CertfctnDdln</b> (Certification Deadline) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public DateFormat4Choice CertfctnDdln;
        
        /// <summary>
        /// Element <b>RedDt</b> (Redemption Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public DateFormat4Choice RedDt;
        
        /// <summary>
        /// Element <b>RegnDdln</b> (Registration Deadline) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public DateFormat4Choice RegnDdln;
        
        /// <summary>
        /// Element <b>PrratnDt</b> (Proration Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public DateFormat4Choice PrratnDt;
        
        /// <summary>
        /// Element <b>DdlnForTaxBrkdwnInstr</b> (Deadline For Tax Breakdown Instruction) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public DateFormat4Choice DdlnForTaxBrkdwnInstr;
        
        /// <summary>
        /// Element <b>LpsdDt</b> (Lapsed Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=21)]
        public DateFormat4Choice LpsdDt;
        
        /// <summary>
        /// Element <b>GrntedPrtcptnDt</b> (Guaranteed Participation Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=22)]
        public DateFormat4Choice GrntedPrtcptnDt;
        
        /// <summary>
        /// Element <b>ElctnToCtrPtyDdln</b> (Election To Ctr Party Deadline) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=23)]
        public DateFormat4Choice ElctnToCtrPtyDdln;
        
        /// <summary>
        /// Element <b>SpclExDt</b> (Special Ex Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=24)]
        public DateFormat4Choice SpclExDt;
    }
    
    /// <summary>
    /// Class <b>CorporateActionFrequencyType1FormatChoice</b> (Corporate Action Frequency Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionFrequencyType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionFrequencyType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionFrequencyType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionFrequencyType1Code</b> (Corporate Action Frequency Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionFrequencyType1Code
    {
        
        /// <summary>
        /// <b>FINL - Final</b>.
        /// </summary>
        FINL,
        
        /// <summary>
        /// <b>INTE - Interest</b>.
        /// </summary>
        INTE,
        
        /// <summary>
        /// <b>REGR - ?undefined?</b>.
        /// </summary>
        REGR,
        
        /// <summary>
        /// <b>SPEC - ?undefined?</b>.
        /// </summary>
        SPEC,
    }
    
    /// <summary>
    /// Class <b>LotteryType1FormatChoice</b> (Lottery Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class LotteryType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type LotteryType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(LotteryType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>LotteryType1Code</b> (Lottery Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum LotteryType1Code
    {
        
        /// <summary>
        /// <b>ORIG - Origin</b>.
        /// </summary>
        ORIG,
        
        /// <summary>
        /// <b>SUPP - Supplier Payment</b>.
        /// </summary>
        SUPP,
    }
    
    /// <summary>
    /// Class <b>ElectionMovementType1FormatChoice</b> (Election Movement Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ElectionMovementType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ElectionMovementType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ElectionMovementType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ElectionMovementType1Code</b> (Election Movement Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum ElectionMovementType1Code
    {
        
        /// <summary>
        /// <b>REST - ?undefined?</b>.
        /// </summary>
        REST,
        
        /// <summary>
        /// <b>DRCT - ?undefined?</b>.
        /// </summary>
        DRCT,
    }
    
    /// <summary>
    /// Class <b>CorporateActionChangeType1FormatChoice</b> (Corporate Action Change Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionChangeType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionChangeType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionChangeType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionChangeType1Code</b> (Corporate Action Change Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionChangeType1Code
    {
        
        /// <summary>
        /// <b>BERE - Bearer to Registered</b>.
        /// </summary>
        BERE,
        
        /// <summary>
        /// <b>CERT - Certificate required / Non-US TEFRA D Certification</b>.
        /// </summary>
        CERT,
        
        /// <summary>
        /// <b>DEPH - ?undefined?</b>.
        /// </summary>
        DEPH,
        
        /// <summary>
        /// <b>GPPH - ?undefined?</b>.
        /// </summary>
        GPPH,
        
        /// <summary>
        /// <b>GTGP - ?undefined?</b>.
        /// </summary>
        GTGP,
        
        /// <summary>
        /// <b>GTPH - ?undefined?</b>.
        /// </summary>
        GTPH,
        
        /// <summary>
        /// <b>NAME - Name Change</b>.
        /// </summary>
        NAME,
        
        /// <summary>
        /// <b>PHDE - ?undefined?</b>.
        /// </summary>
        PHDE,
        
        /// <summary>
        /// <b>REBE - Registered to Bearer</b>.
        /// </summary>
        REBE,
        
        /// <summary>
        /// <b>TERM - Terms</b>.
        /// </summary>
        TERM,
        
        /// <summary>
        /// <b>DECI - ?undefined?</b>.
        /// </summary>
        DECI,
    }
    
    /// <summary>
    /// Class <b>UnitOrFaceAmountOrCode1Choice</b> (Unit Or Face Amount Or Code 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class UnitOrFaceAmountOrCode1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type Quantity1Code 
        /// FaceAmt (Face Amount) of type ActiveCurrencyAndAmount 
        /// Unit (Unit) of type decimal 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(Quantity1Code), Order=0)]
        [XmlElementAttribute("FaceAmt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("Unit", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>Quantity1Code</b> (Quantity 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum Quantity1Code
    {
        
        /// <summary>
        /// <b>QALL - All Securities</b>.
        /// </summary>
        QALL,
    }
    
    /// <summary>
    /// Class <b>CorporateActionCalculationMethod1FormatChoice</b> (Corporate Action Calculation Method 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionCalculationMethod1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionCalculationMethod1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionCalculationMethod1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionCalculationMethod1Code</b> (Corporate Action Calculation Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionCalculationMethod1Code
    {
        
        /// <summary>
        /// <b>PROR - Pro Ration</b>.
        /// </summary>
        PROR,
        
        /// <summary>
        /// <b>LOTT - ?undefined?</b>.
        /// </summary>
        LOTT,
        
        /// <summary>
        /// <b>NOMI - Nominee</b>.
        /// </summary>
        NOMI,
        
        /// <summary>
        /// <b>NNOM - ?undefined?</b>.
        /// </summary>
        NNOM,
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventStage1FormatChoice</b> (Corporate Action Event Stage 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionEventStage1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionEventStage1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionEventStage1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventStage1Code</b> (Corporate Action Event Stage 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionEventStage1Code
    {
        
        /// <summary>
        /// <b>APPD - Approved</b>.
        /// </summary>
        APPD,
        
        /// <summary>
        /// <b>CLDE - Closed/Deactivated</b>.
        /// </summary>
        CLDE,
        
        /// <summary>
        /// <b>PWAL - Period of Action</b>.
        /// </summary>
        PWAL,
        
        /// <summary>
        /// <b>SUAP - Subject to Approval</b>.
        /// </summary>
        SUAP,
        
        /// <summary>
        /// <b>UNAC - Unconditional as to Acceptance</b>.
        /// </summary>
        UNAC,
        
        /// <summary>
        /// <b>WHOU - Wholly Unconditional</b>.
        /// </summary>
        WHOU,
        
        /// <summary>
        /// <b>FULL - ?undefined?</b>.
        /// </summary>
        FULL,
        
        /// <summary>
        /// <b>LAPS - Lapse</b>.
        /// </summary>
        LAPS,
        
        /// <summary>
        /// <b>PART - Formal Partnership</b>.
        /// </summary>
        PART,
        
        /// <summary>
        /// <b>RESC - ?undefined?</b>.
        /// </summary>
        RESC,
    }
    
    /// <summary>
    /// Class <b>CorporateAction2</b> (Corporate Action 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateAction2
    {
        
        /// <summary>
        /// Element <b>EvtStag</b> (Event Stage) of type array of CorporateActionEventStage1FormatChoice.
        /// </summary>
        [XmlElementAttribute("EvtStag", Order=0)]
        public CorporateActionEventStage1FormatChoice[] EvtStag;
        
        /// <summary>
        /// Element <b>DfltOptnTp</b> (Default Option Type) of type CorporateActionOption1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CorporateActionOption1FormatChoice DfltOptnTp;
        
        /// <summary>
        /// Element <b>DfltOptnNb</b> (Default Option Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string DfltOptnNb;
        
        /// <summary>
        /// Element <b>ClctnMtd</b> (Calculation Method) of type CorporateActionCalculationMethod1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionCalculationMethod1FormatChoice ClctnMtd;
        
        /// <summary>
        /// Element <b>BckEndOddLotSctiesQty</b> (Back End Odd Lot Securities Quantity) of type UnitOrFaceAmountOrCode1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public UnitOrFaceAmountOrCode1Choice BckEndOddLotSctiesQty;
        
        /// <summary>
        /// Element <b>FrntEndOddLotSctiesQty</b> (Front End Odd Lot Securities Quantity) of type UnitOrFaceAmountOrCode1Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public UnitOrFaceAmountOrCode1Choice FrntEndOddLotSctiesQty;
        
        /// <summary>
        /// Element <b>MinExrcblSctiesQty</b> (Minimum Exercisable Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public UnitOrFaceAmount1Choice MinExrcblSctiesQty;
        
        /// <summary>
        /// Element <b>MinExrcblMltplSctiesQty</b> (Minimum Exercisable Multiple Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public UnitOrFaceAmount1Choice MinExrcblMltplSctiesQty;
        
        /// <summary>
        /// Element <b>IncrmtlDnmtn</b> (Incremental Denomination) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public UnitOrFaceAmount1Choice IncrmtlDnmtn;
        
        /// <summary>
        /// Element <b>NewDnmtnSctiesQty</b> (New Denomination Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public UnitOrFaceAmount1Choice NewDnmtnSctiesQty;
        
        /// <summary>
        /// Element <b>NewBrdLotSctiesQty</b> (New Board Lot Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public UnitOrFaceAmount1Choice NewBrdLotSctiesQty;
        
        /// <summary>
        /// Element <b>SctiesQtySght</b> (Securities Quantity Sought) of type UnitOrFaceAmountOrCode1Choice.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public UnitOrFaceAmountOrCode1Choice SctiesQtySght;
        
        /// <summary>
        /// Element <b>BaseDnmtn</b> (Base Denomination) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public UnitOrFaceAmount1Choice BaseDnmtn;
        
        /// <summary>
        /// Element <b>ChngTp</b> (Change Type) of type array of CorporateActionChangeType1FormatChoice.
        /// </summary>
        [XmlElementAttribute("ChngTp", Order=13)]
        public CorporateActionChangeType1FormatChoice[] ChngTp;
        
        /// <summary>
        /// Element <b>OfferTp</b> (Offer Type) of type array of OfferType1FormatChoice.
        /// </summary>
        [XmlElementAttribute("OfferTp", Order=14)]
        public OfferType1FormatChoice[] OfferTp;
        
        /// <summary>
        /// Element <b>RstrctnInd</b> (Restriction Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public bool RstrctnInd;
        
        /// <summary>
        /// Element <b>RstrctnIndSpecified</b> (Restriction Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RstrctnIndSpecified;
        
        /// <summary>
        /// Element <b>PrtlElctnInd</b> (Partial Election Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public bool PrtlElctnInd;
        
        /// <summary>
        /// Element <b>PrtlElctnIndSpecified</b> (Partial Election Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrtlElctnIndSpecified;
        
        /// <summary>
        /// Element <b>ElctnTp</b> (Election Type) of type ElectionMovementType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public ElectionMovementType1FormatChoice ElctnTp;
        
        /// <summary>
        /// Element <b>LtryTp</b> (Lottery Type) of type LotteryType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public LotteryType1FormatChoice LtryTp;
        
        /// <summary>
        /// Element <b>IncmTp</b> (Income Type) of type GenericIdentification13.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public GenericIdentification13 IncmTp;
        
        /// <summary>
        /// Element <b>DvddTp</b> (Dividend Type) of type CorporateActionFrequencyType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public CorporateActionFrequencyType1FormatChoice DvddTp;
        
        /// <summary>
        /// Element <b>IntrmdtSctiesDstrbtnTp</b> (Intermediate Securities Distribution Type) of type IntermediateSecurityDistributionType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=21)]
        public IntermediateSecurityDistributionType1FormatChoice IntrmdtSctiesDstrbtnTp;
        
        /// <summary>
        /// Element <b>CpnNb</b> (Coupon Number) of type array of string.
        /// </summary>
        [XmlElementAttribute("CpnNb", Order=22)]
        public string[] CpnNb;
        
        /// <summary>
        /// Element <b>IntrstAcrdNbOfDays</b> (Interest Accrued Number Of Days) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=23)]
        public decimal IntrstAcrdNbOfDays;
        
        /// <summary>
        /// Element <b>IntrstAcrdNbOfDaysSpecified</b> (Interest Accrued Number Of Days Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntrstAcrdNbOfDaysSpecified;
        
        /// <summary>
        /// Element <b>NewDnmtnCcy</b> (New Denomination Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=24)]
        public string NewDnmtnCcy;
        
        /// <summary>
        /// Element <b>DtDtls</b> (Date Details) of type CorporateActionDate2.
        /// </summary>
        [XmlElementAttribute(Order=25)]
        public CorporateActionDate2 DtDtls;
        
        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type array of CorporateActionPrice2.
        /// </summary>
        [XmlElementAttribute("PricDtls", Order=26)]
        public CorporateActionPrice2[] PricDtls;
        
        /// <summary>
        /// Element <b>PrdDtls</b> (Period Details) of type CorporateActionPeriod1.
        /// </summary>
        [XmlElementAttribute(Order=27)]
        public CorporateActionPeriod1 PrdDtls;
        
        /// <summary>
        /// Element <b>RateAndAmtDtls</b> (Rate And Amount Details) of type CorporateActionRate1.
        /// </summary>
        [XmlElementAttribute(Order=28)]
        public CorporateActionRate1 RateAndAmtDtls;
        
        /// <summary>
        /// Element <b>CorpActnAddtlInf</b> (Corporate Action Additional Information) of type CorporateActionNarrative1.
        /// </summary>
        [XmlElementAttribute(Order=29)]
        public CorporateActionNarrative1 CorpActnAddtlInf;
        
        /// <summary>
        /// Element <b>CertfctnReqrdInd</b> (Certification Required Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=30)]
        public bool CertfctnReqrdInd;
        
        /// <summary>
        /// Element <b>CertfctnReqrdIndSpecified</b> (Certification Required Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CertfctnReqrdIndSpecified;
        
        /// <summary>
        /// Element <b>CertfctnTp</b> (Certification Type) of type BeneficiaryCertificationType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=31)]
        public BeneficiaryCertificationType1FormatChoice CertfctnTp;
        
        /// <summary>
        /// Element <b>CptlGn</b> (Capital Gain) of type EUCapitalGain2Code.
        /// </summary>
        [XmlElementAttribute(Order=32)]
        public EUCapitalGain2Code CptlGn;
        
        /// <summary>
        /// Element <b>CptlGnSpecified</b> (Capital Gain Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CptlGnSpecified;
        
        /// <summary>
        /// Element <b>TaxblIncmPerShrClctd</b> (Taxable Income Per Share Calculated) of type TaxableIncomePerShareCalculated2Code.
        /// </summary>
        [XmlElementAttribute(Order=33)]
        public TaxableIncomePerShareCalculated2Code TaxblIncmPerShrClctd;
        
        /// <summary>
        /// Element <b>TaxblIncmPerShrClctdSpecified</b> (Taxable Income Per Share Calculated Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxblIncmPerShrClctdSpecified;
        
        /// <summary>
        /// Element <b>NewPlcOfIncorprtn</b> (New Place Of Incorporation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=34)]
        public string NewPlcOfIncorprtn;
        
        /// <summary>
        /// Element <b>RnncblEntitlmntStsTp</b> (Renounceable Entitlement Status Type) of type RenounceableStatus1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=35)]
        public RenounceableStatus1FormatChoice RnncblEntitlmntStsTp;
        
        /// <summary>
        /// Element <b>ConvsTp</b> (Conversion Type) of type ConversionType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=36)]
        public ConversionType1FormatChoice ConvsTp;
        
        /// <summary>
        /// Element <b>RedChrgsApldInd</b> (Redemption Charges Applied Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=37)]
        public bool RedChrgsApldInd;
        
        /// <summary>
        /// Element <b>RedChrgsApldIndSpecified</b> (Redemption Charges Applied Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RedChrgsApldIndSpecified;
        
        /// <summary>
        /// Element <b>DstrbtnTp</b> (Distribution Type) of type DistributionType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=38)]
        public DistributionType1FormatChoice DstrbtnTp;
    }
    
    /// <summary>
    /// Enumeration <b>EUCapitalGain2Code</b> (EU Capital Gain 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum EUCapitalGain2Code
    {
        
        /// <summary>
        /// <b>EUSI - Capital Gain In Scope</b>.
        /// </summary>
        EUSI,
        
        /// <summary>
        /// <b>EUSO - Capital Gain Out Scope</b>.
        /// </summary>
        EUSO,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }
    
    /// <summary>
    /// Enumeration <b>TaxableIncomePerShareCalculated2Code</b> (Taxable Income Per Share Calculated 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum TaxableIncomePerShareCalculated2Code
    {
        
        /// <summary>
        /// <b>TSIY - Fund Calculates</b>.
        /// </summary>
        TSIY,
        
        /// <summary>
        /// <b>TSIN - Fund Does Not Calculate</b>.
        /// </summary>
        TSIN,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }
    
    /// <summary>
    /// Class <b>CorporateActionMandatoryVoluntary1FormatChoice</b> (Corporate Action Mandatory Voluntary 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionMandatoryVoluntary1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionMandatoryVoluntary1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionMandatoryVoluntary1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionMandatoryVoluntary1Code</b> (Corporate Action Mandatory Voluntary 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionMandatoryVoluntary1Code
    {
        
        /// <summary>
        /// <b>MAND - Mandatory CA Event; No Instruction Required</b>.
        /// </summary>
        MAND,
        
        /// <summary>
        /// <b>CHOS - Mandatory CA Event; Instruction Required</b>.
        /// </summary>
        CHOS,
        
        /// <summary>
        /// <b>VOLU - Voluntary CA Event; Instruction Required to Participate</b>.
        /// </summary>
        VOLU,
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventProcessingType1FormatChoice</b> (Corporate Action Event Processing Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionEventProcessingType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionEventProcessingType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionEventProcessingType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventProcessingType1Code</b> (Corporate Action Event Processing Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionEventProcessingType1Code
    {
        
        /// <summary>
        /// <b>GENL - General</b>.
        /// </summary>
        GENL,
        
        /// <summary>
        /// <b>DISN - CA Results in a Distribution</b>.
        /// </summary>
        DISN,
        
        /// <summary>
        /// <b>REOR - CA Results in a Reorganisation</b>.
        /// </summary>
        REOR,
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventType2FormatChoice</b> (Corporate Action Event Type 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionEventType2FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionEventType2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionEventType2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventType2Code</b> (Corporate Action Event Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionEventType2Code
    {
        
        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,
        
        /// <summary>
        /// <b>ATTI - Attachment</b>.
        /// </summary>
        ATTI,
        
        /// <summary>
        /// <b>BIDS - Repurchase Offer/Issuer Bid/Reverse Rights</b>.
        /// </summary>
        BIDS,
        
        /// <summary>
        /// <b>BONU - Bonus Issue / Capitalisation Issue</b>.
        /// </summary>
        BONU,
        
        /// <summary>
        /// <b>BPUT - Put Redemption</b>.
        /// </summary>
        BPUT,
        
        /// <summary>
        /// <b>BRUP - Bankruptcy</b>.
        /// </summary>
        BRUP,
        
        /// <summary>
        /// <b>CAPG - Capital Gains Distribution</b>.
        /// </summary>
        CAPG,
        
        /// <summary>
        /// <b>CAPI - ?undefined?</b>.
        /// </summary>
        CAPI,
        
        /// <summary>
        /// <b>CERT - Certificate required / Non-US TEFRA D Certification</b>.
        /// </summary>
        CERT,
        
        /// <summary>
        /// <b>CHAN - Change</b>.
        /// </summary>
        CHAN,
        
        /// <summary>
        /// <b>CLSA - Class Action/Proposed Settlement</b>.
        /// </summary>
        CLSA,
        
        /// <summary>
        /// <b>CONS - Consent</b>.
        /// </summary>
        CONS,
        
        /// <summary>
        /// <b>CONV - Convert / Conversion</b>.
        /// </summary>
        CONV,
        
        /// <summary>
        /// <b>COOP - Company Option</b>.
        /// </summary>
        COOP,
        
        /// <summary>
        /// <b>DECR - Decrease In Value</b>.
        /// </summary>
        DECR,
        
        /// <summary>
        /// <b>DETI - Detachment</b>.
        /// </summary>
        DETI,
        
        /// <summary>
        /// <b>DFLT - Bond Default</b>.
        /// </summary>
        DFLT,
        
        /// <summary>
        /// <b>DLST - Delisted</b>.
        /// </summary>
        DLST,
        
        /// <summary>
        /// <b>DRAW - Drawn</b>.
        /// </summary>
        DRAW,
        
        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
        
        /// <summary>
        /// <b>DSCL - Disclosure</b>.
        /// </summary>
        DSCL,
        
        /// <summary>
        /// <b>DTCH - Dutch Auction</b>.
        /// </summary>
        DTCH,
        
        /// <summary>
        /// <b>DVCA - Cash Dividend</b>.
        /// </summary>
        DVCA,
        
        /// <summary>
        /// <b>DVOP - Dividend Option</b>.
        /// </summary>
        DVOP,
        
        /// <summary>
        /// <b>DVSC - Scrip Dividend/Payment</b>.
        /// </summary>
        DVSC,
        
        /// <summary>
        /// <b>DVSE - Stock Dividend</b>.
        /// </summary>
        DVSE,
        
        /// <summary>
        /// <b>EXOF - Exchange Offer</b>.
        /// </summary>
        EXOF,
        
        /// <summary>
        /// <b>EXRI - Call On Rights</b>.
        /// </summary>
        EXRI,
        
        /// <summary>
        /// <b>EXTM - Maturity Extension</b>.
        /// </summary>
        EXTM,
        
        /// <summary>
        /// <b>EXWA - Warrant Exercise</b>.
        /// </summary>
        EXWA,
        
        /// <summary>
        /// <b>INCR - Increase in Value</b>.
        /// </summary>
        INCR,
        
        /// <summary>
        /// <b>INTR - Intermediary / Interest Payment</b>.
        /// </summary>
        INTR,
        
        /// <summary>
        /// <b>LIQU - Liquidation</b>.
        /// </summary>
        LIQU,
        
        /// <summary>
        /// <b>MCAL - Full Call/Early Redemption</b>.
        /// </summary>
        MCAL,
        
        /// <summary>
        /// <b>MRGR - Merger</b>.
        /// </summary>
        MRGR,
        
        /// <summary>
        /// <b>ODLT - Odd Lot Sale/Purchase</b>.
        /// </summary>
        ODLT,
        
        /// <summary>
        /// <b>PARI - Pari Passu</b>.
        /// </summary>
        PARI,
        
        /// <summary>
        /// <b>PCAL - Partial Redemption With Reduction of Nominal Value</b>.
        /// </summary>
        PCAL,
        
        /// <summary>
        /// <b>PDEF - Partial Defeasance/Pre-funding</b>.
        /// </summary>
        PDEF,
        
        /// <summary>
        /// <b>PINK - Pay In Kind</b>.
        /// </summary>
        PINK,
        
        /// <summary>
        /// <b>PLAC - Place of Incorporation</b>.
        /// </summary>
        PLAC,
        
        /// <summary>
        /// <b>PPMT - Instalment Call</b>.
        /// </summary>
        PPMT,
        
        /// <summary>
        /// <b>PRED - Partial Redemption Without Reduction of Nominal Value</b>.
        /// </summary>
        PRED,
        
        /// <summary>
        /// <b>PRII - Interest Payment with Principle</b>.
        /// </summary>
        PRII,
        
        /// <summary>
        /// <b>PRIO - Priority Issue</b>.
        /// </summary>
        PRIO,
        
        /// <summary>
        /// <b>REDM - Redemption</b>.
        /// </summary>
        REDM,
        
        /// <summary>
        /// <b>REDO - Redenomination</b>.
        /// </summary>
        REDO,
        
        /// <summary>
        /// <b>REMK - Remarketing Agreement</b>.
        /// </summary>
        REMK,
        
        /// <summary>
        /// <b>RHDI - Rights Distribution</b>.
        /// </summary>
        RHDI,
        
        /// <summary>
        /// <b>RHTS - Rights Issue/Subscription Rights/Rights Offer</b>.
        /// </summary>
        RHTS,
        
        /// <summary>
        /// <b>SHPR - Shares Premium Dividend</b>.
        /// </summary>
        SHPR,
        
        /// <summary>
        /// <b>SMAL - ?undefined?</b>.
        /// </summary>
        SMAL,
        
        /// <summary>
        /// <b>SOFF - Spin Off</b>.
        /// </summary>
        SOFF,
        
        /// <summary>
        /// <b>SPLF - Stock Split</b>.
        /// </summary>
        SPLF,
        
        /// <summary>
        /// <b>SPLR - Reverse Stock Split</b>.
        /// </summary>
        SPLR,
        
        /// <summary>
        /// <b>SUSP - Suspicious Payment</b>.
        /// </summary>
        SUSP,
        
        /// <summary>
        /// <b>TEND - Tender</b>.
        /// </summary>
        TEND,
        
        /// <summary>
        /// <b>TREC - Tax Reclaim</b>.
        /// </summary>
        TREC,
        
        /// <summary>
        /// <b>WRTH - Worthless</b>.
        /// </summary>
        WRTH,
        
        /// <summary>
        /// <b>WTRC - ?undefined?</b>.
        /// </summary>
        WTRC,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>CorporateActionInformation2</b> (Corporate Action Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionInformation2
    {
        
        /// <summary>
        /// Element <b>AgtId</b> (Agent Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice AgtId;
        
        /// <summary>
        /// Element <b>IssrCorpActnId</b> (Issuer Corporate Action Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IssrCorpActnId;
        
        /// <summary>
        /// Element <b>CorpActnPrcgId</b> (Corporate Action Processing Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CorpActnPrcgId;
        
        /// <summary>
        /// Element <b>EvtTp</b> (Event Type) of type CorporateActionEventType2FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionEventType2FormatChoice EvtTp;
        
        /// <summary>
        /// Element <b>EvtPrcgTp</b> (Event Processing Type) of type CorporateActionEventProcessingType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public CorporateActionEventProcessingType1FormatChoice EvtPrcgTp;
        
        /// <summary>
        /// Element <b>MndtryVlntryEvtTp</b> (Mandatory Voluntary Event Type) of type CorporateActionMandatoryVoluntary1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CorporateActionMandatoryVoluntary1FormatChoice MndtryVlntryEvtTp;
        
        /// <summary>
        /// Element <b>UndrlygScty</b> (Underlying Security) of type FinancialInstrumentDescription3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public FinancialInstrumentDescription3 UndrlygScty;
        
        /// <summary>
        /// Element <b>OthrUndrlygScty</b> (Other Underlying Security) of type array of FinancialInstrumentDescription3.
        /// </summary>
        [XmlElementAttribute("OthrUndrlygScty", Order=7)]
        public FinancialInstrumentDescription3[] OthrUndrlygScty;
    }
    
    /// <summary>
    /// Class <b>ProcessingStatus1FormatChoice</b> (Processing Status 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ProcessingStatus1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ProcessingStatus1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ProcessingStatus1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ProcessingStatus1Code</b> (Processing Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum ProcessingStatus1Code
    {
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
        
        /// <summary>
        /// <b>PREC - Precalculated / Preliminary Announcement: Confirmed</b>.
        /// </summary>
        PREC,
        
        /// <summary>
        /// <b>PREU - Preliminary Announcement: Unconfirmed</b>.
        /// </summary>
        PREU,
        
        /// <summary>
        /// <b>INFO - Information / For Information Only</b>.
        /// </summary>
        INFO,
    }
    
    /// <summary>
    /// Class <b>CorporateActionNotification1</b> (Corporate Action Notification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class CorporateActionNotification1
    {
        
        /// <summary>
        /// Element <b>AnncmntDt</b> (Announcement Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateFormat4Choice AnncmntDt;
        
        /// <summary>
        /// Element <b>FrthrDtldAnncmntDt</b> (Further Detailed Announcement Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DateFormat4Choice FrthrDtldAnncmntDt;
        
        /// <summary>
        /// Element <b>OffclAnncmntPblctnDt</b> (Official Announcement Publication Date) of type DateFormat4Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateFormat4Choice OffclAnncmntPblctnDt;
        
        /// <summary>
        /// Element <b>PrcgSts</b> (Processing Status) of type ProcessingStatus1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ProcessingStatus1FormatChoice PrcgSts;
    }
    
    /// <summary>
    /// Class <b>ProcessingPosition2FormatChoice</b> (Processing Position 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class ProcessingPosition2FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ProcessingPosition2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ProcessingPosition2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ProcessingPosition2Code</b> (Processing Position 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum ProcessingPosition2Code
    {
        
        /// <summary>
        /// <b>AFTE - After</b>.
        /// </summary>
        AFTE,
        
        /// <summary>
        /// <b>WITH - With / Withdrawal</b>.
        /// </summary>
        WITH,
        
        /// <summary>
        /// <b>BEFO - Before</b>.
        /// </summary>
        BEFO,
        
        /// <summary>
        /// <b>INFO - Information / For Information Only</b>.
        /// </summary>
        INFO,
    }
    
    /// <summary>
    /// Class <b>LinkedCorporateAction1</b> (Linked Corporate Action 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public class LinkedCorporateAction1
    {
        
        /// <summary>
        /// Element <b>NtfctnTp</b> (Notification Type) of type CorporateActionNotificationType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CorporateActionNotificationType1Code NtfctnTp;
        
        /// <summary>
        /// Element <b>LkdAgtCANtfctnAdvcId</b> (Linked Agent CA Notification Advice Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DocumentIdentification8 LkdAgtCANtfctnAdvcId;
        
        /// <summary>
        /// Element <b>LkgTp</b> (Linkage Type) of type ProcessingPosition2FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ProcessingPosition2FormatChoice LkgTp;
        
        /// <summary>
        /// Element <b>LkdIssrCorpActnId</b> (Linked Issuer Corporate Action Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string LkdIssrCorpActnId;
        
        /// <summary>
        /// Element <b>LkdCorpActnPrcgId</b> (Linked Corporate Action Processing Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string LkdCorpActnPrcgId;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionNotificationType1Code</b> (Corporate Action Notification Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.009.001.01")]
    public enum CorporateActionNotificationType1Code
    {
        
        /// <summary>
        /// <b>NEWM - New Message</b>.
        /// </summary>
        NEWM,
        
        /// <summary>
        /// <b>REPL - Replacement</b>.
        /// </summary>
        REPL,
        
        /// <summary>
        /// <b>RMDR - Reminder</b>.
        /// </summary>
        RMDR,
    }
}
