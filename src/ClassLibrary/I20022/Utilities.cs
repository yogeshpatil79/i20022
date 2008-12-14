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
// |                                                   |
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
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;


namespace i20022
{

    /// <summary>
    /// Convenience utility class.
    /// </summary>
    internal static class Utilities
    {

        #region Static members

        private static List<Type> _messageTypes;
        private static readonly string[] _assemblies
            = new string[] 
            {
                "AccountManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "Administration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "CashManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "PaymentsClearingAndSettlement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "PaymentsInitiation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "ReferenceData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "SecuritiesEvents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "SecuritiesManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "SecuritiesSettlement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "SecuritiesTrade, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "TradeServicesInitiation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441",
                "TradeServicesManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7714131591c4441"
            };

        #endregion


        #region Class initializer


        /// <summary>
        /// Initializes the <see cref="Utilities"/> class.
        /// </summary>
        static Utilities()
        {
            _messageTypes = new List<Type>();

            try
            {

                foreach (string assemblyName in _assemblies)
                {
                    Assembly assembly = Assembly.Load( assemblyName );

                    Type[] types =
                        assembly.GetExportedTypes();

                    foreach (Type type in types)
                    {
                        _messageTypes.Add( type );
                    }
                }
            }
            catch (System.Exception exception)
            {
                throw new InvalidOperationException( "Error: One or more i20022 assemblies coud not be found at the application directory or GAC!", exception );
            }
        }


        #endregion


        #region Convenience methods


        /// <summary>
        /// Traces the specified text.
        /// </summary>
        /// <param name="Text">The text.</param>
        internal static void Trace(string Text)
        {
            System.Diagnostics.Trace.WriteLine(Text);
        }


        /// <summary>
        /// Traces the specified formated text.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        internal static void Trace(string format, params object[] args)
        {
            Trace(string.Format(format, args));
        }


        /// <summary>
        /// Gets the unifi message code.
        /// </summary>
        /// <param name="xml">The xml message.</param>
        /// <returns>The message type.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        internal static string GetMessageCode(string xml)
        {
            string xmlns = null;

            // 1234567890123456789012345678901                 (31)
            // urn:iso:std:iso:20022:tech:xsd:acmt.001.001.02
            //                                123456789012345  (15)

            //                 1234567
            string preamble = "xmlns=\"";
            int begin = xml.IndexOf(preamble, 0, StringComparison.InvariantCultureIgnoreCase);
            int end;
            if (begin >= 0)
            {
                end = xml.IndexOf("\"", begin + 8);
                if (end >= 0)
                {
                    xmlns = xml.Substring(begin + 7, end - begin - 7);
                }
            }

            return xmlns.Substring(xmlns.Length - 15);
        }


        /// <summary>
        /// Gets the unifi message datatype.
        /// </summary>
        /// <param name="xml">The xml message.</param>
        /// <returns>The unifi message datatype.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        internal static Type GetMessageType(string xml)
        {
            string messageCode = GetMessageCode(xml).Replace(".", "");
            Type returnType = null;

            for (int i = 0; i < _messageTypes.Count; i++)
            {
                if (_messageTypes[i].FullName.IndexOf(messageCode) > 0)
                {
                    returnType = _messageTypes[i];
                    break;
                }
            }

            return returnType;
        }


        /// <summary>
        /// Creates a MemoryStream from a xml string message.
        /// </summary>
        /// <param name="xml">The xml message.</param>
        /// <returns>The MemoryStream.</returns>
        internal static Stream String2MemoryStream(string xml)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(xml);

            return new MemoryStream(buffer);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="st">The MemoryStream.</param>
        /// <returns>The xml message.</returns>
        internal static string MemoryStream2String(Stream st)
        {
            byte[] buffer = new byte[((int)st.Length)];

            st.Position = 0;
            st.Read(buffer, 0, ((int)st.Length));

            return Encoding.UTF8.GetString(buffer);
        }


        /// <summary>
        /// Splits the specified the word.
        /// </summary>
        /// <param name="theWord">The word to split.</param>
        /// <returns></returns>
        internal static List<string> Split(string theWord)
        {
            theWord = theWord.Trim();
            byte[] bytes = UTF8Encoding.UTF8.GetBytes(theWord);
            int[] positions = new int[180];
            List<string> alist = new List<string>();

            int positionIndex = 0;
            for (int index = 0; index < bytes.Length; index++)
            {
                if (bytes[index] >= 65 && bytes[index] <= 90)
                {
                    positions[positionIndex++] = index;
                }

                if (bytes[index] >= 48 && bytes[index] <= 57)
                {
                    positions[positionIndex++] = index;
                }
            }

            for (int i = 0; i < positions.Length - 1; i++)
            {
                string word = String.Empty;
                int start = positions[i];
                int next = positions[i + 1];

                if (next != 0)
                {
                    word = theWord.Substring(start, next - start);
                }
                else
                {
                    word = theWord.Substring(start);
                }

                alist.Add(word);

                if (next == 0)
                {
                    break;
                }
            }

            // enums & numbers
            for (int index = alist.Count - 1; index > -1; index--)
            {
                if (IsDigit(alist[index]))
                {
                    if (index > 1 && IsDigit(alist[index - 1]))
                    {
                        alist[index - 1] = alist[index - 1] + alist[index];
                        alist.RemoveAt(index);
                    }
                }
            }


            return alist;
        }


        #endregion

        
        #region Private methods

        /// <summary>
        /// Verify if a given word is a digit.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        /// 	<c>true</c> if [the specified word is a digit]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsDigit(string word)
        {
            if (word.Length == 1 && word.Substring(0, 1).CompareTo("0") >= 0 && word.Substring(0, 1).CompareTo("9") <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        #endregion

    }
}
