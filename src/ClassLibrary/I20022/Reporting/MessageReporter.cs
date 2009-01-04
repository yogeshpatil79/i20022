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
using System.Collections;

using i20022.MessageSet;


namespace i20022.Reporting
{

    /// <summary>
    /// <example>
    /// <code>
    /// :
    /// using i20022;               // references the convenience classes
    /// using i20022.Reporting;     // references reporting 
    /// using i20022.acmt00100102;  // references the messages to work on
    /// 
    /// namespace SampleCode
    /// {
    ///     class Program
    ///     {
    ///         static void Main(string[] args)
    ///         {
    ///             // reads the xml message
    ///             string xml = File.ReadAllText(".//acmt.001.001.02.xml");
    /// 
    ///             // converts it to an object
    ///             MessageDocument md = new MessageDocument(xml);
    ///             
    ///             // it is ready to use programmatically
    ///             Document messageObject = (Document) md.ToObject();
    ///  
    ///             // generates a full report of the message in plain text
    ///             string report = MessageReporter.Report(messageObject, ReportingType.PlainText);
    ///             :
    ///         }
    ///     }
    /// </code>
    /// </example>
    /// </summary>
    public static class MessageReporter
    {

        #region Private members

        private static readonly BindingFlags 
            _filter = BindingFlags.Instance | BindingFlags.Public;

        #endregion


        /// <summary>
        /// Report a message object in plain text ou html.
        /// <remarks>TODO: xml report</remarks>
        /// </summary>
        /// <param name="instance">The message instance to report.</param>
        /// <param name="reportingType">The reporting type.</param>
        /// <returns>The report.</returns>
        public static string Report( object instance, ReportingType reportingType )
        {
            if (null == instance)
            {
                throw new InvalidOperationException("Error: the message object instance could not be null!");
            }

            StringBuilder concat = new StringBuilder();

            string messageType = Messages.InferMessageType(instance);
            string messageDescription = Messages.GetMessage(messageType).ToString();

            concat.AppendFormat("{0}{1}", messageDescription, Environment.NewLine);

            List<IMessageMember> list = MessageReporter.GetMembers( instance );
            int indent = 0;

            foreach (IMessageMember member in list)
            {
                TraverseMessage( member, reportingType, ref concat, ref indent );
            }

            return concat.ToString();
        }


        /// <summary>
        /// Traverses the message.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <param name="reportingType">Type of the reporting.</param>
        /// <param name="concat">The concat.</param>
        /// <param name="indent">The indent.</param>
        private static void TraverseMessage( IMessageMember member, ReportingType reportingType, ref StringBuilder concat, ref int indent )
        {

            StringBuilder memberConcat = new StringBuilder();
            string name = member.Name;
            object value = null;

            if (indent > 0)
            {
                memberConcat.AppendFormat( "|{0}", Environment.NewLine );
                memberConcat.AppendFormat( "{0}", "+" + new String( '-', indent ) );
            }

            memberConcat.AppendFormat( "{0}", Acronyms.BuildPhrase( name ) );

            if (member.HasValue)
            {
                value = member.GetValue();

                if (null != value)
                {
                    string strValue = String.Format("{0}", value);
                    // verify if value has a description
                    string meaning = Enumerations.GetMeaning(strValue);
                    if (null != meaning)
                    {
                        memberConcat.AppendFormat(" : {0} ({1}){2}", strValue, meaning, Environment.NewLine);
                    }
                    else
                    {
                        memberConcat.AppendFormat(" : {0}{1}", strValue, Environment.NewLine);
                    }
                }
                else
                {
                    memberConcat.AppendFormat( "{0}", Environment.NewLine );
                }
            }
            else
            {
                memberConcat.AppendFormat( "{0}", Environment.NewLine );
            }

            string line = memberConcat.ToString();
            if (!line.EndsWith( "(NULL)" + Environment.NewLine ))
            {
                concat.Append( line );
            }

            if (member.HasChildren)
            {
                indent++;
                foreach (IMessageMember child in member.GetChildren())
                {
                    TraverseMessage( child, reportingType, ref concat, ref indent );
                }
                indent--;
            }

        }


        /// <summary>
        /// Gets all members.
        /// </summary>
        /// <param name="obj">Any object to browse </param>
        /// <returns>List of members</returns>
        internal static List<IMessageMember> GetMembers(object obj)
        {
            if (null == obj)
            {
                return null;
            }

            Type objType = obj.GetType();            
            List<IMessageMember> result = new List<IMessageMember>();

            FieldInfo[] fields = objType.GetFields(_filter);
            foreach (FieldInfo fieldInfo in fields )
            {
                IMessageMember oField;
                if (IsCollection(fieldInfo.GetValue(obj)))
                {
                    oField = new MessageFields(fieldInfo, obj);
                }
                else
                {
                    oField = new MessageField(fieldInfo, obj);
                }
                result.Add(oField);
            }


            return  result ;
        }


        /// <summary>
        /// Determines whether the specified obj is collection.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns>
        /// 	<c>true</c> if the specified obj is collection; otherwise, <c>false</c>.
        /// </returns>
        internal static bool IsCollection( object obj )
        {
            if (null == obj)
            {
                return false;
            }

            if (obj is System.Collections.ICollection || obj is System.ComponentModel.IListSource || obj is Array)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Determines whether the specified object is an enumeration.
        /// </summary>
        /// <param name="obj">The object instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified object instance is an enumeration; otherwise, <c>false</c>.
        /// </returns>
        internal static bool IsEnum(object obj)
        {
            return (obj.GetType().BaseType.Name.Equals("Enum"));
        }


        /// <summary>
        /// Gets the list items.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns></returns>
        internal static IList<IMessageMember> GetListItems( System.Collections.ICollection collection )
        {
           List<IMessageMember> result = new List<IMessageMember>();
           IEnumerator enumer = collection.GetEnumerator();
            while (enumer.MoveNext())
            {
                MessageItem oItem = new MessageItem(enumer.Current);
                result.Add(oItem);
            }
            
            return result;
        }


        /// <summary>
        /// Determines whether [is value type] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        /// 	<c>true</c> if [is value tyype] [the specified type]; otherwise, <c>false</c>.
        /// </returns>
        internal static bool IsValueType(Type type)
        {
            if (type.IsValueType)
            {
                return true;
            }

            if (type == typeof(string) || type == typeof(int) || type == typeof(Int16) || type == typeof(Int32) || type == typeof(Int64)
                || type == typeof(decimal) || type == typeof(double) || type == typeof(Guid) || type == typeof(uint) || type == typeof(UInt16)
                || type == typeof(UInt32) || type == typeof(UInt64) || type == typeof(UIntPtr) || type == typeof(ulong) || type == typeof(long)
                || type == typeof(bool) || type == typeof(byte))
                return true;

            return false;


        }

    }
}
