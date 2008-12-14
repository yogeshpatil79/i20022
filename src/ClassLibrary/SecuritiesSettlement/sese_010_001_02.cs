
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
using System.Diagnostics;
using System.Xml.Serialization;



namespace i20022.sese01000102
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id sese.010.001.02 name TransferCancellationStatusReportV02 from Securities Settlement business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>TrfCxlStsRptV02</b> (Transfer Cancellation Status Report V02) of type TransferCancellationStatusReportV02.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public TransferCancellationStatusReportV02 TrfCxlStsRptV02;
    }

    /// <summary>
    /// Class <b>TransferCancellationStatusReportV02</b> (Transfer Cancellation Status Report V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public class TransferCancellationStatusReportV02
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MsgId;

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( "OthrRef", typeof( AdditionalReference3 ), Order = 1 )]
        [XmlElementAttribute( "RltdRef", typeof( AdditionalReference3 ), Order = 1 )]
        [XmlChoiceIdentifierAttribute( "ItemsElementName" )]
        public AdditionalReference3[] Items;

        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute( "ItemsElementName", Order = 2 )]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;

        /// <summary>
        /// Element <b>StsRpt</b> (Status Report) of type CancellationStatusAndReason2.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public CancellationStatusAndReason2 StsRpt;

        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute( "Xtnsn", Order = 4 )]
        public Extension1[] Xtnsn;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
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
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public class Extension1
    {

        /// <summary>
        /// Element <b>PlcAndNm</b> (Place And Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string PlcAndNm;

        /// <summary>
        /// Element <b>Txt</b> (Txt) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Txt;
    }

    /// <summary>
    /// Class <b>TransferCancellationPendingStatus1</b> (Transfer Cancellation Pending Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public class TransferCancellationPendingStatus1
    {

        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Rsn;
    }

    /// <summary>
    /// Class <b>TransferCancellationCompleteStatusAndReason1</b> (Transfer Cancellation Complete Status And Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public class TransferCancellationCompleteStatusAndReason1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  Rsn of type CancelledStatusReason1Code 
        ///  XtndedRsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( CancelledStatusReason1Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedRsn", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
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
    /// Enumeration <b>CancelledStatusReason1Code</b> (Cancelled Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public enum CancelledStatusReason1Code
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
    }

    /// <summary>
    /// Class <b>TransferCancellationRejectedStatus1</b> (Transfer Cancellation Rejected Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public class TransferCancellationRejectedStatus1
    {

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        ///  DataSrcSchme of type GenericIdentification1 
        ///  Rsn of type CancellationRejectedReason1Code 
        ///  XtndedRsn of type string 
        /// </summary>
        [XmlElementAttribute( "DataSrcSchme", typeof( GenericIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "Rsn", typeof( CancellationRejectedReason1Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedRsn", typeof( string ), Order = 0 )]
        public object[] Items;
    }

    /// <summary>
    /// Enumeration <b>CancellationRejectedReason1Code</b> (Cancellation Rejected Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
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
    /// Class <b>TransferCancellationStatus2</b> (Transfer Cancellation Status 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public class TransferCancellationStatus2
    {

        /// <summary>
        /// Element <b>Sts</b> (Status) of type CancellationStatus2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CancellationStatus2Code Sts;

        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Rsn;
    }

    /// <summary>
    /// Enumeration <b>CancellationStatus2Code</b> (Cancellation Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public enum CancellationStatus2Code
    {

        /// <summary>
        /// <b>STNP - Sent To Next Party</b>.
        /// </summary>
        STNP,

        /// <summary>
        /// <b>PACK - Accepted</b>.
        /// </summary>
        PACK,
    }

    /// <summary>
    /// Class <b>CancellationStatusAndReason2</b> (Cancellation Status And Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
    public class CancellationStatusAndReason2
    {

        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MstrRef;

        /// <summary>
        /// Element <b>TrfRef</b> (Transfer Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string TrfRef;

        /// <summary>
        /// Element <b>ClntRef</b> (Client Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string ClntRef;

        /// <summary>
        /// Element <b>CxlRef</b> (Cancellation Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string CxlRef;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cmplt of type TransferCancellationCompleteStatusAndReason1 
        ///  Pdg of type TransferCancellationPendingStatus1 
        ///  Rjctd of type TransferCancellationRejectedStatus1 
        ///  Sts of type TransferCancellationStatus2 
        /// </summary>
        [XmlElementAttribute( "Cmplt", typeof( TransferCancellationCompleteStatusAndReason1 ), Order = 4 )]
        [XmlElementAttribute( "Pdg", typeof( TransferCancellationPendingStatus1 ), Order = 4 )]
        [XmlElementAttribute( "Rjctd", typeof( TransferCancellationRejectedStatus1 ), Order = 4 )]
        [XmlElementAttribute( "Sts", typeof( TransferCancellationStatus2 ), Order = 4 )]
        public object Item;

        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public PartyIdentification2Choice StsInitr;
    }

    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
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
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
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
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
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
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
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
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02" )]
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

    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.02", IncludeInSchema = false )]
    public enum ItemsChoiceType
    {

        /// <summary>
        /// <b>OthrRef - ?undefined</b>.
        /// </summary>
        OthrRef,

        /// <summary>
        /// <b>RltdRef - ?undefined</b>.
        /// </summary>
        RltdRef,
    }
}
