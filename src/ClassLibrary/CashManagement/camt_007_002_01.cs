
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



namespace i20022.camt00700201
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.007.002.01 name RequestToModifyPayment from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>camt00700201</b> (camt 00700201) of type camt00700201.
        /// </summary>
        [XmlElementAttribute("camt.007.002.01", Order=0)]
        public camt00700201 camt00700201;
    }
    
    /// <summary>
    /// Class <b>camt00700201</b> (camt 00700201).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="camt.007.002.01", Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class camt00700201
    {
        
        /// <summary>
        /// Element <b>Assgnmt</b> (Assignment) of type CaseAssignment.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CaseAssignment Assgnmt;
        
        /// <summary>
        /// Element <b>Case</b> (Case) of type Case.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Case Case;
        
        /// <summary>
        /// Element <b>Undrlyg</b> (Underlying) of type PaymentInstructionExtract.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PaymentInstructionExtract Undrlyg;
        
        /// <summary>
        /// Element <b>Mod</b> (Modification) of type RequestedModification.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public RequestedModification Mod;
    }
    
    /// <summary>
    /// Class <b>CaseAssignment</b> (Case Assignment).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class CaseAssignment
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Assgnr</b> (Assigner) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Assgnr;
        
        /// <summary>
        /// Element <b>Assgne</b> (Assignee) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Assgne;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>InstructionForFinalAgent</b> (Instruction For Final Agent).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class InstructionForFinalAgent
    {
        
        /// <summary>
        /// Element <b>Cd</b> (Code) of type array of Instruction3Code.
        /// </summary>
        [XmlElementAttribute("Cd", Order=0)]
        public Instruction3Code[] Cd;
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Prtry;
    }
    
    /// <summary>
    /// Enumeration <b>Instruction3Code</b> (Instruction 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
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
    /// Class <b>PurposeChoice</b> (Purpose Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class PurposeChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type PaymentPurpose1Code 
        /// Prtry (Proprietary) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(PaymentPurpose1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>PaymentPurpose1Code</b> (Payment Purpose 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public enum PaymentPurpose1Code
    {
        
        /// <summary>
        /// <b>SALA - Salary Payment</b>.
        /// </summary>
        SALA,
        
        /// <summary>
        /// <b>TREA - Treasury Payment</b>.
        /// </summary>
        TREA,
        
        /// <summary>
        /// <b>ADVA - Advance Payment</b>.
        /// </summary>
        ADVA,
        
        /// <summary>
        /// <b>AGRT - Agricultural Transfer</b>.
        /// </summary>
        AGRT,
        
        /// <summary>
        /// <b>ALMY - Alimony Payment</b>.
        /// </summary>
        ALMY,
        
        /// <summary>
        /// <b>BECH - Child Benefit</b>.
        /// </summary>
        BECH,
        
        /// <summary>
        /// <b>BENE - Unemployment Disability Benefit</b>.
        /// </summary>
        BENE,
        
        /// <summary>
        /// <b>BONU - Bonus Issue / Capitalisation Issue</b>.
        /// </summary>
        BONU,
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CBFF - Capital Building</b>.
        /// </summary>
        CBFF,
        
        /// <summary>
        /// <b>CHAR - Charges</b>.
        /// </summary>
        CHAR,
        
        /// <summary>
        /// <b>COLL - Collection Payment</b>.
        /// </summary>
        COLL,
        
        /// <summary>
        /// <b>CMDT - Commodity Transfer</b>.
        /// </summary>
        CMDT,
        
        /// <summary>
        /// <b>COMC - Commercial Payment</b>.
        /// </summary>
        COMC,
        
        /// <summary>
        /// <b>COMM - Commission</b>.
        /// </summary>
        COMM,
        
        /// <summary>
        /// <b>COST - Costs</b>.
        /// </summary>
        COST,
        
        /// <summary>
        /// <b>CPYR - Copyright</b>.
        /// </summary>
        CPYR,
        
        /// <summary>
        /// <b>DIVI - Dividend In Scope</b>.
        /// </summary>
        DIVI,
        
        /// <summary>
        /// <b>FREX - Foreign Exchange</b>.
        /// </summary>
        FREX,
        
        /// <summary>
        /// <b>GDDS - Purchase Sale Of Goods</b>.
        /// </summary>
        GDDS,
        
        /// <summary>
        /// <b>GOVT - Government Payment</b>.
        /// </summary>
        GOVT,
        
        /// <summary>
        /// <b>IHRP - Instalment Hire Purchase Agreement</b>.
        /// </summary>
        IHRP,
        
        /// <summary>
        /// <b>INTC - Intra Company Payment</b>.
        /// </summary>
        INTC,
        
        /// <summary>
        /// <b>INSU - Insurance Premium</b>.
        /// </summary>
        INSU,
        
        /// <summary>
        /// <b>INTE - Interest</b>.
        /// </summary>
        INTE,
        
        /// <summary>
        /// <b>LICF - License Fee</b>.
        /// </summary>
        LICF,
        
        /// <summary>
        /// <b>LOAN - Loan</b>.
        /// </summary>
        LOAN,
        
        /// <summary>
        /// <b>LOAR - Loan Repayment</b>.
        /// </summary>
        LOAR,
        
        /// <summary>
        /// <b>NETT - Netting</b>.
        /// </summary>
        NETT,
        
        /// <summary>
        /// <b>PAYR - Payroll</b>.
        /// </summary>
        PAYR,
        
        /// <summary>
        /// <b>PENS - Pension Payment</b>.
        /// </summary>
        PENS,
        
        /// <summary>
        /// <b>REFU - Refund</b>.
        /// </summary>
        REFU,
        
        /// <summary>
        /// <b>RENT - Rent</b>.
        /// </summary>
        RENT,
        
        /// <summary>
        /// <b>ROYA - Royalties</b>.
        /// </summary>
        ROYA,
        
        /// <summary>
        /// <b>SCVE - Purchase Sale Of Services</b>.
        /// </summary>
        SCVE,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>SSBE - Social Security Benefit</b>.
        /// </summary>
        SSBE,
        
        /// <summary>
        /// <b>SUBS - Substracted</b>.
        /// </summary>
        SUBS,
        
        /// <summary>
        /// <b>TAXS - Tax Payment</b>.
        /// </summary>
        TAXS,
        
        /// <summary>
        /// <b>VATX - Value Added Tax Payment</b>.
        /// </summary>
        VATX,
        
        /// <summary>
        /// <b>COMT - Consumer Third Party Consolidated Payment</b>.
        /// </summary>
        COMT,
        
        /// <summary>
        /// <b>DBTC - Debit Collection Payment</b>.
        /// </summary>
        DBTC,
        
        /// <summary>
        /// <b>SUPP - Supplier Payment</b>.
        /// </summary>
        SUPP,
        
        /// <summary>
        /// <b>HEDG - Hedge Fund</b>.
        /// </summary>
        HEDG,
    }
    
    /// <summary>
    /// Class <b>ReferredDocumentAmount1Choice</b> (Referred Document Amount 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
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
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01", IncludeInSchema=false)]
    public enum ItemChoiceType3
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
    /// Class <b>StructuredRemittanceInformation2</b> (Structured Remittance Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class StructuredRemittanceInformation2
    {
        
        /// <summary>
        /// Element <b>RfrdDocTp</b> (Referred Document Type) of type DocumentType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentType1Code RfrdDocTp;
        
        /// <summary>
        /// Element <b>RfrdDocTpSpecified</b> (Referred Document Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RfrdDocTpSpecified;
        
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
        /// Element <b>DocRefNb</b> (Document Reference Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DocRefNb;
        
        /// <summary>
        /// Element <b>CdtrRef</b> (Creditor Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string CdtrRef;
        
        /// <summary>
        /// Element <b>Invcr</b> (Invoicer) of type PartyIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification1 Invcr;
        
        /// <summary>
        /// Element <b>Invcee</b> (Invoicee) of type PartyIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification1 Invcee;
    }
    
    /// <summary>
    /// Enumeration <b>DocumentType1Code</b> (Document Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public enum DocumentType1Code
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
        /// <b>RADM - Remittance Advice Message</b>.
        /// </summary>
        RADM,
        
        /// <summary>
        /// <b>RPIN - Related Payment Instruction</b>.
        /// </summary>
        RPIN,
        
        /// <summary>
        /// <b>CMCN - Commercial Contract</b>.
        /// </summary>
        CMCN,
        
        /// <summary>
        /// <b>FXDR - Foreign Exchange Deal Reference</b>.
        /// </summary>
        FXDR,
        
        /// <summary>
        /// <b>SOAC - Statement Of Account</b>.
        /// </summary>
        SOAC,
    }
    
    /// <summary>
    /// Class <b>PartyIdentification1</b> (Party Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class PartyIdentification1
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
        /// Element <b>Id</b> (Identification) of type Party1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Party1Choice Id;
    }
    
    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
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
    /// Class <b>Party1Choice</b> (Party 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class Party1Choice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// OrgId (Organisation Identification) of type NonFinancialInstitutionIdentification1 
        /// PrvtId (Private Identification) of type PersonIdentification2 
        /// </summary>
        [XmlElementAttribute("OrgId", typeof(NonFinancialInstitutionIdentification1), Order=0)]
        [XmlElementAttribute("PrvtId", typeof(PersonIdentification2), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>NonFinancialInstitutionIdentification1</b> (Non Financial Institution Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class NonFinancialInstitutionIdentification1
    {
        
        /// <summary>
        /// Element <b>BEI</b> (BEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BEI;
        
        /// <summary>
        /// Element <b>EANGLN</b> (EANGLN) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string EANGLN;
        
        /// <summary>
        /// Element <b>USCHU</b> (CHIPSUniversalIdentification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string USCHU;
        
        /// <summary>
        /// Element <b>DUNS</b> (DUNS) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DUNS;
        
        /// <summary>
        /// Element <b>BkPtyId</b> (Bank Party Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string BkPtyId;
        
        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string TaxIdNb;
        
        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public GenericIdentification3 PrtryId;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification3</b> (Generic Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
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
    /// Class <b>PersonIdentification2</b> (Person Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class PersonIdentification2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AlnRegnNb (Alien Registration Number) of type string 
        /// DrvrsLicNb (Drivers License Number) of type string 
        /// IdntyCardNb (Identity Card Number) of type string 
        /// MplyrIdNb (Employer Identification Number) of type string 
        /// OthrId (Other Identification) of type GenericIdentification4 
        /// PsptNb (Passport Number) of type string 
        /// SclSctyNb (Social Security Number) of type string 
        /// TaxIdNb (Tax Identification Number) of type string 
        /// </summary>
        [XmlElementAttribute("AlnRegnNb", typeof(string), Order=0)]
        [XmlElementAttribute("DrvrsLicNb", typeof(string), Order=0)]
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
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
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
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>AlnRegnNb - Alien Registration Number</b>.
        /// </summary>
        AlnRegnNb,
        
        /// <summary>
        /// <b>DrvrsLicNb - Drivers License Number</b>.
        /// </summary>
        DrvrsLicNb,
        
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
    /// Class <b>RemittanceInformation3Choice</b> (Remittance Information 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class RemittanceInformation3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type StructuredRemittanceInformation2 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(StructuredRemittanceInformation2), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PaymentSchemeChoice</b> (Payment Scheme Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class PaymentSchemeChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CashClearingSystem2Code 
        /// PrtryInf (Proprietary Information) of type string 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CashClearingSystem2Code), Order=0)]
        [XmlElementAttribute("PrtryInf", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CashClearingSystem2Code</b> (Cash Clearing System 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public enum CashClearingSystem2Code
    {
        
        /// <summary>
        /// <b>RTG - RTGS</b>.
        /// </summary>
        RTG,
        
        /// <summary>
        /// <b>ACH - Automated Clearing House</b>.
        /// </summary>
        ACH,
        
        /// <summary>
        /// <b>CHI - US Chips</b>.
        /// </summary>
        CHI,
        
        /// <summary>
        /// <b>FDN - Fed Net</b>.
        /// </summary>
        FDN,
    }
    
    /// <summary>
    /// Class <b>BranchData</b> (Branch Data).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
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
    /// Class <b>ClearingSystemMemberIdentificationChoice</b> (Clearing System Member Identification Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class ClearingSystemMemberIdentificationChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("ATBLZ", typeof(string), Order=0)]
        [XmlElementAttribute("AUBSBs", typeof(string), Order=0)]
        [XmlElementAttribute("AUBSBx", typeof(string), Order=0)]
        [XmlElementAttribute("CACPA", typeof(string), Order=0)]
        [XmlElementAttribute("CHBC", typeof(string), Order=0)]
        [XmlElementAttribute("CHSIC", typeof(string), Order=0)]
        [XmlElementAttribute("DEBLZ", typeof(string), Order=0)]
        [XmlElementAttribute("ESNCC", typeof(string), Order=0)]
        [XmlElementAttribute("GBSC", typeof(string), Order=0)]
        [XmlElementAttribute("HKNCC", typeof(string), Order=0)]
        [XmlElementAttribute("IENSC", typeof(string), Order=0)]
        [XmlElementAttribute("ITNCC", typeof(string), Order=0)]
        [XmlElementAttribute("NZNCC", typeof(string), Order=0)]
        [XmlElementAttribute("PTNCC", typeof(string), Order=0)]
        [XmlElementAttribute("RUCB", typeof(string), Order=0)]
        [XmlElementAttribute("USCH", typeof(string), Order=0)]
        [XmlElementAttribute("USCHU", typeof(string), Order=0)]
        [XmlElementAttribute("USFW", typeof(string), Order=0)]
        [XmlElementAttribute("ZANCC", typeof(string), Order=0)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>ATBLZ - Austrian Bankleitzahl Identifier</b>.
        /// </summary>
        ATBLZ,
        
        /// <summary>
        /// <b>AUBSBs - Small Network Identifier</b>.
        /// </summary>
        AUBSBs,
        
        /// <summary>
        /// <b>AUBSBx - Extensive Branch Network Identifier</b>.
        /// </summary>
        AUBSBx,
        
        /// <summary>
        /// <b>CACPA - Canadian Payments ARN Identifier</b>.
        /// </summary>
        CACPA,
        
        /// <summary>
        /// <b>CHBC - Swiss BC Identifier</b>.
        /// </summary>
        CHBC,
        
        /// <summary>
        /// <b>CHSIC - Swiss SIC Identifier</b>.
        /// </summary>
        CHSIC,
        
        /// <summary>
        /// <b>DEBLZ - German Bankleitzahl Identifier</b>.
        /// </summary>
        DEBLZ,
        
        /// <summary>
        /// <b>ESNCC - Spanish Domestic Interbanking Identifier</b>.
        /// </summary>
        ESNCC,
        
        /// <summary>
        /// <b>GBSC - UK Domestic Sort Code Identifier</b>.
        /// </summary>
        GBSC,
        
        /// <summary>
        /// <b>HKNCC - Hong Kong Bank Identifier</b>.
        /// </summary>
        HKNCC,
        
        /// <summary>
        /// <b>IENSC - Irish NSC Identifier</b>.
        /// </summary>
        IENSC,
        
        /// <summary>
        /// <b>ITNCC - Italian Domestic Identifier</b>.
        /// </summary>
        ITNCC,
        
        /// <summary>
        /// <b>NZNCC - New Zealand NCC Identifier</b>.
        /// </summary>
        NZNCC,
        
        /// <summary>
        /// <b>PTNCC - Portuguese NCC Identifier</b>.
        /// </summary>
        PTNCC,
        
        /// <summary>
        /// <b>RUCB - Russian Central Bank Identification Code Identifier</b>.
        /// </summary>
        RUCB,
        
        /// <summary>
        /// <b>USCH - CHIPS Participant Identifier</b>.
        /// </summary>
        USCH,
        
        /// <summary>
        /// <b>USCHU - CHIPS Universal Identifier</b>.
        /// </summary>
        USCHU,
        
        /// <summary>
        /// <b>USFW - Fedwire Routing Number Identifier</b>.
        /// </summary>
        USFW,
        
        /// <summary>
        /// <b>ZANCC - South African NCC Identifier</b>.
        /// </summary>
        ZANCC,
    }
    
    /// <summary>
    /// Class <b>FinancialInstitutionIdentification1</b> (Financial Institution Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class FinancialInstitutionIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
        
        /// <summary>
        /// Element <b>ClrSysMmbId</b> (Clearing System Member Identification) of type ClearingSystemMemberIdentificationChoice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ClearingSystemMemberIdentificationChoice ClrSysMmbId;
        
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
    /// Class <b>BranchAndFinancialInstitutionIdentification</b> (Branch And Financial Institution Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class BranchAndFinancialInstitutionIdentification
    {
        
        /// <summary>
        /// Element <b>FinInstnId</b> (Financial Institution Identification) of type FinancialInstitutionIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FinancialInstitutionIdentification1 FinInstnId;
        
        /// <summary>
        /// Element <b>BrnchId</b> (Branch Identification) of type BranchData.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public BranchData BrnchId;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification1Choice</b> (Account Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class AccountIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BBAN (BBAN) of type string 
        /// DmstAcct (Domestic Account) of type SimpleIdentificationInformation 
        /// IBAN (IBAN) of type string 
        /// UPIC (UPIC) of type string 
        /// </summary>
        [XmlElementAttribute("BBAN", typeof(string), Order=0)]
        [XmlElementAttribute("DmstAcct", typeof(SimpleIdentificationInformation), Order=0)]
        [XmlElementAttribute("IBAN", typeof(string), Order=0)]
        [XmlElementAttribute("UPIC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>BBAN - Basic Bank Account Number</b>.
        /// </summary>
        BBAN,
        
        /// <summary>
        /// <b>DmstAcct - Domestic Account</b>.
        /// </summary>
        DmstAcct,
        
        /// <summary>
        /// <b>IBAN - International Bank Account Number</b>.
        /// </summary>
        IBAN,
        
        /// <summary>
        /// <b>UPIC - Universal Promotional Identification Code</b>.
        /// </summary>
        UPIC,
    }
    
    /// <summary>
    /// Class <b>CashAccount3</b> (Cash Account 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class CashAccount3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1Choice Id;
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CashAccountType3Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccountType3Code Tp;
        
        /// <summary>
        /// Element <b>TpSpecified</b> (Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TpSpecified;
        
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
    /// Enumeration <b>CashAccountType3Code</b> (Cash Account Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public enum CashAccountType3Code
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
    }
    
    /// <summary>
    /// Class <b>RequestedModification</b> (Requested Modification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class RequestedModification
    {
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string RltdRef;
        
        /// <summary>
        /// Element <b>BkOprCd</b> (Bank Operation Code) of type SWIFTServiceLevel2Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public SWIFTServiceLevel2Code BkOprCd;
        
        /// <summary>
        /// Element <b>BkOprCdSpecified</b> (Bank Operation Code Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BkOprCdSpecified;
        
        /// <summary>
        /// Element <b>InstrCd</b> (Instruction Code) of type Instruction1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Instruction1Code InstrCd;
        
        /// <summary>
        /// Element <b>InstrCdSpecified</b> (Instruction Code Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstrCdSpecified;
        
        /// <summary>
        /// Element <b>ReqdExctnDt</b> (Requested Execution Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime ReqdExctnDt;
        
        /// <summary>
        /// Element <b>ReqdExctnDtSpecified</b> (Requested Execution Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReqdExctnDtSpecified;
        
        /// <summary>
        /// Element <b>ValDt</b> (Value Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime ValDt;
        
        /// <summary>
        /// Element <b>ValDtSpecified</b> (Value Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValDtSpecified;
        
        /// <summary>
        /// Element <b>IntrBkSttldAmt</b> (Inter Bank Settled Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CurrencyAndAmount IntrBkSttldAmt;
        
        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification1 Dbtr;
        
        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type CashAccount3.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public CashAccount3 DbtrAcct;
        
        /// <summary>
        /// Element <b>IntrmySttlmAgt</b> (Intermediary Settlement Agent) of type BranchAndFinancialInstitutionIdentification.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public BranchAndFinancialInstitutionIdentification IntrmySttlmAgt;
        
        /// <summary>
        /// Element <b>LastSttlmAgt</b> (Last Settlement Agent) of type BranchAndFinancialInstitutionIdentification.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public BranchAndFinancialInstitutionIdentification LastSttlmAgt;
        
        /// <summary>
        /// Element <b>PmtSchme</b> (Payment Scheme) of type PaymentSchemeChoice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public PaymentSchemeChoice PmtSchme;
        
        /// <summary>
        /// Element <b>BnfcryInstnAcct</b> (Beneficiary Institution Account) of type CashAccount3.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public CashAccount3 BnfcryInstnAcct;
        
        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public PartyIdentification1 Cdtr;
        
        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount3.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public CashAccount3 CdtrAcct;
        
        /// <summary>
        /// Element <b>RmtInf</b> (Remittance Information) of type RemittanceInformation3Choice.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public RemittanceInformation3Choice RmtInf;
        
        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type PurposeChoice.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public PurposeChoice Purp;
        
        /// <summary>
        /// Element <b>InstrForFnlAgt</b> (Instruction For Final Agent) of type InstructionForFinalAgent.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public InstructionForFinalAgent InstrForFnlAgt;
        
        /// <summary>
        /// Element <b>DtlsOfChrgs</b> (Details Of Charges) of type ChargeBearer1Code.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public ChargeBearer1Code DtlsOfChrgs;
        
        /// <summary>
        /// Element <b>DtlsOfChrgsSpecified</b> (Details Of Charges Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DtlsOfChrgsSpecified;
        
        /// <summary>
        /// Element <b>SndrToRcvrInf</b> (Sender To Receiver Information) of type array of string.
        /// </summary>
        [XmlElementAttribute("SndrToRcvrInf", Order=18)]
        public string[] SndrToRcvrInf;
    }
    
    /// <summary>
    /// Enumeration <b>SWIFTServiceLevel2Code</b> (SWIFT Service Level 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public enum SWIFTServiceLevel2Code
    {
        
        /// <summary>
        /// <b>SPAY - SWIFTPay</b>.
        /// </summary>
        SPAY,
        
        /// <summary>
        /// <b>SSTD - Standard</b>.
        /// </summary>
        SSTD,
    }
    
    /// <summary>
    /// Enumeration <b>Instruction1Code</b> (Instruction 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public enum Instruction1Code
    {
        
        /// <summary>
        /// <b>PBEN - Pay The Beneficiary</b>.
        /// </summary>
        PBEN,
        
        /// <summary>
        /// <b>TTIL - Time Till</b>.
        /// </summary>
        TTIL,
        
        /// <summary>
        /// <b>TFRO - Time From</b>.
        /// </summary>
        TFRO,
    }
    
    /// <summary>
    /// Enumeration <b>ChargeBearer1Code</b> (Charge Bearer 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public enum ChargeBearer1Code
    {
        
        /// <summary>
        /// <b>OUR - Borne By Debtor</b>.
        /// </summary>
        OUR,
        
        /// <summary>
        /// <b>BEN - Borne By Creditor</b>.
        /// </summary>
        BEN,
        
        /// <summary>
        /// <b>SHA - Shared</b>.
        /// </summary>
        SHA,
    }
    
    /// <summary>
    /// Class <b>PaymentInstructionExtract</b> (Payment Instruction Extract).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class PaymentInstructionExtract
    {
        
        /// <summary>
        /// Element <b>AssgnrInstrId</b> (Assigner Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AssgnrInstrId;
        
        /// <summary>
        /// Element <b>AssgneInstrId</b> (Assignee Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AssgneInstrId;
        
        /// <summary>
        /// Element <b>CcyAmt</b> (Currency Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount CcyAmt;
        
        /// <summary>
        /// Element <b>ValDt</b> (Value Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime ValDt;
        
        /// <summary>
        /// Element <b>ValDtSpecified</b> (Value Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValDtSpecified;
    }
    
    /// <summary>
    /// Class <b>Case</b> (Case).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.007.002.01")]
    public class Case
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Cretr</b> (Creator) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Cretr;
        
        /// <summary>
        /// Element <b>ReopCaseIndctn</b> (Reopen Case Indication) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool ReopCaseIndctn;
        
        /// <summary>
        /// Element <b>ReopCaseIndctnSpecified</b> (Reopen Case Indication Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReopCaseIndctnSpecified;
    }
}
