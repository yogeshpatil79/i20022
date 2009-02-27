
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



namespace i20022.sese01000101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id sese.010.001.01 name TransferCancellationStatusReportV01 from Securities Settlement business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>sese01000101</b> (sese 01000101) of type sese01000101.
        /// </summary>
        [XmlElementAttribute("sese.010.001.01", Order=0)]
        public sese01000101 sese01000101;
    }
    
    /// <summary>
    /// Class <b>sese01000101</b> (sese 01000101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="sese.010.001.01", Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public class sese01000101
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
        /// Element <b>StsRpt</b> (Status Report) of type CancellationStatusAndReason.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CancellationStatusAndReason StsRpt;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference2</b> (Additional Reference 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
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
    /// Class <b>TransferCancellationCompleteReason1</b> (Transfer Cancellation Complete Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public class TransferCancellationCompleteReason1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type CancellationCompleteStatusReason1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CancellationCompleteStatusReason1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>CancellationCompleteStatusReason1Code</b> (Cancellation Complete Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public enum CancellationCompleteStatusReason1Code
    {
        
        /// <summary>
        /// <b>CANI - Cancelled By Yourself</b>.
        /// </summary>
        CANI,
        
        /// <summary>
        /// <b>CANS - Cancelled By System</b>.
        /// </summary>
        CANS,
        
        /// <summary>
        /// <b>CSUB - Cancelled By Agent</b>.
        /// </summary>
        CSUB,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>TransferCancellationCompleteStatusChoice</b> (Transfer Cancellation Complete Status Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public class TransferCancellationCompleteStatusChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type TransferCancellationCompleteReason1 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(TransferCancellationCompleteReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
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
    /// Class <b>TransferCancellationRejectionReason1</b> (Transfer Cancellation Rejection Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public class TransferCancellationRejectionReason1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type CancellationRejectedReason1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CancellationRejectedReason1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>CancellationRejectedReason1Code</b> (Cancellation Rejected Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public enum CancellationRejectedReason1Code
    {
        
        /// <summary>
        /// <b>CUTO - Cut Off Time</b>.
        /// </summary>
        CUTO,
        
        /// <summary>
        /// <b>COSE - Already Executed</b>.
        /// </summary>
        COSE,
    }
    
    /// <summary>
    /// Class <b>TransferCancellationRejectedStatus1Choice</b> (Transfer Cancellation Rejected Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public class TransferCancellationRejectedStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type TransferCancellationRejectionReason1 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(TransferCancellationRejectionReason1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>TransferCancellationStatus</b> (Transfer Cancellation Status).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public class TransferCancellationStatus
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type CancellationStatus1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CancellationStatus1Code Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>CancellationStatus1Code</b> (Cancellation Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public enum CancellationStatus1Code
    {
        
        /// <summary>
        /// <b>STNP - Sent To Next Party</b>.
        /// </summary>
        STNP,
        
        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
        
        /// <summary>
        /// <b>CANP - Pending</b>.
        /// </summary>
        CANP,
    }
    
    /// <summary>
    /// Class <b>CancellationStatusAndReason</b> (Cancellation Status And Reason).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01")]
    public class CancellationStatusAndReason
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cmplt (Complete) of type TransferCancellationCompleteStatusChoice 
        /// Rjctd (Rejected) of type TransferCancellationRejectedStatus1Choice 
        /// Sts (Status) of type TransferCancellationStatus 
        /// </summary>
        [XmlElementAttribute("Cmplt", typeof(TransferCancellationCompleteStatusChoice), Order=0)]
        [XmlElementAttribute("Rjctd", typeof(TransferCancellationRejectedStatus1Choice), Order=0)]
        [XmlElementAttribute("Sts", typeof(TransferCancellationStatus), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification1Choice StsInitr;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.010.001.01", IncludeInSchema=false)]
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
