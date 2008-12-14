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
using System.Text;
using System.Reflection;


namespace i20022.Reporting
{

    /// <summary>
    /// Represent a message field.
    /// </summary>
    internal class MessageField : MessageItem
    {

        #region Private members

        private FieldInfo _info;

        #endregion


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageField"/> class.
        /// </summary>
        /// <param name="info">The info.</param>
        /// <param name="parent">The parent.</param>
        public MessageField(FieldInfo info, object parent): base()
        {
            Utilities.Trace("MessageField({0},{1})", info, parent);
            _info = info;
            base._source = info.GetValue(parent);
        }


        /// <summary>
        /// Gets the info.
        /// </summary>
        /// <value>The info.</value>
        public FieldInfo Info
        {
            get
            {
                return _info;
            }
        }


        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public override string Name
        {
            get
            {
                return _info.Name;
            }
        }


        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public override Type Type
        {
            get
            {
                return _info.FieldType;
            }
        }


    }
}
