
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



namespace i20022.pacs00900101
{

    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id pacs.009.001.01 name FinancialInstitutionCreditTransferV01 from Payments Clearing and Settlement business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>pacs00900101</b> (0090 01 01) of type pacs00900101.
        /// </summary>
        [XmlElementAttribute( "pacs.009.001.01", Order = 0 )]
        public pacs00900101 pacs00900101;
    }

    /// <summary>
    /// Class <b>pacs00900101</b> (0090 01 01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( TypeName = "pacs.009.001.01", Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class pacs00900101
    {

        /// <summary>
        /// Element <b>GrpHdr</b> (Group Header) of type GroupHeader4.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public GroupHeader4 GrpHdr;

        /// <summary>
        /// Element <b>CdtTrfTxInf</b> (Credit Transfer Transaction Information) of type array of CreditTransferTransactionInformation3.
        /// </summary>
        [XmlElementAttribute( "CdtTrfTxInf", Order = 1 )]
        public CreditTransferTransactionInformation3[] CdtTrfTxInf;
    }

    /// <summary>
    /// Class <b>GroupHeader4</b> (Group Header 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class GroupHeader4
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
        /// Element <b>BtchBookg</b> (Batch Booking) of type bool.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public bool BtchBookg;

        /// <summary>
        /// Element <b>BtchBookgSpecified</b> (Batch Booking Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BtchBookgSpecified;

        /// <summary>
        /// Element <b>NbOfTxs</b> (Number Of Transactions) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public string NbOfTxs;

        /// <summary>
        /// Element <b>CtrlSum</b> (Control Sum) of type decimal.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public decimal CtrlSum;

        /// <summary>
        /// Element <b>CtrlSumSpecified</b> (Control Sum Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CtrlSumSpecified;

        /// <summary>
        /// Element <b>TtlIntrBkSttlmAmt</b> (Total Intr Bank Settlement Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public CurrencyAndAmount TtlIntrBkSttlmAmt;

        /// <summary>
        /// Element <b>IntrBkSttlmDt</b> (Intr Bank Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 6 )]
        public System.DateTime IntrBkSttlmDt;

        /// <summary>
        /// Element <b>IntrBkSttlmDtSpecified</b> (Intr Bank Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntrBkSttlmDtSpecified;

        /// <summary>
        /// Element <b>SttlmInf</b> (Settlement Information) of type SettlementInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public SettlementInformation1 SttlmInf;

        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation5.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public PaymentTypeInformation5 PmtTpInf;

        /// <summary>
        /// Element <b>InstgAgt</b> (Instructing Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public BranchAndFinancialInstitutionIdentification3 InstgAgt;

        /// <summary>
        /// Element <b>InstdAgt</b> (Instructed Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public BranchAndFinancialInstitutionIdentification3 InstdAgt;
    }

    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    /// Class <b>InstructionForNextAgent1</b> (Instruction For Next Agent 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class InstructionForNextAgent1
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type Instruction4Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Instruction4Code Cd;

        /// <summary>
        /// Element <b>CdSpecified</b> (Code Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdSpecified;

        /// <summary>
        /// Element <b>InstrInf</b> (Instruction Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string InstrInf;
    }

    /// <summary>
    /// Enumeration <b>Instruction4Code</b> (Instruction 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public enum Instruction4Code
    {

        /// <summary>
        /// <b>PHOA - Phone Next Agent</b>.
        /// </summary>
        PHOA,

        /// <summary>
        /// <b>TELA - Telecom Next Agent</b>.
        /// </summary>
        TELA,
    }

    /// <summary>
    /// Class <b>InstructionForCreditorAgent2</b> (Instruction For Creditor Agent 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class InstructionForCreditorAgent2
    {

        /// <summary>
        /// Element <b>Cd</b> (Code) of type Instruction5Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Instruction5Code Cd;

        /// <summary>
        /// Element <b>CdSpecified</b> (Code Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdSpecified;

        /// <summary>
        /// Element <b>InstrInf</b> (Instruction Information) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string InstrInf;
    }

    /// <summary>
    /// Enumeration <b>Instruction5Code</b> (Instruction 5Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public enum Instruction5Code
    {

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
    /// Class <b>SettlementTimeRequest1</b> (Settlement Time Request 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class SettlementTimeRequest1
    {

        /// <summary>
        /// Element <b>CLSTm</b> (CLSTime) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "time", Order = 0 )]
        public System.DateTime CLSTm;
    }

    /// <summary>
    /// Class <b>SettlementDateTimeIndication1</b> (Settlement Date Time Indication 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class SettlementDateTimeIndication1
    {

        /// <summary>
        /// Element <b>DbtDtTm</b> (Debit Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public System.DateTime DbtDtTm;

        /// <summary>
        /// Element <b>DbtDtTmSpecified</b> (Debit Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DbtDtTmSpecified;

        /// <summary>
        /// Element <b>CdtDtTm</b> (Credit Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime CdtDtTm;

        /// <summary>
        /// Element <b>CdtDtTmSpecified</b> (Credit Date Time Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CdtDtTmSpecified;
    }

    /// <summary>
    /// Class <b>PaymentIdentification2</b> (Payment Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class PaymentIdentification2
    {

        /// <summary>
        /// Element <b>InstrId</b> (Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string InstrId;

        /// <summary>
        /// Element <b>EndToEndId</b> (End To End Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public string EndToEndId;

        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string TxId;
    }

    /// <summary>
    /// Class <b>CreditTransferTransactionInformation3</b> (Credit Transfer Transaction Information 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class CreditTransferTransactionInformation3
    {

        /// <summary>
        /// Element <b>PmtId</b> (Payment Identification) of type PaymentIdentification2.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PaymentIdentification2 PmtId;

        /// <summary>
        /// Element <b>PmtTpInf</b> (Payment Type Information) of type PaymentTypeInformation5.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public PaymentTypeInformation5 PmtTpInf;

        /// <summary>
        /// Element <b>IntrBkSttlmAmt</b> (Intr Bank Settlement Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CurrencyAndAmount IntrBkSttlmAmt;

        /// <summary>
        /// Element <b>IntrBkSttlmDt</b> (Intr Bank Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( DataType = "date", Order = 3 )]
        public System.DateTime IntrBkSttlmDt;

        /// <summary>
        /// Element <b>IntrBkSttlmDtSpecified</b> (Intr Bank Settlement Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntrBkSttlmDtSpecified;

        /// <summary>
        /// Element <b>SttlmTmIndctn</b> (Settlement Time Indication) of type SettlementDateTimeIndication1.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public SettlementDateTimeIndication1 SttlmTmIndctn;

        /// <summary>
        /// Element <b>SttlmTmReq</b> (Settlement Time Request) of type SettlementTimeRequest1.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public SettlementTimeRequest1 SttlmTmReq;

        /// <summary>
        /// Element <b>PrvsInstgAgt</b> (Previous Instructing Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public BranchAndFinancialInstitutionIdentification3 PrvsInstgAgt;

        /// <summary>
        /// Element <b>PrvsInstgAgtAcct</b> (Previous Instructing Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public CashAccount7 PrvsInstgAgtAcct;

        /// <summary>
        /// Element <b>InstgAgt</b> (Instructing Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public BranchAndFinancialInstitutionIdentification3 InstgAgt;

        /// <summary>
        /// Element <b>InstdAgt</b> (Instructed Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 9 )]
        public BranchAndFinancialInstitutionIdentification3 InstdAgt;

        /// <summary>
        /// Element <b>IntrmyAgt1</b> (Intermediary Agent 1) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 10 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt1;

        /// <summary>
        /// Element <b>IntrmyAgt1Acct</b> (Intermediary Agent 1Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 11 )]
        public CashAccount7 IntrmyAgt1Acct;

        /// <summary>
        /// Element <b>IntrmyAgt2</b> (Intermediary Agent 2) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 12 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt2;

        /// <summary>
        /// Element <b>IntrmyAgt2Acct</b> (Intermediary Agent 2Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 13 )]
        public CashAccount7 IntrmyAgt2Acct;

        /// <summary>
        /// Element <b>IntrmyAgt3</b> (Intermediary Agent 3) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 14 )]
        public BranchAndFinancialInstitutionIdentification3 IntrmyAgt3;

        /// <summary>
        /// Element <b>IntrmyAgt3Acct</b> (Intermediary Agent 3Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 15 )]
        public CashAccount7 IntrmyAgt3Acct;

        /// <summary>
        /// Element <b>UltmtDbtr</b> (Ultimate Debtor) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 16 )]
        public BranchAndFinancialInstitutionIdentification3 UltmtDbtr;

        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 17 )]
        public BranchAndFinancialInstitutionIdentification3 Dbtr;

        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 18 )]
        public CashAccount7 DbtrAcct;

        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 19 )]
        public BranchAndFinancialInstitutionIdentification3 DbtrAgt;

        /// <summary>
        /// Element <b>DbtrAgtAcct</b> (Debtor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 20 )]
        public CashAccount7 DbtrAgtAcct;

        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 21 )]
        public BranchAndFinancialInstitutionIdentification3 CdtrAgt;

        /// <summary>
        /// Element <b>CdtrAgtAcct</b> (Creditor Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 22 )]
        public CashAccount7 CdtrAgtAcct;

        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 23 )]
        public BranchAndFinancialInstitutionIdentification3 Cdtr;

        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 24 )]
        public CashAccount7 CdtrAcct;

        /// <summary>
        /// Element <b>UltmtCdtr</b> (Ultimate Creditor) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 25 )]
        public BranchAndFinancialInstitutionIdentification3 UltmtCdtr;

        /// <summary>
        /// Element <b>InstrForCdtrAgt</b> (Instruction For Creditor Agent) of type array of InstructionForCreditorAgent2.
        /// </summary>
        [XmlElementAttribute( "InstrForCdtrAgt", Order = 26 )]
        public InstructionForCreditorAgent2[] InstrForCdtrAgt;

        /// <summary>
        /// Element <b>InstrForNxtAgt</b> (Instruction For Next Agent) of type array of InstructionForNextAgent1.
        /// </summary>
        [XmlElementAttribute( "InstrForNxtAgt", Order = 27 )]
        public InstructionForNextAgent1[] InstrForNxtAgt;

        /// <summary>
        /// Element <b>RmtInf</b> (Remittance Information) of type array of string.
        /// </summary>
        [XmlArrayAttribute( Order = 28 )]
        [XmlArrayItemAttribute( "Ustrd", IsNullable = false )]
        public string[] RmtInf;
    }

    /// <summary>
    /// Class <b>PaymentTypeInformation5</b> (Payment Type Information 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class PaymentTypeInformation5
    {

        /// <summary>
        /// Element <b>InstrPrty</b> (Instruction Priority) of type Priority2Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public Priority2Code InstrPrty;

        /// <summary>
        /// Element <b>InstrPrtySpecified</b> (Instruction Priority Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool InstrPrtySpecified;

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  ClrChanl of type ClearingChannel2Code 
        ///  SvcLvl of type RestrictedProprietaryChoice 
        /// </summary>
        [XmlElementAttribute( "ClrChanl", typeof( ClearingChannel2Code ), Order = 1 )]
        [XmlElementAttribute( "SvcLvl", typeof( RestrictedProprietaryChoice ), Order = 1 )]
        public object Item;

        /// <summary>
        /// Element <b>LclInstrm</b> (Local Instrument) of type RestrictedProprietaryChoice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public RestrictedProprietaryChoice LclInstrm;
    }

    /// <summary>
    /// Enumeration <b>Priority2Code</b> (Priority 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    /// Enumeration <b>ClearingChannel2Code</b> (Clearing Channel 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    /// Class <b>RestrictedProprietaryChoice</b> (Restricted Proprietary Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class RestrictedProprietaryChoice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "Prtry", Order = 0 )]
        public string Item;
    }

    /// <summary>
    /// Class <b>BranchAndFinancialInstitutionIdentification3</b> (Branch And Financial Institution Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType1
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    /// Class <b>GenericIdentification3</b> (Generic Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }

    /// <summary>
    /// Class <b>SimpleIdentificationInformation2</b> (Simple Identification Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class SimpleIdentificationInformation2
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }

    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
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
    /// Class <b>ClearingSystemIdentification1Choice</b> (Clearing System Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class ClearingSystemIdentification1Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        ///  ClrSysId of type CashClearingSystem3Code 
        ///  Prtry of type string 
        /// </summary>
        [XmlElementAttribute( "ClrSysId", typeof( CashClearingSystem3Code ), Order = 0 )]
        [XmlElementAttribute( "Prtry", typeof( string ), Order = 0 )]
        public object Item;
    }

    /// <summary>
    /// Enumeration <b>CashClearingSystem3Code</b> (Cash Clearing System 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public enum CashClearingSystem3Code
    {

        /// <summary>
        /// <b>ABE - EBAEuro 1Step 1</b>.
        /// </summary>
        ABE,

        /// <summary>
        /// <b>ART - Austrian</b>.
        /// </summary>
        ART,

        /// <summary>
        /// <b>AVP - New Zealand</b>.
        /// </summary>
        AVP,

        /// <summary>
        /// <b>AZM - Azerbaijan</b>.
        /// </summary>
        AZM,

        /// <summary>
        /// <b>BAP - Bosnia Herzegovina</b>.
        /// </summary>
        BAP,

        /// <summary>
        /// <b>BEL - Belgium</b>.
        /// </summary>
        BEL,

        /// <summary>
        /// <b>BOF - Finland</b>.
        /// </summary>
        BOF,

        /// <summary>
        /// <b>BRL - Italy</b>.
        /// </summary>
        BRL,

        /// <summary>
        /// <b>CAD - Canada</b>.
        /// </summary>
        CAD,

        /// <summary>
        /// <b>CAM - Spain CAM</b>.
        /// </summary>
        CAM,

        /// <summary>
        /// <b>CBJ - Ireland</b>.
        /// </summary>
        CBJ,

        /// <summary>
        /// <b>CHP - United Kingdom</b>.
        /// </summary>
        CHP,

        /// <summary>
        /// <b>DKC - Denmark</b>.
        /// </summary>
        DKC,

        /// <summary>
        /// <b>RTP - Germany RTGSPlus</b>.
        /// </summary>
        RTP,

        /// <summary>
        /// <b>EBA - EBAEuro 1</b>.
        /// </summary>
        EBA,

        /// <summary>
        /// <b>ELS - Germany ELS</b>.
        /// </summary>
        ELS,

        /// <summary>
        /// <b>ERP - EBAStep 1</b>.
        /// </summary>
        ERP,

        /// <summary>
        /// <b>XCT - EBAStep 2</b>.
        /// </summary>
        XCT,

        /// <summary>
        /// <b>HRK - Croatia</b>.
        /// </summary>
        HRK,

        /// <summary>
        /// <b>HRM - Greece</b>.
        /// </summary>
        HRM,

        /// <summary>
        /// <b>HUF - Hungary</b>.
        /// </summary>
        HUF,

        /// <summary>
        /// <b>LGS - Luxemburg</b>.
        /// </summary>
        LGS,

        /// <summary>
        /// <b>LVL - Latvia</b>.
        /// </summary>
        LVL,

        /// <summary>
        /// <b>MUP - Mauritius</b>.
        /// </summary>
        MUP,

        /// <summary>
        /// <b>NOC - Norway</b>.
        /// </summary>
        NOC,

        /// <summary>
        /// <b>PCH - Switzerland</b>.
        /// </summary>
        PCH,

        /// <summary>
        /// <b>PDS - Australia</b>.
        /// </summary>
        PDS,

        /// <summary>
        /// <b>PEG - Egypt</b>.
        /// </summary>
        PEG,

        /// <summary>
        /// <b>PNS - France PNS</b>.
        /// </summary>
        PNS,

        /// <summary>
        /// <b>PVE - Venezuela</b>.
        /// </summary>
        PVE,

        /// <summary>
        /// <b>SEC - Sweden SEC</b>.
        /// </summary>
        SEC,

        /// <summary>
        /// <b>SIT - Slovania</b>.
        /// </summary>
        SIT,

        /// <summary>
        /// <b>SLB - Spain ES</b>.
        /// </summary>
        SLB,

        /// <summary>
        /// <b>SPG - Portugal</b>.
        /// </summary>
        SPG,

        /// <summary>
        /// <b>SSK - Sweden SSK</b>.
        /// </summary>
        SSK,

        /// <summary>
        /// <b>TBF - France FR</b>.
        /// </summary>
        TBF,

        /// <summary>
        /// <b>TGT - Target</b>.
        /// </summary>
        TGT,

        /// <summary>
        /// <b>TOP - Netherlands</b>.
        /// </summary>
        TOP,

        /// <summary>
        /// <b>FDW - Fedwire</b>.
        /// </summary>
        FDW,

        /// <summary>
        /// <b>BOJ - Bank Of Japan Net</b>.
        /// </summary>
        BOJ,

        /// <summary>
        /// <b>FEY - Foreign Exchange Yen Clearing</b>.
        /// </summary>
        FEY,

        /// <summary>
        /// <b>ZEN - Zengin</b>.
        /// </summary>
        ZEN,

        /// <summary>
        /// <b>DDK - Denmark DDK</b>.
        /// </summary>
        DDK,

        /// <summary>
        /// <b>AIP - Albania</b>.
        /// </summary>
        AIP,

        /// <summary>
        /// <b>BCC - Sweden BGC</b>.
        /// </summary>
        BCC,

        /// <summary>
        /// <b>BDS - Barbados</b>.
        /// </summary>
        BDS,

        /// <summary>
        /// <b>BGN - Bulgaria</b>.
        /// </summary>
        BGN,

        /// <summary>
        /// <b>BHS - Bahamas</b>.
        /// </summary>
        BHS,

        /// <summary>
        /// <b>BIS - Botswana</b>.
        /// </summary>
        BIS,

        /// <summary>
        /// <b>BSP - Philippines</b>.
        /// </summary>
        BSP,

        /// <summary>
        /// <b>EPM - ECB</b>.
        /// </summary>
        EPM,

        /// <summary>
        /// <b>EPN - USChips ACH</b>.
        /// </summary>
        EPN,

        /// <summary>
        /// <b>FDA - USFed ACH</b>.
        /// </summary>
        FDA,

        /// <summary>
        /// <b>GIS - Ghana</b>.
        /// </summary>
        GIS,

        /// <summary>
        /// <b>INC - Netherlands IP</b>.
        /// </summary>
        INC,

        /// <summary>
        /// <b>JOD - Jordan</b>.
        /// </summary>
        JOD,

        /// <summary>
        /// <b>KPS - Kenya</b>.
        /// </summary>
        KPS,

        /// <summary>
        /// <b>LKB - Sri Lanka</b>.
        /// </summary>
        LKB,

        /// <summary>
        /// <b>MEP - Singapore</b>.
        /// </summary>
        MEP,

        /// <summary>
        /// <b>MRS - Malta</b>.
        /// </summary>
        MRS,

        /// <summary>
        /// <b>NAM - Namibia</b>.
        /// </summary>
        NAM,

        /// <summary>
        /// <b>PTR - Angola</b>.
        /// </summary>
        PTR,

        /// <summary>
        /// <b>ROL - Romania EPO</b>.
        /// </summary>
        ROL,

        /// <summary>
        /// <b>ROS - Romania GSRS</b>.
        /// </summary>
        ROS,

        /// <summary>
        /// <b>SCP - Chili</b>.
        /// </summary>
        SCP,

        /// <summary>
        /// <b>STG - United Kingdom GBP</b>.
        /// </summary>
        STG,

        /// <summary>
        /// <b>THB - Thailand</b>.
        /// </summary>
        THB,

        /// <summary>
        /// <b>TIS - Tanzania</b>.
        /// </summary>
        TIS,

        /// <summary>
        /// <b>TTD - Trinidad And Tobago</b>.
        /// </summary>
        TTD,

        /// <summary>
        /// <b>UIS - Uganda</b>.
        /// </summary>
        UIS,

        /// <summary>
        /// <b>MOS - South Africa</b>.
        /// </summary>
        MOS,

        /// <summary>
        /// <b>ZET - Zimbabwe</b>.
        /// </summary>
        ZET,

        /// <summary>
        /// <b>ZIS - Zambia</b>.
        /// </summary>
        ZIS,

        /// <summary>
        /// <b>CHI - USChips</b>.
        /// </summary>
        CHI,

        /// <summary>
        /// <b>COP - Columbia</b>.
        /// </summary>
        COP,
    }

    /// <summary>
    /// Class <b>SettlementInformation1</b> (Settlement Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public class SettlementInformation1
    {

        /// <summary>
        /// Element <b>SttlmMtd</b> (Settlement Method) of type SettlementMethod1Code.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public SettlementMethod1Code SttlmMtd;

        /// <summary>
        /// Element <b>SttlmAcct</b> (Settlement Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CashAccount7 SttlmAcct;

        /// <summary>
        /// Element <b>ClrSys</b> (Clearing System) of type ClearingSystemIdentification1Choice.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public ClearingSystemIdentification1Choice ClrSys;

        /// <summary>
        /// Element <b>InstgRmbrsmntAgt</b> (Instructing Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public BranchAndFinancialInstitutionIdentification3 InstgRmbrsmntAgt;

        /// <summary>
        /// Element <b>InstgRmbrsmntAgtAcct</b> (Instructing Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public CashAccount7 InstgRmbrsmntAgtAcct;

        /// <summary>
        /// Element <b>InstdRmbrsmntAgt</b> (Instructed Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public BranchAndFinancialInstitutionIdentification3 InstdRmbrsmntAgt;

        /// <summary>
        /// Element <b>InstdRmbrsmntAgtAcct</b> (Instructed Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public CashAccount7 InstdRmbrsmntAgtAcct;

        /// <summary>
        /// Element <b>ThrdRmbrsmntAgt</b> (Third Reimbursement Agent) of type BranchAndFinancialInstitutionIdentification3.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public BranchAndFinancialInstitutionIdentification3 ThrdRmbrsmntAgt;

        /// <summary>
        /// Element <b>ThrdRmbrsmntAgtAcct</b> (Third Reimbursement Agent Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 8 )]
        public CashAccount7 ThrdRmbrsmntAgtAcct;
    }

    /// <summary>
    /// Enumeration <b>SettlementMethod1Code</b> (Settlement Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:pacs.009.001.01" )]
    public enum SettlementMethod1Code
    {

        /// <summary>
        /// <b>INDA - Intra Day</b>.
        /// </summary>
        INDA,

        /// <summary>
        /// <b>INGA - Instructing Agent</b>.
        /// </summary>
        INGA,

        /// <summary>
        /// <b>COVE - Cover Method</b>.
        /// </summary>
        COVE,

        /// <summary>
        /// <b>CLRG - Clearing System</b>.
        /// </summary>
        CLRG,
    }

}
