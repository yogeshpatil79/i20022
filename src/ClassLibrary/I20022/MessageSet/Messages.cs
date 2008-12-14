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
    /// Utility class that represents the set of messages.
    /// </summary>
    internal static class Messages
    {

        #region Private members

        private static Dictionary<string, Message> _messages;

        #endregion


        #region Static initializer (populates messages)

        /// <summary>
        /// Initializes the <see cref="Messages"/> class.
        /// </summary>
        static Messages()
        {
            _messages = new Dictionary<string, Message>();

            _messages.Add("acmt.001.001.02", new Message("acmt.001.001.02", "AccountOpeningInstructionV02"));
            _messages.Add("acmt.002.001.02", new Message("acmt.002.001.02", "AccountDetailsConfirmationV02"));
            _messages.Add("acmt.003.001.02", new Message("acmt.003.001.02", "AccountModificationInstructionV02"));
            _messages.Add("acmt.005.001.02", new Message("acmt.005.001.02", "RequestForAccountManagementStatusReportV02"));
            _messages.Add("acmt.006.001.02", new Message("acmt.006.001.02", "AccountManagementStatusReportV02"));
            _messages.Add("admi.002.001.01", new Message("admi.002.001.01", "MessageRejectV01"));
            _messages.Add("admi.004.001.01", new Message("admi.004.001.01", "SystemEventNotificationV01"));
            _messages.Add("camt.007.002.01", new Message("camt.007.002.01", "RequestToModifyPayment"));
            _messages.Add("camt.008.002.01", new Message("camt.008.002.01", "RequestToCancelPayment"));
            _messages.Add("camt.026.001.01", new Message("camt.026.001.01", "UnableToApply"));
            _messages.Add("camt.027.001.01", new Message("camt.027.001.01", "ClaimNonReceipt"));
            _messages.Add("camt.028.001.01", new Message("camt.028.001.01", "AdditionalPaymentInformation"));
            _messages.Add("camt.029.001.01", new Message("camt.029.001.01", "ResolutionOfInvestigation"));
            _messages.Add("camt.030.001.01", new Message("camt.030.001.01", "NotificationOfCaseAssignment"));
            _messages.Add("camt.031.001.01", new Message("camt.031.001.01", "RejectCaseAssignment"));
            _messages.Add("camt.032.001.01", new Message("camt.032.001.01", "CancelCaseAssignment"));
            _messages.Add("camt.033.001.01", new Message("camt.033.001.01", "RequestForDuplicateInstruction"));
            _messages.Add("camt.036.001.01", new Message("camt.036.001.01", "DebitAuthorisationResponse"));
            _messages.Add("camt.037.001.01", new Message("camt.037.001.01", "DebitAuthorisationRequest"));
            _messages.Add("camt.038.001.01", new Message("camt.038.001.01", "CaseStatusReportRequest"));
            _messages.Add("camt.039.001.01", new Message("camt.039.001.01", "CaseStatusReport"));
            _messages.Add("camt.040.001.03", new Message("camt.040.001.03", "FundEstimatedCashForecastReportV03"));
            _messages.Add("camt.041.001.03", new Message("camt.041.001.03", "FundConfirmedCashForecastReportV03"));
            _messages.Add("camt.042.001.03", new Message("camt.042.001.03", "FundDetailedEstimatedCashForecastReportV03"));
            _messages.Add("camt.043.001.03", new Message("camt.043.001.03", "FundDetailedConfirmedCashForecastReportV03"));
            _messages.Add("camt.044.001.02", new Message("camt.044.001.02", "FundConfirmedCashForecastReportCancellationV02"));
            _messages.Add("camt.045.001.02", new Message("camt.045.001.02", "FundDetailedConfirmedCashForecastReportCancellationV02"));
            _messages.Add("camt.052.001.01", new Message("camt.052.001.01", "BankToCustomerAccountReportV01"));
            _messages.Add("camt.053.001.01", new Message("camt.053.001.01", "BankToCustomerStatementV01"));
            _messages.Add("camt.054.001.01", new Message("camt.054.001.01", "BankToCustomerDebitCreditNotificationV01"));
            _messages.Add("pacs.002.001.02", new Message("pacs.002.001.02", "PaymentStatusReportV02"));
            _messages.Add("pacs.003.001.01", new Message("pacs.003.001.01", "FIToFICustomerDirectDebitV01"));
            _messages.Add("pacs.004.001.01", new Message("pacs.004.001.01", "PaymentReturnV01"));
            _messages.Add("pacs.006.001.01", new Message("pacs.006.001.01", "PaymentCancellationRequestV01"));
            _messages.Add("pacs.007.001.01", new Message("pacs.007.001.01", "FIToFIPaymentReversalV01"));
            _messages.Add("pacs.008.001.01", new Message("pacs.008.001.01", "FIToFICustomerCreditTransferV01"));
            _messages.Add("pacs.009.001.01", new Message("pacs.009.001.01", "FinancialInstitutionCreditTransferV01"));
            _messages.Add("pain.001.001.02", new Message("pain.001.001.02", "CustomerCreditTransferInitiationV02"));
            _messages.Add("pain.002.001.02", new Message("pain.002.001.02", "PaymentStatusReportV02"));
            _messages.Add("pain.006.001.01", new Message("pain.006.001.01", "PaymentCancellationRequestV01"));
            _messages.Add("pain.007.001.01", new Message("pain.007.001.01", "CustomerPaymentReversalV01"));
            _messages.Add("pain.008.001.01", new Message("pain.008.001.01", "CustomerDirectDebitInitiationV01"));
            _messages.Add("reda.001.001.03", new Message("reda.001.001.03", "PriceReportV03"));
            _messages.Add("reda.002.001.03", new Message("reda.002.001.03", "PriceReportCancellationV03"));
            _messages.Add("reda.003.001.03", new Message("reda.003.001.03", "PriceReportCorrectionV03"));
            _messages.Add("seev.001.001.02", new Message("seev.001.001.02", "MeetingNotificationV02"));
            _messages.Add("seev.002.001.02", new Message("seev.002.001.02", "MeetingCancellationV02"));
            _messages.Add("seev.003.001.02", new Message("seev.003.001.02", "MeetingEntitlementNotificationV02"));
            _messages.Add("seev.004.001.02", new Message("seev.004.001.02", "MeetingInstructionV02"));
            _messages.Add("seev.005.001.02", new Message("seev.005.001.02", "MeetingInstructionCancellationRequestV02"));
            _messages.Add("seev.006.001.02", new Message("seev.006.001.02", "MeetingInstructionStatusV02"));
            _messages.Add("seev.007.001.02", new Message("seev.007.001.02", "MeetingVoteExecutionConfirmationV02"));
            _messages.Add("seev.008.001.02", new Message("seev.008.001.02", "MeetingResultDisseminationV02"));
            _messages.Add("semt.001.001.02", new Message("semt.001.001.02", "SecuritiesMessageRejectionV02"));
            _messages.Add("semt.002.001.02", new Message("semt.002.001.02", "CustodyStatementOfHoldingsV02"));
            _messages.Add("semt.003.001.02", new Message("semt.003.001.02", "AccountingStatementOfHoldingsV02"));
            _messages.Add("semt.004.001.02", new Message("semt.004.001.02", "CustodyStatementOfHoldingsCancellationV02"));
            _messages.Add("semt.005.001.02", new Message("semt.005.001.02", "AccountingStatementOfHoldingsCancellationV02"));
            _messages.Add("semt.006.001.02", new Message("semt.006.001.02", "StatementOfInvestmentFundTransactionsV02"));
            _messages.Add("semt.007.001.02", new Message("semt.007.001.02", "StatementOfInvestmentFundTransactionsCancellationV02"));
            _messages.Add("semt.008.001.02", new Message("semt.008.001.02", "RegulatoryTransactionReportV02"));
            _messages.Add("semt.009.001.02", new Message("semt.009.001.02", "RegulatoryTransactionReportCancellationRequestV02"));
            _messages.Add("semt.010.001.01", new Message("semt.010.001.01", "RegulatoryTransactionReportStatusV01"));
            _messages.Add("semt.011.001.01", new Message("semt.011.001.01", "RegulatoryTransactionReportCancellationStatusV01"));
            _messages.Add("sese.001.001.02", new Message("sese.001.001.02", "TransferOutInstructionV02"));
            _messages.Add("sese.002.001.02", new Message("sese.002.001.02", "TransferOutCancellationRequestV02"));
            _messages.Add("sese.003.001.02", new Message("sese.003.001.02", "TransferOutConfirmationV02"));
            _messages.Add("sese.004.001.02", new Message("sese.004.001.02", "ReversalOfTransferOutConfirmationV02"));
            _messages.Add("sese.005.001.02", new Message("sese.005.001.02", "TransferInInstructionV02"));
            _messages.Add("sese.006.001.02", new Message("sese.006.001.02", "TransferInCancellationRequestV02"));
            _messages.Add("sese.007.001.02", new Message("sese.007.001.02", "TransferInConfirmationV02"));
            _messages.Add("sese.008.001.02", new Message("sese.008.001.02", "ReversalOfTransferInConfirmationV02"));
            _messages.Add("sese.009.001.02", new Message("sese.009.001.02", "RequestForTransferStatusReportV02"));
            _messages.Add("sese.010.001.02", new Message("sese.010.001.02", "TransferCancellationStatusReportV02"));
            _messages.Add("sese.011.001.02", new Message("sese.011.001.02", "TransferInstructionStatusReportV02"));
            _messages.Add("sese.012.001.02", new Message("sese.012.001.02", "PEPOrISAOrPortfolioTransferInstructionV02"));
            _messages.Add("sese.013.001.02", new Message("sese.013.001.02", "PEPOrISAOrPortfolioTransferConfirmationV02"));
            _messages.Add("sese.014.001.02", new Message("sese.014.001.02", "PEPOrISAOrPortfolioTransferCancellationRequestV02"));
            _messages.Add("sese.018.001.01", new Message("sese.018.001.01", "PEPOrISAOrPortfolioInformationV01"));
            _messages.Add("sese.019.001.01", new Message("sese.019.001.01", "RequestForPEPOrISAOrPortfolioInformationV01"));
            _messages.Add("setr.001.001.03", new Message("setr.001.001.03", "RedemptionBulkOrderV03"));
            _messages.Add("setr.002.001.03", new Message("setr.002.001.03", "RedemptionBulkOrderCancellationRequestV03"));
            _messages.Add("setr.003.001.03", new Message("setr.003.001.03", "RedemptionBulkOrderConfirmationV03"));
            _messages.Add("setr.004.001.03", new Message("setr.004.001.03", "RedemptionOrderV03"));
            _messages.Add("setr.005.001.03", new Message("setr.005.001.03", "RedemptionOrderCancellationRequestV03"));
            _messages.Add("setr.006.001.03", new Message("setr.006.001.03", "RedemptionOrderConfirmationV03"));
            _messages.Add("setr.007.001.03", new Message("setr.007.001.03", "SubscriptionBulkOrderV03"));
            _messages.Add("setr.008.001.03", new Message("setr.008.001.03", "SubscriptionBulkOrderCancellationRequestV03"));
            _messages.Add("setr.009.001.03", new Message("setr.009.001.03", "SubscriptionBulkOrderConfirmationV03"));
            _messages.Add("setr.010.001.03", new Message("setr.010.001.03", "SubscriptionOrderV03"));
            _messages.Add("setr.011.001.03", new Message("setr.011.001.03", "SubscriptionOrderCancellationRequestV03"));
            _messages.Add("setr.012.001.03", new Message("setr.012.001.03", "SubscriptionOrderConfirmationV03"));
            _messages.Add("setr.013.001.03", new Message("setr.013.001.03", "SwitchOrderV03"));
            _messages.Add("setr.014.001.03", new Message("setr.014.001.03", "SwitchOrderCancellationRequestV03"));
            _messages.Add("setr.015.001.03", new Message("setr.015.001.03", "SwitchOrderConfirmationV03"));
            _messages.Add("setr.016.001.03", new Message("setr.016.001.03", "OrderInstructionStatusReportV03"));
            _messages.Add("setr.017.001.03", new Message("setr.017.001.03", "OrderCancellationStatusReportV03"));
            _messages.Add("setr.018.001.03", new Message("setr.018.001.03", "RequestForOrderStatusReportV03"));
            _messages.Add("setr.047.001.01", new Message("setr.047.001.01", "SubscriptionOrderConfirmationCancellationInstructionV01"));
            _messages.Add("setr.048.001.01", new Message("setr.048.001.01", "SubscriptionOrderConfirmationAmendmentV01"));
            _messages.Add("setr.049.001.01", new Message("setr.049.001.01", "SubscriptionBulkOrderConfirmationCancellationInstructionV01"));
            _messages.Add("setr.050.001.01", new Message("setr.050.001.01", "SubscriptionBulkOrderConfirmationAmendmentV01"));
            _messages.Add("setr.051.001.01", new Message("setr.051.001.01", "RedemptionOrderConfirmationCancellationInstructionV01"));
            _messages.Add("setr.052.001.01", new Message("setr.052.001.01", "RedemptionOrderConfirmationAmendmentV01"));
            _messages.Add("setr.053.001.01", new Message("setr.053.001.01", "RedemptionBulkOrderConfirmationCancellationInstructionV01"));
            _messages.Add("setr.054.001.01", new Message("setr.054.001.01", "RedemptionBulkOrderConfirmationAmendmentV01"));
            _messages.Add("setr.055.001.01", new Message("setr.055.001.01", "SwitchOrderConfirmationCancellationInstructionV01"));
            _messages.Add("setr.056.001.01", new Message("setr.056.001.01", "SwitchOrderConfirmationAmendmentV01"));
            _messages.Add("setr.057.001.01", new Message("setr.057.001.01", "OrderConfirmationStatusReportV01"));
            _messages.Add("setr.058.001.01", new Message("setr.058.001.01", "RequestForOrderConfirmationStatusReportV01"));
            _messages.Add("trea.001.001.02", new Message("trea.001.001.02", "CreateNonDeliverableForwardOpeningV02"));
            _messages.Add("trea.002.001.02", new Message("trea.002.001.02", "AmendNonDeliverableForwardOpeningV02"));
            _messages.Add("trea.003.001.02", new Message("trea.003.001.02", "CancelNonDeliverableForwardOpeningV02"));
            _messages.Add("trea.004.001.02", new Message("trea.004.001.02", "CreateNonDeliverableForwardValuationV02"));
            _messages.Add("trea.005.001.02", new Message("trea.005.001.02", "AmendNonDeliverableForwardValuationV02"));
            _messages.Add("trea.006.001.02", new Message("trea.006.001.02", "CancelNonDeliverableForwardValuationV02"));
            _messages.Add("trea.007.001.02", new Message("trea.007.001.02", "NonDeliverableForwardNotificationV02"));
            _messages.Add("trea.008.001.02", new Message("trea.008.001.02", "StatusNotificationV02"));
            _messages.Add("trea.009.001.02", new Message("trea.009.001.02", "CreateForeignExchangeOptionV02"));
            _messages.Add("trea.010.001.02", new Message("trea.010.001.02", "AmendForeignExchangeOptionV02"));
            _messages.Add("trea.011.001.02", new Message("trea.011.001.02", "CancelForeignExchangeOptionV02"));
            _messages.Add("trea.012.001.02", new Message("trea.012.001.02", "ForeignExchangeOptionNotificationV02"));
            _messages.Add("trea.013.001.01", new Message("trea.013.001.01", "WithdrawalNotificationV01"));
            _messages.Add("tsin.001.001.01", new Message("tsin.001.001.01", "InvoiceFinancingRequestV01"));
            _messages.Add("tsin.002.001.01", new Message("tsin.002.001.01", "InvoiceFinancingRequestStatusV01"));
            _messages.Add("tsin.003.001.01", new Message("tsin.003.001.01", "InvoiceFinancingCancellationRequestV01"));
            _messages.Add("tsmt.001.001.03", new Message("tsmt.001.001.03", "AcknowledgementV03"));
            _messages.Add("tsmt.002.001.03", new Message("tsmt.002.001.03", "ActivityReportV03"));
            _messages.Add("tsmt.003.001.03", new Message("tsmt.003.001.03", "ActivityReportRequestV03"));
            _messages.Add("tsmt.004.001.02", new Message("tsmt.004.001.02", "ActivityReportSetUpRequestV02"));
            _messages.Add("tsmt.005.001.02", new Message("tsmt.005.001.02", "AmendmentAcceptanceV02"));
            _messages.Add("tsmt.006.001.03", new Message("tsmt.006.001.03", "AmendmentAcceptanceNotificationV03"));
            _messages.Add("tsmt.007.001.02", new Message("tsmt.007.001.02", "AmendmentRejectionV02"));
            _messages.Add("tsmt.008.001.03", new Message("tsmt.008.001.03", "AmendmentRejectionNotificationV03"));
            _messages.Add("tsmt.009.001.03", new Message("tsmt.009.001.03", "BaselineAmendmentRequestV03"));
            _messages.Add("tsmt.010.001.03", new Message("tsmt.010.001.03", "BaselineMatchReportV03"));
            _messages.Add("tsmt.011.001.03", new Message("tsmt.011.001.03", "BaselineReportV03"));
            _messages.Add("tsmt.012.001.03", new Message("tsmt.012.001.03", "BaselineReSubmissionV03"));
            _messages.Add("tsmt.013.001.03", new Message("tsmt.013.001.03", "DataSetMatchReportV03"));
            _messages.Add("tsmt.014.001.03", new Message("tsmt.014.001.03", "DataSetSubmissionV03"));
            _messages.Add("tsmt.015.001.03", new Message("tsmt.015.001.03", "DeltaReportV03"));
            _messages.Add("tsmt.016.001.03", new Message("tsmt.016.001.03", "ErrorReportV03"));
            _messages.Add("tsmt.017.001.03", new Message("tsmt.017.001.03", "ForwardDataSetSubmissionReportV03"));
            _messages.Add("tsmt.018.001.03", new Message("tsmt.018.001.03", "FullPushThroughReportV03"));
            _messages.Add("tsmt.019.001.03", new Message("tsmt.019.001.03", "InitialBaselineSubmissionV03"));
            _messages.Add("tsmt.020.001.02", new Message("tsmt.020.001.02", "MisMatchAcceptanceV02"));
            _messages.Add("tsmt.021.001.03", new Message("tsmt.021.001.03", "MisMatchAcceptanceNotificationV03"));
            _messages.Add("tsmt.022.001.02", new Message("tsmt.022.001.02", "MisMatchRejectionV02"));
            _messages.Add("tsmt.023.001.03", new Message("tsmt.023.001.03", "MisMatchRejectionNotificationV03"));
            _messages.Add("tsmt.024.001.03", new Message("tsmt.024.001.03", "ActionReminderV03"));
            _messages.Add("tsmt.025.001.03", new Message("tsmt.025.001.03", "StatusChangeNotificationV03"));
            _messages.Add("tsmt.026.001.02", new Message("tsmt.026.001.02", "StatusChangeRequestV02"));
            _messages.Add("tsmt.027.001.02", new Message("tsmt.027.001.02", "StatusChangeRequestAcceptanceV02"));
            _messages.Add("tsmt.028.001.03", new Message("tsmt.028.001.03", "StatusChangeRequestNotificationV03"));
            _messages.Add("tsmt.029.001.02", new Message("tsmt.029.001.02", "StatusChangeRequestRejectionV02"));
            _messages.Add("tsmt.030.001.03", new Message("tsmt.030.001.03", "StatusChangeRequestRejectionNotificationV03"));
            _messages.Add("tsmt.031.001.03", new Message("tsmt.031.001.03", "StatusExtensionRequestAcceptanceV03"));
            _messages.Add("tsmt.032.001.03", new Message("tsmt.032.001.03", "StatusExtensionNotificationV03"));
            _messages.Add("tsmt.033.001.03", new Message("tsmt.033.001.03", "StatusExtensionRequestRejectionV03"));
            _messages.Add("tsmt.034.001.03", new Message("tsmt.034.001.03", "StatusExtensionRejectionNotificationV03"));
            _messages.Add("tsmt.035.001.03", new Message("tsmt.035.001.03", "StatusExtensionRequestV03"));
            _messages.Add("tsmt.036.001.03", new Message("tsmt.036.001.03", "StatusExtensionRequestNotificationV03"));
            _messages.Add("tsmt.037.001.03", new Message("tsmt.037.001.03", "StatusReportV03"));
            _messages.Add("tsmt.038.001.03", new Message("tsmt.038.001.03", "StatusReportRequestV03"));
            _messages.Add("tsmt.040.001.03", new Message("tsmt.040.001.03", "TimeOutNotificationV03"));
            _messages.Add("tsmt.041.001.03", new Message("tsmt.041.001.03", "TransactionReportV03"));
            _messages.Add("tsmt.042.001.03", new Message("tsmt.042.001.03", "TransactionReportRequestV03"));
            _messages.Add("tsmt.044.001.01", new Message("tsmt.044.001.01", "IntentToPayNotificationV01"));
            _messages.Add("tsmt.045.001.01", new Message("tsmt.045.001.01", "ForwardIntentToPayNotificationV01"));
            _messages.Add("tsmt.046.001.01", new Message("tsmt.046.001.01", "IntentToPayReportV01"));
            _messages.Add("tsmt.047.001.01", new Message("tsmt.047.001.01", "SpecialRequestV01"));
            _messages.Add("tsmt.048.001.01", new Message("tsmt.048.001.01", "SpecialNotificationV01"));
            _messages.Add("tsmt.049.001.01", new Message("tsmt.049.001.01", "RoleAndBaselineAcceptanceV01"));
            _messages.Add("tsmt.050.001.01", new Message("tsmt.050.001.01", "RoleAndBaselineRejectionV01"));
            _messages.Add("tsmt.051.001.01", new Message("tsmt.051.001.01", "RoleAndBaselineAcceptanceNotificationV01"));
            _messages.Add("tsmt.052.001.01", new Message("tsmt.052.001.01", "RoleAndBaselineRejectionNotificationV01"));


        }

        #endregion


        /// <summary>
        /// Gets a message object given its name.
        /// </summary>
        /// <param name="messageName">Name of the message.</param>
        /// <returns></returns>
        public static Message GetMessage(string messageName)
        {
            Message.VerifyMessageName(messageName);
            Message message = null;

            try
            {
                message = _messages[messageName];
            }
            catch (System.Exception)
            {
            }

            if (null == message)
            {
                throw new InvalidOperationException(String.Format("Error: there is no message {0} defined on the i20022 library!", messageName));
            }
            else
            {
                return message;
            }
        }


        /// <summary>
        /// Infers the type of the message.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static string InferMessageType(object instance)
        {
            // 0123456789012345678
            // i20022.acmt00100102
            //        012345678901 
            string nspace = instance.GetType().Namespace.Substring(7);

            return String.Format("{0}.{1}.{2}.{3}", nspace.Substring(0, 4), nspace.Substring(4, 3), nspace.Substring(7, 3), nspace.Substring(10, 2));
        }

    }
}
