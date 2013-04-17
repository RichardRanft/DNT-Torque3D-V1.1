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

using WinterLeaf;
using WinterLeaf.Classes;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        [Torque_Decorations.TorqueCallBack("", "", "initbaselighting", "", 0, 65000, true)]
        public void initbaselighting()
            {
            /*
             * client/lighting/advanced/shaders.cs  60000
             * client/lighting/advanced/lightViz.cs         61000
             * client/lighting/advanced/shadowViz.cs        62000
             * client/lighting/advanced/shadowViz.gui       63000
             * client/lighting/advanced/init.cs             64000
             * client/lighting/basic/init.cs                65000
             * client/lighting/basic/shadowFilter           66000
             * client/lighting/shadowMaps/init              67000
             */
            dnt.DoScriptInjection(ScriptType.Client, 66000, 66999);

            #region singleton GFXStateBlockData( BL_ProjectedShadowSBData )

            TorqueSingleton ts = new TorqueSingleton("GFXStateBlockData", "BL_ProjectedShadowSBData");
            ts.Props.Add("blendDefined", "true");
            ts.Props.Add("blendEnable", "true");
            ts.Props.Add("blendSrc", "GFXBlendDestColor");
            ts.Props.Add("blendDest", "GFXBlendZero");

            ts.Props.Add("zDefined", "true");
            ts.Props.Add("zEnable", "true");
            ts.Props.Add("zWriteEnable", "false");

            ts.Props.Add("samplersDefined", "true");
            ts.Props.Add("samplerStates[0]", "SamplerClampLinear");
            ts.Props.Add("vertexColorEnable", "true");
            ts.Create();

            #endregion

            #region singleton ShaderData( BL_ProjectedShadowShaderData )

            ts = new TorqueSingleton("ShaderData", "BL_ProjectedShadowShaderData");
            ts.PropsAddString("DXVertexShaderFile", "shaders/common/projectedShadowV.hlsl");
            ts.PropsAddString("DXPixelShaderFile", "shaders/common/projectedShadowP.hlsl");

            ts.PropsAddString("OGLVertexShaderFile", "shaders/common/gl/projectedShadowV.glsl");
            ts.PropsAddString("OGLPixelShaderFile", "shaders/common/gl/projectedShadowP.glsl");

            ts.Props.Add("pixVersion", "2.0");
            ts.Create();

            #endregion

            #region singleton CustomMaterial( BL_ProjectedShadowMaterial )

            ts = new TorqueSingleton("CustomMaterial", "BL_ProjectedShadowMaterial");
            ts.PropsAddString(@"sampler[""inputTex""]", "$miscbuff");

            ts.Props.Add("shader", "BL_ProjectedShadowShaderData");
            ts.Props.Add("stateBlock", "BL_ProjectedShadowSBData");
            ts.Props.Add("version", "2.0");
            ts.Props.Add("forwardLit", "true");
            ts.Create();

            #endregion
            }

        [Torque_Decorations.TorqueCallBack("", "", "onActivateBasicLM", "", 0, 65100, false)]
        public void onActivateBasicLM()
            {
            // If HDR is enabled... enable the special format token.
            if ((sGlobal["$platform"] == "macos") || new coPostEffect("HDRPostFx").isEnabled)
                new coGFXStateBlockData("AL_FormatToken").call("enable");
            // Create render pass for projected shadow.

            coRenderPassManager BL_ProjectedShadowRPM = new Torque_Class_Helper("RenderPassManager", "BL_ProjectedShadowRPM").Create();

            // Create the mesh bin and add it to the manager.

            coRenderMeshMgr meshbin = new Torque_Class_Helper("RenderMeshMgr").Create();

            BL_ProjectedShadowRPM.addManager(meshbin);
            // Add both to the root group so that it doesn't
            // end up in the MissionCleanup instant group.

            coSimSet rootGroup = "RootGroup";
            rootGroup.pushToBack(BL_ProjectedShadowRPM);
            rootGroup.pushToBack(meshbin);
            }

        [Torque_Decorations.TorqueCallBack("", "", "onDeactivateBasicLM", "", 0, 65200, false)]
        public void onDeactivateBasicLM()
            {
            // Delete the pass manager which also deletes the bin.
            new coRenderPassManager("BL_ProjectedShadowRPM").delete();
            }

        [Torque_Decorations.TorqueCallBack("", "", "setBasicLighting", "", 0, 65300, false)]
        public void setBasicLighting()
            {
            Util.setLightManager("Basic Lighting");
            }
        }
    }