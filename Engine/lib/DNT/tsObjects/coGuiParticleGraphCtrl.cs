
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
    internal class tsObjectConvertercoGuiParticleGraphCtrl : TypeConverter
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
                return new coGuiParticleGraphCtrl(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoGuiParticleGraphCtrl))]
    public class coGuiParticleGraphCtrl: coGuiControl
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiParticleGraphCtrl(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiParticleGraphCtrl(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coGuiParticleGraphCtrl(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiParticleGraphCtrl ts, string simobjectid)
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
        public static bool operator !=(coGuiParticleGraphCtrl ts, string simobjectid)
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
        public static implicit operator string( coGuiParticleGraphCtrl ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiParticleGraphCtrl(string ts)
            {
            return new coGuiParticleGraphCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coGuiParticleGraphCtrl ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiParticleGraphCtrl(int ts)
            {
            return new coGuiParticleGraphCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coGuiParticleGraphCtrl ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiParticleGraphCtrl(uint ts)
            {
            return new coGuiParticleGraphCtrl(ts);
            }
/// <summary>
/// (GuiParticleGraphCtrl, addPlotPoint, const char*, 5, 6, (int plotID, float x, float y, bool setAdded = true;)
///               Add a data point to the given plot.
/// 			  @return)
/// 
/// </summary>
public  string addPlotPoint(string a2, string a3, string a4, string a5= ""){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_addPlotPoint(_mSimObjectId, a2, a3, a4, a5);
}
/// <summary>
/// (GuiParticleGraphCtrl, changePlotPoint, const char*, 6, 6, (int plotID, int i, float x, float y)
///               Change a data point to the given plot and plot position.
/// 			  @param plotID The plot you want to access
/// 			  @param i The data point.
/// 			  @param x,y The plot position.
/// 			  @return No return value.)
/// 
/// </summary>
public  string changePlotPoint(string a2, string a3, string a4, string a5){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_changePlotPoint(_mSimObjectId, a2, a3, a4, a5);
}
/// <summary>
/// (GuiParticleGraphCtrl, clearAllGraphs, void, 2, 2, ()
///               Clear all of the graphs.
/// 			  @return No return value)
/// 
/// </summary>
public  void clearAllGraphs(){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_clearAllGraphs(_mSimObjectId);
}
/// <summary>
/// (GuiParticleGraphCtrl, clearGraph, void, 3, 3, (int plotID)
///               Clear the graph of the given plot.
/// 			  @return No return value)
/// 
/// </summary>
public  void clearGraph(string a2){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_clearGraph(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, getGraphColor, const char*, 3, 3, (int plotID)
///               Get the color of the graph passed.
/// 			  @return Returns the color of the graph as a string of RGB values formatted as \"R G B\")
/// 
/// </summary>
public  string getGraphColor(string a2){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_getGraphColor(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, getGraphMax, const char*, 3, 3, (int plotID) 
/// 			  Get the maximum values of the graph ranges.
/// 			  @return Returns the maximum of the range formatted as \"x-max y-max\")
/// 
/// </summary>
public  string getGraphMax(string a2){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_getGraphMax(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, getGraphMin, const char*, 3, 3, (int plotID) 
///               Get the minimum values of the graph ranges.
/// 			  @return Returns the minimum of the range formatted as \"x-min y-min\")
/// 
/// </summary>
public  string getGraphMin(string a2){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_getGraphMin(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, getGraphName, const char*, 3, 3, (int plotID) 
///               Get the name of the graph passed.
/// 			  @return Returns the name of the plot)
/// 
/// </summary>
public  string getGraphName(string a2){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_getGraphName(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, getPlotIndex, const char*, 5, 5, (int plotID, float x, float y)
///               Gets the index of the point passed on the plotID passed (graph ID).
/// 			  @param plotID The plot you wish to check.
/// 			  @param x,y The coordinates of the point to get.
/// 			  @return Returns the index of the point.)
/// 
/// </summary>
public  string getPlotIndex(string a2, string a3, string a4){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_getPlotIndex(_mSimObjectId, a2, a3, a4);
}
/// <summary>
/// (GuiParticleGraphCtrl, getPlotPoint, const char*, 4, 4, (int plotID, int samples)
///               Get a data point from the plot specified, samples from the start of the graph.
/// 			  @return The data point ID)
/// 
/// </summary>
public  string getPlotPoint(string a2, string a3){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_getPlotPoint(_mSimObjectId, a2, a3);
}
/// <summary>
/// (GuiParticleGraphCtrl, getSelectedPlot, const char*, 2, 2, () 
///               Gets the selected Plot (a.k.a. graph).
/// 			  @return The plot's ID.)
/// 
/// </summary>
public  string getSelectedPlot(){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_getSelectedPlot(_mSimObjectId);
}
/// <summary>
/// (GuiParticleGraphCtrl, getSelectedPoint, const char*, 2, 2, ()
///               Gets the selected Point on the Plot (a.k.a. graph).
/// 			  @return The last selected point ID)
/// 
/// </summary>
public  string getSelectedPoint(){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_getSelectedPoint(_mSimObjectId);
}
/// <summary>
/// (GuiParticleGraphCtrl, insertPlotPoint, void, 6, 6, (int plotID, int i, float x, float y)
///               Insert a data point to the given plot and plot position.
/// 			  @param plotID The plot you want to access
/// 			  @param i The data point.
/// 			  @param x,y The plot position.
/// 			  @return No return value.)
/// 
/// </summary>
public  void insertPlotPoint(string a2, string a3, string a4, string a5){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_insertPlotPoint(_mSimObjectId, a2, a3, a4, a5);
}
/// <summary>
/// (GuiParticleGraphCtrl, isExistingPoint, const char*, 4, 4, (int plotID, int samples)
///               @return Returns true or false whether or not the point in the plot passed is an existing point.)
/// 
/// </summary>
public  string isExistingPoint(string a2, string a3){
return TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_isExistingPoint(_mSimObjectId, a2, a3);
}
/// <summary>
/// (GuiParticleGraphCtrl, resetSelectedPoint, void, 2, 2, ()
/// 			  This will reset the currently selected point to nothing.
/// 			  @return No return value.)
/// 
/// </summary>
public  void resetSelectedPoint(){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_resetSelectedPoint(_mSimObjectId);
}
/// <summary>
/// (GuiParticleGraphCtrl, setAutoGraphMax, void, 3, 3, (bool autoMax) 
/// 			  Set whether the max will automatically be set when adding points 
/// 			  (ie if you add a value over the current max, the max is increased to that value).
/// 			  @return No return value.)
/// 
/// </summary>
public  void setAutoGraphMax(string a2){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setAutoGraphMax(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, setAutoRemove, void, 3, 3, (bool autoRemove) 
/// 			  Set whether or not a point should be deleted when you drag another one over it.
/// 			  @return No return value.)
/// 
/// </summary>
public  void setAutoRemove(string a2){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setAutoRemove(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, setGraphHidden, void, 4, 4, (int plotID, bool isHidden)
/// 			  Set whether the graph number passed is hidden or not.
/// 			  @return No return value.)
/// 
/// </summary>
public  void setGraphHidden(string a2, string a3){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setGraphHidden(_mSimObjectId, a2, a3);
}
/// <summary>
/// (GuiParticleGraphCtrl, setGraphMax, void, 5, 5, (int plotID, float maxX, float maxY) 
/// 			  Set the max values of the graph of plotID.
/// 			  @param plotID The plot to modify
/// 			  @param maxX,maxY The maximum bound of the value range.
/// 			  @return No return value.)
/// 
/// </summary>
public  void setGraphMax(string a2, string a3, string a4){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setGraphMax(_mSimObjectId, a2, a3, a4);
}
/// <summary>
/// (GuiParticleGraphCtrl, setGraphMaxX, void, 4, 4, (int plotID, float maxX)
/// 			  Set the max X value of the graph of plotID.
/// 			  @param plotID The plot to modify.
/// 			  @param maxX The maximum x value.
/// 			  @return No return Value.)
/// 
/// </summary>
public  void setGraphMaxX(string a2, string a3){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setGraphMaxX(_mSimObjectId, a2, a3);
}
/// <summary>
/// (GuiParticleGraphCtrl, setGraphMaxY, void, 4, 4, (int plotID, float maxY)
/// 			  Set the max Y value of the graph of plotID.
/// 			  @param plotID The plot to modify.
/// 			  @param maxY The maximum y value.
/// 			  @return No return Value.)
/// 
/// </summary>
public  void setGraphMaxY(string a2, string a3){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setGraphMaxY(_mSimObjectId, a2, a3);
}
/// <summary>
/// (GuiParticleGraphCtrl, setGraphMin, void, 5, 5, (int plotID, float minX, float minY) 
/// 			  Set the min values of the graph of plotID.
/// 			  @param plotID The plot to modify
/// 			  @param minX,minY The minimum bound of the value range.
/// 			  @return No return value.)
/// 
/// </summary>
public  void setGraphMin(string a2, string a3, string a4){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setGraphMin(_mSimObjectId, a2, a3, a4);
}
/// <summary>
/// (GuiParticleGraphCtrl, setGraphMinX, void, 4, 4, (int plotID, float minX) 
/// 			  Set the min X value of the graph of plotID.
/// 			  @param plotID The plot to modify.
/// 			  @param minX The minimum x value.
/// 			  @return No return Value.)
/// 
/// </summary>
public  void setGraphMinX(string a2, string a3){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setGraphMinX(_mSimObjectId, a2, a3);
}
/// <summary>
/// (GuiParticleGraphCtrl, setGraphMinY, void, 4, 4, (int plotID, float minY) 
/// 			  Set the min Y value of the graph of plotID.
/// 			  @param plotID The plot to modify.
/// 			  @param minY The minimum y value.
/// 			  @return No return Value.)
/// 
/// </summary>
public  void setGraphMinY(string a2, string a3){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setGraphMinY(_mSimObjectId, a2, a3);
}
/// <summary>
/// (GuiParticleGraphCtrl, setGraphName, void, 4, 4, (int plotID, string graphName) 
/// 			  Set the name of the given plot.
/// 			  @param plotID The plot to modify.
/// 			  @param graphName The name to set on the plot.
/// 			  @return No return value.)
/// 
/// </summary>
public  void setGraphName(string a2, string a3){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setGraphName(_mSimObjectId, a2, a3);
}
/// <summary>
/// (GuiParticleGraphCtrl, setPointXMovementClamped, void, 3, 3, (bool clamped)
/// 			  Set whether the x position of the selected graph point should be clamped
/// 			  @return No return value.)
/// 
/// </summary>
public  void setPointXMovementClamped(string a2){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setPointXMovementClamped(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, setRenderAll, void, 3, 3, (bool renderAll)
/// 			  Set whether or not a position should be rendered on every point or just the last selected.
/// 			  @return No return value.)
/// 
/// </summary>
public  void setRenderAll(string a2){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setRenderAll(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, setRenderGraphTooltip, void, 3, 3, (bool renderGraphTooltip)
/// 			  Set whether or not to render the graph tooltip.
/// 			  @return No return value.)
/// 
/// </summary>
public  void setRenderGraphTooltip(string a2){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setRenderGraphTooltip(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, setSelectedPlot, void, 3, 3, (int plotID)
///               Set the selected plot (a.k.a. graph).
/// 			  @return No return value )
/// 
/// </summary>
public  void setSelectedPlot(string a2){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setSelectedPlot(_mSimObjectId, a2);
}
/// <summary>
/// (GuiParticleGraphCtrl, setSelectedPoint, void, 3, 3, (int point)
///               Set the selected point on the graph.
/// 			  @return No return value)
/// 
/// </summary>
public  void setSelectedPoint(string a2){
TorqueScriptTemplate.m_ts.fnGuiParticleGraphCtrl_setSelectedPoint(_mSimObjectId, a2);
}
}}
