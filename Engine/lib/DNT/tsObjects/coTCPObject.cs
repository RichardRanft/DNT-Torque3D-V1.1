
// Copyright (C) 2012 Winterleaf Entertainment L,L,C.
// 
// THE SOFTW ARE IS PROVIDED ON AN “ AS IS” BASIS, WITHOUT W ARRANTY OF ANY KIND,
// INCLUDING WITHOUT LIMIT ATION THE W ARRANTIES OF MERCHANT ABILITY, FITNESS
// FOR A PARTICULAR PURPOSE OR NON-INFRINGEMENT . THE ENTIRE RISK AS TO THE
// QUALITY AND PERFORMANCE OF THE SOFTW ARE IS THE RESPONSIBILITY OF LICENSEE.
// SHOULD THE SOFTW ARE PROVE DEFECTIVE IN ANY RESPECT , LICENSEE AND NOT LICEN -
// SOR OR ITS SUPPLIERS OR RESELLERS ASSUMES THE ENTIRE COST OF AN Y SERVICE AND
// REPAIR. THIS DISCLAIMER OF W ARRANTY CONSTITUTES AN ESSENTIAL PART OF THIS
// AGREEMENT. NO USE OF THE SOFTW ARE IS AUTHORIZED HEREUNDER EXCEPT UNDER
// THIS DISCLAIMER.
// 
// The use of the WinterLeaf Entertainment LLC DotNetT orque (“DNT ”) and DotNetT orque
// Customizer (“DNTC”)is governed by this license agreement (“ Agreement”).
// 
// R E S T R I C T I O N S
// 
// (a) Licensee may not: (i) create any derivative works of DNTC, including but not
// limited to translations, localizations, technology add-ons, or game making software
// other than Games; (ii) reverse engineer , or otherwise attempt to derive the algorithms
// for DNT or DNTC (iii) redistribute, encumber , sell, rent, lease, sublicense, or otherwise
// transfer rights to  DNTC; or (iv) remove or alter any tra demark, logo, copyright
// or other proprietary notices, legends, symbols or labels in DNT or DNTC; or (iiv) use
// the Software to develop or distribute any software that compete s with the Software
// without WinterLeaf Entertainment’s prior written consent; or (i iiv) use the Software for
// any illegal purpose.
// (b) Licensee may not distribute the DNTC in any manner.
// 
// LI C E N S E G R A N T .
// This license allows companies of any size, government entities or individuals to cre -
// ate, sell, rent, lease, or otherwise profit commercially from, games using executables
// created from the source code of DNT
// 
// **********************************************************************************
// **********************************************************************************
// **********************************************************************************
// THE SOURCE CODE GENERATED BY DNTC CAN BE  DISTRIBUTED PUBLICLY PROVIDED THAT THE 
// DISTRIBUTOR PROVIDES  THE GENERATE SOURCE CODE FREE OF CHARGE.
// 
// THIS SOURCE CODE (DNT) CAN BE DISTRIBUTED PUBLICLY PROVIDED THAT THE DISTRIBUTOR 
// PROVIDES  THE SOURCE CODE (DNT) FREE OF CHARGE.
// **********************************************************************************
// **********************************************************************************
// **********************************************************************************
// 
// Please visit http://www.winterleafentertainment.com for more information about the project and latest updates.

#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Classes;
using WinterLeaf.Containers;
using WinterLeaf.Enums;
using System.ComponentModel;
#endregion

namespace WinterLeaf.tsObjects
    {
    /// <summary>
    /// 
    /// </summary>
    internal class tsObjectConvertercoTCPObject : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof(string) == sourceType);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
            if (value is string)
                {
                return new coTCPObject(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoTCPObject))]
    public class coTCPObject: coSimObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coTCPObject(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coTCPObject(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coTCPObject(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coTCPObject ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);


            }
  /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            throw new NotImplementedException();
            }
  /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            
            return (this._mSimObjectId ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(coTCPObject ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);

            }


            /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( coTCPObject ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coTCPObject(string ts)
            {
            return new coTCPObject(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coTCPObject ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coTCPObject(int ts)
            {
            return new coTCPObject(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coTCPObject ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coTCPObject(uint ts)
            {
            return new coTCPObject(ts);
            }
/// <summary>
/// @brief Connect to the given address.
/// 
///    @param address Server address (including port) to connect to.
/// 
///    @tsexample
///       // Set the address.
///       %address = \"www.garagegames.com:80\";
/// 
///       // Inform this TCPObject to connect to the specified address.
///       %thisTCPObj.connect(%address);
///    @endtsexample)
/// 
/// </summary>
public  void connect(string address){
TorqueScriptTemplate.m_ts.fnTCPObject_connect(_mSimObjectId, address);
}
/// <summary>
/// @brief Disconnect from whatever this TCPObject is currently connected to, if anything.
/// 
///    @tsexample
///       // Inform this TCPObject to disconnect from anything it is currently connected to.
///       %thisTCPObj.disconnect();
///    @endtsexample)
/// 
/// </summary>
public  void disconnect(){
TorqueScriptTemplate.m_ts.fnTCPObject_disconnect(_mSimObjectId);
}
/// <summary>
/// @brief Start listening on the specified port for connections.
/// 
///    This method starts a listener which looks for incoming TCP connections to a port.  
///    You must overload the onConnectionRequest callback to create a new TCPObject to 
///    read, write, or reject the new connection.
/// 
///    @param port Port for this TCPObject to start listening for connections on.
/// 
///    @tsexample
/// 
///     // Create a listener on port 8080.
///     new TCPObject( TCPListener );
///     TCPListener.listen( 8080 );
/// 
///     function TCPListener::onConnectionRequest( %this, %address, %id )
///     {
///        // Create a new object to manage the connection.
///        new TCPObject( TCPClient, %id );
///     }
/// 
///     function TCPClient::onLine( %this, %line )
///     {
///        // Print the line of text from client.
///        echo( %line );
///     }
/// 
///    @endtsexample)
/// 
/// </summary>
public  void listen(int port){
TorqueScriptTemplate.m_ts.fnTCPObject_listen(_mSimObjectId, port);
}
/// <summary>
/// @brief Transmits the data string to the connected computer.
/// 
///    This method is used to send text data to the connected computer regardless if we initiated the 
///    connection using connect(), or listening to a port using listen().
/// 
///    @param data The data string to send.
/// 
///    @tsexample
///       // Set the command data
///       %data = \"GET \" @ $RSSFeed::serverURL @ \" HTTP/1.0\\r\\";
///       %data = %data @ \"Host: \" @ $RSSFeed::serverName @ \"\\r\\";
///       %data = %data @ \"User-Agent: \" @ $RSSFeed::userAgent @ \"\\r\\\r\\"
/// 
///       // Send the command to the connected server.
///       %thisTCPObj.send(%data);
///    @endtsexample)
/// 
/// </summary>
public  void send(string data){
TorqueScriptTemplate.m_ts.fnTCPObject_send(_mSimObjectId, data);
}
}}