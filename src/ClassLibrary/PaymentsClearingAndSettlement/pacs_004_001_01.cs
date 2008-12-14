
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


namespace i20022.pacs00400101
{

    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id pacs.004.001.01 name PaymentReturnV01 from Payments Clearing and Settlement business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>pacs00400101</b> (0040 01 01) of type pacs00400101.
        /// </summary>
        [XmlElementAttribute( "pacs.004.001.01", Order = 0 )]
        public pacs00400101 pacs00400101;
    }

    /// <summary>
    /// Class <b>pacs00400101</b> (0040 01 01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( TypeName = "pacs.004.001.01", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class pacs00400101
    {

        /// <summary>
        /// Element <b>GrpHdr</b> (Group Header) of type GroupHeader6.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public GroupHeader6 GrpHdr;

        /// <summary>
        /// Element <b>OrgnlGrpInf</b> (Original Group Information) of type OriginalGroupInformation2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public OriginalGroupInformation2 OrgnlGrpInf;

        /// <summary>
        /// Element <b>TxInf</b> (Transaction Information) of type array of PaymentTransactionInformation2.
        /// </summary>
        [XmlElementAttribute( "TxInf", Order = 2 )]
        public PaymentTransactionInformation2[] TxInf;
    }

    /// <summary>
    /// Class <b>GroupHeader6</b> (Group Header 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class GroupHeader6
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MsgId;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CreDtTm;

        /// <summary>
        /// Element <b>Authstn</b> (Authorisation) of type array of string.
        /// </summary>
        [XmlElementAttribute( "Authstn", Order = 2 )]
        public string[] Authstn;

        /// <summary>
        /// Element <b>BtchBookg</b> (Batch Booking) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public bool BtchBookg;

        /// <summary>
        /// Element <b>BtchBookgSpecified</b> (Batch Booking Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BtchBookgSpecified;

        /// <summary>
        /// Element <b>NbOfTxs</b> (Number Of Transactions) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string NbOfTxs;

        /// <summary>
        /// Element <b>CtrlSum</b> (Control Sum) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public decimal CtrlSum;

        /// <summary>
        /// Element <b>CtrlSumSpecified</b> (Control Sum Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CtrlSumSpecified;

        /// <summary>
        /// Element <b>GrpRtr</b> (Group Return) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public bool GrpRtr;

        /// <summary>
        /// Element <b>GrpRtrSpecified</b> (Group Return Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool GrpRtrSpecified;

        /// <summary>
        /// Element <b>TtlRtrdIntrBkSttlmAmt</b> (Total Returned Intr Bank Settlement Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public CurrencyAndAmount TtlRtrdIntrBkSttlmAmt;

        /// <summary>
        /// Element <b>IntrBkSttlmDt</b> (Intr Bank Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 8 )]
        public System.DateTime IntrBkSttlmDt;

        /// <summary>
        /// Element <b>IntrBkSttlmDtSpecified</b> (Intr Bank Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntrBkSttlmDtSpecified;

        /// <summary>
        /// Element <b>SttlmInf</b> (Settlement Information) of type SettlementInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public SettlementInformation1 SttlmInf;

        /// <summary>
        /// Element <b>InstgAgt</b> (Instructing Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public BranchAndFinancialInstitutionIdentification3 InstgAgt;

        /// <summary>
        /// Element <b>InstdAgt</b> (Instructed Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public BranchAndFinancialInstitutionIdentification3 InstdAgt;
    }

    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
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
    /// Class <b>CreditorReferenceType1</b> (Creditor Reference Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class CreditorReferenceType1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type DocumentType3Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( DocumentType3Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>DocumentType3Code</b> (Document Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum DocumentType3Code
    {

        /// <summary>
        /// <b>RADM - Remittance Advice Message</b>.
        /// </summary>
        RADM,

        /// <summary>
        /// <b>RPIN - Related Payment Instruction</b>.
        /// </summary>
        RPIN,

        /// <summary>
        /// <b>FXDR - Foreign Exchange Deal Reference</b>.
        /// </summary>
        FXDR,

        /// <summary>
        /// <b>DISP - Dispatch Advice</b>.
        /// </summary>
        DISP,

        /// <summary>
        /// <b>PUOR - Purchase Order</b>.
        /// </summary>
        PUOR,

        /// <summary>
        /// <b>SCOR - Structured Communication Reference</b>.
        /// </summary>
        SCOR,
    }

    /// <summary>
    /// Class <b>CreditorReferenceInformation1</b> (Creditor Reference Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class CreditorReferenceInformation1
    {

        /// <summary>
        /// Element <b>CdtrRefTp</b> (Creditor Reference Type) of type CreditorReferenceType1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CreditorReferenceType1 CdtrRefTp;

        /// <summary>
        /// Element <b>CdtrRef</b> (Creditor Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string CdtrRef;
    }

    /// <summary>
    /// Class <b>ReferredDocumentAmount1Choice</b> (Referred Document Amount 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ReferredDocumentAmount1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( "CdtNoteAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "DscntApldAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "DuePyblAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "RmtdAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "TaxAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public CurrencyAndAmount Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType5.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType5</b> (Item Choice Type 5).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType5
    {

        /// <summary>
        /// <b>CdtNoteAmt - ?undefined</b>.
        /// </summary>
        CdtNoteAmt,

        /// <summary>
        /// <b>DscntApldAmt - ?undefined</b>.
        /// </summary>
        DscntApldAmt,

        /// <summary>
        /// <b>DuePyblAmt - ?undefined</b>.
        /// </summary>
        DuePyblAmt,

        /// <summary>
        /// <b>RmtdAmt - ?undefined</b>.
        /// </summary>
        RmtdAmt,

        /// <summary>
        /// <b>TaxAmt - ?undefined</b>.
        /// </summary>
        TaxAmt,
    }

    /// <summary>
    /// Class <b>ReferredDocumentType1</b> (Referred Document Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ReferredDocumentType1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type DocumentType2Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( DocumentType2Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>DocumentType2Code</b> (Document Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum DocumentType2Code
    {

        /// <summary>
        /// <b>MSIN - Metered Service Invoice</b>.
        /// </summary>
        MSIN,

        /// <summary>
        /// <b>CNFA - Credit Note Related To Financial Adjustment</b>.
        /// </summary>
        CNFA,

        /// <summary>
        /// <b>DNFA - Debit Note Related To Financial Adjustment</b>.
        /// </summary>
        DNFA,

        /// <summary>
        /// <b>CINV - Commercial Invoice</b>.
        /// </summary>
        CINV,

        /// <summary>
        /// <b>CREN - Credit Note</b>.
        /// </summary>
        CREN,

        /// <summary>
        /// <b>DEBN - Debit Note</b>.
        /// </summary>
        DEBN,

        /// <summary>
        /// <b>HIRI - Hire Invoice</b>.
        /// </summary>
        HIRI,

        /// <summary>
        /// <b>SBIN - Self Billed Invoice</b>.
        /// </summary>
        SBIN,

        /// <summary>
        /// <b>CMCN - Commercial Contract</b>.
        /// </summary>
        CMCN,

        /// <summary>
        /// <b>SOAC - Statement Of Account</b>.
        /// </summary>
        SOAC,

        /// <summary>
        /// <b>DISP - Dispatch Advice</b>.
        /// </summary>
        DISP,
    }

    /// <summary>
    /// Class <b>ReferredDocumentInformation1</b> (Referred Document Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ReferredDocumentInformation1
    {

        /// <summary>
        /// Element <b>RfrdDocTp</b> (Referred Document Type) of type ReferredDocumentType1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ReferredDocumentType1 RfrdDocTp;

        /// <summary>
        /// Element <b>RfrdDocNb</b> (Referred Document Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string RfrdDocNb;
    }

    /// <summary>
    /// Class <b>StructuredRemittanceInformation6</b> (Structured Remittance Information 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class StructuredRemittanceInformation6
    {

        /// <summary>
        /// Element <b>RfrdDocInf</b> (Referred Document Information) of type ReferredDocumentInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ReferredDocumentInformation1 RfrdDocInf;

        /// <summary>
        /// Element <b>RfrdDocRltdDt</b> (Referred Document Related Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 1 )]
        public System.DateTime RfrdDocRltdDt;

        /// <summary>
        /// Element <b>RfrdDocRltdDtSpecified</b> (Referred Document Related Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RfrdDocRltdDtSpecified;

        /// <summary>
        /// Element <b>RfrdDocAmt</b> (Referred Document Amount) of type array of ReferredDocumentAmount1Choice.
        /// </summary>
        [XmlElementAttribute( "RfrdDocAmt", Order = 2 )]
        public ReferredDocumentAmount1Choice[] RfrdDocAmt;

        /// <summary>
        /// Element <b>CdtrRefInf</b> (Creditor Reference Information) of type CreditorReferenceInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public CreditorReferenceInformation1 CdtrRefInf;

        /// <summary>
        /// Element <b>Invcr</b> (Invcr) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification8 Invcr;

        /// <summary>
        /// Element <b>Invcee</b> (Invcee) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public PartyIdentification8 Invcee;

        /// <summary>
        /// Element <b>AddtlRmtInf</b> (Additional Remittance Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string AddtlRmtInf;
    }

    /// <summary>
    /// Class <b>PartyIdentification8</b> (Party Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class PartyIdentification8
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 PstlAdr;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type Party2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public Party2Choice Id;

        /// <summary>
        /// Element <b>CtryOfRes</b> (Country Of Residence) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string CtryOfRes;
    }

    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
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
    /// Class <b>Party2Choice</b> (Party 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class Party2Choice
    {

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        ///  OrgId of type OrganisationIdentification2 
        ///  PrvtId of type PersonIdentification3 
        /// </summary>
        [XmlElementAttribute( "OrgId", typeof( OrganisationIdentification2 ), Order = 0 )]
        [XmlElementAttribute( "PrvtId", typeof( PersonIdentification3 ), Order = 0 )]
        public object[] Items;
    }

    /// <summary>
    /// Class <b>OrganisationIdentification2</b> (Organisation Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class OrganisationIdentification2
    {

        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BIC;

        /// <summary>
        /// Element <b>IBEI</b> (IBEI) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IBEI;

        /// <summary>
        /// Element <b>BEI</b> (BEI) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string BEI;

        /// <summary>
        /// Element <b>EANGLN</b> (EANGLN) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string EANGLN;

        /// <summary>
        /// Element <b>USCHU</b> (USCHU) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string USCHU;

        /// <summary>
        /// Element <b>DUNS</b> (DUNS) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string DUNS;

        /// <summary>
        /// Element <b>BkPtyId</b> (Bank Party Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string BkPtyId;

        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string TaxIdNb;

        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public GenericIdentification3 PrtryId;
    }

    /// <summary>
    /// Class <b>GenericIdentification3</b> (Generic Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class GenericIdentification3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Issr;
    }

    /// <summary>
    /// Class <b>PersonIdentification3</b> (Person Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class PersonIdentification3
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  AlnRegnNb of type string 
        ///  CstmrNb of type string 
        ///  DrvrsLicNb of type string 
        ///  DtAndPlcOfBirth of type DateAndPlaceOfBirth 
        ///  IdntyCardNb of type string 
        ///  MplyrIdNb of type string 
        ///  OthrId of type GenericIdentification4 
        ///  PsptNb of type string 
        ///  SclSctyNb of type string 
        ///  TaxIdNb of type string 
        /// </summary>
        [XmlElementAttribute( "AlnRegnNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CstmrNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DrvrsLicNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DtAndPlcOfBirth", typeof( DateAndPlaceOfBirth ), Order = 0 )]
        [XmlElementAttribute( "IdntyCardNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "MplyrIdNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrId", typeof( GenericIdentification4 ), Order = 0 )]
        [XmlElementAttribute( "PsptNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SclSctyNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "TaxIdNb", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Class <b>DateAndPlaceOfBirth</b> (Date And Place Of Birth).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class DateAndPlaceOfBirth
    {

        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 0 )]
        public System.DateTime BirthDt;

        /// <summary>
        /// Element <b>PrvcOfBirth</b> (Province Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string PrvcOfBirth;

        /// <summary>
        /// Element <b>CityOfBirth</b> (City Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string CityOfBirth;

        /// <summary>
        /// Element <b>CtryOfBirth</b> (Country Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string CtryOfBirth;
    }

    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
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
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType2
    {

        /// <summary>
        /// <b>AlnRegnNb - ?undefined</b>.
        /// </summary>
        AlnRegnNb,

        /// <summary>
        /// <b>CstmrNb - ?undefined</b>.
        /// </summary>
        CstmrNb,

        /// <summary>
        /// <b>DrvrsLicNb - ?undefined</b>.
        /// </summary>
        DrvrsLicNb,

        /// <summary>
        /// <b>DtAndPlcOfBirth - ?undefined</b>.
        /// </summary>
        DtAndPlcOfBirth,

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
    /// Class <b>RemittanceInformation1</b> (Remittance Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class RemittanceInformation1
    {

        /// <summary>
        /// Element <b>Ustrd</b> (Ustrd) of type array of string.
        /// </summary>
        [XmlElementAttribute( "Ustrd", Order = 0 )]
        public string[] Ustrd;

        /// <summary>
        /// Element <b>Strd</b> (Structured) of type array of StructuredRemittanceInformation6.
        /// </summary>
        [XmlElementAttribute( "Strd", Order = 1 )]
        public StructuredRemittanceInformation6[] Strd;
    }

    /// <summary>
    /// Class <b>AmendmentInformationDetails1</b> (Amendment Information Details 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class AmendmentInformationDetails1
    {

        /// <summary>
        /// Element <b>OrgnlMndtId</b> (Original Mandate Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string OrgnlMndtId;

        /// <summary>
        /// Element <b>OrgnlCdtrSchmeId</b> (Original Creditor Scheme Identification) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification8 OrgnlCdtrSchmeId;

        /// <summary>
        /// Element <b>OrgnlCdtrAgt</b> (Original Creditor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public BranchAndFinancialInstitutionIdentification3 OrgnlCdtrAgt;

        /// <summary>
        /// Element <b>OrgnlCdtrAgtAcct</b> (Original Creditor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public CashAccount7 OrgnlCdtrAgtAcct;

        /// <summary>
        /// Element <b>OrgnlDbtr</b> (Original Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification8 OrgnlDbtr;

        /// <summary>
        /// Element <b>OrgnlDbtrAcct</b> (Original Debtor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public CashAccount7 OrgnlDbtrAcct;

        /// <summary>
        /// Element <b>OrgnlDbtrAgt</b> (Original Debtor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public BranchAndFinancialInstitutionIdentification3 OrgnlDbtrAgt;

        /// <summary>
        /// Element <b>OrgnlDbtrAgtAcct</b> (Original Debtor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public CashAccount7 OrgnlDbtrAgtAcct;

        /// <summary>
        /// Element <b>OrgnlFnlColltnDt</b> (Original Final Collection Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 8 )]
        public System.DateTime OrgnlFnlColltnDt;

        /// <summary>
        /// Element <b>OrgnlFnlColltnDtSpecified</b> (Original Final Collection Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrgnlFnlColltnDtSpecified;

        /// <summary>
        /// Element <b>OrgnlFrqcy</b> (Original Frequency) of type Frequency1Code.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public Frequency1Code OrgnlFrqcy;

        /// <summary>
        /// Element <b>OrgnlFrqcySpecified</b> (Original Frequency Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrgnlFrqcySpecified;
    }

    /// <summary>
    /// Class <b>BranchAndFinancialInstitutionIdentification3</b> (Branch And Financial Institution Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class BranchAndFinancialInstitutionIdentification3
    {

        /// <summary>
        /// Element <b>FinInstnId</b> (Financial Institution Identification) of type FinancialInstitutionIdentification5Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public FinancialInstitutionIdentification5Choice FinInstnId;

        /// <summary>
        /// Element <b>BrnchId</b> (Branch Identification) of type BranchData.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BranchData BrnchId;
    }

    /// <summary>
    /// Class <b>FinancialInstitutionIdentification5Choice</b> (Financial Institution Identification 5Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class FinancialInstitutionIdentification5Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BIC of type string 
        ///  ClrSysMmbId of type ClearingSystemMemberIdentification3Choice 
        ///  CmbndId of type FinancialInstitutionIdentification3 
        ///  NmAndAdr of type NameAndAddress7 
        ///  PrtryId of type GenericIdentification3 
        /// </summary>
        [XmlElementAttribute( "BIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ClrSysMmbId", typeof( ClearingSystemMemberIdentification3Choice ), Order = 0 )]
        [XmlElementAttribute( "CmbndId", typeof( FinancialInstitutionIdentification3 ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress7 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification3 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>ClearingSystemMemberIdentification3Choice</b> (Clearing System Member Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ClearingSystemMemberIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "Id", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

        /// <summary>
        /// <b>Id - ?undefined</b>.
        /// </summary>
        Id,

        /// <summary>
        /// <b>Prtry - ?undefined</b>.
        /// </summary>
        Prtry,
    }

    /// <summary>
    /// Class <b>FinancialInstitutionIdentification3</b> (Financial Institution Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class FinancialInstitutionIdentification3
    {

        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BIC;

        /// <summary>
        /// Element <b>ClrSysMmbId</b> (Clearing System Member Identification) of type ClearingSystemMemberIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ClearingSystemMemberIdentification3Choice ClrSysMmbId;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PostalAddress1 PstlAdr;

        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public GenericIdentification3 PrtryId;
    }

    /// <summary>
    /// Class <b>NameAndAddress7</b> (Name And Address 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class NameAndAddress7
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 PstlAdr;
    }

    /// <summary>
    /// Class <b>BranchData</b> (Branch Data).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class BranchData
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PostalAddress1 PstlAdr;
    }

    /// <summary>
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class CashAccount7
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification3Choice Id;

        /// <summary>
        /// Element <b>Tp</b> (Type) of type CashAccountType2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CashAccountType2 Tp;

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Ccy;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Nm;
    }

    /// <summary>
    /// Class <b>AccountIdentification3Choice</b> (Account Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class AccountIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BBAN of type string 
        ///  IBAN of type string 
        ///  PrtryAcct of type SimpleIdentificationInformation2 
        ///  UPIC of type string 
        /// </summary>
        [XmlElementAttribute( "BBAN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IBAN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "PrtryAcct", typeof( SimpleIdentificationInformation2 ), Order = 0 )]
        [XmlElementAttribute( "UPIC", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }

    /// <summary>
    /// Class <b>SimpleIdentificationInformation2</b> (Simple Identification Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class SimpleIdentificationInformation2
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType
    {

        /// <summary>
        /// <b>BBAN - ?undefined</b>.
        /// </summary>
        BBAN,

        /// <summary>
        /// <b>IBAN - ?undefined</b>.
        /// </summary>
        IBAN,

        /// <summary>
        /// <b>PrtryAcct - ?undefined</b>.
        /// </summary>
        PrtryAcct,

        /// <summary>
        /// <b>UPIC - ?undefined</b>.
        /// </summary>
        UPIC,
    }

    /// <summary>
    /// Class <b>CashAccountType2</b> (Cash Account Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class CashAccountType2
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type CashAccountType4Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( CashAccountType4Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>CashAccountType4Code</b> (Cash Account Type 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum CashAccountType4Code
    {

        /// <summary>
        /// <b>CASH - Cash Payment</b>.
        /// </summary>
        CASH,

        /// <summary>
        /// <b>CHAR - Charges</b>.
        /// </summary>
        CHAR,

        /// <summary>
        /// <b>COMM - Commission</b>.
        /// </summary>
        COMM,

        /// <summary>
        /// <b>TAXE - Tax</b>.
        /// </summary>
        TAXE,

        /// <summary>
        /// <b>CISH - Cash Income</b>.
        /// </summary>
        CISH,

        /// <summary>
        /// <b>TRAS - Cash Trading</b>.
        /// </summary>
        TRAS,

        /// <summary>
        /// <b>SACC - Settlement</b>.
        /// </summary>
        SACC,

        /// <summary>
        /// <b>CACC - Current</b>.
        /// </summary>
        CACC,

        /// <summary>
        /// <b>SVGS - Savings</b>.
        /// </summary>
        SVGS,

        /// <summary>
        /// <b>ONDP - Over Night Deposit</b>.
        /// </summary>
        ONDP,

        /// <summary>
        /// <b>MGLD - Marginal Lending</b>.
        /// </summary>
        MGLD,

        /// <summary>
        /// <b>NREX - Non Resident External</b>.
        /// </summary>
        NREX,

        /// <summary>
        /// <b>MOMA - Money Market</b>.
        /// </summary>
        MOMA,

        /// <summary>
        /// <b>LOAN - Loan</b>.
        /// </summary>
        LOAN,

        /// <summary>
        /// <b>SLRY - Salary</b>.
        /// </summary>
        SLRY,

        /// <summary>
        /// <b>ODFT - Overdraft</b>.
        /// </summary>
        ODFT,
    }

    /// <summary>
    /// Enumeration <b>Frequency1Code</b> (Frequency 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum Frequency1Code
    {

        /// <summary>
        /// <b>YEAR - Annual</b>.
        /// </summary>
        YEAR,

        /// <summary>
        /// <b>MNTH - Monthly</b>.
        /// </summary>
        MNTH,

        /// <summary>
        /// <b>QURT - Quarterly</b>.
        /// </summary>
        QURT,

        /// <summary>
        /// <b>MIAN - Semi Annual</b>.
        /// </summary>
        MIAN,

        /// <summary>
        /// <b>WEEK - Weekly</b>.
        /// </summary>
        WEEK,

        /// <summary>
        /// <b>DAIL - Daily</b>.
        /// </summary>
        DAIL,

        /// <summary>
        /// <b>ADHO - Adhoc</b>.
        /// </summary>
        ADHO,

        /// <summary>
        /// <b>INDA - Intra Day</b>.
        /// </summary>
        INDA,
    }

    /// <summary>
    /// Class <b>MandateRelatedInformation1</b> (Mandate Related Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class MandateRelatedInformation1
    {

        /// <summary>
        /// Element <b>MndtId</b> (Mandate Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MndtId;

        /// <summary>
        /// Element <b>DtOfSgntr</b> (Date Of Signature) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 1 )]
        public System.DateTime DtOfSgntr;

        /// <summary>
        /// Element <b>DtOfSgntrSpecified</b> (Date Of Signature Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DtOfSgntrSpecified;

        /// <summary>
        /// Element <b>AmdmntInd</b> (Amendment Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool AmdmntInd;

        /// <summary>
        /// Element <b>AmdmntIndSpecified</b> (Amendment Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AmdmntIndSpecified;

        /// <summary>
        /// Element <b>AmdmntInfDtls</b> (Amendment Information Details) of type AmendmentInformationDetails1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public AmendmentInformationDetails1 AmdmntInfDtls;

        /// <summary>
        /// Element <b>ElctrncSgntr</b> (Electronic Signature) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string ElctrncSgntr;

        /// <summary>
        /// Element <b>FrstColltnDt</b> (First Collection Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 5 )]
        public System.DateTime FrstColltnDt;

        /// <summary>
        /// Element <b>FrstColltnDtSpecified</b> (First Collection Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FrstColltnDtSpecified;

        /// <summary>
        /// Element <b>FnlColltnDt</b> (Final Collection Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 6 )]
        public System.DateTime FnlColltnDt;

        /// <summary>
        /// Element <b>FnlColltnDtSpecified</b> (Final Collection Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FnlColltnDtSpecified;

        /// <summary>
        /// Element <b>Frqcy</b> (Frequency) of type Frequency1Code.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public Frequency1Code Frqcy;

        /// <summary>
        /// Element <b>FrqcySpecified</b> (Frequency Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FrqcySpecified;
    }

    /// <summary>
    /// Class <b>LocalInstrument1Choice</b> (Local Instrument 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class LocalInstrument1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType4.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType4</b> (Item Choice Type 4).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType4
    {

        /// <summary>
        /// <b>Cd - ?undefined</b>.
        /// </summary>
        Cd,

        /// <summary>
        /// <b>Prtry - ?undefined</b>.
        /// </summary>
        Prtry,
    }

    /// <summary>
    /// Class <b>ServiceLevel2Choice</b> (Service Level 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ServiceLevel2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type ServiceLevel1Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( ServiceLevel1Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>ServiceLevel1Code</b> (Service Level 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum ServiceLevel1Code
    {

        /// <summary>
        /// <b>SEPA - Single Euro Payments Area</b>.
        /// </summary>
        SEPA,

        /// <summary>
        /// <b>SDVA - Same Day Value</b>.
        /// </summary>
        SDVA,

        /// <summary>
        /// <b>PRPT - EBAPriority Service</b>.
        /// </summary>
        PRPT,
    }

    /// <summary>
    /// Class <b>PaymentTypeInformation6</b> (Payment Type Information 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class PaymentTypeInformation6
    {

        /// <summary>
        /// Element <b>InstrPrty</b> (Instruction Priority) of type Priority2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Priority2Code InstrPrty;

        /// <summary>
        /// Element <b>InstrPrtySpecified</b> (Instruction Priority Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InstrPrtySpecified;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  ClrChanl of type ClearingChannel2Code 
        ///  SvcLvl of type ServiceLevel2Choice 
        /// </summary>
        [XmlElementAttribute( "ClrChanl", typeof( ClearingChannel2Code ), Order = 1 )]
        [XmlElementAttribute( "SvcLvl", typeof( ServiceLevel2Choice ), Order = 1 )]
        public object Item;

        /// <summary>
        /// Element <b>LclInstrm</b> (Local Instrument) of type LocalInstrument1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public LocalInstrument1Choice LclInstrm;

        /// <summary>
        /// Element <b>SeqTp</b> (Sequence Type) of type SequenceType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public SequenceType1Code SeqTp;

        /// <summary>
        /// Element <b>SeqTpSpecified</b> (Sequence Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SeqTpSpecified;

        /// <summary>
        /// Element <b>CtgyPurp</b> (Category Purpose) of type PaymentCategoryPurpose1Code.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PaymentCategoryPurpose1Code CtgyPurp;

        /// <summary>
        /// Element <b>CtgyPurpSpecified</b> (Category Purpose Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CtgyPurpSpecified;
    }

    /// <summary>
    /// Enumeration <b>Priority2Code</b> (Priority 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum Priority2Code
    {

        /// <summary>
        /// <b>HIGH - High</b>.
        /// </summary>
        HIGH,

        /// <summary>
        /// <b>NORM - Normal</b>.
        /// </summary>
        NORM,
    }

    /// <summary>
    /// Enumeration <b>ClearingChannel2Code</b> (Clearing Channel 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum ClearingChannel2Code
    {

        /// <summary>
        /// <b>RTGS - Real Time Gross Settlement System</b>.
        /// </summary>
        RTGS,

        /// <summary>
        /// <b>RTNS - Real Time Net Settlement System</b>.
        /// </summary>
        RTNS,

        /// <summary>
        /// <b>MPNS - Mass Payment Net System</b>.
        /// </summary>
        MPNS,

        /// <summary>
        /// <b>BOOK - Book Transfer</b>.
        /// </summary>
        BOOK,
    }

    /// <summary>
    /// Enumeration <b>SequenceType1Code</b> (Sequence Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum SequenceType1Code
    {

        /// <summary>
        /// <b>FRST - First</b>.
        /// </summary>
        FRST,

        /// <summary>
        /// <b>RCUR - Recurring</b>.
        /// </summary>
        RCUR,

        /// <summary>
        /// <b>FNAL - Final</b>.
        /// </summary>
        FNAL,

        /// <summary>
        /// <b>OOFF - One Off</b>.
        /// </summary>
        OOFF,
    }

    /// <summary>
    /// Enumeration <b>PaymentCategoryPurpose1Code</b> (Payment Category Purpose 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum PaymentCategoryPurpose1Code
    {

        /// <summary>
        /// <b>CORT - Court</b>.
        /// </summary>
        CORT,

        /// <summary>
        /// <b>SALA - Salary Payment</b>.
        /// </summary>
        SALA,

        /// <summary>
        /// <b>TREA - Treasury Payment</b>.
        /// </summary>
        TREA,

        /// <summary>
        /// <b>CASH - Cash Payment</b>.
        /// </summary>
        CASH,

        /// <summary>
        /// <b>DIVI - Dividend In Scope</b>.
        /// </summary>
        DIVI,

        /// <summary>
        /// <b>GOVT - Government Payment</b>.
        /// </summary>
        GOVT,

        /// <summary>
        /// <b>INTE - Interest</b>.
        /// </summary>
        INTE,

        /// <summary>
        /// <b>LOAN - Loan</b>.
        /// </summary>
        LOAN,

        /// <summary>
        /// <b>PENS - Pension Payment</b>.
        /// </summary>
        PENS,

        /// <summary>
        /// <b>SECU - Security Charge</b>.
        /// </summary>
        SECU,

        /// <summary>
        /// <b>SSBE - Social Security Benefit</b>.
        /// </summary>
        SSBE,

        /// <summary>
        /// <b>SUPP - Supplier Payment</b>.
        /// </summary>
        SUPP,

        /// <summary>
        /// <b>TAXS - Tax Payment</b>.
        /// </summary>
        TAXS,

        /// <summary>
        /// <b>TRAD - Trade</b>.
        /// </summary>
        TRAD,

        /// <summary>
        /// <b>VATX - Value Added Tax Payment</b>.
        /// </summary>
        VATX,

        /// <summary>
        /// <b>HEDG - Hedge Fund</b>.
        /// </summary>
        HEDG,

        /// <summary>
        /// <b>INTC - Intra Company Payment</b>.
        /// </summary>
        INTC,

        /// <summary>
        /// <b>WHLD - With Holding</b>.
        /// </summary>
        WHLD,
    }

    /// <summary>
    /// Class <b>SettlementInformation3</b> (Settlement Information 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class SettlementInformation3
    {

        /// <summary>
        /// Element <b>SttlmMtd</b> (Settlement Method) of type SettlementMethod1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SettlementMethod1Code SttlmMtd;

        /// <summary>
        /// Element <b>SttlmAcct</b> (Settlement Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CashAccount7 SttlmAcct;

        /// <summary>
        /// Element <b>ClrSys</b> (Clearing System) of type ClearingSystemIdentification1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public ClearingSystemIdentification1Choice ClrSys;

        /// <summary>
        /// Element <b>InstgRmbrsmntAgt</b> (Instructing Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public BranchAndFinancialInstitutionIdentification3 InstgRmbrsmntAgt;

        /// <summary>
        /// Element <b>InstgRmbrsmntAgtAcct</b> (Instructing Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public CashAccount7 InstgRmbrsmntAgtAcct;

        /// <summary>
        /// Element <b>InstdRmbrsmntAgt</b> (Instructed Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public BranchAndFinancialInstitutionIdentification3 InstdRmbrsmntAgt;

        /// <summary>
        /// Element <b>InstdRmbrsmntAgtAcct</b> (Instructed Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public CashAccount7 InstdRmbrsmntAgtAcct;

        /// <summary>
        /// Element <b>ThrdRmbrsmntAgt</b> (Third Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public BranchAndFinancialInstitutionIdentification3 ThrdRmbrsmntAgt;

        /// <summary>
        /// Element <b>ThrdRmbrsmntAgtAcct</b> (Third Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public CashAccount7 ThrdRmbrsmntAgtAcct;
    }

    /// <summary>
    /// Enumeration <b>SettlementMethod1Code</b> (Settlement Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum SettlementMethod1Code
    {

        /// <summary>
        /// <b>INDA - Intra Day</b>.
        /// </summary>
        INDA,

        /// <summary>
        /// <b>INGA - Instructing Agent</b>.
        /// </summary>
        INGA,

        /// <summary>
        /// <b>COVE - Cover Method</b>.
        /// </summary>
        COVE,

        /// <summary>
        /// <b>CLRG - Clearing System</b>.
        /// </summary>
        CLRG,
    }

    /// <summary>
    /// Class <b>ClearingSystemIdentification1Choice</b> (Clearing System Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ClearingSystemIdentification1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  ClrSysId of type CashClearingSystem3Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "ClrSysId", typeof( CashClearingSystem3Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>CashClearingSystem3Code</b> (Cash Clearing System 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum CashClearingSystem3Code
    {

        /// <summary>
        /// <b>ABE - EBAEuro 1Step 1</b>.
        /// </summary>
        ABE,

        /// <summary>
        /// <b>ART - Austrian</b>.
        /// </summary>
        ART,

        /// <summary>
        /// <b>AVP - New Zealand</b>.
        /// </summary>
        AVP,

        /// <summary>
        /// <b>AZM - Azerbaijan</b>.
        /// </summary>
        AZM,

        /// <summary>
        /// <b>BAP - Bosnia Herzegovina</b>.
        /// </summary>
        BAP,

        /// <summary>
        /// <b>BEL - Belgium</b>.
        /// </summary>
        BEL,

        /// <summary>
        /// <b>BOF - Finland</b>.
        /// </summary>
        BOF,

        /// <summary>
        /// <b>BRL - Italy</b>.
        /// </summary>
        BRL,

        /// <summary>
        /// <b>CAD - Canada</b>.
        /// </summary>
        CAD,

        /// <summary>
        /// <b>CAM - Spain CAM</b>.
        /// </summary>
        CAM,

        /// <summary>
        /// <b>CBJ - Ireland</b>.
        /// </summary>
        CBJ,

        /// <summary>
        /// <b>CHP - United Kingdom</b>.
        /// </summary>
        CHP,

        /// <summary>
        /// <b>DKC - Denmark</b>.
        /// </summary>
        DKC,

        /// <summary>
        /// <b>RTP - Germany RTGSPlus</b>.
        /// </summary>
        RTP,

        /// <summary>
        /// <b>EBA - EBAEuro 1</b>.
        /// </summary>
        EBA,

        /// <summary>
        /// <b>ELS - Germany ELS</b>.
        /// </summary>
        ELS,

        /// <summary>
        /// <b>ERP - EBAStep 1</b>.
        /// </summary>
        ERP,

        /// <summary>
        /// <b>XCT - EBAStep 2</b>.
        /// </summary>
        XCT,

        /// <summary>
        /// <b>HRK - Croatia</b>.
        /// </summary>
        HRK,

        /// <summary>
        /// <b>HRM - Greece</b>.
        /// </summary>
        HRM,

        /// <summary>
        /// <b>HUF - Hungary</b>.
        /// </summary>
        HUF,

        /// <summary>
        /// <b>LGS - Luxemburg</b>.
        /// </summary>
        LGS,

        /// <summary>
        /// <b>LVL - Latvia</b>.
        /// </summary>
        LVL,

        /// <summary>
        /// <b>MUP - Mauritius</b>.
        /// </summary>
        MUP,

        /// <summary>
        /// <b>NOC - Norway</b>.
        /// </summary>
        NOC,

        /// <summary>
        /// <b>PCH - Switzerland</b>.
        /// </summary>
        PCH,

        /// <summary>
        /// <b>PDS - Australia</b>.
        /// </summary>
        PDS,

        /// <summary>
        /// <b>PEG - Egypt</b>.
        /// </summary>
        PEG,

        /// <summary>
        /// <b>PNS - France PNS</b>.
        /// </summary>
        PNS,

        /// <summary>
        /// <b>PVE - Venezuela</b>.
        /// </summary>
        PVE,

        /// <summary>
        /// <b>SEC - Sweden SEC</b>.
        /// </summary>
        SEC,

        /// <summary>
        /// <b>SIT - Slovania</b>.
        /// </summary>
        SIT,

        /// <summary>
        /// <b>SLB - Spain ES</b>.
        /// </summary>
        SLB,

        /// <summary>
        /// <b>SPG - Portugal</b>.
        /// </summary>
        SPG,

        /// <summary>
        /// <b>SSK - Sweden SSK</b>.
        /// </summary>
        SSK,

        /// <summary>
        /// <b>TBF - France FR</b>.
        /// </summary>
        TBF,

        /// <summary>
        /// <b>TGT - Target</b>.
        /// </summary>
        TGT,

        /// <summary>
        /// <b>TOP - Netherlands</b>.
        /// </summary>
        TOP,

        /// <summary>
        /// <b>FDW - Fedwire</b>.
        /// </summary>
        FDW,

        /// <summary>
        /// <b>BOJ - Bank Of Japan Net</b>.
        /// </summary>
        BOJ,

        /// <summary>
        /// <b>FEY - Foreign Exchange Yen Clearing</b>.
        /// </summary>
        FEY,

        /// <summary>
        /// <b>ZEN - Zengin</b>.
        /// </summary>
        ZEN,

        /// <summary>
        /// <b>DDK - Denmark DDK</b>.
        /// </summary>
        DDK,

        /// <summary>
        /// <b>AIP - Albania</b>.
        /// </summary>
        AIP,

        /// <summary>
        /// <b>BCC - Sweden BGC</b>.
        /// </summary>
        BCC,

        /// <summary>
        /// <b>BDS - Barbados</b>.
        /// </summary>
        BDS,

        /// <summary>
        /// <b>BGN - Bulgaria</b>.
        /// </summary>
        BGN,

        /// <summary>
        /// <b>BHS - Bahamas</b>.
        /// </summary>
        BHS,

        /// <summary>
        /// <b>BIS - Botswana</b>.
        /// </summary>
        BIS,

        /// <summary>
        /// <b>BSP - Philippines</b>.
        /// </summary>
        BSP,

        /// <summary>
        /// <b>EPM - ECB</b>.
        /// </summary>
        EPM,

        /// <summary>
        /// <b>EPN - USChips ACH</b>.
        /// </summary>
        EPN,

        /// <summary>
        /// <b>FDA - USFed ACH</b>.
        /// </summary>
        FDA,

        /// <summary>
        /// <b>GIS - Ghana</b>.
        /// </summary>
        GIS,

        /// <summary>
        /// <b>INC - Netherlands IP</b>.
        /// </summary>
        INC,

        /// <summary>
        /// <b>JOD - Jordan</b>.
        /// </summary>
        JOD,

        /// <summary>
        /// <b>KPS - Kenya</b>.
        /// </summary>
        KPS,

        /// <summary>
        /// <b>LKB - Sri Lanka</b>.
        /// </summary>
        LKB,

        /// <summary>
        /// <b>MEP - Singapore</b>.
        /// </summary>
        MEP,

        /// <summary>
        /// <b>MRS - Malta</b>.
        /// </summary>
        MRS,

        /// <summary>
        /// <b>NAM - Namibia</b>.
        /// </summary>
        NAM,

        /// <summary>
        /// <b>PTR - Angola</b>.
        /// </summary>
        PTR,

        /// <summary>
        /// <b>ROL - Romania EPO</b>.
        /// </summary>
        ROL,

        /// <summary>
        /// <b>ROS - Romania GSRS</b>.
        /// </summary>
        ROS,

        /// <summary>
        /// <b>SCP - Chili</b>.
        /// </summary>
        SCP,

        /// <summary>
        /// <b>STG - United Kingdom GBP</b>.
        /// </summary>
        STG,

        /// <summary>
        /// <b>THB - Thailand</b>.
        /// </summary>
        THB,

        /// <summary>
        /// <b>TIS - Tanzania</b>.
        /// </summary>
        TIS,

        /// <summary>
        /// <b>TTD - Trinidad And Tobago</b>.
        /// </summary>
        TTD,

        /// <summary>
        /// <b>UIS - Uganda</b>.
        /// </summary>
        UIS,

        /// <summary>
        /// <b>MOS - South Africa</b>.
        /// </summary>
        MOS,

        /// <summary>
        /// <b>ZET - Zimbabwe</b>.
        /// </summary>
        ZET,

        /// <summary>
        /// <b>ZIS - Zambia</b>.
        /// </summary>
        ZIS,

        /// <summary>
        /// <b>CHI - USChips</b>.
        /// </summary>
        CHI,

        /// <summary>
        /// <b>COP - Columbia</b>.
        /// </summary>
        COP,
    }

    /// <summary>
    /// Class <b>EquivalentAmount</b> (Equivalent Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class EquivalentAmount
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>CcyOfTrf</b> (Currency Of Transfer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string CcyOfTrf;
    }

    /// <summary>
    /// Class <b>AmountType2Choice</b> (Amount Type 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class AmountType2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  EqvtAmt of type EquivalentAmount 
        ///  InstdAmt of type CurrencyAndAmount 
        /// </summary>
        [XmlElementAttribute( "EqvtAmt", typeof( EquivalentAmount ), Order = 0 )]
        [XmlElementAttribute( "InstdAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>OriginalTransactionReference1</b> (Original Transaction Reference 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class OriginalTransactionReference1
    {

        /// <summary>
        /// Element <b>IntrBkSttlmAmt</b> (Intr Bank Settlement Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CurrencyAndAmount IntrBkSttlmAmt;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type AmountType2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AmountType2Choice Amt;

        /// <summary>
        /// Element <b>IntrBkSttlmDt</b> (Intr Bank Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 2 )]
        public System.DateTime IntrBkSttlmDt;

        /// <summary>
        /// Element <b>IntrBkSttlmDtSpecified</b> (Intr Bank Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntrBkSttlmDtSpecified;

        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( "ReqdColltnDt", typeof( System.DateTime ), DataType = "date", Order = 3 )]
        [XmlElementAttribute( "ReqdExctnDt", typeof( System.DateTime ), DataType = "date", Order = 3 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public System.DateTime Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;

        /// <summary>
        /// Element <b>CdtrSchmeId</b> (Creditor Scheme Identification) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public PartyIdentification8 CdtrSchmeId;

        /// <summary>
        /// Element <b>SttlmInf</b> (Settlement Information) of type SettlementInformation3.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public SettlementInformation3 SttlmInf;

        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation6.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public PaymentTypeInformation6 PmtTpInf;

        /// <summary>
        /// Element <b>PmtMtd</b> (Payment Method) of type PaymentMethod4Code.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public PaymentMethod4Code PmtMtd;

        /// <summary>
        /// Element <b>PmtMtdSpecified</b> (Payment Method Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PmtMtdSpecified;

        /// <summary>
        /// Element <b>MndtRltdInf</b> (Mandate Related Information) of type MandateRelatedInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public MandateRelatedInformation1 MndtRltdInf;

        /// <summary>
        /// Element <b>RmtInf</b> (Remittance Information) of type RemittanceInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public RemittanceInformation1 RmtInf;

        /// <summary>
        /// Element <b>UltmtDbtr</b> (Ultimate Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public PartyIdentification8 UltmtDbtr;

        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public PartyIdentification8 Dbtr;

        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 13 )]
        public CashAccount7 DbtrAcct;

        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 14 )]
        public BranchAndFinancialInstitutionIdentification3 DbtrAgt;

        /// <summary>
        /// Element <b>DbtrAgtAcct</b> (Debtor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 15 )]
        public CashAccount7 DbtrAgtAcct;

        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public BranchAndFinancialInstitutionIdentification3 CdtrAgt;

        /// <summary>
        /// Element <b>CdtrAgtAcct</b> (Creditor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 17 )]
        public CashAccount7 CdtrAgtAcct;

        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 18 )]
        public PartyIdentification8 Cdtr;

        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 19 )]
        public CashAccount7 CdtrAcct;

        /// <summary>
        /// Element <b>UltmtCdtr</b> (Ultimate Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 20 )]
        public PartyIdentification8 UltmtCdtr;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType3
    {

        /// <summary>
        /// <b>ReqdColltnDt - ?undefined</b>.
        /// </summary>
        ReqdColltnDt,

        /// <summary>
        /// <b>ReqdExctnDt - ?undefined</b>.
        /// </summary>
        ReqdExctnDt,
    }

    /// <summary>
    /// Enumeration <b>PaymentMethod4Code</b> (Payment Method 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum PaymentMethod4Code
    {

        /// <summary>
        /// <b>CHK - Cheque</b>.
        /// </summary>
        CHK,

        /// <summary>
        /// <b>TRF - Credit Transfer</b>.
        /// </summary>
        TRF,

        /// <summary>
        /// <b>DD - Direct Debit</b>.
        /// </summary>
        DD,

        /// <summary>
        /// <b>TRA - Transfer Advice</b>.
        /// </summary>
        TRA,
    }

    /// <summary>
    /// Class <b>ChargesInformation1</b> (Charges Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ChargesInformation1
    {

        /// <summary>
        /// Element <b>ChrgsAmt</b> (Charges Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CurrencyAndAmount ChrgsAmt;

        /// <summary>
        /// Element <b>ChrgsPty</b> (Charges Party) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BranchAndFinancialInstitutionIdentification3 ChrgsPty;
    }

    /// <summary>
    /// Class <b>OriginalGroupInformation3</b> (Original Group Information 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class OriginalGroupInformation3
    {

        /// <summary>
        /// Element <b>OrgnlMsgId</b> (Original Message Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string OrgnlMsgId;

        /// <summary>
        /// Element <b>OrgnlMsgNmId</b> (Original Message Name Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string OrgnlMsgNmId;

        /// <summary>
        /// Element <b>OrgnlCreDtTm</b> (Original Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public System.DateTime OrgnlCreDtTm;

        /// <summary>
        /// Element <b>OrgnlCreDtTmSpecified</b> (Original Creation Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrgnlCreDtTmSpecified;
    }

    /// <summary>
    /// Class <b>PaymentTransactionInformation2</b> (Payment Transaction Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class PaymentTransactionInformation2
    {

        /// <summary>
        /// Element <b>RtrId</b> (Return Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string RtrId;

        /// <summary>
        /// Element <b>OrgnlGrpInf</b> (Original Group Information) of type OriginalGroupInformation3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public OriginalGroupInformation3 OrgnlGrpInf;

        /// <summary>
        /// Element <b>OrgnlInstrId</b> (Original Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string OrgnlInstrId;

        /// <summary>
        /// Element <b>OrgnlEndToEndId</b> (Original End To End Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string OrgnlEndToEndId;

        /// <summary>
        /// Element <b>OrgnlTxId</b> (Original Transaction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string OrgnlTxId;

        /// <summary>
        /// Element <b>OrgnlIntrBkSttlmAmt</b> (Original Intr Bank Settlement Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public CurrencyAndAmount OrgnlIntrBkSttlmAmt;

        /// <summary>
        /// Element <b>RtrdIntrBkSttlmAmt</b> (Returned Intr Bank Settlement Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public CurrencyAndAmount RtrdIntrBkSttlmAmt;

        /// <summary>
        /// Element <b>IntrBkSttlmDt</b> (Intr Bank Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 7 )]
        public System.DateTime IntrBkSttlmDt;

        /// <summary>
        /// Element <b>IntrBkSttlmDtSpecified</b> (Intr Bank Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntrBkSttlmDtSpecified;

        /// <summary>
        /// Element <b>RtrdInstdAmt</b> (Returned Instructed Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public CurrencyAndAmount RtrdInstdAmt;

        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public decimal XchgRate;

        /// <summary>
        /// Element <b>XchgRateSpecified</b> (Exchange Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool XchgRateSpecified;

        /// <summary>
        /// Element <b>CompstnAmt</b> (Compensation Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public CurrencyAndAmount CompstnAmt;

        /// <summary>
        /// Element <b>ChrgBr</b> (Charge Bearer) of type ChargeBearerType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public ChargeBearerType1Code ChrgBr;

        /// <summary>
        /// Element <b>ChrgBrSpecified</b> (Charge Bearer Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ChrgBrSpecified;

        /// <summary>
        /// Element <b>ChrgsInf</b> (Charges Information) of type array of ChargesInformation1.
        /// </summary>
        [XmlElementAttribute( "ChrgsInf", Order = 12 )]
        public ChargesInformation1[] ChrgsInf;

        /// <summary>
        /// Element <b>InstgAgt</b> (Instructing Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 13 )]
        public BranchAndFinancialInstitutionIdentification3 InstgAgt;

        /// <summary>
        /// Element <b>InstdAgt</b> (Instructed Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 14 )]
        public BranchAndFinancialInstitutionIdentification3 InstdAgt;

        /// <summary>
        /// Element <b>RtrRsnInf</b> (Return Reason Information) of type array of ReturnReasonInformation1.
        /// </summary>
        [XmlElementAttribute( "RtrRsnInf", Order = 15 )]
        public ReturnReasonInformation1[] RtrRsnInf;

        /// <summary>
        /// Element <b>OrgnlTxRef</b> (Original Transaction Reference) of type OriginalTransactionReference1.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public OriginalTransactionReference1 OrgnlTxRef;
    }

    /// <summary>
    /// Enumeration <b>ChargeBearerType1Code</b> (Charge Bearer Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum ChargeBearerType1Code
    {

        /// <summary>
        /// <b>DEBT - Borne By Debtor</b>.
        /// </summary>
        DEBT,

        /// <summary>
        /// <b>CRED - Borne By Creditor</b>.
        /// </summary>
        CRED,

        /// <summary>
        /// <b>SHAR - Shared</b>.
        /// </summary>
        SHAR,

        /// <summary>
        /// <b>SLEV - Following Service Level</b>.
        /// </summary>
        SLEV,
    }

    /// <summary>
    /// Class <b>ReturnReasonInformation1</b> (Return Reason Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ReturnReasonInformation1
    {

        /// <summary>
        /// Element <b>RtrOrgtr</b> (Return Originator) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentification8 RtrOrgtr;

        /// <summary>
        /// Element <b>RtrRsn</b> (Return Reason) of type ReturnReason1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ReturnReason1Choice RtrRsn;

        /// <summary>
        /// Element <b>AddtlRtrRsnInf</b> (Additional Return Reason Information) of type array of string.
        /// </summary>
        [XmlElementAttribute( "AddtlRtrRsnInf", Order = 2 )]
        public string[] AddtlRtrRsnInf;
    }

    /// <summary>
    /// Class <b>ReturnReason1Choice</b> (Return Reason 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class ReturnReason1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type TransactionRejectReason2Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( TransactionRejectReason2Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>TransactionRejectReason2Code</b> (Transaction Reject Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public enum TransactionRejectReason2Code
    {

        /// <summary>
        /// <b>AC01 - Incorrect Account Number</b>.
        /// </summary>
        AC01,

        /// <summary>
        /// <b>AC04 - Closed Account Number</b>.
        /// </summary>
        AC04,

        /// <summary>
        /// <b>AC06 - Blocked Account</b>.
        /// </summary>
        AC06,

        /// <summary>
        /// <b>AM01 - Zero Amount</b>.
        /// </summary>
        AM01,

        /// <summary>
        /// <b>AM02 - Not Allowed Amount</b>.
        /// </summary>
        AM02,

        /// <summary>
        /// <b>AM03 - Not Allowed Currency</b>.
        /// </summary>
        AM03,

        /// <summary>
        /// <b>AM04 - Insufficient Funds</b>.
        /// </summary>
        AM04,

        /// <summary>
        /// <b>AM05 - Duplication</b>.
        /// </summary>
        AM05,

        /// <summary>
        /// <b>AM06 - Too Low Amount</b>.
        /// </summary>
        AM06,

        /// <summary>
        /// <b>AM07 - Blocked Amount</b>.
        /// </summary>
        AM07,

        /// <summary>
        /// <b>BE01 - Inconsistent With End Customer</b>.
        /// </summary>
        BE01,

        /// <summary>
        /// <b>BE04 - Missing Creditor Address</b>.
        /// </summary>
        BE04,

        /// <summary>
        /// <b>BE05 - Unrecognised Initiating Party</b>.
        /// </summary>
        BE05,

        /// <summary>
        /// <b>AG01 - Transaction Forbidden</b>.
        /// </summary>
        AG01,

        /// <summary>
        /// <b>AG02 - Invalid Bank Operation Code</b>.
        /// </summary>
        AG02,

        /// <summary>
        /// <b>DT01 - Invalid Date</b>.
        /// </summary>
        DT01,

        /// <summary>
        /// <b>RF01 - Not Unique Transaction Reference</b>.
        /// </summary>
        RF01,

        /// <summary>
        /// <b>RC01 - Bank Identifier Incorrect</b>.
        /// </summary>
        RC01,

        /// <summary>
        /// <b>TM01 - Cut Off Time</b>.
        /// </summary>
        TM01,

        /// <summary>
        /// <b>ED01 - Correspondent Bank Not Possible</b>.
        /// </summary>
        ED01,

        /// <summary>
        /// <b>ED03 - Balance Info Requested</b>.
        /// </summary>
        ED03,

        /// <summary>
        /// <b>MS03 - Not Specified Reason Agent Generated</b>.
        /// </summary>
        MS03,

        /// <summary>
        /// <b>MS02 - Not Specified Reason Customer Generated</b>.
        /// </summary>
        MS02,

        /// <summary>
        /// <b>BE06 - Unknown End Customer</b>.
        /// </summary>
        BE06,

        /// <summary>
        /// <b>BE07 - Missing Debtor Address</b>.
        /// </summary>
        BE07,

        /// <summary>
        /// <b>AM09 - Wrong Amount</b>.
        /// </summary>
        AM09,

        /// <summary>
        /// <b>AM10 - Invalid Control Sum</b>.
        /// </summary>
        AM10,

        /// <summary>
        /// <b>MD01 - No Mandate</b>.
        /// </summary>
        MD01,

        /// <summary>
        /// <b>MD02 - Missing Mandatory Information In Mandate</b>.
        /// </summary>
        MD02,

        /// <summary>
        /// <b>MD03 - Invalid File Format For Other Reason Than Grouping Indicator</b>.
        /// </summary>
        MD03,

        /// <summary>
        /// <b>MD04 - Invalid File Format For Grouping Indicator</b>.
        /// </summary>
        MD04,

        /// <summary>
        /// <b>MD06 - Refund Request By End Customer</b>.
        /// </summary>
        MD06,

        /// <summary>
        /// <b>MD07 - End Customer Deceased</b>.
        /// </summary>
        MD07,

        /// <summary>
        /// <b>ED05 - Settlement Failed</b>.
        /// </summary>
        ED05,

        /// <summary>
        /// <b>NARR - Narrative</b>.
        /// </summary>
        NARR,
    }

    /// <summary>
    /// Class <b>OriginalGroupInformation2</b> (Original Group Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class OriginalGroupInformation2
    {

        /// <summary>
        /// Element <b>OrgnlMsgId</b> (Original Message Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string OrgnlMsgId;

        /// <summary>
        /// Element <b>OrgnlMsgNmId</b> (Original Message Name Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string OrgnlMsgNmId;

        /// <summary>
        /// Element <b>OrgnlCreDtTm</b> (Original Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public System.DateTime OrgnlCreDtTm;

        /// <summary>
        /// Element <b>OrgnlCreDtTmSpecified</b> (Original Creation Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrgnlCreDtTmSpecified;

        /// <summary>
        /// Element <b>RtrRsnInf</b> (Return Reason Information) of type array of ReturnReasonInformation1.
        /// </summary>
        [XmlElementAttribute( "RtrRsnInf", Order = 3 )]
        public ReturnReasonInformation1[] RtrRsnInf;
    }

    /// <summary>
    /// Class <b>SettlementInformation1</b> (Settlement Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.01" )]
    public class SettlementInformation1
    {

        /// <summary>
        /// Element <b>SttlmMtd</b> (Settlement Method) of type SettlementMethod1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SettlementMethod1Code SttlmMtd;

        /// <summary>
        /// Element <b>SttlmAcct</b> (Settlement Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CashAccount7 SttlmAcct;

        /// <summary>
        /// Element <b>ClrSys</b> (Clearing System) of type ClearingSystemIdentification1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public ClearingSystemIdentification1Choice ClrSys;

        /// <summary>
        /// Element <b>InstgRmbrsmntAgt</b> (Instructing Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public BranchAndFinancialInstitutionIdentification3 InstgRmbrsmntAgt;

        /// <summary>
        /// Element <b>InstgRmbrsmntAgtAcct</b> (Instructing Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public CashAccount7 InstgRmbrsmntAgtAcct;

        /// <summary>
        /// Element <b>InstdRmbrsmntAgt</b> (Instructed Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public BranchAndFinancialInstitutionIdentification3 InstdRmbrsmntAgt;

        /// <summary>
        /// Element <b>InstdRmbrsmntAgtAcct</b> (Instructed Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public CashAccount7 InstdRmbrsmntAgtAcct;

        /// <summary>
        /// Element <b>ThrdRmbrsmntAgt</b> (Third Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public BranchAndFinancialInstitutionIdentification3 ThrdRmbrsmntAgt;

        /// <summary>
        /// Element <b>ThrdRmbrsmntAgtAcct</b> (Third Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public CashAccount7 ThrdRmbrsmntAgtAcct;
    }
}
