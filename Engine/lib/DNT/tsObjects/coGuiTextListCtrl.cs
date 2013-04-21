
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
    internal class tsObjectConvertercoGuiTextListCtrl : TypeConverter
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
                return new coGuiTextListCtrl(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoGuiTextListCtrl))]
    public class coGuiTextListCtrl: coGuiArrayCtrl
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiTextListCtrl(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiTextListCtrl(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiTextListCtrl(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiTextListCtrl ts, string simobjectid)
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
        public static bool operator !=(coGuiTextListCtrl ts, string simobjectid)
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
        public static implicit operator string( coGuiTextListCtrl ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiTextListCtrl(string ts)
            {
            return new coGuiTextListCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coGuiTextListCtrl ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiTextListCtrl(int ts)
            {
            return new coGuiTextListCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coGuiTextListCtrl ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiTextListCtrl(uint ts)
            {
            return new coGuiTextListCtrl(ts);
            }
public bool clipColumnText
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".clipColumnText").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".clipColumnText", value.AsString());
          }
       }
public VectorInt  columns
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".columns").AsVectorInt ();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".columns", value.AsString());
          }
       }
public bool fitParentWidth
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fitParentWidth").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fitParentWidth", value.AsString());
          }
       }
/// <summary>
/// ,-1),
///    @brief Adds a new row at end of the list with the defined id and text.
///    If index is used, then the new row is inserted at the row location of 'index'.
///    @param id Id of the new row.
///    @param text Text to display at the new row.
///    @param index Index to insert the new row at. If not used, new row will be placed at the end of the list.
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Define the text to display
///    %text = \"Display Text\"
///    // Define the index (optional)
///    %index = \"2\"
///    // Inform the GuiTextListCtrl control to add the new row with the defined information.
///    %rowIndex = %thisGuiTextListCtrl.addRow(%id,%text,%index);
///    @endtsexample
///    @return Returns the row index of the new row. If 'index' was defined, then this just returns the number of rows in the list.
///    @see References)
/// 
/// </summary>
public  int addRow(int id, string text, int index){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_addRow(_mSimObjectId, id, text, index);
}
/// <summary>
/// @brief Clear the list.
///    @tsexample
///    // Inform the GuiTextListCtrl control to clear its contents
///    %thisGuiTextListCtrl.clear();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  new  void clear(){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_clear(_mSimObjectId);
}
/// <summary>
/// @brief Set the selection to nothing.
///    @tsexample
///    // Deselect anything that is currently selected
///    %thisGuiTextListCtrl.clearSelection();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void clearSelection(){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_clearSelection(_mSimObjectId);
}
/// <summary>
/// @brief Find needle in the list, and return the row number it was found in.
///    @param needle Text to find in the list.
///    @tsexample
///    // Define the text to find in the list
///    %needle = \"Text To Find\";
///    // Request the row number that contains the defined text to find
///    %rowNumber = %thisGuiTextListCtrl.findTextIndex(%needle);
///    @endtsexample
///    @return Row number that the defined text was found in,
///    @see GuiControl)
/// 
/// </summary>
public  int findTextIndex(string needle){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_findTextIndex(_mSimObjectId, needle);
}
/// <summary>
/// @brief Get the row ID for an index.
///    @param index Index to get the RowID at
///    @tsexample
///    // Define the index
///    %index = \"3\";
///    // Request the row ID at the defined index
///    %rowId = %thisGuiTextListCtrl.getRowId(%index);
///    @endtsexample
///    @return RowId at the defined index.
///    @see GuiControl)
/// 
/// </summary>
public  int getRowId(int index){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_getRowId(_mSimObjectId, index);
}
/// <summary>
/// @brief Get the row number for a specified id.
///    @param id Id to get the row number at
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Request the row number from the GuiTextListCtrl control at the defined id.
///    %rowNumber = %thisGuiTextListCtrl.getRowNumById(%id);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  int getRowNumById(int id){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_getRowNumById(_mSimObjectId, id);
}
/// <summary>
/// @brief Get the text of the row with the specified index.
///    @param index Row index to acquire the text at.
///    @tsexample
///    // Define the row index
///    %index = \"5\";
///    // Request the text from the row at the defined index
///    %rowText = %thisGuiTextListCtrl.getRowText(%index);
///    @endtsexample
///    @return Text at the defined row index.
///    @see GuiControl)
/// 
/// </summary>
public  string getRowText(int index){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_getRowText(_mSimObjectId, index);
}
/// <summary>
/// @brief Get the text of a row with the specified id.
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Inform the GuiTextListCtrl control to return the text at the defined row id
///    %rowText = %thisGuiTextListCtrl.getRowTextById(%id);
///    @endtsexample
///    @return Row text at the requested row id.
///    @see GuiControl)
/// 
/// </summary>
public  string getRowTextById(int id){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_getRowTextById(_mSimObjectId, id);
}
/// <summary>
/// @brief Get the ID of the currently selected item.
///    @tsexample
///    // Acquire the ID of the selected item in the list.
///    %id = %thisGuiTextListCtrl.getSelectedId();
///    @endtsexample
///    @return The id of the selected item in the list.
///    @see GuiControl)
/// 
/// </summary>
public  int getSelectedId(){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_getSelectedId(_mSimObjectId);
}
/// <summary>
/// @brief Returns the selected row index (not the row ID).
///    @tsexample
///    // Acquire the selected row index
///    %rowIndex = %thisGuiTextListCtrl.getSelectedRow();
///    @endtsexample
///    @return Index of the selected row
///    @see GuiControl)
/// 
/// </summary>
public  int getSelectedRow(){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_getSelectedRow(_mSimObjectId);
}
/// <summary>
/// @brief Check if the specified row is currently active or not.
///    @param rowNum Row number to check the active state.
///    @tsexample
///    // Define the row number
///    %rowNum = \"5\";
///    // Request the active state of the defined row number from the GuiTextListCtrl control.
///    %rowActiveState = %thisGuiTextListCtrl.isRowActive(%rowNum);
///    @endtsexample
///    @return Active state of the defined row number.
///    @see GuiControl)
/// 
/// </summary>
public  bool isRowActive(int rowNum){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_isRowActive(_mSimObjectId, rowNum);
}
/// <summary>
/// @brief Remove a row from the table, based on its index.
///    @param index Row index to remove from the list.
///    @tsexample
///    // Define the row index
///    %index = \"4\";
///    // Inform the GuiTextListCtrl control to remove the row at the defined row index
///    %thisGuiTextListCtrl.removeRow(%index);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void removeRow(int index){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_removeRow(_mSimObjectId, index);
}
/// <summary>
/// @brief Remove row with the specified id.
///    @param id Id to remove the row entry at
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Inform the GuiTextListCtrl control to remove the row at the defined id
///    %thisGuiTextListCtrl.removeRowById(%id);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void removeRowById(int id){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_removeRowById(_mSimObjectId, id);
}
/// <summary>
/// @brief Get the number of rows.
///    @tsexample
///    // Get the number of rows in the list
///    %rowCount = %thisGuiTextListCtrl.rowCount();
///    @endtsexample
///    @return Number of rows in the list.
///    @see GuiControl)
/// 
/// </summary>
public  int rowCount(){
return TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_rowCount(_mSimObjectId);
}
/// <summary>
/// @brief Scroll so the specified row is visible
///    @param rowNum Row number to make visible
///    @tsexample
///    // Define the row number to make visible
///    %rowNum = \"4\";
///    // Inform the GuiTextListCtrl control to scroll the list so the defined rowNum is visible.
///    %thisGuiTextListCtrl.scrollVisible(%rowNum);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void scrollVisible(int rowNum){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_scrollVisible(_mSimObjectId, rowNum);
}
/// <summary>
/// @brief Mark a specified row as active/not.
///    @param rowNum Row number to change the active state.
///    @param active Boolean active state to set the row number.
///    @tsexample
///    // Define the row number
///    %rowNum = \"4\";
///    // Define the boolean active state
///    %active = \"true\";
///    // Informthe GuiTextListCtrl control to set the defined active state at the defined row number.
///    %thisGuiTextListCtrl.setRowActive(%rowNum,%active);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void setRowActive(int rowNum, bool active){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_setRowActive(_mSimObjectId, rowNum, active);
}
/// <summary>
/// @brief Sets the text at the defined id.
///    @param id Id to change.
///    @param text Text to use at the Id.
///    @tsexample
///    // Define the id
///    %id = \"4\";
///    // Define the text
///    %text = \"Text To Display\";
///    // Inform the GuiTextListCtrl control to display the defined text at the defined id
///    %thisGuiTextListCtrl.setRowById(%id,%text);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void setRowById(int id, string text){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_setRowById(_mSimObjectId, id, text);
}
/// <summary>
/// @brief Finds the specified entry by id, then marks its row as selected.
///    @param id Entry within the text list to make selected.
///    @tsexample
///    // Define the id
///    %id = \"5\";
///    // Inform the GuiTextListCtrl control to set the defined id entry as selected
///    %thisGuiTextListCtrl.setSelectedById(%id);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void setSelectedById(int id){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_setSelectedById(_mSimObjectId, id);
}
/// <summary>
/// @briefSelects the specified row.
///    @param rowNum Row number to set selected.
///    @tsexample
///    // Define the row number to set selected
///    %rowNum = \"4\";
///    %guiTextListCtrl.setSelectedRow(%rowNum);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void setSelectedRow(int rowNum){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_setSelectedRow(_mSimObjectId, rowNum);
}
/// <summary>
/// @brief Performs a standard (alphabetical) sort on the values in the specified column.
///    @param columnId Column ID to perform the sort on.
///    @param increasing If false, sort will be performed in reverse.
///    @tsexample
///    // Define the columnId
///    %id = \"1\";
///    // Define if we are increasing or not
///    %increasing = \"false\";
///    // Inform the GuiTextListCtrl to perform the sort operation
///    %thisGuiTextListCtrl.sort(%id,%increasing);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void sort(int columnId, bool increasing){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_sort(_mSimObjectId, columnId, increasing);
}
/// <summary>
/// @brief Perform a numerical sort on the values in the specified column.
///    Detailed description
///    @param columnId Column ID to perform the sort on.
///    @param increasing If false, sort will be performed in reverse.
///    @tsexample
///    // Define the columnId
///    %id = \"1\";
///    // Define if we are increasing or not
///    %increasing = \"false\";
///    // Inform the GuiTextListCtrl to perform the sort operation
///    %thisGuiTextListCtrl.sortNumerical(%id,%increasing);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void sortNumerical(int columnID, bool increasing){
TorqueScriptTemplate.m_ts.fnGuiTextListCtrl_sortNumerical(_mSimObjectId, columnID, increasing);
}
}}
