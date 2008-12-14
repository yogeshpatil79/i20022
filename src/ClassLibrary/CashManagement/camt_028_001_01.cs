
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

 
namespace i20022.camt02800101 {

    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.028.001.01 name AdditionalPaymentInformation from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01", IsNullable=false)]
    public class Document {
        
        /// <summary>
        /// Element <b>camt02800101</b> (0280 01 01) of type camt02800101.
        /// </summary>
        [XmlElementAttribute("camt.028.001.01", Order=0)]
        public camt02800101 camt02800101;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="camt.028.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class camt02800101 {
        
        /// <summary>
        /// Element <b>Assgnmt</b> (Assignment) of type CaseAssignment.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CaseAssignment Assgnmt;
        
        /// <summary>
        /// Element <b>Case</b> (Case) of type Case.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Case Case;
        
        /// <summary>
        /// Element <b>Undrlyg</b> (Underlying) of type PaymentInstructionExtract.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PaymentInstructionExtract Undrlyg;
        
        /// <summary>
        /// Element <b>Inf</b> (Information) of type PaymentComplementaryInformation.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PaymentComplementaryInformation Inf;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class CaseAssignment {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Assgnr</b> (Assigner) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Assgnr;
        
        /// <summary>
        /// Element <b>Assgne</b> (Assignee) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Assgne;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class AccountIdentification1 {
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SimpleIdentificationInformation Prtry;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class SimpleIdentificationInformation {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class Account1 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class PartyIdentification1Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// BICOrBEI of typestring
        /// NmAndAdr of typeNameAndAddress2
        /// PrtryId of typeGenericIdentification1
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress2), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class NameAndAddress2 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class LongPostalAddress1Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// Strd of typeStructuredLongPostalAddress1
        /// Ustrd of typestring
        /// </summary>
        [XmlElementAttribute("Strd", typeof(StructuredLongPostalAddress1), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class StructuredLongPostalAddress1 {
        
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
        /// Element <b>Stat</b> (Stat) of type string.
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
        /// Element <b>POB</b> (POB) of type string.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public string POB;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class GenericIdentification1 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class Intermediary1 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class EquivalentAmount {
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>CcyOfTrf</b> (Currency Of Transfer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string CcyOfTrf;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class CurrencyAndAmount {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class AmountType1Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// EqvtAmt of typeEquivalentAmount
        /// InstdAmt of typeCurrencyAndAmount
        /// </summary>
        [XmlElementAttribute("EqvtAmt", typeof(EquivalentAmount), Order=0)]
        [XmlElementAttribute("InstdAmt", typeof(CurrencyAndAmount), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class BranchData {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PostalAddress1 PstlAdr;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class PostalAddress1 {
        
        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AddressType2Code AdrTp;
        
        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
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
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public enum AddressType2Code {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class ClearingSystemMemberIdentificationChoice {
        
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
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType3 {
        
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
        /// <b>HKNCC - ?undefined</b>.
        /// </summary>
        HKNCC,
        
        /// <summary>
        /// <b>IENSC - ?undefined</b>.
        /// </summary>
        IENSC,
        
        /// <summary>
        /// <b>ITNCC - ?undefined</b>.
        /// </summary>
        ITNCC,
        
        /// <summary>
        /// <b>NZNCC - ?undefined</b>.
        /// </summary>
        NZNCC,
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class FinancialInstitutionIdentification1 {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
        
        /// <summary>
        /// Element <b>ClrSysMmbId</b> (Clearing System Member Identification) of type ClearingSystemMemberIdentificationChoice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ClearingSystemMemberIdentificationChoice ClrSysMmbId;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PostalAddress1 PstlAdr;
        
        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public GenericIdentification3 PrtryId;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class GenericIdentification3 {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class BranchAndFinancialInstitutionIdentification {
        
        /// <summary>
        /// Element <b>FinInstnId</b> (Financial Institution Identification) of type FinancialInstitutionIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public FinancialInstitutionIdentification1 FinInstnId;
        
        /// <summary>
        /// Element <b>BrnchId</b> (Branch Identification) of type BranchData.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public BranchData BrnchId;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class AccountIdentification1Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// BBAN of typestring
        /// DmstAcct of typeSimpleIdentificationInformation
        /// IBAN of typestring
        /// UPIC of typestring
        /// </summary>
        [XmlElementAttribute("BBAN", typeof(string), Order=0)]
        [XmlElementAttribute("DmstAcct", typeof(SimpleIdentificationInformation), Order=0)]
        [XmlElementAttribute("IBAN", typeof(string), Order=0)]
        [XmlElementAttribute("UPIC", typeof(string), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType2 {
        
        /// <summary>
        /// <b>BBAN - ?undefined</b>.
        /// </summary>
        BBAN,
        
        /// <summary>
        /// <b>DmstAcct - ?undefined</b>.
        /// </summary>
        DmstAcct,
        
        /// <summary>
        /// <b>IBAN - ?undefined</b>.
        /// </summary>
        IBAN,
        
        /// <summary>
        /// <b>UPIC - ?undefined</b>.
        /// </summary>
        UPIC,
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class CashAccount3 {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1Choice Id;
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CashAccountType3Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CashAccountType3Code Tp;
        
        /// <summary>
        /// Element <b>TpSpecified</b> (Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TpSpecified;
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Nm;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public enum CashAccountType3Code {
        
        /// <summary>
        /// <b>CASH - Cash Payment</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CHAR - Charges</b>.
        /// </summary>
        CHAR,
        
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
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class GenericIdentification4 {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>IdTp</b> (Identification Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IdTp;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class PersonIdentification2 {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// AlnRegnNb of typestring
        /// DrvrsLicNb of typestring
        /// IdntyCardNb of typestring
        /// MplyrIdNb of typestring
        /// OthrId of typeGenericIdentification4
        /// PsptNb of typestring
        /// SclSctyNb of typestring
        /// TaxIdNb of typestring
        /// </summary>
        [XmlElementAttribute("AlnRegnNb", typeof(string), Order=0)]
        [XmlElementAttribute("DrvrsLicNb", typeof(string), Order=0)]
        [XmlElementAttribute("IdntyCardNb", typeof(string), Order=0)]
        [XmlElementAttribute("MplyrIdNb", typeof(string), Order=0)]
        [XmlElementAttribute("OthrId", typeof(GenericIdentification4), Order=0)]
        [XmlElementAttribute("PsptNb", typeof(string), Order=0)]
        [XmlElementAttribute("SclSctyNb", typeof(string), Order=0)]
        [XmlElementAttribute("TaxIdNb", typeof(string), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1 {
        
        /// <summary>
        /// <b>AlnRegnNb - ?undefined</b>.
        /// </summary>
        AlnRegnNb,
        
        /// <summary>
        /// <b>DrvrsLicNb - ?undefined</b>.
        /// </summary>
        DrvrsLicNb,
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class NonFinancialInstitutionIdentification1 {
        
        /// <summary>
        /// Element <b>BEI</b> (BEI) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BEI;
        
        /// <summary>
        /// Element <b>EANGLN</b> (EANGLN) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string EANGLN;
        
        /// <summary>
        /// Element <b>USCHU</b> (USCHU) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string USCHU;
        
        /// <summary>
        /// Element <b>DUNS</b> (DUNS) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DUNS;
        
        /// <summary>
        /// Element <b>BkPtyId</b> (Bank Party Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string BkPtyId;
        
        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string TaxIdNb;
        
        /// <summary>
        /// Element <b>PrtryId</b> (Proprietary Identification) of type GenericIdentification3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public GenericIdentification3 PrtryId;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class Party1Choice {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// This element can be:
        /// OrgId of typeNonFinancialInstitutionIdentification1
        /// PrvtId of typePersonIdentification2
        /// </summary>
        [XmlElementAttribute("OrgId", typeof(NonFinancialInstitutionIdentification1), Order=0)]
        [XmlElementAttribute("PrvtId", typeof(PersonIdentification2), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class PartyIdentification1 {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 PstlAdr;
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type Party1Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public Party1Choice Id;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class ReferredDocumentAmount1Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute("CdtNoteAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("DscntApldAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("DuePyblAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("RmtdAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlElementAttribute("TaxAmt", typeof(CurrencyAndAmount), Order=0)]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public CurrencyAndAmount Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
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
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class StructuredRemittanceInformation2 {
        
        /// <summary>
        /// Element <b>RfrdDocTp</b> (Referred Document Type) of type DocumentType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentType1Code RfrdDocTp;
        
        /// <summary>
        /// Element <b>RfrdDocTpSpecified</b> (Referred Document Type Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RfrdDocTpSpecified;
        
        /// <summary>
        /// Element <b>RfrdDocRltdDt</b> (Referred Document Related Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime RfrdDocRltdDt;
        
        /// <summary>
        /// Element <b>RfrdDocRltdDtSpecified</b> (Referred Document Related Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RfrdDocRltdDtSpecified;
        
        /// <summary>
        /// Element <b>RfrdDocAmt</b> (Referred Document Amount) of type array of ReferredDocumentAmount1Choice.
        /// </summary>
        [XmlElementAttribute("RfrdDocAmt", Order=2)]
        public ReferredDocumentAmount1Choice[] RfrdDocAmt;
        
        /// <summary>
        /// Element <b>DocRefNb</b> (Document Reference Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DocRefNb;
        
        /// <summary>
        /// Element <b>CdtrRef</b> (Creditor Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string CdtrRef;
        
        /// <summary>
        /// Element <b>Invcr</b> (Invcr) of type PartyIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification1 Invcr;
        
        /// <summary>
        /// Element <b>Invcee</b> (Invcee) of type PartyIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification1 Invcee;
    }
    
    /// <summary>
    /// Enumeration <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public enum DocumentType1Code {
        
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
        /// <b>RADM - Remittance Advice Message</b>.
        /// </summary>
        RADM,
        
        /// <summary>
        /// <b>RPIN - Related Payment Instruction</b>.
        /// </summary>
        RPIN,
        
        /// <summary>
        /// <b>CMCN - Commercial Contract</b>.
        /// </summary>
        CMCN,
        
        /// <summary>
        /// <b>FXDR - Foreign Exchange Deal Reference</b>.
        /// </summary>
        FXDR,
        
        /// <summary>
        /// <b>SOAC - Statement Of Account</b>.
        /// </summary>
        SOAC,
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class RemittanceInformation3Choice {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// This element can be:
        /// Strd of typeStructuredRemittanceInformation2
        /// Ustrd of typestring
        /// </summary>
        [XmlElementAttribute("Strd", typeof(StructuredRemittanceInformation2), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class PaymentComplementaryInformation {
        
        /// <summary>
        /// Element <b>RmtChc</b> (Remittance Choice) of type RemittanceInformation3Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public RemittanceInformation3Choice RmtChc;
        
        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification1 Dbtr;
        
        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type CashAccount3.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CashAccount3 DbtrAcct;
        
        /// <summary>
        /// Element <b>FrstAgt</b> (First Agent) of type BranchAndFinancialInstitutionIdentification.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public BranchAndFinancialInstitutionIdentification FrstAgt;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type AmountType1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public AmountType1Choice Amt;
        
        /// <summary>
        /// Element <b>NstrVstrAcct</b> (Nostro Vostro Account) of type CashAccount3.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CashAccount3 NstrVstrAcct;
        
        /// <summary>
        /// Element <b>Intrmy</b> (Intermediary) of type Intermediary1.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public Intermediary1 Intrmy;
        
        /// <summary>
        /// Element <b>FrstSttlmAgt</b> (First Settlement Agent) of type BranchAndFinancialInstitutionIdentification.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public BranchAndFinancialInstitutionIdentification FrstSttlmAgt;
        
        /// <summary>
        /// Element <b>LastSttlmAgt</b> (Last Settlement Agent) of type BranchAndFinancialInstitutionIdentification.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public BranchAndFinancialInstitutionIdentification LastSttlmAgt;
        
        /// <summary>
        /// Element <b>IntrmySttlmAgt</b> (Intermediary Settlement Agent) of type BranchAndFinancialInstitutionIdentification.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public BranchAndFinancialInstitutionIdentification IntrmySttlmAgt;
        
        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public PartyIdentification1 Cdtr;
        
        /// <summary>
        /// Element <b>CdtrAcct</b> (Creditor Account) of type CashAccount3.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public CashAccount3 CdtrAcct;
        
        /// <summary>
        /// Element <b>SndrToRcvrInf</b> (Sender To Receiver Information) of type array of string.
        /// </summary>
        [XmlElementAttribute("SndrToRcvrInf", Order=12)]
        public string[] SndrToRcvrInf;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class PaymentInstructionExtract {
        
        /// <summary>
        /// Element <b>AssgnrInstrId</b> (Assigner Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AssgnrInstrId;
        
        /// <summary>
        /// Element <b>AssgneInstrId</b> (Assignee Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AssgneInstrId;
        
        /// <summary>
        /// Element <b>CcyAmt</b> (Currency Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount CcyAmt;
        
        /// <summary>
        /// Element <b>ValDt</b> (Value Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime ValDt;
        
        /// <summary>
        /// Element <b>ValDtSpecified</b> (Value Date Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ValDtSpecified;
    }
    
    /// <summary>
    /// Class <b>{</b> ({).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.028.001.01")]
    public class Case {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Cretr</b> (Cretr) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Cretr;
        
        /// <summary>
        /// Element <b>ReopCaseIndctn</b> (Reopen Case Indication) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool ReopCaseIndctn;
        
        /// <summary>
        /// Element <b>ReopCaseIndctnSpecified</b> (Reopen Case Indication Specified) of type bool.
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReopCaseIndctnSpecified;
    }
}
