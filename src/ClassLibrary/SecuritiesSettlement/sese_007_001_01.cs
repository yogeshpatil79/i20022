
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



namespace i20022.sese00700101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id sese.007.001.01 name TransferInConfirmationV01 from Securities Settlement business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>sese00700101</b> (sese 00700101) of type sese00700101.
        /// </summary>
        [XmlElementAttribute("sese.007.001.01", Order=0)]
        public sese00700101 sese00700101;
    }
    
    /// <summary>
    /// Class <b>sese00700101</b> (sese 00700101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="sese.007.001.01", Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class sese00700101
    {
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type AdditionalReference2.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AdditionalReference2 RltdRef;
        
        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AdditionalReference2 PoolRef;
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type AdditionalReference2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public AdditionalReference2 PrvsRef;
        
        /// <summary>
        /// Element <b>TrfDtls</b> (Transfer Details) of type Transfer4.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public Transfer4 TrfDtls;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FinancialInstrument3 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type InvestmentAccount10.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public InvestmentAccount10 AcctDtls;
        
        /// <summary>
        /// Element <b>SttlmDtls</b> (Settlement Details) of type DeliverInformation2.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public DeliverInformation2 SttlmDtls;
        
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Class <b>NameAndAddress1</b> (Name And Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class NameAndAddress1
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
    /// Class <b>DeliveryParameters2</b> (Delivery Parameters 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class DeliveryParameters2
    {
        
        /// <summary>
        /// Element <b>RegdAdrInd</b> (Registered Address Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public bool RegdAdrInd;
        
        /// <summary>
        /// Element <b>NmAndAdr</b> (Name And Address) of type NameAndAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public NameAndAddress1 NmAndAdr;
    }
    
    /// <summary>
    /// Class <b>PartyIdentificationAndAccount2</b> (Party Identification And Account 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class PartyIdentificationAndAccount2
    {
        
        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification1Choice PtyId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>PrcgRef</b> (Processing Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string PrcgRef;
        
        /// <summary>
        /// Element <b>PrcgDt</b> (Processing Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DateAndDateTimeChoice PrcgDt;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01", IncludeInSchema=false)]
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
    /// Class <b>InvestmentAccount11</b> (Investment Account 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class InvestmentAccount11
    {
        
        /// <summary>
        /// Element <b>OwnrId</b> (Owner Identification) of type array of PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute("OwnrId", Order=0)]
        public PartyIdentification1Choice[] OwnrId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>AcctNm</b> (Account Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AcctNm;
        
        /// <summary>
        /// Element <b>AcctDsgnt</b> (Account Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string AcctDsgnt;
        
        /// <summary>
        /// Element <b>IntrmyInf</b> (Intermediary Information) of type array of Intermediary1.
        /// </summary>
        [XmlElementAttribute("IntrmyInf", Order=4)]
        public Intermediary1[] IntrmyInf;
        
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
        /// Element <b>DmtrlsdInd</b> (Dematerialised Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public bool DmtrlsdInd;
        
        /// <summary>
        /// Element <b>DmtrlsdIndSpecified</b> (Dematerialised Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DmtrlsdIndSpecified;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>BnfcryCertfctnInd</b> (Beneficiary Certification Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public bool BnfcryCertfctnInd;
        
        /// <summary>
        /// Element <b>BnfcryCertfctnIndSpecified</b> (Beneficiary Certification Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BnfcryCertfctnIndSpecified;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public PartyIdentification1Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>Intermediary1</b> (Intermediary 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Class <b>Account1</b> (Account 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Enumeration <b>IncomePreference1Code</b> (Income Preference 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public enum IncomePreference1Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
    }
    
    /// <summary>
    /// Class <b>DeliveringPartiesAndAccount1</b> (Delivering Parties And Account 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class DeliveringPartiesAndAccount1
    {
        
        /// <summary>
        /// Element <b>DlvrrDtls</b> (Deliverer Details) of type InvestmentAccount11.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InvestmentAccount11 DlvrrDtls;
        
        /// <summary>
        /// Element <b>DlvrrsCtdnDtls</b> (Deliverers Custodian Details) of type PartyIdentificationAndAccount2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentificationAndAccount2 DlvrrsCtdnDtls;
        
        /// <summary>
        /// Element <b>DlvrrsIntrmyDtls</b> (Deliverers Intermediary Details) of type PartyIdentificationAndAccount2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentificationAndAccount2 DlvrrsIntrmyDtls;
        
        /// <summary>
        /// Element <b>DlvrgAgtDtls</b> (Delivering Agent Details) of type PartyIdentificationAndAccount2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentificationAndAccount2 DlvrgAgtDtls;
        
        /// <summary>
        /// Element <b>SctiesSttlmSys</b> (Securities Settlement System) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string SctiesSttlmSys;
        
        /// <summary>
        /// Element <b>PlcOfSttlmDtls</b> (Place Of Settlement Details) of type PartyIdentificationAndAccount2.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentificationAndAccount2 PlcOfSttlmDtls;
    }
    
    /// <summary>
    /// Class <b>TaxExemptionReasonFormatChoice</b> (Tax Exemption Reason Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class TaxExemptionReasonFormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type TaxExemptReason1Code 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(TaxExemptReason1Code), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>TaxExemptReason1Code</b> (Tax Exempt Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public enum TaxExemptReason1Code
    {
        
        /// <summary>
        /// <b>NONE - None</b>.
        /// </summary>
        NONE,
        
        /// <summary>
        /// <b>MASA - Maxi ISA</b>.
        /// </summary>
        MASA,
        
        /// <summary>
        /// <b>MISA - Mini Cash ISA</b>.
        /// </summary>
        MISA,
        
        /// <summary>
        /// <b>SISA - Mini Stocks And Shares ISA</b>.
        /// </summary>
        SISA,
        
        /// <summary>
        /// <b>IISA - Mini Insurance ISA</b>.
        /// </summary>
        IISA,
        
        /// <summary>
        /// <b>CUYP - Current Year Payment</b>.
        /// </summary>
        CUYP,
        
        /// <summary>
        /// <b>PRYP - Prior Year Payment</b>.
        /// </summary>
        PRYP,
        
        /// <summary>
        /// <b>ASTR - Asset Transfer</b>.
        /// </summary>
        ASTR,
        
        /// <summary>
        /// <b>EMPY - Employee Prior Year</b>.
        /// </summary>
        EMPY,
        
        /// <summary>
        /// <b>EMCY - Employee Current Year</b>.
        /// </summary>
        EMCY,
        
        /// <summary>
        /// <b>EPRY - Employer Prior Year</b>.
        /// </summary>
        EPRY,
        
        /// <summary>
        /// <b>ECYE - Employer Current Year</b>.
        /// </summary>
        ECYE,
        
        /// <summary>
        /// <b>NFPI - Non Fund Prototype IRA</b>.
        /// </summary>
        NFPI,
        
        /// <summary>
        /// <b>NFQP - Non Fund Qualified Plan</b>.
        /// </summary>
        NFQP,
        
        /// <summary>
        /// <b>DECP - Defined Contribution Plan</b>.
        /// </summary>
        DECP,
        
        /// <summary>
        /// <b>IRAC - Individual Retirement Account</b>.
        /// </summary>
        IRAC,
        
        /// <summary>
        /// <b>IRAR - Individual Retirement Account Rollover</b>.
        /// </summary>
        IRAR,
        
        /// <summary>
        /// <b>KEOG - KEOGH</b>.
        /// </summary>
        KEOG,
        
        /// <summary>
        /// <b>PFSP - Profit Sharing Plan</b>.
        /// </summary>
        PFSP,
        
        /// <summary>
        /// <b>Item401K - Item 401K</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("401K")]
        Item401K,
        
        /// <summary>
        /// <b>SIRA - Self Directed IRA</b>.
        /// </summary>
        SIRA,
        
        /// <summary>
        /// <b>Item403B - Item 403B</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("403B")]
        Item403B,
        
        /// <summary>
        /// <b>Item457X - Item 457X</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("457X")]
        Item457X,
        
        /// <summary>
        /// <b>RIRA - Roth IRA Fund Prototype</b>.
        /// </summary>
        RIRA,
        
        /// <summary>
        /// <b>RIAN - Roth IRA Non Prototype</b>.
        /// </summary>
        RIAN,
        
        /// <summary>
        /// <b>RCRF - Roth Conversion IRAFund Prototype</b>.
        /// </summary>
        RCRF,
        
        /// <summary>
        /// <b>RCIP - Roth Conversion IRANon Prototype</b>.
        /// </summary>
        RCIP,
        
        /// <summary>
        /// <b>EIFP - Education IRAFund Prototype</b>.
        /// </summary>
        EIFP,
        
        /// <summary>
        /// <b>EIOP - Education IRANon Prototype</b>.
        /// </summary>
        EIOP,
    }
    
    /// <summary>
    /// Class <b>TaxTypeFormat2Choice</b> (Tax Type Format 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class TaxTypeFormat2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type TaxType2Code 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(TaxType2Code), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>TaxType2Code</b> (Tax Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public enum TaxType2Code
    {
        
        /// <summary>
        /// <b>STAM - Stamp Duty</b>.
        /// </summary>
        STAM,
        
        /// <summary>
        /// <b>WITH - With / Withdrawal</b>.
        /// </summary>
        WITH,
        
        /// <summary>
        /// <b>EUTR - EUTax Retention</b>.
        /// </summary>
        EUTR,
    }
    
    /// <summary>
    /// Class <b>Tax3</b> (Tax 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class Tax3
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type TaxTypeFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TaxTypeFormat2Choice Tp;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt;
        
        /// <summary>
        /// Element <b>Bsis</b> (Basis) of type TaxationBasis2Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TaxationBasis2Code Bsis;
        
        /// <summary>
        /// Element <b>BsisSpecified</b> (Basis Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BsisSpecified;
        
        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification1Choice RcptId;
        
        /// <summary>
        /// Element <b>XmptnInd</b> (Exemption Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public bool XmptnInd;
        
        /// <summary>
        /// Element <b>XmptnRsn</b> (Exemption Reason) of type TaxExemptionReasonFormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public TaxExemptionReasonFormatChoice XmptnRsn;
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAnd13DecimalAmount</b> (Active Or Historic Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Enumeration <b>TaxationBasis2Code</b> (Taxation Basis 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public enum TaxationBasis2Code
    {
        
        /// <summary>
        /// <b>FLAT - Flat</b>.
        /// </summary>
        FLAT,
        
        /// <summary>
        /// <b>PERU - Per Unit</b>.
        /// </summary>
        PERU,
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Class <b>ChargeTypeFormat2Choice</b> (Charge Type Format 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class ChargeTypeFormat2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type ChargeType4Code 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(ChargeType4Code), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeType4Code</b> (Charge Type 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public enum ChargeType4Code
    {
        
        /// <summary>
        /// <b>TRAN - Transfer Fee</b>.
        /// </summary>
        TRAN,
    }
    
    /// <summary>
    /// Class <b>Charge4</b> (Charge 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class Charge4
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type ChargeTypeFormat2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ChargeTypeFormat2Choice Tp;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>ChrgBsis</b> (Charge Basis) of type TaxationBasis2Code.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public TaxationBasis2Code ChrgBsis;
        
        /// <summary>
        /// Element <b>ChrgBsisSpecified</b> (Charge Basis Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChrgBsisSpecified;
        
        /// <summary>
        /// Element <b>ChrgBr</b> (Charge Bearer) of type ChargeBearer1Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ChargeBearer1Code ChrgBr;
        
        /// <summary>
        /// Element <b>ChrgBrSpecified</b> (Charge Bearer Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChrgBrSpecified;
        
        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification1Choice RcptId;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeBearer1Code</b> (Charge Bearer 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public enum ChargeBearer1Code
    {
        
        /// <summary>
        /// <b>OUR - Borne By Debtor</b>.
        /// </summary>
        OUR,
        
        /// <summary>
        /// <b>BEN - Borne By Creditor</b>.
        /// </summary>
        BEN,
        
        /// <summary>
        /// <b>SHA - Shared</b>.
        /// </summary>
        SHA,
    }
    
    /// <summary>
    /// Class <b>DeliverInformation2</b> (Deliver Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class DeliverInformation2
    {
        
        /// <summary>
        /// Element <b>ChrgDtls</b> (Charge Details) of type array of Charge4.
        /// </summary>
        [XmlElementAttribute("ChrgDtls", Order=0)]
        public Charge4[] ChrgDtls;
        
        /// <summary>
        /// Element <b>TaxDtls</b> (Tax Details) of type array of Tax3.
        /// </summary>
        [XmlElementAttribute("TaxDtls", Order=1)]
        public Tax3[] TaxDtls;
        
        /// <summary>
        /// Element <b>SttlmPtiesDtls</b> (Settlement Parties Details) of type DeliveringPartiesAndAccount1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DeliveringPartiesAndAccount1 SttlmPtiesDtls;
        
        /// <summary>
        /// Element <b>PhysTrfInd</b> (Physical Transfer Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public bool PhysTrfInd;
        
        /// <summary>
        /// Element <b>PhysTrfDtls</b> (Physical Transfer Details) of type DeliveryParameters2.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public DeliveryParameters2 PhysTrfDtls;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount10</b> (Investment Account 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class InvestmentAccount10
    {
        
        /// <summary>
        /// Element <b>OwnrId</b> (Owner Identification) of type array of PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute("OwnrId", Order=0)]
        public PartyIdentification1Choice[] OwnrId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>AcctNm</b> (Account Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AcctNm;
        
        /// <summary>
        /// Element <b>AcctDsgnt</b> (Account Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string AcctDsgnt;
        
        /// <summary>
        /// Element <b>IntrmyInf</b> (Intermediary Information) of type array of Intermediary1.
        /// </summary>
        [XmlElementAttribute("IntrmyInf", Order=4)]
        public Intermediary1[] IntrmyInf;
        
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
        /// Element <b>DmtrlsdInd</b> (Dematerialised Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public bool DmtrlsdInd;
        
        /// <summary>
        /// Element <b>DmtrlsdIndSpecified</b> (Dematerialised Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DmtrlsdIndSpecified;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>BnfcryCertfctnInd</b> (Beneficiary Certification Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public bool BnfcryCertfctnInd;
        
        /// <summary>
        /// Element <b>BnfcryCertfctnIndSpecified</b> (Beneficiary Certification Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BnfcryCertfctnIndSpecified;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public PartyIdentification1Choice SfkpgPlc;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public PartyIdentification1Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01", IncludeInSchema=false)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01", IncludeInSchema=false)]
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
    /// Class <b>FinancialInstrument3</b> (Financial Instrument 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class FinancialInstrument3
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
    }
    
    /// <summary>
    /// Enumeration <b>DistributionPolicy1Code</b> (Distribution Policy 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class PriceValue1
    {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
    }
    
    /// <summary>
    /// Class <b>UnitPrice3</b> (Unit Price 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class UnitPrice3
    {
        
        /// <summary>
        /// Element <b>PricTp</b> (Price Type) of type TypeOfPrice2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TypeOfPrice2Code PricTp;
        
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
        
        /// <summary>
        /// Element <b>AcrdIntrstNAV</b> (Accrued Interest NAV) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CurrencyAndAmount AcrdIntrstNAV;
        
        /// <summary>
        /// Element <b>NbOfDaysAcrd</b> (Number Of Days Accrued) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public decimal NbOfDaysAcrd;
        
        /// <summary>
        /// Element <b>NbOfDaysAcrdSpecified</b> (Number Of Days Accrued Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NbOfDaysAcrdSpecified;
        
        /// <summary>
        /// Element <b>TaxblIncmPerShr</b> (Taxable Income Per Share) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CurrencyAndAmount TaxblIncmPerShr;
    }
    
    /// <summary>
    /// Enumeration <b>TypeOfPrice2Code</b> (Type Of Price 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Enumeration <b>PriceMethod1Code</b> (Price Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
    /// Class <b>Unit1</b> (Unit 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class Unit1
    {
        
        /// <summary>
        /// Element <b>UnitsNb</b> (Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FinancialInstrumentQuantity1 UnitsNb;
        
        /// <summary>
        /// Element <b>AcqstnDt</b> (Acquisition Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime AcqstnDt;
        
        /// <summary>
        /// Element <b>AcqstnDtSpecified</b> (Acquisition Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcqstnDtSpecified;
        
        /// <summary>
        /// Element <b>CertNb</b> (Certificate Number) of type array of string.
        /// </summary>
        [XmlElementAttribute("CertNb", Order=2)]
        public string[] CertNb;
        
        /// <summary>
        /// Element <b>Grp1Or2Units</b> (Group 1Or 2Units) of type UKTaxGroupUnitCode.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public UKTaxGroupUnitCode Grp1Or2Units;
        
        /// <summary>
        /// Element <b>Grp1Or2UnitsSpecified</b> (Group 1Or 2Units Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Grp1Or2UnitsSpecified;
        
        /// <summary>
        /// Element <b>PricDtls</b> (Price Details) of type UnitPrice3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public UnitPrice3 PricDtls;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class FinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Unit;
    }
    
    /// <summary>
    /// Enumeration <b>UKTaxGroupUnitCode</b> (UK Tax Group Unit Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public enum UKTaxGroupUnitCode
    {
        
        /// <summary>
        /// <b>GRP1 - Group 1</b>.
        /// </summary>
        GRP1,
        
        /// <summary>
        /// <b>GRP2 - Group 2</b>.
        /// </summary>
        GRP2,
    }
    
    /// <summary>
    /// Class <b>Transfer4</b> (Transfer 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
    public class Transfer4
    {
        
        /// <summary>
        /// Element <b>TrfConfRef</b> (Transfer Confirmation Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TrfConfRef;
        
        /// <summary>
        /// Element <b>TrfRef</b> (Transfer Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string TrfRef;
        
        /// <summary>
        /// Element <b>FctvTrfDt</b> (Effective Transfer Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateAndDateTimeChoice FctvTrfDt;
        
        /// <summary>
        /// Element <b>TradDt</b> (Trade Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime TradDt;
        
        /// <summary>
        /// Element <b>TtlUnitsNb</b> (Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FinancialInstrumentQuantity1 TtlUnitsNb;
        
        /// <summary>
        /// Element <b>UnitsDtls</b> (Units Details) of type array of Unit1.
        /// </summary>
        [XmlElementAttribute("UnitsDtls", Order=5)]
        public Unit1[] UnitsDtls;
        
        /// <summary>
        /// Element <b>OwnAcctTrfInd</b> (Own Account Transfer Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public bool OwnAcctTrfInd;
        
        /// <summary>
        /// Element <b>AvrgPric</b> (Average Price) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount AvrgPric;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:xsd:sese.007.001.01")]
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
