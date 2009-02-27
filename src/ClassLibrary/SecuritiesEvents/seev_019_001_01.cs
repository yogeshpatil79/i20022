
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



namespace i20022.seev01900101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.019.001.01 name AgentCAMovementInstructionV01 from Securities Events business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AgtCAMvmntInstr</b> (Agent CA Movement Instruction) of type AgentCAMovementInstructionV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AgentCAMovementInstructionV01 AgtCAMvmntInstr;
    }
    
    /// <summary>
    /// Class <b>AgentCAMovementInstructionV01</b> (Agent CA Movement Instruction V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class AgentCAMovementInstructionV01
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification8 Id;
        
        /// <summary>
        /// Element <b>AgtCAElctnAdvcId</b> (Agent CA Election Advice Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DocumentIdentification8 AgtCAElctnAdvcId;
        
        /// <summary>
        /// Element <b>CorpActnGnlInf</b> (Corporate Action General Information) of type CorporateActionInformation1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CorporateActionInformation1 CorpActnGnlInf;
        
        /// <summary>
        /// Element <b>MvmntGnlInf</b> (Movement General Information) of type CorporateActionMovement1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionMovement1 MvmntGnlInf;
        
        /// <summary>
        /// Element <b>UndrlygSctiesMvmntDtls</b> (Underlying Securities Movement Details) of type array of UnderlyingSecurityMovement1.
        /// </summary>
        [XmlElementAttribute("UndrlygSctiesMvmntDtls", Order=4)]
        public UnderlyingSecurityMovement1[] UndrlygSctiesMvmntDtls;
        
        /// <summary>
        /// Element <b>UndrlygCshMvmntDtls</b> (Underlying Cash Movement Details) of type array of CashMovement2.
        /// </summary>
        [XmlElementAttribute("UndrlygCshMvmntDtls", Order=5)]
        public CashMovement2[] UndrlygCshMvmntDtls;
        
        /// <summary>
        /// Element <b>PrcdsMvmntDtls</b> (Proceeds Movement Details) of type ProceedsMovement1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public ProceedsMovement1 PrcdsMvmntDtls;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class DocumentIdentification8
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime CreDtTm;
        
        /// <summary>
        /// Element <b>CreDtTmSpecified</b> (Creation Date Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreDtTmSpecified;
    }
    
    /// <summary>
    /// Class <b>ForeignExchangeTerms9</b> (Foreign Exchange Terms 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class ForeignExchangeTerms9
    {
        
        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string UnitCcy;
        
        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string QtdCcy;
        
        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public decimal XchgRate;
        
        /// <summary>
        /// Element <b>RsltgAmt</b> (Resulting Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount RsltgAmt;
        
        /// <summary>
        /// Element <b>OrgnlAmt</b> (Original Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ActiveCurrencyAndAmount OrgnlAmt;
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class ActiveCurrencyAndAmount
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
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class ActiveCurrencyAnd13DecimalAmount
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
    /// Class <b>PriceValue1</b> (Price Value 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class PriceValue1
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
    }
    
    /// <summary>
    /// Class <b>TaxVoucher1</b> (Tax Voucher 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class TaxVoucher1
    {
        
        /// <summary>
        /// Element <b>TaxVchrRate</b> (Tax Voucher Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal TaxVchrRate;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute("TaxCdt", typeof(ActiveCurrencyAndAmount), Order=1)]
        [XmlElementAttribute("TaxDdctn", typeof(ActiveCurrencyAndAmount), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ActiveCurrencyAndAmount Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
        
        /// <summary>
        /// Element <b>GrssAmt</b> (Gross Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount GrssAmt;
        
        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ActiveCurrencyAndAmount NetAmt;
        
        /// <summary>
        /// Element <b>RcrdDtHldg</b> (Record Date Holding) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public UnitOrFaceAmount1Choice RcrdDtHldg;
        
        /// <summary>
        /// Element <b>TaxCdtRate</b> (Tax Credit Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public decimal TaxCdtRate;
        
        /// <summary>
        /// Element <b>TaxCdtRateSpecified</b> (Tax Credit Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxCdtRateSpecified;
        
        /// <summary>
        /// Element <b>WhldgTaxAmt</b> (Withholding Tax Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public ActiveCurrencyAndAmount WhldgTaxAmt;
        
        /// <summary>
        /// Element <b>WhldgTaxRate</b> (Withholding Tax Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public decimal WhldgTaxRate;
        
        /// <summary>
        /// Element <b>WhldgTaxRateSpecified</b> (Withholding Tax Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WhldgTaxRateSpecified;
        
        /// <summary>
        /// Element <b>ScripDvddRinvstmtPricPerShr</b> (Scrip Dividend Reinvestment Price Per Share) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public PriceValue1 ScripDvddRinvstmtPricPerShr;
        
        /// <summary>
        /// Element <b>CshAmtBrghtFwd</b> (Cash Amount Brought Forward) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public ActiveCurrencyAndAmount CshAmtBrghtFwd;
        
        /// <summary>
        /// Element <b>AlltdShrsCost</b> (Alloted Shares Cost) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public PriceValue1 AlltdShrsCost;
        
        /// <summary>
        /// Element <b>CshAmtCrrdFwd</b> (Cash Amount Carried Forward) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public ActiveCurrencyAndAmount CshAmtCrrdFwd;
        
        /// <summary>
        /// Element <b>NtnlTax</b> (Notional Tax) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public ActiveCurrencyAndAmount NtnlTax;
        
        /// <summary>
        /// Element <b>NtnlDvddPybl</b> (Notional Dividend Payable) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public ActiveCurrencyAndAmount NtnlDvddPybl;
        
        /// <summary>
        /// Element <b>BrgnDt</b> (Bargain Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=15)]
        public System.DateTime BrgnDt;
        
        /// <summary>
        /// Element <b>BrgnDtSpecified</b> (Bargain Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrgnDtSpecified;
        
        /// <summary>
        /// Element <b>BrgnSttlmDt</b> (Bargain Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=16)]
        public System.DateTime BrgnSttlmDt;
        
        /// <summary>
        /// Element <b>BrgnSttlmDtSpecified</b> (Bargain Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrgnSttlmDtSpecified;
        
        /// <summary>
        /// Element <b>StmpDtyAmt</b> (Stamp Duty Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public ActiveCurrencyAndAmount StmpDtyAmt;
        
        /// <summary>
        /// Element <b>ChrgAmt</b> (Charge Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public ActiveCurrencyAndAmount ChrgAmt;
        
        /// <summary>
        /// Element <b>ComssnAmt</b> (Commission Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public ActiveCurrencyAndAmount ComssnAmt;
        
        /// <summary>
        /// Element <b>FXDtls</b> (ForeignExchange Details) of type ForeignExchangeTerms9.
        /// </summary>
        [XmlElementAttribute(Order=20)]
        public ForeignExchangeTerms9 FXDtls;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>TaxCdt - Tax Credit</b>.
        /// </summary>
        TaxCdt,
        
        /// <summary>
        /// <b>TaxDdctn - Tax Deduction</b>.
        /// </summary>
        TaxDdctn,
    }
    
    /// <summary>
    /// Class <b>UnitOrFaceAmount1Choice</b> (Unit Or Face Amount 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class UnitOrFaceAmount1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// FaceAmt (Face Amount) of type ActiveCurrencyAndAmount 
        /// Unit (Unit) of type decimal 
        /// </summary>
        [XmlElementAttribute("FaceAmt", typeof(ActiveCurrencyAndAmount), Order=0)]
        [XmlElementAttribute("Unit", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>SecuritiesBalanceType9FormatChoice</b> (Securities Balance Type 9Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class SecuritiesBalanceType9FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type SecuritiesBalanceType9Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(SecuritiesBalanceType9Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>SecuritiesBalanceType9Code</b> (Securities Balance Type 9Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum SecuritiesBalanceType9Code
    {
        
        /// <summary>
        /// <b>AVLB - ?undefined?</b>.
        /// </summary>
        AVLB,
        
        /// <summary>
        /// <b>ELEC - Electronic Certification</b>.
        /// </summary>
        ELEC,
        
        /// <summary>
        /// <b>UNEL - ?undefined?</b>.
        /// </summary>
        UNEL,
        
        /// <summary>
        /// <b>RDIS - ?undefined?</b>.
        /// </summary>
        RDIS,
        
        /// <summary>
        /// <b>RREM - ?undefined?</b>.
        /// </summary>
        RREM,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification13</b> (Generic Identification 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class GenericIdentification13
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>SecuritiesAccount10</b> (Securities Account 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class SecuritiesAccount10
    {
        
        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CreditDebitCode CdtDbtInd;
        
        /// <summary>
        /// Element <b>AcctOwnrId</b> (Account Owner Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice AcctOwnrId;
        
        /// <summary>
        /// Element <b>AcctOwnrNtlty</b> (Account Owner Nationality) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AcctOwnrNtlty;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string AcctId;
        
        /// <summary>
        /// Element <b>BalTp</b> (Balance Type) of type SecuritiesBalanceType9FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public SecuritiesBalanceType9FormatChoice BalTp;
        
        /// <summary>
        /// Element <b>SctyHldgForm</b> (Security Holding Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FormOfSecurity1Code SctyHldgForm;
        
        /// <summary>
        /// Element <b>SctyHldgFormSpecified</b> (Security Holding Form Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SctyHldgFormSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>CreditDebitCode</b> (Credit Debit Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum CreditDebitCode
    {
        
        /// <summary>
        /// <b>CRDT - Credit Card</b>.
        /// </summary>
        CRDT,
        
        /// <summary>
        /// <b>DBIT - Debit Card</b>.
        /// </summary>
        DBIT,
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class PartyIdentification2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class NameAndAddress5
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
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
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
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class GenericIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum FormOfSecurity1Code
    {
        
        /// <summary>
        /// <b>BEAR - Bearer Share Exchange</b>.
        /// </summary>
        BEAR,
        
        /// <summary>
        /// <b>REGD - Registered / Registered Share Exchange</b>.
        /// </summary>
        REGD,
    }
    
    /// <summary>
    /// Class <b>SecuritiesProceeds1</b> (Securities Proceeds 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class SecuritiesProceeds1
    {
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification7 SctyId;
        
        /// <summary>
        /// Element <b>PstngQty</b> (Posting Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public UnitOrFaceAmount1Choice PstngQty;
        
        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type array of SecuritiesAccount10.
        /// </summary>
        [XmlElementAttribute("AcctDtls", Order=2)]
        public SecuritiesAccount10[] AcctDtls;
        
        /// <summary>
        /// Element <b>RcncltnDtls</b> (Reconciliation Details) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string RcncltnDtls;
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification7</b> (Security Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class SecurityIdentification7
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// ISIN (ISIN) of type string 
        /// OthrId (Other Identification) of type AlternateSecurityIdentification3 
        /// </summary>
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("OthrId", typeof(AlternateSecurityIdentification3), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Desc;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification3</b> (Alternate Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class AlternateSecurityIdentification3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("DmstIdSrc", typeof(string), Order=1)]
        [XmlElementAttribute("PrtryIdSrc", typeof(string), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>DmstIdSrc - Domestic Identification Source</b>.
        /// </summary>
        DmstIdSrc,
        
        /// <summary>
        /// <b>PrtryIdSrc - Proprietary Identification Source</b>.
        /// </summary>
        PrtryIdSrc,
    }
    
    /// <summary>
    /// Class <b>CashProceeds1</b> (Cash Proceeds 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CashProceeds1
    {
        
        /// <summary>
        /// Element <b>PstngAmt</b> (Posting Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAndAmount PstngAmt;
        
        /// <summary>
        /// Element <b>RcncltnDtls</b> (Reconciliation Details) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string RcncltnDtls;
        
        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type array of CashAccount19.
        /// </summary>
        [XmlElementAttribute("AcctDtls", Order=2)]
        public CashAccount19[] AcctDtls;
    }
    
    /// <summary>
    /// Class <b>CashAccount19</b> (Cash Account 19).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CashAccount19
    {
        
        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CreditDebitCode CdtDbtInd;
        
        /// <summary>
        /// Element <b>AcctOwnrId</b> (Account Owner Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice AcctOwnrId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public AccountIdentification2Choice AcctId;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification2Choice</b> (Account Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class AccountIdentification2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("CshAcctId", typeof(string), Order=0)]
        [XmlElementAttribute("SctiesAcctId", typeof(string), Order=0)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>CshAcctId - Cash Account Identification</b>.
        /// </summary>
        CshAcctId,
        
        /// <summary>
        /// <b>SctiesAcctId - Securities Account Identification</b>.
        /// </summary>
        SctiesAcctId,
    }
    
    /// <summary>
    /// Class <b>ProceedsMovement1</b> (Proceeds Movement 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class ProceedsMovement1
    {
        
        /// <summary>
        /// Element <b>CshPrcdsMvmntDtls</b> (Cash Proceeds Movement Details) of type array of CashProceeds1.
        /// </summary>
        [XmlElementAttribute("CshPrcdsMvmntDtls", Order=0)]
        public CashProceeds1[] CshPrcdsMvmntDtls;
        
        /// <summary>
        /// Element <b>SctiesPrcdsMvmntDtls</b> (Securities Proceeds Movement Details) of type array of SecuritiesProceeds1.
        /// </summary>
        [XmlElementAttribute("SctiesPrcdsMvmntDtls", Order=1)]
        public SecuritiesProceeds1[] SctiesPrcdsMvmntDtls;
        
        /// <summary>
        /// Element <b>TaxDtls</b> (Tax Details) of type TaxVoucher1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TaxVoucher1 TaxDtls;
    }
    
    /// <summary>
    /// Class <b>CashMovement2</b> (Cash Movement 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CashMovement2
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type array of CashAccount19.
        /// </summary>
        [XmlElementAttribute("AcctDtls", Order=1)]
        public CashAccount19[] AcctDtls;
    }
    
    /// <summary>
    /// Class <b>StampDutyType1FormatChoice</b> (Stamp Duty Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class StampDutyType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type StampDutyType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(StampDutyType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>StampDutyType1Code</b> (Stamp Duty Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum StampDutyType1Code
    {
        
        /// <summary>
        /// <b>SDRU - ?undefined?</b>.
        /// </summary>
        SDRU,
        
        /// <summary>
        /// <b>SDRT - ?undefined?</b>.
        /// </summary>
        SDRT,
        
        /// <summary>
        /// <b>SDRN - ?undefined?</b>.
        /// </summary>
        SDRN,
        
        /// <summary>
        /// <b>SDRQ - ?undefined?</b>.
        /// </summary>
        SDRQ,
    }
    
    /// <summary>
    /// Class <b>SecuritiesBalanceType10FormatChoice</b> (Securities Balance Type 10 Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class SecuritiesBalanceType10FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type SecuritiesBalanceType10Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(SecuritiesBalanceType10Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>SecuritiesBalanceType10Code</b> (Securities Balance Type 10 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum SecuritiesBalanceType10Code
    {
        
        /// <summary>
        /// <b>AVLB - ?undefined?</b>.
        /// </summary>
        AVLB,
        
        /// <summary>
        /// <b>REST - ?undefined?</b>.
        /// </summary>
        REST,
        
        /// <summary>
        /// <b>RDIS - ?undefined?</b>.
        /// </summary>
        RDIS,
        
        /// <summary>
        /// <b>RREM - ?undefined?</b>.
        /// </summary>
        RREM,
    }
    
    /// <summary>
    /// Class <b>SecuritiesAccount8</b> (Securities Account 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class SecuritiesAccount8
    {
        
        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CreditDebitCode CdtDbtInd;
        
        /// <summary>
        /// Element <b>AcctOwnrId</b> (Account Owner Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice AcctOwnrId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AcctId;
        
        /// <summary>
        /// Element <b>BalTp</b> (Balance Type) of type SecuritiesBalanceType10FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public SecuritiesBalanceType10FormatChoice BalTp;
        
        /// <summary>
        /// Element <b>OptnTp</b> (Option Type) of type CorporateActionOption1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public CorporateActionOption1FormatChoice OptnTp;
        
        /// <summary>
        /// Element <b>OptnNb</b> (Option Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string OptnNb;
        
        /// <summary>
        /// Element <b>SctyHldgForm</b> (Security Holding Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public FormOfSecurity1Code SctyHldgForm;
        
        /// <summary>
        /// Element <b>SctyHldgFormSpecified</b> (Security Holding Form Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SctyHldgFormSpecified;
        
        /// <summary>
        /// Element <b>StmpDty</b> (Stamp Duty) of type StampDutyType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public StampDutyType1FormatChoice StmpDty;
    }
    
    /// <summary>
    /// Class <b>CorporateActionOption1FormatChoice</b> (Corporate Action Option 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CorporateActionOption1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionOptionType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionOptionType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionOptionType1Code</b> (Corporate Action Option Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum CorporateActionOptionType1Code
    {
        
        /// <summary>
        /// <b>BSPL - Bonus Share Plan</b>.
        /// </summary>
        BSPL,
        
        /// <summary>
        /// <b>BUYA - Buy Up</b>.
        /// </summary>
        BUYA,
        
        /// <summary>
        /// <b>CASE - Cash and Securities</b>.
        /// </summary>
        CASE,
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CEXC - Consent and Exchange</b>.
        /// </summary>
        CEXC,
        
        /// <summary>
        /// <b>CTEN - Consent and Tender</b>.
        /// </summary>
        CTEN,
        
        /// <summary>
        /// <b>CONN - Consent Denied</b>.
        /// </summary>
        CONN,
        
        /// <summary>
        /// <b>CONY - Consent Granted</b>.
        /// </summary>
        CONY,
        
        /// <summary>
        /// <b>EXER - Exercise</b>.
        /// </summary>
        EXER,
        
        /// <summary>
        /// <b>LAPS - Lapse</b>.
        /// </summary>
        LAPS,
        
        /// <summary>
        /// <b>MPUT - Retain</b>.
        /// </summary>
        MPUT,
        
        /// <summary>
        /// <b>NOAC - No Action</b>.
        /// </summary>
        NOAC,
        
        /// <summary>
        /// <b>OFFR - Offer / Proposed Rate</b>.
        /// </summary>
        OFFR,
        
        /// <summary>
        /// <b>OVER - Normal Processing Period Lapsed / Oversubscribe</b>.
        /// </summary>
        OVER,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>SLLE - Sell Entitlement</b>.
        /// </summary>
        SLLE,
        
        /// <summary>
        /// <b>SPLI - Split Instruction</b>.
        /// </summary>
        SPLI,
        
        /// <summary>
        /// <b>NOQU - Non Qualified Investor</b>.
        /// </summary>
        NOQU,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>QINV - Qualified Investor</b>.
        /// </summary>
        QINV,
    }
    
    /// <summary>
    /// Class <b>UnderlyingSecurityMovement1</b> (Underlying Security Movement 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class UnderlyingSecurityMovement1
    {
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification7 SctyId;
        
        /// <summary>
        /// Element <b>SctiesQty</b> (Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public UnitOrFaceAmount1Choice SctiesQty;
        
        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type array of SecuritiesAccount8.
        /// </summary>
        [XmlElementAttribute("AcctDtls", Order=2)]
        public SecuritiesAccount8[] AcctDtls;
    }
    
    /// <summary>
    /// Class <b>CorporateActionMovement1</b> (Corporate Action Movement 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CorporateActionMovement1
    {
        
        /// <summary>
        /// Element <b>OrdrTp</b> (Order Type) of type DistributionInstructionType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DistributionInstructionType1Code OrdrTp;
        
        /// <summary>
        /// Element <b>HghPrtyInd</b> (High Priority Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool HghPrtyInd;
        
        /// <summary>
        /// Element <b>OptnNb</b> (Option Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string OptnNb;
        
        /// <summary>
        /// Element <b>OptnTp</b> (Option Type) of type CorporateActionOption1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionOption1FormatChoice OptnTp;
        
        /// <summary>
        /// Element <b>ReqdExctnDt</b> (Requested Execution Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime ReqdExctnDt;
        
        /// <summary>
        /// Element <b>AcctOwnrId</b> (Account Owner Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification2Choice AcctOwnrId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string AcctId;
        
        /// <summary>
        /// Element <b>ConfdBalSctiesQty</b> (Confirmed Balance Securities Quantity) of type UnitOrFaceAmount1Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public UnitOrFaceAmount1Choice ConfdBalSctiesQty;
    }
    
    /// <summary>
    /// Enumeration <b>DistributionInstructionType1Code</b> (Distribution Instruction Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum DistributionInstructionType1Code
    {
        
        /// <summary>
        /// <b>GDEB - ?undefined?</b>.
        /// </summary>
        GDEB,
        
        /// <summary>
        /// <b>IDEB - ?undefined?</b>.
        /// </summary>
        IDEB,
        
        /// <summary>
        /// <b>GRET - ?undefined?</b>.
        /// </summary>
        GRET,
        
        /// <summary>
        /// <b>CHAN - Change</b>.
        /// </summary>
        CHAN,
        
        /// <summary>
        /// <b>IRET - ?undefined?</b>.
        /// </summary>
        IRET,
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentDescription3</b> (Financial Instrument Description 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class FinancialInstrumentDescription3
    {
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification7 SctyId;
        
        /// <summary>
        /// Element <b>PlcOfListg</b> (Place Of Listing) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PlcOfListg;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice SfkpgPlc;
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventProcessingType1FormatChoice</b> (Corporate Action Event Processing Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CorporateActionEventProcessingType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionEventProcessingType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionEventProcessingType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventProcessingType1Code</b> (Corporate Action Event Processing Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum CorporateActionEventProcessingType1Code
    {
        
        /// <summary>
        /// <b>GENL - General</b>.
        /// </summary>
        GENL,
        
        /// <summary>
        /// <b>DISN - CA Results in a Distribution</b>.
        /// </summary>
        DISN,
        
        /// <summary>
        /// <b>REOR - CA Results in a Reorganisation</b>.
        /// </summary>
        REOR,
    }
    
    /// <summary>
    /// Class <b>CorporateActionMandatoryVoluntary1FormatChoice</b> (Corporate Action Mandatory Voluntary 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CorporateActionMandatoryVoluntary1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionMandatoryVoluntary1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionMandatoryVoluntary1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionMandatoryVoluntary1Code</b> (Corporate Action Mandatory Voluntary 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum CorporateActionMandatoryVoluntary1Code
    {
        
        /// <summary>
        /// <b>MAND - Mandatory CA Event; No Instruction Required</b>.
        /// </summary>
        MAND,
        
        /// <summary>
        /// <b>CHOS - Mandatory CA Event; Instruction Required</b>.
        /// </summary>
        CHOS,
        
        /// <summary>
        /// <b>VOLU - Voluntary CA Event; Instruction Required to Participate</b>.
        /// </summary>
        VOLU,
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventType2FormatChoice</b> (Corporate Action Event Type 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CorporateActionEventType2FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionEventType2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionEventType2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventType2Code</b> (Corporate Action Event Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public enum CorporateActionEventType2Code
    {
        
        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,
        
        /// <summary>
        /// <b>ATTI - Attachment</b>.
        /// </summary>
        ATTI,
        
        /// <summary>
        /// <b>BIDS - Repurchase Offer/Issuer Bid/Reverse Rights</b>.
        /// </summary>
        BIDS,
        
        /// <summary>
        /// <b>BONU - Bonus Issue / Capitalisation Issue</b>.
        /// </summary>
        BONU,
        
        /// <summary>
        /// <b>BPUT - Put Redemption</b>.
        /// </summary>
        BPUT,
        
        /// <summary>
        /// <b>BRUP - Bankruptcy</b>.
        /// </summary>
        BRUP,
        
        /// <summary>
        /// <b>CAPG - Capital Gains Distribution</b>.
        /// </summary>
        CAPG,
        
        /// <summary>
        /// <b>CAPI - ?undefined?</b>.
        /// </summary>
        CAPI,
        
        /// <summary>
        /// <b>CERT - Certificate required / Non-US TEFRA D Certification</b>.
        /// </summary>
        CERT,
        
        /// <summary>
        /// <b>CHAN - Change</b>.
        /// </summary>
        CHAN,
        
        /// <summary>
        /// <b>CLSA - Class Action/Proposed Settlement</b>.
        /// </summary>
        CLSA,
        
        /// <summary>
        /// <b>CONS - Consent</b>.
        /// </summary>
        CONS,
        
        /// <summary>
        /// <b>CONV - Convert / Conversion</b>.
        /// </summary>
        CONV,
        
        /// <summary>
        /// <b>COOP - Company Option</b>.
        /// </summary>
        COOP,
        
        /// <summary>
        /// <b>DECR - Decrease In Value</b>.
        /// </summary>
        DECR,
        
        /// <summary>
        /// <b>DETI - Detachment</b>.
        /// </summary>
        DETI,
        
        /// <summary>
        /// <b>DFLT - Bond Default</b>.
        /// </summary>
        DFLT,
        
        /// <summary>
        /// <b>DLST - Delisted</b>.
        /// </summary>
        DLST,
        
        /// <summary>
        /// <b>DRAW - Drawn</b>.
        /// </summary>
        DRAW,
        
        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
        
        /// <summary>
        /// <b>DSCL - Disclosure</b>.
        /// </summary>
        DSCL,
        
        /// <summary>
        /// <b>DTCH - Dutch Auction</b>.
        /// </summary>
        DTCH,
        
        /// <summary>
        /// <b>DVCA - Cash Dividend</b>.
        /// </summary>
        DVCA,
        
        /// <summary>
        /// <b>DVOP - Dividend Option</b>.
        /// </summary>
        DVOP,
        
        /// <summary>
        /// <b>DVSC - Scrip Dividend/Payment</b>.
        /// </summary>
        DVSC,
        
        /// <summary>
        /// <b>DVSE - Stock Dividend</b>.
        /// </summary>
        DVSE,
        
        /// <summary>
        /// <b>EXOF - Exchange Offer</b>.
        /// </summary>
        EXOF,
        
        /// <summary>
        /// <b>EXRI - Call On Rights</b>.
        /// </summary>
        EXRI,
        
        /// <summary>
        /// <b>EXTM - Maturity Extension</b>.
        /// </summary>
        EXTM,
        
        /// <summary>
        /// <b>EXWA - Warrant Exercise</b>.
        /// </summary>
        EXWA,
        
        /// <summary>
        /// <b>INCR - Increase in Value</b>.
        /// </summary>
        INCR,
        
        /// <summary>
        /// <b>INTR - Intermediary / Interest Payment</b>.
        /// </summary>
        INTR,
        
        /// <summary>
        /// <b>LIQU - Liquidation</b>.
        /// </summary>
        LIQU,
        
        /// <summary>
        /// <b>MCAL - Full Call/Early Redemption</b>.
        /// </summary>
        MCAL,
        
        /// <summary>
        /// <b>MRGR - Merger</b>.
        /// </summary>
        MRGR,
        
        /// <summary>
        /// <b>ODLT - Odd Lot Sale/Purchase</b>.
        /// </summary>
        ODLT,
        
        /// <summary>
        /// <b>PARI - Pari Passu</b>.
        /// </summary>
        PARI,
        
        /// <summary>
        /// <b>PCAL - Partial Redemption With Reduction of Nominal Value</b>.
        /// </summary>
        PCAL,
        
        /// <summary>
        /// <b>PDEF - Partial Defeasance/Pre-funding</b>.
        /// </summary>
        PDEF,
        
        /// <summary>
        /// <b>PINK - Pay In Kind</b>.
        /// </summary>
        PINK,
        
        /// <summary>
        /// <b>PLAC - Place of Incorporation</b>.
        /// </summary>
        PLAC,
        
        /// <summary>
        /// <b>PPMT - Instalment Call</b>.
        /// </summary>
        PPMT,
        
        /// <summary>
        /// <b>PRED - Partial Redemption Without Reduction of Nominal Value</b>.
        /// </summary>
        PRED,
        
        /// <summary>
        /// <b>PRII - Interest Payment with Principle</b>.
        /// </summary>
        PRII,
        
        /// <summary>
        /// <b>PRIO - Priority Issue</b>.
        /// </summary>
        PRIO,
        
        /// <summary>
        /// <b>REDM - Redemption</b>.
        /// </summary>
        REDM,
        
        /// <summary>
        /// <b>REDO - Redenomination</b>.
        /// </summary>
        REDO,
        
        /// <summary>
        /// <b>REMK - Remarketing Agreement</b>.
        /// </summary>
        REMK,
        
        /// <summary>
        /// <b>RHDI - Rights Distribution</b>.
        /// </summary>
        RHDI,
        
        /// <summary>
        /// <b>RHTS - Rights Issue/Subscription Rights/Rights Offer</b>.
        /// </summary>
        RHTS,
        
        /// <summary>
        /// <b>SHPR - Shares Premium Dividend</b>.
        /// </summary>
        SHPR,
        
        /// <summary>
        /// <b>SMAL - ?undefined?</b>.
        /// </summary>
        SMAL,
        
        /// <summary>
        /// <b>SOFF - Spin Off</b>.
        /// </summary>
        SOFF,
        
        /// <summary>
        /// <b>SPLF - Stock Split</b>.
        /// </summary>
        SPLF,
        
        /// <summary>
        /// <b>SPLR - Reverse Stock Split</b>.
        /// </summary>
        SPLR,
        
        /// <summary>
        /// <b>SUSP - Suspicious Payment</b>.
        /// </summary>
        SUSP,
        
        /// <summary>
        /// <b>TEND - Tender</b>.
        /// </summary>
        TEND,
        
        /// <summary>
        /// <b>TREC - Tax Reclaim</b>.
        /// </summary>
        TREC,
        
        /// <summary>
        /// <b>WRTH - Worthless</b>.
        /// </summary>
        WRTH,
        
        /// <summary>
        /// <b>WTRC - ?undefined?</b>.
        /// </summary>
        WTRC,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>CorporateActionInformation1</b> (Corporate Action Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.019.001.01")]
    public class CorporateActionInformation1
    {
        
        /// <summary>
        /// Element <b>AgtId</b> (Agent Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice AgtId;
        
        /// <summary>
        /// Element <b>IssrCorpActnId</b> (Issuer Corporate Action Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IssrCorpActnId;
        
        /// <summary>
        /// Element <b>CorpActnPrcgId</b> (Corporate Action Processing Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CorpActnPrcgId;
        
        /// <summary>
        /// Element <b>EvtTp</b> (Event Type) of type CorporateActionEventType2FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionEventType2FormatChoice EvtTp;
        
        /// <summary>
        /// Element <b>MndtryVlntryEvtTp</b> (Mandatory Voluntary Event Type) of type CorporateActionMandatoryVoluntary1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public CorporateActionMandatoryVoluntary1FormatChoice MndtryVlntryEvtTp;
        
        /// <summary>
        /// Element <b>EvtPrcgTp</b> (Event Processing Type) of type CorporateActionEventProcessingType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CorporateActionEventProcessingType1FormatChoice EvtPrcgTp;
        
        /// <summary>
        /// Element <b>UndrlygScty</b> (Underlying Security) of type FinancialInstrumentDescription3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public FinancialInstrumentDescription3 UndrlygScty;
    }
}
