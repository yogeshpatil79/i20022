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


namespace i20022.Reporting
{


    /// <summary>
    /// Represents the message member custom comparer.
    /// </summary>
    internal class MemberComparer : Comparer<IMessageMember>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberComparer"/> class.
        /// </summary>
        public MemberComparer()
        {
        }


        /// <summary>
        /// Compares the specified member one with member two.
        /// </summary>
        /// <param name="memberOne">The member one.</param>
        /// <param name="memberTwo">The member two.</param>
        /// <returns></returns>
        public override int Compare(IMessageMember memberOne, IMessageMember memberTwo)
        {
            // compare instances
            if (null == memberOne && null == memberTwo)
            {
                return 0;
            }
            else if (null == memberOne && null != memberTwo)
            {
                return 1;
            }
            else if (null != memberOne && null == memberTwo)
            {
                return -1;
            }

            // compare names
            if (null == memberOne.Name && null == memberTwo.Name)
            {
                return 0;
            }
            else if (null == memberOne.Name && null != memberTwo.Name)
            {
                return 1;
            }
            else if (null != memberOne.Name && null == memberTwo.Name)
            {
                return -1;
            }
            else
            {
                return memberOne.Name.CompareTo( memberTwo.Name );
            }
            
        }
    }
}
