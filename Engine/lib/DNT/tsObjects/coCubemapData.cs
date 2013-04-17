
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
    internal class tsObjectConvertercoCubemapData : TypeConverter
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
                return new coCubemapData(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoCubemapData))]
    public class coCubemapData: coSimObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coCubemapData(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coCubemapData(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coCubemapData(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coCubemapData ts, string simobjectid)
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
        public static bool operator !=(coCubemapData ts, string simobjectid)
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
        public static implicit operator string( coCubemapData ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coCubemapData(string ts)
            {
            return new coCubemapData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coCubemapData ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coCubemapData(int ts)
            {
            return new coCubemapData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coCubemapData ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coCubemapData(uint ts)
            {
            return new coCubemapData(ts);
            }
public String cubeFace
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".cubeFace").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".cubeFace", value.AsString());
          }
       }
public bool dynamic
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dynamic").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dynamic", value.AsString());
          }
       }
public float dynamicFarDist
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dynamicFarDist").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dynamicFarDist", value.AsString());
          }
       }
public float dynamicNearDist
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dynamicNearDist").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dynamicNearDist", value.AsString());
          }
       }
public int dynamicObjectTypeMask
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dynamicObjectTypeMask").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dynamicObjectTypeMask", value.AsString());
          }
       }
public int dynamicSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dynamicSize").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dynamicSize", value.AsString());
          }
       }
/// <summary>
/// Returns the script filename of where the CubemapData object was 
///    defined.  This is used by the material editor. )
/// 
/// </summary>
public  new  string getFilename(){
return TorqueScriptTemplate.m_ts.fnCubemapData_getFilename(_mSimObjectId);
}
/// <summary>
/// Update the assigned cubemaps faces. )
/// 
/// </summary>
public  void updateFaces(){
TorqueScriptTemplate.m_ts.fnCubemapData_updateFaces(_mSimObjectId);
}
}}
