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

using System.Collections.Generic;
using System.Text;

#endregion

namespace WinterLeaf.Classes
    {
    /// <summary>
    /// A helper class to streamline creation of Singletons.
    /// </summary>
    public sealed class TorqueSingleton
        {
        private Dictionary<string, string> _mParams = new Dictionary<string, string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="className"></param>
        /// <param name="datablockName"></param>
        public TorqueSingleton(string className, string datablockName)
            {
            LClassName = className;
            LDatablockName = datablockName;
            }

        /// <summary>
        /// The name of the instance of the object
        /// </summary>
        public string LDatablockName { get; set; }

        /// <summary>
        /// The name of the TorqueScript class.
        /// </summary>
        public string LClassName { get; set; }

        /// <summary>
        /// The properties in the script block/datablock
        /// </summary>
        public Dictionary<string, string> Props
            {
            get { return _mParams; }
            set { _mParams = value; }
            }

        /// <summary>
        /// Addds the property as a string, i.e. key = "value" versus key=value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="str"></param>
        public void PropsAddString(string key, string str)
            {
            _mParams.Add(key, '"' + str + '"');
            }

        /// <summary>
        /// This will return the TorqueScript code that will be executed when Create is called.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            {
            StringBuilder result = new StringBuilder();
            result.Append(" singleton ");
            result.Append(LClassName);
            result.Append("(");
            result.Append(LDatablockName);
            result.Append(")\r\n{");
            foreach (KeyValuePair<string, string> ele in _mParams)
                {
                result.Append(ele.Key);
                result.Append(" = ");
                result.Append(ele.Value.Trim() != "" ? ele.Value : @"""""");
                result.Append(";\r\n");
                }
            result.Append("};");
            return (result.ToString());
            }

        /// <summary>
        /// Passes the ToString() TorqueScript to the Eval statement capturing the id of the object created
        /// </summary>
        /// <returns></returns>
        public string Create()
            {
            dnTorque.self.Evaluate(ToString(), false);
            return LDatablockName;
            }
        }
    }