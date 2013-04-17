
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
    internal class tsObjectConvertercoEditTSCtrl : TypeConverter
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
                return new coEditTSCtrl(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoEditTSCtrl))]
    public class coEditTSCtrl: coGuiTSCtrl
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coEditTSCtrl(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coEditTSCtrl(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coEditTSCtrl(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coEditTSCtrl ts, string simobjectid)
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
        public static bool operator !=(coEditTSCtrl ts, string simobjectid)
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
        public static implicit operator string( coEditTSCtrl ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coEditTSCtrl(string ts)
            {
            return new coEditTSCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coEditTSCtrl ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coEditTSCtrl(int ts)
            {
            return new coEditTSCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coEditTSCtrl ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coEditTSCtrl(uint ts)
            {
            return new coEditTSCtrl(ts);
            }
public bool allowBorderMove
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".allowBorderMove").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".allowBorderMove", value.AsString());
          }
       }
public int borderMovePixelSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".borderMovePixelSize").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".borderMovePixelSize", value.AsString());
          }
       }
public float borderMoveSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".borderMoveSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".borderMoveSpeed", value.AsString());
          }
       }
public int consoleCircleSegments
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".consoleCircleSegments").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".consoleCircleSegments", value.AsString());
          }
       }
public ColorI consoleFillColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".consoleFillColor").AsColorI();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".consoleFillColor", value.AsString());
          }
       }
public ColorI consoleFrameColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".consoleFrameColor").AsColorI();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".consoleFrameColor", value.AsString());
          }
       }
public int consoleLineWidth
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".consoleLineWidth").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".consoleLineWidth", value.AsString());
          }
       }
public int consoleSphereLevel
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".consoleSphereLevel").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".consoleSphereLevel", value.AsString());
          }
       }
public coGizmoProfile gizmoProfile
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".gizmoProfile");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".gizmoProfile", value.ToString());
          }
       }
public ColorI gridColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".gridColor").AsColorI();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".gridColor", value.AsString());
          }
       }
public ColorI gridMinorTickColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".gridMinorTickColor").AsColorI();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".gridMinorTickColor", value.AsString());
          }
       }
public ColorI gridOriginColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".gridOriginColor").AsColorI();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".gridOriginColor", value.AsString());
          }
       }
public float gridSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".gridSize").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".gridSize", value.AsString());
          }
       }
public ColorI missionAreaFillColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".missionAreaFillColor").AsColorI();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".missionAreaFillColor", value.AsString());
          }
       }
public ColorI missionAreaFrameColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".missionAreaFrameColor").AsColorI();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".missionAreaFrameColor", value.AsString());
          }
       }
public float missionAreaHeightAdjust
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".missionAreaHeightAdjust").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".missionAreaHeightAdjust", value.AsString());
          }
       }
public bool renderMissionArea
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderMissionArea").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderMissionArea", value.AsString());
          }
       }
public bool renderOrthoGrid
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderOrthoGrid").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderOrthoGrid", value.AsString());
          }
       }
public float renderOrthoGridPixelBias
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderOrthoGridPixelBias").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderOrthoGridPixelBias", value.AsString());
          }
       }
/// <summary>
///  )
/// 
/// </summary>
public  int getDisplayType(){
return TorqueScriptTemplate.m_ts.fnEditTSCtrl_getDisplayType(_mSimObjectId);
}
/// <summary>
///  )
/// 
/// </summary>
public  int getGizmo(){
return TorqueScriptTemplate.m_ts.fnEditTSCtrl_getGizmo(_mSimObjectId);
}
/// <summary>
/// Return the FOV for orthographic views. )
/// 
/// </summary>
public  float getOrthoFOV(){
return TorqueScriptTemplate.m_ts.fnEditTSCtrl_getOrthoFOV(_mSimObjectId);
}
/// <summary>
///  )
/// 
/// </summary>
public  bool isMiddleMouseDown(){
return TorqueScriptTemplate.m_ts.fnEditTSCtrl_isMiddleMouseDown(_mSimObjectId);
}
/// <summary>
///  )
/// 
/// </summary>
public  void renderBox(Point3F pos, Point3F size){
TorqueScriptTemplate.m_ts.fnEditTSCtrl_renderBox(_mSimObjectId, pos.AsString(), size.AsString());
}
/// <summary>
///  )
/// 
/// </summary>
public  void renderCircle(Point3F pos, Point3F normal, float radius, int segments){
TorqueScriptTemplate.m_ts.fnEditTSCtrl_renderCircle(_mSimObjectId, pos.AsString(), normal.AsString(), radius, segments);
}
/// <summary>
///  )
/// 
/// </summary>
public  void renderLine(Point3F start, Point3F end, float lineWidth){
TorqueScriptTemplate.m_ts.fnEditTSCtrl_renderLine(_mSimObjectId, start.AsString(), end.AsString(), lineWidth);
}
/// <summary>
///  )
/// 
/// </summary>
public  void renderSphere(Point3F pos, float radius, int sphereLevel){
TorqueScriptTemplate.m_ts.fnEditTSCtrl_renderSphere(_mSimObjectId, pos.AsString(), radius, sphereLevel);
}
/// <summary>
///  )
/// 
/// </summary>
public  void renderTriangle(Point3F a, Point3F b, Point3F c){
TorqueScriptTemplate.m_ts.fnEditTSCtrl_renderTriangle(_mSimObjectId, a.AsString(), b.AsString(), c.AsString());
}
/// <summary>
///  )
/// 
/// </summary>
public  void setDisplayType(int displayType){
TorqueScriptTemplate.m_ts.fnEditTSCtrl_setDisplayType(_mSimObjectId, displayType);
}
/// <summary>
/// Set the FOV for to use for orthographic views. )
/// 
/// </summary>
public  void setOrthoFOV(float fov){
TorqueScriptTemplate.m_ts.fnEditTSCtrl_setOrthoFOV(_mSimObjectId, fov);
}
}}