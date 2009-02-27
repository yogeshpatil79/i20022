
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



namespace i20022.admi00200101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id admi.002.001.01 name MessageRejectV01 from Administration business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:admi.002.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:admi.002.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>admi00200101</b> (admi 00200101) of type admi00200101.
        /// </summary>
        [XmlElementAttribute("admi.002.001.01", Order=0)]
        public admi00200101 admi00200101;
    }
    
    /// <summary>
    /// Class <b>admi00200101</b> (admi 00200101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="admi.002.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:admi.002.001.01")]
    public class admi00200101
    {
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type MessageReference.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageReference RltdRef;
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type RejectionReason2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public RejectionReason2 Rsn;
    }
    
    /// <summary>
    /// Class <b>MessageReference</b> (Message Reference).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:admi.002.001.01")]
    public class MessageReference
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
    }
    
    /// <summary>
    /// Class <b>RejectionReason2</b> (Rejection Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:admi.002.001.01")]
    public class RejectionReason2
    {
        
        /// <summary>
        /// Element <b>RjctgPtyRsn</b> (Rejecting Party Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string RjctgPtyRsn;
        
        /// <summary>
        /// Element <b>RjctnDtTm</b> (Rejection Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime RjctnDtTm;
        
        /// <summary>
        /// Element <b>RjctnDtTmSpecified</b> (Rejection Date Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RjctnDtTmSpecified;
        
        /// <summary>
        /// Element <b>ErrLctn</b> (Error Location) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string ErrLctn;
        
        /// <summary>
        /// Element <b>RsnDesc</b> (Reason Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string RsnDesc;
        
        /// <summary>
        /// Element <b>AddtlData</b> (Additional Data) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string AddtlData;
    }
}
