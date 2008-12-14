
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


namespace i20022.tsin00300101
{



    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsin.003.001.01 name InvoiceFinancingCancellationRequestV01 from Trade Services Initiation business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
    [XmlRootAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01", IsNullable = false )]
    public class Document
    {

        /// <summary>
        /// Element <b>InvcFincgCxlReq</b> (Invc Fincg Cancellation Request) of type InvoiceFinancingCancellationRequestV01.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public InvoiceFinancingCancellationRequestV01 InvcFincgCxlReq;
    }

    /// <summary>
    /// Class <b>InvoiceFinancingCancellationRequestV01</b> (Invoice Financing Cancellation Request V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
    public class InvoiceFinancingCancellationRequestV01
    {

        /// <summary>
        /// Element <b>CxlReqId</b> (Cancellation Request Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public MessageIdentification1 CxlReqId;

        /// <summary>
        /// Element <b>CxlReqInf</b> (Cancellation Request Information) of type CancellationRequestInformation1.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CancellationRequestInformation1 CxlReqInf;
    }

    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
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
    /// Class <b>ClearingSystemMemberIdentification2Choice</b> (Clearing System Member Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
    public class ClearingSystemMemberIdentification2Choice
    {

        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute( "ATBLZ", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "AUBSBs", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "AUBSBx", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CACPA", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CHBC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "CHSIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "DEBLZ", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ESNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "GBSC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "GRHEBIC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "HKNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "IENSC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "INIFSC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ITNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "NZNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "OthrClrCdId", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "PLKNR", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "PTNCC", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "RUCB", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "USCH", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "USCHU", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "USFW", typeof( string ), Order = 0 )]
        [XmlElementAttribute( "ZANCC", typeof( string ), Order = 0 )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01", IncludeInSchema = false )]
    public enum ItemChoiceType1
    {

        /// <summary>
        /// <b>ATBLZ - ?undefined</b>.
        /// </summary>
        ATBLZ,

        /// <summary>
        /// <b>AUBSBs - ?undefined</b>.
        /// </summary>
        AUBSBs,

        /// <summary>
        /// <b>AUBSBx - ?undefined</b>.
        /// </summary>
        AUBSBx,

        /// <summary>
        /// <b>CACPA - ?undefined</b>.
        /// </summary>
        CACPA,

        /// <summary>
        /// <b>CHBC - ?undefined</b>.
        /// </summary>
        CHBC,

        /// <summary>
        /// <b>CHSIC - ?undefined</b>.
        /// </summary>
        CHSIC,

        /// <summary>
        /// <b>DEBLZ - ?undefined</b>.
        /// </summary>
        DEBLZ,

        /// <summary>
        /// <b>ESNCC - ?undefined</b>.
        /// </summary>
        ESNCC,

        /// <summary>
        /// <b>GBSC - ?undefined</b>.
        /// </summary>
        GBSC,

        /// <summary>
        /// <b>GRHEBIC - ?undefined</b>.
        /// </summary>
        GRHEBIC,

        /// <summary>
        /// <b>HKNCC - ?undefined</b>.
        /// </summary>
        HKNCC,

        /// <summary>
        /// <b>IENSC - ?undefined</b>.
        /// </summary>
        IENSC,

        /// <summary>
        /// <b>INIFSC - ?undefined</b>.
        /// </summary>
        INIFSC,

        /// <summary>
        /// <b>ITNCC - ?undefined</b>.
        /// </summary>
        ITNCC,

        /// <summary>
        /// <b>NZNCC - ?undefined</b>.
        /// </summary>
        NZNCC,

        /// <summary>
        /// <b>OthrClrCdId - ?undefined</b>.
        /// </summary>
        OthrClrCdId,

        /// <summary>
        /// <b>PLKNR - ?undefined</b>.
        /// </summary>
        PLKNR,

        /// <summary>
        /// <b>PTNCC - ?undefined</b>.
        /// </summary>
        PTNCC,

        /// <summary>
        /// <b>RUCB - ?undefined</b>.
        /// </summary>
        RUCB,

        /// <summary>
        /// <b>USCH - ?undefined</b>.
        /// </summary>
        USCH,

        /// <summary>
        /// <b>USCHU - ?undefined</b>.
        /// </summary>
        USCHU,

        /// <summary>
        /// <b>USFW - ?undefined</b>.
        /// </summary>
        USFW,

        /// <summary>
        /// <b>ZANCC - ?undefined</b>.
        /// </summary>
        ZANCC,
    }

    /// <summary>
    /// Class <b>FinancialInstitutionIdentification6</b> (Financial Institution Identification 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
    public class FinancialInstitutionIdentification6
    {

        /// <summary>
        /// Element <b>ClrSysMmbId</b> (Clearing System Member Identification) of type ClearingSystemMemberIdentification2Choice.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public ClearingSystemMemberIdentification2Choice ClrSysMmbId;

        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification4.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public GenericIdentification4 PrtryId;

        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string BIC;
    }

    /// <summary>
    /// Class <b>GenericIdentification4</b> (Generic Identification 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
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
    /// Class <b>CashAccountType2</b> (Cash Account Type 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
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
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
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
    /// Class <b>SimpleIdentificationInformation2</b> (Simple Identification Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
    public class SimpleIdentificationInformation2
    {

        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Id;
    }

    /// <summary>
    /// Class <b>AccountIdentification3Choice</b> (Account Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
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
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01", IncludeInSchema = false )]
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
    /// Class <b>CashAccount7</b> (Cash Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
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
    /// Class <b>PartyIdentification25</b> (Party Identification 25).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
    public class PartyIdentification25
    {

        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string Nm;

        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification4.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public GenericIdentification4 PrtryId;

        /// <summary>
        /// Element <b>BEI</b> (BEI) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string BEI;
    }

    /// <summary>
    /// Class <b>PartyIdentificationAndAccount6</b> (Party Identification And Account 6).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
    public class PartyIdentificationAndAccount6
    {

        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification25.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public PartyIdentification25 PtyId;

        /// <summary>
        /// Element <b>CdtAcct</b> (Credit Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public CashAccount7 CdtAcct;

        /// <summary>
        /// Element <b>FincgAcct</b> (Fincg Account) of type CashAccount7.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public CashAccount7 FincgAcct;
    }

    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
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
    /// Class <b>CancellationRequestInformation1</b> (Cancellation Request Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute( Namespace = "urn:iso:std:iso:20022:tech:xsd:tsin.003.001.01" )]
    public class CancellationRequestInformation1
    {

        /// <summary>
        /// Element <b>OrgnlGrpId</b> (Original Group Identification) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 0 )]
        public string OrgnlGrpId;

        /// <summary>
        /// Element <b>OrgnlCreDtTm</b> (Original Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute( Order = 1 )]
        public System.DateTime OrgnlCreDtTm;

        /// <summary>
        /// Element <b>NbOfInvcReqs</b> (Number Of Invc Reqs) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 2 )]
        public string NbOfInvcReqs;

        /// <summary>
        /// Element <b>TtlBlkInvcAmt</b> (Total Bulk Invc Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute( Order = 3 )]
        public ActiveCurrencyAndAmount TtlBlkInvcAmt;

        /// <summary>
        /// Element <b>CxlRsn</b> (Cancellation Reason) of type string.
        /// </summary>
        [XmlElementAttribute( Order = 4 )]
        public string CxlRsn;

        /// <summary>
        /// Element <b>FincgRqstr</b> (Fincg Rqstr) of type PartyIdentificationAndAccount6.
        /// </summary>
        [XmlElementAttribute( Order = 5 )]
        public PartyIdentificationAndAccount6 FincgRqstr;

        /// <summary>
        /// Element <b>IntrmyAgt</b> (Intermediary Agent) of type FinancialInstitutionIdentification6.
        /// </summary>
        [XmlElementAttribute( Order = 6 )]
        public FinancialInstitutionIdentification6 IntrmyAgt;

        /// <summary>
        /// Element <b>FrstAgt</b> (First Agent) of type FinancialInstitutionIdentification6.
        /// </summary>
        [XmlElementAttribute( Order = 7 )]
        public FinancialInstitutionIdentification6 FrstAgt;
    }
}
