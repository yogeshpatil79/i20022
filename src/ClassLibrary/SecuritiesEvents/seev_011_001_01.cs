
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



namespace i20022.seev01100101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.011.001.01 name AgentCANotificationStatusAdviceV01 from Securities Events business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AgtCANtfctnStsAdvc</b> (Agent CA Notification Status Advice) of type AgentCANotificationStatusAdviceV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AgentCANotificationStatusAdviceV01 AgtCANtfctnStsAdvc;
    }
    
    /// <summary>
    /// Class <b>AgentCANotificationStatusAdviceV01</b> (Agent CA Notification Status Advice V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class AgentCANotificationStatusAdviceV01
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification8 Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute("AgtCANtfctnAdvcId", typeof(DocumentIdentification8), Order=1)]
        [XmlElementAttribute("AgtCANtfctnCxlReqId", typeof(DocumentIdentification8), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public DocumentIdentification8 Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
        
        /// <summary>
        /// Element <b>CorpActnGnlInf</b> (Corporate Action General Information) of type CorporateActionInformation2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionInformation2 CorpActnGnlInf;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// NtfctnAdvcSts (Notification Advice Status) of type NotificationAdviceStatus1Choice 
        /// NtfctnCxlReqSts (Notification Cancellation Request Status) of type NotificationCancellationRequestStatus1Choice 
        /// </summary>
        [XmlElementAttribute("NtfctnAdvcSts", typeof(NotificationAdviceStatus1Choice), Order=4)]
        [XmlElementAttribute("NtfctnCxlReqSts", typeof(NotificationCancellationRequestStatus1Choice), Order=4)]
        public object Item1;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    /// Class <b>RejectionReason6FormatChoice</b> (Rejection Reason 6Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class RejectionReason6FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RejectionReason6Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RejectionReason6Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason6Code</b> (Rejection Reason 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public enum RejectionReason6Code
    {
        
        /// <summary>
        /// <b>FAIL - ?undefined?</b>.
        /// </summary>
        FAIL,
        
        /// <summary>
        /// <b>SECO - ?undefined?</b>.
        /// </summary>
        SECO,
        
        /// <summary>
        /// <b>AGID - ?undefined?</b>.
        /// </summary>
        AGID,
        
        /// <summary>
        /// <b>ENDP - ?undefined?</b>.
        /// </summary>
        ENDP,
        
        /// <summary>
        /// <b>STAR - ?undefined?</b>.
        /// </summary>
        STAR,
        
        /// <summary>
        /// <b>RESU - ?undefined?</b>.
        /// </summary>
        RESU,
        
        /// <summary>
        /// <b>SECT - ?undefined?</b>.
        /// </summary>
        SECT,
        
        /// <summary>
        /// <b>DISP - Dispatch Advice</b>.
        /// </summary>
        DISP,
        
        /// <summary>
        /// <b>ELIG - Eligible</b>.
        /// </summary>
        ELIG,
        
        /// <summary>
        /// <b>XRAT - ?undefined?</b>.
        /// </summary>
        XRAT,
        
        /// <summary>
        /// <b>VALU - Value Date/Time</b>.
        /// </summary>
        VALU,
        
        /// <summary>
        /// <b>ACRU - ?undefined?</b>.
        /// </summary>
        ACRU,
        
        /// <summary>
        /// <b>NOAC - No Action</b>.
        /// </summary>
        NOAC,
        
        /// <summary>
        /// <b>MCER - ?undefined?</b>.
        /// </summary>
        MCER,
        
        /// <summary>
        /// <b>BDAY - ?undefined?</b>.
        /// </summary>
        BDAY,
        
        /// <summary>
        /// <b>PDAY - ?undefined?</b>.
        /// </summary>
        PDAY,
        
        /// <summary>
        /// <b>GAMN - ?undefined?</b>.
        /// </summary>
        GAMN,
        
        /// <summary>
        /// <b>DFLT - Bond Default</b>.
        /// </summary>
        DFLT,
        
        /// <summary>
        /// <b>NPAT - ?undefined?</b>.
        /// </summary>
        NPAT,
        
        /// <summary>
        /// <b>PERI - ?undefined?</b>.
        /// </summary>
        PERI,
        
        /// <summary>
        /// <b>RDTE - ?undefined?</b>.
        /// </summary>
        RDTE,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification13</b> (Generic Identification 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    /// Class <b>NotificationRejectionReason1</b> (Notification Rejection Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class NotificationRejectionReason1
    {
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type array of RejectionReason6FormatChoice.
        /// </summary>
        [XmlElementAttribute("Rsn", Order=0)]
        public RejectionReason6FormatChoice[] Rsn;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>ProcessedStatus1FormatChoice</b> (Processed Status 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class ProcessedStatus1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ProcessedStatus1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ProcessedStatus1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ProcessedStatus1Code</b> (Processed Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public enum ProcessedStatus1Code
    {
        
        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,
        
        /// <summary>
        /// <b>SENT - ?undefined?</b>.
        /// </summary>
        SENT,
        
        /// <summary>
        /// <b>WARN - ?undefined?</b>.
        /// </summary>
        WARN,
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
    }
    
    /// <summary>
    /// Class <b>NotificationProcessingStatus1</b> (Notification Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class NotificationProcessingStatus1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type ProcessedStatus1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ProcessedStatus1FormatChoice Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>NotificationAdviceStatus1Choice</b> (Notification Advice Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class NotificationAdviceStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcdSts (Processed Status) of type NotificationProcessingStatus1 
        /// RjctdSts (Rejected Status) of type NotificationRejectionReason1 
        /// </summary>
        [XmlElementAttribute("PrcdSts", typeof(NotificationProcessingStatus1), Order=0)]
        [XmlElementAttribute("RjctdSts", typeof(NotificationRejectionReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>RejectionReason11FormatChoice</b> (Rejection Reason 11 Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class RejectionReason11FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RejectionReason11Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RejectionReason11Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason11Code</b> (Rejection Reason 11 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public enum RejectionReason11Code
    {
        
        /// <summary>
        /// <b>FAIL - ?undefined?</b>.
        /// </summary>
        FAIL,
        
        /// <summary>
        /// <b>DCAN - Rejected Since Already Cancelled</b>.
        /// </summary>
        DCAN,
        
        /// <summary>
        /// <b>DPRG - Rejected Since In Progress</b>.
        /// </summary>
        DPRG,
        
        /// <summary>
        /// <b>REFI - ?undefined?</b>.
        /// </summary>
        REFI,
    }
    
    /// <summary>
    /// Class <b>NotificationCancellationRejectionReason1</b> (Notification Cancellation Rejection Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class NotificationCancellationRejectionReason1
    {
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type array of RejectionReason11FormatChoice.
        /// </summary>
        [XmlElementAttribute("Rsn", Order=0)]
        public RejectionReason11FormatChoice[] Rsn;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>ProcessedStatus2FormatChoice</b> (Processed Status 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class ProcessedStatus2FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ProcessedStatus2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ProcessedStatus2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ProcessedStatus2Code</b> (Processed Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public enum ProcessedStatus2Code
    {
        
        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
    }
    
    /// <summary>
    /// Class <b>NotificationCancellationProcessingStatus1</b> (Notification Cancellation Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class NotificationCancellationProcessingStatus1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type ProcessedStatus2FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ProcessedStatus2FormatChoice Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>NotificationCancellationRequestStatus1Choice</b> (Notification Cancellation Request Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
    public class NotificationCancellationRequestStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcdSts (Processed Status) of type NotificationCancellationProcessingStatus1 
        /// RjctdSts (Rejected Status) of type NotificationCancellationRejectionReason1 
        /// </summary>
        [XmlElementAttribute("PrcdSts", typeof(NotificationCancellationProcessingStatus1), Order=0)]
        [XmlElementAttribute("RjctdSts", typeof(NotificationCancellationRejectionReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification3</b> (Alternate Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01", IncludeInSchema=false)]
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
    /// Class <b>SecurityIdentification7</b> (Security Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    /// Class <b>FinancialInstrumentDescription3</b> (Financial Instrument Description 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    /// Class <b>CorporateActionMandatoryVoluntary1FormatChoice</b> (Corporate Action Mandatory Voluntary 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01")]
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
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.011.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>AgtCANtfctnAdvcId - Agent CA Notification Advice Identification</b>.
        /// </summary>
        AgtCANtfctnAdvcId,
        
        /// <summary>
        /// <b>AgtCANtfctnCxlReqId - Agent CA Notification Cancellation Request Identification</b>.
        /// </summary>
        AgtCANtfctnCxlReqId,
    }
}
