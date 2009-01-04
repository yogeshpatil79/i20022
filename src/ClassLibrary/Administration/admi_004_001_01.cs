
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



namespace i20022.admi00400101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id admi.004.001.01 name SystemEventNotificationV01 from Administration business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:admi.004.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:admi.004.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>admi00400101</b> (admi 00400101) of type admi00400101.
        /// </summary>
        [XmlElementAttribute("admi.004.001.01", Order=0)]
        public admi00400101 admi00400101;
    }
    
    /// <summary>
    /// Class <b>admi00400101</b> (admi 00400101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="admi.004.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:admi.004.001.01")]
    public class admi00400101
    {
        
        /// <summary>
        /// Element <b>EvtInf</b> (Event Information) of type Event1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Event1 EvtInf;
    }
    
    /// <summary>
    /// Class <b>Event1</b> (Event 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:admi.004.001.01")]
    public class Event1
    {
        
        /// <summary>
        /// Element <b>EvtCd</b> (Event Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string EvtCd;
        
        /// <summary>
        /// Element <b>EvtParam</b> (Event Parameter) of type array of string.
        /// </summary>
        [XmlElementAttribute("EvtParam", Order=1)]
        public string[] EvtParam;
        
        /// <summary>
        /// Element <b>EvtDesc</b> (Event Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string EvtDesc;
        
        /// <summary>
        /// Element <b>EvtTm</b> (Event Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime EvtTm;
        
        /// <summary>
        /// Element <b>EvtTmSpecified</b> (Event Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EvtTmSpecified;
    }
}
