
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
    internal class tsObjectConvertercoDebrisData : TypeConverter
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
                return new coDebrisData(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoDebrisData))]
    public class coDebrisData: coGameBaseData
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coDebrisData(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coDebrisData(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coDebrisData(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coDebrisData ts, string simobjectid)
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
        public static bool operator !=(coDebrisData ts, string simobjectid)
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
        public static implicit operator string( coDebrisData ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coDebrisData(string ts)
            {
            return new coDebrisData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coDebrisData ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coDebrisData(int ts)
            {
            return new coDebrisData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coDebrisData ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coDebrisData(uint ts)
            {
            return new coDebrisData(ts);
            }
public float baseRadius
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".baseRadius").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".baseRadius", value.AsString());
          }
       }
public int bounceVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".bounceVariance").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".bounceVariance", value.AsString());
          }
       }
public float elasticity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".elasticity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".elasticity", value.AsString());
          }
       }
public coParticleEmitterData emitters
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".emitters");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".emitters", value.ToString());
          }
       }
public bool explodeOnMaxBounce
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".explodeOnMaxBounce").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".explodeOnMaxBounce", value.AsString());
          }
       }
public coExplosionData explosion
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".explosion");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".explosion", value.ToString());
          }
       }
public bool fade
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fade").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fade", value.AsString());
          }
       }
public float friction
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".friction").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".friction", value.AsString());
          }
       }
public float gravModifier
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".gravModifier").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".gravModifier", value.AsString());
          }
       }
public bool ignoreWater
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ignoreWater").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ignoreWater", value.AsString());
          }
       }
public float lifetime
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lifetime").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lifetime", value.AsString());
          }
       }
public float lifetimeVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lifetimeVariance").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lifetimeVariance", value.AsString());
          }
       }
public float maxSpinSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxSpinSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxSpinSpeed", value.AsString());
          }
       }
public float minSpinSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".minSpinSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".minSpinSpeed", value.AsString());
          }
       }
public int numBounces
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".numBounces").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".numBounces", value.AsString());
          }
       }
public String shapeFile
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".shapeFile").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".shapeFile", value.AsString());
          }
       }
public bool snapOnMaxBounce
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".snapOnMaxBounce").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".snapOnMaxBounce", value.AsString());
          }
       }
public bool staticOnMaxBounce
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".staticOnMaxBounce").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".staticOnMaxBounce", value.AsString());
          }
       }
public float terminalVelocity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".terminalVelocity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".terminalVelocity", value.AsString());
          }
       }
public String texture
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".texture").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".texture", value.AsString());
          }
       }
public bool useRadiusMass
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".useRadiusMass").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".useRadiusMass", value.AsString());
          }
       }
public float velocity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".velocity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".velocity", value.AsString());
          }
       }
public float velocityVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".velocityVariance").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".velocityVariance", value.AsString());
          }
       }
}}
