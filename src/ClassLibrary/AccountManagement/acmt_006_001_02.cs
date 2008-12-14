
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
using System.Xml.Serialization;


namespace i20022.acmt00600102
{

    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id acmt.006.001.02 name AccountManagementStatusReportV02 from Account Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>AcctMgmtStsRptV02</b> (Account Management Status Report V02) of type AccountManagementStatusReportV02.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountManagementStatusReportV02 AcctMgmtStsRptV02;
    }

    /// <summary>
    /// Class <b>AccountManagementStatusReportV02</b> (Account Management Status Report V02).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class AccountManagementStatusReportV02
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MsgId;

        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( "RltdRef", Order = 1 )]
        public AdditionalReference3[] RltdRef;

        /// <summary>
        /// Element <b>StsRpt</b> (Status Report) of type AccountManagementStatusAndReason1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public AccountManagementStatusAndReason1 StsRpt;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class MessageIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CreDtTm;
    }

    /// <summary>
    /// Class <b>RejectedStatus5</b> (Rejected Status 5).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class RejectedStatus5
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Rsn of type RejectedStatusReason6Code 
        ///  XtndedRsn of type string 
        /// </summary>
        [XmlElementAttribute( "Rsn", typeof( RejectedStatusReason6Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedRsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>RejectedStatusReason6Code</b> (Rejected Status Reason 6Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public enum RejectedStatusReason6Code
    {

        /// <summary>
        /// <b>SAFE - Investment Account</b>.
        /// </summary>
        SAFE,

        /// <summary>
        /// <b>NSLA - Not Compliant With SLA</b>.
        /// </summary>
        NSLA,
    }

    /// <summary>
    /// Class <b>AccountManagementStatusAndReason1</b> (Account Management Status And Reason 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class AccountManagementStatusAndReason1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Rjctd of type RejectedStatus5 
        ///  Sts of type AccountManagementStatus1Code 
        /// </summary>
        [XmlElementAttribute( "Rjctd", typeof( RejectedStatus5 ), Order = 0 )]
        [XmlElementAttribute( "Sts", typeof( AccountManagementStatus1Code ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>AcctApplId</b> (Account Application Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string AcctApplId;
    }

    /// <summary>
    /// Enumeration <b>AccountManagementStatus1Code</b> (Account Management Status 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public enum AccountManagementStatus1Code
    {

        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,

        /// <summary>
        /// <b>ACCP - Accepted</b>.
        /// </summary>
        ACCP,

        /// <summary>
        /// <b>EXEC - Processing Ongoing</b>.
        /// </summary>
        EXEC,

        /// <summary>
        /// <b>STNP - Sent To Next Party</b>.
        /// </summary>
        STNP,
    }

    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class PostalAddress1
    {

        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AddressType2Code AdrTp;

        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdrTpSpecified;

        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute( "AdrLine", Order = 1 )]
        public string[] AdrLine;

        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string StrtNm;

        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string BldgNb;

        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string PstCd;

        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string TwnNm;

        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string CtrySubDvsn;

        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string Ctry;
    }

    /// <summary>
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public enum AddressType2Code
    {

        /// <summary>
        /// <b>ADDR - Postal</b>.
        /// </summary>
        ADDR,

        /// <summary>
        /// <b>PBOX - POBox</b>.
        /// </summary>
        PBOX,

        /// <summary>
        /// <b>HOME - Residential</b>.
        /// </summary>
        HOME,

        /// <summary>
        /// <b>BIZZ - Business</b>.
        /// </summary>
        BIZZ,

        /// <summary>
        /// <b>MLTO - Mail To</b>.
        /// </summary>
        MLTO,

        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
    }

    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class NameAndAddress5
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 Adr;
    }

    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class GenericIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string SchmeNm;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class PartyIdentification2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BICOrBEI of type string 
        ///  NmAndAdr of type NameAndAddress5 
        ///  PrtryId of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute( "BICOrBEI", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress5 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification1 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02" )]
    public class AdditionalReference3
    {

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ref;

        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice RefIssr;

        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string MsgNm;
    }
}
