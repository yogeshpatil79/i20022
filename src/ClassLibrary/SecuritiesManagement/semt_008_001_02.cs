
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



namespace i20022.semt00800102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id semt.008.001.02 name RegulatoryTransactionReportV02 from Securities Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>RgltryTxRpt</b> (Regulatory Transaction Report) of type RegulatoryTransactionReportV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RegulatoryTransactionReportV02 RgltryTxRpt;
    }
    
    /// <summary>
    /// Class <b>RegulatoryTransactionReportV02</b> (Regulatory Transaction Report V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class RegulatoryTransactionReportV02
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification8 Id;
        
        /// <summary>
        /// Element <b>TxDtls</b> (Transaction Details) of type array of TransactionDetails3.
        /// </summary>
        [XmlElementAttribute("TxDtls", Order=1)]
        public TransactionDetails3[] TxDtls;
        
        /// <summary>
        /// Element <b>RptgInstn</b> (Reporting Institution) of type PartyIdentification23Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification23Choice RptgInstn;
        
        /// <summary>
        /// Element <b>RptgAgt</b> (Reporting Agent) of type PartyIdentification24Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification24Choice RptgAgt;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=4)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class DocumentIdentification8
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
        
        /// <summary>
        /// Element <b>CreDtTmSpecified</b> (Creation Date Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreDtTmSpecified;
    }
    
    /// <summary>
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    /// Class <b>PartyIdentification23Choice</b> (Party Identification 23 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class PartyIdentification23Choice
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
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    /// Class <b>UnitOrFaceAmountChoice</b> (Unit Or Face Amount Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class UnitOrFaceAmountChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// FaceAmt (Face Amount) of type CurrencyAndAmount 
        /// Unit (Unit) of type decimal 
        /// </summary>
        [XmlElementAttribute("FaceAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("Unit", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification23</b> (Party Identification 23).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class PartyIdentification23
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
        
        /// <summary>
        /// Element <b>NmAndAdr</b> (Name And Address) of type NameAndAddress5.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public NameAndAddress5 NmAndAdr;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification11Choice</b> (Party Identification 11 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class PartyIdentification11Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// CntrlCtrPty (Central Ctr Party) of type string 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("CntrlCtrPty", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>BICOrBEI - BIC Or BEI</b>.
        /// </summary>
        BICOrBEI,
        
        /// <summary>
        /// <b>CntrlCtrPty - Central Ctr Party</b>.
        /// </summary>
        CntrlCtrPty,
        
        /// <summary>
        /// <b>PrtryId - Proprietary Identification</b>.
        /// </summary>
        PrtryId,
    }
    
    /// <summary>
    /// Class <b>PartyIdentification24Choice</b> (Party Identification 24 Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class PartyIdentification24Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("MIC", typeof(string), Order=0)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>BICOrBEI - BIC Or BEI</b>.
        /// </summary>
        BICOrBEI,
        
        /// <summary>
        /// <b>MIC - ?undefined?</b>.
        /// </summary>
        MIC,
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAnd13DecimalAmount</b> (Active Or Historic Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
    /// Class <b>PriceRateOrAmountChoice</b> (Price Rate Or Amount Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class PriceRateOrAmountChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Amt (Amount) of type ActiveOrHistoricCurrencyAnd13DecimalAmount 
        /// Rate (Rate) of type decimal 
        /// </summary>
        [XmlElementAttribute("Amt", typeof(ActiveOrHistoricCurrencyAnd13DecimalAmount), Order=0)]
        [XmlElementAttribute("Rate", typeof(decimal), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification3</b> (Generic Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class GenericIdentification3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>SecurityClassificationType1Choice</b> (Security Classification Type 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class SecurityClassificationType1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AltrnClssfctn (Alternate Classification) of type GenericIdentification3 
        /// CFI (CFI) of type string 
        /// </summary>
        [XmlElementAttribute("AltrnClssfctn", typeof(GenericIdentification3), Order=0)]
        [XmlElementAttribute("CFI", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>SecurityInstrumentDescription2</b> (Security Instrument Description 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class SecurityInstrumentDescription2
    {
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Desc;
        
        /// <summary>
        /// Element <b>ClssfctnTp</b> (Classification Type) of type SecurityClassificationType1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public SecurityClassificationType1Choice ClssfctnTp;
        
        /// <summary>
        /// Element <b>PlcOfListg</b> (Place Of Listing) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string PlcOfListg;
        
        /// <summary>
        /// Element <b>ExrcDt</b> (Exercise Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime ExrcDt;
        
        /// <summary>
        /// Element <b>ExrcDtSpecified</b> (Exercise Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExrcDtSpecified;
        
        /// <summary>
        /// Element <b>MtrtyDt</b> (Maturity Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime MtrtyDt;
        
        /// <summary>
        /// Element <b>MtrtyDtSpecified</b> (Maturity Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MtrtyDtSpecified;
        
        /// <summary>
        /// Element <b>OptnTp</b> (Option Type) of type OptionTypeCode.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public OptionTypeCode OptnTp;
        
        /// <summary>
        /// Element <b>OptnTpSpecified</b> (Option Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptnTpSpecified;
        
        /// <summary>
        /// Element <b>StrkPric</b> (Strike Price) of type PriceRateOrAmountChoice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PriceRateOrAmountChoice StrkPric;
        
        /// <summary>
        /// Element <b>Mltplr</b> (Multiplier) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public decimal Mltplr;
        
        /// <summary>
        /// Element <b>MltplrSpecified</b> (Multiplier Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MltplrSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>OptionTypeCode</b> (Option Type Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public enum OptionTypeCode
    {
        
        /// <summary>
        /// <b>CALL - Call</b>.
        /// </summary>
        CALL,
        
        /// <summary>
        /// <b>PUTO - Put</b>.
        /// </summary>
        PUTO,
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType
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
    /// Class <b>SecurityIdentification6Choice</b> (Security Identification 6Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class SecurityIdentification6Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// ISIN (ISIN) of type string 
        /// InstrmDesc (Instrument Description) of type SecurityInstrumentDescription2 
        /// OthrId (Other Identification) of type AlternateSecurityIdentification1 
        /// </summary>
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("InstrmDesc", typeof(SecurityInstrumentDescription2), Order=0)]
        [XmlElementAttribute("OthrId", typeof(AlternateSecurityIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrument15</b> (Financial Instrument 15).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class FinancialInstrument15
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification6Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification6Choice Id;
        
        /// <summary>
        /// Element <b>InstrmDesc</b> (Instrument Description) of type SecurityInstrumentDescription2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public SecurityInstrumentDescription2 InstrmDesc;
        
        /// <summary>
        /// Element <b>UndrlygInstrmId</b> (Underlying Instrument Identification) of type SecurityIdentification6Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public SecurityIdentification6Choice UndrlygInstrmId;
    }
    
    /// <summary>
    /// Class <b>OffMarket1Choice</b> (Off Market 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class OffMarket1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// OffMktInd (Off Market Indicator) of type OffMarket1Code 
        /// SystmtcIntlr (Systematic Internaliser) of type string 
        /// </summary>
        [XmlElementAttribute("OffMktInd", typeof(OffMarket1Code), Order=0)]
        [XmlElementAttribute("SystmtcIntlr", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>OffMarket1Code</b> (Off Market 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public enum OffMarket1Code
    {
        
        /// <summary>
        /// <b>XOFF - Off Market</b>.
        /// </summary>
        XOFF,
        
        /// <summary>
        /// <b>XXXX - Not Admitted On Exchange</b>.
        /// </summary>
        XXXX,
    }
    
    /// <summary>
    /// Class <b>PlaceOfTradeIdentification2Choice</b> (Place Of Trade Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class PlaceOfTradeIdentification2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// MktId (Market Identification) of type string 
        /// OffMkt (Off Market) of type OffMarket1Choice 
        /// </summary>
        [XmlElementAttribute("MktId", typeof(string), Order=0)]
        [XmlElementAttribute("OffMkt", typeof(OffMarket1Choice), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>TransactionDetails3</b> (Transaction Details 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public class TransactionDetails3
    {
        
        /// <summary>
        /// Element <b>TradRef</b> (Trade Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string TradRef;
        
        /// <summary>
        /// Element <b>AssoctdTradRef</b> (Associated Trade Reference) of type array of string.
        /// </summary>
        [XmlElementAttribute("AssoctdTradRef", Order=1)]
        public string[] AssoctdTradRef;
        
        /// <summary>
        /// Element <b>PlcOfTrad</b> (Place Of Trade) of type PlaceOfTradeIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PlaceOfTradeIdentification2Choice PlcOfTrad;
        
        /// <summary>
        /// Element <b>TradDtTm</b> (Trade Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime TradDtTm;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument15.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FinancialInstrument15 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>Sd</b> (Side) of type OrderDriverCode.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public OrderDriverCode Sd;
        
        /// <summary>
        /// Element <b>TxRptMrkr</b> (Transaction Report Marker) of type array of PartyIdentification24Choice.
        /// </summary>
        [XmlElementAttribute("TxRptMrkr", Order=6)]
        public PartyIdentification24Choice[] TxRptMrkr;
        
        /// <summary>
        /// Element <b>CtrPty</b> (Ctr Party) of type PartyIdentification11Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PartyIdentification11Choice CtrPty;
        
        /// <summary>
        /// Element <b>Clnt</b> (Client) of type PartyIdentification23.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public PartyIdentification23 Clnt;
        
        /// <summary>
        /// Element <b>Cpcty</b> (Capacity) of type TradingCapacity3Code.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public TradingCapacity3Code Cpcty;
        
        /// <summary>
        /// Element <b>ExctdTradPric</b> (Executed Trade Price) of type PriceRateOrAmountChoice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public PriceRateOrAmountChoice ExctdTradPric;
        
        /// <summary>
        /// Element <b>ExctdTradQty</b> (Executed Trade Quantity) of type UnitOrFaceAmountChoice.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public UnitOrFaceAmountChoice ExctdTradQty;
        
        /// <summary>
        /// Element <b>SttlmAmt</b> (Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public ActiveCurrencyAndAmount SttlmAmt;
        
        /// <summary>
        /// Element <b>SttlmDt</b> (Settlement Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public System.DateTime SttlmDt;
        
        /// <summary>
        /// Element <b>SttlmDtSpecified</b> (Settlement Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SttlmDtSpecified;
        
        /// <summary>
        /// Element <b>PrxyHldr</b> (Proxy Holder) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public PartyIdentification2Choice PrxyHldr;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Enumeration <b>OrderDriverCode</b> (Order Driver Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public enum OrderDriverCode
    {
        
        /// <summary>
        /// <b>BUYI - Buy</b>.
        /// </summary>
        BUYI,
        
        /// <summary>
        /// <b>SELL - Seller</b>.
        /// </summary>
        SELL,
    }
    
    /// <summary>
    /// Enumeration <b>TradingCapacity3Code</b> (Trading Capacity 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:semt.008.001.02")]
    public enum TradingCapacity3Code
    {
        
        /// <summary>
        /// <b>PRIN - Principal Agent</b>.
        /// </summary>
        PRIN,
        
        /// <summary>
        /// <b>CPRN - Crossing Principal</b>.
        /// </summary>
        CPRN,
        
        /// <summary>
        /// <b>RISP - Riskless Principal</b>.
        /// </summary>
        RISP,
        
        /// <summary>
        /// <b>PROP - Proposed</b>.
        /// </summary>
        PROP,
        
        /// <summary>
        /// <b>AGEN - Agent</b>.
        /// </summary>
        AGEN,
        
        /// <summary>
        /// <b>CAGN - Crossing Agent</b>.
        /// </summary>
        CAGN,
        
        /// <summary>
        /// <b>OAGN - Other Agent</b>.
        /// </summary>
        OAGN,
        
        /// <summary>
        /// <b>PRAG - Principal Agent</b>.
        /// </summary>
        PRAG,
    }
}
