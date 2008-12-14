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
    /// Utility class representing the messages business areas.
    /// </summary>
    internal static class BusinessAreas
    {

        #region Private members

        private static Dictionary<string, string> _businessAreas;

        #endregion


        #region Static initializer (populates business areas dictionary)

        /// <summary>
        /// Initializes the <see cref="BusinessAreas"/> class.
        /// </summary>
        static BusinessAreas()
        {
            _businessAreas = new Dictionary<string, string>();
            _businessAreas.Add("acmt", "Account Management");
            _businessAreas.Add("admi", "Administration");
            _businessAreas.Add("camt", "Cash Management");
            _businessAreas.Add("pacs", "Payments Clearing and Settlement");
            _businessAreas.Add("pain", "Payments Initiation");
            _businessAreas.Add("reda", "Reference Data");
            _businessAreas.Add("seev", "Securities Events");
            _businessAreas.Add("semt", "Securities Management");
            _businessAreas.Add("sese", "Securities Settlement");
            _businessAreas.Add("setr", "Securities Trade");
            _businessAreas.Add("tsin", "Trade Services Initiation");
            _businessAreas.Add("tsmt", "Trade Services Management");
            _businessAreas.Add("trea", "Treasury");
        }

        #endregion


        #region Public methods

        /// <summary>
        /// Gets the business area.
        /// </summary>
        /// <param name="messageName">The name of the message. <example>pacs.002.001.02</example></param>
        /// <returns>The business area.</returns>
        public static string GetBusinessArea(string messageName)
        {
            Message.VerifyMessageName(messageName);
            string businessArea = null;

            try
            {
                businessArea = _businessAreas[messageName.Substring(0, 4)];
            }
            catch (System.Exception)
            {
            }

            if (null == businessArea)
            {
                throw new InvalidOperationException(String.Format("Error: there is no message {0} defined on the i20022 library!", messageName));
            }
            else
            {
                return businessArea;
            }
        }

        #endregion

    }
}
