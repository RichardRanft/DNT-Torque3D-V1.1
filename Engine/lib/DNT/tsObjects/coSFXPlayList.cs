
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
    internal class tsObjectConvertercoSFXPlayList : TypeConverter
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
                return new coSFXPlayList(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoSFXPlayList))]
    public class coSFXPlayList: coSFXTrack
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSFXPlayList(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSFXPlayList(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coSFXPlayList(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSFXPlayList ts, string simobjectid)
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
        public static bool operator !=(coSFXPlayList ts, string simobjectid)
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
        public static implicit operator string( coSFXPlayList ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSFXPlayList(string ts)
            {
            return new coSFXPlayList(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coSFXPlayList ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSFXPlayList(int ts)
            {
            return new coSFXPlayList(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coSFXPlayList ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coSFXPlayList(uint ts)
            {
            return new coSFXPlayList(ts);
            }
public float delayTimeIn
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".delayTimeIn").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".delayTimeIn", value.AsString());
          }
       }
public Point2F delayTimeInVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".delayTimeInVariance").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".delayTimeInVariance", value.AsString());
          }
       }
public float delayTimeOut
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".delayTimeOut").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".delayTimeOut", value.AsString());
          }
       }
public Point2F delayTimeOutVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".delayTimeOutVariance").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".delayTimeOutVariance", value.AsString());
          }
       }
public float fadeTimeIn
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeTimeIn").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeTimeIn", value.AsString());
          }
       }
public Point2F fadeTimeInVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeTimeInVariance").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeTimeInVariance", value.AsString());
          }
       }
public float fadeTimeOut
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeTimeOut").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeTimeOut", value.AsString());
          }
       }
public Point2F fadeTimeOutVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fadeTimeOutVariance").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fadeTimeOutVariance", value.AsString());
          }
       }
public SFXPlayList__ELoopMode loopMode
       {
       get
          {          return (SFXPlayList__ELoopMode)Enum.Parse(typeof(SFXPlayList__ELoopMode), dnTorque.self.GetVar(_mSimObjectId + ".loopMode"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".loopMode", value.ToString());
          }
       }
public float maxDistance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxDistance").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxDistance", value.AsString());
          }
       }
public Point2F maxDistanceVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxDistanceVariance").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxDistanceVariance", value.AsString());
          }
       }
public int numSlotsToPlay
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".numSlotsToPlay").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".numSlotsToPlay", value.AsString());
          }
       }
public float pitchScale
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".pitchScale").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".pitchScale", value.AsString());
          }
       }
public Point2F pitchScaleVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".pitchScaleVariance").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".pitchScaleVariance", value.AsString());
          }
       }
public SFXPlayList__ERandomMode random
       {
       get
          {          return (SFXPlayList__ERandomMode)Enum.Parse(typeof(SFXPlayList__ERandomMode), dnTorque.self.GetVar(_mSimObjectId + ".random"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".random", value.ToString());
          }
       }
public float referenceDistance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".referenceDistance").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".referenceDistance", value.AsString());
          }
       }
public Point2F referenceDistanceVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".referenceDistanceVariance").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".referenceDistanceVariance", value.AsString());
          }
       }
public int repeatCount
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".repeatCount").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".repeatCount", value.AsString());
          }
       }
public SFXPlayList__EReplayMode replay
       {
       get
          {          return (SFXPlayList__EReplayMode)Enum.Parse(typeof(SFXPlayList__EReplayMode), dnTorque.self.GetVar(_mSimObjectId + ".replay"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".replay", value.ToString());
          }
       }
public coSFXState state
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".state");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".state", value.ToString());
          }
       }
public SFXPlayList__EStateMode stateMode
       {
       get
          {          return (SFXPlayList__EStateMode)Enum.Parse(typeof(SFXPlayList__EStateMode), dnTorque.self.GetVar(_mSimObjectId + ".stateMode"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".stateMode", value.ToString());
          }
       }
public bool trace
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".trace").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".trace", value.AsString());
          }
       }
public coSFXTrack track
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".track");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".track", value.ToString());
          }
       }
public SFXPlayList__ETransitionMode transitionIn
       {
       get
          {          return (SFXPlayList__ETransitionMode)Enum.Parse(typeof(SFXPlayList__ETransitionMode), dnTorque.self.GetVar(_mSimObjectId + ".transitionIn"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".transitionIn", value.ToString());
          }
       }
public SFXPlayList__ETransitionMode transitionOut
       {
       get
          {          return (SFXPlayList__ETransitionMode)Enum.Parse(typeof(SFXPlayList__ETransitionMode), dnTorque.self.GetVar(_mSimObjectId + ".transitionOut"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".transitionOut", value.ToString());
          }
       }
public float volumeScale
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".volumeScale").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".volumeScale", value.AsString());
          }
       }
public Point2F volumeScaleVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".volumeScaleVariance").AsPoint2F();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".volumeScaleVariance", value.AsString());
          }
       }
}}