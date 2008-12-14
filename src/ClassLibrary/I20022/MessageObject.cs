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
    /// This is a convenience class responsible to
    /// converting ISO 20022 message documents to message objects.
    /// <example>
    /// <code>
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
    ///             // converts it to an object
    ///             MessageDocument md = new MessageDocument(xml);
    ///             // it is ready to use programmatically
    ///             Document messageObject = (Document) md.ToObject();
    ///             :
    ///             // converts the message object to xml...
    ///             MessageObject mo = new MessageObject(messageObject);            
    ///             // is simple like this!!!
    ///             xml = mo.ToXml();
    ///             :
    ///         }
    ///     }
    /// 
    /// </code>
    /// </example>
    /// </summary>
    public sealed class MessageObject
    {

        #region Private members

        private string _errorText;
        private string _messageCode;
        private Type _messageType;
        private object _instance;

        #endregion


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObject"/> class.
        /// </summary>
        /// <param name="instance">The message object instance.</param>
        public MessageObject(object instance)
        {
            _instance = instance;
            _messageType = instance.GetType();
        }

        #endregion


        #region Public properties


        /// <summary>
        /// Gets the error text.
        /// </summary>
        /// <value>The error text.</value>
        public string ErrorText
        {
            get { return _errorText; }
        }

        /// <summary>
        /// Gets the message code.
        /// </summary>
        /// <value>The message code.</value>
        public string MessageCode
        {
            get { return _messageCode; }
        }

        /// <summary>
        /// Gets the message type.
        /// </summary>
        /// <value>The message type.</value>
        public Type MessageType
        {
            get { return _messageType; }
        }

        /// <summary>
        /// Gets the message object instance.
        /// </summary>
        /// <value>The message object instance.</value>
        public object Instance
        {
            get { return _instance; }
        }

        #endregion


        #region Public methods


        /// <summary>
        /// Converts an instance of a message object in a xml message document.
        /// </summary>
        /// <returns>The xml message document representing the message object instance.</returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        /// <exception cref="System.NotSupportedException"></exception>
        /// <exception cref="System.ObjectDisposedException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        public string ToXml()
        {
            string xml = String.Empty; 
         
            XmlSerializer serializer = null;
            Stream stream = null;

            try
            {
                serializer = Initialize( _messageType );
                stream = new MemoryStream();
                serializer.Serialize( stream, _instance );
                xml = Utilities.MemoryStream2String( stream );
                _messageCode = Utilities.GetMessageCode(xml);
                stream.Dispose();
            }
            finally
            {
                serializer = null;
                stream = null;
            }

            return xml;
        }


        #endregion


        #region Serialization handlers


        /// <summary>
        /// Initializes a new XmlSerializer.
        /// </summary>
        /// <param name="type">The datatype of an unifi message instance.</param>
        /// <returns>The xml serializer.</returns>
        private XmlSerializer Initialize( Type type )
        {
            XmlSerializer serializer = new XmlSerializer( type );

            serializer.UnknownNode += new XmlNodeEventHandler( serializer_UnknownNode );
            serializer.UnknownAttribute += new XmlAttributeEventHandler( serializer_UnknownAttribute );
            serializer.UnknownElement += new XmlElementEventHandler( serializer_UnknownElement );
            serializer.UnreferencedObject += new UnreferencedObjectEventHandler( serializer_UnreferencedObject );

            return serializer;
        }


        /// <summary>
        /// Handles the UnknownNode event of the serializer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Xml.Serialization.XmlNodeEventArgs"/> instance containing the event data.</param>
        private void serializer_UnknownNode( object sender, XmlNodeEventArgs e )
        {
            _errorText += String.Format( "unknown node {0}='{1}'", e.Name, e.Text );
        }


        /// <summary>
        /// Handles the UnknownAttribute event of the serializer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Xml.Serialization.XmlAttributeEventArgs"/> instance containing the event data.</param>
        private void serializer_UnknownAttribute( object sender, XmlAttributeEventArgs e )
        {
            System.Xml.XmlAttribute attr = e.Attr;
            _errorText += String.Format( "unknown attribute {0}='{1}'", attr.Name, attr.Value );
        }


        /// <summary>
        /// Handles the UnknownElement event of the serializer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Xml.Serialization.XmlElementEventArgs"/> instance containing the event data.</param>
        private void serializer_UnknownElement( object sender, XmlElementEventArgs e )
        {
            System.Xml.XmlElement elem = e.Element;
            _errorText += String.Format( "unknown element {0}='{1}'", elem.Name, elem.Value );
        }


        /// <summary>
        /// Handles the UnreferencedObject event of the serializer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Xml.Serialization.UnreferencedObjectEventArgs"/> instance containing the event data.</param>
        private void serializer_UnreferencedObject( object sender, UnreferencedObjectEventArgs e )
        {
            _errorText += String.Format( "unreferenced object '{0}' type='{1}'",
                e.UnreferencedId,
                e.UnreferencedObject.GetType().Name );
        }

        #endregion


    }
}
