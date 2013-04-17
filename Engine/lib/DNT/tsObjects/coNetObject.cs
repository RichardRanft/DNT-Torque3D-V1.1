
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
    internal class tsObjectConvertercoNetObject : TypeConverter
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
                return new coNetObject(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoNetObject))]
    public class coNetObject: coSimObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coNetObject(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coNetObject(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coNetObject(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coNetObject ts, string simobjectid)
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
        public static bool operator !=(coNetObject ts, string simobjectid)
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
        public static implicit operator string( coNetObject ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coNetObject(string ts)
            {
            return new coNetObject(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coNetObject ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coNetObject(int ts)
            {
            return new coNetObject(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coNetObject ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coNetObject(uint ts)
            {
            return new coNetObject(ts);
            }
/// <summary>
/// @brief Undo the effects of a scopeToClient() call.
/// 
///    @param client The connection to remove this object's scoping from 
///    
///    @see scopeToClient())
/// 
/// </summary>
public  void clearScopeToClient(string client){
TorqueScriptTemplate.m_ts.fnNetObject_clearScopeToClient(_mSimObjectId, client);
}
/// <summary>
/// @brief Returns a pointer to the client object when on a local connection.
/// 
///    Short-Circuit-Networking: this is only valid for a local-client / singleplayer situation.
/// 
///    @returns the SimObject ID of the client object.
/// 
///    @tsexample
///       // Psuedo-code, some values left out for this example
///       %node = new ParticleEmitterNode(){};
///       %clientObject = %node.getClientObject();
///       if(isObject(%clientObject)
///       	%clientObject.setTransform(\"0 0 0\");
///    @endtsexample
///    
///    @see @ref local_connections)
/// 
/// </summary>
public  int getClientObject(){
return TorqueScriptTemplate.m_ts.fnNetObject_getClientObject(_mSimObjectId);
}
/// <summary>
/// @brief Get the ghost index of this object from the server.
/// 
///    @returns The ghost ID of this NetObject on the server
/// 
///    @tsexample
///       %ghostID = LocalClientConnection.getGhostId( %serverObject );
///    @endtsexample)
/// 
/// </summary>
public  int getGhostID(){
return TorqueScriptTemplate.m_ts.fnNetObject_getGhostID(_mSimObjectId);
}
/// <summary>
/// @brief Returns a pointer to the client object when on a local connection.
/// 
///    Short-Circuit-Netorking: this is only valid for a local-client / singleplayer situation.
///    
///    @returns The SimObject ID of the server object.
///    @tsexample
///       // Psuedo-code, some values left out for this example
///       %node = new ParticleEmitterNode(){};
///       %serverObject = %node.getServerObject();
///       if(isObject(%serverObject)
///       	%serverObject.setTransform(\"0 0 0\");
///    @endtsexample
///    
///    @see @ref local_connections)
/// 
/// </summary>
public  int getServerObject(){
return TorqueScriptTemplate.m_ts.fnNetObject_getServerObject(_mSimObjectId);
}
/// <summary>
/// @brief Called to check if an object resides on the clientside.
///    @return True if the object resides on the client, false otherwise.)
/// 
/// </summary>
public  bool isClientObject(){
return TorqueScriptTemplate.m_ts.fnNetObject_isClientObject(_mSimObjectId);
}
/// <summary>
/// @brief Checks if an object resides on the server.
///    @return True if the object resides on the server, false otherwise.)
/// 
/// </summary>
public  bool isServerObject(){
return TorqueScriptTemplate.m_ts.fnNetObject_isServerObject(_mSimObjectId);
}
/// <summary>
/// @brief Cause the NetObject to be forced as scoped on the specified NetConnection.
/// 
///    @param client The connection this object will always be scoped to
/// 
///    @tsexample
///       // Called to create new cameras in TorqueScript
///       // %this - The active GameConnection
///       // %spawnPoint - The spawn point location where we creat the camera
///       function GameConnection::spawnCamera(%this, %spawnPoint)
///       {
///       	// If this connection's camera exists
///       	if(isObject(%this.camera))
///       	{
///       		// Add it to the mission group to be cleaned up later
///       		MissionCleanup.add( %this.camera );
///       		// Force it to scope to the client side
///       		%this.camera.scopeToClient(%this);
///       	}
///       }
///    @endtsexample
///    
///    @see clearScopeToClient())
/// 
/// </summary>
public  void scopeToClient(string client){
TorqueScriptTemplate.m_ts.fnNetObject_scopeToClient(_mSimObjectId, client);
}
/// <summary>
/// @brief Always scope this object on all connections.
/// 
///    The object is marked as ScopeAlways and is immediately ghosted to 
///    all active connections.  This function has no effect if the object 
///    is not marked as Ghostable.)
/// 
/// </summary>
public  void setScopeAlways(){
TorqueScriptTemplate.m_ts.fnNetObject_setScopeAlways(_mSimObjectId);
}
}}
