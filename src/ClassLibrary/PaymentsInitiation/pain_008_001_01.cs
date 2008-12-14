
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

 
namespace i20022.pain00800101 {

    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id pain.008.001.01 name CustomerDirectDebitInitiationV01 from Payments Initiation business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IsNullable=false)]
    public class Document {
        
        /// <summary>
        /// Element <b>pain00800101</b> (0080 01 01) of type pain00800101.
        /// </summary>
        [XmlElementAttribute("pain.008.001.01", Order=0)]
        public pain00800101 pain00800101;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="pain.008.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class pain00800101 {
        
        /// <summary>
        /// Element <b>GrpHdr</b> (Group Header) of type GroupHeader1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public GroupHeader1 GrpHdr;
        
        /// <summary>
        /// Element <b>PmtInf</b> (Payment Information) of type array of PaymentInstructionInformation2.
        /// </summary>
        [XmlElementAttribute("PmtInf", Order=1)]
        public PaymentInstructionInformation2[] PmtInf;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class GroupHeader1 {
        
        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MsgId;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime CreDtTm;
        
        /// <summary>
        /// Element <b>Authstn</b> (Authorisation) of type array of string.
        /// </summary>
        [XmlElementAttribute("Authstn", Order=2)]
        public string[] Authstn;
        
        /// <summary>
        /// Element <b>BtchBookg</b> (Batch Booking) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool BtchBookg;
        
        /// <summary>
        /// Element <b>BtchBookgSpecified</b> (Batch Booking Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BtchBookgSpecified;
        
        /// <summary>
        /// Element <b>NbOfTxs</b> (Number Of Transactions) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string NbOfTxs;
        
        /// <summary>
        /// Element <b>CtrlSum</b> (Control Sum) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public decimal CtrlSum;
        
        /// <summary>
        /// Element <b>CtrlSumSpecified</b> (Control Sum Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CtrlSumSpecified;
        
        /// <summary>
        /// Element <b>Grpg</b> (Grpg) of type Grouping1Code.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public Grouping1Code Grpg;
        
        /// <summary>
        /// Element <b>InitgPty</b> (Initiating Party) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PartyIdentification8 InitgPty;
        
        /// <summary>
        /// Element <b>FwdgAgt</b> (Forwarding Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public BranchAndFinancialInstitutionIdentification3 FwdgAgt;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum Grouping1Code {
        
        /// <summary>
        /// <b>SNGL - Single</b>.
        /// </summary>
        SNGL,
        
        /// <summary>
        /// <b>GRPD - Grouped</b>.
        /// </summary>
        GRPD,
        
        /// <summary>
        /// <b>MIXD - Mixed</b>.
        /// </summary>
        MIXD,
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class PartyIdentification8 {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 PstlAdr;
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type Party2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Party2Choice Id;
        
        /// <summary>
        /// Element <b>CtryOfRes</b> (Country Of Residence) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string CtryOfRes;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class PostalAddress1 {
        
        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AddressType2Code AdrTp;
        
        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdrTpSpecified;
        
        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute("AdrLine", Order=1)]
        public string[] AdrLine;
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string BldgNb;
        
        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string PstCd;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string CtrySubDvsn;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Ctry;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum AddressType2Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class CreditorReferenceType1 {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// Cd of typeDocumentType3Code
        /// Prtry of typestring
        /// </summary>
        [XmlElementAttribute("Cd", typeof(DocumentType3Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Issr;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum DocumentType3Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class CreditorReferenceInformation1 {
        
        /// <summary>
        /// Element <b>CdtrRefTp</b> (Creditor Reference Type) of type CreditorReferenceType1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CreditorReferenceType1 CdtrRefTp;
        
        /// <summary>
        /// Element <b>CdtrRef</b> (Creditor Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string CdtrRef;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class ReferredDocumentAmount1Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute("CdtNoteAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("DscntApldAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("DuePyblAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("RmtdAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("TaxAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public CurrencyAndAmount Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType5.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class CurrencyAndAmount {
        
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
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType5 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class ReferredDocumentType1 {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// Cd of typeDocumentType2Code
        /// Prtry of typestring
        /// </summary>
        [XmlElementAttribute("Cd", typeof(DocumentType2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Issr;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum DocumentType2Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class ReferredDocumentInformation1 {
        
        /// <summary>
        /// Element <b>RfrdDocTp</b> (Referred Document Type) of type ReferredDocumentType1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ReferredDocumentType1 RfrdDocTp;
        
        /// <summary>
        /// Element <b>RfrdDocNb</b> (Referred Document Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string RfrdDocNb;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class StructuredRemittanceInformation6 {
        
        /// <summary>
        /// Element <b>RfrdDocInf</b> (Referred Document Information) of type ReferredDocumentInformation1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ReferredDocumentInformation1 RfrdDocInf;
        
        /// <summary>
        /// Element <b>RfrdDocRltdDt</b> (Referred Document Related Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime RfrdDocRltdDt;
        
        /// <summary>
        /// Element <b>RfrdDocRltdDtSpecified</b> (Referred Document Related Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RfrdDocRltdDtSpecified;
        
        /// <summary>
        /// Element <b>RfrdDocAmt</b> (Referred Document Amount) of type array of ReferredDocumentAmount1Choice.
        /// </summary>
        [XmlElementAttribute("RfrdDocAmt", Order=2)]
        public ReferredDocumentAmount1Choice[] RfrdDocAmt;
        
        /// <summary>
        /// Element <b>CdtrRefInf</b> (Creditor Reference Information) of type CreditorReferenceInformation1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CreditorReferenceInformation1 CdtrRefInf;
        
        /// <summary>
        /// Element <b>Invcr</b> (Invcr) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification8 Invcr;
        
        /// <summary>
        /// Element <b>Invcee</b> (Invcee) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification8 Invcee;
        
        /// <summary>
        /// Element <b>AddtlRmtInf</b> (Additional Remittance Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string AddtlRmtInf;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class RemittanceInformation1 {
        
        /// <summary>
        /// Element <b>Ustrd</b> (Ustrd) of type array of string.
        /// </summary>
        [XmlElementAttribute("Ustrd", Order=0)]
        public string[] Ustrd;
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type array of StructuredRemittanceInformation6.
        /// </summary>
        [XmlElementAttribute("Strd", Order=1)]
        public StructuredRemittanceInformation6[] Strd;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class NameAndAddress3 {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 Adr;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class RemittanceLocation1 {
        
        /// <summary>
        /// Element <b>RmtId</b> (Remittance Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string RmtId;
        
        /// <summary>
        /// Element <b>RmtLctnMtd</b> (Remittance Location Method) of type RemittanceLocationMethod1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public RemittanceLocationMethod1Code RmtLctnMtd;
        
        /// <summary>
        /// Element <b>RmtLctnMtdSpecified</b> (Remittance Location Method Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RmtLctnMtdSpecified;
        
        /// <summary>
        /// Element <b>RmtLctnElctrncAdr</b> (Remittance Location Electronic Address) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string RmtLctnElctrncAdr;
        
        /// <summary>
        /// Element <b>RmtLctnPstlAdr</b> (Remittance Location Postal Address) of type NameAndAddress3.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public NameAndAddress3 RmtLctnPstlAdr;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum RemittanceLocationMethod1Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class TaxType {
        
        /// <summary>
        /// Element <b>CtgyDesc</b> (Category Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string CtgyDesc;
        
        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Rate;
        
        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;
        
        /// <summary>
        /// Element <b>TaxblBaseAmt</b> (Taxable Base Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount TaxblBaseAmt;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CurrencyAndAmount Amt;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class TaxDetails {
        
        /// <summary>
        /// Element <b>CertId</b> (Certificate Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string CertId;
        
        /// <summary>
        /// Element <b>TaxTp</b> (Tax Type) of type TaxType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TaxType TaxTp;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class TaxInformation2 {
        
        /// <summary>
        /// Element <b>CdtrTaxId</b> (Creditor Tax Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string CdtrTaxId;
        
        /// <summary>
        /// Element <b>CdtrTaxTp</b> (Creditor Tax Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string CdtrTaxTp;
        
        /// <summary>
        /// Element <b>DbtrTaxId</b> (Debtor Tax Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string DbtrTaxId;
        
        /// <summary>
        /// Element <b>TaxRefNb</b> (Tax Reference Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string TaxRefNb;
        
        /// <summary>
        /// Element <b>TtlTaxblBaseAmt</b> (Total Taxable Base Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public CurrencyAndAmount TtlTaxblBaseAmt;
        
        /// <summary>
        /// Element <b>TtlTaxAmt</b> (Total Tax Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CurrencyAndAmount TtlTaxAmt;
        
        /// <summary>
        /// Element <b>TaxDt</b> (Tax Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=6)]
        public System.DateTime TaxDt;
        
        /// <summary>
        /// Element <b>TaxDtSpecified</b> (Tax Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxDtSpecified;
        
        /// <summary>
        /// Element <b>TaxTpInf</b> (Tax Type Information) of type array of TaxDetails.
        /// </summary>
        [XmlElementAttribute("TaxTpInf", Order=7)]
        public TaxDetails[] TaxTpInf;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class StructuredRegulatoryReporting2 {
        
        /// <summary>
        /// Element <b>Cd</b> (Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Cd;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Inf;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class RegulatoryAuthority {
        
        /// <summary>
        /// Element <b>AuthrtyNm</b> (Authority Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AuthrtyNm;
        
        /// <summary>
        /// Element <b>AuthrtyCtry</b> (Authority Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AuthrtyCtry;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class RegulatoryReporting2 {
        
        /// <summary>
        /// Element <b>DbtCdtRptgInd</b> (Debit Credit Reporting Indicator) of type RegulatoryReportingType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RegulatoryReportingType1Code DbtCdtRptgInd;
        
        /// <summary>
        /// Element <b>DbtCdtRptgIndSpecified</b> (Debit Credit Reporting Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DbtCdtRptgIndSpecified;
        
        /// <summary>
        /// Element <b>Authrty</b> (Authority) of type RegulatoryAuthority.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public RegulatoryAuthority Authrty;
        
        /// <summary>
        /// Element <b>RgltryDtls</b> (Regulatory Details) of type StructuredRegulatoryReporting2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public StructuredRegulatoryReporting2 RgltryDtls;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum RegulatoryReportingType1Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class Purpose1Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("Cd", typeof(string), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType4 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class AmendmentInformationDetails1 {
        
        /// <summary>
        /// Element <b>OrgnlMndtId</b> (Original Mandate Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string OrgnlMndtId;
        
        /// <summary>
        /// Element <b>OrgnlCdtrSchmeId</b> (Original Creditor Scheme Identification) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification8 OrgnlCdtrSchmeId;
        
        /// <summary>
        /// Element <b>OrgnlCdtrAgt</b> (Original Creditor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public BranchAndFinancialInstitutionIdentification3 OrgnlCdtrAgt;
        
        /// <summary>
        /// Element <b>OrgnlCdtrAgtAcct</b> (Original Creditor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CashAccount7 OrgnlCdtrAgtAcct;
        
        /// <summary>
        /// Element <b>OrgnlDbtr</b> (Original Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification8 OrgnlDbtr;
        
        /// <summary>
        /// Element <b>OrgnlDbtrAcct</b> (Original Debtor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CashAccount7 OrgnlDbtrAcct;
        
        /// <summary>
        /// Element <b>OrgnlDbtrAgt</b> (Original Debtor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public BranchAndFinancialInstitutionIdentification3 OrgnlDbtrAgt;
        
        /// <summary>
        /// Element <b>OrgnlDbtrAgtAcct</b> (Original Debtor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public CashAccount7 OrgnlDbtrAgtAcct;
        
        /// <summary>
        /// Element <b>OrgnlFnlColltnDt</b> (Original Final Collection Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=8)]
        public System.DateTime OrgnlFnlColltnDt;
        
        /// <summary>
        /// Element <b>OrgnlFnlColltnDtSpecified</b> (Original Final Collection Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrgnlFnlColltnDtSpecified;
        
        /// <summary>
        /// Element <b>OrgnlFrqcy</b> (Original Frequency) of type Frequency1Code.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public Frequency1Code OrgnlFrqcy;
        
        /// <summary>
        /// Element <b>OrgnlFrqcySpecified</b> (Original Frequency Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OrgnlFrqcySpecified;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class BranchAndFinancialInstitutionIdentification3 {
        
        /// <summary>
        /// Element <b>FinInstnId</b> (Financial Institution Identification) of type FinancialInstitutionIdentification5Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FinancialInstitutionIdentification5Choice FinInstnId;
        
        /// <summary>
        /// Element <b>BrnchId</b> (Branch Identification) of type BranchData.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public BranchData BrnchId;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class FinancialInstitutionIdentification5Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// BIC of typestring
        /// ClrSysMmbId of typeClearingSystemMemberIdentification3Choice
        /// CmbndId of typeFinancialInstitutionIdentification3
        /// NmAndAdr of typeNameAndAddress7
        /// PrtryId of typeGenericIdentification3
        /// </summary>
        [XmlElementAttribute("BIC", typeof(string), Order=0)]
        [XmlElementAttribute("ClrSysMmbId", typeof(ClearingSystemMemberIdentification3Choice), Order=0)]
        [XmlElementAttribute("CmbndId", typeof(FinancialInstitutionIdentification3), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress7), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification3), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class ClearingSystemMemberIdentification3Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("Id", typeof(string), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class FinancialInstitutionIdentification3 {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
        
        /// <summary>
        /// Element <b>ClrSysMmbId</b> (Clearing System Member Identification) of type ClearingSystemMemberIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ClearingSystemMemberIdentification3Choice ClrSysMmbId;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PostalAddress1 PstlAdr;
        
        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public GenericIdentification3 PrtryId;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class GenericIdentification3 {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class NameAndAddress7 {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 PstlAdr;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class BranchData {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PostalAddress1 PstlAdr;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class CashAccount7 {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification3Choice Id;
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CashAccountType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccountType2 Tp;
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Nm;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class AccountIdentification3Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// BBAN of typestring
        /// IBAN of typestring
        /// PrtryAcct of typeSimpleIdentificationInformation2
        /// UPIC of typestring
        /// </summary>
        [XmlElementAttribute("BBAN", typeof(string), Order=0)]
        [XmlElementAttribute("IBAN", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryAcct", typeof(SimpleIdentificationInformation2), Order=0)]
        [XmlElementAttribute("UPIC", typeof(string), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class SimpleIdentificationInformation2 {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType3 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class CashAccountType2 {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// Cd of typeCashAccountType4Code
        /// Prtry of typestring
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CashAccountType4Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum CashAccountType4Code {
        
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
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum Frequency1Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class MandateRelatedInformation1 {
        
        /// <summary>
        /// Element <b>MndtId</b> (Mandate Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MndtId;
        
        /// <summary>
        /// Element <b>DtOfSgntr</b> (Date Of Signature) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime DtOfSgntr;
        
        /// <summary>
        /// Element <b>DtOfSgntrSpecified</b> (Date Of Signature Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DtOfSgntrSpecified;
        
        /// <summary>
        /// Element <b>AmdmntInd</b> (Amendment Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool AmdmntInd;
        
        /// <summary>
        /// Element <b>AmdmntIndSpecified</b> (Amendment Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AmdmntIndSpecified;
        
        /// <summary>
        /// Element <b>AmdmntInfDtls</b> (Amendment Information Details) of type AmendmentInformationDetails1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public AmendmentInformationDetails1 AmdmntInfDtls;
        
        /// <summary>
        /// Element <b>ElctrncSgntr</b> (Electronic Signature) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string ElctrncSgntr;
        
        /// <summary>
        /// Element <b>FrstColltnDt</b> (First Collection Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime FrstColltnDt;
        
        /// <summary>
        /// Element <b>FrstColltnDtSpecified</b> (First Collection Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FrstColltnDtSpecified;
        
        /// <summary>
        /// Element <b>FnlColltnDt</b> (Final Collection Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=6)]
        public System.DateTime FnlColltnDt;
        
        /// <summary>
        /// Element <b>FnlColltnDtSpecified</b> (Final Collection Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FnlColltnDtSpecified;
        
        /// <summary>
        /// Element <b>Frqcy</b> (Frequency) of type Frequency1Code.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public Frequency1Code Frqcy;
        
        /// <summary>
        /// Element <b>FrqcySpecified</b> (Frequency Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FrqcySpecified;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class DirectDebitTransaction1 {
        
        /// <summary>
        /// Element <b>MndtRltdInf</b> (Mandate Related Information) of type MandateRelatedInformation1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MandateRelatedInformation1 MndtRltdInf;
        
        /// <summary>
        /// Element <b>CdtrSchmeId</b> (Creditor Scheme Identification) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification8 CdtrSchmeId;
        
        /// <summary>
        /// Element <b>PreNtfctnId</b> (Pre Notification Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string PreNtfctnId;
        
        /// <summary>
        /// Element <b>PreNtfctnDt</b> (Pre Notification Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime PreNtfctnDt;
        
        /// <summary>
        /// Element <b>PreNtfctnDtSpecified</b> (Pre Notification Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PreNtfctnDtSpecified;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class PaymentIdentification1 {
        
        /// <summary>
        /// Element <b>InstrId</b> (Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string InstrId;
        
        /// <summary>
        /// Element <b>EndToEndId</b> (End To End Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string EndToEndId;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class DirectDebitTransactionInformation1 {
        
        /// <summary>
        /// Element <b>PmtId</b> (Payment Identification) of type PaymentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PaymentIdentification1 PmtId;
        
        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PaymentTypeInformation2 PmtTpInf;
        
        /// <summary>
        /// Element <b>InstdAmt</b> (Instructed Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount InstdAmt;
        
        /// <summary>
        /// Element <b>ChrgBr</b> (Charge Bearer) of type ChargeBearerType1Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ChargeBearerType1Code ChrgBr;
        
        /// <summary>
        /// Element <b>ChrgBrSpecified</b> (Charge Bearer Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ChrgBrSpecified;
        
        /// <summary>
        /// Element <b>DrctDbtTx</b> (Direct Debit Transaction) of type DirectDebitTransaction1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public DirectDebitTransaction1 DrctDbtTx;
        
        /// <summary>
        /// Element <b>UltmtCdtr</b> (Ultimate Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification8 UltmtCdtr;
        
        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public BranchAndFinancialInstitutionIdentification3 DbtrAgt;
        
        /// <summary>
        /// Element <b>DbtrAgtAcct</b> (Debtor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public CashAccount7 DbtrAgtAcct;
        
        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public PartyIdentification8 Dbtr;
        
        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public CashAccount7 DbtrAcct;
        
        /// <summary>
        /// Element <b>UltmtDbtr</b> (Ultimate Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public PartyIdentification8 UltmtDbtr;
        
        /// <summary>
        /// Element <b>InstrForCdtrAgt</b> (Instruction For Creditor Agent) of type string.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public string InstrForCdtrAgt;
        
        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type Purpose1Choice.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public Purpose1Choice Purp;
        
        /// <summary>
        /// Element <b>RgltryRptg</b> (Regulatory Reporting) of type array of RegulatoryReporting2.
        /// </summary>
        [XmlElementAttribute("RgltryRptg", Order=13)]
        public RegulatoryReporting2[] RgltryRptg;
        
        /// <summary>
        /// Element <b>Tax</b> (Tax) of type TaxInformation2.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public TaxInformation2 Tax;
        
        /// <summary>
        /// Element <b>RltdRmtInf</b> (Related Remittance Information) of type array of RemittanceLocation1.
        /// </summary>
        [XmlElementAttribute("RltdRmtInf", Order=15)]
        public RemittanceLocation1[] RltdRmtInf;
        
        /// <summary>
        /// Element <b>RmtInf</b> (Remittance Information) of type RemittanceInformation1.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public RemittanceInformation1 RmtInf;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class PaymentTypeInformation2 {
        
        /// <summary>
        /// Element <b>InstrPrty</b> (Instruction Priority) of type Priority2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Priority2Code InstrPrty;
        
        /// <summary>
        /// Element <b>InstrPrtySpecified</b> (Instruction Priority Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InstrPrtySpecified;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// ClrChanl of typeClearingChannel2Code
        /// SvcLvl of typeServiceLevel3Choice
        /// </summary>
        [XmlElementAttribute("ClrChanl", typeof(ClearingChannel2Code), Order=1)]
        [XmlElementAttribute("SvcLvl", typeof(ServiceLevel3Choice), Order=1)]
        public object Item;
        
        /// <summary>
        /// Element <b>LclInstrm</b> (Local Instrument) of type LocalInstrument1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public LocalInstrument1Choice LclInstrm;
        
        /// <summary>
        /// Element <b>SeqTp</b> (Sequence Type) of type SequenceType1Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public SequenceType1Code SeqTp;
        
        /// <summary>
        /// Element <b>SeqTpSpecified</b> (Sequence Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SeqTpSpecified;
        
        /// <summary>
        /// Element <b>CtgyPurp</b> (Category Purpose) of type PaymentCategoryPurpose1Code.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PaymentCategoryPurpose1Code CtgyPurp;
        
        /// <summary>
        /// Element <b>CtgyPurpSpecified</b> (Category Purpose Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CtgyPurpSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum Priority2Code {
        
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
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum ClearingChannel2Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class ServiceLevel3Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// Cd of typeServiceLevel2Code
        /// Prtry of typestring
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ServiceLevel2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum ServiceLevel2Code {
        
        /// <summary>
        /// <b>SEPA - Single Euro Payments Area</b>.
        /// </summary>
        SEPA,
        
        /// <summary>
        /// <b>SDVA - Same Day Value</b>.
        /// </summary>
        SDVA,
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class LocalInstrument1Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("Cd", typeof(string), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType2 {
        
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
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum SequenceType1Code {
        
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
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum PaymentCategoryPurpose1Code {
        
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
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum ChargeBearerType1Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class PaymentInstructionInformation2 {
        
        /// <summary>
        /// Element <b>PmtInfId</b> (Payment Information Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PmtInfId;
        
        /// <summary>
        /// Element <b>PmtMtd</b> (Payment Method) of type PaymentMethod2Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PaymentMethod2Code PmtMtd;
        
        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PaymentTypeInformation2 PmtTpInf;
        
        /// <summary>
        /// Element <b>ReqdColltnDt</b> (Requested Collection Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime ReqdColltnDt;
        
        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification8 Cdtr;
        
        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CashAccount7 CdtrAcct;
        
        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public BranchAndFinancialInstitutionIdentification3 CdtrAgt;
        
        /// <summary>
        /// Element <b>CdtrAgtAcct</b> (Creditor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public CashAccount7 CdtrAgtAcct;
        
        /// <summary>
        /// Element <b>UltmtCdtr</b> (Ultimate Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public PartyIdentification8 UltmtCdtr;
        
        /// <summary>
        /// Element <b>ChrgBr</b> (Charge Bearer) of type ChargeBearerType1Code.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public ChargeBearerType1Code ChrgBr;
        
        /// <summary>
        /// Element <b>ChrgBrSpecified</b> (Charge Bearer Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ChrgBrSpecified;
        
        /// <summary>
        /// Element <b>ChrgsAcct</b> (Charges Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public CashAccount7 ChrgsAcct;
        
        /// <summary>
        /// Element <b>ChrgsAcctAgt</b> (Charges Account Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public BranchAndFinancialInstitutionIdentification3 ChrgsAcctAgt;
        
        /// <summary>
        /// Element <b>DrctDbtTxInf</b> (Direct Debit Transaction Information) of type array of DirectDebitTransactionInformation1.
        /// </summary>
        [XmlElementAttribute("DrctDbtTxInf", Order=12)]
        public DirectDebitTransactionInformation1[] DrctDbtTxInf;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public enum PaymentMethod2Code {
        
        /// <summary>
        /// <b>DD - Direct Debit</b>.
        /// </summary>
        DD,
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class GenericIdentification4 {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>IdTp</b> (Identification Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IdTp;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class DateAndPlaceOfBirth {
        
        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime BirthDt;
        
        /// <summary>
        /// Element <b>PrvcOfBirth</b> (Province Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PrvcOfBirth;
        
        /// <summary>
        /// Element <b>CityOfBirth</b> (City Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CityOfBirth;
        
        /// <summary>
        /// Element <b>CtryOfBirth</b> (Country Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string CtryOfBirth;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class PersonIdentification3 {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// AlnRegnNb of typestring
        /// CstmrNb of typestring
        /// DrvrsLicNb of typestring
        /// DtAndPlcOfBirth of typeDateAndPlaceOfBirth
        /// IdntyCardNb of typestring
        /// MplyrIdNb of typestring
        /// OthrId of typeGenericIdentification4
        /// PsptNb of typestring
        /// SclSctyNb of typestring
        /// TaxIdNb of typestring
        /// </summary>
        [XmlElementAttribute("AlnRegnNb", typeof(string), Order=0)]
        [XmlElementAttribute("CstmrNb", typeof(string), Order=0)]
        [XmlElementAttribute("DrvrsLicNb", typeof(string), Order=0)]
        [XmlElementAttribute("DtAndPlcOfBirth", typeof(DateAndPlaceOfBirth), Order=0)]
        [XmlElementAttribute("IdntyCardNb", typeof(string), Order=0)]
        [XmlElementAttribute("MplyrIdNb", typeof(string), Order=0)]
        [XmlElementAttribute("OthrId", typeof(GenericIdentification4), Order=0)]
        [XmlElementAttribute("PsptNb", typeof(string), Order=0)]
        [XmlElementAttribute("SclSctyNb", typeof(string), Order=0)]
        [XmlElementAttribute("TaxIdNb", typeof(string), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class OrganisationIdentification2 {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
        
        /// <summary>
        /// Element <b>IBEI</b> (IBEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IBEI;
        
        /// <summary>
        /// Element <b>BEI</b> (BEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string BEI;
        
        /// <summary>
        /// Element <b>EANGLN</b> (EANGLN) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string EANGLN;
        
        /// <summary>
        /// Element <b>USCHU</b> (USCHU) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string USCHU;
        
        /// <summary>
        /// Element <b>DUNS</b> (DUNS) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string DUNS;
        
        /// <summary>
        /// Element <b>BkPtyId</b> (Bank Party Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string BkPtyId;
        
        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string TaxIdNb;
        
        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public GenericIdentification3 PrtryId;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.008.001.01")]
    public class Party2Choice {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        /// OrgId of typeOrganisationIdentification2
        /// PrvtId of typePersonIdentification3
        /// </summary>
        [XmlElementAttribute("OrgId", typeof(OrganisationIdentification2), Order=0)]
        [XmlElementAttribute("PrvtId", typeof(PersonIdentification3), Order=0)]
        public object[] Items;
    }
}
