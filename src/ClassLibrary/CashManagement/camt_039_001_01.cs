
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



namespace i20022.camt03900101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.039.001.01 name CaseStatusReport from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>camt03900101</b> (camt 03900101) of type camt03900101.
        /// </summary>
        [XmlElementAttribute("camt.039.001.01", Order=0)]
        public camt03900101 camt03900101;
    }
    
    /// <summary>
    /// Class <b>camt03900101</b> (camt 03900101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="camt.039.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01")]
    public class camt03900101
    {
        
        /// <summary>
        /// Element <b>Hdr</b> (Header) of type ReportHeader.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ReportHeader Hdr;
        
        /// <summary>
        /// Element <b>Case</b> (Case) of type Case.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Case Case;
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type CaseStatus.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CaseStatus Sts;
        
        /// <summary>
        /// Element <b>NewAssgnmt</b> (New Assignment) of type CaseAssignment.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CaseAssignment NewAssgnmt;
    }
    
    /// <summary>
    /// Class <b>ReportHeader</b> (Report Header).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01")]
    public class ReportHeader
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Fr</b> (From) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Fr;
        
        /// <summary>
        /// Element <b>To</b> (To) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string To;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>CaseAssignment</b> (Case Assignment).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01")]
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
    /// Class <b>CaseStatus</b> (Case Status).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01")]
    public class CaseStatus
    {
        
        /// <summary>
        /// Element <b>DtTm</b> (Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public System.DateTime DtTm;
        
        /// <summary>
        /// Element <b>CaseSts</b> (Case Status) of type CaseStatus1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CaseStatus1Code CaseSts;
        
        /// <summary>
        /// Element <b>InvstgtnSts</b> (Investigation Status) of type InvestigationExecutionConfirmation1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public InvestigationExecutionConfirmation1Code InvstgtnSts;
        
        /// <summary>
        /// Element <b>InvstgtnStsSpecified</b> (Investigation Status Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvstgtnStsSpecified;
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Rsn;
    }
    
    /// <summary>
    /// Enumeration <b>CaseStatus1Code</b> (Case Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01")]
    public enum CaseStatus1Code
    {
        
        /// <summary>
        /// <b>CLOSE - Closed</b>.
        /// </summary>
        CLOSE,
        
        /// <summary>
        /// <b>ASGN - Assigned</b>.
        /// </summary>
        ASGN,
        
        /// <summary>
        /// <b>INVE - Under Investigation</b>.
        /// </summary>
        INVE,
        
        /// <summary>
        /// <b>UKNW - Unknown Case</b>.
        /// </summary>
        UKNW,
    }
    
    /// <summary>
    /// Enumeration <b>InvestigationExecutionConfirmation1Code</b> (Investigation Execution Confirmation 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.039.001.01")]
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
}
