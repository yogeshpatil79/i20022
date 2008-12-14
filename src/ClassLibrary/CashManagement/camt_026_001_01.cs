
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


namespace i20022.camt02600101
{


    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.026.001.01 name UnableToApply from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>camt02600101</b> (0260 01 01) of type camt02600101.
        /// </summary>
        [XmlElementAttribute( "camt.026.001.01", Order = 0 )]
        public camt02600101 camt02600101;
    }

    /// <summary>
    /// Class <b>camt02600101</b> (0260 01 01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( TypeName = "camt.026.001.01", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    public class camt02600101
    {

        /// <summary>
        /// Element <b>Assgnmt</b> (Assignment) of type CaseAssignment.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CaseAssignment Assgnmt;

        /// <summary>
        /// Element <b>Case</b> (Case) of type Case.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public Case Case;

        /// <summary>
        /// Element <b>Undrlyg</b> (Underlying) of type PaymentInstructionExtract.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PaymentInstructionExtract Undrlyg;

        /// <summary>
        /// Element <b>Justfn</b> (Justfn) of type UnableToApplyJustificationChoice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public UnableToApplyJustificationChoice Justfn;
    }

    /// <summary>
    /// Class <b>CaseAssignment</b> (Case Assignment).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    public class CaseAssignment
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Assgnr</b> (Assigner) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Assgnr;

        /// <summary>
        /// Element <b>Assgne</b> (Assignee) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Assgne;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public System.DateTime CreDtTm;
    }

    /// <summary>
    /// Class <b>MissingOrIncorrectInformation</b> (Missing Or Incorrect Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    public class MissingOrIncorrectInformation
    {

        /// <summary>
        /// Element <b>MssngInf</b> (Missing Information) of type array of UnableToApplyMissingInfo1Code.
        /// </summary>
        [XmlElementAttribute( "MssngInf", Order = 0 )]
        public UnableToApplyMissingInfo1Code[] MssngInf;

        /// <summary>
        /// Element <b>IncrrctInf</b> (Incorrect Information) of type array of UnableToApplyIncorrectInfo1Code.
        /// </summary>
        [XmlElementAttribute( "IncrrctInf", Order = 1 )]
        public UnableToApplyIncorrectInfo1Code[] IncrrctInf;
    }

    /// <summary>
    /// Enumeration <b>UnableToApplyMissingInfo1Code</b> (Unable To Apply Missing Info 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    public enum UnableToApplyMissingInfo1Code
    {

        /// <summary>
        /// <b>MS01 - Missing Remittance Information</b>.
        /// </summary>
        MS01,

        /// <summary>
        /// <b>MS02 - Not Specified Reason Customer Generated</b>.
        /// </summary>
        MS02,

        /// <summary>
        /// <b>MS03 - Not Specified Reason Agent Generated</b>.
        /// </summary>
        MS03,

        /// <summary>
        /// <b>MS04 - Missing Debtor Account</b>.
        /// </summary>
        MS04,

        /// <summary>
        /// <b>MS05 - Missing First Agent</b>.
        /// </summary>
        MS05,

        /// <summary>
        /// <b>MS06 - Missing Amount</b>.
        /// </summary>
        MS06,

        /// <summary>
        /// <b>MS07 - Missing Nostro Vostro Account</b>.
        /// </summary>
        MS07,

        /// <summary>
        /// <b>MS08 - Missing Intermediary</b>.
        /// </summary>
        MS08,

        /// <summary>
        /// <b>MS09 - Missing Reimbursement Agent 1</b>.
        /// </summary>
        MS09,

        /// <summary>
        /// <b>MS10 - Missing Reimbursement Agent 2</b>.
        /// </summary>
        MS10,

        /// <summary>
        /// <b>MS11 - Missing Reimbursement Agent</b>.
        /// </summary>
        MS11,

        /// <summary>
        /// <b>MS12 - Missing Creditor</b>.
        /// </summary>
        MS12,

        /// <summary>
        /// <b>MS13 - Missing Creditor Account</b>.
        /// </summary>
        MS13,

        /// <summary>
        /// <b>MS14 - Missing Instruction</b>.
        /// </summary>
        MS14,
    }

    /// <summary>
    /// Enumeration <b>UnableToApplyIncorrectInfo1Code</b> (Unable To Apply Incorrect Info 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    public enum UnableToApplyIncorrectInfo1Code
    {

        /// <summary>
        /// <b>IN01 - Incorrect Related Reference</b>.
        /// </summary>
        IN01,

        /// <summary>
        /// <b>IN02 - Incorrect Bank Operation Code</b>.
        /// </summary>
        IN02,

        /// <summary>
        /// <b>IN03 - Incorrect Instruction Code</b>.
        /// </summary>
        IN03,

        /// <summary>
        /// <b>IN04 - Incorrect Requested Execution Date</b>.
        /// </summary>
        IN04,

        /// <summary>
        /// <b>IN05 - Incorrect Value Date</b>.
        /// </summary>
        IN05,

        /// <summary>
        /// <b>IN06 - Incorrect Interbank Settled Amount</b>.
        /// </summary>
        IN06,

        /// <summary>
        /// <b>IN07 - Incorrect Debtor</b>.
        /// </summary>
        IN07,

        /// <summary>
        /// <b>IN08 - Incorrect Debtor Account</b>.
        /// </summary>
        IN08,

        /// <summary>
        /// <b>IN09 - Incorrect Receiver Correspondent</b>.
        /// </summary>
        IN09,

        /// <summary>
        /// <b>IN10 - Incorrect Third Reimbursement Institution</b>.
        /// </summary>
        IN10,

        /// <summary>
        /// <b>IN11 - Incorrect Payment Scheme</b>.
        /// </summary>
        IN11,

        /// <summary>
        /// <b>IN12 - Incorrect Account Of Beneficiary Institution</b>.
        /// </summary>
        IN12,

        /// <summary>
        /// <b>IN13 - Incorrect Creditor</b>.
        /// </summary>
        IN13,

        /// <summary>
        /// <b>IN14 - Incorrect Creditor Account</b>.
        /// </summary>
        IN14,

        /// <summary>
        /// <b>IN15 - Incorrect Remittance Information</b>.
        /// </summary>
        IN15,

        /// <summary>
        /// <b>IN16 - Incorrect Payment Purpose</b>.
        /// </summary>
        IN16,

        /// <summary>
        /// <b>IN17 - Incorrect Details Of Charges</b>.
        /// </summary>
        IN17,

        /// <summary>
        /// <b>IN18 - Incorrect Sender To Receiver Information</b>.
        /// </summary>
        IN18,

        /// <summary>
        /// <b>IN19 - Incorrect Instruction For Final Agent</b>.
        /// </summary>
        IN19,

        /// <summary>
        /// <b>MM20 - Mismatch Creditor Name Account</b>.
        /// </summary>
        MM20,

        /// <summary>
        /// <b>MM21 - Mismatch Debtor Name Account</b>.
        /// </summary>
        MM21,

        /// <summary>
        /// <b>MM22 - Mismatch Final Agent Name Account</b>.
        /// </summary>
        MM22,
    }

    /// <summary>
    /// Class <b>UnableToApplyJustificationChoice</b> (Unable To Apply Justification Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    public class UnableToApplyJustificationChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  AnyInf of type bool 
        ///  MssngOrIncrrctInf of type MissingOrIncorrectInformation 
        /// </summary>
        [XmlElementAttribute( "AnyInf", typeof( bool ), Order = 0 )]
        [XmlElementAttribute( "MssngOrIncrrctInf", typeof( MissingOrIncorrectInformation ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
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
    /// Class <b>PaymentInstructionExtract</b> (Payment Instruction Extract).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    public class PaymentInstructionExtract
    {

        /// <summary>
        /// Element <b>AssgnrInstrId</b> (Assigner Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string AssgnrInstrId;

        /// <summary>
        /// Element <b>AssgneInstrId</b> (Assignee Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string AssgneInstrId;

        /// <summary>
        /// Element <b>CcyAmt</b> (Currency Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CurrencyAndAmount CcyAmt;

        /// <summary>
        /// Element <b>ValDt</b> (Value Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public System.DateTime ValDt;

        /// <summary>
        /// Element <b>ValDtSpecified</b> (Value Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ValDtSpecified;
    }

    /// <summary>
    /// Class <b>Case</b> (Case).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.026.001.01" )]
    public class Case
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Cretr</b> (Cretr) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Cretr;

        /// <summary>
        /// Element <b>ReopCaseIndctn</b> (Reopen Case Indication) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool ReopCaseIndctn;

        /// <summary>
        /// Element <b>ReopCaseIndctnSpecified</b> (Reopen Case Indication Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReopCaseIndctnSpecified;
    }
}
