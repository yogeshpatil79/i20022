
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



namespace i20022.reda00200102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id reda.002.001.02 name PriceReportCancellationV02 from Reference Data business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>reda00200102</b> (reda 00200102) of type reda00200102.
        /// </summary>
        [XmlElementAttribute("reda.002.001.02", Order=0)]
        public reda00200102 reda00200102;
    }
    
    /// <summary>
    /// Class <b>reda00200102</b> (reda 00200102).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="reda.002.001.02", Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class reda00200102
    {
        
        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AdditionalReference3 PoolRef;
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AdditionalReference3 PrvsRef;
        
        /// <summary>
        /// Element <b>PricRptToBeCanc</b> (Price Report To Be Cancelled) of type PriceReport1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PriceReport1 PricRptToBeCanc;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    /// Class <b>DateTimePeriodDetails</b> (Date Time Period Details).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class DateTimePeriodDetails
    {
        
        /// <summary>
        /// Element <b>FrDtTm</b> (From Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public System.DateTime FrDtTm;
        
        /// <summary>
        /// Element <b>ToDtTm</b> (To Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime ToDtTm;
    }
    
    /// <summary>
    /// Class <b>StatisticsByUserDefinedTimePeriod1</b> (Statistics By User Defined Time Period 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class StatisticsByUserDefinedTimePeriod1
    {
        
        /// <summary>
        /// Element <b>Prd</b> (Period) of type DateTimePeriodDetails.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DateTimePeriodDetails Prd;
        
        /// <summary>
        /// Element <b>HghstPricVal</b> (Highest Price Value) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceValue1 HghstPricVal;
        
        /// <summary>
        /// Element <b>LwstPricVal</b> (Lowest Price Value) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PriceValue1 LwstPricVal;
        
        /// <summary>
        /// Element <b>PricChng</b> (Price Change) of type PriceValue2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PriceValue2 PricChng;
        
        /// <summary>
        /// Element <b>Yld</b> (Yield) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public decimal Yld;
        
        /// <summary>
        /// Element <b>YldSpecified</b> (Yield Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YldSpecified;
    }
    
    /// <summary>
    /// Class <b>PriceValue1</b> (Price Value 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    /// Class <b>PriceValue2</b> (Price Value 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class PriceValue2
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt;
        
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
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAnd13DecimalAmount</b> (Active Or Historic Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class ActiveOrHistoricCurrencyAnd13DecimalAmount
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
    /// Class <b>StatisticsByPredefinedTimePeriods1</b> (Statistics By Predefined Time Periods 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class StatisticsByPredefinedTimePeriods1
    {
        
        /// <summary>
        /// Element <b>HghstPricVal12Mnths</b> (Highest Price Value 12 Months) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PriceValue1 HghstPricVal12Mnths;
        
        /// <summary>
        /// Element <b>LwstPricVal12Mnths</b> (Lowest Price Value 12 Months) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceValue1 LwstPricVal12Mnths;
        
        /// <summary>
        /// Element <b>OneYrPricChng</b> (One Year Price Change) of type PriceValue2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PriceValue2 OneYrPricChng;
        
        /// <summary>
        /// Element <b>ThreeYrPricChng</b> (Three Year Price Change) of type PriceValue2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PriceValue2 ThreeYrPricChng;
        
        /// <summary>
        /// Element <b>FiveYrPricChng</b> (Five Year Price Change) of type PriceValue2.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PriceValue2 FiveYrPricChng;
    }
    
    /// <summary>
    /// Class <b>ValuationStatistics2</b> (Valuation Statistics 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class ValuationStatistics2
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ccy;
        
        /// <summary>
        /// Element <b>PricTpChngBsis</b> (Price Type Change Basis) of type PriceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceType2 PricTpChngBsis;
        
        /// <summary>
        /// Element <b>PricChng</b> (Price Change) of type PriceValue2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PriceValue2 PricChng;
        
        /// <summary>
        /// Element <b>Yld</b> (Yield) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public decimal Yld;
        
        /// <summary>
        /// Element <b>YldSpecified</b> (Yield Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YldSpecified;
        
        /// <summary>
        /// Element <b>ByPrdfndTmPrds</b> (By Predefined Time Periods) of type StatisticsByPredefinedTimePeriods1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public StatisticsByPredefinedTimePeriods1 ByPrdfndTmPrds;
        
        /// <summary>
        /// Element <b>ByUsrDfndTmPrd</b> (By User Defined Time Period) of type array of StatisticsByUserDefinedTimePeriod1.
        /// </summary>
        [XmlElementAttribute("ByUsrDfndTmPrd", Order=5)]
        public StatisticsByUserDefinedTimePeriod1[] ByUsrDfndTmPrd;
    }
    
    /// <summary>
    /// Class <b>PriceType2</b> (Price Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class PriceType2
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TypeOfPrice6Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TypeOfPrice6Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TypeOfPrice6Code</b> (Type Of Price 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public enum TypeOfPrice6Code
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
        
        /// <summary>
        /// <b>DDVR - Daily Dividend Rate</b>.
        /// </summary>
        DDVR,
        
        /// <summary>
        /// <b>ACTU - Actual</b>.
        /// </summary>
        ACTU,
        
        /// <summary>
        /// <b>NAUP - Non Adjusted Unpublished</b>.
        /// </summary>
        NAUP,
    }
    
    /// <summary>
    /// Class <b>EUCapitalGain1</b> (EU Capital Gain 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class EUCapitalGain1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type EUCapitalGain1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public EUCapitalGain1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>EUCapitalGain1Code</b> (EU Capital Gain 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public enum EUCapitalGain1Code
    {
        
        /// <summary>
        /// <b>EUSI - Capital Gain In Scope</b>.
        /// </summary>
        EUSI,
        
        /// <summary>
        /// <b>EUSO - Capital Gain Out Scope</b>.
        /// </summary>
        EUSO,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>TaxCalculationInformation2</b> (Tax Calculation Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class TaxCalculationInformation2
    {
        
        /// <summary>
        /// Element <b>EUCptlGn</b> (EU Capital Gain) of type EUCapitalGain1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public EUCapitalGain1 EUCptlGn;
        
        /// <summary>
        /// Element <b>PctgOfDebtClm</b> (Percentage Of Debt Claim) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal PctgOfDebtClm;
        
        /// <summary>
        /// Element <b>PctgOfDebtClmSpecified</b> (Percentage Of Debt Claim Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PctgOfDebtClmSpecified;
        
        /// <summary>
        /// Element <b>PctgGrdfthdDebt</b> (Percentage Grandfathered Debt) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public decimal PctgGrdfthdDebt;
        
        /// <summary>
        /// Element <b>PctgGrdfthdDebtSpecified</b> (Percentage Grandfathered Debt Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PctgGrdfthdDebtSpecified;
    }
    
    /// <summary>
    /// Class <b>TaxType3</b> (Tax Type 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class TaxType3
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TaxType6Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxType6Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TaxType6Code</b> (Tax Type 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public enum TaxType6Code
    {
        
        /// <summary>
        /// <b>INPO - Interim Profit Tax</b>.
        /// </summary>
        INPO,
        
        /// <summary>
        /// <b>EUTR - EUTax Retention</b>.
        /// </summary>
        EUTR,
        
        /// <summary>
        /// <b>AKT1 - Aktiengewinn 1</b>.
        /// </summary>
        AKT1,
        
        /// <summary>
        /// <b>AKT2 - Aktiengewinn 2</b>.
        /// </summary>
        AKT2,
        
        /// <summary>
        /// <b>ZWIS - Zwischengewinn</b>.
        /// </summary>
        ZWIS,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>Tax8</b> (Tax 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class Tax8
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type TaxType3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxType3 Tp;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt;
        
        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public decimal Rate;
        
        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateSpecified;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Ctry;
        
        /// <summary>
        /// Element <b>TaxClctnDtls</b> (Tax Calculation Details) of type TaxCalculationInformation2.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public TaxCalculationInformation2 TaxClctnDtls;
    }
    
    /// <summary>
    /// Class <b>CalculationBasis1</b> (Calculation Basis 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class CalculationBasis1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type CalculationBasis1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CalculationBasis1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>CalculationBasis1Code</b> (Calculation Basis 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public enum CalculationBasis1Code
    {
        
        /// <summary>
        /// <b>AVER - Average</b>.
        /// </summary>
        AVER,
        
        /// <summary>
        /// <b>DAIL - Daily</b>.
        /// </summary>
        DAIL,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>ChargeType2</b> (Charge Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class ChargeType2
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type ChargeType7Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ChargeType7Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeType7Code</b> (Charge Type 7Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public enum ChargeType7Code
    {
        
        /// <summary>
        /// <b>MANF - Management Fee</b>.
        /// </summary>
        MANF,
        
        /// <summary>
        /// <b>BEND - Back End Load</b>.
        /// </summary>
        BEND,
        
        /// <summary>
        /// <b>ADVI - Advisory Fee</b>.
        /// </summary>
        ADVI,
        
        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,
        
        /// <summary>
        /// <b>PUBL - Publication Fee</b>.
        /// </summary>
        PUBL,
        
        /// <summary>
        /// <b>ACCT - Accounting Fee</b>.
        /// </summary>
        ACCT,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>EQUL - Equalisation</b>.
        /// </summary>
        EQUL,
    }
    
    /// <summary>
    /// Class <b>Charge9</b> (Charge 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class Charge9
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type ChargeType2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ChargeType2 Tp;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
        
        /// <summary>
        /// Element <b>ClctnBsis</b> (Calculation Basis) of type CalculationBasis1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CalculationBasis1 ClctnBsis;
    }
    
    /// <summary>
    /// Class <b>TaxableIncomePerShareCalculated1</b> (Taxable Income Per Share Calculated 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class TaxableIncomePerShareCalculated1
    {
        
        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TaxableIncomePerShareCalculated1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxableIncomePerShareCalculated1Code Strd;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>TaxableIncomePerShareCalculated1Code</b> (Taxable Income Per Share Calculated 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public enum TaxableIncomePerShareCalculated1Code
    {
        
        /// <summary>
        /// <b>TSIY - Fund Calculates</b>.
        /// </summary>
        TSIY,
        
        /// <summary>
        /// <b>TSIN - Fund Does Not Calculate</b>.
        /// </summary>
        TSIN,
        
        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>UnitPrice4</b> (Unit Price 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class UnitPrice4
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type TypeOfPrice8Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TypeOfPrice8Code Tp;
        
        /// <summary>
        /// Element <b>Val</b> (Value) of type PriceValue1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceValue1 Val;
    }
    
    /// <summary>
    /// Enumeration <b>TypeOfPrice8Code</b> (Type Of Price 8Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public enum TypeOfPrice8Code
    {
        
        /// <summary>
        /// <b>ACTU - Actual</b>.
        /// </summary>
        ACTU,
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    /// Class <b>AmountPrice1Choice</b> (Amount Price 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class AmountPrice1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type CurrencyAndAmount 
        /// UnitPric (Unit Price) of type UnitPrice4 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("UnitPric", typeof(UnitPrice4), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>UnitPrice6</b> (Unit Price 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class UnitPrice6
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type PriceType2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PriceType2 Tp;
        
        /// <summary>
        /// Element <b>PricMtd</b> (Price Method) of type PriceMethod1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PriceMethod1Code PricMtd;
        
        /// <summary>
        /// Element <b>PricMtdSpecified</b> (Price Method Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricMtdSpecified;
        
        /// <summary>
        /// Element <b>ValInInvstmtCcy</b> (Value In Investment Currency) of type array of PriceValue1.
        /// </summary>
        [XmlElementAttribute("ValInInvstmtCcy", Order=2)]
        public PriceValue1[] ValInInvstmtCcy;
        
        /// <summary>
        /// Element <b>ValInAltrntvCcy</b> (Value In Alternative Currency) of type array of PriceValue1.
        /// </summary>
        [XmlElementAttribute("ValInAltrntvCcy", Order=3)]
        public PriceValue1[] ValInAltrntvCcy;
        
        /// <summary>
        /// Element <b>ForExctnInd</b> (For Execution Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public bool ForExctnInd;
        
        /// <summary>
        /// Element <b>CumDvddInd</b> (Cum Dividend Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public bool CumDvddInd;
        
        /// <summary>
        /// Element <b>ClctnBsis</b> (Calculation Basis) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public decimal ClctnBsis;
        
        /// <summary>
        /// Element <b>ClctnBsisSpecified</b> (Calculation Basis Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClctnBsisSpecified;
        
        /// <summary>
        /// Element <b>NbOfDaysAcrd</b> (Number Of Days Accrued) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public decimal NbOfDaysAcrd;
        
        /// <summary>
        /// Element <b>NbOfDaysAcrdSpecified</b> (Number Of Days Accrued Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NbOfDaysAcrdSpecified;
        
        /// <summary>
        /// Element <b>TaxblIncmPerShr</b> (Taxable Income Per Share) of type AmountPrice1Choice.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public AmountPrice1Choice TaxblIncmPerShr;
        
        /// <summary>
        /// Element <b>TaxblIncmPerShrClctd</b> (Taxable Income Per Share Calculated) of type TaxableIncomePerShareCalculated1.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public TaxableIncomePerShareCalculated1 TaxblIncmPerShrClctd;
        
        /// <summary>
        /// Element <b>ChrgDtls</b> (Charge Details) of type array of Charge9.
        /// </summary>
        [XmlElementAttribute("ChrgDtls", Order=10)]
        public Charge9[] ChrgDtls;
        
        /// <summary>
        /// Element <b>TaxLbltyDtls</b> (Tax Liability Details) of type array of Tax8.
        /// </summary>
        [XmlElementAttribute("TaxLbltyDtls", Order=11)]
        public Tax8[] TaxLbltyDtls;
        
        /// <summary>
        /// Element <b>TaxRfndDtls</b> (Tax Refund Details) of type array of Tax8.
        /// </summary>
        [XmlElementAttribute("TaxRfndDtls", Order=12)]
        public Tax8[] TaxRfndDtls;
    }
    
    /// <summary>
    /// Enumeration <b>PriceMethod1Code</b> (Price Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class FinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Unit;
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02", IncludeInSchema=false)]
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
    /// Class <b>PriceValuation2</b> (Price Valuation 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class PriceValuation2
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>ValtnDtTm</b> (Valuation Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DateAndDateTimeChoice ValtnDtTm;
        
        /// <summary>
        /// Element <b>TradDtTm</b> (Trade Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateAndDateTimeChoice TradDtTm;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument5.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public FinancialInstrument5 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>TtlNAV</b> (Total NAV) of type array of ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute("TtlNAV", Order=4)]
        public ActiveOrHistoricCurrencyAndAmount[] TtlNAV;
        
        /// <summary>
        /// Element <b>TtlUnitsNb</b> (Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstrumentQuantity1 TtlUnitsNb;
        
        /// <summary>
        /// Element <b>NxtValtnDtTm</b> (Next Valuation Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public DateAndDateTimeChoice NxtValtnDtTm;
        
        /// <summary>
        /// Element <b>PrvsValtnDtTm</b> (Previous Valuation Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public DateAndDateTimeChoice PrvsValtnDtTm;
        
        /// <summary>
        /// Element <b>ValtnCycl</b> (Valuation Cycle) of type ValuationTiming1Code.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public ValuationTiming1Code ValtnCycl;
        
        /// <summary>
        /// Element <b>SspdInd</b> (Suspended Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public bool SspdInd;
        
        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type array of UnitPrice6.
        /// </summary>
        [XmlElementAttribute("PricDtls", Order=10)]
        public UnitPrice6[] PricDtls;
        
        /// <summary>
        /// Element <b>ValtnSttstcs</b> (Valuation Statistics) of type array of ValuationStatistics2.
        /// </summary>
        [XmlElementAttribute("ValtnSttstcs", Order=11)]
        public ValuationStatistics2[] ValtnSttstcs;
    }
    
    /// <summary>
    /// Enumeration <b>ValuationTiming1Code</b> (Valuation Timing 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public enum ValuationTiming1Code
    {
        
        /// <summary>
        /// <b>EXCP - Exceptional</b>.
        /// </summary>
        EXCP,
        
        /// <summary>
        /// <b>USUA - Usual Transaction Time</b>.
        /// </summary>
        USUA,
        
        /// <summary>
        /// <b>PATC - Particular</b>.
        /// </summary>
        PATC,
    }
    
    /// <summary>
    /// Class <b>PriceReport1</b> (Price Report 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
    public class PriceReport1
    {
        
        /// <summary>
        /// Element <b>PricValtnDtls</b> (Price Valuation Details) of type array of PriceValuation2.
        /// </summary>
        [XmlElementAttribute("PricValtnDtls", Order=0)]
        public PriceValuation2[] PricValtnDtls;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=1)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:reda.002.001.02")]
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
