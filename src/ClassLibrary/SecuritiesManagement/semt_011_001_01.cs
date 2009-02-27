
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



namespace i20022.semt01100101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id semt.011.001.01 name RegulatoryTransactionReportCancellationStatusV01 from Securities Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>RgltryTxRptCxlStsV01</b> (Regulatory Transaction Report Cancellation Status V01) of type RegulatoryTransactionReportCancellationStatusV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RegulatoryTransactionReportCancellationStatusV01 RgltryTxRptCxlStsV01;
    }
    
    /// <summary>
    /// Class <b>RegulatoryTransactionReportCancellationStatusV01</b> (Regulatory Transaction Report Cancellation Status V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
    public class RegulatoryTransactionReportCancellationStatusV01
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification8 Id;
        
        /// <summary>
        /// Element <b>RptgInstn</b> (Reporting Institution) of type PartyIdentification23Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification23Choice RptgInstn;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// IndvTxCxlSts (Individual Transaction Cancellation Status) of type TradeTransactionStatusAndReason2 
        /// RptCxlSts (Report Cancellation Status) of type ReportStatusAndReason2 
        /// </summary>
        [XmlElementAttribute("IndvTxCxlSts", typeof(TradeTransactionStatusAndReason2), Order=2)]
        [XmlElementAttribute("RptCxlSts", typeof(ReportStatusAndReason2), Order=2)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
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
    /// Class <b>TradeTransactionStatusAndReason2</b> (Trade Transaction Status And Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
    public class TradeTransactionStatusAndReason2
    {
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string RltdRef;
        
        /// <summary>
        /// Element <b>TradRef</b> (Trade Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string TradRef;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// Rjctd (Rejected) of type RejectedCancellationStatusReason1Choice 
        /// Sts (Status) of type Status2Code 
        /// </summary>
        [XmlElementAttribute("Rjctd", typeof(RejectedCancellationStatusReason1Choice), Order=2)]
        [XmlElementAttribute("Sts", typeof(Status2Code), Order=2)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>RejectedCancellationStatusReason1Choice</b> (Rejected Cancellation Status Reason 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
    public class RejectedCancellationStatusReason1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type RejectedCancellationStatusReason1Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(RejectedCancellationStatusReason1Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
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
    /// Enumeration <b>RejectedCancellationStatusReason1Code</b> (Rejected Cancellation Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
    public enum RejectedCancellationStatusReason1Code
    {
        
        /// <summary>
        /// <b>REFE - Invalid Or Unrecognised Reference</b>.
        /// </summary>
        REFE,
        
        /// <summary>
        /// <b>NRGM - No Cancellation Match</b>.
        /// </summary>
        NRGM,
        
        /// <summary>
        /// <b>NSLA - Not Compliant With SLA</b>.
        /// </summary>
        NSLA,
    }
    
    /// <summary>
    /// Enumeration <b>Status2Code</b> (Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
    public enum Status2Code
    {
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
        
        /// <summary>
        /// <b>PDNG - Pending</b>.
        /// </summary>
        PDNG,
    }
    
    /// <summary>
    /// Class <b>ReportStatusAndReason2</b> (Report Status And Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
    public class ReportStatusAndReason2
    {
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string RltdRef;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// Rjctd (Rejected) of type RejectedCancellationStatusReason1Choice 
        /// Sts (Status) of type Status2Code 
        /// </summary>
        [XmlElementAttribute("Rjctd", typeof(RejectedCancellationStatusReason1Choice), Order=1)]
        [XmlElementAttribute("Sts", typeof(Status2Code), Order=1)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification23Choice</b> (Party Identification 23 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.011.001.01")]
    public class PartyIdentification23Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
}
