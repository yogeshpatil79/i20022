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
// |               http://www.i20022.com               |
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
using System.Linq;
using System.Text;


namespace i20022.MessageSet
{

    /// <summary>
    /// Utility class responsible for give meanings to message fields and types.
    /// </summary>
    internal static class Acronyms
    {

        #region Private members

        private static Dictionary<string, string> _acronyms;

        #endregion


        #region Static initializer (Populates Acronyms Dictionary)


        /// <summary>
        /// 
        /// </summary>
        static Acronyms()
        {
            _acronyms = new Dictionary<string, string>();

            _acronyms.Add( "0", "0" );
            _acronyms.Add( "1", "1" );
            _acronyms.Add( "2", "2" );
            _acronyms.Add( "3", "3" );
            _acronyms.Add( "4", "4" );
            _acronyms.Add( "5", "5" );
            _acronyms.Add( "6", "6" );
            _acronyms.Add( "7", "7" );
            _acronyms.Add( "8", "8" );
            _acronyms.Add( "9", "9" );

            _acronyms.Add( "Abs", "Absolute" );
            _acronyms.Add( "Accptd", "Accepted" );
            _acronyms.Add( "Accptnc", "Acceptance" );
            _acronyms.Add( "Acct", "Account" );
            _acronyms.Add( "Acmltn", "Accumulation" );
            _acronyms.Add( "Acqstn", "Acquisition" );
            _acronyms.Add( "Acrd", "Accrued" );
            _acronyms.Add( "Actl", "Actual" );
            _acronyms.Add( "Actn", "Action" );
            _acronyms.Add( "Actvty", "Activity" );
            _acronyms.Add( "Addtl", "Additional" );
            _acronyms.Add( "Adjstmnt", "Adjustment" );
            _acronyms.Add( "Adr", "Address" );
            _acronyms.Add( "Agcy", "Agency" );
            _acronyms.Add( "Aggt", "Aggregate" );
            _acronyms.Add( "Agnst", "Against" );
            _acronyms.Add( "Agrd", "Agreed" );
            _acronyms.Add( "Agrmt", "Agreement" );
            _acronyms.Add( "Agt", "Agent" );
            _acronyms.Add( "Air", "Air" );
            _acronyms.Add( "Airprt", "Airport" );
            _acronyms.Add( "All", "All" );
            _acronyms.Add( "Allcn", "Allocation" );
            _acronyms.Add( "Allctd", "Allocated" );
            _acronyms.Add( "Allgd", "Alleged" );
            _acronyms.Add( "Allowed", "Allowed" );
            _acronyms.Add( "Allwd", "Allowed" );
            _acronyms.Add( "Allwnc", "Allowance" );
            _acronyms.Add( "Aln", "Alien" );
            _acronyms.Add( "Along", "Along" );
            _acronyms.Add( "Already", "Already" );
            _acronyms.Add( "Altrn", "Alternate" );
            _acronyms.Add( "Altrntv", "Alternative" );
            _acronyms.Add( "Amd", "Amend" );
            _acronyms.Add( "Amdmnt", "Amendment" );
            _acronyms.Add( "Amount", "Amount" );
            _acronyms.Add( "Amt", "Amount" );
            _acronyms.Add( "Amts", "Amounts" );
            _acronyms.Add( "Amtsd", "Amortised" );
            _acronyms.Add( "And", "And" );
            _acronyms.Add( "Anncmnt", "Announcement" );
            _acronyms.Add( "Any", "Any" );
            _acronyms.Add( "Apld", "Applied" );
            _acronyms.Add( "Appl", "Application" );
            _acronyms.Add( "Appntmnt", "Appointment" );
            _acronyms.Add( "Area", "Area" );
            _acronyms.Add( "As", "As" );
            _acronyms.Add( "Assgne", "Assignee" );
            _acronyms.Add( "Assgnmt", "Assignment" );
            _acronyms.Add( "Assgnr", "Assigner" );
            _acronyms.Add( "Assoctd", "Associated" );
            _acronyms.Add( "Asst", "Asset" );
            _acronyms.Add( "At", "At" );
            _acronyms.Add( "Attchd", "Attached" );
            _acronyms.Add( "Attndee", "Attendee" );
            _acronyms.Add( "Attndnc", "Attendance" );
            _acronyms.Add( "Attny", "Attorney" );
            _acronyms.Add( "Audtd", "Audited" );
            _acronyms.Add( "Authrsd", "Authorised" );
            _acronyms.Add( "Authrty", "Authority" );
            _acronyms.Add( "Authstn", "Authorisation" );
            _acronyms.Add( "Auto", "Auto" );
            _acronyms.Add( "Avlbl", "Available" );
            _acronyms.Add( "Avlbty", "Availability" );
            _acronyms.Add( "Avrg", "Average" );
            _acronyms.Add( "B", "Branch" );
            _acronyms.Add( "Bal", "Balance" );
            _acronyms.Add( "Base", "Base" );
            _acronyms.Add( "Baseln", "Baseline" );
            _acronyms.Add( "Bchmk", "Benchmark" );
            _acronyms.Add( "Bckd", "Backed" );
            _acronyms.Add( "Bd", "Bond" );
            _acronyms.Add( "Bddrs", "Bidders" );
            _acronyms.Add( "Bdry", "Boundary" );
            _acronyms.Add( "Be", "Be" );
            _acronyms.Add( "Bid", "Bid" );
            _acronyms.Add( "Biddg", "Bidding" );
            _acronyms.Add( "Bil", "Bilateral" );
            _acronyms.Add( "Birth", "Birth" );
            _acronyms.Add( "Biz", "Business" );
            _acronyms.Add( "Bk", "Bank" );
            _acronyms.Add( "Blck", "Block" );
            _acronyms.Add( "Blckg", "Blocking" );
            _acronyms.Add( "Bldg", "Building" );
            _acronyms.Add( "Blk", "Bulk" );
            _acronyms.Add( "Bll", "Bill" );
            _acronyms.Add( "Bllt", "Ballot" );
            _acronyms.Add( "Bnfcl", "Beneficial" );
            _acronyms.Add( "Bnfcry", "Beneficiary" );
            _acronyms.Add( "Book", "Book" );
            _acronyms.Add( "Bookg", "Booking" );
            _acronyms.Add( "Br", "Bearer" );
            _acronyms.Add( "Brg", "Bearing" );
            _acronyms.Add( "Brkdwn", "Breakdown" );
            _acronyms.Add( "Brkr", "Broker" );
            _acronyms.Add( "Brnch", "Branch" );
            _acronyms.Add( "Bsis", "Basis" );
            _acronyms.Add( "Btch", "Batch" );
            _acronyms.Add( "Buy", "Buy" );
            _acronyms.Add( "Buyr", "Buyer" );
            _acronyms.Add( "Bx", "Identification" );
            _acronyms.Add( "By", "By" );
            _acronyms.Add( "Call", "Call" );
            _acronyms.Add( "Canc", "Cancelled" );
            _acronyms.Add( "Card", "Card" );
            _acronyms.Add( "Case", "Case" );
            _acronyms.Add( "Ccl", "Cancel" );
            _acronyms.Add( "Ccy", "Currency" );
            _acronyms.Add( "Cd", "Code" );
            _acronyms.Add( "Cdt", "Credit" );
            _acronyms.Add( "Cdtr", "Creditor" );
            _acronyms.Add( "Cert", "Certificate" );
            _acronyms.Add( "Certd", "Certificated" );
            _acronyms.Add( "Certfctn", "Certification" );
            _acronyms.Add( "Chanl", "Channel" );
            _acronyms.Add( "Chc", "Choice" );
            _acronyms.Add( "Chck", "Check" );
            _acronyms.Add( "Chng", "Change" );
            _acronyms.Add( "Chq", "Cheque" );
            _acronyms.Add( "Chrg", "Charge" );
            _acronyms.Add( "Chrgs", "Charges" );
            _acronyms.Add( "Chrtcs", "Characteristics" );
            _acronyms.Add( "City", "City" );
            _acronyms.Add( "Clctd", "Calculated" );
            _acronyms.Add( "Clctn", "Calculation" );
            _acronyms.Add( "Cllbl", "Callable" );
            _acronyms.Add( "Clm", "Claim" );
            _acronyms.Add( "Clnt", "Client" );
            _acronyms.Add( "Clr", "Clearing" );
            _acronyms.Add( "Clsg", "Closing" );
            _acronyms.Add( "Clsr", "Closure" );
            _acronyms.Add( "Clss", "Class" );
            _acronyms.Add( "Clssfctn", "Classification" );
            _acronyms.Add( "Cmbnd", "Combined" );
            _acronyms.Add( "Cmon", "Common" );
            _acronyms.Add( "Cmplc", "Compliance" );
            _acronyms.Add( "Cmplt", "Complete" );
            _acronyms.Add( "Cmpnt", "Component" );
            _acronyms.Add( "Cmptn", "Computation" );
            _acronyms.Add( "Cntrl", "Central" );
            _acronyms.Add( "Cnts", "Contents" );
            _acronyms.Add( "Coll", "Collateral" );
            _acronyms.Add( "Colltn", "Collection" );
            _acronyms.Add( "Com", "Communication" );
            _acronyms.Add( "Compstn", "Compensation" );
            _acronyms.Add( "Comrcl", "Commercial" );
            _acronyms.Add( "Comssn", "Commission" );
            _acronyms.Add( "Comssns", "Commissions" );
            _acronyms.Add( "Cond", "Condition" );
            _acronyms.Add( "Condly", "Conditionally" );
            _acronyms.Add( "Conds", "Conditions" );
            _acronyms.Add( "Conf", "Confirmation" );
            _acronyms.Add( "Confd", "Confirmed" );
            _acronyms.Add( "Contra", "Contra" );
            _acronyms.Add( "Convs", "Conversion" );
            _acronyms.Add( "Convtbl", "Convertible" );
            _acronyms.Add( "Corp", "Corporate" );
            _acronyms.Add( "Cover", "Cover" );
            _acronyms.Add( "Cpn", "Coupon" );
            _acronyms.Add( "Cptl", "Capital" );
            _acronyms.Add( "Cptlstn", "Capitalisation" );
            _acronyms.Add( "Cpy", "Copy" );
            _acronyms.Add( "Cre", "Creation" );
            _acronyms.Add( "Crit", "Criteria" );
            _acronyms.Add( "Critn", "Criterion" );
            _acronyms.Add( "Cross", "Cross" );
            _acronyms.Add( "Crrctd", "Corrected" );
            _acronyms.Add( "Crrier", "Carrier" );
            _acronyms.Add( "Crspdt", "Correspondent" );
            _acronyms.Add( "Crt", "Court" );
            _acronyms.Add( "Crv", "Curve" );
            _acronyms.Add( "Csh", "Cash" );
            _acronyms.Add( "Cst", "Constant" );
            _acronyms.Add( "Cstmr", "Customer" );
            _acronyms.Add( "Ct", "Cent" );
            _acronyms.Add( "Ctct", "Contact" );
            _acronyms.Add( "Ctdn", "Custodian" );
            _acronyms.Add( "Ctdy", "Custody" );
            _acronyms.Add( "Ctgy", "Category" );
            _acronyms.Add( "Ctrct", "Contract" );
            _acronyms.Add( "Ctrl", "Control" );
            _acronyms.Add( "Ctry", "Country" );
            _acronyms.Add( "Cty", "County" );
            _acronyms.Add( "Ctznsh", "Citizenship" );
            _acronyms.Add( "Cum", "Cum" );
            _acronyms.Add( "Cur", "Current" );
            _acronyms.Add( "Cvrd", "Covered" );
            _acronyms.Add( "Cxl", "Cancellation" );
            _acronyms.Add( "Cycl", "Cycle" );
            _acronyms.Add( "Data", "Data" );
            _acronyms.Add( "Day", "Day" );
            _acronyms.Add( "Days", "Days" );
            _acronyms.Add( "Dbt", "Debit" );
            _acronyms.Add( "Dbtr", "Debtor" );
            _acronyms.Add( "Dclrtn", "Declaration" );
            _acronyms.Add( "Dcmnttn", "Documentation" );
            _acronyms.Add( "Ddln", "Deadline" );
            _acronyms.Add( "Deal", "Deal" );
            _acronyms.Add( "Debt", "Debt" );
            _acronyms.Add( "Del", "Delete" );
            _acronyms.Add( "Deltd", "Deleted" );
            _acronyms.Add( "Dely", "Delay" );
            _acronyms.Add( "Deriv", "Derivative" );
            _acronyms.Add( "Desc", "Description" );
            _acronyms.Add( "Description", "Description" );
            _acronyms.Add( "Dflt", "Default" );
            _acronyms.Add( "Dfnd", "Defined" );
            _acronyms.Add( "Diff", "Difference" );
            _acronyms.Add( "Disp", "Display" );
            _acronyms.Add( "Dlvr", "Deliver" );
            _acronyms.Add( "Dlvrg", "Delivering" );
            _acronyms.Add( "Dlvrr", "Deliverer" );
            _acronyms.Add( "Dlvrrs", "Deliverers" );
            _acronyms.Add( "Dlvry", "Delivery" );
            _acronyms.Add( "Dmst", "Domestic" );
            _acronyms.Add( "Dmtrlsd", "Dematerialised" );
            _acronyms.Add( "Dnmtn", "Denomination" );
            _acronyms.Add( "Do", "Do" );
            _acronyms.Add( "Doc", "Document" );
            _acronyms.Add( "Dont", "Dont" );
            _acronyms.Add( "Dplct", "Duplicate" );
            _acronyms.Add( "Dprture", "Departure" );
            _acronyms.Add( "Dpstary", "Depositary" );
            _acronyms.Add( "Dpstry", "Depository" );
            _acronyms.Add( "Drct", "Direct" );
            _acronyms.Add( "Drctn", "Direction" );
            _acronyms.Add( "Drvrs", "Drivers" );
            _acronyms.Add( "Drwee", "Drawee" );
            _acronyms.Add( "Drwr", "Drawer" );
            _acronyms.Add( "Dschrge", "Discharge" );
            _acronyms.Add( "Dscld", "Disclosed" );
            _acronyms.Add( "Dsclsr", "Disclosure" );
            _acronyms.Add( "Dscnt", "Discount" );
            _acronyms.Add( "Dsgnt", "Designation" );
            _acronyms.Add( "Dstn", "Destination" );
            _acronyms.Add( "Dstrbtn", "Distribution" );
            _acronyms.Add( "Dstrct", "District" );
            _acronyms.Add( "Dt", "Date" );
            _acronyms.Add( "Dtd", "Dated" );
            _acronyms.Add( "Dth", "Death" );
            _acronyms.Add( "Dtl", "Detail" );
            _acronyms.Add( "Dtld", "Detailed" );
            _acronyms.Add( "Dtls", "Details" );
            _acronyms.Add( "Dty", "Duty" );
            _acronyms.Add( "Dual", "Dual" );
            _acronyms.Add( "Due", "Due" );
            _acronyms.Add( "Dvdd", "Dividend" );
            _acronyms.Add( "Dvsn", "Division" );
            _acronyms.Add( "Dwn", "Down" );
            _acronyms.Add( "Earlst", "Earliest" );
            _acronyms.Add( "Elctrnc", "Electronic" );
            _acronyms.Add( "Elmt", "Element" );
            _acronyms.Add( "Email", "Email" );
            _acronyms.Add( "Emplng", "Employing" );
            _acronyms.Add( "End", "End" );
            _acronyms.Add( "Entitlmnt", "Entitlement" );
            _acronyms.Add( "Eqty", "Equity" );
            _acronyms.Add( "Eqvt", "Equivalent" );
            _acronyms.Add( "Err", "Error" );
            _acronyms.Add( "Escrwd", "Escrowed" );
            _acronyms.Add( "Estmtd", "Estimated" );
            _acronyms.Add( "Evt", "Event" );
            _acronyms.Add( "Ex", "Ex" );
            _acronyms.Add( "Exct", "Execute" );
            _acronyms.Add( "Exctd", "Executed" );
            _acronyms.Add( "Exctg", "Executing" );
            _acronyms.Add( "Exctn", "Execution" );
            _acronyms.Add( "Executed", "Executed" );
            _acronyms.Add( "Exrc", "Exercise" );
            _acronyms.Add( "Exrcbl", "Exercisable" );
            _acronyms.Add( "F", "Foreign" );
            _acronyms.Add( "Face", "Face" );
            _acronyms.Add( "Failr", "Failure" );
            _acronyms.Add( "Fair", "Fair" );
            _acronyms.Add( "Fax", "Fax" );
            _acronyms.Add( "Fcst", "Forecast" );
            _acronyms.Add( "Fct", "Effect" );
            _acronyms.Add( "Fctnl", "Functional" );
            _acronyms.Add( "Fctr", "Factor" );
            _acronyms.Add( "Fctv", "Effective" );
            _acronyms.Add( "Featr", "Feature" );
            _acronyms.Add( "Fee", "Fee" );
            _acronyms.Add( "File", "File" );
            _acronyms.Add( "Fill", "Fill" );
            _acronyms.Add( "Filld", "Filled" );
            _acronyms.Add( "Fin", "Financial" );
            _acronyms.Add( "Firm", "Firm" );
            _acronyms.Add( "Five", "Five" );
            _acronyms.Add( "Flat", "Flat" );
            _acronyms.Add( "Fld", "Field" );
            _acronyms.Add( "Flng", "Failing" );
            _acronyms.Add( "Flow", "Flow" );
            _acronyms.Add( "Flr", "Floor" );
            _acronyms.Add( "Fltg", "Floating" );
            _acronyms.Add( "Fmly", "Family" );
            _acronyms.Add( "Fnd", "Fund" );
            _acronyms.Add( "Fndd", "Funded" );
            _acronyms.Add( "Fngb", "Fungible" );
            _acronyms.Add( "Fnl", "Final" );
            _acronyms.Add( "For", "For" );
            _acronyms.Add( "Force", "Force" );
            _acronyms.Add( "Form", "Form" );
            _acronyms.Add( "Fr", "From" );
            _acronyms.Add( "Frft", "Forfeit" );
            _acronyms.Add( "Frght", "Freight" );
            _acronyms.Add( "Frgn", "Foreign" );
            _acronyms.Add( "Frms", "Forms" );
            _acronyms.Add( "Frmtd", "Formatted" );
            _acronyms.Add( "Frqcy", "Frequency" );
            _acronyms.Add( "Frst", "First" );
            _acronyms.Add( "Fscl", "Fiscal" );
            _acronyms.Add( "Futr", "Future" );
            _acronyms.Add( "Futrs", "Futures" );
            _acronyms.Add( "Fwdg", "Forwarding" );
            _acronyms.Add( "Fxd", "Fixed" );
            _acronyms.Add( "Gbl", "Global" );
            _acronyms.Add( "Gn", "Gain" );
            _acronyms.Add( "Gndr", "Gender" );
            _acronyms.Add( "Gnl", "General" );
            _acronyms.Add( "Go", "Go" );
            _acronyms.Add( "Good", "Good" );
            _acronyms.Add( "Goods", "Goods" );
            _acronyms.Add( "Govnt", "Government" );
            _acronyms.Add( "Grd", "Grand" );
            _acronyms.Add( "Grdfthd", "Grandfathered" );
            _acronyms.Add( "Grp", "Group" );
            _acronyms.Add( "Grss", "Gross" );
            _acronyms.Add( "Guardn", "Guardian" );
            _acronyms.Add( "Gv", "Give" );
            _acronyms.Add( "Gvn", "Given" );
            _acronyms.Add( "Halt", "Halt" );
            _acronyms.Add( "Hdlg", "Handling" );
            _acronyms.Add( "Hdr", "Header" );
            _acronyms.Add( "Held", "Held" );
            _acronyms.Add( "Hghst", "Highest" );
            _acronyms.Add( "Hldg", "Holding" );
            _acronyms.Add( "Hldgs", "Holdings" );
            _acronyms.Add( "Hldr", "Holder" );
            _acronyms.Add( "Hrs", "Hours" );
            _acronyms.Add( "Id", "Identification" );
            _acronyms.Add( "Idnty", "Identity" );
            _acronyms.Add( "Idr", "Identifier" );
            _acronyms.Add( "Imblsd", "Immobilised" );
            _acronyms.Add( "Imdt", "Immediate" );
            _acronyms.Add( "Img", "Image" );
            _acronyms.Add( "Impld", "Implied" );
            _acronyms.Add( "Imprvmt", "Improvement" );
            _acronyms.Add( "In", "In" );
            _acronyms.Add( "Incl", "Included" );
            _acronyms.Add( "Incm", "Income" );
            _acronyms.Add( "Incntiv", "Incentive" );
            _acronyms.Add( "Incrrct", "Incorrect" );
            _acronyms.Add( "Ind", "Indicator" );
            _acronyms.Add( "Indctn", "Indication" );
            _acronyms.Add( "Indv", "Individual" );
            _acronyms.Add( "Indx", "Index" );
            _acronyms.Add( "Inf", "Information" );
            _acronyms.Add( "Init", "Initiate" );
            _acronyms.Add( "Initg", "Initiating" );
            _acronyms.Add( "Initl", "Initial" );
            _acronyms.Add( "Initn", "Initiation" );
            _acronyms.Add( "Initr", "Initiator" );
            _acronyms.Add( "Inittd", "Initiated" );
            _acronyms.Add( "Insrd", "Insured" );
            _acronyms.Add( "Instd", "Instructed" );
            _acronyms.Add( "Instg", "Instructing" );
            _acronyms.Add( "Instlmt", "Instalment" );
            _acronyms.Add( "Instn", "Institution" );
            _acronyms.Add( "Instns", "Institutions" );
            _acronyms.Add( "Instr", "Instruction" );
            _acronyms.Add( "Instrm", "Instrument" );
            _acronyms.Add( "Instrs", "Instructions" );
            _acronyms.Add( "Intrm", "Interim" );
            _acronyms.Add( "Intrmy", "Intermediary" );
            _acronyms.Add( "Intrnl", "International" );
            _acronyms.Add( "Intrst", "Interest" );
            _acronyms.Add( "Intrstd", "Interested" );
            _acronyms.Add( "Intrvl", "Interval" );
            _acronyms.Add( "Intt", "Intent" );
            _acronyms.Add( "Invalid", "Invalid" );
            _acronyms.Add( "Invstgtn", "Investigation" );
            _acronyms.Add( "Invstmt", "Investment" );
            _acronyms.Add( "Invstr", "Investor" );
            _acronyms.Add( "Is", "Is" );
            _acronyms.Add( "Issd", "Issued" );
            _acronyms.Add( "Isse", "Issue" );
            _acronyms.Add( "Issr", "Issuer" );
            _acronyms.Add( "Itm", "Item" );
            _acronyms.Add( "Itms", "Items" );
            _acronyms.Add( "Jnt", "Joint" );
            _acronyms.Add( "Labl", "Label" );
            _acronyms.Add( "Lang", "Language" );
            _acronyms.Add( "Last", "Last" );
            _acronyms.Add( "Latst", "Latest" );
            _acronyms.Add( "Lbllg", "Labelling" );
            _acronyms.Add( "Lblty", "Liability" );
            _acronyms.Add( "Lcl", "Local" );
            _acronyms.Add( "Lct", "Locate" );
            _acronyms.Add( "Lctn", "Location" );
            _acronyms.Add( "Leg", "Leg" );
            _acronyms.Add( "Lgl", "Legal" );
            _acronyms.Add( "Lic", "License" );
            _acronyms.Add( "Life", "Life" );
            _acronyms.Add( "Line", "Line" );
            _acronyms.Add( "List", "List" );
            _acronyms.Add( "Listg", "Listing" );
            _acronyms.Add( "Lk", "Link" );
            _acronyms.Add( "Lkd", "Linked" );
            _acronyms.Add( "Lmt", "Limit" );
            _acronyms.Add( "Ln", "Loan" );
            _acronyms.Add( "Lndg", "Lending" );
            _acronyms.Add( "Lndrg", "Laundering" );
            _acronyms.Add( "Lng", "Long" );
            _acronyms.Add( "Loadng", "Loading" );
            _acronyms.Add( "Loss", "Loss" );
            _acronyms.Add( "Lot", "Lot" );
            _acronyms.Add( "Lqdty", "Liquidity" );
            _acronyms.Add( "Lswhr", "Elsewhere" );
            _acronyms.Add( "Lttr", "Letter" );
            _acronyms.Add( "Lvl", "Level" );
            _acronyms.Add( "Lwst", "Lowest" );
            _acronyms.Add( "Mail", "Mail" );
            _acronyms.Add( "Main", "Main" );
            _acronyms.Add( "Max", "Maximum" );
            _acronyms.Add( "Md", "Mode" );
            _acronyms.Add( "Mddl", "Middle" );
            _acronyms.Add( "Mdlus", "Modulus" );
            _acronyms.Add( "Measr", "Measure" );
            _acronyms.Add( "Memo", "Memo" );
            _acronyms.Add( "Mgmt", "Management" );
            _acronyms.Add( "Mgr", "Manager" );
            _acronyms.Add( "Mid", "Mid" );
            _acronyms.Add( "Min", "Minimum" );
            _acronyms.Add( "Mis", "Mis" );
            _acronyms.Add( "Mkp", "Markup" );
            _acronyms.Add( "Mkt", "Market" );
            _acronyms.Add( "Mln", "Million" );
            _acronyms.Add( "Mlng", "Mailing" );
            _acronyms.Add( "Mltmdl", "Multimodal" );
            _acronyms.Add( "Mltpl", "Multiple" );
            _acronyms.Add( "Mltplr", "Multiplier" );
            _acronyms.Add( "Mmb", "Member" );
            _acronyms.Add( "Mncpl", "Municipal" );
            _acronyms.Add( "Mndt", "Mandate" );
            _acronyms.Add( "Mnr", "Minor" );
            _acronyms.Add( "Mns", "Minus" );
            _acronyms.Add( "Mnths", "Months" );
            _acronyms.Add( "Mny", "Money" );
            _acronyms.Add( "Mob", "Mobile" );
            _acronyms.Add( "Mod", "Modification" );
            _acronyms.Add( "Modfd", "Modified" );
            _acronyms.Add( "Mplyr", "Employer" );
            _acronyms.Add( "Mrgn", "Margin" );
            _acronyms.Add( "Mrtg", "Mortgage" );
            _acronyms.Add( "Msg", "Message" );
            _acronyms.Add( "Mssng", "Missing" );
            _acronyms.Add( "Mstr", "Master" );
            _acronyms.Add( "Mtch", "Match" );
            _acronyms.Add( "Mtchd", "Matched" );
            _acronyms.Add( "Mtchg", "Matching" );
            _acronyms.Add( "Mtchs", "Matches" );
            _acronyms.Add( "Mtd", "Method" );
            _acronyms.Add( "Mtg", "Meeting" );
            _acronyms.Add( "Mthds", "Methods" );
            _acronyms.Add( "Mtrty", "Maturity" );
            _acronyms.Add( "Mul", "Multilateral" );
            _acronyms.Add( "Nb", "Number" );
            _acronyms.Add( "Net", "Net" );
            _acronyms.Add( "Netg", "Netting" );
            _acronyms.Add( "New", "New" );
            _acronyms.Add( "Ngtbl", "Negotiable" );
            _acronyms.Add( "Nm", "Name" );
            _acronyms.Add( "Nmnee", "Nominee" );
            _acronyms.Add( "Nmnl", "Nominal" );
            _acronyms.Add( "Nn", "None" );
            _acronyms.Add( "No", "No" );
            _acronyms.Add( "Non", "Non" );
            _acronyms.Add( "Not", "Not" );
            _acronyms.Add( "Note", "Note" );
            _acronyms.Add( "Nstr", "Nostro" );
            _acronyms.Add( "Ntfctn", "Notification" );
            _acronyms.Add( "Ntfy", "Notify" );
            _acronyms.Add( "Ntifng", "Notifying" );
            _acronyms.Add( "Ntl", "National" );
            _acronyms.Add( "Ntlty", "Nationality" );
            _acronyms.Add( "Ntrl", "Natural" );
            _acronyms.Add( "Ntry", "Entry" );
            _acronyms.Add( "Ntties", "Entities" );
            _acronyms.Add( "Ntty", "Entity" );
            _acronyms.Add( "Ntwk", "Network" );
            _acronyms.Add( "Nxt", "Next" );
            _acronyms.Add( "Odd", "Odd" );
            _acronyms.Add( "Of", "Of" );
            _acronyms.Add( "Offer", "Offer" );
            _acronyms.Add( "Offset", "Offset" );
            _acronyms.Add( "On", "On" );
            _acronyms.Add( "One", "One" );
            _acronyms.Add( "Only", "Only" );
            _acronyms.Add( "Opng", "Opening" );
            _acronyms.Add( "Opr", "Operation" );
            _acronyms.Add( "Optn", "Option" );
            _acronyms.Add( "Or", "Or" );
            _acronyms.Add( "Ordr", "Order" );
            _acronyms.Add( "Ordrd", "Ordered" );
            _acronyms.Add( "Ordrg", "Ordering" );
            _acronyms.Add( "Ordrs", "Orders" );
            _acronyms.Add( "Org", "Organisation" );
            _acronyms.Add( "Orgn", "Origin" );
            _acronyms.Add( "Orgnl", "Original" );
            _acronyms.Add( "Orgtg", "Originating" );
            _acronyms.Add( "Orgtn", "Origination" );
            _acronyms.Add( "Orgtr", "Originator" );
            _acronyms.Add( "Othr", "Other" );
            _acronyms.Add( "Out", "Out" );
            _acronyms.Add( "Outsd", "Outside" );
            _acronyms.Add( "Outsdng", "Outstanding" );
            _acronyms.Add( "Over", "Over" );
            _acronyms.Add( "Own", "Own" );
            _acronyms.Add( "Ownr", "Owner" );
            _acronyms.Add( "Ownrsh", "Ownership" );
            _acronyms.Add( "Par", "Par" );
            _acronyms.Add( "Param", "Parameter" );
            _acronyms.Add( "Params", "Parameters" );
            _acronyms.Add( "Pblctn", "Publication" );
            _acronyms.Add( "Pct", "Percent" );
            _acronyms.Add( "Pctg", "Percentage" );
            _acronyms.Add( "Pdct", "Product" );
            _acronyms.Add( "Pdg", "Pending" );
            _acronyms.Add( "Peg", "Peg" );
            _acronyms.Add( "Per", "Per" );
            _acronyms.Add( "Pg", "Page" );
            _acronyms.Add( "Pggd", "Pegged" );
            _acronyms.Add( "Pgntn", "Pagination" );
            _acronyms.Add( "Phne", "Phone" );
            _acronyms.Add( "Phys", "Physical" );
            _acronyms.Add( "Plan", "Plan" );
            _acronyms.Add( "Plc", "Place" );
            _acronyms.Add( "Plcy", "Policy" );
            _acronyms.Add( "Pls", "Pools" );
            _acronyms.Add( "Plus", "Plus" );
            _acronyms.Add( "Pmry", "Primary" );
            _acronyms.Add( "Pmt", "Payment" );
            _acronyms.Add( "Pmts", "Payments" );
            _acronyms.Add( "Png", "Paying" );
            _acronyms.Add( "Pnlty", "Penalty" );
            _acronyms.Add( "Pool", "Pool" );
            _acronyms.Add( "Poolg", "Pooling" );
            _acronyms.Add( "Port", "Port" );
            _acronyms.Add( "Pos", "Position" );
            _acronyms.Add( "Prcg", "Processing" );
            _acronyms.Add( "Prcsn", "Precision" );
            _acronyms.Add( "Prd", "Period" );
            _acronyms.Add( "Prdfnd", "Predefined" );
            _acronyms.Add( "Prds", "Periods" );
            _acronyms.Add( "Pre", "Pre" );
            _acronyms.Add( "Pref", "Preference" );
            _acronyms.Add( "Premium", "Premium" );
            _acronyms.Add( "Prevsly", "Previously" );
            _acronyms.Add( "Prft", "Profit" );
            _acronyms.Add( "Prfx", "Prefix" );
            _acronyms.Add( "Prgrs", "Progress" );
            _acronyms.Add( "Pric", "Price" );
            _acronyms.Add( "Prm", "Premium" );
            _acronyms.Add( "Propsd", "Proposed" );
            _acronyms.Add( "Prpsl", "Proposal" );
            _acronyms.Add( "Prsn", "Person" );
            _acronyms.Add( "Prssgnd", "Preassigned" );
            _acronyms.Add( "Prt", "Print" );
            _acronyms.Add( "Prtcn", "Protection" );
            _acronyms.Add( "Prtcptn", "Participation" );
            _acronyms.Add( "Prtfl", "Portfolio" );
            _acronyms.Add( "Prtisd", "Prioritised" );
            _acronyms.Add( "Prtl", "Partial" );
            _acronyms.Add( "Prtly", "Partially" );
            _acronyms.Add( "Prtry", "Proprietary" );
            _acronyms.Add( "Prty", "Priority" );
            _acronyms.Add( "Prvc", "Province" );
            _acronyms.Add( "Prvs", "Previous" );
            _acronyms.Add( "Prvt", "Private" );
            _acronyms.Add( "Prxy", "Proxy" );
            _acronyms.Add( "Pspt", "Passport" );
            _acronyms.Add( "Pst", "Post" );
            _acronyms.Add( "Pstl", "Postal" );
            _acronyms.Add( "Ptcp", "Participate" );
            _acronyms.Add( "Ptcpt", "Participant" );
            _acronyms.Add( "Pth", "Path" );
            _acronyms.Add( "Pties", "Parties" );
            _acronyms.Add( "Pts", "Points" );
            _acronyms.Add( "Pty", "Party" );
            _acronyms.Add( "Purchs", "Purchase" );
            _acronyms.Add( "Purp", "Purpose" );
            _acronyms.Add( "Put", "Put" );
            _acronyms.Add( "Putbl", "Putable" );
            _acronyms.Add( "Pwr", "Power" );
            _acronyms.Add( "Pybl", "Payable" );
            _acronyms.Add( "Pyee", "Payee" );
            _acronyms.Add( "Q", "Queue" );
            _acronyms.Add( "Qlfd", "Qualified" );
            _acronyms.Add( "Qlfr", "Qualifier" );
            _acronyms.Add( "Qlty", "Quality" );
            _acronyms.Add( "Qrm", "Quorum" );
            _acronyms.Add( "Qry", "Query" );
            _acronyms.Add( "Qt", "Quote" );
            _acronyms.Add( "Qtd", "Quoted" );
            _acronyms.Add( "Qte", "Quote" );
            _acronyms.Add( "Qtee", "Quotee" );
            _acronyms.Add( "Qtg", "Quoting" );
            _acronyms.Add( "Qtn", "Quotation" );
            _acronyms.Add( "Qty", "Quantity" );
            _acronyms.Add( "Rail", "Rail" );
            _acronyms.Add( "Rate", "Rate" );
            _acronyms.Add( "Ratg", "Rating" );
            _acronyms.Add( "Ratio", "Ratio" );
            _acronyms.Add( "Rcmmndtn", "Recommendation" );
            _acronyms.Add( "Rcnfrm", "Reconfirm" );
            _acronyms.Add( "Rcpt", "Recipient" );
            _acronyms.Add( "Rcrd", "Record" );
            _acronyms.Add( "Rct", "Receipt" );
            _acronyms.Add( "Rcvg", "Receiving" );
            _acronyms.Add( "Rcvr", "Receiver" );
            _acronyms.Add( "Rcvrs", "Receivers" );
            _acronyms.Add( "Rdc", "Reduce" );
            _acronyms.Add( "Real", "Real" );
            _acronyms.Add( "Red", "Redemption" );
            _acronyms.Add( "Ref", "Reference" );
            _acronyms.Add( "Reference", "Reference" );
            _acronyms.Add( "Regd", "Registered" );
            _acronyms.Add( "Regn", "Registration" );
            _acronyms.Add( "Regy", "Registry" );
            _acronyms.Add( "Reop", "Reopen" );
            _acronyms.Add( "Req", "Request" );
            _acronyms.Add( "Reqd", "Requested" );
            _acronyms.Add( "Reqrd", "Required" );
            _acronyms.Add( "Request", "Request" );
            _acronyms.Add( "Res", "Residence" );
            _acronyms.Add( "Resdtl", "Residential" );
            _acronyms.Add( "Rfnd", "Refund" );
            _acronyms.Add( "Rfrd", "Referred" );
            _acronyms.Add( "Rg", "Range" );
            _acronyms.Add( "Rght", "Right" );
            _acronyms.Add( "Rghts", "Rights" );
            _acronyms.Add( "Rgltr", "Regulator" );
            _acronyms.Add( "Rgltry", "Regulatory" );
            _acronyms.Add( "Rgn", "Region" );
            _acronyms.Add( "Rgnl", "Regional" );
            _acronyms.Add( "Rjctd", "Rejected" );
            _acronyms.Add( "Rjctg", "Rejecting" );
            _acronyms.Add( "Rjctn", "Rejection" );
            _acronyms.Add( "Rltd", "Related" );
            _acronyms.Add( "Rltv", "Relative" );
            _acronyms.Add( "Rmbrsmnt", "Reimbursement" );
            _acronyms.Add( "Rmng", "Remaining" );
            _acronyms.Add( "Rmt", "Remittance" );
            _acronyms.Add( "Rmtd", "Remitted" );
            _acronyms.Add( "Rndg", "Rounding" );
            _acronyms.Add( "Road", "Road" );
            _acronyms.Add( "Role", "Role" );
            _acronyms.Add( "Rp", "Repurchase" );
            _acronyms.Add( "Rpr", "Repair" );
            _acronyms.Add( "Rprd", "Repaired" );
            _acronyms.Add( "Rpt", "Report" );
            _acronyms.Add( "Rptd", "Reported" );
            _acronyms.Add( "Rptg", "Reporting" );
            _acronyms.Add( "Rqrmnt", "Requirement" );
            _acronyms.Add( "Rqrmnts", "Requirements" );
            _acronyms.Add( "Rregn", "Reregistration" );
            _acronyms.Add( "Rsk", "Risk" );
            _acronyms.Add( "Rslt", "Result" );
            _acronyms.Add( "Rsltg", "Resulting" );
            _acronyms.Add( "Rsltn", "Resolution" );
            _acronyms.Add( "Rsn", "Reason" );
            _acronyms.Add( "Rspn", "Response" );
            _acronyms.Add( "Rst", "Reset" );
            _acronyms.Add( "Rstrctns", "Restrictions" );
            _acronyms.Add( "Rsvatn", "Reservation" );
            _acronyms.Add( "Rtg", "Routing" );
            _acronyms.Add( "Rtr", "Return" );
            _acronyms.Add( "Rtrd", "Returned" );
            _acronyms.Add( "Rule", "Rule" );
            _acronyms.Add( "Rvsd", "Reversed" );
            _acronyms.Add( "Rvsl", "Reversal" );
            _acronyms.Add( "Sbcbr", "Subscriber" );
            _acronyms.Add( "Sbcpt", "Subscription" );
            _acronyms.Add( "Sbjt", "Subject" );
            _acronyms.Add( "Scale", "Scale" );
            _acronyms.Add( "Sch", "Search" );
            _acronyms.Add( "Schdld", "Scheduled" );
            _acronyms.Add( "Schme", "Scheme" );
            _acronyms.Add( "Scl", "Social" );
            _acronyms.Add( "Scnd", "Second" );
            _acronyms.Add( "Scndry", "Secondary" );
            _acronyms.Add( "Scp", "Scope" );
            _acronyms.Add( "Scties", "Securities" );
            _acronyms.Add( "Sctr", "Sector" );
            _acronyms.Add( "Scty", "Security" );
            _acronyms.Add( "Sd", "Side" );
            _acronyms.Add( "Sea", "Sea" );
            _acronyms.Add( "Selctn", "Selection" );
            _acronyms.Add( "Sell", "Sell" );
            _acronyms.Add( "Sellr", "Seller" );
            _acronyms.Add( "Seq", "Sequence" );
            _acronyms.Add( "Set", "Set" );
            _acronyms.Add( "Sfkpg", "Safekeeping" );
            _acronyms.Add( "Sfx", "Suffix" );
            _acronyms.Add( "Sgn", "Sign" );
            _acronyms.Add( "Sgntr", "Signature" );
            _acronyms.Add( "Sgntries", "Signatories" );
            _acronyms.Add( "Sgntry", "Signatory" );
            _acronyms.Add( "Ship", "Ship" );
            _acronyms.Add( "Shipmnt", "Shipment" );
            _acronyms.Add( "Show", "Show" );
            _acronyms.Add( "Shr", "Share" );
            _acronyms.Add( "Shrg", "Sharing" );
            _acronyms.Add( "Shrs", "Shares" );
            _acronyms.Add( "Shrt", "Short" );
            _acronyms.Add( "Slctd", "Solicited" );
            _acronyms.Add( "Smpl", "Simple" );
            _acronyms.Add( "Snd", "Send" );
            _acronyms.Add( "Sndr", "Sender" );
            _acronyms.Add( "Sngl", "Single" );
            _acronyms.Add( "Snt", "Sent" );
            _acronyms.Add( "Spc", "Specie" );
            _acronyms.Add( "Spcfc", "Specific" );
            _acronyms.Add( "Spd", "Speed" );
            _acronyms.Add( "Splmtry", "Supplementary" );
            _acronyms.Add( "Splt", "Split" );
            _acronyms.Add( "Spprt", "Support" );
            _acronyms.Add( "Sprd", "Spread" );
            _acronyms.Add( "Src", "Source" );
            _acronyms.Add( "Srcr", "Servicer" );
            _acronyms.Add( "Srtg", "Sorting" );
            _acronyms.Add( "Ssn", "Session" );
            _acronyms.Add( "Sspd", "Suspended" );
            _acronyms.Add( "Start", "Start" );
            _acronyms.Add( "Stay", "Stay" );
            _acronyms.Add( "Stg", "Standing" );
            _acronyms.Add( "Stmp", "Stamp" );
            _acronyms.Add( "Stmt", "Statement" );
            _acronyms.Add( "Stock", "Stock" );
            _acronyms.Add( "Stop", "Stop" );
            _acronyms.Add( "Strd", "Structured" );
            _acronyms.Add( "Strk", "Strike" );
            _acronyms.Add( "Strks", "Strikes" );
            _acronyms.Add( "Strt", "Street" );
            _acronyms.Add( "Strtgy", "Strategy" );
            _acronyms.Add( "Sts", "Status" );
            _acronyms.Add( "Sttld", "Settled" );
            _acronyms.Add( "Sttlm", "Settlement" );
            _acronyms.Add( "Sttstcs", "Statistics" );
            _acronyms.Add( "Style", "Style" );
            _acronyms.Add( "Sub", "Sub" );
            _acronyms.Add( "Submissn", "Submission" );
            _acronyms.Add( "Submitg", "Submitting" );
            _acronyms.Add( "Submitr", "Submitter" );
            _acronyms.Add( "Submittd", "Submitted" );
            _acronyms.Add( "Sucssr", "Successor" );
            _acronyms.Add( "Sum", "Sum" );
            _acronyms.Add( "Summry", "Summary" );
            _acronyms.Add( "Svc", "Service" );
            _acronyms.Add( "Svcr", "Servicer" );
            _acronyms.Add( "Svgs", "Savings" );
            _acronyms.Add( "Swp", "Swap" );
            _acronyms.Add( "Swtch", "Switch" );
            _acronyms.Add( "Symb", "Symbol" );
            _acronyms.Add( "Sys", "System" );
            _acronyms.Add( "Sz", "Size" );
            _acronyms.Add( "Take", "Take" );
            _acronyms.Add( "Takng", "Taking" );
            _acronyms.Add( "Tax", "Tax" );
            _acronyms.Add( "Taxbl", "Taxable" );
            _acronyms.Add( "Taxs", "Taxes" );
            _acronyms.Add( "Taxtn", "Taxation" );
            _acronyms.Add( "Tckr", "Ticker" );
            _acronyms.Add( "Tckts", "Tickets" );
            _acronyms.Add( "Tel", "Telephone" );
            _acronyms.Add( "Terms", "Terms" );
            _acronyms.Add( "The", "The" );
            _acronyms.Add( "Thrd", "Third" );
            _acronyms.Add( "Three", "Three" );
            _acronyms.Add( "Thrgh", "Through" );
            _acronyms.Add( "Thrshld", "Threshold" );
            _acronyms.Add( "Till", "Till" );
            _acronyms.Add( "Tlrnce", "Tolerance" );
            _acronyms.Add( "Tlx", "Telex" );
            _acronyms.Add( "Tm", "Time" );
            _acronyms.Add( "To", "To" );
            _acronyms.Add( "Tp", "Type" );
            _acronyms.Add( "Trad", "Trade" );
            _acronyms.Add( "Tradd", "Traded" );
            _acronyms.Add( "Tradg", "Trading" );
            _acronyms.Add( "Tradr", "Trader" );
            _acronyms.Add( "Trch", "Tranche" );
            _acronyms.Add( "Trf", "Transfer" );
            _acronyms.Add( "Trfd", "Transferred" );
            _acronyms.Add( "Trgt", "Target" );
            _acronyms.Add( "Trlr", "Trailer" );
            _acronyms.Add( "Trns", "Trans" );
            _acronyms.Add( "Trnsprt", "Transport" );
            _acronyms.Add( "Trnsprtd", "Transported" );
            _acronyms.Add( "Trnst", "Transit" );
            _acronyms.Add( "Try", "Try" );
            _acronyms.Add( "Ttl", "Total" );
            _acronyms.Add( "Twn", "Town" );
            _acronyms.Add( "Tx", "Transaction" );
            _acronyms.Add( "Txs", "Transactions" );
            _acronyms.Add( "Txtl", "Textual" );
            _acronyms.Add( "Uknwn", "Unknown" );
            _acronyms.Add( "Ultmt", "Ultimate" );
            _acronyms.Add( "Umtchd", "Unmatched" );
            _acronyms.Add( "Undrlyg", "Underlying" );
            _acronyms.Add( "Unit", "Unit" );
            _acronyms.Add( "Units", "Units" );
            _acronyms.Add( "Unq", "Unique" );
            _acronyms.Add( "Unrecognised", "Unrecognised" );
            _acronyms.Add( "Up", "Up" );
            _acronyms.Add( "Upd", "Update" );
            _acronyms.Add( "Updtd", "Updated" );
            _acronyms.Add( "Usr", "User" );
            _acronyms.Add( "Val", "Value" );
            _acronyms.Add( "Vals", "Values" );
            _acronyms.Add( "Valtn", "Valuation" );
            _acronyms.Add( "Var", "Variance" );
            _acronyms.Add( "Varbl", "Variable" );
            _acronyms.Add( "Vldty", "Validity" );
            _acronyms.Add( "Vol", "Volume" );
            _acronyms.Add( "Vote", "Vote" );
            _acronyms.Add( "Vrsn", "Version" );
            _acronyms.Add( "Vssl", "Vessel" );
            _acronyms.Add( "Vstr", "Vostro" );
            _acronyms.Add( "Vtng", "Voting" );
            _acronyms.Add( "Wav", "Wave" );
            _acronyms.Add( "Wghtd", "Weighted" );
            _acronyms.Add( "Whldg", "Withholding" );
            _acronyms.Add( "Wth", "With" );
            _acronyms.Add( "Wtht", "Without" );
            _acronyms.Add( "Wvd", "Waived" );
            _acronyms.Add( "Wvg", "Waiving" );
            _acronyms.Add( "X", "Exchange" );
            _acronyms.Add( "Xchg", "Exchange" );
            _acronyms.Add( "Xcptnl", "Exceptional" );
            _acronyms.Add( "Xmptn", "Exemption" );
            _acronyms.Add( "Xpctd", "Expected" );
            _acronyms.Add( "Xpry", "Expiry" );
            _acronyms.Add( "Xtnded", "Extended" );
            _acronyms.Add( "Xtnsn", "Extension" );
            _acronyms.Add( "Yld", "Yield" );
            _acronyms.Add( "Yr", "Year" );
            _acronyms.Add( "Yrs", "Years" );
            _acronyms.Add( "Zone", "Zone" );

        }

        #endregion


        #region Public methods

        /// <summary>
        /// Build a phrase from a word.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string BuildPhrase( string word )
        {
            if (word.StartsWith( "i20022." ))
            {
                string[] arra = word.Split( ".".ToCharArray() );
                word = arra[arra.GetUpperBound(0)];
            }

            List<string> list = Utilities.Split( word );
            
            string phrase = String.Empty;

            for (int i = 0; i < list.Count; i++)
            {
                string acronym = list[i];

                if (acronym.Length == 1)
                {
                    phrase += acronym;
                }
                else
                {
                    string meaning = acronym;

                    try
                    {
                        meaning = _acronyms[acronym];
                    }
                    catch { }

                    phrase += meaning + " ";
                }
            }

            return phrase.Trim();
        }

        #endregion

    }
}
