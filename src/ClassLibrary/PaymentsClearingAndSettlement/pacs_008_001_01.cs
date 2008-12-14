
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


namespace i20022.pacs00800101
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id pacs.008.001.01 name FIToFICustomerCreditTransferV01 from Payments Clearing and Settlement business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>pacs00800101</b> (0080 01 01) of type pacs00800101.
        /// </summary>
        [XmlElementAttribute( "pacs.008.001.01", Order = 0 )]
        public pacs00800101 pacs00800101;
    }

    /// <summary>
    /// Class <b>pacs00800101</b> (0080 01 01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( TypeName = "pacs.008.001.01", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class pacs00800101
    {

        /// <summary>
        /// Element <b>GrpHdr</b> (Group Header) of type GroupHeader2.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public GroupHeader2 GrpHdr;

        /// <summary>
        /// Element <b>CdtTrfTxInf</b> (Credit Transfer Transaction Information) of type array of CreditTransferTransactionInformation2.
        /// </summary>
        [XmlElementAttribute( "CdtTrfTxInf", Order = 1 )]
        public CreditTransferTransactionInformation2[] CdtTrfTxInf;
    }

    /// <summary>
    /// Class <b>GroupHeader2</b> (Group Header 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class GroupHeader2
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
        /// Element <b>BtchBookg</b> (Batch Booking) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool BtchBookg;

        /// <summary>
        /// Element <b>BtchBookgSpecified</b> (Batch Booking Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BtchBookgSpecified;

        /// <summary>
        /// Element <b>NbOfTxs</b> (Number Of Transactions) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string NbOfTxs;

        /// <summary>
        /// Element <b>CtrlSum</b> (Control Sum) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public decimal CtrlSum;

        /// <summary>
        /// Element <b>CtrlSumSpecified</b> (Control Sum Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CtrlSumSpecified;

        /// <summary>
        /// Element <b>TtlIntrBkSttlmAmt</b> (Total Intr Bank Settlement Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public CurrencyAndAmount TtlIntrBkSttlmAmt;

        /// <summary>
        /// Element <b>IntrBkSttlmDt</b> (Intr Bank Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 6 )]
        public System.DateTime IntrBkSttlmDt;

        /// <summary>
        /// Element <b>IntrBkSttlmDtSpecified</b> (Intr Bank Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntrBkSttlmDtSpecified;

        /// <summary>
        /// Element <b>SttlmInf</b> (Settlement Information) of type SettlementInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public SettlementInformation1 SttlmInf;

        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation3.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public PaymentTypeInformation3 PmtTpInf;

        /// <summary>
        /// Element <b>InstgAgt</b> (Instructing Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public BranchAndFinancialInstitutionIdentification3 InstgAgt;

        /// <summary>
        /// Element <b>InstdAgt</b> (Instructed Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public BranchAndFinancialInstitutionIdentification3 InstdAgt;
    }

    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01", IncludeInSchema = false )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;

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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType3
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Class <b>NameAndAddress3</b> (Name And Address 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class NameAndAddress3
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
    /// Class <b>RemittanceLocation1</b> (Remittance Location 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class RemittanceLocation1
    {

        /// <summary>
        /// Element <b>RmtId</b> (Remittance Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string RmtId;

        /// <summary>
        /// Element <b>RmtLctnMtd</b> (Remittance Location Method) of type RemittanceLocationMethod1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public RemittanceLocationMethod1Code RmtLctnMtd;

        /// <summary>
        /// Element <b>RmtLctnMtdSpecified</b> (Remittance Location Method Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RmtLctnMtdSpecified;

        /// <summary>
        /// Element <b>RmtLctnElctrncAdr</b> (Remittance Location Electronic Address) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string RmtLctnElctrncAdr;

        /// <summary>
        /// Element <b>RmtLctnPstlAdr</b> (Remittance Location Postal Address) of type NameAndAddress3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public NameAndAddress3 RmtLctnPstlAdr;
    }

    /// <summary>
    /// Enumeration <b>RemittanceLocationMethod1Code</b> (Remittance Location Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public enum RemittanceLocationMethod1Code
    {

        /// <summary>
        /// <b>FAXI - Fax</b>.
        /// </summary>
        FAXI,

        /// <summary>
        /// <b>EDIC - Electronic Data Interchange</b>.
        /// </summary>
        EDIC,

        /// <summary>
        /// <b>URID - Uniform Resource Identifier</b>.
        /// </summary>
        URID,

        /// <summary>
        /// <b>EMAL - Email</b>.
        /// </summary>
        EMAL,

        /// <summary>
        /// <b>POST - Postage Charge</b>.
        /// </summary>
        POST,
    }

    /// <summary>
    /// Class <b>StructuredRegulatoryReporting2</b> (Structured Regulatory Reporting 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class StructuredRegulatoryReporting2
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Cd;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Inf;
    }

    /// <summary>
    /// Class <b>RegulatoryAuthority</b> (Regulatory Authority).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class RegulatoryAuthority
    {

        /// <summary>
        /// Element <b>AuthrtyNm</b> (Authority Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string AuthrtyNm;

        /// <summary>
        /// Element <b>AuthrtyCtry</b> (Authority Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string AuthrtyCtry;
    }

    /// <summary>
    /// Class <b>RegulatoryReporting2</b> (Regulatory Reporting 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class RegulatoryReporting2
    {

        /// <summary>
        /// Element <b>DbtCdtRptgInd</b> (Debit Credit Reporting Indicator) of type RegulatoryReportingType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public RegulatoryReportingType1Code DbtCdtRptgInd;

        /// <summary>
        /// Element <b>DbtCdtRptgIndSpecified</b> (Debit Credit Reporting Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DbtCdtRptgIndSpecified;

        /// <summary>
        /// Element <b>Authrty</b> (Authority) of type RegulatoryAuthority.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public RegulatoryAuthority Authrty;

        /// <summary>
        /// Element <b>RgltryDtls</b> (Regulatory Details) of type StructuredRegulatoryReporting2.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public StructuredRegulatoryReporting2 RgltryDtls;
    }

    /// <summary>
    /// Enumeration <b>RegulatoryReportingType1Code</b> (Regulatory Reporting Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public enum RegulatoryReportingType1Code
    {

        /// <summary>
        /// <b>CRED - Borne By Creditor</b>.
        /// </summary>
        CRED,

        /// <summary>
        /// <b>DEBT - Borne By Debtor</b>.
        /// </summary>
        DEBT,

        /// <summary>
        /// <b>BOTH - Both</b>.
        /// </summary>
        BOTH,
    }

    /// <summary>
    /// Class <b>Purpose1Choice</b> (Purpose 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class Purpose1Choice
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01", IncludeInSchema = false )]
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
    /// Class <b>InstructionForNextAgent1</b> (Instruction For Next Agent 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class InstructionForNextAgent1
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type Instruction4Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Instruction4Code Cd;

        /// <summary>
        /// Element <b>CdSpecified</b> (Code Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdSpecified;

        /// <summary>
        /// Element <b>InstrInf</b> (Instruction Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string InstrInf;
    }

    /// <summary>
    /// Enumeration <b>Instruction4Code</b> (Instruction 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public enum Instruction4Code
    {

        /// <summary>
        /// <b>PHOA - Phone Next Agent</b>.
        /// </summary>
        PHOA,

        /// <summary>
        /// <b>TELA - Telecom Next Agent</b>.
        /// </summary>
        TELA,
    }

    /// <summary>
    /// Class <b>InstructionForCreditorAgent1</b> (Instruction For Creditor Agent 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class InstructionForCreditorAgent1
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type Instruction3Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Instruction3Code Cd;

        /// <summary>
        /// Element <b>CdSpecified</b> (Code Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdSpecified;

        /// <summary>
        /// Element <b>InstrInf</b> (Instruction Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string InstrInf;
    }

    /// <summary>
    /// Enumeration <b>Instruction3Code</b> (Instruction 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public enum Instruction3Code
    {

        /// <summary>
        /// <b>CHQB - Pay Creditor By Cheque</b>.
        /// </summary>
        CHQB,

        /// <summary>
        /// <b>HOLD - Hold Cash For Creditor</b>.
        /// </summary>
        HOLD,

        /// <summary>
        /// <b>PHOB - Phone Beneficiary</b>.
        /// </summary>
        PHOB,

        /// <summary>
        /// <b>TELB - Telecom</b>.
        /// </summary>
        TELB,
    }

    /// <summary>
    /// Class <b>ChargesInformation1</b> (Charges Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Class <b>BranchAndFinancialInstitutionIdentification3</b> (Branch And Financial Institution Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01", IncludeInSchema = false )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Class <b>SettlementTimeRequest1</b> (Settlement Time Request 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class SettlementTimeRequest1
    {

        /// <summary>
        /// Element <b>CLSTm</b> (CLSTime) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "time", Order = 0 )]
        public System.DateTime CLSTm;
    }

    /// <summary>
    /// Class <b>SettlementDateTimeIndication1</b> (Settlement Date Time Indication 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class SettlementDateTimeIndication1
    {

        /// <summary>
        /// Element <b>DbtDtTm</b> (Debit Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public System.DateTime DbtDtTm;

        /// <summary>
        /// Element <b>DbtDtTmSpecified</b> (Debit Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DbtDtTmSpecified;

        /// <summary>
        /// Element <b>CdtDtTm</b> (Credit Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CdtDtTm;

        /// <summary>
        /// Element <b>CdtDtTmSpecified</b> (Credit Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdtDtTmSpecified;
    }

    /// <summary>
    /// Class <b>PaymentIdentification2</b> (Payment Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class PaymentIdentification2
    {

        /// <summary>
        /// Element <b>InstrId</b> (Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string InstrId;

        /// <summary>
        /// Element <b>EndToEndId</b> (End To End Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string EndToEndId;

        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string TxId;
    }

    /// <summary>
    /// Class <b>CreditTransferTransactionInformation2</b> (Credit Transfer Transaction Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class CreditTransferTransactionInformation2
    {

        /// <summary>
        /// Element <b>PmtId</b> (Payment Identification) of type PaymentIdentification2.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PaymentIdentification2 PmtId;

        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PaymentTypeInformation3 PmtTpInf;

        /// <summary>
        /// Element <b>IntrBkSttlmAmt</b> (Intr Bank Settlement Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CurrencyAndAmount IntrBkSttlmAmt;

        /// <summary>
        /// Element <b>IntrBkSttlmDt</b> (Intr Bank Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 3 )]
        public System.DateTime IntrBkSttlmDt;

        /// <summary>
        /// Element <b>IntrBkSttlmDtSpecified</b> (Intr Bank Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntrBkSttlmDtSpecified;

        /// <summary>
        /// Element <b>SttlmTmIndctn</b> (Settlement Time Indication) of type SettlementDateTimeIndication1.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public SettlementDateTimeIndication1 SttlmTmIndctn;

        /// <summary>
        /// Element <b>SttlmTmReq</b> (Settlement Time Request) of type SettlementTimeRequest1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public SettlementTimeRequest1 SttlmTmReq;

        /// <summary>
        /// Element <b>AccptncDtTm</b> (Acceptance Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public System.DateTime AccptncDtTm;

        /// <summary>
        /// Element <b>AccptncDtTmSpecified</b> (Acceptance Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AccptncDtTmSpecified;

        /// <summary>
        /// Element <b>PoolgAdjstmntDt</b> (Pooling Adjustment Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 7 )]
        public System.DateTime PoolgAdjstmntDt;

        /// <summary>
        /// Element <b>PoolgAdjstmntDtSpecified</b> (Pooling Adjustment Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PoolgAdjstmntDtSpecified;

        /// <summary>
        /// Element <b>InstdAmt</b> (Instructed Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public CurrencyAndAmount InstdAmt;

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
        /// Element <b>ChrgBr</b> (Charge Bearer) of type ChargeBearerType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public ChargeBearerType1Code ChrgBr;

        /// <summary>
        /// Element <b>ChrgsInf</b> (Charges Information) of type array of ChargesInformation1.
        /// </summary>
        [XmlElementAttribute( "ChrgsInf", Order = 11 )]
        public ChargesInformation1[] ChrgsInf;

        /// <summary>
        /// Element <b>PrvsInstgAgt</b> (Previous Instructing Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public BranchAndFinancialInstitutionIdentification3 PrvsInstgAgt;

        /// <summary>
        /// Element <b>PrvsInstgAgtAcct</b> (Previous Instructing Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 13 )]
        public CashAccount7 PrvsInstgAgtAcct;

        /// <summary>
        /// Element <b>InstgAgt</b> (Instructing Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 14 )]
        public BranchAndFinancialInstitutionIdentification3 InstgAgt;

        /// <summary>
        /// Element <b>InstdAgt</b> (Instructed Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 15 )]
        public BranchAndFinancialInstitutionIdentification3 InstdAgt;

        /// <summary>
        /// Element <b>IntrmyAgt1</b> (Intermediary Agent 1) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt1;

        /// <summary>
        /// Element <b>IntrmyAgt1Acct</b> (Intermediary Agent 1Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 17 )]
        public CashAccount7 IntrmyAgt1Acct;

        /// <summary>
        /// Element <b>IntrmyAgt2</b> (Intermediary Agent 2) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 18 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt2;

        /// <summary>
        /// Element <b>IntrmyAgt2Acct</b> (Intermediary Agent 2Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 19 )]
        public CashAccount7 IntrmyAgt2Acct;

        /// <summary>
        /// Element <b>IntrmyAgt3</b> (Intermediary Agent 3) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 20 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt3;

        /// <summary>
        /// Element <b>IntrmyAgt3Acct</b> (Intermediary Agent 3Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 21 )]
        public CashAccount7 IntrmyAgt3Acct;

        /// <summary>
        /// Element <b>UltmtDbtr</b> (Ultimate Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 22 )]
        public PartyIdentification8 UltmtDbtr;

        /// <summary>
        /// Element <b>InitgPty</b> (Initiating Party) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 23 )]
        public PartyIdentification8 InitgPty;

        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 24 )]
        public PartyIdentification8 Dbtr;

        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 25 )]
        public CashAccount7 DbtrAcct;

        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 26 )]
        public BranchAndFinancialInstitutionIdentification3 DbtrAgt;

        /// <summary>
        /// Element <b>DbtrAgtAcct</b> (Debtor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 27 )]
        public CashAccount7 DbtrAgtAcct;

        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 28 )]
        public BranchAndFinancialInstitutionIdentification3 CdtrAgt;

        /// <summary>
        /// Element <b>CdtrAgtAcct</b> (Creditor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 29 )]
        public CashAccount7 CdtrAgtAcct;

        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 30 )]
        public PartyIdentification8 Cdtr;

        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 31 )]
        public CashAccount7 CdtrAcct;

        /// <summary>
        /// Element <b>UltmtCdtr</b> (Ultimate Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 32 )]
        public PartyIdentification8 UltmtCdtr;

        /// <summary>
        /// Element <b>InstrForCdtrAgt</b> (Instruction For Creditor Agent) of type array of InstructionForCreditorAgent1.
        /// </summary>
        [XmlElementAttribute( "InstrForCdtrAgt", Order = 33 )]
        public InstructionForCreditorAgent1[] InstrForCdtrAgt;

        /// <summary>
        /// Element <b>InstrForNxtAgt</b> (Instruction For Next Agent) of type array of InstructionForNextAgent1.
        /// </summary>
        [XmlElementAttribute( "InstrForNxtAgt", Order = 34 )]
        public InstructionForNextAgent1[] InstrForNxtAgt;

        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type Purpose1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 35 )]
        public Purpose1Choice Purp;

        /// <summary>
        /// Element <b>RgltryRptg</b> (Regulatory Reporting) of type array of RegulatoryReporting2.
        /// </summary>
        [XmlElementAttribute( "RgltryRptg", Order = 36 )]
        public RegulatoryReporting2[] RgltryRptg;

        /// <summary>
        /// Element <b>RltdRmtInf</b> (Related Remittance Information) of type array of RemittanceLocation1.
        /// </summary>
        [XmlElementAttribute( "RltdRmtInf", Order = 37 )]
        public RemittanceLocation1[] RltdRmtInf;

        /// <summary>
        /// Element <b>RmtInf</b> (Remittance Information) of type RemittanceInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 38 )]
        public RemittanceInformation1 RmtInf;
    }

    /// <summary>
    /// Class <b>PaymentTypeInformation3</b> (Payment Type Information 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
    public class PaymentTypeInformation3
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
        /// Element <b>CtgyPurp</b> (Category Purpose) of type PaymentCategoryPurpose1Code.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Class <b>ServiceLevel2Choice</b> (Service Level 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Class <b>LocalInstrument1Choice</b> (Local Instrument 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType2
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
    /// Enumeration <b>PaymentCategoryPurpose1Code</b> (Payment Category Purpose 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Enumeration <b>ChargeBearerType1Code</b> (Charge Bearer Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01", IncludeInSchema = false )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Class <b>ClearingSystemIdentification1Choice</b> (Clearing System Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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
    /// Class <b>SettlementInformation1</b> (Settlement Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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

    /// <summary>
    /// Enumeration <b>SettlementMethod1Code</b> (Settlement Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.008.001.01" )]
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

}
