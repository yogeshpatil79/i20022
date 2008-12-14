
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



namespace i20022.camt05300101
{


    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.053.001.01 name BankToCustomerStatementV01 from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>BkToCstmrStmtV01</b> (Bank To Customer Statement V01) of type BankToCustomerStatementV01.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BankToCustomerStatementV01 BkToCstmrStmtV01;
    }

    /// <summary>
    /// Class <b>BankToCustomerStatementV01</b> (Bank To Customer Statement V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class BankToCustomerStatementV01
    {

        /// <summary>
        /// Element <b>GrpHdr</b> (Group Header) of type GroupHeader23.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public GroupHeader23 GrpHdr;

        /// <summary>
        /// Element <b>Stmt</b> (Statement) of type array of AccountStatement1.
        /// </summary>
        [XmlElementAttribute( "Stmt", Order = 1 )]
        public AccountStatement1[] Stmt;
    }

    /// <summary>
    /// Class <b>GroupHeader23</b> (Group Header 23).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class GroupHeader23
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MsgId;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CreDtTm;

        /// <summary>
        /// Element <b>MsgRcpt</b> (Message Recipient) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PartyIdentification8 MsgRcpt;

        /// <summary>
        /// Element <b>MsgPgntn</b> (Message Pagination) of type Pagination.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public Pagination MsgPgntn;

        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string AddtlInf;
    }

    /// <summary>
    /// Class <b>PartyIdentification8</b> (Party Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class PartyIdentification8
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 PstlAdr;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type Party2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public Party2Choice Id;

        /// <summary>
        /// Element <b>CtryOfRes</b> (Country Of Residence) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string CtryOfRes;
    }

    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    /// Class <b>CorporateAction1</b> (Corporate Action 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CorporateAction1
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Cd;

        /// <summary>
        /// Element <b>Nb</b> (Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nb;

        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Prtry;
    }

    /// <summary>
    /// Class <b>ReturnReason1Choice</b> (Return Reason 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ReturnReason1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type TransactionRejectReason2Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( TransactionRejectReason2Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>TransactionRejectReason2Code</b> (Transaction Reject Reason 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public enum TransactionRejectReason2Code
    {

        /// <summary>
        /// <b>AC01 - Incorrect Account Number</b>.
        /// </summary>
        AC01,

        /// <summary>
        /// <b>AC04 - Closed Account Number</b>.
        /// </summary>
        AC04,

        /// <summary>
        /// <b>AC06 - Blocked Account</b>.
        /// </summary>
        AC06,

        /// <summary>
        /// <b>AM01 - Zero Amount</b>.
        /// </summary>
        AM01,

        /// <summary>
        /// <b>AM02 - Not Allowed Amount</b>.
        /// </summary>
        AM02,

        /// <summary>
        /// <b>AM03 - Not Allowed Currency</b>.
        /// </summary>
        AM03,

        /// <summary>
        /// <b>AM04 - Insufficient Funds</b>.
        /// </summary>
        AM04,

        /// <summary>
        /// <b>AM05 - Duplication</b>.
        /// </summary>
        AM05,

        /// <summary>
        /// <b>AM06 - Too Low Amount</b>.
        /// </summary>
        AM06,

        /// <summary>
        /// <b>AM07 - Blocked Amount</b>.
        /// </summary>
        AM07,

        /// <summary>
        /// <b>BE01 - Inconsistent With End Customer</b>.
        /// </summary>
        BE01,

        /// <summary>
        /// <b>BE04 - Missing Creditor Address</b>.
        /// </summary>
        BE04,

        /// <summary>
        /// <b>BE05 - Unrecognised Initiating Party</b>.
        /// </summary>
        BE05,

        /// <summary>
        /// <b>AG01 - Transaction Forbidden</b>.
        /// </summary>
        AG01,

        /// <summary>
        /// <b>AG02 - Invalid Bank Operation Code</b>.
        /// </summary>
        AG02,

        /// <summary>
        /// <b>DT01 - Invalid Date</b>.
        /// </summary>
        DT01,

        /// <summary>
        /// <b>RF01 - Not Unique Transaction Reference</b>.
        /// </summary>
        RF01,

        /// <summary>
        /// <b>RC01 - Bank Identifier Incorrect</b>.
        /// </summary>
        RC01,

        /// <summary>
        /// <b>TM01 - Cut Off Time</b>.
        /// </summary>
        TM01,

        /// <summary>
        /// <b>ED01 - Correspondent Bank Not Possible</b>.
        /// </summary>
        ED01,

        /// <summary>
        /// <b>ED03 - Balance Info Requested</b>.
        /// </summary>
        ED03,

        /// <summary>
        /// <b>MS03 - Not Specified Reason Agent Generated</b>.
        /// </summary>
        MS03,

        /// <summary>
        /// <b>MS02 - Not Specified Reason Customer Generated</b>.
        /// </summary>
        MS02,

        /// <summary>
        /// <b>BE06 - Unknown End Customer</b>.
        /// </summary>
        BE06,

        /// <summary>
        /// <b>BE07 - Missing Debtor Address</b>.
        /// </summary>
        BE07,

        /// <summary>
        /// <b>AM09 - Wrong Amount</b>.
        /// </summary>
        AM09,

        /// <summary>
        /// <b>AM10 - Invalid Control Sum</b>.
        /// </summary>
        AM10,

        /// <summary>
        /// <b>MD01 - No Mandate</b>.
        /// </summary>
        MD01,

        /// <summary>
        /// <b>MD02 - Missing Mandatory Information In Mandate</b>.
        /// </summary>
        MD02,

        /// <summary>
        /// <b>MD03 - Invalid File Format For Other Reason Than Grouping Indicator</b>.
        /// </summary>
        MD03,

        /// <summary>
        /// <b>MD04 - Invalid File Format For Grouping Indicator</b>.
        /// </summary>
        MD04,

        /// <summary>
        /// <b>MD06 - Refund Request By End Customer</b>.
        /// </summary>
        MD06,

        /// <summary>
        /// <b>MD07 - End Customer Deceased</b>.
        /// </summary>
        MD07,

        /// <summary>
        /// <b>ED05 - Settlement Failed</b>.
        /// </summary>
        ED05,

        /// <summary>
        /// <b>NARR - Narrative</b>.
        /// </summary>
        NARR,
    }

    /// <summary>
    /// Class <b>ReturnReasonInformation5</b> (Return Reason Information 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ReturnReasonInformation5
    {

        /// <summary>
        /// Element <b>OrgnlBkTxCd</b> (Original Bank Transaction Code) of type BankTransactionCodeStructure1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BankTransactionCodeStructure1 OrgnlBkTxCd;

        /// <summary>
        /// Element <b>RtrOrgtr</b> (Return Originator) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification8 RtrOrgtr;

        /// <summary>
        /// Element <b>RtrRsn</b> (Return Reason) of type ReturnReason1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public ReturnReason1Choice RtrRsn;

        /// <summary>
        /// Element <b>AddtlRtrRsnInf</b> (Additional Return Reason Information) of type array of string.
        /// </summary>
        [XmlElementAttribute( "AddtlRtrRsnInf", Order = 3 )]
        public string[] AddtlRtrRsnInf;
    }

    /// <summary>
    /// Class <b>BankTransactionCodeStructure1</b> (Bank Transaction Code Structure 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class BankTransactionCodeStructure1
    {

        /// <summary>
        /// Element <b>Domn</b> (Domn) of type BankTransactionCodeStructure2.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BankTransactionCodeStructure2 Domn;

        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type ProprietaryBankTransactionCodeStructure1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ProprietaryBankTransactionCodeStructure1 Prtry;
    }

    /// <summary>
    /// Class <b>BankTransactionCodeStructure2</b> (Bank Transaction Code Structure 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class BankTransactionCodeStructure2
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Cd;

        /// <summary>
        /// Element <b>Fmly</b> (Family) of type BankTransactionCodeStructure3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BankTransactionCodeStructure3 Fmly;
    }

    /// <summary>
    /// Class <b>BankTransactionCodeStructure3</b> (Bank Transaction Code Structure 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class BankTransactionCodeStructure3
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Cd;

        /// <summary>
        /// Element <b>SubFmlyCd</b> (Sub Family Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string SubFmlyCd;
    }

    /// <summary>
    /// Class <b>ProprietaryBankTransactionCodeStructure1</b> (Proprietary Bank Transaction Code Structure 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ProprietaryBankTransactionCodeStructure1
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Cd;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Issr;
    }

    /// <summary>
    /// Class <b>TaxType</b> (Tax Type).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TaxType
    {

        /// <summary>
        /// Element <b>CtgyDesc</b> (Category Description) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string CtgyDesc;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;

        /// <summary>
        /// Element <b>TaxblBaseAmt</b> (Taxable Base Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CurrencyAndAmount TaxblBaseAmt;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public CurrencyAndAmount Amt;
    }

    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CurrencyAndAmount
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
    /// Class <b>TaxDetails</b> (Tax Details).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TaxDetails
    {

        /// <summary>
        /// Element <b>CertId</b> (Certificate Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string CertId;

        /// <summary>
        /// Element <b>TaxTp</b> (Tax Type) of type TaxType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public TaxType TaxTp;
    }

    /// <summary>
    /// Class <b>TaxInformation2</b> (Tax Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TaxInformation2
    {

        /// <summary>
        /// Element <b>CdtrTaxId</b> (Creditor Tax Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string CdtrTaxId;

        /// <summary>
        /// Element <b>CdtrTaxTp</b> (Creditor Tax Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string CdtrTaxTp;

        /// <summary>
        /// Element <b>DbtrTaxId</b> (Debtor Tax Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string DbtrTaxId;

        /// <summary>
        /// Element <b>TaxRefNb</b> (Tax Reference Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string TaxRefNb;

        /// <summary>
        /// Element <b>TtlTaxblBaseAmt</b> (Total Taxable Base Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public CurrencyAndAmount TtlTaxblBaseAmt;

        /// <summary>
        /// Element <b>TtlTaxAmt</b> (Total Tax Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public CurrencyAndAmount TtlTaxAmt;

        /// <summary>
        /// Element <b>TaxDt</b> (Tax Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 6 )]
        public System.DateTime TaxDt;

        /// <summary>
        /// Element <b>TaxDtSpecified</b> (Tax Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxDtSpecified;

        /// <summary>
        /// Element <b>TaxTpInf</b> (Tax Type Information) of type array of TaxDetails.
        /// </summary>
        [XmlElementAttribute( "TaxTpInf", Order = 7 )]
        public TaxDetails[] TaxTpInf;
    }

    /// <summary>
    /// Class <b>AlternateSecurityIdentification2</b> (Alternate Security Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class AlternateSecurityIdentification2
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Tp;

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Id;
    }

    /// <summary>
    /// Class <b>SecurityIdentification4Choice</b> (Security Identification 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class SecurityIdentification4Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  ISIN of type string 
        ///  Prtry of type AlternateSecurityIdentification2 
        /// </summary>
        [XmlElementAttribute( "ISIN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( AlternateSecurityIdentification2 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>ProprietaryQuantity1</b> (Proprietary Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ProprietaryQuantity1
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Tp;

        /// <summary>
        /// Element <b>Qty</b> (Quantity) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Qty;
    }

    /// <summary>
    /// Class <b>FinancialInstrumentQuantityChoice</b> (Financial Instrument Quantity Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType8.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType8 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType8</b> (Item Choice Type 8).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType8
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
    /// Class <b>TransactionQuantities1Choice</b> (Transaction Quantities 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TransactionQuantities1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Prtry of type ProprietaryQuantity1 
        ///  Qty of type FinancialInstrumentQuantityChoice 
        /// </summary>
        [XmlElementAttribute( "Prtry", typeof( ProprietaryQuantity1 ), Order = 0 )]
        [XmlElementAttribute( "Qty", typeof( FinancialInstrumentQuantityChoice ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>ProprietaryPrice1</b> (Proprietary Price 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ProprietaryPrice1
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Tp;

        /// <summary>
        /// Element <b>Pric</b> (Price) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyAndAmount Pric;
    }

    /// <summary>
    /// Class <b>TransactionPrice1Choice</b> (Transaction Price 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TransactionPrice1Choice
    {

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        ///  DealPric of type CurrencyAndAmount 
        ///  Prtry of type ProprietaryPrice1 
        /// </summary>
        [XmlElementAttribute( "DealPric", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( ProprietaryPrice1 ), Order = 0 )]
        public object[] Items;
    }

    /// <summary>
    /// Class <b>ProprietaryDate1</b> (Proprietary Date 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ProprietaryDate1
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Tp;

        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( "Dt", typeof( System.DateTime ), DataType = "date", Order = 1 )]
        [XmlElementAttribute( "DtTm", typeof( System.DateTime ), Order = 1 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public System.DateTime Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType7.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType7 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType7</b> (Item Choice Type 7).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType7
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
    /// Class <b>TransactionDates1</b> (Transaction Dates 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TransactionDates1
    {

        /// <summary>
        /// Element <b>AccptncDtTm</b> (Acceptance Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public System.DateTime AccptncDtTm;

        /// <summary>
        /// Element <b>AccptncDtTmSpecified</b> (Acceptance Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AccptncDtTmSpecified;

        /// <summary>
        /// Element <b>TradDt</b> (Trade Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 1 )]
        public System.DateTime TradDt;

        /// <summary>
        /// Element <b>TradDtSpecified</b> (Trade Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TradDtSpecified;

        /// <summary>
        /// Element <b>IntrBkSttlmDt</b> (Intr Bank Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 2 )]
        public System.DateTime IntrBkSttlmDt;

        /// <summary>
        /// Element <b>IntrBkSttlmDtSpecified</b> (Intr Bank Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntrBkSttlmDtSpecified;

        /// <summary>
        /// Element <b>StartDt</b> (Start Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 3 )]
        public System.DateTime StartDt;

        /// <summary>
        /// Element <b>StartDtSpecified</b> (Start Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool StartDtSpecified;

        /// <summary>
        /// Element <b>EndDt</b> (End Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 4 )]
        public System.DateTime EndDt;

        /// <summary>
        /// Element <b>EndDtSpecified</b> (End Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EndDtSpecified;

        /// <summary>
        /// Element <b>TxDtTm</b> (Transaction Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public System.DateTime TxDtTm;

        /// <summary>
        /// Element <b>TxDtTmSpecified</b> (Transaction Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TxDtTmSpecified;

        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type array of ProprietaryDate1.
        /// </summary>
        [XmlElementAttribute( "Prtry", Order = 6 )]
        public ProprietaryDate1[] Prtry;
    }

    /// <summary>
    /// Class <b>CreditorReferenceType1</b> (Creditor Reference Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CreditorReferenceType1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type DocumentType3Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( DocumentType3Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>DocumentType3Code</b> (Document Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CreditorReferenceInformation1
    {

        /// <summary>
        /// Element <b>CdtrRefTp</b> (Creditor Reference Type) of type CreditorReferenceType1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CreditorReferenceType1 CdtrRefTp;

        /// <summary>
        /// Element <b>CdtrRef</b> (Creditor Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string CdtrRef;
    }

    /// <summary>
    /// Class <b>ReferredDocumentAmount1Choice</b> (Referred Document Amount 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ReferredDocumentAmount1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( "CdtNoteAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "DscntApldAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "DuePyblAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "RmtdAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlElementAttribute( "TaxAmt", typeof( CurrencyAndAmount ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public CurrencyAndAmount Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType6.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType6</b> (Item Choice Type 6).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType6
    {

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
    /// Class <b>ReferredDocumentType1</b> (Referred Document Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ReferredDocumentType1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type DocumentType2Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( DocumentType2Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>DocumentType2Code</b> (Document Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ReferredDocumentInformation1
    {

        /// <summary>
        /// Element <b>RfrdDocTp</b> (Referred Document Type) of type ReferredDocumentType1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ReferredDocumentType1 RfrdDocTp;

        /// <summary>
        /// Element <b>RfrdDocNb</b> (Referred Document Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string RfrdDocNb;
    }

    /// <summary>
    /// Class <b>StructuredRemittanceInformation6</b> (Structured Remittance Information 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class StructuredRemittanceInformation6
    {

        /// <summary>
        /// Element <b>RfrdDocInf</b> (Referred Document Information) of type ReferredDocumentInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ReferredDocumentInformation1 RfrdDocInf;

        /// <summary>
        /// Element <b>RfrdDocRltdDt</b> (Referred Document Related Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 1 )]
        public System.DateTime RfrdDocRltdDt;

        /// <summary>
        /// Element <b>RfrdDocRltdDtSpecified</b> (Referred Document Related Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RfrdDocRltdDtSpecified;

        /// <summary>
        /// Element <b>RfrdDocAmt</b> (Referred Document Amount) of type array of ReferredDocumentAmount1Choice.
        /// </summary>
        [XmlElementAttribute( "RfrdDocAmt", Order = 2 )]
        public ReferredDocumentAmount1Choice[] RfrdDocAmt;

        /// <summary>
        /// Element <b>CdtrRefInf</b> (Creditor Reference Information) of type CreditorReferenceInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public CreditorReferenceInformation1 CdtrRefInf;

        /// <summary>
        /// Element <b>Invcr</b> (Invcr) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification8 Invcr;

        /// <summary>
        /// Element <b>Invcee</b> (Invcee) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public PartyIdentification8 Invcee;

        /// <summary>
        /// Element <b>AddtlRmtInf</b> (Additional Remittance Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string AddtlRmtInf;
    }

    /// <summary>
    /// Class <b>RemittanceInformation1</b> (Remittance Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class RemittanceInformation1
    {

        /// <summary>
        /// Element <b>Ustrd</b> (Ustrd) of type array of string.
        /// </summary>
        [XmlElementAttribute( "Ustrd", Order = 0 )]
        public string[] Ustrd;

        /// <summary>
        /// Element <b>Strd</b> (Structured) of type array of StructuredRemittanceInformation6.
        /// </summary>
        [XmlElementAttribute( "Strd", Order = 1 )]
        public StructuredRemittanceInformation6[] Strd;
    }

    /// <summary>
    /// Class <b>NameAndAddress3</b> (Name And Address 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class NameAndAddress3
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
    /// Class <b>RemittanceLocation1</b> (Remittance Location 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class RemittanceLocation1
    {

        /// <summary>
        /// Element <b>RmtId</b> (Remittance Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string RmtId;

        /// <summary>
        /// Element <b>RmtLctnMtd</b> (Remittance Location Method) of type RemittanceLocationMethod1Code.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public RemittanceLocationMethod1Code RmtLctnMtd;

        /// <summary>
        /// Element <b>RmtLctnMtdSpecified</b> (Remittance Location Method Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RmtLctnMtdSpecified;

        /// <summary>
        /// Element <b>RmtLctnElctrncAdr</b> (Remittance Location Electronic Address) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string RmtLctnElctrncAdr;

        /// <summary>
        /// Element <b>RmtLctnPstlAdr</b> (Remittance Location Postal Address) of type NameAndAddress3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public NameAndAddress3 RmtLctnPstlAdr;
    }

    /// <summary>
    /// Enumeration <b>RemittanceLocationMethod1Code</b> (Remittance Location Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    /// Class <b>Purpose1Choice</b> (Purpose 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class Purpose1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType5.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType5</b> (Item Choice Type 5).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType5
    {

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
    /// Class <b>ProprietaryAgent1</b> (Proprietary Agent 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ProprietaryAgent1
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Tp;

        /// <summary>
        /// Element <b>Agt</b> (Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BranchAndFinancialInstitutionIdentification3 Agt;
    }

    /// <summary>
    /// Class <b>BranchAndFinancialInstitutionIdentification3</b> (Branch And Financial Institution Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class BranchAndFinancialInstitutionIdentification3
    {

        /// <summary>
        /// Element <b>FinInstnId</b> (Financial Institution Identification) of type FinancialInstitutionIdentification5Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public FinancialInstitutionIdentification5Choice FinInstnId;

        /// <summary>
        /// Element <b>BrnchId</b> (Branch Identification) of type BranchData.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BranchData BrnchId;
    }

    /// <summary>
    /// Class <b>FinancialInstitutionIdentification5Choice</b> (Financial Institution Identification 5Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class FinancialInstitutionIdentification5Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BIC of type string 
        ///  ClrSysMmbId of type ClearingSystemMemberIdentification3Choice 
        ///  CmbndId of type FinancialInstitutionIdentification3 
        ///  NmAndAdr of type NameAndAddress7 
        ///  PrtryId of type GenericIdentification3 
        /// </summary>
        [XmlElementAttribute( "BIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ClrSysMmbId", typeof( ClearingSystemMemberIdentification3Choice ), Order = 0 )]
        [XmlElementAttribute( "CmbndId", typeof( FinancialInstitutionIdentification3 ), Order = 0 )]
        [XmlElementAttribute( "NmAndAdr", typeof( NameAndAddress7 ), Order = 0 )]
        [XmlElementAttribute( "PrtryId", typeof( GenericIdentification3 ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>ClearingSystemMemberIdentification3Choice</b> (Clearing System Member Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ClearingSystemMemberIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "Id", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public string Item;

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
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType2
    {

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
    /// Class <b>FinancialInstitutionIdentification3</b> (Financial Institution Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class FinancialInstitutionIdentification3
    {

        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BIC;

        /// <summary>
        /// Element <b>ClrSysMmbId</b> (Clearing System Member Identification) of type ClearingSystemMemberIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public ClearingSystemMemberIdentification3Choice ClrSysMmbId;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PostalAddress1 PstlAdr;

        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public GenericIdentification3 PrtryId;
    }

    /// <summary>
    /// Class <b>GenericIdentification3</b> (Generic Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class GenericIdentification3
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Issr;
    }

    /// <summary>
    /// Class <b>NameAndAddress7</b> (Name And Address 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class NameAndAddress7
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PostalAddress1 PstlAdr;
    }

    /// <summary>
    /// Class <b>BranchData</b> (Branch Data).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class BranchData
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Nm;

        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public PostalAddress1 PstlAdr;
    }

    /// <summary>
    /// Class <b>TransactionAgents1</b> (Transaction Agents 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TransactionAgents1
    {

        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BranchAndFinancialInstitutionIdentification3 DbtrAgt;

        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public BranchAndFinancialInstitutionIdentification3 CdtrAgt;

        /// <summary>
        /// Element <b>IntrmyAgt1</b> (Intermediary Agent 1) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt1;

        /// <summary>
        /// Element <b>IntrmyAgt2</b> (Intermediary Agent 2) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt2;

        /// <summary>
        /// Element <b>IntrmyAgt3</b> (Intermediary Agent 3) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt3;

        /// <summary>
        /// Element <b>RcvgAgt</b> (Receiving Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public BranchAndFinancialInstitutionIdentification3 RcvgAgt;

        /// <summary>
        /// Element <b>DlvrgAgt</b> (Delivering Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public BranchAndFinancialInstitutionIdentification3 DlvrgAgt;

        /// <summary>
        /// Element <b>IssgAgt</b> (Issg Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public BranchAndFinancialInstitutionIdentification3 IssgAgt;

        /// <summary>
        /// Element <b>SttlmPlc</b> (Settlement Place) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public BranchAndFinancialInstitutionIdentification3 SttlmPlc;

        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type array of ProprietaryAgent1.
        /// </summary>
        [XmlElementAttribute( "Prtry", Order = 9 )]
        public ProprietaryAgent1[] Prtry;
    }

    /// <summary>
    /// Class <b>ProprietaryParty1</b> (Proprietary Party 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ProprietaryParty1
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Tp;

        /// <summary>
        /// Element <b>Pty</b> (Party) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification8 Pty;
    }

    /// <summary>
    /// Class <b>TransactionParty1</b> (Transaction Party 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TransactionParty1
    {

        /// <summary>
        /// Element <b>InitgPty</b> (Initiating Party) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentification8 InitgPty;

        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PartyIdentification8 Dbtr;

        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CashAccount7 DbtrAcct;

        /// <summary>
        /// Element <b>UltmtDbtr</b> (Ultimate Debtor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public PartyIdentification8 UltmtDbtr;

        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification8 Cdtr;

        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public CashAccount7 CdtrAcct;

        /// <summary>
        /// Element <b>UltmtCdtr</b> (Ultimate Creditor) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public PartyIdentification8 UltmtCdtr;

        /// <summary>
        /// Element <b>TradgPty</b> (Trading Party) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public PartyIdentification8 TradgPty;

        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type array of ProprietaryParty1.
        /// </summary>
        [XmlElementAttribute( "Prtry", Order = 8 )]
        public ProprietaryParty1[] Prtry;
    }

    /// <summary>
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CashAccount7
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification3Choice Id;

        /// <summary>
        /// Element <b>Tp</b> (Type) of type CashAccountType2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CashAccountType2 Tp;

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Ccy;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Nm;
    }

    /// <summary>
    /// Class <b>AccountIdentification3Choice</b> (Account Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class AccountIdentification3Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  BBAN of type string 
        ///  IBAN of type string 
        ///  PrtryAcct of type SimpleIdentificationInformation2 
        ///  UPIC of type string 
        /// </summary>
        [XmlElementAttribute( "BBAN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IBAN", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "PrtryAcct", typeof( SimpleIdentificationInformation2 ), Order = 0 )]
        [XmlElementAttribute( "UPIC", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }

    /// <summary>
    /// Class <b>SimpleIdentificationInformation2</b> (Simple Identification Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class SimpleIdentificationInformation2
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

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
    /// Class <b>CashAccountType2</b> (Cash Account Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CashAccountType2
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type CashAccountType4Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( CashAccountType4Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>CashAccountType4Code</b> (Cash Account Type 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public enum CashAccountType4Code
    {

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
    /// Class <b>ProprietaryReference1</b> (Proprietary Reference 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ProprietaryReference1
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Tp;

        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string Ref;
    }

    /// <summary>
    /// Class <b>TransactionReferences1</b> (Transaction References 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TransactionReferences1
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MsgId;

        /// <summary>
        /// Element <b>AcctSvcrRef</b> (Account Servicer Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string AcctSvcrRef;

        /// <summary>
        /// Element <b>InstrId</b> (Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string InstrId;

        /// <summary>
        /// Element <b>EndToEndId</b> (End To End Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string EndToEndId;

        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string TxId;

        /// <summary>
        /// Element <b>MndtId</b> (Mandate Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string MndtId;

        /// <summary>
        /// Element <b>ChqNb</b> (Cheque Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string ChqNb;

        /// <summary>
        /// Element <b>ClrSysRef</b> (Clearing System Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string ClrSysRef;

        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type ProprietaryReference1.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public ProprietaryReference1 Prtry;
    }

    /// <summary>
    /// Class <b>EntryTransaction1</b> (Entry Transaction 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class EntryTransaction1
    {

        /// <summary>
        /// Element <b>Refs</b> (Refs) of type TransactionReferences1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public TransactionReferences1 Refs;

        /// <summary>
        /// Element <b>AmtDtls</b> (Amount Details) of type AmountAndCurrencyExchange2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AmountAndCurrencyExchange2 AmtDtls;

        /// <summary>
        /// Element <b>Avlbty</b> (Availability) of type array of CashBalanceAvailability1.
        /// </summary>
        [XmlElementAttribute( "Avlbty", Order = 2 )]
        public CashBalanceAvailability1[] Avlbty;

        /// <summary>
        /// Element <b>BkTxCd</b> (Bank Transaction Code) of type BankTransactionCodeStructure1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public BankTransactionCodeStructure1 BkTxCd;

        /// <summary>
        /// Element <b>Chrgs</b> (Charges) of type array of ChargesInformation3.
        /// </summary>
        [XmlElementAttribute( "Chrgs", Order = 4 )]
        public ChargesInformation3[] Chrgs;

        /// <summary>
        /// Element <b>Intrst</b> (Interest) of type array of TransactionInterest1.
        /// </summary>
        [XmlElementAttribute( "Intrst", Order = 5 )]
        public TransactionInterest1[] Intrst;

        /// <summary>
        /// Element <b>RltdPties</b> (Related Parties) of type TransactionParty1.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public TransactionParty1 RltdPties;

        /// <summary>
        /// Element <b>RltdAgts</b> (Related Agts) of type TransactionAgents1.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public TransactionAgents1 RltdAgts;

        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type Purpose1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public Purpose1Choice Purp;

        /// <summary>
        /// Element <b>RltdRmtInf</b> (Related Remittance Information) of type array of RemittanceLocation1.
        /// </summary>
        [XmlElementAttribute( "RltdRmtInf", Order = 9 )]
        public RemittanceLocation1[] RltdRmtInf;

        /// <summary>
        /// Element <b>RmtInf</b> (Remittance Information) of type RemittanceInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public RemittanceInformation1 RmtInf;

        /// <summary>
        /// Element <b>RltdDts</b> (Related Dts) of type TransactionDates1.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public TransactionDates1 RltdDts;

        /// <summary>
        /// Element <b>RltdPric</b> (Related Price) of type TransactionPrice1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public TransactionPrice1Choice RltdPric;

        /// <summary>
        /// Element <b>RltdQties</b> (Related Qties) of type array of TransactionQuantities1Choice.
        /// </summary>
        [XmlElementAttribute( "RltdQties", Order = 13 )]
        public TransactionQuantities1Choice[] RltdQties;

        /// <summary>
        /// Element <b>FinInstrmId</b> (Financial Instrument Identification) of type SecurityIdentification4Choice.
        /// </summary>
        [XmlElementAttribute( Order = 14 )]
        public SecurityIdentification4Choice FinInstrmId;

        /// <summary>
        /// Element <b>Tax</b> (Tax) of type TaxInformation2.
        /// </summary>
        [XmlElementAttribute( Order = 15 )]
        public TaxInformation2 Tax;

        /// <summary>
        /// Element <b>RtrInf</b> (Return Information) of type ReturnReasonInformation5.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public ReturnReasonInformation5 RtrInf;

        /// <summary>
        /// Element <b>CorpActn</b> (Corporate Action) of type CorporateAction1.
        /// </summary>
        [XmlElementAttribute( Order = 17 )]
        public CorporateAction1 CorpActn;

        /// <summary>
        /// Element <b>SfkpgAcct</b> (Safekeeping Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 18 )]
        public CashAccount7 SfkpgAcct;

        /// <summary>
        /// Element <b>AddtlTxInf</b> (Additional Transaction Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 19 )]
        public string AddtlTxInf;
    }

    /// <summary>
    /// Class <b>AmountAndCurrencyExchange2</b> (Amount And Currency Exchange 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class AmountAndCurrencyExchange2
    {

        /// <summary>
        /// Element <b>InstdAmt</b> (Instructed Amount) of type AmountAndCurrencyExchangeDetails1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AmountAndCurrencyExchangeDetails1 InstdAmt;

        /// <summary>
        /// Element <b>TxAmt</b> (Transaction Amount) of type AmountAndCurrencyExchangeDetails1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AmountAndCurrencyExchangeDetails1 TxAmt;

        /// <summary>
        /// Element <b>CntrValAmt</b> (Cntr Value Amount) of type AmountAndCurrencyExchangeDetails1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public AmountAndCurrencyExchangeDetails1 CntrValAmt;

        /// <summary>
        /// Element <b>AnncdPstngAmt</b> (Anncd Pstng Amount) of type AmountAndCurrencyExchangeDetails1.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public AmountAndCurrencyExchangeDetails1 AnncdPstngAmt;

        /// <summary>
        /// Element <b>PrtryAmt</b> (Proprietary Amount) of type array of AmountAndCurrencyExchangeDetails2.
        /// </summary>
        [XmlElementAttribute( "PrtryAmt", Order = 4 )]
        public AmountAndCurrencyExchangeDetails2[] PrtryAmt;
    }

    /// <summary>
    /// Class <b>AmountAndCurrencyExchangeDetails1</b> (Amount And Currency Exchange Details 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class AmountAndCurrencyExchangeDetails1
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>CcyXchg</b> (Currency Exchange) of type CurrencyExchange3.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyExchange3 CcyXchg;
    }

    /// <summary>
    /// Class <b>CurrencyExchange3</b> (Currency Exchange 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CurrencyExchange3
    {

        /// <summary>
        /// Element <b>SrcCcy</b> (Source Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string SrcCcy;

        /// <summary>
        /// Element <b>TrgtCcy</b> (Target Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string TrgtCcy;

        /// <summary>
        /// Element <b>UnitCcy</b> (Unit Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string UnitCcy;

        /// <summary>
        /// Element <b>XchgRate</b> (Exchange Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal XchgRate;

        /// <summary>
        /// Element <b>CtrctId</b> (Contract Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string CtrctId;

        /// <summary>
        /// Element <b>QtnDt</b> (Quotation Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public System.DateTime QtnDt;

        /// <summary>
        /// Element <b>QtnDtSpecified</b> (Quotation Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool QtnDtSpecified;
    }

    /// <summary>
    /// Class <b>AmountAndCurrencyExchangeDetails2</b> (Amount And Currency Exchange Details 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class AmountAndCurrencyExchangeDetails2
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Tp;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>CcyXchg</b> (Currency Exchange) of type CurrencyExchange3.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CurrencyExchange3 CcyXchg;
    }

    /// <summary>
    /// Class <b>CashBalanceAvailability1</b> (Cash Balance Availability 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CashBalanceAvailability1
    {

        /// <summary>
        /// Element <b>Dt</b> (Date) of type CashBalanceAvailabilityDate1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CashBalanceAvailabilityDate1 Dt;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CreditDebitCode CdtDbtInd;
    }

    /// <summary>
    /// Class <b>CashBalanceAvailabilityDate1</b> (Cash Balance Availability Date 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CashBalanceAvailabilityDate1
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  NbOfDays of type string 
        /// </summary>
        [XmlElementAttribute( "ActlDt", typeof( System.DateTime ), DataType = "date", Order = 0 )]
        [XmlElementAttribute( "NbOfDays", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>CreditDebitCode</b> (Credit Debit Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    /// Class <b>ChargesInformation3</b> (Charges Information 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ChargesInformation3
    {

        /// <summary>
        /// Element <b>TtlChrgsAndTaxAmt</b> (Total Charges And Tax Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CurrencyAndAmount TtlChrgsAndTaxAmt;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>Tp</b> (Type) of type ChargeTypeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public ChargeTypeChoice Tp;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;

        /// <summary>
        /// Element <b>Br</b> (Bearer) of type ChargeBearerType1Code.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public ChargeBearerType1Code Br;

        /// <summary>
        /// Element <b>BrSpecified</b> (Bearer Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BrSpecified;

        /// <summary>
        /// Element <b>Pty</b> (Party) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public BranchAndFinancialInstitutionIdentification3 Pty;

        /// <summary>
        /// Element <b>Tax</b> (Tax) of type TaxCharges1.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public TaxCharges1 Tax;
    }

    /// <summary>
    /// Class <b>ChargeTypeChoice</b> (Charge Type Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ChargeTypeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type ChargeType1Code 
        ///  PrtryCd of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( ChargeType1Code ), Order = 0 )]
        [XmlElementAttribute( "PrtryCd", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>ChargeType1Code</b> (Charge Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public enum ChargeType1Code
    {

        /// <summary>
        /// <b>BRKF - Brokerage Fee</b>.
        /// </summary>
        BRKF,

        /// <summary>
        /// <b>COMM - Commission</b>.
        /// </summary>
        COMM,
    }

    /// <summary>
    /// Enumeration <b>ChargeBearerType1Code</b> (Charge Bearer Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    /// Class <b>TaxCharges1</b> (Tax Charges 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TaxCharges1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal Rate;

        /// <summary>
        /// Element <b>RateSpecified</b> (Rate Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RateSpecified;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CurrencyAndAmount Amt;
    }

    /// <summary>
    /// Class <b>TransactionInterest1</b> (Transaction Interest 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TransactionInterest1
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CreditDebitCode CdtDbtInd;

        /// <summary>
        /// Element <b>Tp</b> (Type) of type InterestType1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public InterestType1Choice Tp;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type array of Rate1.
        /// </summary>
        [XmlElementAttribute( "Rate", Order = 3 )]
        public Rate1[] Rate;

        /// <summary>
        /// Element <b>FrToDt</b> (From To Date) of type DateTimePeriodDetails.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public DateTimePeriodDetails FrToDt;

        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string Rsn;
    }

    /// <summary>
    /// Class <b>InterestType1Choice</b> (Interest Type 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class InterestType1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type InterestType1Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( InterestType1Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>InterestType1Code</b> (Interest Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public enum InterestType1Code
    {

        /// <summary>
        /// <b>INDY - Intra Day</b>.
        /// </summary>
        INDY,

        /// <summary>
        /// <b>OVRN - Over Night</b>.
        /// </summary>
        OVRN,
    }

    /// <summary>
    /// Class <b>Rate1</b> (Rate 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class Rate1
    {

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type RateTypeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public RateTypeChoice Rate;

        /// <summary>
        /// Element <b>VldtyRg</b> (Validity Range) of type CurrencyAndAmountRange.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyAndAmountRange VldtyRg;
    }

    /// <summary>
    /// Class <b>RateTypeChoice</b> (Rate Type Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class RateTypeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  PctgRate of type decimal 
        ///  TxtlRate of type string 
        /// </summary>
        [XmlElementAttribute( "PctgRate", typeof( decimal ), Order = 0 )]
        [XmlElementAttribute( "TxtlRate", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Class <b>CurrencyAndAmountRange</b> (Currency And Amount Range).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CurrencyAndAmountRange
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ImpliedCurrencyAmountRangeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ImpliedCurrencyAmountRangeChoice Amt;

        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CreditDebitCode CdtDbtInd;

        /// <summary>
        /// Element <b>CdtDbtIndSpecified</b> (Credit Debit Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdtDbtIndSpecified;

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Ccy;
    }

    /// <summary>
    /// Class <b>ImpliedCurrencyAmountRangeChoice</b> (Implied Currency Amount Range Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class ImpliedCurrencyAmountRangeChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  EQAmt of type decimal 
        ///  FrAmt of type AmountRangeBoundary1 
        ///  FrToAmt of type FromToAmountRange 
        ///  NEQAmt of type decimal 
        ///  ToAmt of type AmountRangeBoundary1 
        /// </summary>
        [XmlElementAttribute( "EQAmt", typeof( decimal ), Order = 0 )]
        [XmlElementAttribute( "FrAmt", typeof( AmountRangeBoundary1 ), Order = 0 )]
        [XmlElementAttribute( "FrToAmt", typeof( FromToAmountRange ), Order = 0 )]
        [XmlElementAttribute( "NEQAmt", typeof( decimal ), Order = 0 )]
        [XmlElementAttribute( "ToAmt", typeof( AmountRangeBoundary1 ), Order = 0 )]
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
    /// Class <b>AmountRangeBoundary1</b> (Amount Range Boundary 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class AmountRangeBoundary1
    {

        /// <summary>
        /// Element <b>BdryAmt</b> (Boundary Amount) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public decimal BdryAmt;

        /// <summary>
        /// Element <b>Incl</b> (Included) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public bool Incl;
    }

    /// <summary>
    /// Class <b>FromToAmountRange</b> (From To Amount Range).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class FromToAmountRange
    {

        /// <summary>
        /// Element <b>FrAmt</b> (From Amount) of type AmountRangeBoundary1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AmountRangeBoundary1 FrAmt;

        /// <summary>
        /// Element <b>ToAmt</b> (To Amount) of type AmountRangeBoundary1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public AmountRangeBoundary1 ToAmt;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType3
    {

        /// <summary>
        /// <b>EQAmt - ?undefined</b>.
        /// </summary>
        EQAmt,

        /// <summary>
        /// <b>FrAmt - ?undefined</b>.
        /// </summary>
        FrAmt,

        /// <summary>
        /// <b>FrToAmt - ?undefined</b>.
        /// </summary>
        FrToAmt,

        /// <summary>
        /// <b>NEQAmt - ?undefined</b>.
        /// </summary>
        NEQAmt,

        /// <summary>
        /// <b>ToAmt - ?undefined</b>.
        /// </summary>
        ToAmt,
    }

    /// <summary>
    /// Class <b>DateTimePeriodDetails</b> (Date Time Period Details).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    /// Class <b>BatchInformation1</b> (Batch Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class BatchInformation1
    {

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MsgId;

        /// <summary>
        /// Element <b>PmtInfId</b> (Payment Information Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string PmtInfId;

        /// <summary>
        /// Element <b>NbOfTxs</b> (Number Of Transactions) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string NbOfTxs;
    }

    /// <summary>
    /// Class <b>MessageIdentification2</b> (Message Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class MessageIdentification2
    {

        /// <summary>
        /// Element <b>MsgNmId</b> (Message Name Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string MsgNmId;

        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string MsgId;
    }

    /// <summary>
    /// Class <b>StatementEntry1</b> (Statement Entry 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class StatementEntry1
    {

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CreditDebitCode CdtDbtInd;

        /// <summary>
        /// Element <b>RvslInd</b> (Reversal Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool RvslInd;

        /// <summary>
        /// Element <b>RvslIndSpecified</b> (Reversal Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RvslIndSpecified;

        /// <summary>
        /// Element <b>Sts</b> (Status) of type EntryStatus3Code.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public EntryStatus3Code Sts;

        /// <summary>
        /// Element <b>BookgDt</b> (Booking Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public DateAndDateTimeChoice BookgDt;

        /// <summary>
        /// Element <b>ValDt</b> (Value Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public DateAndDateTimeChoice ValDt;

        /// <summary>
        /// Element <b>AcctSvcrRef</b> (Account Servicer Reference) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string AcctSvcrRef;

        /// <summary>
        /// Element <b>Avlbty</b> (Availability) of type array of CashBalanceAvailability1.
        /// </summary>
        [XmlElementAttribute( "Avlbty", Order = 7 )]
        public CashBalanceAvailability1[] Avlbty;

        /// <summary>
        /// Element <b>BkTxCd</b> (Bank Transaction Code) of type BankTransactionCodeStructure1.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public BankTransactionCodeStructure1 BkTxCd;

        /// <summary>
        /// Element <b>ComssnWvrInd</b> (Commission Wvr Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public bool ComssnWvrInd;

        /// <summary>
        /// Element <b>ComssnWvrIndSpecified</b> (Commission Wvr Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ComssnWvrIndSpecified;

        /// <summary>
        /// Element <b>AddtlInfInd</b> (Additional Information Indicator) of type MessageIdentification2.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public MessageIdentification2 AddtlInfInd;

        /// <summary>
        /// Element <b>Btch</b> (Batch) of type array of BatchInformation1.
        /// </summary>
        [XmlElementAttribute( "Btch", Order = 11 )]
        public BatchInformation1[] Btch;

        /// <summary>
        /// Element <b>AmtDtls</b> (Amount Details) of type AmountAndCurrencyExchange2.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public AmountAndCurrencyExchange2 AmtDtls;

        /// <summary>
        /// Element <b>Chrgs</b> (Charges) of type array of ChargesInformation3.
        /// </summary>
        [XmlElementAttribute( "Chrgs", Order = 13 )]
        public ChargesInformation3[] Chrgs;

        /// <summary>
        /// Element <b>Intrst</b> (Interest) of type array of TransactionInterest1.
        /// </summary>
        [XmlElementAttribute( "Intrst", Order = 14 )]
        public TransactionInterest1[] Intrst;

        /// <summary>
        /// Element <b>TxDtls</b> (Transaction Details) of type array of EntryTransaction1.
        /// </summary>
        [XmlElementAttribute( "TxDtls", Order = 15 )]
        public EntryTransaction1[] TxDtls;

        /// <summary>
        /// Element <b>AddtlNtryInf</b> (Additional Entry Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public string AddtlNtryInf;
    }

    /// <summary>
    /// Enumeration <b>EntryStatus3Code</b> (Entry Status 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public enum EntryStatus3Code
    {

        /// <summary>
        /// <b>BOOK - Book Transfer</b>.
        /// </summary>
        BOOK,
    }

    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType4.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType4</b> (Item Choice Type 4).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType4
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
    /// Class <b>NumberAndSumOfTransactionsPerBankTransactionCode1</b> (Number And Sum Of Transactions Per Bank Transaction Code 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class NumberAndSumOfTransactionsPerBankTransactionCode1
    {

        /// <summary>
        /// Element <b>NbOfNtries</b> (Number Of Ntries) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string NbOfNtries;

        /// <summary>
        /// Element <b>Sum</b> (Sum) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal Sum;

        /// <summary>
        /// Element <b>SumSpecified</b> (Sum Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SumSpecified;

        /// <summary>
        /// Element <b>TtlNetNtryAmt</b> (Total Net Entry Amount) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal TtlNetNtryAmt;

        /// <summary>
        /// Element <b>TtlNetNtryAmtSpecified</b> (Total Net Entry Amount Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TtlNetNtryAmtSpecified;

        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public CreditDebitCode CdtDbtInd;

        /// <summary>
        /// Element <b>CdtDbtIndSpecified</b> (Credit Debit Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdtDbtIndSpecified;

        /// <summary>
        /// Element <b>BkTxCd</b> (Bank Transaction Code) of type BankTransactionCodeStructure1.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public BankTransactionCodeStructure1 BkTxCd;

        /// <summary>
        /// Element <b>Avlbty</b> (Availability) of type array of CashBalanceAvailability1.
        /// </summary>
        [XmlElementAttribute( "Avlbty", Order = 5 )]
        public CashBalanceAvailability1[] Avlbty;
    }

    /// <summary>
    /// Class <b>NumberAndSumOfTransactions1</b> (Number And Sum Of Transactions 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class NumberAndSumOfTransactions1
    {

        /// <summary>
        /// Element <b>NbOfNtries</b> (Number Of Ntries) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string NbOfNtries;

        /// <summary>
        /// Element <b>Sum</b> (Sum) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal Sum;

        /// <summary>
        /// Element <b>SumSpecified</b> (Sum Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SumSpecified;
    }

    /// <summary>
    /// Class <b>NumberAndSumOfTransactions2</b> (Number And Sum Of Transactions 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class NumberAndSumOfTransactions2
    {

        /// <summary>
        /// Element <b>NbOfNtries</b> (Number Of Ntries) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string NbOfNtries;

        /// <summary>
        /// Element <b>Sum</b> (Sum) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal Sum;

        /// <summary>
        /// Element <b>SumSpecified</b> (Sum Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SumSpecified;

        /// <summary>
        /// Element <b>TtlNetNtryAmt</b> (Total Net Entry Amount) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal TtlNetNtryAmt;

        /// <summary>
        /// Element <b>TtlNetNtryAmtSpecified</b> (Total Net Entry Amount Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TtlNetNtryAmtSpecified;

        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public CreditDebitCode CdtDbtInd;

        /// <summary>
        /// Element <b>CdtDbtIndSpecified</b> (Credit Debit Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdtDbtIndSpecified;
    }

    /// <summary>
    /// Class <b>TotalTransactions1</b> (Total Transactions 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class TotalTransactions1
    {

        /// <summary>
        /// Element <b>TtlNtries</b> (Total Ntries) of type NumberAndSumOfTransactions2.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public NumberAndSumOfTransactions2 TtlNtries;

        /// <summary>
        /// Element <b>TtlCdtNtries</b> (Total Credit Ntries) of type NumberAndSumOfTransactions1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public NumberAndSumOfTransactions1 TtlCdtNtries;

        /// <summary>
        /// Element <b>TtlDbtNtries</b> (Total Debit Ntries) of type NumberAndSumOfTransactions1.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public NumberAndSumOfTransactions1 TtlDbtNtries;

        /// <summary>
        /// Element <b>TtlNtriesPerBkTxCd</b> (Total Ntries Per Bank Transaction Code) of type array of NumberAndSumOfTransactionsPerBankTransactionCode1.
        /// </summary>
        [XmlElementAttribute( "TtlNtriesPerBkTxCd", Order = 3 )]
        public NumberAndSumOfTransactionsPerBankTransactionCode1[] TtlNtriesPerBkTxCd;
    }

    /// <summary>
    /// Class <b>CreditLine1</b> (Credit Line 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CreditLine1
    {

        /// <summary>
        /// Element <b>Incl</b> (Included) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public bool Incl;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CurrencyAndAmount Amt;
    }

    /// <summary>
    /// Class <b>BalanceType2Choice</b> (Balance Type 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class BalanceType2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  Cd of type BalanceType9Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "Cd", typeof( BalanceType9Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>BalanceType9Code</b> (Balance Type 9Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public enum BalanceType9Code
    {

        /// <summary>
        /// <b>OPBD - Opening Booked</b>.
        /// </summary>
        OPBD,

        /// <summary>
        /// <b>ITBD - Interim Booked</b>.
        /// </summary>
        ITBD,

        /// <summary>
        /// <b>CLBD - Closing Booked</b>.
        /// </summary>
        CLBD,

        /// <summary>
        /// <b>OPAV - Opening Available</b>.
        /// </summary>
        OPAV,

        /// <summary>
        /// <b>ITAV - Interim Available</b>.
        /// </summary>
        ITAV,

        /// <summary>
        /// <b>CLAV - Closing Available</b>.
        /// </summary>
        CLAV,

        /// <summary>
        /// <b>FWAV - Forward Available</b>.
        /// </summary>
        FWAV,

        /// <summary>
        /// <b>PRCD - Previously Closed Booked</b>.
        /// </summary>
        PRCD,

        /// <summary>
        /// <b>IOPA - Investment Opening Available</b>.
        /// </summary>
        IOPA,

        /// <summary>
        /// <b>IITA - Investment Interim Available</b>.
        /// </summary>
        IITA,

        /// <summary>
        /// <b>ICLA - Investment Closing Available</b>.
        /// </summary>
        ICLA,

        /// <summary>
        /// <b>IFWA - Investment Forward Available</b>.
        /// </summary>
        IFWA,

        /// <summary>
        /// <b>ICLB - Investment Closing Booked</b>.
        /// </summary>
        ICLB,

        /// <summary>
        /// <b>IITB - Investment Interim Booked</b>.
        /// </summary>
        IITB,

        /// <summary>
        /// <b>IOPB - Investment Opening Booked</b>.
        /// </summary>
        IOPB,

        /// <summary>
        /// <b>DOPA - Disbursement Opening Available</b>.
        /// </summary>
        DOPA,

        /// <summary>
        /// <b>DITA - Disbursement Interim Available</b>.
        /// </summary>
        DITA,

        /// <summary>
        /// <b>DCLA - Disbursement Closing Available</b>.
        /// </summary>
        DCLA,

        /// <summary>
        /// <b>DFWA - Disbursement Forward Available</b>.
        /// </summary>
        DFWA,

        /// <summary>
        /// <b>DCLB - Disbursement Closing Booked</b>.
        /// </summary>
        DCLB,

        /// <summary>
        /// <b>DITB - Disbursement Interim Booked</b>.
        /// </summary>
        DITB,

        /// <summary>
        /// <b>DOPB - Disbursement Opening Booked</b>.
        /// </summary>
        DOPB,

        /// <summary>
        /// <b>COPA - Collection Opening Available</b>.
        /// </summary>
        COPA,

        /// <summary>
        /// <b>CITA - Collection Interim Available</b>.
        /// </summary>
        CITA,

        /// <summary>
        /// <b>CCLA - Collection Closing Available</b>.
        /// </summary>
        CCLA,

        /// <summary>
        /// <b>CFWA - Collection Forward Available</b>.
        /// </summary>
        CFWA,

        /// <summary>
        /// <b>CCLB - Collection Closing Booked</b>.
        /// </summary>
        CCLB,

        /// <summary>
        /// <b>CITB - Collection Interim Booked</b>.
        /// </summary>
        CITB,

        /// <summary>
        /// <b>COPB - Collection Opening Booked</b>.
        /// </summary>
        COPB,
    }

    /// <summary>
    /// Class <b>CashBalance2</b> (Cash Balance 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CashBalance2
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type BalanceType2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public BalanceType2Choice Tp;

        /// <summary>
        /// Element <b>CdtLine</b> (Credit Line) of type CreditLine1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CreditLine1 CdtLine;

        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CurrencyAndAmount Amt;

        /// <summary>
        /// Element <b>CdtDbtInd</b> (Credit Debit Indicator) of type CreditDebitCode.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public CreditDebitCode CdtDbtInd;

        /// <summary>
        /// Element <b>Dt</b> (Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public DateAndDateTimeChoice Dt;

        /// <summary>
        /// Element <b>Avlbty</b> (Availability) of type array of CashBalanceAvailability1.
        /// </summary>
        [XmlElementAttribute( "Avlbty", Order = 5 )]
        public CashBalanceAvailability1[] Avlbty;
    }

    /// <summary>
    /// Class <b>AccountInterest1</b> (Account Interest 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class AccountInterest1
    {

        /// <summary>
        /// Element <b>Tp</b> (Type) of type InterestType1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public InterestType1Choice Tp;

        /// <summary>
        /// Element <b>Rate</b> (Rate) of type array of Rate1.
        /// </summary>
        [XmlElementAttribute( "Rate", Order = 1 )]
        public Rate1[] Rate;

        /// <summary>
        /// Element <b>FrToDt</b> (From To Date) of type DateTimePeriodDetails.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public DateTimePeriodDetails FrToDt;

        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Rsn;
    }

    /// <summary>
    /// Class <b>CashAccount13</b> (Cash Account 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class CashAccount13
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification3Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public AccountIdentification3Choice Id;

        /// <summary>
        /// Element <b>Tp</b> (Type) of type CashAccountType2.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CashAccountType2 Tp;

        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Ccy;

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string Nm;

        /// <summary>
        /// Element <b>Ownr</b> (Owner) of type PartyIdentification8.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public PartyIdentification8 Ownr;

        /// <summary>
        /// Element <b>Svcr</b> (Servicer) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public BranchAndFinancialInstitutionIdentification3 Svcr;
    }

    /// <summary>
    /// Class <b>AccountStatement1</b> (Account Statement 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class AccountStatement1
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>ElctrncSeqNb</b> (Electronic Sequence Number) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public decimal ElctrncSeqNb;

        /// <summary>
        /// Element <b>ElctrncSeqNbSpecified</b> (Electronic Sequence Number Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ElctrncSeqNbSpecified;

        /// <summary>
        /// Element <b>LglSeqNb</b> (Legal Sequence Number) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public decimal LglSeqNb;

        /// <summary>
        /// Element <b>LglSeqNbSpecified</b> (Legal Sequence Number Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool LglSeqNbSpecified;

        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public System.DateTime CreDtTm;

        /// <summary>
        /// Element <b>FrToDt</b> (From To Date) of type DateTimePeriodDetails.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public DateTimePeriodDetails FrToDt;

        /// <summary>
        /// Element <b>CpyDplctInd</b> (Copy Duplicate Indicator) of type CopyDuplicate1Code.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public CopyDuplicate1Code CpyDplctInd;

        /// <summary>
        /// Element <b>CpyDplctIndSpecified</b> (Copy Duplicate Indicator Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CpyDplctIndSpecified;

        /// <summary>
        /// Element <b>Acct</b> (Account) of type CashAccount13.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public CashAccount13 Acct;

        /// <summary>
        /// Element <b>RltdAcct</b> (Related Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public CashAccount7 RltdAcct;

        /// <summary>
        /// Element <b>Intrst</b> (Interest) of type array of AccountInterest1.
        /// </summary>
        [XmlElementAttribute( "Intrst", Order = 8 )]
        public AccountInterest1[] Intrst;

        /// <summary>
        /// Element <b>Bal</b> (Balance) of type array of CashBalance2.
        /// </summary>
        [XmlElementAttribute( "Bal", Order = 9 )]
        public CashBalance2[] Bal;

        /// <summary>
        /// Element <b>TxsSummry</b> (Transactions Summary) of type TotalTransactions1.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public TotalTransactions1 TxsSummry;

        /// <summary>
        /// Element <b>Ntry</b> (Entry) of type array of StatementEntry1.
        /// </summary>
        [XmlElementAttribute( "Ntry", Order = 11 )]
        public StatementEntry1[] Ntry;

        /// <summary>
        /// Element <b>AddtlStmtInf</b> (Additional Statement Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public string AddtlStmtInf;
    }

    /// <summary>
    /// Enumeration <b>CopyDuplicate1Code</b> (Copy Duplicate 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public enum CopyDuplicate1Code
    {

        /// <summary>
        /// <b>CODU - Copy Duplicate</b>.
        /// </summary>
        CODU,

        /// <summary>
        /// <b>COPY - Copy</b>.
        /// </summary>
        COPY,

        /// <summary>
        /// <b>DUPL - Duplicate Payment</b>.
        /// </summary>
        DUPL,
    }

    /// <summary>
    /// Class <b>Pagination</b> (Pagination).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
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
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class GenericIdentification4
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;

        /// <summary>
        /// Element <b>IdTp</b> (Identification Type) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IdTp;
    }

    /// <summary>
    /// Class <b>DateAndPlaceOfBirth</b> (Date And Place Of Birth).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class DateAndPlaceOfBirth
    {

        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 0 )]
        public System.DateTime BirthDt;

        /// <summary>
        /// Element <b>PrvcOfBirth</b> (Province Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string PrvcOfBirth;

        /// <summary>
        /// Element <b>CityOfBirth</b> (City Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string CityOfBirth;

        /// <summary>
        /// Element <b>CtryOfBirth</b> (Country Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string CtryOfBirth;
    }

    /// <summary>
    /// Class <b>PersonIdentification3</b> (Person Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class PersonIdentification3
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  AlnRegnNb of type string 
        ///  CstmrNb of type string 
        ///  DrvrsLicNb of type string 
        ///  DtAndPlcOfBirth of type DateAndPlaceOfBirth 
        ///  IdntyCardNb of type string 
        ///  MplyrIdNb of type string 
        ///  OthrId of type GenericIdentification4 
        ///  PsptNb of type string 
        ///  SclSctyNb of type string 
        ///  TaxIdNb of type string 
        /// </summary>
        [XmlElementAttribute( "AlnRegnNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CstmrNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DrvrsLicNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DtAndPlcOfBirth", typeof( DateAndPlaceOfBirth ), Order = 0 )]
        [XmlElementAttribute( "IdntyCardNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "MplyrIdNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrId", typeof( GenericIdentification4 ), Order = 0 )]
        [XmlElementAttribute( "PsptNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "SclSctyNb", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "TaxIdNb", typeof( string ), Order = 0 )]
        [XmlChoiceIdentifierAttribute( "ItemElementName" )]
        public object Item;

        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;

        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string Issr;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType
    {

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
    /// Class <b>OrganisationIdentification2</b> (Organisation Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class OrganisationIdentification2
    {

        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string BIC;

        /// <summary>
        /// Element <b>IBEI</b> (IBEI) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string IBEI;

        /// <summary>
        /// Element <b>BEI</b> (BEI) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string BEI;

        /// <summary>
        /// Element <b>EANGLN</b> (EANGLN) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string EANGLN;

        /// <summary>
        /// Element <b>USCHU</b> (USCHU) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string USCHU;

        /// <summary>
        /// Element <b>DUNS</b> (DUNS) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public string DUNS;

        /// <summary>
        /// Element <b>BkPtyId</b> (Bank Party Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public string BkPtyId;

        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public string TaxIdNb;

        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public GenericIdentification3 PrtryId;
    }

    /// <summary>
    /// Class <b>Party2Choice</b> (Party 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01" )]
    public class Party2Choice
    {

        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        ///  OrgId of type OrganisationIdentification2 
        ///  PrvtId of type PersonIdentification3 
        /// </summary>
        [XmlElementAttribute( "OrgId", typeof( OrganisationIdentification2 ), Order = 0 )]
        [XmlElementAttribute( "PrvtId", typeof( PersonIdentification3 ), Order = 0 )]
        public object[] Items;
    }
}
