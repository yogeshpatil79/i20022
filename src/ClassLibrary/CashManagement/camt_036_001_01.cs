
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



namespace i20022.camt03600101
{

    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.036.001.01 name DebitAuthorisationResponse from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>camt03600101</b> (0360 01 01) of type camt03600101.
        /// </summary>
        [XmlElementAttribute( "camt.036.001.01", Order = 0 )]
        public camt03600101 camt03600101;
    }

    /// <summary>
    /// Class <b>camt03600101</b> (0360 01 01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( TypeName = "camt.036.001.01", Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.01" )]
    public class camt03600101
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
        /// Element <b>Conf</b> (Confirmation) of type DebitAuthorisationConfirmation.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DebitAuthorisationConfirmation Conf;
    }

    /// <summary>
    /// Class <b>CaseAssignment</b> (Case Assignment).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.01" )]
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
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.01" )]
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
    /// Class <b>DebitAuthorisationConfirmation</b> (Debit Authorisation Confirmation).
    /// </summary>

    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.01" )]
    public class DebitAuthorisationConfirmation
    {

        /// <summary>
        /// Element <b>DbtAuthstn</b> (Debit Authorisation) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public bool DbtAuthstn;

        /// <summary>
        /// Element <b>AmtToDbt</b> (Amount To Debit) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyAndAmount AmtToDbt;

        /// <summary>
        /// Element <b>ValDtToDbt</b> (Value Date To Debit) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 2 )]
        public System.DateTime ValDtToDbt;

        /// <summary>
        /// Element <b>ValDtToDbtSpecified</b> (Value Date To Debit Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ValDtToDbtSpecified;

        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Rsn;
    }

    /// <summary>
    /// Class <b>Case</b> (Case).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.01" )]
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
