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
    /// This class represents an ISO 20022 UNIFI message.
    /// The naming conventions for the UNIFI messages are 
    /// based on a format of: xxxx.aaa.bbb.cc,  where:
    ///   xxxx - 4 char business area; e.g. pacs
    ///   aaa - 3 digit message type; e.g. 008
    ///   bbb - 3 digit variant number; e.g. 001
    ///   cc - 2 digit version number; e.g 01
    /// <example>pacs.008.001.01</example>
    /// </summary>
    internal class Message
    {

        #region Private members

        private string _messageName;
        private string _description;


        #endregion


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="messageName">The name of the message.</param>
        /// <param name="description">The description.</param>
        public Message(string messageName, string description)
        {
            _messageName = messageName;
            _description = description;
        }

        #endregion


        #region Properties

        /// <summary>
        /// Gets or sets the name of the message.
        /// </summary>
        /// <value>The name of the message.</value>
        public string MessageName
        {
            get 
            { 
                return _messageName; 
            }
            set
            {
                VerifyMessageName(value);
                _messageName = value;
            }
        }


        /// <summary>
        /// Gets the message description.
        /// </summary>
        /// <value>The message description.</value>
        public string Description
        {
            get
            { 
                return _description; 
            }
        }


        /// <summary>
        /// Gets or sets the business area of the message.
        /// </summary>
        /// <value>The business area of the message.</value>
        public string BusinessArea
        {
            get 
            { 
                return GetBusinessArea(_messageName); 
            }
        }

        #endregion


        #region Internal and private methods


        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <returns></returns>
        private string GetDescription()
        {
            List<string> list = Utilities.Split( _description);

            string description = null;
            for (int index = 0; index < list.Count; index++)
            {
                if (index > 0)
                {
                    description += " ";
                }

                description += list[index];
            }

            return description;
        }


        /// <summary>
        /// Gets the business area of the message.
        /// </summary>
        /// <param name="messageName">Name of the message.</param>
        /// <returns></returns>
        private string GetBusinessArea(string messageName)
        {
            return BusinessAreas.GetBusinessArea(messageName);
        }


        /// <summary>
        /// Verifies the message name.
        /// </summary>
        /// <param name="name">The name.</param>
        internal static void VerifyMessageName(string name)
        {
            if (null == name)
            {
                throw new InvalidOperationException("Error: the message name could not be null!");
            }

            string theName = name.Trim();

            if (name.Length != 15)
            {
                throw new InvalidOperationException("Error: the message name should have 15 characters!");
            }
        }

        #endregion


        #region Convenience methods

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            return String.Format("{0} - {1} ({2})", _messageName, GetDescription(), BusinessArea);
        }

        #endregion

    }
}
