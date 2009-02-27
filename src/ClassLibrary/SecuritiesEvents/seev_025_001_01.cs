
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



namespace i20022.seev02500101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.025.001.01 name AgentCAStandingInstructionRequestV01 from Securities Events business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AgtCAStgInstrReq</b> (Agent CA Standing Instruction Request) of type AgentCAStandingInstructionRequestV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AgentCAStandingInstructionRequestV01 AgtCAStgInstrReq;
    }
    
    /// <summary>
    /// Class <b>AgentCAStandingInstructionRequestV01</b> (Agent CA Standing Instruction Request V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public class AgentCAStandingInstructionRequestV01
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification8 Id;
        
        /// <summary>
        /// Element <b>StgInstrGnlInf</b> (Standing Instruction General Information) of type CorporateActionStandingInstructionGeneralInformation1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CorporateActionStandingInstructionGeneralInformation1 StgInstrGnlInf;
        
        /// <summary>
        /// Element <b>StgInstrDtls</b> (Standing Instruction Details) of type CorporateActionStandingInstruction1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CorporateActionStandingInstruction1 StgInstrDtls;
        
        /// <summary>
        /// Element <b>CtctDtls</b> (Contact Details) of type ContactPerson1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ContactPerson1 CtctDtls;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    /// Class <b>ContactIdentification4</b> (Contact Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    /// Class <b>SecuritiesAccount6</b> (Securities Account 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public class SecuritiesAccount6
    {
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification7 SctyId;
        
        /// <summary>
        /// Element <b>SctiesAcctId</b> (Securities Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SctiesAcctId;
        
        /// <summary>
        /// Element <b>AcctOwnrId</b> (Account Owner Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice AcctOwnrId;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification2Choice SfkpgPlc;
        
        /// <summary>
        /// Element <b>RegnDtls</b> (Registration Details) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string RegnDtls;
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification7</b> (Security Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType
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
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>CashAccountIdentification1Choice</b> (Cash Account Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public class CashAccountIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BBAN (BBAN) of type string 
        /// DmstAcct (Domestic Account) of type SimpleIdentificationInformation 
        /// IBAN (IBAN) of type string 
        /// UPIC (UPIC) of type string 
        /// </summary>
        [XmlElementAttribute("BBAN", typeof(string), Order=0)]
        [XmlElementAttribute("DmstAcct", typeof(SimpleIdentificationInformation), Order=0)]
        [XmlElementAttribute("IBAN", typeof(string), Order=0)]
        [XmlElementAttribute("UPIC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>BBAN - Basic Bank Account Number</b>.
        /// </summary>
        BBAN,
        
        /// <summary>
        /// <b>DmstAcct - Domestic Account</b>.
        /// </summary>
        DmstAcct,
        
        /// <summary>
        /// <b>IBAN - International Bank Account Number</b>.
        /// </summary>
        IBAN,
        
        /// <summary>
        /// <b>UPIC - Universal Promotional Identification Code</b>.
        /// </summary>
        UPIC,
    }
    
    /// <summary>
    /// Class <b>CashAccount17</b> (Cash Account 17).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public class CashAccount17
    {
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type CashAccountIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CashAccountIdentification1Choice AcctId;
        
        /// <summary>
        /// Element <b>PmtCcy</b> (Payment Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PmtCcy;
        
        /// <summary>
        /// Element <b>AcctOwnrId</b> (Account Owner Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice AcctOwnrId;
        
        /// <summary>
        /// Element <b>CrspdtBkId</b> (Correspondent Bank Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string CrspdtBkId;
    }
    
    /// <summary>
    /// Class <b>CorporateActionStandingInstruction1</b> (Corporate Action Standing Instruction 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public class CorporateActionStandingInstruction1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// CshDstrbtnDtls (Cash Distribution Details) of type CashAccount17 
        /// NetOrGrss (Net Or Gross) of type StandingInstructionGrossNet1Code 
        /// SctiesDstrbtnDtls (Securities Distribution Details) of type SecuritiesAccount6 
        /// </summary>
        [XmlElementAttribute("CshDstrbtnDtls", typeof(CashAccount17), Order=0)]
        [XmlElementAttribute("NetOrGrss", typeof(StandingInstructionGrossNet1Code), Order=0)]
        [XmlElementAttribute("SctiesDstrbtnDtls", typeof(SecuritiesAccount6), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>StandingInstructionGrossNet1Code</b> (Standing Instruction Gross Net 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public enum StandingInstructionGrossNet1Code
    {
        
        /// <summary>
        /// <b>GROS - ?undefined?</b>.
        /// </summary>
        GROS,
        
        /// <summary>
        /// <b>NETT - Netting</b>.
        /// </summary>
        NETT,
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentDescription3</b> (Financial Instrument Description 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    /// Class <b>IncludedAccount1</b> (Included Account 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public class IncludedAccount1
    {
        
        /// <summary>
        /// Element <b>SctiesAcctId</b> (Securities Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string SctiesAcctId;
        
        /// <summary>
        /// Element <b>InclInd</b> (Included Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool InclInd;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification13</b> (Generic Identification 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    /// Class <b>CorporateActionEventType2FormatChoice</b> (Corporate Action Event Type 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
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
    /// Class <b>CorporateActionStandingInstructionGeneralInformation1</b> (Corporate Action Standing Instruction General Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public class CorporateActionStandingInstructionGeneralInformation1
    {
        
        /// <summary>
        /// Element <b>StgInstrTp</b> (Standing Instruction Type) of type StandingInstructionType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public StandingInstructionType1Code StgInstrTp;
        
        /// <summary>
        /// Element <b>EvtTp</b> (Event Type) of type array of CorporateActionEventType2FormatChoice.
        /// </summary>
        [XmlElementAttribute("EvtTp", Order=1)]
        public CorporateActionEventType2FormatChoice[] EvtTp;
        
        /// <summary>
        /// Element <b>InstgPtyId</b> (Instructing Party Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice InstgPtyId;
        
        /// <summary>
        /// Element <b>ClntStgInstrId</b> (Client Standing Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string ClntStgInstrId;
        
        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type array of IncludedAccount1.
        /// </summary>
        [XmlElementAttribute("AcctDtls", Order=4)]
        public IncludedAccount1[] AcctDtls;
        
        /// <summary>
        /// Element <b>UndrlygScty</b> (Underlying Security) of type FinancialInstrumentDescription3.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstrumentDescription3 UndrlygScty;
    }
    
    /// <summary>
    /// Enumeration <b>StandingInstructionType1Code</b> (Standing Instruction Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.025.001.01")]
    public enum StandingInstructionType1Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>PAYM - ?undefined?</b>.
        /// </summary>
        PAYM,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
    }
}
