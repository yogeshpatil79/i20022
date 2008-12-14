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
using i20022.MessageSet;


namespace i20022.Reporting
{

    /// <summary>
    /// The <b>i20022 message member</b> interface.
    /// </summary>
    internal interface IMessageMember
    {

        /// <summary>
        /// Gets the member큦 type.
        /// </summary>
        /// <value>The member큦 type.</value>
        Type Type { get; }


        /// <summary>
        /// Gets a value indicating whether this instance has value.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance has value; otherwise, <c>false</c>.
        /// </value>
        bool HasValue { get;}


        /// <summary>
        /// Gets the member큦 value if it is a value type.
        /// </summary>
        /// <returns>The member큦 value.</returns>
        object GetValue();


        /// <summary>
        /// Gets the member큦 name.
        /// </summary>
        /// <value>The member큦 name.</value>
        string Name { get; }

        
        /// <summary>
        /// Gets a value indicating whether this instance has children.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance has children; otherwise, <c>false</c>.
        /// </value>
        bool HasChildren { get;}
        

        /// <summary>
        /// Gets the list of child member큦.
        /// </summary>
        /// <returns>The list of child member큦.</returns>
        IList<IMessageMember> GetChildren();

    }
}
