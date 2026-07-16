using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace LogicLayer
{
    public class clsInputValidator 
    {
        
        private static bool CheckTextBoxesInputs(string txt)
        {
            return (string.IsNullOrEmpty(txt));
        }

        public delegate bool delMatch(string word, string pattren);
        public static bool IsPhoneInputNotCorrect(string Phone) => Regex.IsMatch(Phone, @"^0[5-7]\d{8}$") == false;

        public static bool IsPatrrenCorrect(string word, string pattren) => Regex.IsMatch(word, pattren);

        public static bool IsColumnNameContainsID(string ColumnName) => Regex.IsMatch(ColumnName, "\\b\\w*ID\\w*\\b");

        public static bool IsColumnNameContainsDate(string ColumnName) => Regex.IsMatch(ColumnName, "\\b\\w*Date\\w*\\b");

        public static bool IsDateValid(string Date) => Regex.IsMatch(Date, @"^\d{1,2}/\d{1,2}/\d{4}$");

        public static bool IsPDF_FileNameNotValid(string FileName)
        {
            return Regex.IsMatch(FileName, @"^(.+?)(\\.pdf)?$") == false;
        }
        public static bool IsXML_FileNameNotValid(string FileName)
        {
            return Regex.IsMatch(FileName, @"^(.+?)(\\.xml)?$") == false;
        }

        public static bool IsJSON_FileNameNotValid(string FileName)
        {
            return Regex.IsMatch(FileName, @"^(.+?)(\\.json)?$") == false;
        }

        public static bool IsNameNotValid(string name)
        {
            // Pattern: Only letters, spaces, hyphens, and apostrophes, min 2 chars, max 50 chars
            
            return Regex.IsMatch(name, @"^[a-zA-Z\s\-']{2,20}$") == false;
        }

        private static bool IsPinValid(string pin)
        {
            // Pattern: ^\d{3}$ means exactly 3 digits
            string pattern = @"^\d{3}$";
            return Regex.IsMatch(pin, pattern);
        }

        // Check if PIN is NOT correct
        public static bool IsPinNotCorrect(string pin)
        {
            return !IsPinValid(pin);
        }

        private static bool IsUsernameValid(string username)
        {
 
            string pattern = @"^@[a-zA-Z0-9_]{3,20}$";
            return Regex.IsMatch(username, pattern);
        }

        // Check if username is NOT correct
        public static bool IsUsernameNotCorrect(string username)
        {
            return !IsUsernameValid(username);
        }
        private static bool IsEmailValid(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public static bool IsEmailNotValid(string email) => IsEmailValid(email) == false;
        public static bool CheckInputs(delMatch CheckingFunction, string username , string Password , string RegexPattren = @"^@\S+$")
        {
            if (CheckTextBoxesInputs(username) || CheckTextBoxesInputs(Password)|| CheckingFunction(username, RegexPattren) == false)
            {
                return false;
            }

            return true;
        }

        public static bool IsTitle_Not_Valid(string Title) => !Regex.IsMatch(Title, @"^[a-zA-Z0-9\s]+$");
        public static bool IsISBN_Not_Valid(string Input) => !Regex.IsMatch(Input, @"^\d{3}-\d{1}-\d{3}-\d{5}-\d{1}$");
        public static bool IsInputNotIntegerValue(string Input) => !int.TryParse(Input, out int result);
        public static bool IsInputNotDoubleValue(string Input) => !int.TryParse(Input, out int result);

        public static bool IsWeakPassword(string Password)
        {
            return !Regex.IsMatch(Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }

        public static bool IsValidGatewayCustomerId(string gatewayCustomerId) =>
        !Regex.IsMatch(gatewayCustomerId, @"^[a-zA-Z0-9_-]{5,50}$");

        public static bool IsValidPaymentMethodToken(string paymentMethodToken) =>
            !Regex.IsMatch(paymentMethodToken, @"^[a-zA-Z0-9_-]{10,100}$");

        public static bool IsValidCardType(string cardType) =>
            !Regex.IsMatch(cardType, @"^(Visa|MasterCard|American Express|Pay Pal|Amex|Apple Pay|Discover|Diners Club|JCB|UnionPay)$", RegexOptions.IgnoreCase);

        public static bool IsValidHolderName(string holderName) =>
            !Regex.IsMatch(holderName, @"^[a-zA-Z\s\-\.']{2,100}$");

        public static bool IsValidBillingPostalCode(string billingPostalCode) =>
            !Regex.IsMatch(billingPostalCode, @"^[a-zA-Z0-9\s-]{3,10}$");

        public static bool IsAmountValid(string Amount)
        {
          return  Regex.IsMatch(Amount, @"^(0|[1-9]\d*)(\.\d{1,2})?$");
        }

        public static bool IsShippingCarrierNotCorrect(string ShippingCarrier) =>
       Regex.IsMatch(ShippingCarrier, @"^(UPS|FedEx|USPS|DHL|Canada Post|Other)$") == false;

        // 3. Carrier Service Level: alphanumeric, spaces, hyphens
        public static bool IsCarrierServiceLevelNotCorrect(string CarrierServiceLevel) =>
            Regex.IsMatch(CarrierServiceLevel, @"^[A-Za-z0-9\s\-]+$") == false;

        // 4. Tracking Number: alphanumeric, 8-30 chars
        public static bool IsTrackingNumberNotCorrect(string TrackingNumber) =>
            Regex.IsMatch(TrackingNumber, @"^[A-Za-z0-9]{8,30}$") == false;

        // 5. Tracking URL: http/https URL with track? and tracknum=
        public static bool IsTrackingURLNotCorrect(string TrackingURL) =>
            Regex.IsMatch(TrackingURL, @"^https?:\/\/[\w\-\.]+\/track\?.*tracknum=.*$") == false;

        // 6. Estimated Delivery Date: YYYY-MM-DD format
        public static bool IsEstimatedDeliveryDateNotCorrect(string EstimatedDeliveryDate) =>
            Regex.IsMatch(EstimatedDeliveryDate, @"^\d{4}-\d{2}-\d{2}$") == false;

        // 7. Actual Delivery Date: YYYY-MM-DD format (can be empty)
        public static bool IsActualDeliveryDateNotCorrect(string ActualDeliveryDate) =>
            string.IsNullOrEmpty(ActualDeliveryDate) ? false : Regex.IsMatch(ActualDeliveryDate, @"^\d{4}-\d{2}-\d{2}$") == false;

        // 8. Shipping Notes: letters, numbers, spaces, common punctuation; up to 500 chars
        public static bool IsShippingNotesNotCorrect(string ShippingNotes) =>
            Regex.IsMatch(ShippingNotes, @"^[\w\s\.,!?-]{0,500}$") == false;

        // 9. Shipping Updates: similar to notes, allows colons/semicolons; up to 255 chars
        public static bool IsShippingUpdatesNotCorrect(string ShippingUpdates) =>
            Regex.IsMatch(ShippingUpdates, @"^[\w\s\.,:;-]{0,255}$") == false;

        // 10. Shipping Cost: positive number, optional 1-2 decimal places
        public static bool IsShippingCostNotCorrect(string ShippingCost) =>
            Regex.IsMatch(ShippingCost, @"^\d+(\.\d{1,2})?$") == false;

    }
}
