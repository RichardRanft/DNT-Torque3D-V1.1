
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
    internal class tsObjectConvertercoPrecipitation : TypeConverter
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
                return new coPrecipitation(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoPrecipitation))]
    public class coPrecipitation: coGameBase
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPrecipitation(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPrecipitation(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPrecipitation(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coPrecipitation ts, string simobjectid)
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
        public static bool operator !=(coPrecipitation ts, string simobjectid)
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
        public static implicit operator string( coPrecipitation ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPrecipitation(string ts)
            {
            return new coPrecipitation(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coPrecipitation ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPrecipitation(int ts)
            {
            return new coPrecipitation(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coPrecipitation ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPrecipitation(uint ts)
            {
            return new coPrecipitation(ts);
            }
public bool animateSplashes
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".animateSplashes").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".animateSplashes", value.AsString());
          }
       }
public float boxHeight
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".boxHeight").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".boxHeight", value.AsString());
          }
       }
public float boxWidth
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".boxWidth").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".boxWidth", value.AsString());
          }
       }
public bool doCollision
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".doCollision").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".doCollision", value.AsString());
          }
       }
public int dropAnimateMS
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dropAnimateMS").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dropAnimateMS", value.AsString());
          }
       }
public float dropSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dropSize").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dropSize", value.AsString());
          }
       }
public float fadeDist
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeDist").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeDist", value.AsString());
          }
       }
public float fadeDistEnd
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeDistEnd").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeDistEnd", value.AsString());
          }
       }
public bool followCam
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".followCam").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".followCam", value.AsString());
          }
       }
public ColorF glowIntensity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".glowIntensity").AsColorF();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".glowIntensity", value.AsString());
          }
       }
public bool hitPlayers
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".hitPlayers").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".hitPlayers", value.AsString());
          }
       }
public bool hitVehicles
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".hitVehicles").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".hitVehicles", value.AsString());
          }
       }
public float maxMass
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxMass").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxMass", value.AsString());
          }
       }
public float maxSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxSpeed", value.AsString());
          }
       }
public float maxTurbulence
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxTurbulence").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxTurbulence", value.AsString());
          }
       }
public float minMass
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".minMass").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".minMass", value.AsString());
          }
       }
public float minSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".minSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".minSpeed", value.AsString());
          }
       }
public int numDrops
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".numDrops").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".numDrops", value.AsString());
          }
       }
public bool reflect
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".reflect").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".reflect", value.AsString());
          }
       }
public bool rotateWithCamVel
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".rotateWithCamVel").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".rotateWithCamVel", value.AsString());
          }
       }
public int splashMS
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".splashMS").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".splashMS", value.AsString());
          }
       }
public float splashSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".splashSize").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".splashSize", value.AsString());
          }
       }
public float turbulenceSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".turbulenceSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".turbulenceSpeed", value.AsString());
          }
       }
public bool useLighting
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".useLighting").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".useLighting", value.AsString());
          }
       }
public bool useTrueBillboards
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".useTrueBillboards").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".useTrueBillboards", value.AsString());
          }
       }
public bool useTurbulence
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".useTurbulence").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".useTurbulence", value.AsString());
          }
       }
public bool useWind
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".useWind").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".useWind", value.AsString());
          }
       }
/// <summary>
/// Smoothly change the maximum number of drops in the effect (from current 
///    value to #numDrops * @a percentage).
///    This method can be used to simulate a storm building or fading in intensity 
///    as the number of drops in the Precipitation box changes.
///    @param percentage New maximum number of drops value (as a percentage of 
///    #numDrops). Valid range is 0-1.
///    @param seconds Length of time (in seconds) over which to increase the drops 
///    percentage value. Set to 0 to change instantly.
///    @tsexample
///    %percentage = 0.5;  // The percentage, from 0 to 1, of the maximum drops to display
///    %seconds = 5.0;     // The length of time over which to make the change.
///    %precipitation.modifyStorm( %percentage, %seconds );
///    @endtsexample )
/// 
/// </summary>
public  void modifyStorm(float percentage, float seconds){
TorqueScriptTemplate.m_ts.fnPrecipitation_modifyStorm(_mSimObjectId, percentage, seconds);
}
/// <summary>
/// Sets the maximum number of drops in the effect, as a percentage of #numDrops.
///    The change occurs instantly (use modifyStorm() to change the number of drops 
///    over a period of time.
///    @param percentage New maximum number of drops value (as a percentage of 
///    #numDrops). Valid range is 0-1.
///    @tsexample
///    %percentage = 0.5;  // The percentage, from 0 to 1, of the maximum drops to display
///    %precipitation.setPercentage( %percentage );
///    @endtsexample
///    @see modifyStorm )
/// 
/// </summary>
public  void setPercentage(float percentage){
TorqueScriptTemplate.m_ts.fnPrecipitation_setPercentage(_mSimObjectId, percentage);
}
/// <summary>
/// Smoothly change the turbulence parameters over a period of time.
///    @param max New #maxTurbulence value. Set to 0 to disable turbulence.
///    @param speed New #turbulenceSpeed value.
///    @param seconds Length of time (in seconds) over which to interpolate the 
///    turbulence settings. Set to 0 to change instantly.
///    @tsexample
///    %turbulence = 0.5;     // Set the new turbulence value. Set to 0 to disable turbulence.
///    %speed = 5.0;          // The new speed of the turbulance effect.
///    %seconds = 5.0;        // The length of time over which to make the change.
///    %precipitation.setTurbulence( %turbulence, %speed, %seconds );
///    @endtsexample )
/// 
/// </summary>
public  void setTurbulence(float max, float speed, float seconds){
TorqueScriptTemplate.m_ts.fnPrecipitation_setTurbulence(_mSimObjectId, max, speed, seconds);
}
}}
