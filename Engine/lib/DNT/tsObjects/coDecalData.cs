
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
    internal class tsObjectConvertercoDecalData : TypeConverter
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
                return new coDecalData(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoDecalData))]
    public class coDecalData: coSimDataBlock
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coDecalData(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coDecalData(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coDecalData(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coDecalData ts, string simobjectid)
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
        public static bool operator !=(coDecalData ts, string simobjectid)
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
        public static implicit operator string( coDecalData ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coDecalData(string ts)
            {
            return new coDecalData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coDecalData ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coDecalData(int ts)
            {
            return new coDecalData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coDecalData ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coDecalData(uint ts)
            {
            return new coDecalData(ts);
            }
public float clippingAngle
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".clippingAngle").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".clippingAngle", value.AsString());
          }
       }
public float fadeEndPixelSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeEndPixelSize").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeEndPixelSize", value.AsString());
          }
       }
public float fadeStartPixelSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeStartPixelSize").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeStartPixelSize", value.AsString());
          }
       }
public int fadeTime
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeTime").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeTime", value.AsString());
          }
       }
public int frame
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".frame").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".frame", value.AsString());
          }
       }
public int lifeSpan
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lifeSpan").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lifeSpan", value.AsString());
          }
       }
public String material
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".material").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".material", value.AsString());
          }
       }
public bool randomize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".randomize").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".randomize", value.AsString());
          }
       }
public sbyte renderPriority
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderPriority").AsSbyte();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderPriority", value.AsString());
          }
       }
public float size
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".size").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".size", value.AsString());
          }
       }
public int texCols
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".texCols").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".texCols", value.AsString());
          }
       }
public int texRows
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".texRows").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".texRows", value.AsString());
          }
       }
public int textureCoordCount
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".textureCoordCount").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".textureCoordCount", value.AsString());
          }
       }
public RectF textureCoords
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".textureCoords").AsRectF();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".textureCoords", value.AsString());
          }
       }
/// <summary>
/// Recompute the imagemap sub-texture rectangles for this DecalData.
///    @tsexample
///    // Inform the decal object to reload its imagemap and frame data.
///    %decalData.texRows = 4;
///    %decalData.postApply();
///    @endtsexample)
/// 
/// </summary>
public  void postApply(){
TorqueScriptTemplate.m_ts.fnDecalData_postApply(_mSimObjectId);
}
}}
