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
using System.Collections;
using System.Reflection;

namespace i20022.Reporting
{

    /// <summary>
    /// Represents the message fields.
    /// </summary>
    internal class MessageFields : MessageField 
    {

        private ICollection _list;


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageFields"/> class.
        /// </summary>
        /// <param name="info">The info.</param>
        /// <param name="parent">The parent.</param>
        public MessageFields(FieldInfo info, object parent) : base(info, parent)
        {

            object value = base.GetValue();

            if (null == value)
            {
                _list = null;
            }

            if (value is System.ComponentModel.IListSource)
            {
                _list = ((System.ComponentModel.IListSource)value).GetList();
            }
            else
            {
                _list = (ICollection)value;
            }

        }



        /// <summary>
        /// Returns true if the object has child members and false otherwise.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance has children; otherwise, <c>false</c>.
        /// </value>
        public override bool HasChildren
        {
            get
            {
                if (null == _list)
                {
                    return false;
                }

                if (_list.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
        }


        /// <summary>
        /// Returns the child members of the member.
        /// </summary>
        /// <returns></returns>
        public override IList<IMessageMember> GetChildren()
        {
            if (!HasChildren)
            {
                return null;
            }
            else
            {
                return MessageReporter.GetListItems( _list );
            }
        }

    }
}
