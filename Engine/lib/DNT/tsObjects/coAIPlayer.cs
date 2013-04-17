
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
    internal class tsObjectConvertercoAIPlayer : TypeConverter
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
                return new coAIPlayer(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoAIPlayer))]
    public class coAIPlayer: coPlayer
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coAIPlayer(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coAIPlayer(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coAIPlayer(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coAIPlayer ts, string simobjectid)
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
        public static bool operator !=(coAIPlayer ts, string simobjectid)
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
        public static implicit operator string( coAIPlayer ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coAIPlayer(string ts)
            {
            return new coAIPlayer(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coAIPlayer ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coAIPlayer(int ts)
            {
            return new coAIPlayer(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coAIPlayer ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coAIPlayer(uint ts)
            {
            return new coAIPlayer(ts);
            }
public float mMoveTolerance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".mMoveTolerance").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".mMoveTolerance", value.AsString());
          }
       }
public int moveStuckTestDelay
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".moveStuckTestDelay").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".moveStuckTestDelay", value.AsString());
          }
       }
public float moveStuckTolerance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".moveStuckTolerance").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".moveStuckTolerance", value.AsString());
          }
       }
/// <summary>
/// @brief Use this to stop aiming at an object or a point.
///    
///    @see setAimLocation()
///    @see setAimObject())
/// 
/// </summary>
public  void clearAim(){
TorqueScriptTemplate.m_ts.fnAIPlayer_clearAim(_mSimObjectId);
}
/// <summary>
/// @brief Returns the point the AIPlayer is aiming at.
/// 
///    This will reflect the position set by setAimLocation(), 
///    or the position of the object that the bot is now aiming at.  
///    If the bot is not aiming at anything, this value will 
///    change to whatever point the bot's current line-of-sight intercepts.
/// 
///    @return World space coordinates of the object AI is aiming at. Formatted as \"X Y Z\".
///    
///    @see setAimLocation()
///    @see setAimObject())
/// 
/// </summary>
public  Point3F getAimLocation(){
return new Point3F ( TorqueScriptTemplate.m_ts.fnAIPlayer_getAimLocation(_mSimObjectId));
}
/// <summary>
/// @brief Gets the object the AIPlayer is targeting.
/// 
///    @return Returns -1 if no object is being aimed at, 
///    or the SimObjectID of the object the AIPlayer is aiming at.
///    
///    @see setAimObject())
/// 
/// </summary>
public  int getAimObject(){
return TorqueScriptTemplate.m_ts.fnAIPlayer_getAimObject(_mSimObjectId);
}
/// <summary>
/// @brief Get the AIPlayer's current destination.
/// 
///    @return Returns a point containing the \"x y z\" position 
///    of the AIPlayer's current move destination. If no move destination 
///    has yet been set, this returns \"0 0 0\".
///    
///    @see setMoveDestination())
/// 
/// </summary>
public  Point3F getMoveDestination(){
return new Point3F ( TorqueScriptTemplate.m_ts.fnAIPlayer_getMoveDestination(_mSimObjectId));
}
/// <summary>
/// @brief Gets the move speed of an AI object.
/// 
///    @return A speed multiplier between 0.0 and 1.0.
/// 
///    @see setMoveSpeed())
/// 
/// </summary>
public  float getMoveSpeed(){
return TorqueScriptTemplate.m_ts.fnAIPlayer_getMoveSpeed(_mSimObjectId);
}
/// <summary>
/// @brief Tells the AIPlayer to aim at the location provided.
/// 
///    @param target An \"x y z\" position in the game world to target.
///    
///    @see getAimLocation())
/// 
/// </summary>
public  void setAimLocation(Point3F target){
TorqueScriptTemplate.m_ts.fnAIPlayer_setAimLocation(_mSimObjectId, target.AsString());
}
/// <summary>
/// ( AIPlayer, setAimObject, void, 3, 4, ( GameBase obj, [Point3F offset] )
///               Sets the bot's target object. Optionally set an offset from target location.
/// 			  @hide)
/// 
/// </summary>
public  void setAimObject(string a2, string a3= ""){
TorqueScriptTemplate.m_ts.fnAIPlayer_setAimObject(_mSimObjectId, a2, a3);
}
/// <summary>
/// @brief Tells the AI to move to the location provided
/// 
///    @param goal Coordinates in world space representing location to move to.
///    @param slowDown A boolean value. If set to true, the bot will slow down 
///    when it gets within 5-meters of its move destination. If false, the bot 
///    will stop abruptly when it reaches the move destination. By default, this is true.
/// 
///    @note Upon reaching a move destination, the bot will clear its move destination and 
///    calls to getMoveDestination will return \"0 0 0\".
///    
///    @see getMoveDestination())
/// 
/// </summary>
public  void setMoveDestination(Point3F goal, bool slowDown){
TorqueScriptTemplate.m_ts.fnAIPlayer_setMoveDestination(_mSimObjectId, goal.AsString(), slowDown);
}
/// <summary>
/// @brief Sets the move speed for an AI object.
/// 
///    @param speed A speed multiplier between 0.0 and 1.0.  
///    This is multiplied by the AIPlayer's base movement rates (as defined in 
///    its PlayerData datablock)
///    
///    @see getMoveDestination())
/// 
/// </summary>
public  void setMoveSpeed(float speed){
TorqueScriptTemplate.m_ts.fnAIPlayer_setMoveSpeed(_mSimObjectId, speed);
}
/// <summary>
/// @brief Tells the AIPlayer to stop moving.)
/// 
/// </summary>
public  void stop(){
TorqueScriptTemplate.m_ts.fnAIPlayer_stop(_mSimObjectId);
}
}}
