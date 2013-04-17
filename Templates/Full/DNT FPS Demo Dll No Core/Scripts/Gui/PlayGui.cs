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

using System;
using WinterLeaf.Classes;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        //-----------------------------------------------------------------------------
        // Torque
        // Copyright GarageGames, LLC 2011
        //-----------------------------------------------------------------------------

        //-----------------------------------------------------------------------------
        // PlayGui is the main TSControl through which the game is viewed.
        // The PlayGui also contains the hud controls.
        //-----------------------------------------------------------------------------

        [Torque_Decorations.TorqueCallBack("", "PlayGui", "onWake", "(this)", 1, 4900, false)]
        public void PlayGuiOnWake(string thisobj)
            {
            // Turn off any shell sounds...
            // sfxStop( ... );
            bGlobal["$enableDirectInput"] = true;
            Util._activateDirectInput();

            coGuiCanvas canvas = "canvas";
            try
                {
                // Message hud dialog
                coGuiControl MainChatHud = "MainChatHud";
                coGuiMessageVectorCtrl chatHud = "chatHud";
                canvas.pushDialog(MainChatHud);
                chatHud.attach(new coMessageVector("HudMessageVector"));
                }
            catch (Exception)
                {
                }

            // just update the action map here
            new coActionMap("moveMap").push();


            // hack city - these controls are floating around and need to be clamped
            if (console.isFunction("refreshCenterTextCtrl"))
                Util._schedule("0", "0", "refreshCenterTextCtrl");
            if (console.isFunction("refreshBottomTextCtrl"))
                Util._schedule("0", "0", "refreshBottomTextCtrl");
            }

        [Torque_Decorations.TorqueCallBack("", "PlayGui", "onSleep", "(this)", 1, 4900, false)]
        public void PlayGuiOnSleep(string thisobj)
            {
            try
                {
                new coGuiCanvas("canvas").popDialog(new coGuiControl("MainChatHud"));
                }
            catch (Exception)
                {
                }
            new coActionMap("moveMap").pop();
            }

        [Torque_Decorations.TorqueCallBack("", "PlayGui", "clearHud", "(this)", 1, 4900, false)]
        public void PlayGuiclearHud(coGameTSCtrl thisobj)
            {
            try
                {
                new coGuiCanvas("canvas").popDialog(new coGuiControl("MainChatHud"));
                }
            catch (Exception)
                {
                }
            while (thisobj.getCount() > 0)
                new coSimObject(thisobj.getObject(0)).delete();
            }

        [Torque_Decorations.TorqueCallBack("", "", "refreshBottomTextCtrl", "(this)", 0, 4900, false)]
        public void refreshBottomTextCtrl()
            {
            new coGuiMLTextCtrl("BottomPrintText")["position"] = "0 0";
            }

        [Torque_Decorations.TorqueCallBack("", "", "refreshCenterTextCtrl", "(this)", 0, 4900, false)]
        public void refreshCenterTextCtrl()
            {
            new coGuiMLTextCtrl("CenterPrintText")["position"] = "0 0";
            }
        }
    }