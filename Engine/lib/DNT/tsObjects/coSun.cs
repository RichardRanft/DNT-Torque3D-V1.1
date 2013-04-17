
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
    internal class tsObjectConvertercoSun : TypeConverter
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
                return new coSun(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoSun))]
    public class coSun: coSceneObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSun(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSun(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSun(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSun ts, string simobjectid)
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
        public static bool operator !=(coSun ts, string simobjectid)
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
        public static implicit operator string( coSun ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSun(string ts)
            {
            return new coSun(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coSun ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSun(int ts)
            {
            return new coSun(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coSun ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSun(uint ts)
            {
            return new coSun(ts);
            }
public ColorF ambient
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ambient").AsColorF();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ambient", value.AsString());
          }
       }
public float azimuth
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".azimuth").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".azimuth", value.AsString());
          }
       }
public float brightness
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".brightness").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".brightness", value.AsString());
          }
       }
public bool castShadows
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".castShadows").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".castShadows", value.AsString());
          }
       }
public ColorF color
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".color").AsColorF();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".color", value.AsString());
          }
       }
public bool coronaEnabled
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".coronaEnabled").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".coronaEnabled", value.AsString());
          }
       }
public String coronaMaterial
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".coronaMaterial").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".coronaMaterial", value.AsString());
          }
       }
public float coronaScale
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".coronaScale").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".coronaScale", value.AsString());
          }
       }
public ColorF coronaTint
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".coronaTint").AsColorF();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".coronaTint", value.AsString());
          }
       }
public bool coronaUseLightColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".coronaUseLightColor").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".coronaUseLightColor", value.AsString());
          }
       }
public float elevation
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".elevation").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".elevation", value.AsString());
          }
       }
public float flareScale
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".flareScale").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".flareScale", value.AsString());
          }
       }
public coLightFlareData flareType
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".flareType");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".flareType", value.ToString());
          }
       }
/// <summary>
/// (Sun, animate, void, 7, 7, animate( F32 duration, F32 startAzimuth, F32 endAzimuth, F32 startElevation, F32 endElevation ))
/// 
/// </summary>
public  void animate(string a2, string a3, string a4, string a5, string a6){
TorqueScriptTemplate.m_ts.fnSun_animate(_mSimObjectId, a2, a3, a4, a5, a6);
}
/// <summary>
/// (Sun, apply, void, 2, 2, )
/// 
/// </summary>
public  void apply(){
TorqueScriptTemplate.m_ts.fnSun_apply(_mSimObjectId);
}
}}
