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
    /// Implementation class of the message item. 
    /// </summary>
    internal class MessageItem : IMessageMember 
    {

        protected  object _source;


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageItem"/> class.
        /// </summary>
        protected MessageItem()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageItem"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        public MessageItem(object source)
        {
            _source = source;
        }
        

         /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public virtual string Name
        {
            get 
            {
                if (null == _source)
                {
                    return "(NULL)";
                }
                else
                {
                    return _source.ToString();
                }
            }
        }


        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public virtual Type Type
        {
            get 
            {
                if (null == _source)
                {
                    return null;
                }
                else
                {
                    return _source.GetType();
                }
            }
        }



        /// <summary>
        /// Gets a value indicating whether this instance has value.
        /// </summary>
        /// <value><c>true</c> if this instance has value; otherwise, <c>false</c>.</value>
        public virtual bool HasValue
        {
            get 
            {
                
                if (null == _source)
                {
                    return true;
                }
                else if ( MessageReporter.IsValueType(Type) || MessageReporter.IsEnum(_source))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <returns>The value.</returns>
        public virtual object GetValue()
        {
            if (null == _source)
            {
                return "(NULL)";
            }
            else if (HasValue)
            {
                return _source.ToString();
            }
            else
            {
                return _source;
            }

        }


        /// <summary>
        /// Returns true if the object has child members and false otherwise.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance has children; otherwise, <c>false</c>.
        /// </value>
        public virtual bool HasChildren
        {
            get 
            {
                if (null == _source)
                {
                    return false;
                }
                if (HasValue)
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
        public virtual IList<IMessageMember> GetChildren()
        {
            if (!HasChildren)
            {
                return null;
            }

            return MessageReporter.GetMembers(_source);
        }

    }
}
