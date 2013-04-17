
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
    internal class tsObjectConvertercoGuiGraphCtrl : TypeConverter
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
                return new coGuiGraphCtrl(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoGuiGraphCtrl))]
    public class coGuiGraphCtrl: coGuiControl
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiGraphCtrl(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiGraphCtrl(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiGraphCtrl(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiGraphCtrl ts, string simobjectid)
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
        public static bool operator !=(coGuiGraphCtrl ts, string simobjectid)
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
        public static implicit operator string( coGuiGraphCtrl ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiGraphCtrl(string ts)
            {
            return new coGuiGraphCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coGuiGraphCtrl ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiGraphCtrl(int ts)
            {
            return new coGuiGraphCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coGuiGraphCtrl ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiGraphCtrl(uint ts)
            {
            return new coGuiGraphCtrl(ts);
            }
public float centerY
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".centerY").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".centerY", value.AsString());
          }
       }
public ColorF plotColor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".plotColor").AsColorF();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".plotColor", value.AsString());
          }
       }
public int plotInterval
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".plotInterval").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".plotInterval", value.AsString());
          }
       }
public int plotType
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".plotType").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".plotType", value.AsString());
          }
       }
public String plotVariable
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".plotVariable").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".plotVariable", value.AsString());
          }
       }
/// <summary>
/// Sets up the given plotting curve to automatically plot the value of the @a variable with a 
///    frequency of @a updateFrequency.
///    @param plotId Index of the plotting curve.  Must be 0=plotId6.
///    @param variable Name of the global variable.
///    @param updateFrequency Frequency with which to add new data points to the plotting curve (in milliseconds).
///    @tsexample
///    // Plot FPS counter at 1 second intervals.
///    %graph.addAutoPlot( 0, \"fps::real\", 1000 );
///    @endtsexample )
/// 
/// </summary>
public  void addAutoPlot(int plotId, string variable, int updateFrequency){
TorqueScriptTemplate.m_ts.fnGuiGraphCtrl_addAutoPlot(_mSimObjectId, plotId, variable, updateFrequency);
}
/// <summary>
/// Add a data point to the plot's curve.
///    @param plotId Index of the plotting curve to which to add the data point.  Must be 0=plotId6.
///    @param value Value of the data point to add to the curve.
///    @note Data values are added to the @b left end of the plotting curve.
///    @note A maximum number of 200 data points can be added to any single plotting curve at any one time.  If 
///       this limit is exceeded, data points on the right end of the curve are culled. )
/// 
/// </summary>
public  void addDatum(int plotId, float value){
TorqueScriptTemplate.m_ts.fnGuiGraphCtrl_addDatum(_mSimObjectId, plotId, value);
}
/// <summary>
/// Get a data point on the given plotting curve.
///    @param plotId Index of the plotting curve from which to fetch the data point.  Must be 0=plotId6.
///    @param index Index of the data point on the curve.
///    @return The value of the data point or -1 if @a plotId or @a index are out of range. )
/// 
/// </summary>
public  float getDatum(int plotId, int index){
return TorqueScriptTemplate.m_ts.fnGuiGraphCtrl_getDatum(_mSimObjectId, plotId, index);
}
/// <summary>
/// Stop automatic variable plotting for the given curve.
///    @param plotId Index of the plotting curve.  Must be 0=plotId6. )
/// 
/// </summary>
public  void removeAutoPlot(int plotId){
TorqueScriptTemplate.m_ts.fnGuiGraphCtrl_removeAutoPlot(_mSimObjectId, plotId);
}
/// <summary>
/// Change the charting type of the given plotting curve.
///    @param plotId Index of the plotting curve.  Must be 0=plotId6.
///    @param graphType Charting type to use for the curve.
///    @note Instead of calling this method, you can directly assign to #plotType. )
/// 
/// </summary>
public  void setGraphType(int plotId, GuiGraphType graphType){
TorqueScriptTemplate.m_ts.fnGuiGraphCtrl_setGraphType(_mSimObjectId, plotId, (int)graphType );
}
}}
