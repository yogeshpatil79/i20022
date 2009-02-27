
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



namespace i20022.semt00100101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id semt.001.001.01 name SecuritiesMessageRejectionV01 from Securities Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>semt00100101</b> (semt 00100101) of type semt00100101.
        /// </summary>
        [XmlElementAttribute("semt.001.001.01", Order=0)]
        public semt00100101 semt00100101;
    }
    
    /// <summary>
    /// Class <b>semt00100101</b> (semt 00100101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="semt.001.001.01", Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
    public class semt00100101
    {
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type AdditionalReference2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AdditionalReference2 RltdRef;
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type RejectionReason1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public RejectionReason1 Rsn;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference2</b> (Additional Reference 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
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
    /// Class <b>RejectionReason1</b> (Rejection Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
    public class RejectionReason1
    {
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type MessageRejectedReason1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageRejectedReason1Code Rsn;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type AdditionalReference2.
        /// </summary>
        [XmlElementAttribute("LkdMsgOthrRef", typeof(AdditionalReference2), Order=2)]
        [XmlElementAttribute("LkdMsgPrvsRef", typeof(AdditionalReference2), Order=2)]
        [XmlElementAttribute("LkdMsgRltdRef", typeof(AdditionalReference2), Order=2)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public AdditionalReference2 Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>MessageRejectedReason1Code</b> (Message Rejected Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
    public enum MessageRejectedReason1Code
    {
        
        /// <summary>
        /// <b>REFE - Invalid Or Unrecognised Reference</b>.
        /// </summary>
        REFE,
        
        /// <summary>
        /// <b>NALO - Not Allowed Request</b>.
        /// </summary>
        NALO,
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>LkdMsgOthrRef - Linked Message Other Reference</b>.
        /// </summary>
        LkdMsgOthrRef,
        
        /// <summary>
        /// <b>LkdMsgPrvsRef - Linked Message Previous Reference</b>.
        /// </summary>
        LkdMsgPrvsRef,
        
        /// <summary>
        /// <b>LkdMsgRltdRef - Linked Message Related Reference</b>.
        /// </summary>
        LkdMsgRltdRef,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.001.001.01")]
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
}
