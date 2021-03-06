﻿// Copyright (C) 2012 Winterleaf Entertainment L,L,C.
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
// 
// 
// 

#region

using System;
using System.ComponentModel;
using WinterLeaf.Classes;
using WinterLeaf.Containers;

#endregion

namespace WinterLeaf.tsObjects
    {
    /// <summary>
    /// 
    /// </summary>
    internal class tsObjectConvertercoGuiRolloutCtrl : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof (string) == sourceType);
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
                return new coGuiRolloutCtrl(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiRolloutCtrl))]
    public class coGuiRolloutCtrl : coGuiControl
        {
        private RectI _margin;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiRolloutCtrl(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiRolloutCtrl(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiRolloutCtrl(int simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// Whether to automatically collapse sibling rollouts.\n\n     If this is true, the rollout will automatically collapse all sibling rollout controls when it      is expanded. If this is false, the auto-collapse behavior can be triggered by CTRL (CMD on MAC)      clicking the rollout header. CTRL/CMD clicking also works if this is false, in which case the      auto-collapsing of sibling controls will be temporarily deactivated. 
        /// </summary>
        public bool autoCollapseSiblings
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".autoCollapseSiblings").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".autoCollapseSiblings", value.AsString()); }
            }

        /// <summary>
        /// Text label to display on the rollout header. 
        /// </summary>
        public String caption
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".caption").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".caption", value.AsString()); }
            }

        /// <summary>
        /// Whether the rollout can be collapsed by clicking its header. 
        /// </summary>
        public bool clickCollapse
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".clickCollapse").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".clickCollapse", value.AsString()); }
            }

        /// <summary>
        /// Default height of the client area. This is used when no child control has been added to the rollout. 
        /// </summary>
        public int defaultHeight
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".defaultHeight").AsInt(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".defaultHeight", value.AsString()); }
            }

        /// <summary>
        /// The current rollout expansion state. 
        /// </summary>
        public bool expanded
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".expanded").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".expanded", value.AsString()); }
            }

        /// <summary>
        /// Whether to render the rollout header.\n\n     @note If this is false, the user cannot toggle the rollout state with the mouse. 
        /// </summary>
        public bool hideHeader
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".hideHeader").AsBool(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".hideHeader", value.AsString()); }
            }

        /// <summary>
        /// Margin to put around child control. 
        /// </summary>
        public RectI margin
            {
            get
                {
                if (_margin != null)
                    _margin.DetachAllEvents();
                _margin = dnTorque.self.GetVar(_mSimObjectId + ".margin").AsRectI();
                _margin.OnChangeNotification += _margin_OnChangeNotification;
                return _margin;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".margin", value.AsString()); }
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiRolloutCtrl ts, string simobjectid)
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
            return (this._mSimObjectId == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(coGuiRolloutCtrl ts, string simobjectid)
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
        public static implicit operator string(coGuiRolloutCtrl ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiRolloutCtrl(string ts)
            {
            return new coGuiRolloutCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiRolloutCtrl ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiRolloutCtrl(int ts)
            {
            return new coGuiRolloutCtrl(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiRolloutCtrl ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiRolloutCtrl(uint ts)
            {
            return new coGuiRolloutCtrl(ts);
            }

        private void _margin_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".margin", e.NewValue);
            }

        /// <summary>
        /// Collapse the rollout if it is currently expanded.  This will make the rollout's child control invisible.
        ///    @note The rollout will animate to collapsed state.  To instantly collapse without animation, use instantCollapse(). )
        /// 
        /// </summary>
        public void collapse()
            {
            TorqueScriptTemplate.m_ts.fnGuiRolloutCtrl_collapse(_mSimObjectId);
            }

        /// <summary>
        /// Expand the rollout if it is currently collapsed.  This will make the rollout's child control visible.
        ///    @note The rollout will animate to expanded state.  To instantly expand without animation, use instantExpand(). )
        /// 
        /// </summary>
        public void expand()
            {
            TorqueScriptTemplate.m_ts.fnGuiRolloutCtrl_expand(_mSimObjectId);
            }

        /// <summary>
        /// Instantly collapse the rollout without animation.  To smoothly slide the rollout to collapsed state, use collapse(). )
        /// 
        /// </summary>
        public void instantCollapse()
            {
            TorqueScriptTemplate.m_ts.fnGuiRolloutCtrl_instantCollapse(_mSimObjectId);
            }

        /// <summary>
        /// Instantly expand the rollout without animation.  To smoothly slide the rollout to expanded state, use expand(). )
        /// 
        /// </summary>
        public void instantExpand()
            {
            TorqueScriptTemplate.m_ts.fnGuiRolloutCtrl_instantExpand(_mSimObjectId);
            }

        /// <summary>
        /// Determine whether the rollout is currently expanded, i.e. whether the child control is visible.
        ///    @return True if the rollout is expanded, false if not. )
        /// 
        /// </summary>
        public new bool isExpanded()
            {
            return TorqueScriptTemplate.m_ts.fnGuiRolloutCtrl_isExpanded(_mSimObjectId);
            }

        /// <summary>
        /// Resize the rollout to exactly fit around its child control.  This can be used to manually trigger a recomputation of 
        ///    the rollout size. )
        /// 
        /// </summary>
        public void sizeToContents()
            {
            TorqueScriptTemplate.m_ts.fnGuiRolloutCtrl_sizeToContents(_mSimObjectId);
            }

        /// <summary>
        /// Toggle the current collapse state of the rollout.  If it is currently expanded, then collapse it.  If it 
        ///    is currently collapsed, then expand it. )
        /// 
        /// </summary>
        public void toggleCollapse()
            {
            TorqueScriptTemplate.m_ts.fnGuiRolloutCtrl_toggleCollapse(_mSimObjectId);
            }

        /// <summary>
        /// Toggle the current expansion state of the rollout  If it is currently expanded, then collapse it.  If it 
        ///    is currently collapsed, then expand it.
        ///    @param instant If true, the rollout will toggle its state without animation.  Otherwise, the rollout will 
        ///       smoothly slide into the opposite state. )
        /// 
        /// </summary>
        public void toggleExpanded(bool instantly)
            {
            TorqueScriptTemplate.m_ts.fnGuiRolloutCtrl_toggleExpanded(_mSimObjectId, instantly);
            }
        }
    }