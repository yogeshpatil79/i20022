
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



namespace i20022.seev00600102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.006.001.02 name MeetingInstructionStatusV02 from Securities Events business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>MtgInstrSts</b> (Meeting Instruction Status) of type MeetingInstructionStatusV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MeetingInstructionStatusV02 MtgInstrSts;
    }
    
    /// <summary>
    /// Class <b>MeetingInstructionStatusV02</b> (Meeting Instruction Status V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class MeetingInstructionStatusV02
    {
        
        /// <summary>
        /// Element <b>MtgInstrStsId</b> (Meeting Instruction Status Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 MtgInstrStsId;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type MessageIdentification.
        /// </summary>
        [XmlElementAttribute("InstrCxlId", typeof(MessageIdentification), Order=1)]
        [XmlElementAttribute("InstrId", typeof(MessageIdentification), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public MessageIdentification Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
        
        /// <summary>
        /// Element <b>MtgRef</b> (Meeting Reference) of type MeetingReference3.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public MeetingReference3 MtgRef;
        
        /// <summary>
        /// Element <b>RptgPty</b> (Reporting Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification9Choice RptgPty;
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public SecurityIdentification3 SctyId;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// CxlSts (Cancellation Status) of type CancellationStatus1Choice 
        /// InstrSts (Instruction Status) of type InstructionStatus1Choice 
        /// </summary>
        [XmlElementAttribute("CxlSts", typeof(CancellationStatus1Choice), Order=6)]
        [XmlElementAttribute("InstrSts", typeof(InstructionStatus1Choice), Order=6)]
        public object Item1;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class MessageIdentification1
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
    }
    
    /// <summary>
    /// Class <b>CancellationRejectionStatus1</b> (Cancellation Rejection Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class CancellationRejectionStatus1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Rsn (Reason) of type RejectionReason2Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("Rsn", typeof(RejectionReason2Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason2Code</b> (Rejection Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public enum RejectionReason2Code
    {
        
        /// <summary>
        /// <b>ULNK - Unknown Linkages Reference</b>.
        /// </summary>
        ULNK,
        
        /// <summary>
        /// <b>RBIS - Rejected By Issuer Or Registrar</b>.
        /// </summary>
        RBIS,
        
        /// <summary>
        /// <b>INIR - Instruction Irrevocable</b>.
        /// </summary>
        INIR,
        
        /// <summary>
        /// <b>ADEA - After Deadline</b>.
        /// </summary>
        ADEA,
        
        /// <summary>
        /// <b>LATE - Too Late</b>.
        /// </summary>
        LATE,
        
        /// <summary>
        /// <b>DCAN - Rejected Since Already Cancelled</b>.
        /// </summary>
        DCAN,
        
        /// <summary>
        /// <b>DPRG - Rejected Since In Progress</b>.
        /// </summary>
        DPRG,
    }
    
    /// <summary>
    /// Class <b>CancellationProcessingStatus1</b> (Cancellation Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class CancellationProcessingStatus1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type CancellationStatus3Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CancellationStatus3Code Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>CancellationStatus3Code</b> (Cancellation Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public enum CancellationStatus3Code
    {
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
        
        /// <summary>
        /// <b>CANP - Pending</b>.
        /// </summary>
        CANP,
        
        /// <summary>
        /// <b>CAND - Complete</b>.
        /// </summary>
        CAND,
        
        /// <summary>
        /// <b>RCIS - Received By Issuer Or Registrar</b>.
        /// </summary>
        RCIS,
    }
    
    /// <summary>
    /// Class <b>CancellationStatus1Choice</b> (Cancellation Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class CancellationStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcgSts (Processing Status) of type CancellationProcessingStatus1 
        /// RjctnSts (Rejection Status) of type CancellationRejectionStatus1 
        /// </summary>
        [XmlElementAttribute("PrcgSts", typeof(CancellationProcessingStatus1), Order=0)]
        [XmlElementAttribute("RjctnSts", typeof(CancellationRejectionStatus1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>DetailedInstructionStatus1</b> (Detailed Instruction Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class DetailedInstructionStatus1
    {
        
        /// <summary>
        /// Element <b>InstrId</b> (Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string InstrId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AcctId;
        
        /// <summary>
        /// Element <b>SubAcctId</b> (Sub Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string SubAcctId;
        
        /// <summary>
        /// Element <b>InstrSts</b> (Instruction Status) of type InstructionStatus2Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InstructionStatus2Choice InstrSts;
    }
    
    /// <summary>
    /// Class <b>InstructionStatus2Choice</b> (Instruction Status 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class InstructionStatus2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcgSts (Processing Status) of type InstructionProcessingStatus1 
        /// RjctnSts (Rejection Status) of type InstructionRejectionStatus1 
        /// </summary>
        [XmlElementAttribute("PrcgSts", typeof(InstructionProcessingStatus1), Order=0)]
        [XmlElementAttribute("RjctnSts", typeof(InstructionRejectionStatus1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>InstructionProcessingStatus1</b> (Instruction Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class InstructionProcessingStatus1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type Status3Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Status3Code Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>Status3Code</b> (Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public enum Status3Code
    {
        
        /// <summary>
        /// <b>CAND - Complete</b>.
        /// </summary>
        CAND,
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
        
        /// <summary>
        /// <b>NOIN - Institutional</b>.
        /// </summary>
        NOIN,
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
        
        /// <summary>
        /// <b>RCIS - Received By Issuer Or Registrar</b>.
        /// </summary>
        RCIS,
        
        /// <summary>
        /// <b>STIN - Standing Instruction</b>.
        /// </summary>
        STIN,
    }
    
    /// <summary>
    /// Class <b>InstructionRejectionStatus1</b> (Instruction Rejection Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class InstructionRejectionStatus1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Rsn (Reason) of type RejectionReason1Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("Rsn", typeof(RejectionReason1Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason1Code</b> (Rejection Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public enum RejectionReason1Code
    {
        
        /// <summary>
        /// <b>ADEA - After Deadline</b>.
        /// </summary>
        ADEA,
        
        /// <summary>
        /// <b>LATE - Too Late</b>.
        /// </summary>
        LATE,
        
        /// <summary>
        /// <b>DQUA - Financial Instrument Quantity</b>.
        /// </summary>
        DQUA,
        
        /// <summary>
        /// <b>IPOS - Insufficient Treshold Position</b>.
        /// </summary>
        IPOS,
        
        /// <summary>
        /// <b>LACK - Lack Of Securities</b>.
        /// </summary>
        LACK,
        
        /// <summary>
        /// <b>SAFE - Investment Account</b>.
        /// </summary>
        SAFE,
        
        /// <summary>
        /// <b>RBIS - Rejected By Issuer Or Registrar</b>.
        /// </summary>
        RBIS,
        
        /// <summary>
        /// <b>EVNM - Unrecognized Identification</b>.
        /// </summary>
        EVNM,
        
        /// <summary>
        /// <b>ULNK - Unknown Linkages Reference</b>.
        /// </summary>
        ULNK,
        
        /// <summary>
        /// <b>PRXY - Proxy Card Discrepancy</b>.
        /// </summary>
        PRXY,
        
        /// <summary>
        /// <b>PART - Formal Partnership</b>.
        /// </summary>
        PART,
        
        /// <summary>
        /// <b>SPLT - Split Vote Not Allowed</b>.
        /// </summary>
        SPLT,
        
        /// <summary>
        /// <b>IPOA - Missing Or Invalid POA</b>.
        /// </summary>
        IPOA,
        
        /// <summary>
        /// <b>IREG - Registration Discrepancy</b>.
        /// </summary>
        IREG,
        
        /// <summary>
        /// <b>DSEC - Financial Instrument Identification</b>.
        /// </summary>
        DSEC,
    }
    
    /// <summary>
    /// Class <b>InstructionStatus1Choice</b> (Instruction Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class InstructionStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// DtldInstrSts (Detailed Instruction Status) of type DetailedInstructionStatus1 
        /// GblInstrSts (Global Instruction Status) of type InstructionStatus2Choice 
        /// </summary>
        [XmlElementAttribute("DtldInstrSts", typeof(DetailedInstructionStatus1), Order=0)]
        [XmlElementAttribute("GblInstrSts", typeof(InstructionStatus2Choice), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>AlternateFinancialInstrumentIdentification1</b> (Alternate Financial Instrument Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class AlternateFinancialInstrumentIdentification1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("DmstIdSrc", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryIdSrc", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Id;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02", IncludeInSchema=false)]
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
    /// Class <b>SecurityIdentification3</b> (Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class SecurityIdentification3
    {
        
        /// <summary>
        /// Element <b>ISIN</b> (ISIN) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string ISIN;
        
        /// <summary>
        /// Element <b>TckrSymb</b> (Ticker Symbol) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string TckrSymb;
        
        /// <summary>
        /// Element <b>CUSIP</b> (CUSIP) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CUSIP;
        
        /// <summary>
        /// Element <b>SEDOL</b> (SEDOL) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string SEDOL;
        
        /// <summary>
        /// Element <b>QUICK</b> (QUICK) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string QUICK;
        
        /// <summary>
        /// Element <b>OthrId</b> (Other Identification) of type AlternateFinancialInstrumentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public AlternateFinancialInstrumentIdentification1 OthrId;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
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
    /// Class <b>PartyIdentification9Choice</b> (Party Identification 9Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class PartyIdentification9Choice
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
    /// Class <b>MeetingReference3</b> (Meeting Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class MeetingReference3
    {
        
        /// <summary>
        /// Element <b>MtgId</b> (Meeting Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MtgId;
        
        /// <summary>
        /// Element <b>IssrMtgId</b> (Issuer Meeting Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IssrMtgId;
        
        /// <summary>
        /// Element <b>MtgDtAndTm</b> (Meeting Date And Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public System.DateTime MtgDtAndTm;
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type MeetingType2Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public MeetingType2Code Tp;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Clssfctn (Classification) of type MeetingTypeClassification1Code 
        /// XtndedClssfctn (Extended Classification) of type string 
        /// </summary>
        [XmlElementAttribute("Clssfctn", typeof(MeetingTypeClassification1Code), Order=4)]
        [XmlElementAttribute("XtndedClssfctn", typeof(string), Order=4)]
        public object Item;
        
        /// <summary>
        /// Element <b>Lctn</b> (Location) of type array of PostalAddress1.
        /// </summary>
        [XmlElementAttribute("Lctn", Order=5)]
        public PostalAddress1[] Lctn;
    }
    
    /// <summary>
    /// Enumeration <b>MeetingType2Code</b> (Meeting Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public enum MeetingTypeClassification1Code
    {
        
        /// <summary>
        /// <b>AMET - Annual</b>.
        /// </summary>
        AMET,
        
        /// <summary>
        /// <b>OMET - Ordinary General Meeting</b>.
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02")]
    public class MessageIdentification
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>InstrCxlId - Instruction Cancellation Identification</b>.
        /// </summary>
        InstrCxlId,
        
        /// <summary>
        /// <b>InstrId - Instruction Identification</b>.
        /// </summary>
        InstrId,
    }
}
