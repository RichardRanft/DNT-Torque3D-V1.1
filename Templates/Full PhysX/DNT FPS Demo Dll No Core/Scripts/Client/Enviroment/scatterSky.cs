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
// Last updated: 04/10/2013
// 

#region

using WinterLeaf.Classes;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        //-----------------------------------------------------------------------------
        // Water
        //-----------------------------------------------------------------------------

        [Torque_Decorations.TorqueCallBack("", "", "initialize_scattersky", "", 0, 46000, true)]
        public void initialize_scattersky()
            {
            Torque_Class_Helper tch = new Torque_Class_Helper("GFXStateBlockData", "ScatterSkySBData");
            tch.Props.Add("cullDefined", "true");
            tch.PropsAddString("cullMode", "GFXCullNone");
            tch.Props.Add("zDefined", "true");
            tch.Props.Add("zEnable", "true");
            tch.Props.Add("zWriteEnable", "false");
            tch.Props.Add("zFunc", "GFXCmpLessEqual");

            tch.Props.Add("samplersDefined", "true");
            tch.Props.Add("samplerStates[0]", "SamplerClampLinear");
            tch.Props.Add("samplerStates[1]", "SamplerClampLinear");
            tch.Props.Add("vertexColorEnable", "true");
            tch.Create();

            TorqueSingleton ts = new TorqueSingleton("ShaderData", "ScatterSkyShaderData");
            ts.PropsAddString("DXVertexShaderFile", "shaders/common/scatterSkyV.hlsl");
            ts.PropsAddString("DXPixelShaderFile", "shaders/common/scatterSkyP.hlsl");

            ts.PropsAddString("OGLVertexShaderFile", "shaders/common/gl/scatterSkyV.glsl");
            ts.PropsAddString("OGLPixelShaderFile", "shaders/common/gl/scatterSkyP.glsl");

            ts.Props.Add("pixVersion", "2.0");

            ts.Create();
            }
        }
    }