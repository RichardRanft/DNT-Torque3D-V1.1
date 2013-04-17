
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
    internal class tsObjectConvertercofxShapeReplicator : TypeConverter
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
                return new cofxShapeReplicator(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercofxShapeReplicator))]
    public class cofxShapeReplicator: coSceneObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public cofxShapeReplicator(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public cofxShapeReplicator(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public cofxShapeReplicator(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(cofxShapeReplicator ts, string simobjectid)
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
        public static bool operator !=(cofxShapeReplicator ts, string simobjectid)
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
        public static implicit operator string( cofxShapeReplicator ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator cofxShapeReplicator(string ts)
            {
            return new cofxShapeReplicator(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( cofxShapeReplicator ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator cofxShapeReplicator(int ts)
            {
            return new cofxShapeReplicator(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( cofxShapeReplicator ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator cofxShapeReplicator(uint ts)
            {
            return new cofxShapeReplicator(ts);
            }
public bool AlignToTerrain
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".AlignToTerrain").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".AlignToTerrain", value.AsString());
          }
       }
public int AllowedTerrainSlope
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".AllowedTerrainSlope").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".AllowedTerrainSlope", value.AsString());
          }
       }
public bool AllowOnInteriors
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".AllowOnInteriors").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".AllowOnInteriors", value.AsString());
          }
       }
public bool AllowOnStatics
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".AllowOnStatics").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".AllowOnStatics", value.AsString());
          }
       }
public bool AllowOnTerrain
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".AllowOnTerrain").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".AllowOnTerrain", value.AsString());
          }
       }
public bool AllowOnWater
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".AllowOnWater").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".AllowOnWater", value.AsString());
          }
       }
public bool AllowWaterSurface
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".AllowWaterSurface").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".AllowWaterSurface", value.AsString());
          }
       }
public bool HideReplications
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".HideReplications").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".HideReplications", value.AsString());
          }
       }
public int InnerRadiusX
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".InnerRadiusX").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".InnerRadiusX", value.AsString());
          }
       }
public int InnerRadiusY
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".InnerRadiusY").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".InnerRadiusY", value.AsString());
          }
       }
public bool Interactions
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".Interactions").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".Interactions", value.AsString());
          }
       }
public int OffsetZ
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".OffsetZ").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".OffsetZ", value.AsString());
          }
       }
public int OuterRadiusX
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".OuterRadiusX").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".OuterRadiusX", value.AsString());
          }
       }
public int OuterRadiusY
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".OuterRadiusY").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".OuterRadiusY", value.AsString());
          }
       }
public int PlacementAreaHeight
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".PlacementAreaHeight").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".PlacementAreaHeight", value.AsString());
          }
       }
public ColorF PlacementColour
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".PlacementColour").AsColorF();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".PlacementColour", value.AsString());
          }
       }
public int Seed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".Seed").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".Seed", value.AsString());
          }
       }
public int ShapeCount
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ShapeCount").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ShapeCount", value.AsString());
          }
       }
public String ShapeFile
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ShapeFile").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ShapeFile", value.AsString());
          }
       }
public int ShapeRetries
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ShapeRetries").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ShapeRetries", value.AsString());
          }
       }
public Point3F ShapeRotateMax
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ShapeRotateMax").AsPoint3F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ShapeRotateMax", value.AsString());
          }
       }
public Point3F ShapeRotateMin
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ShapeRotateMin").AsPoint3F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ShapeRotateMin", value.AsString());
          }
       }
public Point3F ShapeScaleMax
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ShapeScaleMax").AsPoint3F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ShapeScaleMax", value.AsString());
          }
       }
public Point3F ShapeScaleMin
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ShapeScaleMin").AsPoint3F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ShapeScaleMin", value.AsString());
          }
       }
public bool ShowPlacementArea
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ShowPlacementArea").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ShowPlacementArea", value.AsString());
          }
       }
public Point3F TerrainAlignment
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".TerrainAlignment").AsPoint3F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".TerrainAlignment", value.AsString());
          }
       }
}}
