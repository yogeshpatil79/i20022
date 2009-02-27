
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



namespace i20022.sese01100101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id sese.011.001.01 name TransferInstructionStatusReportV01 from Securities Settlement business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>sese01100101</b> (sese 01100101) of type sese01100101.
        /// </summary>
        [XmlElementAttribute("sese.011.001.01", Order=0)]
        public sese01100101 sese01100101;
    }
    
    /// <summary>
    /// Class <b>sese01100101</b> (sese 01100101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="sese.011.001.01", Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class sese01100101
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of AdditionalReference2.
        /// </summary>
        [XmlElementAttribute("OthrRef", typeof(AdditionalReference2), Order=0)]
        [XmlElementAttribute("RltdRef", typeof(AdditionalReference2), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public AdditionalReference2[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <summary>
        /// Element <b>StsRpt</b> (Status Report) of type TransferStatusAndReason.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TransferStatusAndReason StsRpt;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference2</b> (Additional Reference 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class AdditionalReference2
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification1Choice RefIssr;
        
        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string MsgNm;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification1Choice</b> (Party Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class PartyIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress2 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress2), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress2</b> (Name And Address 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class NameAndAddress2
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type LongPostalAddress1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public LongPostalAddress1Choice Adr;
    }
    
    /// <summary>
    /// Class <b>LongPostalAddress1Choice</b> (Long Postal Address 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class LongPostalAddress1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type StructuredLongPostalAddress1 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(StructuredLongPostalAddress1), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>StructuredLongPostalAddress1</b> (Structured Long Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class StructuredLongPostalAddress1
    {
        
        /// <summary>
        /// Element <b>BldgNm</b> (Building Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BldgNm;
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>StrtBldgId</b> (Street Building Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StrtBldgId;
        
        /// <summary>
        /// Element <b>Flr</b> (Floor) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Flr;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>DstrctNm</b> (District Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string DstrctNm;
        
        /// <summary>
        /// Element <b>RgnId</b> (Region Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string RgnId;
        
        /// <summary>
        /// Element <b>Stat</b> (State) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Stat;
        
        /// <summary>
        /// Element <b>CtyId</b> (County Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string CtyId;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string Ctry;
        
        /// <summary>
        /// Element <b>PstCdId</b> (Post Code Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string PstCdId;
        
        /// <summary>
        /// Element <b>POB</b> (PostOfficeBox) of type string.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public string POB;
    }
    
    /// <summary>
    /// Class <b>RejectedStatusReason5</b> (Rejected Status Reason 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class RejectedStatusReason5
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TransferRejectedStatusReason1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TransferRejectedStatusReason1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TransferRejectedStatusReason1Code</b> (Transfer Rejected Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public enum TransferRejectedStatusReason1Code
    {
        
        /// <summary>
        /// <b>DDAT - Settlement Date</b>.
        /// </summary>
        DDAT,
        
        /// <summary>
        /// <b>DEPT - Settlement Place</b>.
        /// </summary>
        DEPT,
        
        /// <summary>
        /// <b>DSEC - Financial Instrument Identification</b>.
        /// </summary>
        DSEC,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>ISTP - Settlement Parties</b>.
        /// </summary>
        ISTP,
        
        /// <summary>
        /// <b>ICTN - Certificate Number</b>.
        /// </summary>
        ICTN,
        
        /// <summary>
        /// <b>SAFE - Investment Account</b>.
        /// </summary>
        SAFE,
        
        /// <summary>
        /// <b>IAQD - Acquisition Date</b>.
        /// </summary>
        IAQD,
        
        /// <summary>
        /// <b>BLCA - Account Blocked For Corporate Action</b>.
        /// </summary>
        BLCA,
        
        /// <summary>
        /// <b>DOCC - Awaiting Documents</b>.
        /// </summary>
        DOCC,
        
        /// <summary>
        /// <b>IDNA - Financial Instrument Identification And Name</b>.
        /// </summary>
        IDNA,
        
        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
        
        /// <summary>
        /// <b>LEGL - Legal Decision</b>.
        /// </summary>
        LEGL,
        
        /// <summary>
        /// <b>NSLA - Not Compliant With SLA</b>.
        /// </summary>
        NSLA,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>DQUA - Financial Instrument Quantity</b>.
        /// </summary>
        DQUA,
    }
    
    /// <summary>
    /// Class <b>RejectedStatus3Choice</b> (Rejected Status 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class RejectedStatus3Choice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type RejectedStatusReason5 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(RejectedStatusReason5), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
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
    /// Class <b>InRepairStatusReason2</b> (In Repair Status Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class InRepairStatusReason2
    {
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>InRepairStatus2Choice</b> (In Repair Status 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class InRepairStatus2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// NoRsn (No Reason) of type NoReasonCode 
        /// Rsn (Reason) of type InRepairStatusReason2 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("NoRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("Rsn", typeof(InRepairStatusReason2), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>NoReasonCode</b> (No Reason Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public enum NoReasonCode
    {
        
        /// <summary>
        /// <b>NORE - No Reason</b>.
        /// </summary>
        NORE,
    }
    
    /// <summary>
    /// Class <b>TransferUnmatchedStatusReason1</b> (Transfer Unmatched Status Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class TransferUnmatchedStatusReason1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TransferUnmatchedReason1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TransferUnmatchedReason1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TransferUnmatchedReason1Code</b> (Transfer Unmatched Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public enum TransferUnmatchedReason1Code
    {
        
        /// <summary>
        /// <b>CMIS - No Match</b>.
        /// </summary>
        CMIS,
        
        /// <summary>
        /// <b>CPCA - Counterparty Cancelled</b>.
        /// </summary>
        CPCA,
        
        /// <summary>
        /// <b>DELN - Transaction Direction</b>.
        /// </summary>
        DELN,
        
        /// <summary>
        /// <b>DSEC - Financial Instrument Identification</b>.
        /// </summary>
        DSEC,
        
        /// <summary>
        /// <b>PHYS - Physical Certification</b>.
        /// </summary>
        PHYS,
        
        /// <summary>
        /// <b>PODU - Duplicate</b>.
        /// </summary>
        PODU,
        
        /// <summary>
        /// <b>DEPT - Settlement Place</b>.
        /// </summary>
        DEPT,
        
        /// <summary>
        /// <b>DDAT - Settlement Date</b>.
        /// </summary>
        DDAT,
        
        /// <summary>
        /// <b>DQUA - Financial Instrument Quantity</b>.
        /// </summary>
        DQUA,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>TransferUnmatchedStatus</b> (Transfer Unmatched Status).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class TransferUnmatchedStatus
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// NoRsn (No Reason) of type NoReasonCode 
        /// Rsn (Reason) of type TransferUnmatchedStatusReason1 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("NoRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("Rsn", typeof(TransferUnmatchedStatusReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PendingSettlementStatusReason1</b> (Pending Settlement Status Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class PendingSettlementStatusReason1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type PendingSettlementStatusReason1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PendingSettlementStatusReason1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>PendingSettlementStatusReason1Code</b> (Pending Settlement Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public enum PendingSettlementStatusReason1Code
    {
        
        /// <summary>
        /// <b>AWSH - Awaiting Shares From Counterparty</b>.
        /// </summary>
        AWSH,
        
        /// <summary>
        /// <b>BLOC - Account Blocked</b>.
        /// </summary>
        BLOC,
        
        /// <summary>
        /// <b>CAIS - Awaiting Securities</b>.
        /// </summary>
        CAIS,
        
        /// <summary>
        /// <b>CLAC - Counterparty Insufficient Securities</b>.
        /// </summary>
        CLAC,
        
        /// <summary>
        /// <b>DOCC - Awaiting Documents</b>.
        /// </summary>
        DOCC,
        
        /// <summary>
        /// <b>DOCY - Awaiting Documents Or Endorsements From You</b>.
        /// </summary>
        DOCY,
        
        /// <summary>
        /// <b>IAAD - Status Reason Investigation</b>.
        /// </summary>
        IAAD,
        
        /// <summary>
        /// <b>LACK - Lack Of Securities</b>.
        /// </summary>
        LACK,
        
        /// <summary>
        /// <b>LINK - Pending Linked Instruction</b>.
        /// </summary>
        LINK,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>PHCK - Physical Securities Verification</b>.
        /// </summary>
        PHCK,
        
        /// <summary>
        /// <b>PHSE - Physical Delivery Delay</b>.
        /// </summary>
        PHSE,
        
        /// <summary>
        /// <b>SBLO - Securities Blocked</b>.
        /// </summary>
        SBLO,
        
        /// <summary>
        /// <b>MINF - Missing Information</b>.
        /// </summary>
        MINF,
    }
    
    /// <summary>
    /// Class <b>PendingSettlementStatusChoice</b> (Pending Settlement Status Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class PendingSettlementStatusChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// NoRsn (No Reason) of type NoReasonCode 
        /// Rsn (Reason) of type PendingSettlementStatusReason1 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("NoRsn", typeof(NoReasonCode), Order=0)]
        [XmlElementAttribute("Rsn", typeof(PendingSettlementStatusReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>TransferInstructionStatus</b> (Transfer Instruction Status).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class TransferInstructionStatus
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type TransferStatus1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TransferStatus1Code Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TransferStatus1Code</b> (Transfer Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public enum TransferStatus1Code
    {
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
        
        /// <summary>
        /// <b>STNP - Sent To Next Party</b>.
        /// </summary>
        STNP,
        
        /// <summary>
        /// <b>MACH - Matched</b>.
        /// </summary>
        MACH,
        
        /// <summary>
        /// <b>COSE - Already Executed</b>.
        /// </summary>
        COSE,
        
        /// <summary>
        /// <b>CANP - Pending</b>.
        /// </summary>
        CANP,
        
        /// <summary>
        /// <b>RVSD - ?undefined?</b>.
        /// </summary>
        RVSD,
        
        /// <summary>
        /// <b>CAND - Complete</b>.
        /// </summary>
        CAND,
    }
    
    /// <summary>
    /// Class <b>TransferStatusAndReason</b> (Transfer Status And Reason).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01")]
    public class TransferStatusAndReason
    {
        
        /// <summary>
        /// Element <b>TrfRef</b> (Transfer Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TrfRef;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// InRpr (In Repair) of type InRepairStatus2Choice 
        /// PdgSttlm (Pending Settlement) of type PendingSettlementStatusChoice 
        /// Rjctd (Rejected) of type RejectedStatus3Choice 
        /// Sts (Status) of type TransferInstructionStatus 
        /// Umtchd (Unmatched) of type TransferUnmatchedStatus 
        /// </summary>
        [XmlElementAttribute("InRpr", typeof(InRepairStatus2Choice), Order=1)]
        [XmlElementAttribute("PdgSttlm", typeof(PendingSettlementStatusChoice), Order=1)]
        [XmlElementAttribute("Rjctd", typeof(RejectedStatus3Choice), Order=1)]
        [XmlElementAttribute("Sts", typeof(TransferInstructionStatus), Order=1)]
        [XmlElementAttribute("Umtchd", typeof(TransferUnmatchedStatus), Order=1)]
        public object Item;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification1Choice StsInitr;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.011.001.01", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <summary>
        /// <b>OthrRef - Other Reference</b>.
        /// </summary>
        OthrRef,
        
        /// <summary>
        /// <b>RltdRef - Related Reference</b>.
        /// </summary>
        RltdRef,
    }
}
