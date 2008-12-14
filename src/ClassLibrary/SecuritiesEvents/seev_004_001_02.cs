
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



namespace i20022.seev00400102
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.004.001.02 name MeetingInstructionV02 from Securities Events business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>MtgInstr</b> (Meeting Instruction) of type MeetingInstructionV02.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MeetingInstructionV02 MtgInstr;
    }

    /// <summary>
    /// Class <b>MeetingInstructionV02</b> (Meeting Instruction V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class MeetingInstructionV02
    {

        /// <summary>
        /// Element <b>MtgInstrId</b> (Meeting Instruction Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MtgInstrId;

        /// <summary>
        /// Element <b>MtgRef</b> (Meeting Reference) of type MeetingReference3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public MeetingReference3 MtgRef;

        /// <summary>
        /// Element <b>InstgPty</b> (Instructing Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification9Choice InstgPty;

        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public SecurityIdentification3 SctyId;

        /// <summary>
        /// Element <b>Instr</b> (Instruction) of type array of Instruction1.
        /// </summary>
        [XmlElementAttribute( "Instr", Order = 4 )]
        public Instruction1[] Instr;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
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
    /// Class <b>SpecificInstructionRequest1</b> (Specific Instruction Request 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class SpecificInstructionRequest1
    {

        /// <summary>
        /// Element <b>PrtcptnRegn</b> (Participation Registration) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public bool PrtcptnRegn;

        /// <summary>
        /// Element <b>PrtcptnRegnSpecified</b> (Participation Registration Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PrtcptnRegnSpecified;

        /// <summary>
        /// Element <b>BlckgScties</b> (Blocking Securities) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool BlckgScties;

        /// <summary>
        /// Element <b>BlckgSctiesSpecified</b> (Blocking Securities Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BlckgSctiesSpecified;

        /// <summary>
        /// Element <b>SctiesRegn</b> (Securities Registration) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool SctiesRegn;

        /// <summary>
        /// Element <b>SctiesRegnSpecified</b> (Securities Registration Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SctiesRegnSpecified;
    }

    /// <summary>
    /// Class <b>VoteInstructionForMeetingResolution1</b> (Vote Instruction For Meeting Resolution 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class VoteInstructionForMeetingResolution1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Shrhldr of type NameAndAddress9 
        ///  VoteIndctn of type VoteInstructionAtMeeting1Code 
        /// </summary>
        [XmlElementAttribute( "Shrhldr", typeof( NameAndAddress9 ), Order = 0 )]
        [XmlElementAttribute( "VoteIndctn", typeof( VoteInstructionAtMeeting1Code ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>NameAndAddress9</b> (Name And Address 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class NameAndAddress9
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type LongPostalAddress2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public LongPostalAddress2Choice Adr;
    }

    /// <summary>
    /// Class <b>LongPostalAddress2Choice</b> (Long Postal Address 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class LongPostalAddress2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Strd of type PostalAddress1 
        ///  Ustrd of type string 
        /// </summary>
        [XmlElementAttribute( "Strd", typeof( PostalAddress1 ), Order = 0 )]
        [XmlElementAttribute( "Ustrd", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
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
    /// Enumeration <b>VoteInstructionAtMeeting1Code</b> (Vote Instruction At Meeting 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum VoteInstructionAtMeeting1Code
    {

        /// <summary>
        /// <b>CHRM - Chairman</b>.
        /// </summary>
        CHRM,

        /// <summary>
        /// <b>CAGS - Against</b>.
        /// </summary>
        CAGS,

        /// <summary>
        /// <b>CFOR - For</b>.
        /// </summary>
        CFOR,

        /// <summary>
        /// <b>ABST - Abstain</b>.
        /// </summary>
        ABST,

        /// <summary>
        /// <b>WTHH - Withhold</b>.
        /// </summary>
        WTHH,

        /// <summary>
        /// <b>WMGT - With Management</b>.
        /// </summary>
        WMGT,

        /// <summary>
        /// <b>AMGT - Against Management</b>.
        /// </summary>
        AMGT,

        /// <summary>
        /// <b>NOAC - No Action</b>.
        /// </summary>
        NOAC,
    }

    /// <summary>
    /// Class <b>VoteDetails1</b> (Vote Details 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class VoteDetails1
    {

        /// <summary>
        /// Element <b>VoteInstrForAgndRsltn</b> (Vote Instruction For Agnd Resolution) of type Vote1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Vote1Choice VoteInstrForAgndRsltn;

        /// <summary>
        /// Element <b>VoteInstrForMtgRsltn</b> (Vote Instruction For Meeting Resolution) of type VoteInstructionForMeetingResolution1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public VoteInstructionForMeetingResolution1 VoteInstrForMtgRsltn;
    }

    /// <summary>
    /// Class <b>Vote1Choice</b> (Vote 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class Vote1Choice
    {

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        ///  GblVoteInstr of type Vote3 
        ///  VoteInstr of type Vote4 
        /// </summary>
        [XmlElementAttribute( "GblVoteInstr", typeof( Vote3 ), Order = 0 )]
        [XmlElementAttribute( "VoteInstr", typeof( Vote4 ), Order = 0 )]
        public object[] Items;
    }

    /// <summary>
    /// Class <b>Vote3</b> (Vote 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class Vote3
    {

        /// <summary>
        /// Element <b>IssrLabl</b> (Issuer Label) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string IssrLabl;

        /// <summary>
        /// Element <b>VoteOptn</b> (Vote Option) of type VoteInstruction2Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public VoteInstruction2Code VoteOptn;
    }

    /// <summary>
    /// Enumeration <b>VoteInstruction2Code</b> (Vote Instruction 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum VoteInstruction2Code
    {

        /// <summary>
        /// <b>CFOR - For</b>.
        /// </summary>
        CFOR,

        /// <summary>
        /// <b>CAGS - Against</b>.
        /// </summary>
        CAGS,

        /// <summary>
        /// <b>ABST - Abstain</b>.
        /// </summary>
        ABST,

        /// <summary>
        /// <b>WTHH - Withhold</b>.
        /// </summary>
        WTHH,

        /// <summary>
        /// <b>WMGT - With Management</b>.
        /// </summary>
        WMGT,

        /// <summary>
        /// <b>AMGT - Against Management</b>.
        /// </summary>
        AMGT,

        /// <summary>
        /// <b>NOAC - No Action</b>.
        /// </summary>
        NOAC,

        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,
    }

    /// <summary>
    /// Class <b>Vote4</b> (Vote 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class Vote4
    {

        /// <summary>
        /// Element <b>IssrLabl</b> (Issuer Label) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string IssrLabl;

        /// <summary>
        /// Element <b>For</b> (For) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal For;

        /// <summary>
        /// Element <b>ForSpecified</b> (For Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ForSpecified;

        /// <summary>
        /// Element <b>Agnst</b> (Against) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal Agnst;

        /// <summary>
        /// Element <b>AgnstSpecified</b> (Against Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AgnstSpecified;

        /// <summary>
        /// Element <b>Abstn</b> (Abstn) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal Abstn;

        /// <summary>
        /// Element <b>AbstnSpecified</b> (Abstn Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AbstnSpecified;

        /// <summary>
        /// Element <b>Wthhld</b> (Wthhld) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public decimal Wthhld;

        /// <summary>
        /// Element <b>WthhldSpecified</b> (Wthhld Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WthhldSpecified;

        /// <summary>
        /// Element <b>WthMgmt</b> (With Management) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public decimal WthMgmt;

        /// <summary>
        /// Element <b>WthMgmtSpecified</b> (With Management Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WthMgmtSpecified;

        /// <summary>
        /// Element <b>AgnstMgmt</b> (Against Management) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public decimal AgnstMgmt;

        /// <summary>
        /// Element <b>AgnstMgmtSpecified</b> (Against Management Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AgnstMgmtSpecified;

        /// <summary>
        /// Element <b>Dscrtnry</b> (Dscrtnry) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public decimal Dscrtnry;

        /// <summary>
        /// Element <b>DscrtnrySpecified</b> (Dscrtnry Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DscrtnrySpecified;

        /// <summary>
        /// Element <b>NoActn</b> (No Action) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public decimal NoActn;

        /// <summary>
        /// Element <b>NoActnSpecified</b> (No Action Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NoActnSpecified;
    }

    /// <summary>
    /// Class <b>AttendanceCard1</b> (Attendance Card 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class AttendanceCard1
    {

        /// <summary>
        /// Element <b>AttndncCardLbllg</b> (Attendance Card Labelling) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string AttndncCardLbllg;

        /// <summary>
        /// Element <b>DlvryMtd</b> (Delivery Method) of type DeliveryPlace1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public DeliveryPlace1Code DlvryMtd;

        /// <summary>
        /// Element <b>OthrAdr</b> (Other Address) of type NameAndAddress9.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public NameAndAddress9 OthrAdr;
    }

    /// <summary>
    /// Enumeration <b>DeliveryPlace1Code</b> (Delivery Place 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum DeliveryPlace1Code
    {

        /// <summary>
        /// <b>EMPL - Employer</b>.
        /// </summary>
        EMPL,

        /// <summary>
        /// <b>INDI - Individual</b>.
        /// </summary>
        INDI,

        /// <summary>
        /// <b>ENTR - Entrance Of Meeting</b>.
        /// </summary>
        ENTR,

        /// <summary>
        /// <b>OADR - Other Address</b>.
        /// </summary>
        OADR,
    }

    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class GenericIdentification4
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>IdTp</b> (Identification Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IdTp;
    }

    /// <summary>
    /// Class <b>PersonIdentification2</b> (Person Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class PersonIdentification2
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  AlnRegnNb of type string 
        ///  DrvrsLicNb of type string 
        ///  IdntyCardNb of type string 
        ///  MplyrIdNb of type string 
        ///  OthrId of type GenericIdentification4 
        ///  PsptNb of type string 
        ///  SclSctyNb of type string 
        ///  TaxIdNb of type string 
        /// </summary>
        [XmlElementAttribute( "AlnRegnNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DrvrsLicNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IdntyCardNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "MplyrIdNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrId", typeof( GenericIdentification4 ), Order = 0 )]
        [XmlElementAttribute( "PsptNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SclSctyNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "TaxIdNb", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

        /// <summary>
        /// <b>AlnRegnNb - ?undefined</b>.
        /// </summary>
        AlnRegnNb,

        /// <summary>
        /// <b>DrvrsLicNb - ?undefined</b>.
        /// </summary>
        DrvrsLicNb,

        /// <summary>
        /// <b>IdntyCardNb - ?undefined</b>.
        /// </summary>
        IdntyCardNb,

        /// <summary>
        /// <b>MplyrIdNb - ?undefined</b>.
        /// </summary>
        MplyrIdNb,

        /// <summary>
        /// <b>OthrId - ?undefined</b>.
        /// </summary>
        OthrId,

        /// <summary>
        /// <b>PsptNb - ?undefined</b>.
        /// </summary>
        PsptNb,

        /// <summary>
        /// <b>SclSctyNb - ?undefined</b>.
        /// </summary>
        SclSctyNb,

        /// <summary>
        /// <b>TaxIdNb - ?undefined</b>.
        /// </summary>
        TaxIdNb,
    }

    /// <summary>
    /// Class <b>IndividualPerson13</b> (Individual Person 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class IndividualPerson13
    {

        /// <summary>
        /// Element <b>BirthNm</b> (Birth Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BirthNm;

        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string GvnNm;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type PersonIdentification2.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PersonIdentification2 Id;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type LongPostalAddress2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public LongPostalAddress2Choice Adr;

        /// <summary>
        /// Element <b>EmplngPty</b> (Employing Party) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification9Choice EmplngPty;

        /// <summary>
        /// Element <b>AttndncCardDtls</b> (Attendance Card Details) of type AttendanceCard1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public AttendanceCard1 AttndncCardDtls;
    }

    /// <summary>
    /// Class <b>PartyIdentification9Choice</b> (Party Identification 9Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class PartyIdentification9Choice
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
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
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
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
    /// Class <b>Proxy2</b> (Proxy 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class Proxy2
    {

        /// <summary>
        /// Element <b>PrxyTp</b> (Proxy Type) of type ProxyType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ProxyType2Code PrxyTp;

        /// <summary>
        /// Element <b>PrsnDtls</b> (Person Details) of type IndividualPerson13.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public IndividualPerson13 PrsnDtls;

        /// <summary>
        /// Element <b>VoteInstrForAgndRsltn</b> (Vote Instruction For Agnd Resolution) of type Vote1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public Vote1Choice VoteInstrForAgndRsltn;
    }

    /// <summary>
    /// Enumeration <b>ProxyType2Code</b> (Proxy Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum ProxyType2Code
    {

        /// <summary>
        /// <b>CHRM - Chairman</b>.
        /// </summary>
        CHRM,

        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,

        /// <summary>
        /// <b>HLDR - Security Holder</b>.
        /// </summary>
        HLDR,
    }

    /// <summary>
    /// Class <b>GenericIdentification5</b> (Generic Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class GenericIdentification5
    {

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Issr;

        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Inf;

        /// <summary>
        /// Element <b>Nrrtv</b> (Nrrtv) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Nrrtv;
    }

    /// <summary>
    /// Class <b>PartyIdentification3</b> (Party Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class PartyIdentification3
    {

        /// <summary>
        /// Element <b>BICOrBEI</b> (BICOr BEI) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BICOrBEI;
    }

    /// <summary>
    /// Class <b>SafekeepingPlaceAsCodeAndPartyIdentification</b> (Safekeeping Place As Code And Party Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class SafekeepingPlaceAsCodeAndPartyIdentification
    {

        /// <summary>
        /// Element <b>PlcSfkpg</b> (Place Safekeeping) of type SafekeepingPlace1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SafekeepingPlace1Code PlcSfkpg;

        /// <summary>
        /// Element <b>Nrrtv</b> (Nrrtv) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nrrtv;

        /// <summary>
        /// Element <b>Pty</b> (Party) of type PartyIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification3 Pty;
    }

    /// <summary>
    /// Enumeration <b>SafekeepingPlace1Code</b> (Safekeeping Place 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum SafekeepingPlace1Code
    {

        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,

        /// <summary>
        /// <b>ICSD - Shares Held At ICSD</b>.
        /// </summary>
        ICSD,

        /// <summary>
        /// <b>NCSD - Shares Held At NCSD</b>.
        /// </summary>
        NCSD,

        /// <summary>
        /// <b>SHHE - Shares Held Elsewhere</b>.
        /// </summary>
        SHHE,
    }

    /// <summary>
    /// Class <b>SafekeepingPlaceFormatChoice</b> (Safekeeping Place Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class SafekeepingPlaceFormatChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Id of type SafekeepingPlaceAsCodeAndPartyIdentification 
        ///  IdAsCtry of type string 
        ///  IdAsDSS of type GenericIdentification5 
        /// </summary>
        [XmlElementAttribute( "Id", typeof( SafekeepingPlaceAsCodeAndPartyIdentification ), Order = 0 )]
        [XmlElementAttribute( "IdAsCtry", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IdAsDSS", typeof( GenericIdentification5 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
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
    /// Class <b>UnitOrFaceAmountOrCodeChoice</b> (Unit Or Face Amount Or Code Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class UnitOrFaceAmountOrCodeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type Quantity1Code 
        ///  FaceAmt of type CurrencyAndAmount 
        ///  Unit of type decimal 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( Quantity1Code ), Order = 0 )]
        [XmlElementAttribute( "FaceAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "Unit", typeof( decimal ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>Quantity1Code</b> (Quantity 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum Quantity1Code
    {

        /// <summary>
        /// <b>QALL - All Securities</b>.
        /// </summary>
        QALL,
    }

    /// <summary>
    /// Class <b>HoldingBalance4</b> (Holding Balance 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class HoldingBalance4
    {

        /// <summary>
        /// Element <b>Bal</b> (Balance) of type UnitOrFaceAmountOrCodeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public UnitOrFaceAmountOrCodeChoice Bal;

        /// <summary>
        /// Element <b>BalTp</b> (Balance Type) of type SecuritiesEntryType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public SecuritiesEntryType2Code BalTp;

        /// <summary>
        /// Element <b>BalTpSpecified</b> (Balance Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BalTpSpecified;

        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type SafekeepingPlaceFormatChoice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public SafekeepingPlaceFormatChoice SfkpgPlc;
    }

    /// <summary>
    /// Enumeration <b>SecuritiesEntryType2Code</b> (Securities Entry Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum SecuritiesEntryType2Code
    {

        /// <summary>
        /// <b>BLOK - Blocked</b>.
        /// </summary>
        BLOK,

        /// <summary>
        /// <b>ELIG - Eligible</b>.
        /// </summary>
        ELIG,

        /// <summary>
        /// <b>PEND - Pending Delivery</b>.
        /// </summary>
        PEND,

        /// <summary>
        /// <b>PENR - Pending Receipt</b>.
        /// </summary>
        PENR,

        /// <summary>
        /// <b>NOMI - Nominee</b>.
        /// </summary>
        NOMI,

        /// <summary>
        /// <b>SETD - Settled</b>.
        /// </summary>
        SETD,

        /// <summary>
        /// <b>BORR - Borrowed</b>.
        /// </summary>
        BORR,

        /// <summary>
        /// <b>LOAN - Loan</b>.
        /// </summary>
        LOAN,

        /// <summary>
        /// <b>SPOS - Street Position</b>.
        /// </summary>
        SPOS,

        /// <summary>
        /// <b>TRAD - Trade</b>.
        /// </summary>
        TRAD,

        /// <summary>
        /// <b>COLI - Collateral In</b>.
        /// </summary>
        COLI,

        /// <summary>
        /// <b>COLO - Collateral Out</b>.
        /// </summary>
        COLO,

        /// <summary>
        /// <b>UNBA - Uninstructed Balance</b>.
        /// </summary>
        UNBA,

        /// <summary>
        /// <b>INBA - Instructed Balance</b>.
        /// </summary>
        INBA,

        /// <summary>
        /// <b>REGO - Out For Registration</b>.
        /// </summary>
        REGO,
    }

    /// <summary>
    /// Class <b>SubAccount2</b> (Sub Account 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class SubAccount2
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }

    /// <summary>
    /// Class <b>SafekeepingAccount3</b> (Safekeeping Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class SafekeepingAccount3
    {

        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string AcctId;

        /// <summary>
        /// Element <b>AcctOwnr</b> (Account Owner) of type PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification9Choice AcctOwnr;

        /// <summary>
        /// Element <b>SubAcctDtls</b> (Sub Account Details) of type SubAccount2.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public SubAccount2 SubAcctDtls;

        /// <summary>
        /// Element <b>InstdBal</b> (Instructed Balance) of type array of HoldingBalance4.
        /// </summary>
        [XmlElementAttribute( "InstdBal", Order = 3 )]
        public HoldingBalance4[] InstdBal;

        /// <summary>
        /// Element <b>RghtsHldr</b> (Rights Holder) of type array of PartyIdentification9Choice.
        /// </summary>
        [XmlElementAttribute( "RghtsHldr", Order = 4 )]
        public PartyIdentification9Choice[] RghtsHldr;
    }

    /// <summary>
    /// Class <b>Instruction1</b> (Instruction 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class Instruction1
    {

        /// <summary>
        /// Element <b>InstrId</b> (Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string InstrId;

        /// <summary>
        /// Element <b>ReqdExctnDt</b> (Requested Execution Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime ReqdExctnDt;

        /// <summary>
        /// Element <b>ReqdExctnDtSpecified</b> (Requested Execution Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReqdExctnDtSpecified;

        /// <summary>
        /// Element <b>VoteExctnConf</b> (Vote Execution Confirmation) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool VoteExctnConf;

        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type SafekeepingAccount3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public SafekeepingAccount3 AcctDtls;

        /// <summary>
        /// Element <b>Prxy</b> (Proxy) of type Proxy2.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public Proxy2 Prxy;

        /// <summary>
        /// Element <b>VoteDtls</b> (Vote Details) of type VoteDetails1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public VoteDetails1 VoteDtls;

        /// <summary>
        /// Element <b>MtgAttndee</b> (Meeting Attendee) of type array of IndividualPerson13.
        /// </summary>
        [XmlElementAttribute( "MtgAttndee", Order = 6 )]
        public IndividualPerson13[] MtgAttndee;

        /// <summary>
        /// Element <b>SpcfcInstrReq</b> (Specific Instruction Request) of type SpecificInstructionRequest1.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public SpecificInstructionRequest1 SpcfcInstrReq;
    }

    /// <summary>
    /// Class <b>AlternateFinancialInstrumentIdentification1</b> (Alternate Financial Instrument Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class AlternateFinancialInstrumentIdentification1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "DmstIdSrc", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "PrtryIdSrc", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Id;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType
    {

        /// <summary>
        /// <b>DmstIdSrc - ?undefined</b>.
        /// </summary>
        DmstIdSrc,

        /// <summary>
        /// <b>PrtryIdSrc - ?undefined</b>.
        /// </summary>
        PrtryIdSrc,
    }

    /// <summary>
    /// Class <b>SecurityIdentification3</b> (Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class SecurityIdentification3
    {

        /// <summary>
        /// Element <b>ISIN</b> (ISIN) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string ISIN;

        /// <summary>
        /// Element <b>TckrSymb</b> (Ticker Symbol) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string TckrSymb;

        /// <summary>
        /// Element <b>CUSIP</b> (CUSIP) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string CUSIP;

        /// <summary>
        /// Element <b>SEDOL</b> (SEDOL) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string SEDOL;

        /// <summary>
        /// Element <b>QUICK</b> (QUICK) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string QUICK;

        /// <summary>
        /// Element <b>OthrId</b> (Other Identification) of type AlternateFinancialInstrumentIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public AlternateFinancialInstrumentIdentification1 OthrId;
    }

    /// <summary>
    /// Class <b>MeetingReference3</b> (Meeting Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public class MeetingReference3
    {

        /// <summary>
        /// Element <b>MtgId</b> (Meeting Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MtgId;

        /// <summary>
        /// Element <b>IssrMtgId</b> (Issuer Meeting Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IssrMtgId;

        /// <summary>
        /// Element <b>MtgDtAndTm</b> (Meeting Date And Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public System.DateTime MtgDtAndTm;

        /// <summary>
        /// Element <b>Tp</b> (Type) of type MeetingType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public MeetingType2Code Tp;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Clssfctn of type MeetingTypeClassification1Code 
        ///  XtndedClssfctn of type string 
        /// </summary>
        [XmlElementAttribute( "Clssfctn", typeof( MeetingTypeClassification1Code ), Order = 4 )]
        [XmlElementAttribute( "XtndedClssfctn", typeof( string ), Order = 4 )]
        public object Item;

        /// <summary>
        /// Element <b>Lctn</b> (Location) of type array of PostalAddress1.
        /// </summary>
        [XmlElementAttribute( "Lctn", Order = 5 )]
        public PostalAddress1[] Lctn;
    }

    /// <summary>
    /// Enumeration <b>MeetingType2Code</b> (Meeting Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum MeetingType2Code
    {

        /// <summary>
        /// <b>XMET - Extraordinary</b>.
        /// </summary>
        XMET,

        /// <summary>
        /// <b>GMET - General</b>.
        /// </summary>
        GMET,

        /// <summary>
        /// <b>MIXD - Mixed</b>.
        /// </summary>
        MIXD,

        /// <summary>
        /// <b>SPCL - Special</b>.
        /// </summary>
        SPCL,
    }

    /// <summary>
    /// Enumeration <b>MeetingTypeClassification1Code</b> (Meeting Type Classification 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.02" )]
    public enum MeetingTypeClassification1Code
    {

        /// <summary>
        /// <b>AMET - Annual</b>.
        /// </summary>
        AMET,

        /// <summary>
        /// <b>OMET - Ordinary</b>.
        /// </summary>
        OMET,

        /// <summary>
        /// <b>CLAS - Class</b>.
        /// </summary>
        CLAS,

        /// <summary>
        /// <b>ISSU - Issuer Initiated</b>.
        /// </summary>
        ISSU,

        /// <summary>
        /// <b>VRHI - Voting Rights Holder Initiated</b>.
        /// </summary>
        VRHI,

        /// <summary>
        /// <b>CORT - Court</b>.
        /// </summary>
        CORT,
    }

}
