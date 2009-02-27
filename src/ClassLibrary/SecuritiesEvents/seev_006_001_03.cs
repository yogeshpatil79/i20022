
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



namespace i20022.seev00600103
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.006.001.03 name MeetingInstructionStatusV03 from Securities Events business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>MtgInstrSts</b> (Meeting Instruction Status) of type MeetingInstructionStatusV03.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MeetingInstructionStatusV03 MtgInstrSts;
    }
    
    /// <summary>
    /// Class <b>MeetingInstructionStatusV03</b> (Meeting Instruction Status V03).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class MeetingInstructionStatusV03
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 Id;
        
        /// <summary>
        /// Element <b>InstrTp</b> (Instruction Type) of type InstructionType1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public InstructionType1Choice InstrTp;
        
        /// <summary>
        /// Element <b>MtgRef</b> (Meeting Reference) of type MeetingReference4.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public MeetingReference4 MtgRef;
        
        /// <summary>
        /// Element <b>RptgPty</b> (Reporting Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification9Choice RptgPty;
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification11.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public SecurityIdentification11 SctyId;
        
        /// <summary>
        /// Element <b>InstrTpSts</b> (Instruction Type Status) of type InstructionTypeStatus1Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public InstructionTypeStatus1Choice InstrTpSts;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>CancellationRejectionStatus1Choice</b> (Cancellation Rejection Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class CancellationRejectionStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RejectionReason2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RejectionReason2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason2Code</b> (Rejection Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>GenericIdentification13</b> (Generic Identification 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>AdditionalStatus2</b> (Additional Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class AdditionalStatus2
    {
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type CancellationRejectionStatus1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CancellationRejectionStatus1Choice Rsn;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>CancellationProcessingStatus1</b> (Cancellation Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>CancellationStatus2Choice</b> (Cancellation Status 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class CancellationStatus2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcgSts (Processing Status) of type CancellationProcessingStatus1 
        /// RjctnSts (Rejection Status) of type AdditionalStatus2 
        /// </summary>
        [XmlElementAttribute("PrcgSts", typeof(CancellationProcessingStatus1), Order=0)]
        [XmlElementAttribute("RjctnSts", typeof(AdditionalStatus2), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>DetailedInstructionStatus8</b> (Detailed Instruction Status 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class DetailedInstructionStatus8
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
        /// Element <b>InstrSts</b> (Instruction Status) of type InstructionStatus4Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InstructionStatus4Choice InstrSts;
    }
    
    /// <summary>
    /// Class <b>InstructionStatus4Choice</b> (Instruction Status 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class InstructionStatus4Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcgSts (Processing Status) of type InstructionProcessingStatus1 
        /// RjctnSts (Rejection Status) of type AdditionalStatus1 
        /// </summary>
        [XmlElementAttribute("PrcgSts", typeof(InstructionProcessingStatus1), Order=0)]
        [XmlElementAttribute("RjctnSts", typeof(AdditionalStatus1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>InstructionProcessingStatus1</b> (Instruction Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>AdditionalStatus1</b> (Additional Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class AdditionalStatus1
    {
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type InstructionRejectionStatus1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InstructionRejectionStatus1Choice Rsn;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>InstructionRejectionStatus1Choice</b> (Instruction Rejection Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class InstructionRejectionStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RejectionReason1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RejectionReason1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason1Code</b> (Rejection Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>InstructionStatus3Choice</b> (Instruction Status 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class InstructionStatus3Choice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// DtldInstrSts (Detailed Instruction Status) of type DetailedInstructionStatus8 
        /// GblInstrSts (Global Instruction Status) of type InstructionStatus4Choice 
        /// </summary>
        [XmlElementAttribute("DtldInstrSts", typeof(DetailedInstructionStatus8), Order=0)]
        [XmlElementAttribute("GblInstrSts", typeof(InstructionStatus4Choice), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>InstructionTypeStatus1Choice</b> (Instruction Type Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class InstructionTypeStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// CxlSts (Cancellation Status) of type CancellationStatus2Choice 
        /// InstrSts (Instruction Status) of type InstructionStatus3Choice 
        /// </summary>
        [XmlElementAttribute("CxlSts", typeof(CancellationStatus2Choice), Order=0)]
        [XmlElementAttribute("InstrSts", typeof(InstructionStatus3Choice), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>IdentificationSource1Choice</b> (Identification Source 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class IdentificationSource1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("Dmst", typeof(string), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>Dmst - Domestic</b>.
        /// </summary>
        Dmst,
        
        /// <summary>
        /// <b>Prtry - Proprietary</b>.
        /// </summary>
        Prtry,
    }
    
    /// <summary>
    /// Class <b>AlternateIdentification1</b> (Alternate Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class AlternateIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>IdSrc</b> (Identification Source) of type IdentificationSource1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public IdentificationSource1Choice IdSrc;
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification11Choice</b> (Security Identification 11 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class SecurityIdentification11Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// ISIN (ISIN) of type string 
        /// OthrId (Other Identification) of type AlternateIdentification1 
        /// </summary>
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("OthrId", typeof(AlternateIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification11</b> (Security Identification 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class SecurityIdentification11
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification11Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification11Choice Id;
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Desc;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>MeetingTypeClassification1Choice</b> (Meeting Type Classification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class MeetingTypeClassification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type MeetingTypeClassification1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(MeetingTypeClassification1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>MeetingTypeClassification1Code</b> (Meeting Type Classification 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>MeetingReference4</b> (Meeting Reference 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class MeetingReference4
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
        /// Element <b>Clssfctn</b> (Classification) of type MeetingTypeClassification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public MeetingTypeClassification1Choice Clssfctn;
        
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
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
    /// Class <b>MessageIdentification</b> (Message Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class MessageIdentification
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>InstructionType1Choice</b> (Instruction Type 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03")]
    public class InstructionType1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type MessageIdentification.
        /// </summary>
        [XmlElementAttribute("InstrCxlId", typeof(MessageIdentification), Order=0)]
        [XmlElementAttribute("InstrId", typeof(MessageIdentification), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public MessageIdentification Item;
        
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.006.001.03", IncludeInSchema=false)]
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
