
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



namespace i20022.semt00300102
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id semt.003.001.02 name AccountingStatementOfHoldingsV02 from Securities Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>AcctgStmtOfHldgsV02</b> (Acctg Statement Of Holdings V02) of type AccountingStatementOfHoldingsV02.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountingStatementOfHoldingsV02 AcctgStmtOfHldgsV02;
    }

    /// <summary>
    /// Class <b>AccountingStatementOfHoldingsV02</b> (Accounting Statement Of Holdings V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AccountingStatementOfHoldingsV02
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 MsgId;

        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type array of AdditionalReference2.
        /// </summary>
        [XmlElementAttribute( "PrvsRef", Order = 1 )]
        public AdditionalReference2[] PrvsRef;

        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type array of AdditionalReference2.
        /// </summary>
        [XmlElementAttribute( "RltdRef", Order = 2 )]
        public AdditionalReference2[] RltdRef;

        /// <summary>
        /// Element <b>MsgPgntn</b> (Message Pagination) of type Pagination.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public Pagination MsgPgntn;

        /// <summary>
        /// Element <b>StmtGnlDtls</b> (Statement General Details) of type Statement6.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public Statement6 StmtGnlDtls;

        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type SafekeepingAccount2.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public SafekeepingAccount2 AcctDtls;

        /// <summary>
        /// Element <b>BalForAcct</b> (Balance For Account) of type array of AggregateBalanceInformation3.
        /// </summary>
        [XmlElementAttribute( "BalForAcct", Order = 6 )]
        public AggregateBalanceInformation3[] BalForAcct;

        /// <summary>
        /// Element <b>SubAcctDtls</b> (Sub Account Details) of type array of SubAccountIdentification3.
        /// </summary>
        [XmlElementAttribute( "SubAcctDtls", Order = 7 )]
        public SubAccountIdentification3[] SubAcctDtls;

        /// <summary>
        /// Element <b>TtlVals</b> (Total Values) of type TotalValueInPageAndStatement.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public TotalValueInPageAndStatement TtlVals;

        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute( "Xtnsn", Order = 9 )]
        public Extension1[] Xtnsn;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class ActiveCurrencyAndAmount
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
    /// Class <b>TotalValueInPageAndStatement</b> (Total Value In Page And Statement).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class TotalValueInPageAndStatement
    {

        /// <summary>
        /// Element <b>TtlHldgsValOfPg</b> (Total Holdings Value Of Page) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ActiveCurrencyAndAmount TtlHldgsValOfPg;

        /// <summary>
        /// Element <b>TtlHldgsValOfStmt</b> (Total Holdings Value Of Statement) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ActiveCurrencyAndAmount TtlHldgsValOfStmt;
    }

    /// <summary>
    /// Class <b>SubAccountIdentification3</b> (Sub Account Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class SubAccountIdentification3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentificationFormatChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentificationFormatChoice Id;

        /// <summary>
        /// Element <b>FngbInd</b> (Fungible Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool FngbInd;

        /// <summary>
        /// Element <b>ActvtyInd</b> (Activity Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool ActvtyInd;

        /// <summary>
        /// Element <b>BalForSubAcct</b> (Balance For Sub Account) of type array of AggregateBalanceInformation3.
        /// </summary>
        [XmlElementAttribute( "BalForSubAcct", Order = 3 )]
        public AggregateBalanceInformation3[] BalForSubAcct;
    }

    /// <summary>
    /// Class <b>AccountIdentificationFormatChoice</b> (Account Identification Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AccountIdentificationFormatChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  IdAndPurp of type AccountIdentificationAndPurpose 
        ///  IdAsDSS of type AccountIdentification3 
        ///  SmplId of type AccountIdentification1 
        /// </summary>
        [XmlElementAttribute( "IdAndPurp", typeof( AccountIdentificationAndPurpose ), Order = 0 )]
        [XmlElementAttribute( "IdAsDSS", typeof( AccountIdentification3 ), Order = 0 )]
        [XmlElementAttribute( "SmplId", typeof( AccountIdentification1 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>AccountIdentificationAndPurpose</b> (Account Identification And Purpose).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AccountIdentificationAndPurpose
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification1 Id;

        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type SecuritiesAccountPurposeType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public SecuritiesAccountPurposeType1Code Purp;
    }

    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AccountIdentification1
    {

        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SimpleIdentificationInformation Prtry;
    }

    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class SimpleIdentificationInformation
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }

    /// <summary>
    /// Enumeration <b>SecuritiesAccountPurposeType1Code</b> (Securities Account Purpose Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Class <b>AccountIdentification3</b> (Account Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AccountIdentification3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification1 Id;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Issr;

        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Inf;
    }

    /// <summary>
    /// Class <b>AggregateBalanceInformation3</b> (Aggregate Balance Information 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AggregateBalanceInformation3
    {

        /// <summary>
        /// Element <b>AggtQty</b> (Aggregate Quantity) of type BalanceQuantity1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BalanceQuantity1Choice AggtQty;

        /// <summary>
        /// Element <b>DaysAcrd</b> (Days Accrued) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal DaysAcrd;

        /// <summary>
        /// Element <b>DaysAcrdSpecified</b> (Days Accrued Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DaysAcrdSpecified;

        /// <summary>
        /// Element <b>HldgVal</b> (Holding Value) of type array of ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( "HldgVal", Order = 2 )]
        public ActiveOrHistoricCurrencyAndAmount[] HldgVal;

        /// <summary>
        /// Element <b>PrvsHldgVal</b> (Previous Holding Value) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public ActiveOrHistoricCurrencyAndAmount PrvsHldgVal;

        /// <summary>
        /// Element <b>AcrdIntrstAmt</b> (Accrued Interest Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public ActiveOrHistoricCurrencyAndAmount AcrdIntrstAmt;

        /// <summary>
        /// Element <b>AcrdIntrstAmtSgn</b> (Accrued Interest Amount Sign) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public bool AcrdIntrstAmtSgn;

        /// <summary>
        /// Element <b>AcrdIntrstAmtSgnSpecified</b> (Accrued Interest Amount Sign Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AcrdIntrstAmtSgnSpecified;

        /// <summary>
        /// Element <b>BookVal</b> (Book Value) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public ActiveOrHistoricCurrencyAndAmount BookVal;

        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type SafekeepingPlaceFormatChoice.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public SafekeepingPlaceFormatChoice SfkpgPlc;

        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument13.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public FinancialInstrument13 FinInstrmDtls;

        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type array of PriceInformation2.
        /// </summary>
        [XmlElementAttribute( "PricDtls", Order = 9 )]
        public PriceInformation2[] PricDtls;

        /// <summary>
        /// Element <b>FXDtls</b> (FXDetails) of type ForeignExchangeTerms6.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public ForeignExchangeTerms6 FXDtls;

        /// <summary>
        /// Element <b>BalBrkdwnDtls</b> (Balance Breakdown Details) of type array of SubBalanceInformation2.
        /// </summary>
        [XmlElementAttribute( "BalBrkdwnDtls", Order = 11 )]
        public SubBalanceInformation2[] BalBrkdwnDtls;

        /// <summary>
        /// Element <b>AddtlBalBrkdwnDtls</b> (Additional Balance Breakdown Details) of type array of AdditionalBalanceInformation2.
        /// </summary>
        [XmlElementAttribute( "AddtlBalBrkdwnDtls", Order = 12 )]
        public AdditionalBalanceInformation2[] AddtlBalBrkdwnDtls;

        /// <summary>
        /// Element <b>BalAtSfkpgPlc</b> (Balance At Safekeeping Place) of type array of AggregateBalancePerSafekeepingPlace4.
        /// </summary>
        [XmlElementAttribute( "BalAtSfkpgPlc", Order = 13 )]
        public AggregateBalancePerSafekeepingPlace4[] BalAtSfkpgPlc;
    }

    /// <summary>
    /// Class <b>BalanceQuantity1Choice</b> (Balance Quantity 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class BalanceQuantity1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Qty of type FinancialInstrumentQuantityChoice 
        ///  QtyAsDSS of type GenericIdentification6 
        /// </summary>
        [XmlElementAttribute( "Qty", typeof( FinancialInstrumentQuantityChoice ), Order = 0 )]
        [XmlElementAttribute( "QtyAsDSS", typeof( GenericIdentification6 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>FinancialInstrumentQuantityChoice</b> (Financial Instrument Quantity Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class FinancialInstrumentQuantityChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type decimal.
        /// </summary>
        [XmlElementAttribute( "AmtsdVal", typeof( decimal ), Order = 0 )]
        [XmlElementAttribute( "FaceAmt", typeof( decimal ), Order = 0 )]
        [XmlElementAttribute( "Unit", typeof( decimal ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public decimal Item;

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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

        /// <summary>
        /// <b>AmtsdVal - ?undefined</b>.
        /// </summary>
        AmtsdVal,

        /// <summary>
        /// <b>FaceAmt - ?undefined</b>.
        /// </summary>
        FaceAmt,

        /// <summary>
        /// <b>Unit - ?undefined</b>.
        /// </summary>
        Unit,
    }

    /// <summary>
    /// Class <b>GenericIdentification6</b> (Generic Identification 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class GenericIdentification6
    {

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Issr;

        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Inf;

        /// <summary>
        /// Element <b>Bal</b> (Balance) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal Bal;
    }

    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Class <b>SafekeepingPlaceFormatChoice</b> (Safekeeping Place Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class SafekeepingPlaceFormatChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Id of type SafekeepingPlaceAsCodeAndPartyIdentification 
        ///  IdAsCtry of type string 
        ///  IdAsDSS of type GenericIdentification5 
        /// </summary>
        [XmlElementAttribute( "Id", typeof( SafekeepingPlaceAsCodeAndPartyIdentification ), Order = 0 )]
        [XmlElementAttribute( "IdAsCtry", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IdAsDSS", typeof( GenericIdentification5 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>SafekeepingPlaceAsCodeAndPartyIdentification</b> (Safekeeping Place As Code And Party Identification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class SafekeepingPlaceAsCodeAndPartyIdentification
    {

        /// <summary>
        /// Element <b>PlcSfkpg</b> (Place Safekeeping) of type SafekeepingPlace1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SafekeepingPlace1Code PlcSfkpg;

        /// <summary>
        /// Element <b>Nrrtv</b> (Nrrtv) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nrrtv;

        /// <summary>
        /// Element <b>Pty</b> (Party) of type PartyIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification3 Pty;
    }

    /// <summary>
    /// Enumeration <b>SafekeepingPlace1Code</b> (Safekeeping Place 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public enum SafekeepingPlace1Code
    {

        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,

        /// <summary>
        /// <b>ICSD - Shares Held At ICSD</b>.
        /// </summary>
        ICSD,

        /// <summary>
        /// <b>NCSD - Shares Held At NCSD</b>.
        /// </summary>
        NCSD,

        /// <summary>
        /// <b>SHHE - Shares Held Elsewhere</b>.
        /// </summary>
        SHHE,
    }

    /// <summary>
    /// Class <b>PartyIdentification3</b> (Party Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class PartyIdentification3
    {

        /// <summary>
        /// Element <b>BICOrBEI</b> (BICOr BEI) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BICOrBEI;
    }

    /// <summary>
    /// Class <b>GenericIdentification5</b> (Generic Identification 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class GenericIdentification5
    {

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Issr;

        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Inf;

        /// <summary>
        /// Element <b>Nrrtv</b> (Nrrtv) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Nrrtv;
    }

    /// <summary>
    /// Class <b>FinancialInstrument13</b> (Financial Instrument 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class FinancialInstrument13
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SecurityIdentification3Choice Id;

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
        /// Element <b>ClssTp</b> (Class Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string ClssTp;

        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public FormOfSecurity1Code SctiesForm;

        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;

        /// <summary>
        /// Element <b>DstrbtnPlcy</b> (Distribution Policy) of type DistributionPolicy1Code.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public DistributionPolicy1Code DstrbtnPlcy;

        /// <summary>
        /// Element <b>DstrbtnPlcySpecified</b> (Distribution Policy Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified;
    }

    /// <summary>
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }

    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType2
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
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02", IncludeInSchema = false )]
    public enum ItemChoiceType3
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
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Class <b>PriceInformation2</b> (Price Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class PriceInformation2
    {

        /// <summary>
        /// Element <b>Val</b> (Value) of type PriceRateOrAmountOrUnknownChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PriceRateOrAmountOrUnknownChoice Val;

        /// <summary>
        /// Element <b>ValTp</b> (Value Type) of type PriceValueType2Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PriceValueType2Code ValTp;

        /// <summary>
        /// Element <b>ValTpSpecified</b> (Value Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ValTpSpecified;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Tp of type TypeOfPrice11Code 
        ///  XtndedTp of type string 
        /// </summary>
        [XmlElementAttribute( "Tp", typeof( TypeOfPrice11Code ), Order = 2 )]
        [XmlElementAttribute( "XtndedTp", typeof( string ), Order = 2 )]
        public object Item;

        /// <summary>
        /// Element <b>SrcOfPric</b> (Source Of Price) of type PriceSourceFormatChoice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PriceSourceFormatChoice SrcOfPric;

        /// <summary>
        /// Element <b>QtnDt</b> (Quotation Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public DateAndDateTimeChoice QtnDt;

        /// <summary>
        /// Element <b>Yldd</b> (Yldd) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public bool Yldd;

        /// <summary>
        /// Element <b>YlddSpecified</b> (Yldd Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool YlddSpecified;
    }

    /// <summary>
    /// Class <b>PriceRateOrAmountOrUnknownChoice</b> (Price Rate Or Amount Or Unknown Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class PriceRateOrAmountOrUnknownChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Amt of type ActiveOrHistoricCurrencyAnd13DecimalAmount 
        ///  Rate of type decimal 
        ///  UknwnInd of type bool 
        /// </summary>
        [XmlElementAttribute( "Amt", typeof( ActiveOrHistoricCurrencyAnd13DecimalAmount ), Order = 0 )]
        [XmlElementAttribute( "Rate", typeof( decimal ), Order = 0 )]
        [XmlElementAttribute( "UknwnInd", typeof( bool ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAnd13DecimalAmount</b> (Active Or Historic Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Enumeration <b>PriceValueType2Code</b> (Price Value Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public enum PriceValueType2Code
    {

        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,

        /// <summary>
        /// <b>PREM - Premium</b>.
        /// </summary>
        PREM,
    }

    /// <summary>
    /// Enumeration <b>TypeOfPrice11Code</b> (Type Of Price 11 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public enum TypeOfPrice11Code
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
        /// <b>MRKT - Market</b>.
        /// </summary>
        MRKT,

        /// <summary>
        /// <b>INDC - Indicative</b>.
        /// </summary>
        INDC,
    }

    /// <summary>
    /// Class <b>PriceSourceFormatChoice</b> (Price Source Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class PriceSourceFormatChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  LclMktPlc of type string 
        ///  NonLclMktPlc of type PriceSource 
        ///  PlcAsDSS of type GenericIdentification5 
        /// </summary>
        [XmlElementAttribute( "LclMktPlc", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NonLclMktPlc", typeof( PriceSource ), Order = 0 )]
        [XmlElementAttribute( "PlcAsDSS", typeof( GenericIdentification5 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>PriceSource</b> (Price Source).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class PriceSource
    {

        /// <summary>
        /// Element <b>PricSrc</b> (Price Source) of type PriceSource1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PriceSource1Code PricSrc;

        /// <summary>
        /// Element <b>Nrrtv</b> (Nrrtv) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nrrtv;
    }

    /// <summary>
    /// Enumeration <b>PriceSource1Code</b> (Price Source 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public enum PriceSource1Code
    {

        /// <summary>
        /// <b>FUND - Fund</b>.
        /// </summary>
        FUND,

        /// <summary>
        /// <b>THEO - Theoretical</b>.
        /// </summary>
        THEO,

        /// <summary>
        /// <b>VEND - Vendor</b>.
        /// </summary>
        VEND,
    }

    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02", IncludeInSchema = false )]
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
    /// Class <b>ForeignExchangeTerms6</b> (Foreign Exchange Terms 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class ForeignExchangeTerms6
    {

        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string UnitCcy;

        /// <summary>
        /// Element <b>QtdCcy</b> (Quoted Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string QtdCcy;

        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal XchgRate;

        /// <summary>
        /// Element <b>QtnDt</b> (Quotation Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public System.DateTime QtnDt;

        /// <summary>
        /// Element <b>QtnDtSpecified</b> (Quotation Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool QtnDtSpecified;

        /// <summary>
        /// Element <b>QtgInstn</b> (Quoting Institution) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification2Choice QtgInstn;
    }

    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Class <b>SubBalanceInformation2</b> (Sub Balance Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class SubBalanceInformation2
    {

        /// <summary>
        /// Element <b>Qty</b> (Quantity) of type SubBalanceQuantity1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SubBalanceQuantity1Choice Qty;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  SubBalTp of type SecuritiesBalanceType1Code 
        ///  XtndedSubBalTp of type string 
        /// </summary>
        [XmlElementAttribute( "SubBalTp", typeof( SecuritiesBalanceType1Code ), Order = 1 )]
        [XmlElementAttribute( "XtndedSubBalTp", typeof( string ), Order = 1 )]
        public object Item;

        /// <summary>
        /// Element <b>AddtlBalBrkdwnDtls</b> (Additional Balance Breakdown Details) of type array of AdditionalBalanceInformation2.
        /// </summary>
        [XmlElementAttribute( "AddtlBalBrkdwnDtls", Order = 2 )]
        public AdditionalBalanceInformation2[] AddtlBalBrkdwnDtls;
    }

    /// <summary>
    /// Class <b>SubBalanceQuantity1Choice</b> (Sub Balance Quantity 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class SubBalanceQuantity1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Qty of type FinancialInstrumentQuantityChoice 
        ///  QtyAndAvlbty of type QuantityAndAvailability 
        ///  QtyAsDSS of type GenericIdentification6 
        /// </summary>
        [XmlElementAttribute( "Qty", typeof( FinancialInstrumentQuantityChoice ), Order = 0 )]
        [XmlElementAttribute( "QtyAndAvlbty", typeof( QuantityAndAvailability ), Order = 0 )]
        [XmlElementAttribute( "QtyAsDSS", typeof( GenericIdentification6 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>QuantityAndAvailability</b> (Quantity And Availability).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class QuantityAndAvailability
    {

        /// <summary>
        /// Element <b>Qty</b> (Quantity) of type FinancialInstrumentQuantityChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public FinancialInstrumentQuantityChoice Qty;

        /// <summary>
        /// Element <b>AvlbtyInd</b> (Availability Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool AvlbtyInd;
    }

    /// <summary>
    /// Enumeration <b>SecuritiesBalanceType1Code</b> (Securities Balance Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public enum SecuritiesBalanceType1Code
    {

        /// <summary>
        /// <b>BLOK - Blocked</b>.
        /// </summary>
        BLOK,

        /// <summary>
        /// <b>BORR - Borrowed</b>.
        /// </summary>
        BORR,

        /// <summary>
        /// <b>COLI - Collateral In</b>.
        /// </summary>
        COLI,

        /// <summary>
        /// <b>COLO - Collateral Out</b>.
        /// </summary>
        COLO,

        /// <summary>
        /// <b>LOAN - Loan</b>.
        /// </summary>
        LOAN,

        /// <summary>
        /// <b>MARG - Margin</b>.
        /// </summary>
        MARG,

        /// <summary>
        /// <b>PDMT - Pending Delivery Matched Balance</b>.
        /// </summary>
        PDMT,

        /// <summary>
        /// <b>PRMT - Pending Receipt Matched Balance</b>.
        /// </summary>
        PRMT,

        /// <summary>
        /// <b>PRUM - Pending Receipt Unmatched Balance</b>.
        /// </summary>
        PRUM,

        /// <summary>
        /// <b>PECA - Pending Corporate Action</b>.
        /// </summary>
        PECA,

        /// <summary>
        /// <b>PEND - Pending Delivery</b>.
        /// </summary>
        PEND,

        /// <summary>
        /// <b>PENR - Pending Receipt</b>.
        /// </summary>
        PENR,

        /// <summary>
        /// <b>PLED - Pledged</b>.
        /// </summary>
        PLED,

        /// <summary>
        /// <b>PDUM - Pending Delivery Unmatched Balance</b>.
        /// </summary>
        PDUM,

        /// <summary>
        /// <b>REGO - Out For Registration</b>.
        /// </summary>
        REGO,

        /// <summary>
        /// <b>RSTR - Restricted</b>.
        /// </summary>
        RSTR,

        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,

        /// <summary>
        /// <b>TRAN - Transfer Fee</b>.
        /// </summary>
        TRAN,

        /// <summary>
        /// <b>DRAW - Drawn</b>.
        /// </summary>
        DRAW,

        /// <summary>
        /// <b>WDOC - Waiting Documentation</b>.
        /// </summary>
        WDOC,

        /// <summary>
        /// <b>BTRA - Being Transferred</b>.
        /// </summary>
        BTRA,
    }

    /// <summary>
    /// Class <b>AdditionalBalanceInformation2</b> (Additional Balance Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AdditionalBalanceInformation2
    {

        /// <summary>
        /// Element <b>Qty</b> (Quantity) of type SubBalanceQuantity1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SubBalanceQuantity1Choice Qty;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  SubBalTp of type SecuritiesBalanceType2Code 
        ///  XtndedSubBalTp of type string 
        /// </summary>
        [XmlElementAttribute( "SubBalTp", typeof( SecuritiesBalanceType2Code ), Order = 1 )]
        [XmlElementAttribute( "XtndedSubBalTp", typeof( string ), Order = 1 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>SecuritiesBalanceType2Code</b> (Securities Balance Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public enum SecuritiesBalanceType2Code
    {

        /// <summary>
        /// <b>CLEN - Tax Exempt</b>.
        /// </summary>
        CLEN,

        /// <summary>
        /// <b>DIRT - Non Tax Exempt</b>.
        /// </summary>
        DIRT,

        /// <summary>
        /// <b>NOMI - Nominee</b>.
        /// </summary>
        NOMI,

        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,

        /// <summary>
        /// <b>SPOS - Street Position</b>.
        /// </summary>
        SPOS,

        /// <summary>
        /// <b>UNRG - Unregistered</b>.
        /// </summary>
        UNRG,
    }

    /// <summary>
    /// Class <b>AggregateBalancePerSafekeepingPlace4</b> (Aggregate Balance Per Safekeeping Place 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AggregateBalancePerSafekeepingPlace4
    {

        /// <summary>
        /// Element <b>AggtBal</b> (Aggregate Balance) of type BalanceQuantity1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BalanceQuantity1Choice AggtBal;

        /// <summary>
        /// Element <b>DaysAcrd</b> (Days Accrued) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal DaysAcrd;

        /// <summary>
        /// Element <b>DaysAcrdSpecified</b> (Days Accrued Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DaysAcrdSpecified;

        /// <summary>
        /// Element <b>HldgVal</b> (Holding Value) of type array of ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( "HldgVal", Order = 2 )]
        public ActiveOrHistoricCurrencyAndAmount[] HldgVal;

        /// <summary>
        /// Element <b>PrvsHldgVal</b> (Previous Holding Value) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public ActiveOrHistoricCurrencyAndAmount PrvsHldgVal;

        /// <summary>
        /// Element <b>AcrdIntrstAmt</b> (Accrued Interest Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public ActiveOrHistoricCurrencyAndAmount AcrdIntrstAmt;

        /// <summary>
        /// Element <b>AcrdIntrstAmtSgn</b> (Accrued Interest Amount Sign) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public bool AcrdIntrstAmtSgn;

        /// <summary>
        /// Element <b>AcrdIntrstAmtSgnSpecified</b> (Accrued Interest Amount Sign Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AcrdIntrstAmtSgnSpecified;

        /// <summary>
        /// Element <b>BookVal</b> (Book Value) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public ActiveOrHistoricCurrencyAndAmount BookVal;

        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type SafekeepingPlaceFormatChoice.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public SafekeepingPlaceFormatChoice SfkpgPlc;

        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type array of PriceInformation2.
        /// </summary>
        [XmlElementAttribute( "PricDtls", Order = 8 )]
        public PriceInformation2[] PricDtls;

        /// <summary>
        /// Element <b>FXDtls</b> (FXDetails) of type ForeignExchangeTerms6.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public ForeignExchangeTerms6 FXDtls;

        /// <summary>
        /// Element <b>BalBrkdwnDtls</b> (Balance Breakdown Details) of type array of SubBalanceInformation2.
        /// </summary>
        [XmlElementAttribute( "BalBrkdwnDtls", Order = 10 )]
        public SubBalanceInformation2[] BalBrkdwnDtls;

        /// <summary>
        /// Element <b>AddtlBalBrkdwnDtls</b> (Additional Balance Breakdown Details) of type array of AdditionalBalanceInformation2.
        /// </summary>
        [XmlElementAttribute( "AddtlBalBrkdwnDtls", Order = 11 )]
        public AdditionalBalanceInformation2[] AddtlBalBrkdwnDtls;
    }

    /// <summary>
    /// Class <b>Account7</b> (Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class Account7
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification1 Id;

        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification2Choice AcctSvcr;
    }

    /// <summary>
    /// Class <b>Intermediary11</b> (Intermediary 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class Intermediary11
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentification2Choice Id;

        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account7.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public Account7 Acct;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Role of type InvestmentFundRole2Code 
        ///  XtndedRole of type string 
        /// </summary>
        [XmlElementAttribute( "Role", typeof( InvestmentFundRole2Code ), Order = 2 )]
        [XmlElementAttribute( "XtndedRole", typeof( string ), Order = 2 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>InvestmentFundRole2Code</b> (Investment Fund Role 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public enum InvestmentFundRole2Code
    {

        /// <summary>
        /// <b>FMCO - Fund Management Company</b>.
        /// </summary>
        FMCO,

        /// <summary>
        /// <b>REGI - Registrar</b>.
        /// </summary>
        REGI,

        /// <summary>
        /// <b>TRAG - Transfer Agent</b>.
        /// </summary>
        TRAG,

        /// <summary>
        /// <b>INTR - Intermediary</b>.
        /// </summary>
        INTR,

        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,

        /// <summary>
        /// <b>CONC - Concentrator</b>.
        /// </summary>
        CONC,

        /// <summary>
        /// <b>UCL1 - Underlying Client 1</b>.
        /// </summary>
        UCL1,

        /// <summary>
        /// <b>UCL2 - Underlying Client 2</b>.
        /// </summary>
        UCL2,

        /// <summary>
        /// <b>TRAN - Transfer Fee</b>.
        /// </summary>
        TRAN,
    }

    /// <summary>
    /// Class <b>SafekeepingAccount2</b> (Safekeeping Account 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class SafekeepingAccount2
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentificationFormatChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentificationFormatChoice Id;

        /// <summary>
        /// Element <b>FngbInd</b> (Fungible Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool FngbInd;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Nm;

        /// <summary>
        /// Element <b>Dsgnt</b> (Designation) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Dsgnt;

        /// <summary>
        /// Element <b>IntrmyInf</b> (Intermediary Information) of type array of Intermediary11.
        /// </summary>
        [XmlElementAttribute( "IntrmyInf", Order = 4 )]
        public Intermediary11[] IntrmyInf;

        /// <summary>
        /// Element <b>AcctOwnr</b> (Account Owner) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public PartyIdentification2Choice AcctOwnr;

        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public PartyIdentification2Choice AcctSvcr;
    }

    /// <summary>
    /// Class <b>StatementBasisCodeAndDSSCodeChoice</b> (Statement Basis Code And DSSCode Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class StatementBasisCodeAndDSSCodeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  StmtBsisAsCd of type StatementBasis1Code 
        ///  StmtBsisAsDSS of type GenericIdentification7 
        /// </summary>
        [XmlElementAttribute( "StmtBsisAsCd", typeof( StatementBasis1Code ), Order = 0 )]
        [XmlElementAttribute( "StmtBsisAsDSS", typeof( GenericIdentification7 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>StatementBasis1Code</b> (Statement Basis 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public enum StatementBasis1Code
    {

        /// <summary>
        /// <b>CONT - Contractual</b>.
        /// </summary>
        CONT,

        /// <summary>
        /// <b>SETT - Settled</b>.
        /// </summary>
        SETT,

        /// <summary>
        /// <b>TRAD - Trade</b>.
        /// </summary>
        TRAD,
    }

    /// <summary>
    /// Class <b>GenericIdentification7</b> (Generic Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class GenericIdentification7
    {

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Issr;

        /// <summary>
        /// Element <b>Inf</b> (Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Inf;
    }

    /// <summary>
    /// Class <b>StatementUpdateTypeCodeAndDSSCodeChoice</b> (Statement Update Type Code And DSSCode Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class StatementUpdateTypeCodeAndDSSCodeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  StmtUpdTpAsCd of type StatementUpdateTypeCode 
        ///  StmtUpdTpAsDSS of type GenericIdentification7 
        /// </summary>
        [XmlElementAttribute( "StmtUpdTpAsCd", typeof( StatementUpdateTypeCode ), Order = 0 )]
        [XmlElementAttribute( "StmtUpdTpAsDSS", typeof( GenericIdentification7 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>StatementUpdateTypeCode</b> (Statement Update Type Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Class <b>FrequencyCodeAndDSSCode1Choice</b> (Frequency Code And DSSCode 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class FrequencyCodeAndDSSCode1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  FrqcyAsCd of type EventFrequency1Code 
        ///  FrqcyAsDSS of type GenericIdentification7 
        /// </summary>
        [XmlElementAttribute( "FrqcyAsCd", typeof( EventFrequency1Code ), Order = 0 )]
        [XmlElementAttribute( "FrqcyAsDSS", typeof( GenericIdentification7 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>EventFrequency1Code</b> (Event Frequency 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Class <b>Statement6</b> (Statement 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class Statement6
    {

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ref;

        /// <summary>
        /// Element <b>StmtDtTm</b> (Statement Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public DateAndDateTimeChoice StmtDtTm;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DateAndDateTimeChoice CreDtTm;

        /// <summary>
        /// Element <b>Frqcy</b> (Frequency) of type FrequencyCodeAndDSSCode1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public FrequencyCodeAndDSSCode1Choice Frqcy;

        /// <summary>
        /// Element <b>UpdTp</b> (Update Type) of type StatementUpdateTypeCodeAndDSSCodeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public StatementUpdateTypeCodeAndDSSCodeChoice UpdTp;

        /// <summary>
        /// Element <b>ActvtyInd</b> (Activity Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public bool ActvtyInd;

        /// <summary>
        /// Element <b>StmtBsis</b> (Statement Basis) of type StatementBasisCodeAndDSSCodeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public StatementBasisCodeAndDSSCodeChoice StmtBsis;

        /// <summary>
        /// Element <b>RptNb</b> (Report Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string RptNb;

        /// <summary>
        /// Element <b>AudtdInd</b> (Audited Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public bool AudtdInd;
    }

    /// <summary>
    /// Class <b>Pagination</b> (Pagination).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
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
    /// Class <b>StructuredLongPostalAddress1</b> (Structured Long Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class StructuredLongPostalAddress1
    {

        /// <summary>
        /// Element <b>BldgNm</b> (Building Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BldgNm;

        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string StrtNm;

        /// <summary>
        /// Element <b>StrtBldgId</b> (Street Building Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string StrtBldgId;

        /// <summary>
        /// Element <b>Flr</b> (Floor) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Flr;

        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string TwnNm;

        /// <summary>
        /// Element <b>DstrctNm</b> (District Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string DstrctNm;

        /// <summary>
        /// Element <b>RgnId</b> (Region Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string RgnId;

        /// <summary>
        /// Element <b>Stat</b> (Stat) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string Stat;

        /// <summary>
        /// Element <b>CtyId</b> (County Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public string CtyId;

        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public string Ctry;

        /// <summary>
        /// Element <b>PstCdId</b> (Post Code Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public string PstCdId;

        /// <summary>
        /// Element <b>POB</b> (POB) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public string POB;
    }

    /// <summary>
    /// Class <b>LongPostalAddress1Choice</b> (Long Postal Address 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class LongPostalAddress1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Strd of type StructuredLongPostalAddress1 
        ///  Ustrd of type string 
        /// </summary>
        [XmlElementAttribute( "Strd", typeof( StructuredLongPostalAddress1 ), Order = 0 )]
        [XmlElementAttribute( "Ustrd", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>NameAndAddress2</b> (Name And Address 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class NameAndAddress2
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>Adr</b> (Address) of type LongPostalAddress1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public LongPostalAddress1Choice Adr;
    }

    /// <summary>
    /// Class <b>PartyIdentification1Choice</b> (Party Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class PartyIdentification1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BICOrBEI of type string 
        ///  NmAndAdr of type NameAndAddress2 
        ///  PrtryId of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute( "BICOrBEI", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress2 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification1 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>AdditionalReference2</b> (Additional Reference 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.001.02" )]
    public class AdditionalReference2
    {

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Ref;

        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification1Choice RefIssr;

        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string MsgNm;
    }
}
