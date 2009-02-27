
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



namespace i20022.pain00100102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id pain.001.001.02 name CustomerCreditTransferInitiationV02 from Payments Initiation business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>pain00100102</b> (pain 00100102) of type pain00100102.
        /// </summary>
        [XmlElementAttribute("pain.001.001.02", Order=0)]
        public pain00100102 pain00100102;
    }
    
    /// <summary>
    /// Class <b>pain00100102</b> (pain 00100102).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="pain.001.001.02", Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class pain00100102
    {
        
        /// <summary>
        /// Element <b>GrpHdr</b> (Group Header) of type GroupHeader1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public GroupHeader1 GrpHdr;
        
        /// <summary>
        /// Element <b>PmtInf</b> (Payment Information) of type array of PaymentInstructionInformation1.
        /// </summary>
        [XmlElementAttribute("PmtInf", Order=1)]
        public PaymentInstructionInformation1[] PmtInf;
    }
    
    /// <summary>
    /// Class <b>GroupHeader1</b> (Group Header 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class GroupHeader1
    {
        
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CtrlSumSpecified;
        
        /// <summary>
        /// Element <b>Grpg</b> (Grouping) of type Grouping1Code.
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
    /// Enumeration <b>Grouping1Code</b> (Grouping 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public enum Grouping1Code
    {
        
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
    /// Class <b>PartyIdentification8</b> (Party Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class PartyIdentification8
    {
        
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
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class PostalAddress1
    {
        
        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AddressType2Code AdrTp;
        
        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    /// Class <b>CreditorReferenceType1</b> (Creditor Reference Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class CreditorReferenceType1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type DocumentType3Code 
        /// Prtry (Proprietary) of type string 
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
    /// Enumeration <b>DocumentType3Code</b> (Document Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class CreditorReferenceInformation1
    {
        
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
    /// Class <b>ReferredDocumentAmount1Choice</b> (Referred Document Amount 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class ReferredDocumentAmount1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute("CdtNoteAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("DscntApldAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("DuePyblAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("RmtdAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("TaxAmt", typeof(CurrencyAndAmount), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public CurrencyAndAmount Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType5.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class CurrencyAndAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType5</b> (Item Choice Type 5).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType5
    {
        
        /// <summary>
        /// <b>CdtNoteAmt - Credit Note Amount</b>.
        /// </summary>
        CdtNoteAmt,
        
        /// <summary>
        /// <b>DscntApldAmt - Discount Applied Amount</b>.
        /// </summary>
        DscntApldAmt,
        
        /// <summary>
        /// <b>DuePyblAmt - Due Payable Amount</b>.
        /// </summary>
        DuePyblAmt,
        
        /// <summary>
        /// <b>RmtdAmt - Remitted Amount</b>.
        /// </summary>
        RmtdAmt,
        
        /// <summary>
        /// <b>TaxAmt - Tax Amount</b>.
        /// </summary>
        TaxAmt,
    }
    
    /// <summary>
    /// Class <b>ReferredDocumentType1</b> (Referred Document Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class ReferredDocumentType1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type DocumentType2Code 
        /// Prtry (Proprietary) of type string 
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
    /// Enumeration <b>DocumentType2Code</b> (Document Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class ReferredDocumentInformation1
    {
        
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
    /// Class <b>StructuredRemittanceInformation6</b> (Structured Remittance Information 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class StructuredRemittanceInformation6
    {
        
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
        /// Element <b>Invcr</b> (Invoicer) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification8 Invcr;
        
        /// <summary>
        /// Element <b>Invcee</b> (Invoicee) of type PartyIdentification8.
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
    /// Class <b>RemittanceInformation1</b> (Remittance Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class RemittanceInformation1
    {
        
        /// <summary>
        /// Element <b>Ustrd</b> (Unstructured) of type array of string.
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
    /// Class <b>RemittanceLocation1</b> (Remittance Location 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class RemittanceLocation1
    {
        
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
    /// Enumeration <b>RemittanceLocationMethod1Code</b> (Remittance Location Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    /// Class <b>NameAndAddress3</b> (Name And Address 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class NameAndAddress3
    {
        
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
    /// Class <b>TaxType</b> (Tax Type).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class TaxType
    {
        
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
    /// Class <b>TaxDetails</b> (Tax Details).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class TaxDetails
    {
        
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
    /// Class <b>TaxInformation2</b> (Tax Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class TaxInformation2
    {
        
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxDtSpecified;
        
        /// <summary>
        /// Element <b>TaxTpInf</b> (Tax Type Information) of type array of TaxDetails.
        /// </summary>
        [XmlElementAttribute("TaxTpInf", Order=7)]
        public TaxDetails[] TaxTpInf;
    }
    
    /// <summary>
    /// Class <b>StructuredRegulatoryReporting2</b> (Structured Regulatory Reporting 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class StructuredRegulatoryReporting2
    {
        
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
    /// Class <b>RegulatoryAuthority</b> (Regulatory Authority).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class RegulatoryAuthority
    {
        
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
    /// Class <b>RegulatoryReporting2</b> (Regulatory Reporting 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class RegulatoryReporting2
    {
        
        /// <summary>
        /// Element <b>DbtCdtRptgInd</b> (Debit Credit Reporting Indicator) of type RegulatoryReportingType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RegulatoryReportingType1Code DbtCdtRptgInd;
        
        /// <summary>
        /// Element <b>DbtCdtRptgIndSpecified</b> (Debit Credit Reporting Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
    /// Enumeration <b>RegulatoryReportingType1Code</b> (Regulatory Reporting Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class Purpose1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("Cd", typeof(string), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType4</b> (Item Choice Type 4).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType4
    {
        
        /// <summary>
        /// <b>Cd - Code</b>.
        /// </summary>
        Cd,
        
        /// <summary>
        /// <b>Prtry - Proprietary</b>.
        /// </summary>
        Prtry,
    }
    
    /// <summary>
    /// Class <b>InstructionForCreditorAgent1</b> (Instruction For Creditor Agent 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class InstructionForCreditorAgent1
    {
        
        /// <summary>
        /// Element <b>Cd</b> (Code) of type Instruction3Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Instruction3Code Cd;
        
        /// <summary>
        /// Element <b>CdSpecified</b> (Code Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CdSpecified;
        
        /// <summary>
        /// Element <b>InstrInf</b> (Instruction Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string InstrInf;
    }
    
    /// <summary>
    /// Enumeration <b>Instruction3Code</b> (Instruction 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    /// Class <b>ChequeDeliveryMethod1Choice</b> (Cheque Delivery Method 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class ChequeDeliveryMethod1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ChequeDelivery1Code 
        /// Prtry (Proprietary) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ChequeDelivery1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ChequeDelivery1Code</b> (Cheque Delivery 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public enum ChequeDelivery1Code
    {
        
        /// <summary>
        /// <b>MLDB - Mail To Debtor</b>.
        /// </summary>
        MLDB,
        
        /// <summary>
        /// <b>MLCD - Mail To Creditor</b>.
        /// </summary>
        MLCD,
        
        /// <summary>
        /// <b>MLFA - Mail To Final Agent</b>.
        /// </summary>
        MLFA,
        
        /// <summary>
        /// <b>CRDB - Courier To Debtor</b>.
        /// </summary>
        CRDB,
        
        /// <summary>
        /// <b>CRCD - Courier To Creditor</b>.
        /// </summary>
        CRCD,
        
        /// <summary>
        /// <b>CRFA - Courier To Final Agent</b>.
        /// </summary>
        CRFA,
        
        /// <summary>
        /// <b>PUDB - Pick Up By Debtor</b>.
        /// </summary>
        PUDB,
        
        /// <summary>
        /// <b>PUCD - Pick Up By Creditor</b>.
        /// </summary>
        PUCD,
        
        /// <summary>
        /// <b>PUFA - Pick Up By Final Agent</b>.
        /// </summary>
        PUFA,
        
        /// <summary>
        /// <b>RGDB - Registered Mail To Debtor</b>.
        /// </summary>
        RGDB,
        
        /// <summary>
        /// <b>RGCD - Registered Mail To Creditor</b>.
        /// </summary>
        RGCD,
        
        /// <summary>
        /// <b>RGFA - Registered Mail To Final Agent</b>.
        /// </summary>
        RGFA,
    }
    
    /// <summary>
    /// Class <b>Cheque5</b> (Cheque 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class Cheque5
    {
        
        /// <summary>
        /// Element <b>ChqTp</b> (Cheque Type) of type ChequeType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ChequeType2Code ChqTp;
        
        /// <summary>
        /// Element <b>ChqTpSpecified</b> (Cheque Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChqTpSpecified;
        
        /// <summary>
        /// Element <b>ChqNb</b> (Cheque Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string ChqNb;
        
        /// <summary>
        /// Element <b>ChqFr</b> (Cheque From) of type NameAndAddress3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public NameAndAddress3 ChqFr;
        
        /// <summary>
        /// Element <b>DlvryMtd</b> (Delivery Method) of type ChequeDeliveryMethod1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ChequeDeliveryMethod1Choice DlvryMtd;
        
        /// <summary>
        /// Element <b>DlvrTo</b> (Deliver To) of type NameAndAddress3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public NameAndAddress3 DlvrTo;
        
        /// <summary>
        /// Element <b>InstrPrty</b> (Instruction Priority) of type Priority2Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public Priority2Code InstrPrty;
        
        /// <summary>
        /// Element <b>InstrPrtySpecified</b> (Instruction Priority Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstrPrtySpecified;
        
        /// <summary>
        /// Element <b>ChqMtrtyDt</b> (Cheque Maturity Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=6)]
        public System.DateTime ChqMtrtyDt;
        
        /// <summary>
        /// Element <b>ChqMtrtyDtSpecified</b> (Cheque Maturity Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChqMtrtyDtSpecified;
        
        /// <summary>
        /// Element <b>FrmsCd</b> (Forms Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string FrmsCd;
        
        /// <summary>
        /// Element <b>MemoFld</b> (Memo Field) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string MemoFld;
        
        /// <summary>
        /// Element <b>RgnlClrZone</b> (Regional Clearing Zone) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string RgnlClrZone;
        
        /// <summary>
        /// Element <b>PrtLctn</b> (Print Location) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string PrtLctn;
    }
    
    /// <summary>
    /// Enumeration <b>ChequeType2Code</b> (Cheque Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public enum ChequeType2Code
    {
        
        /// <summary>
        /// <b>CCHQ - Customer Cheque</b>.
        /// </summary>
        CCHQ,
        
        /// <summary>
        /// <b>CCCH - Certified Customer Cheque</b>.
        /// </summary>
        CCCH,
        
        /// <summary>
        /// <b>BCHQ - Bank Cheque</b>.
        /// </summary>
        BCHQ,
        
        /// <summary>
        /// <b>DRFT - Draft</b>.
        /// </summary>
        DRFT,
        
        /// <summary>
        /// <b>ELDR - Electronic Draft</b>.
        /// </summary>
        ELDR,
    }
    
    /// <summary>
    /// Enumeration <b>Priority2Code</b> (Priority 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    /// Class <b>ExchangeRateInformation1</b> (Exchange Rate Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class ExchangeRateInformation1
    {
        
        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal XchgRate;
        
        /// <summary>
        /// Element <b>XchgRateSpecified</b> (Exchange Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XchgRateSpecified;
        
        /// <summary>
        /// Element <b>RateTp</b> (Rate Type) of type ExchangeRateType1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ExchangeRateType1Code RateTp;
        
        /// <summary>
        /// Element <b>RateTpSpecified</b> (Rate Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateTpSpecified;
        
        /// <summary>
        /// Element <b>CtrctId</b> (Contract Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CtrctId;
    }
    
    /// <summary>
    /// Enumeration <b>ExchangeRateType1Code</b> (Exchange Rate Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public enum ExchangeRateType1Code
    {
        
        /// <summary>
        /// <b>SPOT - Spot</b>.
        /// </summary>
        SPOT,
        
        /// <summary>
        /// <b>SALE - Sale</b>.
        /// </summary>
        SALE,
        
        /// <summary>
        /// <b>AGRD - Agreed</b>.
        /// </summary>
        AGRD,
    }
    
    /// <summary>
    /// Class <b>EquivalentAmount</b> (Equivalent Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class EquivalentAmount
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>CcyOfTrf</b> (Currency Of Transfer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string CcyOfTrf;
    }
    
    /// <summary>
    /// Class <b>AmountType2Choice</b> (Amount Type 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class AmountType2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// EqvtAmt (Equivalent Amount) of type EquivalentAmount 
        /// InstdAmt (Instructed Amount) of type CurrencyAndAmount 
        /// </summary>
        [XmlElementAttribute("EqvtAmt", typeof(EquivalentAmount), Order=0)]
        [XmlElementAttribute("InstdAmt", typeof(CurrencyAndAmount), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PaymentIdentification1</b> (Payment Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class PaymentIdentification1
    {
        
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
    /// Class <b>CreditTransferTransactionInformation1</b> (Credit Transfer Transaction Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class CreditTransferTransactionInformation1
    {
        
        /// <summary>
        /// Element <b>PmtId</b> (Payment Identification) of type PaymentIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PaymentIdentification1 PmtId;
        
        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PaymentTypeInformation1 PmtTpInf;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type AmountType2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public AmountType2Choice Amt;
        
        /// <summary>
        /// Element <b>XchgRateInf</b> (Exchange Rate Information) of type ExchangeRateInformation1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ExchangeRateInformation1 XchgRateInf;
        
        /// <summary>
        /// Element <b>ChrgBr</b> (Charge Bearer) of type ChargeBearerType1Code.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ChargeBearerType1Code ChrgBr;
        
        /// <summary>
        /// Element <b>ChrgBrSpecified</b> (Charge Bearer Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChrgBrSpecified;
        
        /// <summary>
        /// Element <b>ChqInstr</b> (Cheque Instruction) of type Cheque5.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public Cheque5 ChqInstr;
        
        /// <summary>
        /// Element <b>UltmtDbtr</b> (Ultimate Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification8 UltmtDbtr;
        
        /// <summary>
        /// Element <b>IntrmyAgt1</b> (Intermediary Agent 1) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt1;
        
        /// <summary>
        /// Element <b>IntrmyAgt1Acct</b> (Intermediary Agent 1Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public CashAccount7 IntrmyAgt1Acct;
        
        /// <summary>
        /// Element <b>IntrmyAgt2</b> (Intermediary Agent 2) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt2;
        
        /// <summary>
        /// Element <b>IntrmyAgt2Acct</b> (Intermediary Agent 2Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public CashAccount7 IntrmyAgt2Acct;
        
        /// <summary>
        /// Element <b>IntrmyAgt3</b> (Intermediary Agent 3) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt3;
        
        /// <summary>
        /// Element <b>IntrmyAgt3Acct</b> (Intermediary Agent 3Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public CashAccount7 IntrmyAgt3Acct;
        
        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public BranchAndFinancialInstitutionIdentification3 CdtrAgt;
        
        /// <summary>
        /// Element <b>CdtrAgtAcct</b> (Creditor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public CashAccount7 CdtrAgtAcct;
        
        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public PartyIdentification8 Cdtr;
        
        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public CashAccount7 CdtrAcct;
        
        /// <summary>
        /// Element <b>UltmtCdtr</b> (Ultimate Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public PartyIdentification8 UltmtCdtr;
        
        /// <summary>
        /// Element <b>InstrForCdtrAgt</b> (Instruction For Creditor Agent) of type array of InstructionForCreditorAgent1.
        /// </summary>
        [XmlElementAttribute("InstrForCdtrAgt", Order=18)]
        public InstructionForCreditorAgent1[] InstrForCdtrAgt;
        
        /// <summary>
        /// Element <b>InstrForDbtrAgt</b> (Instruction For Debtor Agent) of type string.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public string InstrForDbtrAgt;
        
        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type Purpose1Choice.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public Purpose1Choice Purp;
        
        /// <summary>
        /// Element <b>RgltryRptg</b> (Regulatory Reporting) of type array of RegulatoryReporting2.
        /// </summary>
        [XmlElementAttribute("RgltryRptg", Order=21)]
        public RegulatoryReporting2[] RgltryRptg;
        
        /// <summary>
        /// Element <b>Tax</b> (Tax) of type TaxInformation2.
        /// </summary>
        [XmlElementAttribute(Order=22)]
        public TaxInformation2 Tax;
        
        /// <summary>
        /// Element <b>RltdRmtInf</b> (Related Remittance Information) of type array of RemittanceLocation1.
        /// </summary>
        [XmlElementAttribute("RltdRmtInf", Order=23)]
        public RemittanceLocation1[] RltdRmtInf;
        
        /// <summary>
        /// Element <b>RmtInf</b> (Remittance Information) of type RemittanceInformation1.
        /// </summary>
        [XmlElementAttribute(Order=24)]
        public RemittanceInformation1 RmtInf;
    }
    
    /// <summary>
    /// Class <b>PaymentTypeInformation1</b> (Payment Type Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class PaymentTypeInformation1
    {
        
        /// <summary>
        /// Element <b>InstrPrty</b> (Instruction Priority) of type Priority2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Priority2Code InstrPrty;
        
        /// <summary>
        /// Element <b>InstrPrtySpecified</b> (Instruction Priority Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstrPrtySpecified;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// ClrChanl (Clearing Channel) of type ClearingChannel2Code 
        /// SvcLvl (Service Level) of type ServiceLevel2Choice 
        /// </summary>
        [XmlElementAttribute("ClrChanl", typeof(ClearingChannel2Code), Order=1)]
        [XmlElementAttribute("SvcLvl", typeof(ServiceLevel2Choice), Order=1)]
        public object Item;
        
        /// <summary>
        /// Element <b>LclInstrm</b> (Local Instrument) of type LocalInstrument1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public LocalInstrument1Choice LclInstrm;
        
        /// <summary>
        /// Element <b>CtgyPurp</b> (Category Purpose) of type PaymentCategoryPurpose1Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PaymentCategoryPurpose1Code CtgyPurp;
        
        /// <summary>
        /// Element <b>CtgyPurpSpecified</b> (Category Purpose Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CtgyPurpSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>ClearingChannel2Code</b> (Clearing Channel 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class ServiceLevel2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ServiceLevel1Code 
        /// Prtry (Proprietary) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ServiceLevel1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ServiceLevel1Code</b> (Service Level 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
        /// <b>PRPT - EBA Priority Service</b>.
        /// </summary>
        PRPT,
    }
    
    /// <summary>
    /// Class <b>LocalInstrument1Choice</b> (Local Instrument 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class LocalInstrument1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("Cd", typeof(string), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>Cd - Code</b>.
        /// </summary>
        Cd,
        
        /// <summary>
        /// <b>Prtry - Proprietary</b>.
        /// </summary>
        Prtry,
    }
    
    /// <summary>
    /// Enumeration <b>PaymentCategoryPurpose1Code</b> (Payment Category Purpose 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
        /// <b>CASH - Cash</b>.
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
        /// <b>SECU - Security Charge / Securities Option</b>.
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
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
    /// Class <b>BranchAndFinancialInstitutionIdentification3</b> (Branch And Financial Institution Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class BranchAndFinancialInstitutionIdentification3
    {
        
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
    /// Class <b>FinancialInstitutionIdentification5Choice</b> (Financial Institution Identification 5Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class FinancialInstitutionIdentification5Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BIC (BIC) of type string 
        /// ClrSysMmbId (Clearing System Member Identification) of type ClearingSystemMemberIdentification3Choice 
        /// CmbndId (Combined Identification) of type FinancialInstitutionIdentification3 
        /// NmAndAdr (Name And Address) of type NameAndAddress7 
        /// PrtryId (Proprietary Identification) of type GenericIdentification3 
        /// </summary>
        [XmlElementAttribute("BIC", typeof(string), Order=0)]
        [XmlElementAttribute("ClrSysMmbId", typeof(ClearingSystemMemberIdentification3Choice), Order=0)]
        [XmlElementAttribute("CmbndId", typeof(FinancialInstitutionIdentification3), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress7), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification3), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>ClearingSystemMemberIdentification3Choice</b> (Clearing System Member Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class ClearingSystemMemberIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("Id", typeof(string), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>Id - Identification</b>.
        /// </summary>
        Id,
        
        /// <summary>
        /// <b>Prtry - Proprietary</b>.
        /// </summary>
        Prtry,
    }
    
    /// <summary>
    /// Class <b>FinancialInstitutionIdentification3</b> (Financial Institution Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class FinancialInstitutionIdentification3
    {
        
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
    /// Class <b>GenericIdentification3</b> (Generic Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class GenericIdentification3
    {
        
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
    /// Class <b>NameAndAddress7</b> (Name And Address 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class NameAndAddress7
    {
        
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
    /// Class <b>BranchData</b> (Branch Data).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class BranchData
    {
        
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
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class CashAccount7
    {
        
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
    /// Class <b>AccountIdentification3Choice</b> (Account Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class AccountIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BBAN (BBAN) of type string 
        /// IBAN (IBAN) of type string 
        /// PrtryAcct (Proprietary Account) of type SimpleIdentificationInformation2 
        /// UPIC (UPIC) of type string 
        /// </summary>
        [XmlElementAttribute("BBAN", typeof(string), Order=0)]
        [XmlElementAttribute("IBAN", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryAcct", typeof(SimpleIdentificationInformation2), Order=0)]
        [XmlElementAttribute("UPIC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation2</b> (Simple Identification Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class SimpleIdentificationInformation2
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>BBAN - Basic Bank Account Number</b>.
        /// </summary>
        BBAN,
        
        /// <summary>
        /// <b>IBAN - International Bank Account Number</b>.
        /// </summary>
        IBAN,
        
        /// <summary>
        /// <b>PrtryAcct - Proprietary Account</b>.
        /// </summary>
        PrtryAcct,
        
        /// <summary>
        /// <b>UPIC - Universal Promotional Identification Code</b>.
        /// </summary>
        UPIC,
    }
    
    /// <summary>
    /// Class <b>CashAccountType2</b> (Cash Account Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class CashAccountType2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CashAccountType4Code 
        /// Prtry (Proprietary) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CashAccountType4Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CashAccountType4Code</b> (Cash Account Type 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public enum CashAccountType4Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
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
    /// Class <b>PaymentInstructionInformation1</b> (Payment Instruction Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class PaymentInstructionInformation1
    {
        
        /// <summary>
        /// Element <b>PmtInfId</b> (Payment Information Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PmtInfId;
        
        /// <summary>
        /// Element <b>PmtMtd</b> (Payment Method) of type PaymentMethod3Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PaymentMethod3Code PmtMtd;
        
        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PaymentTypeInformation1 PmtTpInf;
        
        /// <summary>
        /// Element <b>ReqdExctnDt</b> (Requested Execution Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime ReqdExctnDt;
        
        /// <summary>
        /// Element <b>PoolgAdjstmntDt</b> (Pooling Adjustment Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime PoolgAdjstmntDt;
        
        /// <summary>
        /// Element <b>PoolgAdjstmntDtSpecified</b> (Pooling Adjustment Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PoolgAdjstmntDtSpecified;
        
        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification8 Dbtr;
        
        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public CashAccount7 DbtrAcct;
        
        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public BranchAndFinancialInstitutionIdentification3 DbtrAgt;
        
        /// <summary>
        /// Element <b>DbtrAgtAcct</b> (Debtor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public CashAccount7 DbtrAgtAcct;
        
        /// <summary>
        /// Element <b>UltmtDbtr</b> (Ultimate Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public PartyIdentification8 UltmtDbtr;
        
        /// <summary>
        /// Element <b>ChrgBr</b> (Charge Bearer) of type ChargeBearerType1Code.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public ChargeBearerType1Code ChrgBr;
        
        /// <summary>
        /// Element <b>ChrgBrSpecified</b> (Charge Bearer Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChrgBrSpecified;
        
        /// <summary>
        /// Element <b>ChrgsAcct</b> (Charges Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public CashAccount7 ChrgsAcct;
        
        /// <summary>
        /// Element <b>ChrgsAcctAgt</b> (Charges Account Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public BranchAndFinancialInstitutionIdentification3 ChrgsAcctAgt;
        
        /// <summary>
        /// Element <b>CdtTrfTxInf</b> (Credit Transfer Transaction Information) of type array of CreditTransferTransactionInformation1.
        /// </summary>
        [XmlElementAttribute("CdtTrfTxInf", Order=13)]
        public CreditTransferTransactionInformation1[] CdtTrfTxInf;
    }
    
    /// <summary>
    /// Enumeration <b>PaymentMethod3Code</b> (Payment Method 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public enum PaymentMethod3Code
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
        /// <b>TRA - Transfer Advice</b>.
        /// </summary>
        TRA,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class GenericIdentification4
    {
        
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
    /// Class <b>DateAndPlaceOfBirth</b> (Date And Place Of Birth).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class DateAndPlaceOfBirth
    {
        
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
    /// Class <b>PersonIdentification3</b> (Person Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class PersonIdentification3
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AlnRegnNb (Alien Registration Number) of type string 
        /// CstmrNb (Customer Number) of type string 
        /// DrvrsLicNb (Drivers License Number) of type string 
        /// DtAndPlcOfBirth (Date And Place Of Birth) of type DateAndPlaceOfBirth 
        /// IdntyCardNb (Identity Card Number) of type string 
        /// MplyrIdNb (Employer Identification Number) of type string 
        /// OthrId (Other Identification) of type GenericIdentification4 
        /// PsptNb (Passport Number) of type string 
        /// SclSctyNb (Social Security Number) of type string 
        /// TaxIdNb (Tax Identification Number) of type string 
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
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>AlnRegnNb - Alien Registration Number</b>.
        /// </summary>
        AlnRegnNb,
        
        /// <summary>
        /// <b>CstmrNb - Customer Number</b>.
        /// </summary>
        CstmrNb,
        
        /// <summary>
        /// <b>DrvrsLicNb - Drivers License Number</b>.
        /// </summary>
        DrvrsLicNb,
        
        /// <summary>
        /// <b>DtAndPlcOfBirth - Date And Place Of Birth</b>.
        /// </summary>
        DtAndPlcOfBirth,
        
        /// <summary>
        /// <b>IdntyCardNb - Identity Card Number</b>.
        /// </summary>
        IdntyCardNb,
        
        /// <summary>
        /// <b>MplyrIdNb - Employer Identification Number</b>.
        /// </summary>
        MplyrIdNb,
        
        /// <summary>
        /// <b>OthrId - Other Identification</b>.
        /// </summary>
        OthrId,
        
        /// <summary>
        /// <b>PsptNb - Passport Number</b>.
        /// </summary>
        PsptNb,
        
        /// <summary>
        /// <b>SclSctyNb - Social Security Number</b>.
        /// </summary>
        SclSctyNb,
        
        /// <summary>
        /// <b>TaxIdNb - Tax Identification Number</b>.
        /// </summary>
        TaxIdNb,
    }
    
    /// <summary>
    /// Class <b>OrganisationIdentification2</b> (Organisation Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class OrganisationIdentification2
    {
        
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
        /// Element <b>USCHU</b> (CHIPSUniversalIdentification) of type string.
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
    /// Class <b>Party2Choice</b> (Party 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:pain.001.001.02")]
    public class Party2Choice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// OrgId (Organisation Identification) of type OrganisationIdentification2 
        /// PrvtId (Private Identification) of type PersonIdentification3 
        /// </summary>
        [XmlElementAttribute("OrgId", typeof(OrganisationIdentification2), Order=0)]
        [XmlElementAttribute("PrvtId", typeof(PersonIdentification3), Order=0)]
        public object[] Items;
    }
}
