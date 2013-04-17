
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
    internal class tsObjectConvertercoGuiGameListMenuCtrl : TypeConverter
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
                return new coGuiGameListMenuCtrl(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoGuiGameListMenuCtrl))]
    public class coGuiGameListMenuCtrl: coGuiControl
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiGameListMenuCtrl(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiGameListMenuCtrl(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiGameListMenuCtrl(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiGameListMenuCtrl ts, string simobjectid)
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
        public static bool operator !=(coGuiGameListMenuCtrl ts, string simobjectid)
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
        public static implicit operator string( coGuiGameListMenuCtrl ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiGameListMenuCtrl(string ts)
            {
            return new coGuiGameListMenuCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coGuiGameListMenuCtrl ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiGameListMenuCtrl(int ts)
            {
            return new coGuiGameListMenuCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coGuiGameListMenuCtrl ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiGameListMenuCtrl(uint ts)
            {
            return new coGuiGameListMenuCtrl(ts);
            }
public String callbackOnA
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".callbackOnA").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".callbackOnA", value.AsString());
          }
       }
public String callbackOnB
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".callbackOnB").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".callbackOnB", value.AsString());
          }
       }
public String callbackOnX
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".callbackOnX").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".callbackOnX", value.AsString());
          }
       }
public String callbackOnY
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".callbackOnY").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".callbackOnY", value.AsString());
          }
       }
public bool debugRender
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".debugRender").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".debugRender", value.AsString());
          }
       }
/// <summary>
/// Activates the current row. The script callback of  the current row will be called (if it has one). )
/// 
/// </summary>
public  void activateRow(){
TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_activateRow(_mSimObjectId);
}
/// <summary>
/// Add a row to the list control.
///    @param label The text to display on the row as a label.
///    @param callback Name of a script function to use as a callback when this row is activated.
///    @param icon [optional] Index of the icon to use as a marker.
///    @param yPad [optional] An extra amount of height padding before the row. Does nothing on the first row.
///    @param useHighlightIcon [optional] Does this row use the highlight icon?.
///    @param enabled [optional] If this row is initially enabled. )
/// 
/// </summary>
public  void addRow(string label, string callback, int icon, int yPad, bool useHighlightIcon, bool enabled){
TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_addRow(_mSimObjectId, label, callback, icon, yPad, useHighlightIcon, enabled);
}
/// <summary>
/// Gets the number of rows on the control.
///    @return (int) The number of rows on the control. )
/// 
/// </summary>
public  int getRowCount(){
return TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_getRowCount(_mSimObjectId);
}
/// <summary>
/// Gets the label displayed on the specified row.
///    @param row Index of the row to get the label of.
///    @return The label for the row. )
/// 
/// </summary>
public  string getRowLabel(int row){
return TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_getRowLabel(_mSimObjectId, row);
}
/// <summary>
/// Gets the index of the currently selected row.
///    @return Index of the selected row. )
/// 
/// </summary>
public  int getSelectedRow(){
return TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_getSelectedRow(_mSimObjectId);
}
/// <summary>
/// Determines if the specified row is enabled or disabled.
///    @param row The row to set the enabled status of.
///    @return True if the specified row is enabled. False if the row is not enabled or the given index was not valid. )
/// 
/// </summary>
public  bool isRowEnabled(int row){
return TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_isRowEnabled(_mSimObjectId, row);
}
/// <summary>
/// Sets a row's enabled status according to the given parameters.
///    @param row The index to check for validity.
///    @param enabled Indicate true to enable the row or false to disable it. )
/// 
/// </summary>
public  void setRowEnabled(int row, bool enabled){
TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_setRowEnabled(_mSimObjectId, row, enabled);
}
/// <summary>
/// Sets the label on the given row.
///    @param row Index of the row to set the label on.
///    @param label Text to set as the label of the row. )
/// 
/// </summary>
public  void setRowLabel(int row, string label){
TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_setRowLabel(_mSimObjectId, row, label);
}
/// <summary>
/// Sets the selected row. Only rows that are enabled can be selected.
///    @param row Index of the row to set as selected. )
/// 
/// </summary>
public  void setSelected(int row){
TorqueScriptTemplate.m_ts.fnGuiGameListMenuCtrl_setSelected(_mSimObjectId, row);
}
}}
