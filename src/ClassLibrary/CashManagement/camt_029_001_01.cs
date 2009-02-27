
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



namespace i20022.camt02900101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.029.001.01 name ResolutionOfInvestigation from Cash Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>camt02900101</b> (camt 02900101) of type camt02900101.
        /// </summary>
        [XmlElementAttribute("camt.029.001.01", Order=0)]
        public camt02900101 camt02900101;
    }
    
    /// <summary>
    /// Class <b>camt02900101</b> (camt 02900101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="camt.029.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public class camt02900101
    {
        
        /// <summary>
        /// Element <b>Assgnmt</b> (Assignment) of type CaseAssignment.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CaseAssignment Assgnmt;
        
        /// <summary>
        /// Element <b>RslvdCase</b> (Resolved Case) of type Case.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Case RslvdCase;
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type InvestigationStatusChoice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public InvestigationStatusChoice Sts;
        
        /// <summary>
        /// Element <b>CrrctnTx</b> (Correction Transaction) of type PaymentInstructionExtract.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PaymentInstructionExtract CrrctnTx;
    }
    
    /// <summary>
    /// Class <b>CaseAssignment</b> (Case Assignment).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public class CaseAssignment
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Assgnr</b> (Assigner) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Assgnr;
        
        /// <summary>
        /// Element <b>Assgne</b> (Assignee) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Assgne;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public class CurrencyAndAmount
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
    /// Class <b>PaymentInstructionExtract</b> (Payment Instruction Extract).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public class PaymentInstructionExtract
    {
        
        /// <summary>
        /// Element <b>AssgnrInstrId</b> (Assigner Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AssgnrInstrId;
        
        /// <summary>
        /// Element <b>AssgneInstrId</b> (Assignee Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AssgneInstrId;
        
        /// <summary>
        /// Element <b>CcyAmt</b> (Currency Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount CcyAmt;
        
        /// <summary>
        /// Element <b>ValDt</b> (Value Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime ValDt;
        
        /// <summary>
        /// Element <b>ValDtSpecified</b> (Value Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValDtSpecified;
    }
    
    /// <summary>
    /// Class <b>RejectedCancellationJustification</b> (Rejected Cancellation Justification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public class RejectedCancellationJustification
    {
        
        /// <summary>
        /// Element <b>RsnCd</b> (Reason Code) of type PaymentCancellationRejection1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PaymentCancellationRejection1Code RsnCd;
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Rsn;
    }
    
    /// <summary>
    /// Enumeration <b>PaymentCancellationRejection1Code</b> (Payment Cancellation Rejection 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public enum PaymentCancellationRejection1Code
    {
        
        /// <summary>
        /// <b>LEGL - Legal Decision</b>.
        /// </summary>
        LEGL,
        
        /// <summary>
        /// <b>AGNT - Incorrect Agent</b>.
        /// </summary>
        AGNT,
        
        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,
    }
    
    /// <summary>
    /// Class <b>InvestigationStatusChoice</b> (Investigation Status Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public class InvestigationStatusChoice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// AssgnmtCxlConf (Assignment Cancellation Confirmation) of type bool 
        /// Conf (Confirmation) of type InvestigationExecutionConfirmation1Code 
        /// DplctOf (Duplicate Of) of type Case 
        /// RjctdCxl (Rejected Cancellation) of type RejectedCancellationJustification 
        /// RjctdMod (Rejected Modification) of type PaymentModificationRejection1Code 
        /// </summary>
        [XmlElementAttribute("AssgnmtCxlConf", typeof(bool), Order=0)]
        [XmlElementAttribute("Conf", typeof(InvestigationExecutionConfirmation1Code), Order=0)]
        [XmlElementAttribute("DplctOf", typeof(Case), Order=0)]
        [XmlElementAttribute("RjctdCxl", typeof(RejectedCancellationJustification), Order=0)]
        [XmlElementAttribute("RjctdMod", typeof(PaymentModificationRejection1Code), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Enumeration <b>InvestigationExecutionConfirmation1Code</b> (Investigation Execution Confirmation 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public enum InvestigationExecutionConfirmation1Code
    {
        
        /// <summary>
        /// <b>CNCL - Cancelled By Client</b>.
        /// </summary>
        CNCL,
        
        /// <summary>
        /// <b>MODI - Request To Modify</b>.
        /// </summary>
        MODI,
        
        /// <summary>
        /// <b>ACDA - Accepted Debit Authorisation</b>.
        /// </summary>
        ACDA,
        
        /// <summary>
        /// <b>IPAY - Payment Initiated</b>.
        /// </summary>
        IPAY,
        
        /// <summary>
        /// <b>ICOV - Cover Initiated</b>.
        /// </summary>
        ICOV,
        
        /// <summary>
        /// <b>MCOV - Cover Modified</b>.
        /// </summary>
        MCOV,
        
        /// <summary>
        /// <b>IPYI - Payment Instruction Initiated</b>.
        /// </summary>
        IPYI,
        
        /// <summary>
        /// <b>INFO - Information / For Information Only</b>.
        /// </summary>
        INFO,
        
        /// <summary>
        /// <b>CONF - Confirmation Of Payment</b>.
        /// </summary>
        CONF,
        
        /// <summary>
        /// <b>CWFW - Cancellation Will Follow</b>.
        /// </summary>
        CWFW,
    }
    
    /// <summary>
    /// Class <b>Case</b> (Case).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public class Case
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Cretr</b> (Creator) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Cretr;
        
        /// <summary>
        /// Element <b>ReopCaseIndctn</b> (Reopen Case Indication) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool ReopCaseIndctn;
        
        /// <summary>
        /// Element <b>ReopCaseIndctnSpecified</b> (Reopen Case Indication Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReopCaseIndctnSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>PaymentModificationRejection1Code</b> (Payment Modification Rejection 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.029.001.01")]
    public enum PaymentModificationRejection1Code
    {
        
        /// <summary>
        /// <b>UM01 - Unable To Modify Related Reference</b>.
        /// </summary>
        UM01,
        
        /// <summary>
        /// <b>UM02 - Unable To Modify Bank Operation Code</b>.
        /// </summary>
        UM02,
        
        /// <summary>
        /// <b>UM03 - Unable To Modify Instruction Code</b>.
        /// </summary>
        UM03,
        
        /// <summary>
        /// <b>UM04 - Unable To Modify Requested Execution Date</b>.
        /// </summary>
        UM04,
        
        /// <summary>
        /// <b>UM05 - Unable To Modify Value Date</b>.
        /// </summary>
        UM05,
        
        /// <summary>
        /// <b>UM06 - Unable To Modify Interbank Settlement Account</b>.
        /// </summary>
        UM06,
        
        /// <summary>
        /// <b>UM07 - Unable To Modify Debtor</b>.
        /// </summary>
        UM07,
        
        /// <summary>
        /// <b>UM08 - Unable To Modify Debtor Account</b>.
        /// </summary>
        UM08,
        
        /// <summary>
        /// <b>UM09 - Unable To Modify Receiver Correspondent</b>.
        /// </summary>
        UM09,
        
        /// <summary>
        /// <b>UM10 - Unable To Modify Third Reimbursement Institution</b>.
        /// </summary>
        UM10,
        
        /// <summary>
        /// <b>UM11 - Unable To Modify Payment Scheme</b>.
        /// </summary>
        UM11,
        
        /// <summary>
        /// <b>UM12 - Unable To Modify Accountof Beneficiary Institution</b>.
        /// </summary>
        UM12,
        
        /// <summary>
        /// <b>UM13 - Unable To Modify Creditor</b>.
        /// </summary>
        UM13,
        
        /// <summary>
        /// <b>UM14 - Unable To Modify Creditor Account</b>.
        /// </summary>
        UM14,
        
        /// <summary>
        /// <b>UM15 - Unable To Modify Remittance Information</b>.
        /// </summary>
        UM15,
        
        /// <summary>
        /// <b>UM16 - Unable To Modify Payment Purpose</b>.
        /// </summary>
        UM16,
        
        /// <summary>
        /// <b>UM17 - Unable To Modify Details Of Charges</b>.
        /// </summary>
        UM17,
        
        /// <summary>
        /// <b>UM18 - Unable To Modify Sender To Receiver Information</b>.
        /// </summary>
        UM18,
        
        /// <summary>
        /// <b>UM19 - Unable To Modify Instruction For Final Agent</b>.
        /// </summary>
        UM19,
        
        /// <summary>
        /// <b>UM20 - Instruction Cancelled Submit New Instruction</b>.
        /// </summary>
        UM20,
        
        /// <summary>
        /// <b>UM21 - Unable To Modify Submit Cancellation</b>.
        /// </summary>
        UM21,
    }
}
