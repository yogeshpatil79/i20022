
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



namespace i20022.sese01100102
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id sese.011.001.02 name TransferInstructionStatusReportV02 from Securities Settlement business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>TrfInstrStsRptV02</b> (Transfer Instruction Status Report V02) of type TransferInstructionStatusReportV02.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public TransferInstructionStatusReportV02 TrfInstrStsRptV02;
    }

    /// <summary>
    /// Class <b>TransferInstructionStatusReportV02</b> (Transfer Instruction Status Report V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class TransferInstructionStatusReportV02
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MsgId;

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( "OthrRef", typeof( AdditionalReference3 ), Order = 1 )]
        [XmlElementAttribute( "RltdRef", typeof( AdditionalReference3 ), Order = 1 )]
        [XmlChoiceIdentifierAttribute( "ItemsElementName" )]
        public AdditionalReference3[] Items;

        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute( "ItemsElementName", Order = 2 )]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;

        /// <summary>
        /// Element <b>StsRpt</b> (Status Report) of type TransferStatusAndReason2.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public TransferStatusAndReason2 StsRpt;

        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute( "Xtnsn", Order = 4 )]
        public Extension1[] Xtnsn;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
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
    /// Class <b>CancellationPendingStatus1</b> (Cancellation Pending Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class CancellationPendingStatus1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  NoSpcfdRsn of type NoReasonCode 
        ///  Rsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "NoSpcfdRsn", typeof( NoReasonCode ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
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
    /// Enumeration <b>NoReasonCode</b> (No Reason Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public enum NoReasonCode
    {

        /// <summary>
        /// <b>NORE - No Reason</b>.
        /// </summary>
        NORE,
    }

    /// <summary>
    /// Class <b>ReversedStatus1</b> (Reversed Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class ReversedStatus1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  NoSpcfdRsn of type NoReasonCode 
        ///  Rsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "NoSpcfdRsn", typeof( NoReasonCode ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>CancelledStatus3</b> (Cancelled Status 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class CancelledStatus3
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  NoSpcfdRsn of type NoReasonCode 
        ///  Rsn of type CancelledStatusReason3Code 
        ///  XtndedRsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "NoSpcfdRsn", typeof( NoReasonCode ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( CancelledStatusReason3Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedRsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>CancelledStatusReason3Code</b> (Cancelled Status Reason 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public enum CancelledStatusReason3Code
    {

        /// <summary>
        /// <b>CNTA - Cancelled By Transfer Agent</b>.
        /// </summary>
        CNTA,

        /// <summary>
        /// <b>CNCL - Cancelled By Client</b>.
        /// </summary>
        CNCL,

        /// <summary>
        /// <b>CNIN - Cancelled By Intermediary</b>.
        /// </summary>
        CNIN,
    }

    /// <summary>
    /// Class <b>FailedSettlementStatus1</b> (Failed Settlement Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class FailedSettlementStatus1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  NoSpcfdRsn of type NoReasonCode 
        ///  Rsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "NoSpcfdRsn", typeof( NoReasonCode ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>RejectedStatus8Choice</b> (Rejected Status 8Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class RejectedStatus8Choice
    {

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  Rsn of type TransferRejectedStatusReason2Code 
        ///  XtndedRsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( TransferRejectedStatusReason2Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedRsn", typeof( string ), Order = 0 )]
        public object[] Items;
    }

    /// <summary>
    /// Enumeration <b>TransferRejectedStatusReason2Code</b> (Transfer Rejected Status Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public enum TransferRejectedStatusReason2Code
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
        /// <b>SECU - Security Charge</b>.
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
        /// <b>DQUA - Financial Instrument Quantity</b>.
        /// </summary>
        DQUA,

        /// <summary>
        /// <b>INUK - Investor Name Address Unknown</b>.
        /// </summary>
        INUK,

        /// <summary>
        /// <b>INID - Insufficient Investor Data</b>.
        /// </summary>
        INID,

        /// <summary>
        /// <b>INAC - Invalid Account Servicer</b>.
        /// </summary>
        INAC,

        /// <summary>
        /// <b>INNA - Invalid Nominee Account</b>.
        /// </summary>
        INNA,

        /// <summary>
        /// <b>INPM - Invalid New Plan Manager</b>.
        /// </summary>
        INPM,

        /// <summary>
        /// <b>CYPA - Current Year Partial</b>.
        /// </summary>
        CYPA,

        /// <summary>
        /// <b>PTNS - Partial Not Supported</b>.
        /// </summary>
        PTNS,

        /// <summary>
        /// <b>FTAX - Financial Instrument Tax Year</b>.
        /// </summary>
        FTAX,

        /// <summary>
        /// <b>ISAT - Invalid ISAType</b>.
        /// </summary>
        ISAT,

        /// <summary>
        /// <b>CASH - Cash Payment</b>.
        /// </summary>
        CASH,

        /// <summary>
        /// <b>TREF - Duplicate Transfer Reference</b>.
        /// </summary>
        TREF,
    }

    /// <summary>
    /// Class <b>InRepairStatus3</b> (In Repair Status 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class InRepairStatus3
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  NoSpcfdRsn of type NoReasonCode 
        ///  Rsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "NoSpcfdRsn", typeof( NoReasonCode ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>TransferUnmatchedStatus2</b> (Transfer Unmatched Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class TransferUnmatchedStatus2
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  NoSpcfdRsn of type NoReasonCode 
        ///  Rsn of type TransferUnmatchedReason2Code 
        ///  XtndedRsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "NoSpcfdRsn", typeof( NoReasonCode ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( TransferUnmatchedReason2Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedRsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>TransferUnmatchedReason2Code</b> (Transfer Unmatched Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public enum TransferUnmatchedReason2Code
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
    }

    /// <summary>
    /// Class <b>PendingSettlementStatus2</b> (Pending Settlement Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class PendingSettlementStatus2
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  NoSpcfdRsn of type NoReasonCode 
        ///  Rsn of type PendingSettlementStatusReason2Code 
        ///  XtndedRsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "NoSpcfdRsn", typeof( NoReasonCode ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( PendingSettlementStatusReason2Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedRsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>PendingSettlementStatusReason2Code</b> (Pending Settlement Status Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public enum PendingSettlementStatusReason2Code
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

        /// <summary>
        /// <b>ACOP - Account Not Open</b>.
        /// </summary>
        ACOP,

        /// <summary>
        /// <b>IINV - Under Investigation</b>.
        /// </summary>
        IINV,

        /// <summary>
        /// <b>CINV - Commercial Invoice</b>.
        /// </summary>
        CINV,

        /// <summary>
        /// <b>AINV - Under Transfer Agent Investigation</b>.
        /// </summary>
        AINV,

        /// <summary>
        /// <b>WTRF - Awaiting Transfer Agent Status</b>.
        /// </summary>
        WTRF,

        /// <summary>
        /// <b>USUA - Usual Transaction Time</b>.
        /// </summary>
        USUA,

        /// <summary>
        /// <b>ASTA - Awaiting Status</b>.
        /// </summary>
        ASTA,

        /// <summary>
        /// <b>AFST - Application Form Sent</b>.
        /// </summary>
        AFST,

        /// <summary>
        /// <b>STST - Stock Transfer Form Sent</b>.
        /// </summary>
        STST,

        /// <summary>
        /// <b>LPRO - Longer Processing</b>.
        /// </summary>
        LPRO,

        /// <summary>
        /// <b>ADRQ - Additional Documents Requested</b>.
        /// </summary>
        ADRQ,

        /// <summary>
        /// <b>ADS1 - Additional Documents Sent 1</b>.
        /// </summary>
        ADS1,

        /// <summary>
        /// <b>ADS2 - Additional Documents Sent 2</b>.
        /// </summary>
        ADS2,

        /// <summary>
        /// <b>DRJC - Documents Rejected</b>.
        /// </summary>
        DRJC,

        /// <summary>
        /// <b>CYIN - Awaiting Counterparty Receipt</b>.
        /// </summary>
        CYIN,

        /// <summary>
        /// <b>CYDV - Awaiting Counterparty Delivery</b>.
        /// </summary>
        CYDV,

        /// <summary>
        /// <b>OVER - Normal Processing Period Lapsed</b>.
        /// </summary>
        OVER,

        /// <summary>
        /// <b>WCPA - Wrong Counterparty Account</b>.
        /// </summary>
        WCPA,

        /// <summary>
        /// <b>SDUT - Lack Of Stamp Duty Information</b>.
        /// </summary>
        SDUT,

        /// <summary>
        /// <b>TAPR - Transfer Agent Processing</b>.
        /// </summary>
        TAPR,

        /// <summary>
        /// <b>XCNF - Expected Confirmation</b>.
        /// </summary>
        XCNF,

        /// <summary>
        /// <b>ESCA - Escalation</b>.
        /// </summary>
        ESCA,

        /// <summary>
        /// <b>NRCP - Transfer Agent Non Receipt</b>.
        /// </summary>
        NRCP,

        /// <summary>
        /// <b>FVER - Final Verification</b>.
        /// </summary>
        FVER,
    }

    /// <summary>
    /// Class <b>TransferInstructionStatus2</b> (Transfer Instruction Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class TransferInstructionStatus2
    {

        /// <summary>
        /// Element <b>Sts</b> (Status) of type TransferStatus2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public TransferStatus2Code Sts;

        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Rsn;
    }

    /// <summary>
    /// Enumeration <b>TransferStatus2Code</b> (Transfer Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public enum TransferStatus2Code
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
        /// <b>SETT - Settled</b>.
        /// </summary>
        SETT,
    }

    /// <summary>
    /// Class <b>TransferStatusAndReason2</b> (Transfer Status And Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
    public class TransferStatusAndReason2
    {

        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MstrRef;

        /// <summary>
        /// Element <b>TrfRef</b> (Transfer Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string TrfRef;

        /// <summary>
        /// Element <b>ClntRef</b> (Client Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string ClntRef;

        /// <summary>
        /// Element <b>CxlRef</b> (Cancellation Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string CxlRef;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Canc of type CancelledStatus3 
        ///  CxlPdg of type CancellationPendingStatus1 
        ///  FaildSttlm of type FailedSettlementStatus1 
        ///  InRpr of type InRepairStatus3 
        ///  PdgSttlm of type PendingSettlementStatus2 
        ///  Rjctd of type RejectedStatus8Choice 
        ///  Rvsd of type ReversedStatus1 
        ///  Sts of type TransferInstructionStatus2 
        ///  Umtchd of type TransferUnmatchedStatus2 
        /// </summary>
        [XmlElementAttribute( "Canc", typeof( CancelledStatus3 ), Order = 4 )]
        [XmlElementAttribute( "CxlPdg", typeof( CancellationPendingStatus1 ), Order = 4 )]
        [XmlElementAttribute( "FaildSttlm", typeof( FailedSettlementStatus1 ), Order = 4 )]
        [XmlElementAttribute( "InRpr", typeof( InRepairStatus3 ), Order = 4 )]
        [XmlElementAttribute( "PdgSttlm", typeof( PendingSettlementStatus2 ), Order = 4 )]
        [XmlElementAttribute( "Rjctd", typeof( RejectedStatus8Choice ), Order = 4 )]
        [XmlElementAttribute( "Rvsd", typeof( ReversedStatus1 ), Order = 4 )]
        [XmlElementAttribute( "Sts", typeof( TransferInstructionStatus2 ), Order = 4 )]
        [XmlElementAttribute( "Umtchd", typeof( TransferUnmatchedStatus2 ), Order = 4 )]
        public object Item;

        /// <summary>
        /// Element <b>TradDt</b> (Trade Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 5 )]
        public System.DateTime TradDt;

        /// <summary>
        /// Element <b>TradDtSpecified</b> (Trade Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TradDtSpecified;

        /// <summary>
        /// Element <b>SndOutDt</b> (Send Out Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 6 )]
        public System.DateTime SndOutDt;

        /// <summary>
        /// Element <b>SndOutDtSpecified</b> (Send Out Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SndOutDtSpecified;

        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public PartyIdentification2Choice StsInitr;
    }

    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
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
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02" )]
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

    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.02", IncludeInSchema = false )]
    public enum ItemsChoiceType
    {

        /// <summary>
        /// <b>OthrRef - ?undefined</b>.
        /// </summary>
        OthrRef,

        /// <summary>
        /// <b>RltdRef - ?undefined</b>.
        /// </summary>
        RltdRef,
    }
}
