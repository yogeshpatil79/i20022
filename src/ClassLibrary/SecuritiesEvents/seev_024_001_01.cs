
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



namespace i20022.seev02400101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.024.001.01 name AgentCAInformationStatusAdviceV01 from Securities Events business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AgtCAInfStsAdvc</b> (Agent CA Information Status Advice) of type AgentCAInformationStatusAdviceV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AgentCAInformationStatusAdviceV01 AgtCAInfStsAdvc;
    }
    
    /// <summary>
    /// Class <b>AgentCAInformationStatusAdviceV01</b> (Agent CA Information Status Advice V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class AgentCAInformationStatusAdviceV01
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification8 Id;
        
        /// <summary>
        /// Element <b>AgtCAInfAdvcId</b> (Agent CA Information Advice Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DocumentIdentification8 AgtCAInfAdvcId;
        
        /// <summary>
        /// Element <b>CorpActnAddtlInf</b> (Corporate Action Additional Information) of type CorporateActionAdditionalInformation1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CorporateActionAdditionalInformation1 CorpActnAddtlInf;
        
        /// <summary>
        /// Element <b>InfStsDtls</b> (Information Status Details) of type CorporateActionInformationStatus1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionInformationStatus1Choice InfStsDtls;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    /// Class <b>RejectionReason15FormatChoice</b> (Rejection Reason 15 Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class RejectionReason15FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RejectionReason15Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RejectionReason15Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason15Code</b> (Rejection Reason 15 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public enum RejectionReason15Code
    {
        
        /// <summary>
        /// <b>FAIL - ?undefined?</b>.
        /// </summary>
        FAIL,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification13</b> (Generic Identification 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    /// Class <b>CorporateActionInformationRejectedStatus1</b> (Corporate Action Information Rejected Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class CorporateActionInformationRejectedStatus1
    {
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type array of RejectionReason15FormatChoice.
        /// </summary>
        [XmlElementAttribute("Rsn", Order=0)]
        public RejectionReason15FormatChoice[] Rsn;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>ProcessedStatus5FormatChoice</b> (Processed Status 5Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class ProcessedStatus5FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ProcessedStatus5Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ProcessedStatus5Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ProcessedStatus5Code</b> (Processed Status 5Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public enum ProcessedStatus5Code
    {
        
        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
    }
    
    /// <summary>
    /// Class <b>CorporateActionInformationProcessingStatus1</b> (Corporate Action Information Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class CorporateActionInformationProcessingStatus1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type ProcessedStatus5FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ProcessedStatus5FormatChoice Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>CorporateActionInformationStatus1Choice</b> (Corporate Action Information Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class CorporateActionInformationStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcdSts (Processed Status) of type CorporateActionInformationProcessingStatus1 
        /// RjctdSts (Rejected Status) of type CorporateActionInformationRejectedStatus1 
        /// </summary>
        [XmlElementAttribute("PrcdSts", typeof(CorporateActionInformationProcessingStatus1), Order=0)]
        [XmlElementAttribute("RjctdSts", typeof(CorporateActionInformationRejectedStatus1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01", IncludeInSchema=false)]
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
    /// Class <b>ProceedsDelivery1</b> (Proceeds Delivery 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class ProceedsDelivery1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// CshAcctId (Cash Account Identification) of type CashAccountIdentification1Choice 
        /// SctiesAcctId (Securities Account Identification) of type string 
        /// </summary>
        [XmlElementAttribute("CshAcctId", typeof(CashAccountIdentification1Choice), Order=0)]
        [XmlElementAttribute("SctiesAcctId", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AcctOwnrId</b> (Account Owner Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice AcctOwnrId;
        
        /// <summary>
        /// Element <b>AcctSvcrId</b> (Account Servicer Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice AcctSvcrId;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    /// Class <b>UnitOrFaceAmount1Choice</b> (Unit Or Face Amount 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    /// Class <b>AlternateSecurityIdentification3</b> (Alternate Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01", IncludeInSchema=false)]
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
    /// Class <b>SecurityIdentification7</b> (Security Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    /// Class <b>BeneficiaryCertificationType1FormatChoice</b> (Beneficiary Certification Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
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
    /// Class <b>PersonIdentificationType3Choice</b> (Person Identification Type 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class PersonIdentificationType3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type PersonIdentificationType3Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(PersonIdentificationType3Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>PersonIdentificationType3Code</b> (Person Identification Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public enum PersonIdentificationType3Code
    {
        
        /// <summary>
        /// <b>ARNU - ?undefined?</b>.
        /// </summary>
        ARNU,
        
        /// <summary>
        /// <b>CCPT - ?undefined?</b>.
        /// </summary>
        CCPT,
        
        /// <summary>
        /// <b>EMID - Employer Identification Number</b>.
        /// </summary>
        EMID,
        
        /// <summary>
        /// <b>DRLC - Drivers License Number</b>.
        /// </summary>
        DRLC,
        
        /// <summary>
        /// <b>FINN - ?undefined?</b>.
        /// </summary>
        FINN,
        
        /// <summary>
        /// <b>TXID - ?undefined?</b>.
        /// </summary>
        TXID,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification16</b> (Generic Identification 16).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class GenericIdentification16
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>IdTp</b> (Identification Type) of type PersonIdentificationType3Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PersonIdentificationType3Choice IdTp;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>BeneficialOwner1</b> (Beneficial Owner 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class BeneficialOwner1
    {
        
        /// <summary>
        /// Element <b>BnfclOwnrId</b> (Beneficial Owner Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice BnfclOwnrId;
        
        /// <summary>
        /// Element <b>AddtlId</b> (Additional Identification) of type GenericIdentification16.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public GenericIdentification16 AddtlId;
        
        /// <summary>
        /// Element <b>Ntlty</b> (Nationality) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Ntlty;
        
        /// <summary>
        /// Element <b>DmclCtry</b> (Domicile Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DmclCtry;
        
        /// <summary>
        /// Element <b>NonDmclCtry</b> (Non Domicile Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string NonDmclCtry;
        
        /// <summary>
        /// Element <b>CertfctnInd</b> (Certification Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public bool CertfctnInd;
        
        /// <summary>
        /// Element <b>CertfctnIndSpecified</b> (Certification Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CertfctnIndSpecified;
        
        /// <summary>
        /// Element <b>CertfctnTp</b> (Certification Type) of type BeneficiaryCertificationType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public BeneficiaryCertificationType1FormatChoice CertfctnTp;
        
        /// <summary>
        /// Element <b>DclrtnDtls</b> (Declaration Details) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string DclrtnDtls;
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public SecurityIdentification7 SctyId;
        
        /// <summary>
        /// Element <b>ElctdSctiesQty</b> (Elected Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public UnitOrFaceAmount1Choice ElctdSctiesQty;
    }
    
    /// <summary>
    /// Class <b>CorporateActionAdditionalInformation1</b> (Corporate Action Additional Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.024.001.01")]
    public class CorporateActionAdditionalInformation1
    {
        
        /// <summary>
        /// Element <b>BnfclOwnrDtls</b> (Beneficial Owner Details) of type array of BeneficialOwner1.
        /// </summary>
        [XmlElementAttribute("BnfclOwnrDtls", Order=0)]
        public BeneficialOwner1[] BnfclOwnrDtls;
        
        /// <summary>
        /// Element <b>RegnDtls</b> (Registration Details) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string RegnDtls;
        
        /// <summary>
        /// Element <b>RcvrId</b> (Receiver Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice RcvrId;
        
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
        /// Element <b>DlvryDtls</b> (Delivery Details) of type array of ProceedsDelivery1.
        /// </summary>
        [XmlElementAttribute("DlvryDtls", Order=5)]
        public ProceedsDelivery1[] DlvryDtls;
        
        /// <summary>
        /// Element <b>AddtlInstr</b> (Additional Instruction) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string AddtlInstr;
    }
}
