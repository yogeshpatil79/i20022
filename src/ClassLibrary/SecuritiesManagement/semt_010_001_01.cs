
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



namespace i20022.semt01000101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id semt.010.001.01 name RegulatoryTransactionReportStatusV01 from Securities Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>RgltryTxRptStsV01</b> (Regulatory Transaction Report Status V01) of type RegulatoryTransactionReportStatusV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RegulatoryTransactionReportStatusV01 RgltryTxRptStsV01;
    }
    
    /// <summary>
    /// Class <b>RegulatoryTransactionReportStatusV01</b> (Regulatory Transaction Report Status V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
    public class RegulatoryTransactionReportStatusV01
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
        /// IndvTxSts (Individual Transaction Status) of type TradeTransactionStatusAndReason1 
        /// RptSts (Report Status) of type ReportStatusAndReason1 
        /// </summary>
        [XmlElementAttribute("IndvTxSts", typeof(TradeTransactionStatusAndReason1), Order=2)]
        [XmlElementAttribute("RptSts", typeof(ReportStatusAndReason1), Order=2)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
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
    /// Class <b>TradeTransactionStatusAndReason1</b> (Trade Transaction Status And Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
    public class TradeTransactionStatusAndReason1
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
        /// Rjctd (Rejected) of type RejectedStatusReason9Choice 
        /// Sts (Status) of type Status2Code 
        /// </summary>
        [XmlElementAttribute("Rjctd", typeof(RejectedStatusReason9Choice), Order=2)]
        [XmlElementAttribute("Sts", typeof(Status2Code), Order=2)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>RejectedStatusReason9Choice</b> (Rejected Status Reason 9Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
    public class RejectedStatusReason9Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type RejectedStatusReason9Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(RejectedStatusReason9Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
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
    /// Enumeration <b>RejectedStatusReason9Code</b> (Rejected Status Reason 9Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
    public enum RejectedStatusReason9Code
    {
        
        /// <summary>
        /// <b>DSEC - Financial Instrument Identification</b>.
        /// </summary>
        DSEC,
        
        /// <summary>
        /// <b>IDNA - Financial Instrument Identification And Name</b>.
        /// </summary>
        IDNA,
        
        /// <summary>
        /// <b>ORRF - Duplicate Order Reference</b>.
        /// </summary>
        ORRF,
        
        /// <summary>
        /// <b>NSLA - Not Compliant With SLA</b>.
        /// </summary>
        NSLA,
        
        /// <summary>
        /// <b>DQUA - Financial Instrument Quantity</b>.
        /// </summary>
        DQUA,
        
        /// <summary>
        /// <b>NCRR - Settlement Amount Currency</b>.
        /// </summary>
        NCRR,
        
        /// <summary>
        /// <b>PLCE - Place Of Trade</b>.
        /// </summary>
        PLCE,
        
        /// <summary>
        /// <b>DTRD - Trade Date</b>.
        /// </summary>
        DTRD,
    }
    
    /// <summary>
    /// Enumeration <b>Status2Code</b> (Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
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
    /// Class <b>ReportStatusAndReason1</b> (Report Status And Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
    public class ReportStatusAndReason1
    {
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string RltdRef;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// Rjctd (Rejected) of type RejectedStatusReason9Choice 
        /// Sts (Status) of type Status2Code 
        /// </summary>
        [XmlElementAttribute("Rjctd", typeof(RejectedStatusReason9Choice), Order=1)]
        [XmlElementAttribute("Sts", typeof(Status2Code), Order=1)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification23Choice</b> (Party Identification 23 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.010.001.01")]
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
