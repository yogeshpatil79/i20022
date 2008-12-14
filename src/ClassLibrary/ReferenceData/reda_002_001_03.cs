
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


namespace i20022.reda00200103
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id reda.002.001.03 name PriceReportCancellationV03 from Reference Data business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>PricRptCxlV03</b> (Price Report Cancellation V03) of type PriceReportCancellationV03.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PriceReportCancellationV03 PricRptCxlV03;
    }

    /// <summary>
    /// Class <b>PriceReportCancellationV03</b> (Price Report Cancellation V03).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PriceReportCancellationV03
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MsgId;

        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AdditionalReference3 PoolRef;

        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public AdditionalReference3 PrvsRef;

        /// <summary>
        /// Element <b>MsgPgntn</b> (Message Pagination) of type Pagination.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public Pagination MsgPgntn;

        /// <summary>
        /// Element <b>PricRptToBeCanc</b> (Price Report To Be Cancelled) of type PriceReport2.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PriceReport2 PricRptToBeCanc;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class MessageIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CreDtTm;
    }

    /// <summary>
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class Extension1
    {

        /// <summary>
        /// Element <b>PlcAndNm</b> (Place And Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string PlcAndNm;

        /// <summary>
        /// Element <b>Txt</b> (Txt) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Txt;
    }

    /// <summary>
    /// Class <b>PerformanceFactors1</b> (Performance Factors 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PerformanceFactors1
    {

        /// <summary>
        /// Element <b>CorpActnFctr</b> (Corporate Action Factor) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public decimal CorpActnFctr;

        /// <summary>
        /// Element <b>CorpActnFctrSpecified</b> (Corporate Action Factor Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CorpActnFctrSpecified;

        /// <summary>
        /// Element <b>CmltvCorpActnFctr</b> (Cmltv Corporate Action Factor) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal CmltvCorpActnFctr;

        /// <summary>
        /// Element <b>CmltvCorpActnFctrSpecified</b> (Cmltv Corporate Action Factor Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CmltvCorpActnFctrSpecified;

        /// <summary>
        /// Element <b>AcmltnPrd</b> (Accumulation Period) of type DatePeriodDetails.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DatePeriodDetails AcmltnPrd;

        /// <summary>
        /// Element <b>NrmlPrfrmnc</b> (Nrml Prfrmnc) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal NrmlPrfrmnc;

        /// <summary>
        /// Element <b>NrmlPrfrmncSpecified</b> (Nrml Prfrmnc Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NrmlPrfrmncSpecified;
    }

    /// <summary>
    /// Class <b>DatePeriodDetails</b> (Date Period Details).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class DatePeriodDetails
    {

        /// <summary>
        /// Element <b>FrDt</b> (From Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 0 )]
        public System.DateTime FrDt;

        /// <summary>
        /// Element <b>ToDt</b> (To Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 1 )]
        public System.DateTime ToDt;
    }

    /// <summary>
    /// Class <b>DateTimePeriodDetails</b> (Date Time Period Details).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class DateTimePeriodDetails
    {

        /// <summary>
        /// Element <b>FrDtTm</b> (From Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public System.DateTime FrDtTm;

        /// <summary>
        /// Element <b>ToDtTm</b> (To Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime ToDtTm;
    }

    /// <summary>
    /// Class <b>DateOrDateTimePeriodChoice</b> (Date Or Date Time Period Choice).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class DateOrDateTimePeriodChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Dt of type DatePeriodDetails 
        ///  DtTm of type DateTimePeriodDetails 
        /// </summary>
        [XmlElementAttribute( "Dt", typeof( DatePeriodDetails ), Order = 0 )]
        [XmlElementAttribute( "DtTm", typeof( DateTimePeriodDetails ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>StatisticsByUserDefinedTimePeriod2</b> (Statistics By User Defined Time Period 2).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class StatisticsByUserDefinedTimePeriod2
    {

        /// <summary>
        /// Element <b>Prd</b> (Period) of type DateOrDateTimePeriodChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public DateOrDateTimePeriodChoice Prd;

        /// <summary>
        /// Element <b>HghstPricVal</b> (Highest Price Value) of type PriceValue5.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PriceValue5 HghstPricVal;

        /// <summary>
        /// Element <b>LwstPricVal</b> (Lowest Price Value) of type PriceValue5.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PriceValue5 LwstPricVal;

        /// <summary>
        /// Element <b>PricChng</b> (Price Change) of type PriceValueChange1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PriceValueChange1 PricChng;

        /// <summary>
        /// Element <b>Yld</b> (Yield) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public decimal Yld;

        /// <summary>
        /// Element <b>YldSpecified</b> (Yield Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool YldSpecified;
    }

    /// <summary>
    /// Class <b>PriceValue5</b> (Price Value 5).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PriceValue5
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt;
    }

    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAnd13DecimalAmount</b> (Active Or Historic Currency And 13 Decimal Amount).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class ActiveOrHistoricCurrencyAnd13DecimalAmount
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
    /// Class <b>PriceValueChange1</b> (Price Value Change 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PriceValueChange1
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt;

        /// <summary>
        /// Element <b>AmtSgn</b> (Amount Sign) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool AmtSgn;

        /// <summary>
        /// Element <b>AmtSgnSpecified</b> (Amount Sign Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AmtSgnSpecified;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;
    }

    /// <summary>
    /// Class <b>StatisticsByPredefinedTimePeriods2</b> (Statistics By Predefined Time Periods 2).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class StatisticsByPredefinedTimePeriods2
    {

        /// <summary>
        /// Element <b>HghstPricVal12Mnths</b> (Highest Price Value 12 Months) of type PriceValue5.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PriceValue5 HghstPricVal12Mnths;

        /// <summary>
        /// Element <b>LwstPricVal12Mnths</b> (Lowest Price Value 12 Months) of type PriceValue5.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PriceValue5 LwstPricVal12Mnths;

        /// <summary>
        /// Element <b>OneYrPricChng</b> (One Year Price Change) of type PriceValueChange1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PriceValueChange1 OneYrPricChng;

        /// <summary>
        /// Element <b>ThreeYrPricChng</b> (Three Year Price Change) of type PriceValueChange1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PriceValueChange1 ThreeYrPricChng;

        /// <summary>
        /// Element <b>FiveYrPricChng</b> (Five Year Price Change) of type PriceValueChange1.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PriceValueChange1 FiveYrPricChng;
    }

    /// <summary>
    /// Class <b>PriceType2</b> (Price Type 2).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PriceType2
    {

        /// <summary>
        /// Element <b>Strd</b> (Structured) of type TypeOfPrice6Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public TypeOfPrice6Code Strd;

        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string AddtlInf;
    }

    /// <summary>
    /// Enumeration <b>TypeOfPrice6Code</b> (Type Of Price 6Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum TypeOfPrice6Code
    {

        /// <summary>
        /// <b>BIDE - Bid</b>.
        /// </summary>
        BIDE,

        /// <summary>
        /// <b>OFFR - Offer</b>.
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
    /// Class <b>ValuationStatistics3</b> (Valuation Statistics 3).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class ValuationStatistics3
    {

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ccy;

        /// <summary>
        /// Element <b>PricTpChngBsis</b> (Price Type Change Basis) of type PriceType2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PriceType2 PricTpChngBsis;

        /// <summary>
        /// Element <b>PricChng</b> (Price Change) of type PriceValueChange1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PriceValueChange1 PricChng;

        /// <summary>
        /// Element <b>Yld</b> (Yield) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal Yld;

        /// <summary>
        /// Element <b>YldSpecified</b> (Yield Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool YldSpecified;

        /// <summary>
        /// Element <b>ByPrdfndTmPrds</b> (By Predefined Time Periods) of type StatisticsByPredefinedTimePeriods2.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public StatisticsByPredefinedTimePeriods2 ByPrdfndTmPrds;

        /// <summary>
        /// Element <b>ByUsrDfndTmPrd</b> (By User Defined Time Period) of type array of StatisticsByUserDefinedTimePeriod2.
        /// </summary>
        [XmlElementAttribute( "ByUsrDfndTmPrd", Order = 5 )]
        public StatisticsByUserDefinedTimePeriod2[] ByUsrDfndTmPrd;
    }

    /// <summary>
    /// Class <b>TaxCalculationInformation4</b> (Tax Calculation Information 4).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class TaxCalculationInformation4
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  EUCptlGn of type EUCapitalGain2Code 
        ///  XtndedEUCptlGn of type string 
        /// </summary>
        [XmlElementAttribute( "EUCptlGn", typeof( EUCapitalGain2Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedEUCptlGn", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>PctgOfDebtClm</b> (Percentage Of Debt Claim) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal PctgOfDebtClm;

        /// <summary>
        /// Element <b>PctgOfDebtClmSpecified</b> (Percentage Of Debt Claim Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PctgOfDebtClmSpecified;

        /// <summary>
        /// Element <b>PctgGrdfthdDebt</b> (Percentage Grandfathered Debt) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal PctgGrdfthdDebt;

        /// <summary>
        /// Element <b>PctgGrdfthdDebtSpecified</b> (Percentage Grandfathered Debt Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PctgGrdfthdDebtSpecified;

        /// <summary>
        /// Element <b>TaxblIncmPerDvdd</b> (Taxable Income Per Dividend) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount TaxblIncmPerDvdd;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  EUDvddSts of type EUDividendStatus1Code 
        ///  XtndedEUDvddSts of type string 
        /// </summary>
        [XmlElementAttribute( "EUDvddSts", typeof( EUDividendStatus1Code ), Order = 4 )]
        [XmlElementAttribute( "XtndedEUDvddSts", typeof( string ), Order = 4 )]
        public object Item1;
    }

    /// <summary>
    /// Enumeration <b>EUCapitalGain2Code</b> (EUCapital Gain 2Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum EUCapitalGain2Code
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
    }

    /// <summary>
    /// Enumeration <b>EUDividendStatus1Code</b> (EUDividend Status 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum EUDividendStatus1Code
    {

        /// <summary>
        /// <b>DIVI - Dividend In Scope</b>.
        /// </summary>
        DIVI,

        /// <summary>
        /// <b>DIVO - Dividend Out Scope</b>.
        /// </summary>
        DIVO,

        /// <summary>
        /// <b>UKWN - Unknown</b>.
        /// </summary>
        UKWN,
    }

    /// <summary>
    /// Class <b>Tax17</b> (Tax 17).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class Tax17
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type TaxType12Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( TaxType12Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type array of ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( "Amt", Order = 1 )]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount[] Amt;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;

        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Ctry;

        /// <summary>
        /// Element <b>TaxClctnDtls</b> (Tax Calculation Details) of type TaxCalculationInformation4.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public TaxCalculationInformation4 TaxClctnDtls;
    }

    /// <summary>
    /// Enumeration <b>TaxType12Code</b> (Tax Type 12 Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum TaxType12Code
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
        /// <b>MIET - Mietgewinn</b>.
        /// </summary>
        MIET,
    }

    /// <summary>
    /// Class <b>Charge15</b> (Charge 15).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class Charge15
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type ChargeType9Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( ChargeType9Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  Amt of type ActiveCurrencyAnd13DecimalAmount 
        ///  Rate of type decimal 
        /// </summary>
        [XmlElementAttribute( "Amt", typeof( ActiveCurrencyAnd13DecimalAmount ), Order = 1 )]
        [XmlElementAttribute( "Rate", typeof( decimal ), Order = 1 )]
        public object Item1;

        /// <summary>
        /// Element <b>Item2</b> (Item 2) of type object.
        /// This element can be:
        ///  ClctnBsis of type CalculationBasis2Code 
        ///  XtndedClctnBsis of type string 
        /// </summary>
        [XmlElementAttribute( "ClctnBsis", typeof( CalculationBasis2Code ), Order = 2 )]
        [XmlElementAttribute( "XtndedClctnBsis", typeof( string ), Order = 2 )]
        public object Item2;
    }

    /// <summary>
    /// Enumeration <b>ChargeType9Code</b> (Charge Type 9Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum ChargeType9Code
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
        /// <b>FEND - Front End Load</b>.
        /// </summary>
        FEND,

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
        /// <b>EQUL - Equalisation</b>.
        /// </summary>
        EQUL,

        /// <summary>
        /// <b>PENA - Penalty</b>.
        /// </summary>
        PENA,
    }

    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class ActiveCurrencyAnd13DecimalAmount
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
    /// Enumeration <b>CalculationBasis2Code</b> (Calculation Basis 2Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum CalculationBasis2Code
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
        /// <b>MNTH - Monthly</b>.
        /// </summary>
        MNTH,

        /// <summary>
        /// <b>YEAR - Annual</b>.
        /// </summary>
        YEAR,
    }

    /// <summary>
    /// Class <b>PriceValue1</b> (Price Value 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PriceValue1
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveCurrencyAnd13DecimalAmount Amt;
    }

    /// <summary>
    /// Class <b>UnitPrice15</b> (Unit Price 15).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class UnitPrice15
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type TypeOfPrice9Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( TypeOfPrice9Code ), Order = 0 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>PricMtd</b> (Price Method) of type PriceMethod1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PriceMethod1Code PricMtd;

        /// <summary>
        /// Element <b>PricMtdSpecified</b> (Price Method Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PricMtdSpecified;

        /// <summary>
        /// Element <b>ValInInvstmtCcy</b> (Value In Investment Currency) of type array of PriceValue1.
        /// </summary>
        [XmlElementAttribute( "ValInInvstmtCcy", Order = 2 )]
        public PriceValue1[] ValInInvstmtCcy;

        /// <summary>
        /// Element <b>ValInAltrntvCcy</b> (Value In Alternative Currency) of type array of PriceValue1.
        /// </summary>
        [XmlElementAttribute( "ValInAltrntvCcy", Order = 3 )]
        public PriceValue1[] ValInAltrntvCcy;

        /// <summary>
        /// Element <b>ForExctnInd</b> (For Execution Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public bool ForExctnInd;

        /// <summary>
        /// Element <b>CumDvddInd</b> (Cum Dividend Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public bool CumDvddInd;

        /// <summary>
        /// Element <b>ClctnBsis</b> (Calculation Basis) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public decimal ClctnBsis;

        /// <summary>
        /// Element <b>ClctnBsisSpecified</b> (Calculation Basis Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ClctnBsisSpecified;

        /// <summary>
        /// Element <b>EstmtdPricInd</b> (Estimated Price Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public bool EstmtdPricInd;

        /// <summary>
        /// Element <b>NbOfDaysAcrd</b> (Number Of Days Accrued) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public decimal NbOfDaysAcrd;

        /// <summary>
        /// Element <b>NbOfDaysAcrdSpecified</b> (Number Of Days Accrued Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NbOfDaysAcrdSpecified;

        /// <summary>
        /// Element <b>TaxblIncmPerShr</b> (Taxable Income Per Share) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount TaxblIncmPerShr;

        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// This element can be:
        ///  TaxblIncmPerShrClctd of type TaxableIncomePerShareCalculated2Code 
        ///  XtndedTaxblIncmPerShrClctd of type string 
        /// </summary>
        [XmlElementAttribute( "TaxblIncmPerShrClctd", typeof( TaxableIncomePerShareCalculated2Code ), Order = 10 )]
        [XmlElementAttribute( "XtndedTaxblIncmPerShrClctd", typeof( string ), Order = 10 )]
        public object Item1;

        /// <summary>
        /// Element <b>TaxblIncmPerDvdd</b> (Taxable Income Per Dividend) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount TaxblIncmPerDvdd;

        /// <summary>
        /// Element <b>Item2</b> (Item 2) of type object.
        /// This element can be:
        ///  EUDvddSts of type EUDividendStatus1Code 
        ///  XtndedEUDvddSts of type string 
        /// </summary>
        [XmlElementAttribute( "EUDvddSts", typeof( EUDividendStatus1Code ), Order = 12 )]
        [XmlElementAttribute( "XtndedEUDvddSts", typeof( string ), Order = 12 )]
        public object Item2;

        /// <summary>
        /// Element <b>ChrgDtls</b> (Charge Details) of type array of Charge15.
        /// </summary>
        [XmlElementAttribute( "ChrgDtls", Order = 13 )]
        public Charge15[] ChrgDtls;

        /// <summary>
        /// Element <b>TaxLbltyDtls</b> (Tax Liability Details) of type array of Tax17.
        /// </summary>
        [XmlElementAttribute( "TaxLbltyDtls", Order = 14 )]
        public Tax17[] TaxLbltyDtls;

        /// <summary>
        /// Element <b>TaxRfndDtls</b> (Tax Refund Details) of type array of Tax17.
        /// </summary>
        [XmlElementAttribute( "TaxRfndDtls", Order = 15 )]
        public Tax17[] TaxRfndDtls;
    }

    /// <summary>
    /// Enumeration <b>TypeOfPrice9Code</b> (Type Of Price 9Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum TypeOfPrice9Code
    {

        /// <summary>
        /// <b>BIDE - Bid</b>.
        /// </summary>
        BIDE,

        /// <summary>
        /// <b>OFFR - Offer</b>.
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

        /// <summary>
        /// <b>GUAR - Guaranteed</b>.
        /// </summary>
        GUAR,

        /// <summary>
        /// <b>ENAV - Estimated NAV</b>.
        /// </summary>
        ENAV,
    }

    /// <summary>
    /// Enumeration <b>PriceMethod1Code</b> (Price Method 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
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
    /// Enumeration <b>TaxableIncomePerShareCalculated2Code</b> (Taxable Income Per Share Calculated 2Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum TaxableIncomePerShareCalculated2Code
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
    }

    /// <summary>
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class FinancialInstrumentQuantity1
    {

        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public decimal Unit;
    }

    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class ActiveOrHistoricCurrencyAndAmount
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
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class AlternateSecurityIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "DmstIdSrc", typeof( string ), Order = 1 )]
        [XmlElementAttribute( "PrtryIdSrc", typeof( string ), Order = 1 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

        /// <summary>
        /// <b>DmstIdSrc - ?undefined</b>.
        /// </summary>
        DmstIdSrc,

        /// <summary>
        /// <b>PrtryIdSrc - ?undefined</b>.
        /// </summary>
        PrtryIdSrc,
    }

    /// <summary>
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class SecurityIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Belgn of type string 
        ///  Blmbrg of type string 
        ///  CTA of type string 
        ///  CUSIP of type string 
        ///  Cmon of type string 
        ///  Dtch of type string 
        ///  ISIN of type string 
        ///  OthrPrtryId of type AlternateSecurityIdentification1 
        ///  QUICK of type string 
        ///  RIC of type string 
        ///  SCVM of type string 
        ///  SEDOL of type string 
        ///  TckrSymb of type string 
        ///  Vlrn of type string 
        ///  Wrtppr of type string 
        /// </summary>
        [XmlElementAttribute( "Belgn", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Blmbrg", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CTA", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CUSIP", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Cmon", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Dtch", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ISIN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrPrtryId", typeof( AlternateSecurityIdentification1 ), Order = 0 )]
        [XmlElementAttribute( "QUICK", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "RIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SCVM", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SEDOL", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "TckrSymb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Vlrn", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Wrtppr", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

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
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03", IncludeInSchema = false )]
    public enum ItemChoiceType2
    {

        /// <summary>
        /// <b>Belgn - ?undefined</b>.
        /// </summary>
        Belgn,

        /// <summary>
        /// <b>Blmbrg - ?undefined</b>.
        /// </summary>
        Blmbrg,

        /// <summary>
        /// <b>CTA - ?undefined</b>.
        /// </summary>
        CTA,

        /// <summary>
        /// <b>CUSIP - ?undefined</b>.
        /// </summary>
        CUSIP,

        /// <summary>
        /// <b>Cmon - ?undefined</b>.
        /// </summary>
        Cmon,

        /// <summary>
        /// <b>Dtch - ?undefined</b>.
        /// </summary>
        Dtch,

        /// <summary>
        /// <b>ISIN - ?undefined</b>.
        /// </summary>
        ISIN,

        /// <summary>
        /// <b>OthrPrtryId - ?undefined</b>.
        /// </summary>
        OthrPrtryId,

        /// <summary>
        /// <b>QUICK - ?undefined</b>.
        /// </summary>
        QUICK,

        /// <summary>
        /// <b>RIC - ?undefined</b>.
        /// </summary>
        RIC,

        /// <summary>
        /// <b>SCVM - ?undefined</b>.
        /// </summary>
        SCVM,

        /// <summary>
        /// <b>SEDOL - ?undefined</b>.
        /// </summary>
        SEDOL,

        /// <summary>
        /// <b>TckrSymb - ?undefined</b>.
        /// </summary>
        TckrSymb,

        /// <summary>
        /// <b>Vlrn - ?undefined</b>.
        /// </summary>
        Vlrn,

        /// <summary>
        /// <b>Wrtppr - ?undefined</b>.
        /// </summary>
        Wrtppr,
    }

    /// <summary>
    /// Class <b>FinancialInstrument8</b> (Financial Instrument 8).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class FinancialInstrument8
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type array of SecurityIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( "Id", Order = 0 )]
        public SecurityIdentification3Choice[] Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;

        /// <summary>
        /// Element <b>SplmtryId</b> (Supplementary Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string SplmtryId;

        /// <summary>
        /// Element <b>DnmtnCcy</b> (Denomination Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string DnmtnCcy;

        /// <summary>
        /// Element <b>ClssTp</b> (Class Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string ClssTp;

        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public FormOfSecurity1Code SctiesForm;

        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;

        /// <summary>
        /// Element <b>DstrbtnPlcy</b> (Distribution Policy) of type DistributionPolicy1Code.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public DistributionPolicy1Code DstrbtnPlcy;

        /// <summary>
        /// Element <b>DstrbtnPlcySpecified</b> (Distribution Policy Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified;

        /// <summary>
        /// Element <b>DualFndInd</b> (Dual Fund Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public bool DualFndInd;
    }

    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum FormOfSecurity1Code
    {

        /// <summary>
        /// <b>BEAR - Bearer</b>.
        /// </summary>
        BEAR,

        /// <summary>
        /// <b>REGD - Registered</b>.
        /// </summary>
        REGD,
    }

    /// <summary>
    /// Enumeration <b>DistributionPolicy1Code</b> (Distribution Policy 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
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
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class DateAndDateTimeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( "Dt", typeof( System.DateTime ), DataType = "date", Order = 0 )]
        [XmlElementAttribute( "DtTm", typeof( System.DateTime ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public System.DateTime Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03", IncludeInSchema = false )]
    public enum ItemChoiceType
    {

        /// <summary>
        /// <b>Dt - ?undefined</b>.
        /// </summary>
        Dt,

        /// <summary>
        /// <b>DtTm - ?undefined</b>.
        /// </summary>
        DtTm,
    }

    /// <summary>
    /// Class <b>PriceValuation3</b> (Price Valuation 3).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PriceValuation3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>ValtnDtTm</b> (Valuation Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public DateAndDateTimeChoice ValtnDtTm;

        /// <summary>
        /// Element <b>NAVDtTm</b> (NAVDate Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DateAndDateTimeChoice NAVDtTm;

        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument8.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public FinancialInstrument8 FinInstrmDtls;

        /// <summary>
        /// Element <b>FndMgmtCpny</b> (Fund Management Cpny) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification2Choice FndMgmtCpny;

        /// <summary>
        /// Element <b>TtlNAV</b> (Total NAV) of type array of ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( "TtlNAV", Order = 5 )]
        public ActiveOrHistoricCurrencyAndAmount[] TtlNAV;

        /// <summary>
        /// Element <b>TtlUnitsNb</b> (Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public FinancialInstrumentQuantity1 TtlUnitsNb;

        /// <summary>
        /// Element <b>NxtValtnDtTm</b> (Next Valuation Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public DateAndDateTimeChoice NxtValtnDtTm;

        /// <summary>
        /// Element <b>PrvsValtnDtTm</b> (Previous Valuation Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public DateAndDateTimeChoice PrvsValtnDtTm;

        /// <summary>
        /// Element <b>ValtnTp</b> (Valuation Type) of type ValuationTiming1Code.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public ValuationTiming1Code ValtnTp;

        /// <summary>
        /// Element <b>ValtnFrqcy</b> (Valuation Frequency) of type EventFrequency1Code.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public EventFrequency1Code ValtnFrqcy;

        /// <summary>
        /// Element <b>ValtnFrqcySpecified</b> (Valuation Frequency Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ValtnFrqcySpecified;

        /// <summary>
        /// Element <b>OffclValtnInd</b> (Offcl Valuation Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public bool OffclValtnInd;

        /// <summary>
        /// Element <b>SspdInd</b> (Suspended Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public bool SspdInd;

        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type array of UnitPrice15.
        /// </summary>
        [XmlElementAttribute( "PricDtls", Order = 13 )]
        public UnitPrice15[] PricDtls;

        /// <summary>
        /// Element <b>ValtnSttstcs</b> (Valuation Statistics) of type array of ValuationStatistics3.
        /// </summary>
        [XmlElementAttribute( "ValtnSttstcs", Order = 14 )]
        public ValuationStatistics3[] ValtnSttstcs;

        /// <summary>
        /// Element <b>PrfrmncDtls</b> (Prfrmnc Details) of type PerformanceFactors1.
        /// </summary>
        [XmlElementAttribute( Order = 15 )]
        public PerformanceFactors1 PrfrmncDtls;
    }

    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PartyIdentification2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BICOrBEI of type string 
        ///  NmAndAdr of type NameAndAddress5 
        ///  PrtryId of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute( "BICOrBEI", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress5 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification1 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class NameAndAddress5
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
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
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
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
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
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class GenericIdentification1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string SchmeNm;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>ValuationTiming1Code</b> (Valuation Timing 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
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
    /// Enumeration <b>EventFrequency1Code</b> (Event Frequency 1Code).
    /// </summary>
    [System.SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public enum EventFrequency1Code
    {

        /// <summary>
        /// <b>YEAR - Annual</b>.
        /// </summary>
        YEAR,

        /// <summary>
        /// <b>SEMI - Semi Annual</b>.
        /// </summary>
        SEMI,

        /// <summary>
        /// <b>QUTR - Quarterly</b>.
        /// </summary>
        QUTR,

        /// <summary>
        /// <b>TOMN - Every Two Months</b>.
        /// </summary>
        TOMN,

        /// <summary>
        /// <b>MNTH - Monthly</b>.
        /// </summary>
        MNTH,

        /// <summary>
        /// <b>TWMN - Twice AMonth</b>.
        /// </summary>
        TWMN,

        /// <summary>
        /// <b>TOWK - Every Two Weeks</b>.
        /// </summary>
        TOWK,

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

        /// <summary>
        /// <b>OVNG - Overnight</b>.
        /// </summary>
        OVNG,

        /// <summary>
        /// <b>ONDE - On Demand</b>.
        /// </summary>
        ONDE,
    }

    /// <summary>
    /// Class <b>PriceReport2</b> (Price Report 2).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class PriceReport2
    {

        /// <summary>
        /// Element <b>PricValtnDtls</b> (Price Valuation Details) of type array of PriceValuation3.
        /// </summary>
        [XmlElementAttribute( "PricValtnDtls", Order = 0 )]
        public PriceValuation3[] PricValtnDtls;

        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute( "Xtnsn", Order = 1 )]
        public Extension1[] Xtnsn;
    }

    /// <summary>
    /// Class <b>Pagination</b> (Pagination).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class Pagination
    {

        /// <summary>
        /// Element <b>PgNb</b> (Page Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string PgNb;

        /// <summary>
        /// Element <b>LastPgInd</b> (Last Page Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool LastPgInd;
    }

    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03" )]
    public class AdditionalReference3
    {

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ref;

        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice RefIssr;

        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string MsgNm;
    }
}
