
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



namespace i20022.semt00600101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id semt.006.001.01 name StatementOfInvestmentFundTransactionsV01 from Securities Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>semt00600101</b> (semt 00600101) of type semt00600101.
        /// </summary>
        [XmlElementAttribute("semt.006.001.01", Order=0)]
        public semt00600101 semt00600101;
    }
    
    /// <summary>
    /// Class <b>semt00600101</b> (semt 00600101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="semt.006.001.01", Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class semt00600101
    {
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type array of AdditionalReference2.
        /// </summary>
        [XmlElementAttribute("PrvsRef", Order=0)]
        public AdditionalReference2[] PrvsRef;
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type array of AdditionalReference2.
        /// </summary>
        [XmlElementAttribute("RltdRef", Order=1)]
        public AdditionalReference2[] RltdRef;
        
        /// <summary>
        /// Element <b>MsgPgntn</b> (Message Pagination) of type Pagination.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Pagination MsgPgntn;
        
        /// <summary>
        /// Element <b>StmtGnlDtls</b> (Statement General Details) of type Statement5.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public Statement5 StmtGnlDtls;
        
        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount12.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public InvestmentAccount12 InvstmtAcctDtls;
        
        /// <summary>
        /// Element <b>TxOnAcct</b> (Transaction On Account) of type array of InvestmentFundTransactionsByFund1.
        /// </summary>
        [XmlElementAttribute("TxOnAcct", Order=5)]
        public InvestmentFundTransactionsByFund1[] TxOnAcct;
        
        /// <summary>
        /// Element <b>SubAcctDtls</b> (Sub Account Details) of type array of SubAccountIdentification4.
        /// </summary>
        [XmlElementAttribute("SubAcctDtls", Order=6)]
        public SubAccountIdentification4[] SubAcctDtls;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=7)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference2</b> (Additional Reference 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class AdditionalReference2
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification1Choice RefIssr;
        
        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string MsgNm;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification1Choice</b> (Party Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class PartyIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress2 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress2), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress2</b> (Name And Address 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class NameAndAddress2
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type LongPostalAddress1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public LongPostalAddress1Choice Adr;
    }
    
    /// <summary>
    /// Class <b>LongPostalAddress1Choice</b> (Long Postal Address 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class LongPostalAddress1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type StructuredLongPostalAddress1 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(StructuredLongPostalAddress1), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>StructuredLongPostalAddress1</b> (Structured Long Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class StructuredLongPostalAddress1
    {
        
        /// <summary>
        /// Element <b>BldgNm</b> (Building Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BldgNm;
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>StrtBldgId</b> (Street Building Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StrtBldgId;
        
        /// <summary>
        /// Element <b>Flr</b> (Floor) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Flr;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>DstrctNm</b> (District Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string DstrctNm;
        
        /// <summary>
        /// Element <b>RgnId</b> (Region Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string RgnId;
        
        /// <summary>
        /// Element <b>Stat</b> (State) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Stat;
        
        /// <summary>
        /// Element <b>CtyId</b> (County Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string CtyId;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string Ctry;
        
        /// <summary>
        /// Element <b>PstCdId</b> (Post Code Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string PstCdId;
        
        /// <summary>
        /// Element <b>POB</b> (PostOfficeBox) of type string.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public string POB;
    }
    
    /// <summary>
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class Extension1
    {
        
        /// <summary>
        /// Element <b>PlcAndNm</b> (Place And Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PlcAndNm;
        
        /// <summary>
        /// Element <b>Txt</b> (Text) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Txt;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification3</b> (Account Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class AccountIdentification3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 Id;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Issr;
        
        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Inf;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class AccountIdentification1
    {
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SimpleIdentificationInformation Prtry;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>AccountIdentificationAndPurpose</b> (Account Identification And Purpose).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class AccountIdentificationAndPurpose
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 Id;
        
        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type SecuritiesAccountPurposeType1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public SecuritiesAccountPurposeType1Code Purp;
    }
    
    /// <summary>
    /// Enumeration <b>SecuritiesAccountPurposeType1Code</b> (Securities Account Purpose Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum SecuritiesAccountPurposeType1Code
    {
        
        /// <summary>
        /// <b>MARG - Margin</b>.
        /// </summary>
        MARG,
        
        /// <summary>
        /// <b>SHOR - Short Sale</b>.
        /// </summary>
        SHOR,
        
        /// <summary>
        /// <b>ABRD - Abroad</b>.
        /// </summary>
        ABRD,
        
        /// <summary>
        /// <b>CEND - Centralised</b>.
        /// </summary>
        CEND,
        
        /// <summary>
        /// <b>DVPA - Cash DVP</b>.
        /// </summary>
        DVPA,
        
        /// <summary>
        /// <b>PHYS - Physical Certification</b>.
        /// </summary>
        PHYS,
    }
    
    /// <summary>
    /// Class <b>AccountIdentificationFormatChoice</b> (Account Identification Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class AccountIdentificationFormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// IdAndPurp (Identification And Purpose) of type AccountIdentificationAndPurpose 
        /// IdAsDSS (Identification As DSS) of type AccountIdentification3 
        /// SmplId (Simple Identification) of type AccountIdentification1 
        /// </summary>
        [XmlElementAttribute("IdAndPurp", typeof(AccountIdentificationAndPurpose), Order=0)]
        [XmlElementAttribute("IdAsDSS", typeof(AccountIdentification3), Order=0)]
        [XmlElementAttribute("SmplId", typeof(AccountIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>SubAccountIdentification4</b> (Sub Account Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class SubAccountIdentification4
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentificationFormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentificationFormatChoice Id;
        
        /// <summary>
        /// Element <b>ActvtyInd</b> (Activity Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool ActvtyInd;
        
        /// <summary>
        /// Element <b>TxOnSubAcct</b> (Transaction On Sub Account) of type array of InvestmentFundTransactionsByFund1.
        /// </summary>
        [XmlElementAttribute("TxOnSubAcct", Order=2)]
        public InvestmentFundTransactionsByFund1[] TxOnSubAcct;
    }
    
    /// <summary>
    /// Class <b>InvestmentFundTransactionsByFund1</b> (Investment Fund Transactions By Fund 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class InvestmentFundTransactionsByFund1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification1Choice Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>SplmtryId</b> (Supplementary Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string SplmtryId;
        
        /// <summary>
        /// Element <b>Form</b> (Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public FormOfSecurity1Code Form;
        
        /// <summary>
        /// Element <b>FormSpecified</b> (Form Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormSpecified;
        
        /// <summary>
        /// Element <b>ClssTp</b> (Class Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string ClssTp;
        
        /// <summary>
        /// Element <b>DstrbtnPlcy</b> (Distribution Policy) of type DistributionPolicy1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public DistributionPolicy1Code DstrbtnPlcy;
        
        /// <summary>
        /// Element <b>DstrbtnPlcySpecified</b> (Distribution Policy Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified;
        
        /// <summary>
        /// Element <b>TxDtls</b> (Transaction Details) of type array of InvestmentFundTransaction2.
        /// </summary>
        [XmlElementAttribute("TxDtls", Order=6)]
        public InvestmentFundTransaction2[] TxDtls;
        
        /// <summary>
        /// Element <b>BalByPg</b> (Balance By Page) of type PaginationBalance1.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PaginationBalance1 BalByPg;
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification1Choice</b> (Security Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class SecurityIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AltrnId (Alternate Identification) of type AlternateSecurityIdentification1 
        /// Blmbrg (Bloomberg) of type string 
        /// CTA (CTA) of type string 
        /// Cmon (Common) of type string 
        /// ISIN (ISIN) of type string 
        /// RIC (RIC) of type string 
        /// TckrSymb (Ticker Symbol) of type string 
        /// </summary>
        [XmlElementAttribute("AltrnId", typeof(AlternateSecurityIdentification1), Order=0)]
        [XmlElementAttribute("Blmbrg", typeof(string), Order=0)]
        [XmlElementAttribute("CTA", typeof(string), Order=0)]
        [XmlElementAttribute("Cmon", typeof(string), Order=0)]
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("RIC", typeof(string), Order=0)]
        [XmlElementAttribute("TckrSymb", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class AlternateSecurityIdentification1
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1
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
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>AltrnId - Alternate Identification</b>.
        /// </summary>
        AltrnId,
        
        /// <summary>
        /// <b>Blmbrg - Bloomberg Symbol</b>.
        /// </summary>
        Blmbrg,
        
        /// <summary>
        /// <b>CTA - Consolidated Tape Association</b>.
        /// </summary>
        CTA,
        
        /// <summary>
        /// <b>Cmon - Common</b>.
        /// </summary>
        Cmon,
        
        /// <summary>
        /// <b>ISIN - International Securities Identification Number</b>.
        /// </summary>
        ISIN,
        
        /// <summary>
        /// <b>RIC - RIC Security Id</b>.
        /// </summary>
        RIC,
        
        /// <summary>
        /// <b>TckrSymb - Ticker Symbol</b>.
        /// </summary>
        TckrSymb,
    }
    
    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
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
    /// Enumeration <b>DistributionPolicy1Code</b> (Distribution Policy 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum DistributionPolicy1Code
    {
        
        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,
        
        /// <summary>
        /// <b>ACCU - Accumulation</b>.
        /// </summary>
        ACCU,
    }
    
    /// <summary>
    /// Class <b>InvestmentFundTransaction2</b> (Investment Fund Transaction 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class InvestmentFundTransaction2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// CorpActnEvtTp (Corporate Action Event Type) of type CorporateActionEventType1CodeChoice 
        /// TxTp (Transaction Type) of type TransactionType1CodeChoice 
        /// </summary>
        [XmlElementAttribute("CorpActnEvtTp", typeof(CorporateActionEventType1CodeChoice), Order=0)]
        [XmlElementAttribute("TxTp", typeof(TransactionType1CodeChoice), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>BookgSts</b> (Booking Status) of type TransactionStatus1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public TransactionStatus1Code BookgSts;
        
        /// <summary>
        /// Element <b>BookgStsSpecified</b> (Booking Status Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BookgStsSpecified;
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string MstrRef;
        
        /// <summary>
        /// Element <b>OrdrRef</b> (Order Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string OrdrRef;
        
        /// <summary>
        /// Element <b>DealRef</b> (Deal Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string DealRef;
        
        /// <summary>
        /// Element <b>LegId</b> (Leg Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string LegId;
        
        /// <summary>
        /// Element <b>LegExctnId</b> (Leg Execution Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string LegExctnId;
        
        /// <summary>
        /// Element <b>OrdrDtTm</b> (Order Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public System.DateTime OrdrDtTm;
        
        /// <summary>
        /// Element <b>OrdrDtTmSpecified</b> (Order Date Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdrDtTmSpecified;
        
        /// <summary>
        /// Element <b>SttldTxInd</b> (Settled Transaction Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public bool SttldTxInd;
        
        /// <summary>
        /// Element <b>RegdTxInd</b> (Registered Transaction Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public bool RegdTxInd;
        
        /// <summary>
        /// Element <b>UnitsQty</b> (Units Quantity) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public FinancialInstrumentQuantity1 UnitsQty;
        
        /// <summary>
        /// Element <b>CdtDbt</b> (Credit Debit) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public CreditDebitCode CdtDbt;
        
        /// <summary>
        /// Element <b>Rvsl</b> (Reversal) of type ReversalCode.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public ReversalCode Rvsl;
        
        /// <summary>
        /// Element <b>RvslSpecified</b> (Reversal Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RvslSpecified;
        
        /// <summary>
        /// Element <b>GrssSttlmAmt</b> (Gross Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public ActiveCurrencyAndAmount GrssSttlmAmt;
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=14)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SttlmDtSpecified</b> (Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SttlmDtSpecified;
        
        /// <summary>
        /// Element <b>TradDtTm</b> (Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public DateAndDateTimeChoice TradDtTm;
        
        /// <summary>
        /// Element <b>CumDvddInd</b> (Cum Dividend Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public bool CumDvddInd;
        
        /// <summary>
        /// Element <b>PrtlyExctdInd</b> (Partially Executed Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=17)]
        public bool PrtlyExctdInd;
        
        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type UnitPrice1.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public UnitPrice1 PricDtls;
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventType1CodeChoice</b> (Corporate Action Event Type 1Code Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class CorporateActionEventType1CodeChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type CorporateActionEventType1Code 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(CorporateActionEventType1Code), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventType1Code</b> (Corporate Action Event Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum CorporateActionEventType1Code
    {
        
        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
        
        /// <summary>
        /// <b>CAPG - Capital Gains Distribution</b>.
        /// </summary>
        CAPG,
        
        /// <summary>
        /// <b>DVCA - Cash Dividend</b>.
        /// </summary>
        DVCA,
        
        /// <summary>
        /// <b>DVOP - Dividend Option</b>.
        /// </summary>
        DVOP,
        
        /// <summary>
        /// <b>DVSE - Stock Dividend</b>.
        /// </summary>
        DVSE,
        
        /// <summary>
        /// <b>LIQU - Liquidation</b>.
        /// </summary>
        LIQU,
        
        /// <summary>
        /// <b>MRGR - Merger</b>.
        /// </summary>
        MRGR,
        
        /// <summary>
        /// <b>NAME - Name Change</b>.
        /// </summary>
        NAME,
        
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
        /// <b>TEND - Tender</b>.
        /// </summary>
        TEND,
        
        /// <summary>
        /// <b>BONU - Bonus Issue / Capitalisation Issue</b>.
        /// </summary>
        BONU,
        
        /// <summary>
        /// <b>RHDI - Rights Distribution</b>.
        /// </summary>
        RHDI,
        
        /// <summary>
        /// <b>EXRI - Call On Rights</b>.
        /// </summary>
        EXRI,
        
        /// <summary>
        /// <b>CHAN - Change</b>.
        /// </summary>
        CHAN,
        
        /// <summary>
        /// <b>REDO - Redenomination</b>.
        /// </summary>
        REDO,
        
        /// <summary>
        /// <b>EXOP - Exchange Option</b>.
        /// </summary>
        EXOP,
        
        /// <summary>
        /// <b>EXOF - Exchange Offer</b>.
        /// </summary>
        EXOF,
        
        /// <summary>
        /// <b>DECR - Decrease In Value</b>.
        /// </summary>
        DECR,
    }
    
    /// <summary>
    /// Class <b>TransactionType1CodeChoice</b> (Transaction Type 1Code Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class TransactionType1CodeChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type TransactionType2Code 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(TransactionType2Code), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>TransactionType2Code</b> (Transaction Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum TransactionType2Code
    {
        
        /// <summary>
        /// <b>REDM - Redemption</b>.
        /// </summary>
        REDM,
        
        /// <summary>
        /// <b>SUBS - Substracted</b>.
        /// </summary>
        SUBS,
        
        /// <summary>
        /// <b>SSPL - Subscription Savings Plan</b>.
        /// </summary>
        SSPL,
        
        /// <summary>
        /// <b>RWPL - Redemption Withdrawing Plan</b>.
        /// </summary>
        RWPL,
        
        /// <summary>
        /// <b>TRIN - Transfer In</b>.
        /// </summary>
        TRIN,
        
        /// <summary>
        /// <b>TOUT - Transfer Out</b>.
        /// </summary>
        TOUT,
        
        /// <summary>
        /// <b>SWII - Switch In</b>.
        /// </summary>
        SWII,
        
        /// <summary>
        /// <b>SWIO - Switch Out</b>.
        /// </summary>
        SWIO,
        
        /// <summary>
        /// <b>SUAA - Subscription Asset Allocation</b>.
        /// </summary>
        SUAA,
        
        /// <summary>
        /// <b>REAA - Redemption Asset Allocation</b>.
        /// </summary>
        REAA,
    }
    
    /// <summary>
    /// Enumeration <b>TransactionStatus1Code</b> (Transaction Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum TransactionStatus1Code
    {
        
        /// <summary>
        /// <b>RVSL - Reversal</b>.
        /// </summary>
        RVSL,
        
        /// <summary>
        /// <b>REBO - Rebooked</b>.
        /// </summary>
        REBO,
        
        /// <summary>
        /// <b>CANC - Request To Cancel</b>.
        /// </summary>
        CANC,
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class FinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Unit;
    }
    
    /// <summary>
    /// Enumeration <b>CreditDebitCode</b> (Credit Debit Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
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
    /// Enumeration <b>ReversalCode</b> (Reversal Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum ReversalCode
    {
        
        /// <summary>
        /// <b>RVCD - Reversal Credit</b>.
        /// </summary>
        RVCD,
        
        /// <summary>
        /// <b>RVDB - Reversal Debit</b>.
        /// </summary>
        RVDB,
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
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
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class DateAndDateTimeChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute("Dt", typeof(System.DateTime), DataType="date", Order=0)]
        [XmlElementAttribute("DtTm", typeof(System.DateTime), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public System.DateTime Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>Dt - Date</b>.
        /// </summary>
        Dt,
        
        /// <summary>
        /// <b>DtTm - Date Time</b>.
        /// </summary>
        DtTm,
    }
    
    /// <summary>
    /// Class <b>UnitPrice1</b> (Unit Price 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class UnitPrice1
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type TypeOfPrice2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TypeOfPrice2Code Tp;
        
        /// <summary>
        /// Element <b>Val</b> (Value) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceValue1 Val;
        
        /// <summary>
        /// Element <b>PricMtd</b> (Price Method) of type PriceMethod1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PriceMethod1Code PricMtd;
        
        /// <summary>
        /// Element <b>PricMtdSpecified</b> (Price Method Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricMtdSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>TypeOfPrice2Code</b> (Type Of Price 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum TypeOfPrice2Code
    {
        
        /// <summary>
        /// <b>BIDE - Bid</b>.
        /// </summary>
        BIDE,
        
        /// <summary>
        /// <b>OFFR - Offer / Proposed Rate</b>.
        /// </summary>
        OFFR,
        
        /// <summary>
        /// <b>NAVL - Net Asset Value</b>.
        /// </summary>
        NAVL,
        
        /// <summary>
        /// <b>CREA - Creation</b>.
        /// </summary>
        CREA,
        
        /// <summary>
        /// <b>CANC - Request To Cancel</b>.
        /// </summary>
        CANC,
        
        /// <summary>
        /// <b>INTE - Interest</b>.
        /// </summary>
        INTE,
        
        /// <summary>
        /// <b>SWNG - Swing</b>.
        /// </summary>
        SWNG,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>MIDD - Mid</b>.
        /// </summary>
        MIDD,
        
        /// <summary>
        /// <b>RINV - Reinvestment</b>.
        /// </summary>
        RINV,
        
        /// <summary>
        /// <b>SWIC - Switch</b>.
        /// </summary>
        SWIC,
    }
    
    /// <summary>
    /// Class <b>PriceValue1</b> (Price Value 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class PriceValue1
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
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
    /// Enumeration <b>PriceMethod1Code</b> (Price Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum PriceMethod1Code
    {
        
        /// <summary>
        /// <b>FORW - Forward Price</b>.
        /// </summary>
        FORW,
        
        /// <summary>
        /// <b>HIST - Historical Price</b>.
        /// </summary>
        HIST,
    }
    
    /// <summary>
    /// Class <b>PaginationBalance1</b> (Pagination Balance 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class PaginationBalance1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute("FrstOpngBal", typeof(FinancialInstrumentQuantity1), Order=0)]
        [XmlElementAttribute("IntrmyOpngBal", typeof(FinancialInstrumentQuantity1), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public FinancialInstrumentQuantity1 Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute("FnlClsgBal", typeof(FinancialInstrumentQuantity1), Order=2)]
        [XmlElementAttribute("IntrmyClsgBal", typeof(FinancialInstrumentQuantity1), Order=2)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public FinancialInstrumentQuantity1 Item1;
        
        /// <summary>
        /// Element <b>Item1ElementName</b> (Item 1Element Name) of type Item1ChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>FrstOpngBal - First Opening Balance</b>.
        /// </summary>
        FrstOpngBal,
        
        /// <summary>
        /// <b>IntrmyOpngBal - Intermediary Opening Balance</b>.
        /// </summary>
        IntrmyOpngBal,
    }
    
    /// <summary>
    /// Enumeration <b>Item1ChoiceType</b> (Item 1Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01", IncludeInSchema=false)]
    public enum Item1ChoiceType
    {
        
        /// <summary>
        /// <b>FnlClsgBal - Final Closing Balance</b>.
        /// </summary>
        FnlClsgBal,
        
        /// <summary>
        /// <b>IntrmyClsgBal - Intermediary Closing Balance</b>.
        /// </summary>
        IntrmyClsgBal,
    }
    
    /// <summary>
    /// Class <b>Account1</b> (Account 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class Account1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 Id;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification1Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>Intermediary1</b> (Intermediary 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class Intermediary1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification1Choice Id;
        
        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Account1 Acct;
        
        /// <summary>
        /// Element <b>Role</b> (Role) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Role;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount12</b> (Investment Account 12).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class InvestmentAccount12
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Dsgnt</b> (Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Dsgnt;
        
        /// <summary>
        /// Element <b>IntrmyInf</b> (Intermediary Information) of type array of Intermediary1.
        /// </summary>
        [XmlElementAttribute("IntrmyInf", Order=3)]
        public Intermediary1[] IntrmyInf;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification1Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>DatePeriodDetails</b> (Date Period Details).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class DatePeriodDetails
    {
        
        /// <summary>
        /// Element <b>FrDt</b> (From Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime FrDt;
        
        /// <summary>
        /// Element <b>ToDt</b> (To Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime ToDt;
    }
    
    /// <summary>
    /// Class <b>Statement5</b> (Statement 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class Statement5
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>StmtPrd</b> (Statement Period) of type DatePeriodDetails.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DatePeriodDetails StmtPrd;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateAndDateTimeChoice CreDtTm;
        
        /// <summary>
        /// Element <b>Frqcy</b> (Frequency) of type Frequency1Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public Frequency1Code Frqcy;
        
        /// <summary>
        /// Element <b>FrqcySpecified</b> (Frequency Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FrqcySpecified;
        
        /// <summary>
        /// Element <b>UpdTp</b> (Update Type) of type StatementUpdateTypeCode.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public StatementUpdateTypeCode UpdTp;
        
        /// <summary>
        /// Element <b>ActvtyInd</b> (Activity Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public bool ActvtyInd;
        
        /// <summary>
        /// Element <b>RptNb</b> (Report Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string RptNb;
    }
    
    /// <summary>
    /// Enumeration <b>Frequency1Code</b> (Frequency 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
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
    /// Enumeration <b>StatementUpdateTypeCode</b> (Statement Update Type Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public enum StatementUpdateTypeCode
    {
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
        
        /// <summary>
        /// <b>DELT - Delete Data Set</b>.
        /// </summary>
        DELT,
    }
    
    /// <summary>
    /// Class <b>Pagination</b> (Pagination).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
    public class Pagination
    {
        
        /// <summary>
        /// Element <b>PgNb</b> (Page Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PgNb;
        
        /// <summary>
        /// Element <b>LastPgInd</b> (Last Page Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool LastPgInd;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:semt.006.001.01")]
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
}
