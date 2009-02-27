
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



namespace i20022.camt04300102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.043.001.02 name FundDetailedConfirmedCashForecastReportV02 from Cash Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>camt04300102</b> (camt 04300102) of type camt04300102.
        /// </summary>
        [XmlElementAttribute("camt.043.001.02", Order=0)]
        public camt04300102 camt04300102;
    }
    
    /// <summary>
    /// Class <b>camt04300102</b> (camt 04300102).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="camt.043.001.02", Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class camt04300102
    {
        
        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AdditionalReference3 PoolRef;
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute("PrvsRef", Order=1)]
        public AdditionalReference3[] PrvsRef;
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute("RltdRef", Order=2)]
        public AdditionalReference3[] RltdRef;
        
        /// <summary>
        /// Element <b>FndCshFcstDtls</b> (Fund Cash Forecast Details) of type array of FundCashForecast2.
        /// </summary>
        [XmlElementAttribute("FndCshFcstDtls", Order=3)]
        public FundCashForecast2[] FndCshFcstDtls;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=4)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    /// Class <b>NetCashForecast1</b> (Net Cash Forecast 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class NetCashForecast1
    {
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SttlmDtSpecified</b> (Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SttlmDtSpecified;
        
        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount NetAmt;
        
        /// <summary>
        /// Element <b>NetUnitsNb</b> (Net Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstrumentQuantity1 NetUnitsNb;
        
        /// <summary>
        /// Element <b>FlowDrctn</b> (Flow Direction) of type FlowDirectionType1Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public FlowDirectionType1Code FlowDrctn;
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class ActiveOrHistoricCurrencyAndAmount
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
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class FinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Unit;
    }
    
    /// <summary>
    /// Enumeration <b>FlowDirectionType1Code</b> (Flow Direction Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public enum FlowDirectionType1Code
    {
        
        /// <summary>
        /// <b>INCG - Incoming</b>.
        /// </summary>
        INCG,
        
        /// <summary>
        /// <b>OUTG - Outgoing</b>.
        /// </summary>
        OUTG,
    }
    
    /// <summary>
    /// Class <b>InvestmentFundTransactionOutType1</b> (Investment Fund Transaction Out Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class InvestmentFundTransactionOutType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type InvestmentFundTransactionOutType4Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InvestmentFundTransactionOutType4Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>InvestmentFundTransactionOutType4Code</b> (Investment Fund Transaction Out Type 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public enum InvestmentFundTransactionOutType4Code
    {
        
        /// <summary>
        /// <b>REDM - Redemption</b>.
        /// </summary>
        REDM,
        
        /// <summary>
        /// <b>SWIO - Switch Out</b>.
        /// </summary>
        SWIO,
        
        /// <summary>
        /// <b>INSP - In Specie</b>.
        /// </summary>
        INSP,
        
        /// <summary>
        /// <b>CROO - Cross Out</b>.
        /// </summary>
        CROO,
        
        /// <summary>
        /// <b>DIVI - Dividend In Scope</b>.
        /// </summary>
        DIVI,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>FundCashOutBreakdown1</b> (Fund Cash Out Breakdown 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class FundCashOutBreakdown1
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveOrHistoricCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>UnitsNb</b> (Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public FinancialInstrumentQuantity1 UnitsNb;
        
        /// <summary>
        /// Element <b>NewAmtInd</b> (New Amount Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool NewAmtInd;
        
        /// <summary>
        /// Element <b>NewAmtIndSpecified</b> (New Amount Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewAmtIndSpecified;
        
        /// <summary>
        /// Element <b>InvstmtFndTxOutTpDtls</b> (Investment Fund Transaction Out Type Details) of type InvestmentFundTransactionOutType1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InvestmentFundTransactionOutType1 InvstmtFndTxOutTpDtls;
        
        /// <summary>
        /// Element <b>OrgnlOrdrQtyDtls</b> (Original Order Quantity Details) of type OriginalOrderQuantityType1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public OriginalOrderQuantityType1 OrgnlOrdrQtyDtls;
        
        /// <summary>
        /// Element <b>ComssnDtls</b> (Commission Details) of type array of Commission4.
        /// </summary>
        [XmlElementAttribute("ComssnDtls", Order=5)]
        public Commission4[] ComssnDtls;
    }
    
    /// <summary>
    /// Class <b>OriginalOrderQuantityType1</b> (Original Order Quantity Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class OriginalOrderQuantityType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type OrderQuantityType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public OrderQuantityType1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>OrderQuantityType1Code</b> (Order Quantity Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public enum OrderQuantityType1Code
    {
        
        /// <summary>
        /// <b>UNIT - Unit</b>.
        /// </summary>
        UNIT,
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>Commission4</b> (Commission 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class Commission4
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CommissionType1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CommissionType1 Tp;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveCurrencyAnd13DecimalAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveCurrencyAnd13DecimalAmount), Order=1)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=1)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>CommissionType1</b> (Commission Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class CommissionType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type CommissionType5Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CommissionType5Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>CommissionType5Code</b> (Commission Type 5Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public enum CommissionType5Code
    {
        
        /// <summary>
        /// <b>FEND - Front End Load</b>.
        /// </summary>
        FEND,
        
        /// <summary>
        /// <b>BEND - Back End Load</b>.
        /// </summary>
        BEND,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    /// Class <b>CashOutForecast1</b> (Cash Out Forecast 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class CashOutForecast1
    {
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SubTtlAmt</b> (Sub Total Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount SubTtlAmt;
        
        /// <summary>
        /// Element <b>SubTtlUnitsNb</b> (Sub Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstrumentQuantity1 SubTtlUnitsNb;
        
        /// <summary>
        /// Element <b>XcptnlCshFlowInd</b> (Exceptional Cash Flow Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool XcptnlCshFlowInd;
        
        /// <summary>
        /// Element <b>XcptnlCshFlowIndSpecified</b> (Exceptional Cash Flow Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XcptnlCshFlowIndSpecified;
        
        /// <summary>
        /// Element <b>CshOutBrkdwnDtls</b> (Cash Out Breakdown Details) of type array of FundCashOutBreakdown1.
        /// </summary>
        [XmlElementAttribute("CshOutBrkdwnDtls", Order=4)]
        public FundCashOutBreakdown1[] CshOutBrkdwnDtls;
    }
    
    /// <summary>
    /// Class <b>InvestmentFundTransactionInType1</b> (Investment Fund Transaction In Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class InvestmentFundTransactionInType1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type InvestmentFundTransactionInType3Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InvestmentFundTransactionInType3Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>InvestmentFundTransactionInType3Code</b> (Investment Fund Transaction In Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public enum InvestmentFundTransactionInType3Code
    {
        
        /// <summary>
        /// <b>SUBS - Substracted</b>.
        /// </summary>
        SUBS,
        
        /// <summary>
        /// <b>SWII - Switch In</b>.
        /// </summary>
        SWII,
        
        /// <summary>
        /// <b>INSP - In Specie</b>.
        /// </summary>
        INSP,
        
        /// <summary>
        /// <b>CROI - Cross In</b>.
        /// </summary>
        CROI,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>FundCashInBreakdown1</b> (Fund Cash In Breakdown 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class FundCashInBreakdown1
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveOrHistoricCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>UnitsNb</b> (Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public FinancialInstrumentQuantity1 UnitsNb;
        
        /// <summary>
        /// Element <b>NewAmtInd</b> (New Amount Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool NewAmtInd;
        
        /// <summary>
        /// Element <b>NewAmtIndSpecified</b> (New Amount Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewAmtIndSpecified;
        
        /// <summary>
        /// Element <b>InvstmtFndTxInTpDtls</b> (Investment Fund Transaction In Type Details) of type InvestmentFundTransactionInType1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InvestmentFundTransactionInType1 InvstmtFndTxInTpDtls;
        
        /// <summary>
        /// Element <b>OrgnlOrdrQtyDtls</b> (Original Order Quantity Details) of type OriginalOrderQuantityType1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public OriginalOrderQuantityType1 OrgnlOrdrQtyDtls;
        
        /// <summary>
        /// Element <b>ComssnDtls</b> (Commission Details) of type array of Commission4.
        /// </summary>
        [XmlElementAttribute("ComssnDtls", Order=5)]
        public Commission4[] ComssnDtls;
    }
    
    /// <summary>
    /// Class <b>CashInForecast1</b> (Cash In Forecast 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class CashInForecast1
    {
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SubTtlAmt</b> (Sub Total Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount SubTtlAmt;
        
        /// <summary>
        /// Element <b>SubTtlUnitsNb</b> (Sub Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstrumentQuantity1 SubTtlUnitsNb;
        
        /// <summary>
        /// Element <b>XcptnlCshFlowInd</b> (Exceptional Cash Flow Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool XcptnlCshFlowInd;
        
        /// <summary>
        /// Element <b>XcptnlCshFlowIndSpecified</b> (Exceptional Cash Flow Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XcptnlCshFlowIndSpecified;
        
        /// <summary>
        /// Element <b>CshInBrkdwnDtls</b> (Cash In Breakdown Details) of type array of FundCashInBreakdown1.
        /// </summary>
        [XmlElementAttribute("CshInBrkdwnDtls", Order=4)]
        public FundCashInBreakdown1[] CshInBrkdwnDtls;
    }
    
    /// <summary>
    /// Class <b>DataFormat2Choice</b> (Data Format 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class DataFormat2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type GenericIdentification1 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    /// Class <b>ReportParameter2Choice</b> (Report Parameter 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class ReportParameter2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Ccy (Currency) of type string 
        /// Ctry (Country) of type string 
        /// Pty (Party) of type PartyIdentification2Choice 
        /// UsrDfnd (User Defined) of type DataFormat2Choice 
        /// </summary>
        [XmlElementAttribute("Ccy", typeof(string), Order=0)]
        [XmlElementAttribute("Ctry", typeof(string), Order=0)]
        [XmlElementAttribute("Pty", typeof(PartyIdentification2Choice), Order=0)]
        [XmlElementAttribute("UsrDfnd", typeof(DataFormat2Choice), Order=0)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>Ccy - Currency</b>.
        /// </summary>
        Ccy,
        
        /// <summary>
        /// <b>Ctry - Country</b>.
        /// </summary>
        Ctry,
        
        /// <summary>
        /// <b>Pty - Party</b>.
        /// </summary>
        Pty,
        
        /// <summary>
        /// <b>UsrDfnd - User Defined</b>.
        /// </summary>
        UsrDfnd,
    }
    
    /// <summary>
    /// Class <b>ForecastParameter2</b> (Forecast Parameter 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class ForecastParameter2
    {
        
        /// <summary>
        /// Element <b>RptParam</b> (Report Parameter) of type ReportParameter2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ReportParameter2Choice RptParam;
        
        /// <summary>
        /// Element <b>CshInFcstDtls</b> (Cash In Forecast Details) of type array of CashInForecast1.
        /// </summary>
        [XmlElementAttribute("CshInFcstDtls", Order=1)]
        public CashInForecast1[] CshInFcstDtls;
        
        /// <summary>
        /// Element <b>CshOutFcstDtls</b> (Cash Out Forecast Details) of type array of CashOutForecast1.
        /// </summary>
        [XmlElementAttribute("CshOutFcstDtls", Order=2)]
        public CashOutForecast1[] CshOutFcstDtls;
        
        /// <summary>
        /// Element <b>NetCshFcstDtls</b> (Net Cash Forecast Details) of type array of NetCashForecast1.
        /// </summary>
        [XmlElementAttribute("NetCshFcstDtls", Order=3)]
        public NetCashForecast1[] NetCshFcstDtls;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification2</b> (Generic Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class GenericIdentification2
    {
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>DataFormat1Choice</b> (Data Format 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class DataFormat1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type GenericIdentification2 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(GenericIdentification2), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>SortCriteria1Choice</b> (Sort Criteria 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class SortCriteria1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Prdfnd (Predefined) of type ReportSortedType1Code 
        /// UsrDfnd (User Defined) of type DataFormat1Choice 
        /// </summary>
        [XmlElementAttribute("Prdfnd", typeof(ReportSortedType1Code), Order=0)]
        [XmlElementAttribute("UsrDfnd", typeof(DataFormat1Choice), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ReportSortedType1Code</b> (Report Sorted Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public enum ReportSortedType1Code
    {
        
        /// <summary>
        /// <b>COUN - Consularized</b>.
        /// </summary>
        COUN,
        
        /// <summary>
        /// <b>PART - Formal Partnership</b>.
        /// </summary>
        PART,
        
        /// <summary>
        /// <b>CURR - Incorrect Currency</b>.
        /// </summary>
        CURR,
    }
    
    /// <summary>
    /// Class <b>CashSortingCriterion2</b> (Cash Sorting Criterion 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class CashSortingCriterion2
    {
        
        /// <summary>
        /// Element <b>SrtgCritnTp</b> (Sorting Criterion Type) of type SortCriteria1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SortCriteria1Choice SrtgCritnTp;
        
        /// <summary>
        /// Element <b>FcstBrkdwnDtls</b> (Forecast Breakdown Details) of type array of ForecastParameter2.
        /// </summary>
        [XmlElementAttribute("FcstBrkdwnDtls", Order=1)]
        public ForecastParameter2[] FcstBrkdwnDtls;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02", IncludeInSchema=false)]
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
    /// Class <b>SecurityIdentification1Choice</b> (Security Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02", IncludeInSchema=false)]
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
    /// Class <b>FinancialInstrument5</b> (Financial Instrument 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class FinancialInstrument5
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
        /// Element <b>ReqdNAVCcy</b> (Requested NAV Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string ReqdNAVCcy;
        
        /// <summary>
        /// Element <b>ClssTp</b> (Class Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string ClssTp;
        
        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FormOfSecurity1Code SctiesForm;
        
        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;
        
        /// <summary>
        /// Element <b>DstrbtnPlcy</b> (Distribution Policy) of type DistributionPolicy1Code.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public DistributionPolicy1Code DstrbtnPlcy;
        
        /// <summary>
        /// Element <b>DstrbtnPlcySpecified</b> (Distribution Policy Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified;
        
        /// <summary>
        /// Element <b>DualFndInd</b> (Dual Fund Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public bool DualFndInd;
    }
    
    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02", IncludeInSchema=false)]
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
    /// Class <b>FundCashForecast2</b> (Fund Cash Forecast 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:camt.043.001.02")]
    public class FundCashForecast2
    {
        
        /// <summary>
        /// Element <b>TradDtTm</b> (Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateAndDateTimeChoice TradDtTm;
        
        /// <summary>
        /// Element <b>PrvsTradDtTm</b> (Previous Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DateAndDateTimeChoice PrvsTradDtTm;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument5.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public FinancialInstrument5 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>TtlNAV</b> (Total NAV) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveOrHistoricCurrencyAndAmount TtlNAV;
        
        /// <summary>
        /// Element <b>PrvsTtlNAV</b> (Previous Total NAV) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public ActiveOrHistoricCurrencyAndAmount PrvsTtlNAV;
        
        /// <summary>
        /// Element <b>TtlUnitsNb</b> (Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstrumentQuantity1 TtlUnitsNb;
        
        /// <summary>
        /// Element <b>PrvsTtlUnitsNb</b> (Previous Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public FinancialInstrumentQuantity1 PrvsTtlUnitsNb;
        
        /// <summary>
        /// Element <b>TtlNAVChngRate</b> (Total NAV Change Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public decimal TtlNAVChngRate;
        
        /// <summary>
        /// Element <b>TtlNAVChngRateSpecified</b> (Total NAV Change Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TtlNAVChngRateSpecified;
        
        /// <summary>
        /// Element <b>InvstmtCcy</b> (Investment Currency) of type array of string.
        /// </summary>
        [XmlElementAttribute("InvstmtCcy", Order=8)]
        public string[] InvstmtCcy;
        
        /// <summary>
        /// Element <b>XcptnlNetCshFlowInd</b> (Exceptional Net Cash Flow Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public bool XcptnlNetCshFlowInd;
        
        /// <summary>
        /// Element <b>SrtgCritDtls</b> (Sorting Criteria Details) of type array of CashSortingCriterion2.
        /// </summary>
        [XmlElementAttribute("SrtgCritDtls", Order=10)]
        public CashSortingCriterion2[] SrtgCritDtls;
        
        /// <summary>
        /// Element <b>NetCshFcstDtls</b> (Net Cash Forecast Details) of type array of NetCashForecast1.
        /// </summary>
        [XmlElementAttribute("NetCshFcstDtls", Order=11)]
        public NetCashForecast1[] NetCshFcstDtls;
    }
}
