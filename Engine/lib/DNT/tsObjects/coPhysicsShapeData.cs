
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
    internal class tsObjectConvertercoPhysicsShapeData : TypeConverter
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
                return new coPhysicsShapeData(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoPhysicsShapeData))]
    public class coPhysicsShapeData: coGameBaseData
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPhysicsShapeData(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPhysicsShapeData(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coPhysicsShapeData(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coPhysicsShapeData ts, string simobjectid)
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
        public static bool operator !=(coPhysicsShapeData ts, string simobjectid)
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
        public static implicit operator string( coPhysicsShapeData ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPhysicsShapeData(string ts)
            {
            return new coPhysicsShapeData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coPhysicsShapeData ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPhysicsShapeData(int ts)
            {
            return new coPhysicsShapeData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coPhysicsShapeData ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coPhysicsShapeData(uint ts)
            {
            return new coPhysicsShapeData(ts);
            }
public float angularDamping
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".angularDamping").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".angularDamping", value.AsString());
          }
       }
public float angularSleepThreshold
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".angularSleepThreshold").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".angularSleepThreshold", value.AsString());
          }
       }
public float buoyancyDensity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".buoyancyDensity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".buoyancyDensity", value.AsString());
          }
       }
public coPhysicsDebrisData debris
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".debris");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".debris", value.ToString());
          }
       }
public coPhysicsShapeData destroyedShape
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".destroyedShape");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".destroyedShape", value.ToString());
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
public float linearDamping
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".linearDamping").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".linearDamping", value.AsString());
          }
       }
public float linearSleepThreshold
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".linearSleepThreshold").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".linearSleepThreshold", value.AsString());
          }
       }
public float mass
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".mass").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".mass", value.AsString());
          }
       }
public float restitution
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".restitution").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".restitution", value.AsString());
          }
       }
public String shapeName
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".shapeName").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".shapeName", value.AsString());
          }
       }
public PhysicsShapeData__SimType simType
       {
       get
          {          return (PhysicsShapeData__SimType)Enum.Parse(typeof(PhysicsShapeData__SimType), dnTorque.self.GetVar(_mSimObjectId + ".simType"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".simType", value.ToString());
          }
       }
public float staticFriction
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".staticFriction").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".staticFriction", value.AsString());
          }
       }
public float waterDampingScale
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".waterDampingScale").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".waterDampingScale", value.AsString());
          }
       }
}}