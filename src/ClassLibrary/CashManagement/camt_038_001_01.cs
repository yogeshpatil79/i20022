
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



namespace i20022.camt03800101
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.038.001.01 name CaseStatusReportRequest from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.038.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.038.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>camt03800101</b> (0380 01 01) of type camt03800101.
        /// </summary>
        [XmlElementAttribute( "camt.038.001.01", Order = 0 )]
        public camt03800101 camt03800101;
    }

    /// <summary>
    /// Class <b>camt03800101</b> (0380 01 01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( TypeName = "camt.038.001.01", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.038.001.01" )]
    public class camt03800101
    {

        /// <summary>
        /// Element <b>ReqHdr</b> (Request Header) of type ReportHeader.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ReportHeader ReqHdr;

        /// <summary>
        /// Element <b>Case</b> (Case) of type Case.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public Case Case;
    }

    /// <summary>
    /// Class <b>ReportHeader</b> (Report Header).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.038.001.01" )]
    public class ReportHeader
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Fr</b> (From) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Fr;

        /// <summary>
        /// Element <b>To</b> (To) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string To;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public System.DateTime CreDtTm;
    }

    /// <summary>
    /// Class <b>Case</b> (Case).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.038.001.01" )]
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
