
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



namespace i20022.sese01200102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id sese.012.001.02 name PEPOrISAOrPortfolioTransferInstructionV02 from Securities Settlement business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>PEPOrISAOrPrtflTrfInstrV02</b> (PEP Or ISA Or Portfolio Transfer Instruction V02) of type PEPOrISAOrPortfolioTransferInstructionV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PEPOrISAOrPortfolioTransferInstructionV02 PEPOrISAOrPrtflTrfInstrV02;
    }
    
    /// <summary>
    /// Class <b>PEPOrISAOrPortfolioTransferInstructionV02</b> (PEP Or ISA Or Portfolio Transfer Instruction V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class PEPOrISAOrPortfolioTransferInstructionV02
    {
        
        /// <summary>
        /// Element <b>MsgRef</b> (Message Reference) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 MsgRef;
        
        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AdditionalReference3 PoolRef;
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public AdditionalReference3 PrvsRef;
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public AdditionalReference3 RltdRef;
        
        /// <summary>
        /// Element <b>PmryIndvInvstr</b> (Primary Individual Investor) of type IndividualPerson8.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public IndividualPerson8 PmryIndvInvstr;
        
        /// <summary>
        /// Element <b>ScndryIndvInvstr</b> (Secondary Individual Investor) of type IndividualPerson8.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public IndividualPerson8 ScndryIndvInvstr;
        
        /// <summary>
        /// Element <b>OthrIndvInvstr</b> (Other Individual Investor) of type array of IndividualPerson8.
        /// </summary>
        [XmlElementAttribute("OthrIndvInvstr", Order=6)]
        public IndividualPerson8[] OthrIndvInvstr;
        
        /// <summary>
        /// Element <b>PmryCorpInvstr</b> (Primary Corporate Investor) of type Organisation4.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public Organisation4 PmryCorpInvstr;
        
        /// <summary>
        /// Element <b>ScndryCorpInvstr</b> (Secondary Corporate Investor) of type Organisation4.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public Organisation4 ScndryCorpInvstr;
        
        /// <summary>
        /// Element <b>OthrCorpInvstr</b> (Other Corporate Investor) of type array of Organisation4.
        /// </summary>
        [XmlElementAttribute("OthrCorpInvstr", Order=9)]
        public Organisation4[] OthrCorpInvstr;
        
        /// <summary>
        /// Element <b>ClntAcct</b> (Client Account) of type Account5.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public Account5 ClntAcct;
        
        /// <summary>
        /// Element <b>NmneeAcct</b> (Nominee Account) of type Account6.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public Account6 NmneeAcct;
        
        /// <summary>
        /// Element <b>NewPlanMgr</b> (New Plan Manager) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public PartyIdentification2Choice NewPlanMgr;
        
        /// <summary>
        /// Element <b>CshAcct</b> (Cash Account) of type CashAccount11.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public CashAccount11 CshAcct;
        
        /// <summary>
        /// Element <b>PdctTrf</b> (Product Transfer) of type array of PEPISATransfer3.
        /// </summary>
        [XmlElementAttribute("PdctTrf", Order=14)]
        public PEPISATransfer3[] PdctTrf;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=15)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class MessageIdentification1
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
    }
    
    /// <summary>
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType2
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
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class SecurityIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Belgn (Belgian) of type string 
        /// Blmbrg (Bloomberg) of type string 
        /// CTA (CTA) of type string 
        /// CUSIP (CUSIP) of type string 
        /// Cmon (Common) of type string 
        /// Dtch (Dutch) of type string 
        /// ISIN (ISIN) of type string 
        /// OthrPrtryId (Other Proprietary Identification) of type AlternateSecurityIdentification1 
        /// QUICK (QUICK) of type string 
        /// RIC (RIC) of type string 
        /// SCVM (Sicovam) of type string 
        /// SEDOL (SEDOL) of type string 
        /// TckrSymb (Ticker Symbol) of type string 
        /// Vlrn (Valoren) of type string 
        /// Wrtppr (Wertpapier) of type string 
        /// </summary>
        [XmlElementAttribute("Belgn", typeof(string), Order=0)]
        [XmlElementAttribute("Blmbrg", typeof(string), Order=0)]
        [XmlElementAttribute("CTA", typeof(string), Order=0)]
        [XmlElementAttribute("CUSIP", typeof(string), Order=0)]
        [XmlElementAttribute("Cmon", typeof(string), Order=0)]
        [XmlElementAttribute("Dtch", typeof(string), Order=0)]
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("OthrPrtryId", typeof(AlternateSecurityIdentification1), Order=0)]
        [XmlElementAttribute("QUICK", typeof(string), Order=0)]
        [XmlElementAttribute("RIC", typeof(string), Order=0)]
        [XmlElementAttribute("SCVM", typeof(string), Order=0)]
        [XmlElementAttribute("SEDOL", typeof(string), Order=0)]
        [XmlElementAttribute("TckrSymb", typeof(string), Order=0)]
        [XmlElementAttribute("Vlrn", typeof(string), Order=0)]
        [XmlElementAttribute("Wrtppr", typeof(string), Order=0)]
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
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>Belgn - Belgiam</b>.
        /// </summary>
        Belgn,
        
        /// <summary>
        /// <b>Blmbrg - Bloomberg Symbol</b>.
        /// </summary>
        Blmbrg,
        
        /// <summary>
        /// <b>CTA - Consolidated Tape Association</b>.
        /// </summary>
        CTA,
        
        /// <summary>
        /// <b>CUSIP - Committee on Uniform Security Identification Procedures</b>.
        /// </summary>
        CUSIP,
        
        /// <summary>
        /// <b>Cmon - Common</b>.
        /// </summary>
        Cmon,
        
        /// <summary>
        /// <b>Dtch - Dutch</b>.
        /// </summary>
        Dtch,
        
        /// <summary>
        /// <b>ISIN - International Securities Identification Number</b>.
        /// </summary>
        ISIN,
        
        /// <summary>
        /// <b>OthrPrtryId - Other Proprietary Identification</b>.
        /// </summary>
        OthrPrtryId,
        
        /// <summary>
        /// <b>QUICK - QUICK Security Id</b>.
        /// </summary>
        QUICK,
        
        /// <summary>
        /// <b>RIC - RIC Security Id</b>.
        /// </summary>
        RIC,
        
        /// <summary>
        /// <b>SCVM - Sicovam</b>.
        /// </summary>
        SCVM,
        
        /// <summary>
        /// <b>SEDOL - Stock Exchange Daily Official List</b>.
        /// </summary>
        SEDOL,
        
        /// <summary>
        /// <b>TckrSymb - Ticker Symbol</b>.
        /// </summary>
        TckrSymb,
        
        /// <summary>
        /// <b>Vlrn - Valoren</b>.
        /// </summary>
        Vlrn,
        
        /// <summary>
        /// <b>Wrtppr - Wertpapier</b>.
        /// </summary>
        Wrtppr,
    }
    
    /// <summary>
    /// Class <b>FinancialInstrument11</b> (Financial Instrument 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class FinancialInstrument11
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification3Choice Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>TrfTp</b> (Transfer Type) of type TransferType1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TransferType1Code TrfTp;
    }
    
    /// <summary>
    /// Enumeration <b>TransferType1Code</b> (Transfer Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public enum TransferType1Code
    {
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
    }
    
    /// <summary>
    /// Class <b>Portfolio1</b> (Portfolio 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class Portfolio1
    {
        
        /// <summary>
        /// Element <b>PrtflInf</b> (Portfolio Information) of type array of string.
        /// </summary>
        [XmlElementAttribute("PrtflInf", Order=0)]
        public string[] PrtflInf;
    }
    
    /// <summary>
    /// Class <b>PreviousYearChoice</b> (Previous Year Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class PreviousYearChoice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of string.
        /// </summary>
        [XmlElementAttribute("AllPrvsYrs", typeof(string), Order=0)]
        [XmlElementAttribute("SpcfcPrvsYrs", typeof(string), DataType="gYear", Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType1.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType1</b> (Items Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02", IncludeInSchema=false)]
    public enum ItemsChoiceType1
    {
        
        /// <summary>
        /// <b>AllPrvsYrs - All Previous Years</b>.
        /// </summary>
        AllPrvsYrs,
        
        /// <summary>
        /// <b>SpcfcPrvsYrs - Specific Previous Years</b>.
        /// </summary>
        SpcfcPrvsYrs,
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
    /// Class <b>SubscriptionInformation1</b> (Subscription Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class SubscriptionInformation1
    {
        
        /// <summary>
        /// Element <b>DtOfFrstSbcpt</b> (Date Of First Subscription) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime DtOfFrstSbcpt;
        
        /// <summary>
        /// Element <b>EqtyCmpnt</b> (Equity Component) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAndAmount EqtyCmpnt;
        
        /// <summary>
        /// Element <b>CshCmpnt</b> (Cash Component) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAndAmount CshCmpnt;
        
        /// <summary>
        /// Element <b>TtlAmtYrToDt</b> (Total Amount Year To Date) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount TtlAmtYrToDt;
    }
    
    /// <summary>
    /// Class <b>PreviousYear1</b> (Previous Year 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class PreviousYear1
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of string.
        /// </summary>
        [XmlElementAttribute("AllPrvsYrs", typeof(string), Order=0)]
        [XmlElementAttribute("SpcfcPrvsYrs", typeof(string), DataType="gYear", Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <summary>
        /// Element <b>CshCmpntInd</b> (Cash Component Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool CshCmpntInd;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <summary>
        /// <b>AllPrvsYrs - All Previous Years</b>.
        /// </summary>
        AllPrvsYrs,
        
        /// <summary>
        /// <b>SpcfcPrvsYrs - Specific Previous Years</b>.
        /// </summary>
        SpcfcPrvsYrs,
    }
    
    /// <summary>
    /// Class <b>ISAYearsOfIssue1</b> (ISA Years Of Issue 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class ISAYearsOfIssue1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// CurYrTp (Current Year Type) of type ISAType1Code 
        /// XtndedCurYrTp (Extended Current Year Type) of type string 
        /// </summary>
        [XmlElementAttribute("CurYrTp", typeof(ISAType1Code), Order=0)]
        [XmlElementAttribute("XtndedCurYrTp", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>CshCmpntInd</b> (Cash Component Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool CshCmpntInd;
        
        /// <summary>
        /// Element <b>PrvsYrs</b> (Previous Years) of type PreviousYear1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PreviousYear1 PrvsYrs;
        
        /// <summary>
        /// Element <b>CurYrSbcptDtls</b> (Current Year Subscription Details) of type SubscriptionInformation1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public SubscriptionInformation1 CurYrSbcptDtls;
    }
    
    /// <summary>
    /// Enumeration <b>ISAType1Code</b> (ISA Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public enum ISAType1Code
    {
        
        /// <summary>
        /// <b>MINE - Mini Equity</b>.
        /// </summary>
        MINE,
        
        /// <summary>
        /// <b>MAXI - Maxi</b>.
        /// </summary>
        MAXI,
        
        /// <summary>
        /// <b>MINC - Mini Cash</b>.
        /// </summary>
        MINC,
    }
    
    /// <summary>
    /// Class <b>PEPISATransfer3</b> (PEPISA Transfer 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class PEPISATransfer3
    {
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MstrRef;
        
        /// <summary>
        /// Element <b>TrfId</b> (Transfer Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string TrfId;
        
        /// <summary>
        /// Element <b>RsdlCshInd</b> (Residual Cash Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool RsdlCshInd;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// ISA (ISA) of type ISAYearsOfIssue1 
        /// PEP (PEP) of type PreviousYearChoice 
        /// Prtfl (Portfolio) of type Portfolio1 
        /// </summary>
        [XmlElementAttribute("ISA", typeof(ISAYearsOfIssue1), Order=3)]
        [XmlElementAttribute("PEP", typeof(PreviousYearChoice), Order=3)]
        [XmlElementAttribute("Prtfl", typeof(Portfolio1), Order=3)]
        public object Item;
        
        /// <summary>
        /// Element <b>FinInstrmAsstForTrf</b> (Financial Instrument Asset For Transfer) of type array of FinancialInstrument11.
        /// </summary>
        [XmlElementAttribute("FinInstrmAsstForTrf", Order=4)]
        public FinancialInstrument11[] FinInstrmAsstForTrf;
    }
    
    /// <summary>
    /// Class <b>ClearingSystemMemberIdentificationChoice</b> (Clearing System Member Identification Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType1
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
    /// Class <b>FinancialInstitutionIdentification3Choice</b> (Financial Institution Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class FinancialInstitutionIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BIC (BIC) of type string 
        /// ClrSysMmbId (Clearing System Member Identification) of type ClearingSystemMemberIdentificationChoice 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// PrtryId (Proprietary Identification) of type SimpleIdentificationInformation 
        /// </summary>
        [XmlElementAttribute("BIC", typeof(string), Order=0)]
        [XmlElementAttribute("ClrSysMmbId", typeof(ClearingSystemMemberIdentificationChoice), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(SimpleIdentificationInformation), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>CashAccountIdentification1Choice</b> (Cash Account Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class CashAccountIdentification1Choice
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType
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
    /// Class <b>CashAccount11</b> (Cash Account 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class CashAccount11
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type CashAccountIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CashAccountIdentification1Choice Id;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public FinancialInstitutionIdentification3Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>Account6</b> (Account 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class Account6
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Dsgnt</b> (Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Dsgnt;
        
        /// <summary>
        /// Element <b>Svcr</b> (Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice Svcr;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
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
    /// Class <b>Account5</b> (Account 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class Account5
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Dsgnt</b> (Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Dsgnt;
        
        /// <summary>
        /// Element <b>Svcr</b> (Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice Svcr;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification4Choice</b> (Party Identification 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class PartyIdentification4Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>Organisation4</b> (Organisation 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class Organisation4
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification4Choice Id;
        
        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Purp;
        
        /// <summary>
        /// Element <b>TaxtnCtry</b> (Taxation Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string TaxtnCtry;
        
        /// <summary>
        /// Element <b>RegnCtry</b> (Registration Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string RegnCtry;
        
        /// <summary>
        /// Element <b>RegnDt</b> (Registration Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime RegnDt;
        
        /// <summary>
        /// Element <b>RegnDtSpecified</b> (Registration Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegnDtSpecified;
        
        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string TaxIdNb;
        
        /// <summary>
        /// Element <b>NtlRegnNb</b> (National Registration Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string NtlRegnNb;
        
        /// <summary>
        /// Element <b>CorpInvstrAdr</b> (Corporate Investor Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public PostalAddress1 CorpInvstrAdr;
    }
    
    /// <summary>
    /// Class <b>IndividualPerson8</b> (Individual Person 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class IndividualPerson8
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string GvnNm;
        
        /// <summary>
        /// Element <b>NmPrfx</b> (Name Prefix) of type NamePrefix1Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public NamePrefix1Code NmPrfx;
        
        /// <summary>
        /// Element <b>NmPrfxSpecified</b> (Name Prefix Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NmPrfxSpecified;
        
        /// <summary>
        /// Element <b>NmSfx</b> (Name Suffix) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string NmSfx;
        
        /// <summary>
        /// Element <b>Gndr</b> (Gender) of type GenderCode.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public GenderCode Gndr;
        
        /// <summary>
        /// Element <b>GndrSpecified</b> (Gender Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GndrSpecified;
        
        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime BirthDt;
        
        /// <summary>
        /// Element <b>BirthDtSpecified</b> (Birth Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDtSpecified;
        
        /// <summary>
        /// Element <b>SclSctyNb</b> (Social Security Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string SclSctyNb;
        
        /// <summary>
        /// Element <b>IndvInvstrAdr</b> (Individual Investor Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PostalAddress1 IndvInvstrAdr;
    }
    
    /// <summary>
    /// Enumeration <b>NamePrefix1Code</b> (Name Prefix 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public enum NamePrefix1Code
    {
        
        /// <summary>
        /// <b>DOCT - Doctor</b>.
        /// </summary>
        DOCT,
        
        /// <summary>
        /// <b>MIST - Mister</b>.
        /// </summary>
        MIST,
        
        /// <summary>
        /// <b>MISS - Miss</b>.
        /// </summary>
        MISS,
        
        /// <summary>
        /// <b>MADM - Madam</b>.
        /// </summary>
        MADM,
    }
    
    /// <summary>
    /// Enumeration <b>GenderCode</b> (Gender Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public enum GenderCode
    {
        
        /// <summary>
        /// <b>MALE - Male</b>.
        /// </summary>
        MALE,
        
        /// <summary>
        /// <b>FEMA - Female</b>.
        /// </summary>
        FEMA,
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.012.001.02")]
    public class AdditionalReference3
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice RefIssr;
        
        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string MsgNm;
    }
}
