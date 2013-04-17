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
        [Torque_Decorations.TorqueCallBack("", "", "Initialize_AdvanceLight_Shaders", "", 0, 60000, true)]
        public void Initialize_AdvanceLight_Shaders()
            {
            #region new GFXStateBlockData( AL_VectorLightState )

            Torque_Class_Helper tch = new Torque_Class_Helper("GFXStateBlockData", "AL_VectorLightState");
            tch.Props.Add("blendDefined", "true");
            tch.Props.Add("blendEnable", "true");
            tch.Props.Add("blendSrc", "GFXBlendOne");
            tch.Props.Add("blendDest", "GFXBlendOne");
            tch.Props.Add("blendOp", "GFXBlendOpAdd");

            tch.Props.Add("zDefined", "true");
            tch.Props.Add("zEnable", "false");
            tch.Props.Add("zWriteEnable", "false");

            tch.Props.Add("samplersDefined", "true");
            tch.Props.Add("samplerStates[0]", "SamplerClampPoint"); // G-buffer
            tch.Props.Add("samplerStates[1]", "SamplerClampPoint"); // Shadow Map (Do not change this to linear, as all cards can not filter equally.)
            tch.Props.Add("samplerStates[2]", "SamplerClampLinear"); // SSAO Mask
            tch.Props.Add("samplerStates[3]", "SamplerWrapPoint"); // Random Direction Map

            tch.Props.Add("cullDefined", "true");
            tch.Props.Add("cullMode", "GFXCullNone");

            tch.Props.Add("stencilDefined", "true");
            tch.Props.Add("stencilEnable", "true");
            tch.Props.Add("stencilFailOp", "GFXStencilOpKeep");
            tch.Props.Add("stencilZFailOp", "GFXStencilOpKeep");
            tch.Props.Add("stencilPassOp", "GFXStencilOpKeep");
            tch.Props.Add("stencilFunc", "GFXCmpLess");
            tch.Props.Add("stencilRef", "0");
            tch.Create();

            #endregion

            #region new ShaderData( AL_VectorLightShader )

            tch = new Torque_Class_Helper("ShaderData", "AL_VectorLightShader");
            tch.PropsAddString("DXVertexShaderFile", "shaders/common/lighting/advanced/farFrustumQuadV.hlsl");
            tch.PropsAddString("DXPixelShaderFile", "shaders/common/lighting/advanced/vectorLightP.hlsl");

            tch.PropsAddString("OGLVertexShaderFile", "shaders/common/lighting/advanced/gl/farFrustumQuadV.glsl");
            tch.PropsAddString("OGLPixelShaderFile", "shaders/common/lighting/advanced/gl/vectorLightP.glsl");
            tch.Props.Add("pixVersion", "3.0");
            tch.Create();

            #endregion

            #region new CustomMaterial( AL_VectorLightMaterial )

            tch = new Torque_Class_Helper("CustomMaterial", "AL_VectorLightMaterial");
            tch.Props.Add("shader", "AL_VectorLightShader");
            tch.Props.Add("stateBlock", "AL_VectorLightState");
            tch.PropsAddString(@"sampler[""prePassBuffer""]", "#prepass");
            tch.PropsAddString(@"sampler[""ShadowMap""]", "$dynamiclight");
            tch.PropsAddString(@"sampler[""ssaoMask""]", "#ssaoMask");

            tch.PropsAddString("target", "lightinfo");

            tch.Props.Add("pixVersion", "3.0");
            tch.Create();

            #endregion

            #region new GFXStateBlockData( AL_ConvexLightState )

            tch = new Torque_Class_Helper("GFXStateBlockData", "AL_ConvexLightState");

            tch.Props.Add("blendDefined", "true");
            tch.Props.Add("blendEnable", "true");
            tch.Props.Add("blendSrc", "GFXBlendOne");
            tch.Props.Add("blendDest", "GFXBlendOne");
            tch.Props.Add("blendOp", "GFXBlendOpAdd");

            tch.Props.Add("zDefined", "true");
            tch.Props.Add("zEnable", "true");
            tch.Props.Add("zWriteEnable", "false");
            tch.Props.Add("zFunc", "GFXCmpGreaterEqual");

            tch.Props.Add("samplersDefined", "true");
            tch.Props.Add("samplerStates[0]", "SamplerClampPoint"); // G-buffer
            tch.Props.Add("samplerStates[1]", "SamplerClampPoint"); // Shadow Map (Do not use linear, these are perspective projections)
            tch.Props.Add("samplerStates[2]", "SamplerClampLinear"); // Cookie Map   
            tch.Props.Add("samplerStates[3]", "SamplerWrapPoint"); // Random Direction Map

            tch.Props.Add("cullDefined", "true");
            tch.Props.Add("cullMode", "GFXCullCW");

            tch.Props.Add("stencilDefined", "true");
            tch.Props.Add("stencilEnable", "true");
            tch.Props.Add("stencilFailOp", "GFXStencilOpKeep");
            tch.Props.Add("stencilZFailOp", "GFXStencilOpKeep");
            tch.Props.Add("stencilPassOp", "GFXStencilOpKeep");
            tch.Props.Add("stencilFunc", "GFXCmpLess");
            tch.Props.Add("stencilRef", "0");
            tch.Create();

            #endregion

            #region new ShaderData( AL_PointLightShader )

            tch = new Torque_Class_Helper("ShaderData", "AL_PointLightShader");
            tch.PropsAddString("DXVertexShaderFile", "shaders/common/lighting/advanced/convexGeometryV.hlsl");
            tch.PropsAddString("DXPixelShaderFile", "shaders/common/lighting/advanced/pointLightP.hlsl");
            tch.PropsAddString("OGLVertexShaderFile", "shaders/common/lighting/advanced/gl/convexGeometryV.glsl");
            tch.PropsAddString("OGLPixelShaderFile", "shaders/common/lighting/advanced/gl/pointLightP.glsl");
            tch.Props.Add("pixVersion", "3.0");
            tch.Create();

            #endregion

            #region new CustomMaterial( AL_PointLightMaterial )

            tch = new Torque_Class_Helper("CustomMaterial", "AL_PointLightMaterial");
            tch.Props.Add("shader", "AL_PointLightShader");
            tch.Props.Add("stateBlock", "AL_ConvexLightState");
            tch.PropsAddString(@"sampler[""prePassBuffer""]", "#prepass");
            tch.PropsAddString(@"sampler[""shadowMap""]", "$dynamiclight");
            tch.PropsAddString(@"sampler[""cookieTex""]", "$dynamiclightmask");
            tch.PropsAddString(@"target", "lightinfo");
            tch.Props.Add("pixVersion", "3.0");
            tch.Create();

            #endregion

            #region new ShaderData( AL_SpotLightShader )

            tch = new Torque_Class_Helper("ShaderData", "AL_SpotLightShader");
            tch.PropsAddString("DXVertexShaderFile", "shaders/common/lighting/advanced/convexGeometryV.hlsl");
            tch.PropsAddString("DXPixelShaderFile", "shaders/common/lighting/advanced/spotLightP.hlsl");
            tch.PropsAddString("OGLVertexShaderFile", "shaders/common/lighting/advanced/gl/convexGeometryV.glsl");
            tch.PropsAddString("OGLPixelShaderFile", "shaders/common/lighting/advanced/gl/spotLightP.glsl");
            tch.Props.Add("pixVersion", "3.0");
            tch.Create();

            #endregion

            #region new CustomMaterial( AL_SpotLightMaterial )

            tch = new Torque_Class_Helper("CustomMaterial", "AL_SpotLightMaterial");
            tch.Props.Add("shader", "AL_SpotLightShader");
            tch.Props.Add("stateBlock", "AL_ConvexLightState");

            tch.PropsAddString(@"sampler[""prePassBuffer""]", "#prepass");
            tch.PropsAddString(@"sampler[""shadowMap""]", "$dynamiclight");
            tch.PropsAddString(@"sampler[""cookieTex""]", "$dynamiclightmask");

            tch.PropsAddString("target", "lightinfo");
            tch.Props.Add("pixVersion", "3.0");
            tch.Create();

            #endregion

            #region new Material( AL_DefaultPrePassMaterial )

            tch = new Torque_Class_Helper("Material", "AL_DefaultPrePassMaterial");
            // We need something in the first pass else it 
            // won't create a proper material instance.  
            //
            // We use color here because some objects may not
            // have texture coords in their vertex format... 
            // for example like terrain.
            //

            tch.PropsAddString("diffuseColor[0]", "1 1 1 1");
            tch.Create();

            #endregion

            // This material is used for generating shadow 
            // materials for objects that do not have materials.

            #region new Material( AL_DefaultShadowMaterial )

            tch = new Torque_Class_Helper("Material", "AL_DefaultShadowMaterial");
            // We need something in the first pass else it 
            // won't create a proper material instance.  
            //
            // We use color here because some objects may not
            // have texture coords in their vertex format... 
            // for example like terrain.
            //

            tch.PropsAddString("diffuseColor[0]", "1 1 1 1");
            // This is here mostly for terrain which uses
            // this material to create its shadow material.
            //
            // At sunset/sunrise the sun is looking thru 
            // backsides of the terrain which often are not
            // closed.  By changing the material to be double
            // sided we avoid holes in the shadowed geometry.
            //
            tch.Props.Add("doubleSided", "true");
            tch.Create();

            #endregion

            #region new ShaderData( AL_ParticlePointLightShader )

            tch = new Torque_Class_Helper("ShaderData", "AL_ParticlePointLightShader");
            tch.PropsAddString("DXVertexShaderFile", "shaders/common/lighting/advanced/particlePointLightV.hlsl");
            tch.PropsAddString("DXPixelShaderFile", "shaders/common/lighting/advanced/particlePointLightP.hlsl");
            tch.PropsAddString("OGLVertexShaderFile", "shaders/common/lighting/advanced/gl/convexGeometryV.glsl");
            tch.PropsAddString("OGLPixelShaderFile", "shaders/common/lighting/advanced/gl/pointLightP.glsl");
            tch.Props.Add("pixVersion", "3.0");
            tch.Create();

            #endregion

            #region new CustomMaterial( AL_ParticlePointLightMaterial )

            tch = new Torque_Class_Helper("CustomMaterial", "AL_ParticlePointLightMaterial");
            tch.Props.Add("shader", "AL_ParticlePointLightShader");
            tch.Props.Add("stateBlock", "AL_ConvexLightState");

            tch.PropsAddString(@"sampler[""prePassBuffer""]", "#prepass");
            tch.PropsAddString(@"target", "lightinfo");

            tch.Props.Add("pixVersion", "3.0");
            tch.Create();

            #endregion
            }
        }
    }