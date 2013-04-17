
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
    internal class tsObjectConvertercoCamera : TypeConverter
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
                return new coCamera(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoCamera))]
    public class coCamera: coShapeBase
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coCamera(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coCamera(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
public coCamera(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coCamera ts, string simobjectid)
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
        public static bool operator !=(coCamera ts, string simobjectid)
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
        public static implicit operator string( coCamera ts)
            {
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coCamera(string ts)
            {
            return new coCamera(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coCamera ts)
            {
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coCamera(int ts)
            {
            return new coCamera(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coCamera ts)
            {
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coCamera(uint ts)
            {
            return new coCamera(ts);
            }
public float angularDrag
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".angularDrag").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".angularDrag", value.AsString());
          }
       }
public float angularForce
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".angularForce").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".angularForce", value.AsString());
          }
       }
public float brakeMultiplier
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".brakeMultiplier").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".brakeMultiplier", value.AsString());
          }
       }
public Camera__CameraMotionMode controlMode
       {
       get
          {          return (Camera__CameraMotionMode)Enum.Parse(typeof(Camera__CameraMotionMode), dnTorque.self.GetVar(_mSimObjectId + ".controlMode"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".controlMode", value.ToString());
          }
       }
public float drag
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".drag").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".drag", value.AsString());
          }
       }
public float force
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".force").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".force", value.AsString());
          }
       }
public float mass
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".mass").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".mass", value.AsString());
          }
       }
public bool newtonMode
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".newtonMode").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".newtonMode", value.AsString());
          }
       }
public bool newtonRotation
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".newtonRotation").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".newtonRotation", value.AsString());
          }
       }
public float speedMultiplier
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".speedMultiplier").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".speedMultiplier", value.AsString());
          }
       }
/// <summary>
/// Move the camera to fully view the given radius.
///                    @note For this operation to take affect a valid edit orbit point must first be specified.  See Camera::setEditOrbitPoint().
///                    @param radius The radius to view.)
/// 
/// </summary>
public  void autoFitRadius(float radius){
TorqueScriptTemplate.m_ts.fnCamera_autoFitRadius(_mSimObjectId, radius);
}
/// <summary>
/// Get the angular velocity for a Newton mode camera.
///                    @returns The angular velocity in the form of \"x y z\".
///                    @note Only returns useful results when Camera::newtonRotation is set to true.)
/// 
/// </summary>
public  Point3F getAngularVelocity(){
return new Point3F ( TorqueScriptTemplate.m_ts.fnCamera_getAngularVelocity(_mSimObjectId));
}
/// <summary>
/// Returns the current camera control mode.
///                    @see CameraMotionMode)
/// 
/// </summary>
public  Camera__CameraMotionMode getMode(){
return (Camera__CameraMotionMode)( TorqueScriptTemplate.m_ts.fnCamera_getMode(_mSimObjectId));
}
/// <summary>
/// Get the camera's offset from its orbit or tracking point.
///                    The offset is added to the camera's position when set to CameraMode::OrbitObject.
///                    @returns The offset in the form of \"x y z\".)
/// 
/// </summary>
public  Point3F getOffset(){
return new Point3F ( TorqueScriptTemplate.m_ts.fnCamera_getOffset(_mSimObjectId));
}
/// <summary>
/// Get the camera's position in the world.
///                    @returns The position in the form of \"x y z\".)
/// 
/// </summary>
public  new  Point3F getPosition(){
return new Point3F ( TorqueScriptTemplate.m_ts.fnCamera_getPosition(_mSimObjectId));
}
/// <summary>
/// Get the camera's Euler rotation in radians.
///                    @returns The rotation in radians in the form of \"x y z\".)
/// 
/// </summary>
public  Point3F getRotation(){
return new Point3F ( TorqueScriptTemplate.m_ts.fnCamera_getRotation(_mSimObjectId));
}
/// <summary>
/// Get the velocity for the camera.
///                    @returns The camera's velocity in the form of \"x y z\".
///                    @note Only useful when the Camera is in Newton mode.)
/// 
/// </summary>
public  new  Point3F getVelocity(){
return new Point3F ( TorqueScriptTemplate.m_ts.fnCamera_getVelocity(_mSimObjectId));
}
/// <summary>
/// Is the camera in edit orbit mode?
///                    @returns true if the camera is in edit orbit mode.)
/// 
/// </summary>
public  bool isEditOrbitMode(){
return TorqueScriptTemplate.m_ts.fnCamera_isEditOrbitMode(_mSimObjectId);
}
/// <summary>
/// Is this a Newton Fly mode camera with damped rotation?
///                     @returns true if the camera uses a damped rotation.  i.e. Camera::newtonRotation is set to true.)
/// 
/// </summary>
public  bool isRotationDamped(){
return TorqueScriptTemplate.m_ts.fnCamera_isRotationDamped(_mSimObjectId);
}
/// <summary>
/// Point the camera at the specified position.  Does not work in Orbit or Track modes.
///                    @param point The position to point the camera at.)
/// 
/// </summary>
public  void lookAt(Point3F point){
TorqueScriptTemplate.m_ts.fnCamera_lookAt(_mSimObjectId, point.AsString());
}
/// <summary>
/// Set the angular drag for a Newton mode camera.
///                    @param drag The angular drag applied while the camera is rotating.
///                    @note Only takes affect when Camera::newtonRotation is set to true.)
/// 
/// </summary>
public  void setAngularDrag(float drag){
TorqueScriptTemplate.m_ts.fnCamera_setAngularDrag(_mSimObjectId, drag);
}
/// <summary>
/// Set the angular force for a Newton mode camera.
///                    @param force The angular force applied when attempting to rotate the camera.
///                    @note Only takes affect when Camera::newtonRotation is set to true.)
/// 
/// </summary>
public  void setAngularForce(float force){
TorqueScriptTemplate.m_ts.fnCamera_setAngularForce(_mSimObjectId, force);
}
/// <summary>
/// Set the angular velocity for a Newton mode camera.
///                    @param velocity The angular velocity infor form of \"x y z\".
///                    @note Only takes affect when Camera::newtonRotation is set to true.)
/// 
/// </summary>
public  void setAngularVelocity(Point3F velocity){
TorqueScriptTemplate.m_ts.fnCamera_setAngularVelocity(_mSimObjectId, velocity.AsString());
}
/// <summary>
/// Set the Newton mode camera brake multiplier when trigger[1] is active.
///                    @param multiplier The brake multiplier to apply.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
public  void setBrakeMultiplier(float multiplier){
TorqueScriptTemplate.m_ts.fnCamera_setBrakeMultiplier(_mSimObjectId, multiplier);
}
/// <summary>
/// Set the drag for a Newton mode camera.
///                    @param drag The drag applied to the camera while moving.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
public  void setDrag(float drag){
TorqueScriptTemplate.m_ts.fnCamera_setDrag(_mSimObjectId, drag);
}
/// <summary>
/// Set the editor camera to orbit around a point set with Camera::setEditOrbitPoint().
///                     @note This method is generally used only within the World Editor and other tools.  To 
///                     orbit about an object or point within a game, see Camera::setOrbitMode() and its helper methods.)
/// 
/// </summary>
public  void setEditOrbitMode(){
TorqueScriptTemplate.m_ts.fnCamera_setEditOrbitMode(_mSimObjectId);
}
/// <summary>
/// Set the editor camera's orbit point.
///                    @param point The point the camera will orbit in the form of \"x y z\".)
/// 
/// </summary>
public  void setEditOrbitPoint(Point3F point){
TorqueScriptTemplate.m_ts.fnCamera_setEditOrbitPoint(_mSimObjectId, point.AsString());
}
/// <summary>
/// Set the force applied to a Newton mode camera while moving.
///                    @param force The force applied to the camera while attempting to move.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
public  void setFlyForce(float force){
TorqueScriptTemplate.m_ts.fnCamera_setFlyForce(_mSimObjectId, force);
}
/// <summary>
/// Set the camera to fly freely.
///                    Allows the camera to have 6 degrees of freedom.  Provides for instantaneous motion 
///                    and rotation unless one of the Newton fields has been set to true.  See Camera::newtonMode 
///                    and Camera::newtonRotation.)
/// 
/// </summary>
public  void setFlyMode(){
TorqueScriptTemplate.m_ts.fnCamera_setFlyMode(_mSimObjectId);
}
/// <summary>
/// Set the mass for a Newton mode camera.
///                    @param mass The mass used during ease-in and ease-out calculations.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
public  void setMass(float mass){
TorqueScriptTemplate.m_ts.fnCamera_setMass(_mSimObjectId, mass);
}
/// <summary>
/// Set the camera to fly freely, but with ease-in and ease-out.
///                     This method allows for the same 6 degrees of freedom as Camera::setFlyMode() but 
///                     activates the ease-in and ease-out on the camera's movement.  To also activate 
///                     Newton mode for the camera's rotation, set Camera::newtonRotation to true.)
/// 
/// </summary>
public  void setNewtonFlyMode(){
TorqueScriptTemplate.m_ts.fnCamera_setNewtonFlyMode(_mSimObjectId);
}
/// <summary>
/// Set the camera's offset.
///                    The offset is added to the camera's position when set to CameraMode::OrbitObject.
///                    @param offset The distance to offset the camera by in the form of \"x y z\".)
/// 
/// </summary>
public  void setOffset(Point3F offset){
TorqueScriptTemplate.m_ts.fnCamera_setOffset(_mSimObjectId, offset.AsString());
}
/// <summary>
/// Set the camera to orbit around the given object, or if none is given, around the given point.
///                     @param orbitObject The object to orbit around.  If no object is given (0 or blank string is passed in) use the orbitPoint instead
///                     @param orbitPoint The point to orbit around when no object is given.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform().
///                     @param minDistance The minimum distance allowed to the orbit object or point.
///                     @param maxDistance The maximum distance allowed from the orbit object or point.
///                     @param initDistance The initial distance from the orbit object or point.
///                     @param ownClientObj [optional] Are we orbiting an object that is owned by us?  Default is false.
///                     @param offset [optional] An offset added to the camera's position.  Default is no offset.
///                     @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.
///                     @see Camera::setOrbitObject()
///                     @see Camera::setOrbitPoint())
/// 
/// </summary>
public  void setOrbitMode(string orbitObject, TransformF orbitPoint, float minDistance, float maxDistance, float initDistance, bool ownClientObj, Point3F offset, bool xlocked){
TorqueScriptTemplate.m_ts.fnCamera_setOrbitMode(_mSimObjectId, orbitObject, orbitPoint.AsString(), minDistance, maxDistance, initDistance, ownClientObj, offset.AsString(), xlocked);
}
/// <summary>
/// Set the camera to orbit around a given object.
///                     @param orbitObject The object to orbit around.
///                     @param rotation The initial camera rotation about the object in radians in the form of \"x y z\".
///                     @param minDistance The minimum distance allowed to the orbit object or point.
///                     @param maxDistance The maximum distance allowed from the orbit object or point.
///                     @param initDistance The initial distance from the orbit object or point.
///                     @param ownClientObject [optional] Are we orbiting an object that is owned by us?  Default is false.
///                     @param offset [optional] An offset added to the camera's position.  Default is no offset.
///                     @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.
///                     @returns false if the given object could not be found.
///                     @see Camera::setOrbitMode())
/// 
/// </summary>
public  bool setOrbitObject(string orbitObject, Point3F rotation, float minDistance, float maxDistance, float initDistance, bool ownClientObject, Point3F offset, bool xlocked){
return TorqueScriptTemplate.m_ts.fnCamera_setOrbitObject(_mSimObjectId, orbitObject, rotation.AsString(), minDistance, maxDistance, initDistance, ownClientObject, offset.AsString(), xlocked);
}
/// <summary>
/// Set the camera to orbit around a given point.
///                     @param orbitPoint The point to orbit around.  In the form of \"x y z ax ay az aa\" such as returned by SceneObject::getTransform().
///                     @param minDistance The minimum distance allowed to the orbit object or point.
///                     @param maxDistance The maximum distance allowed from the orbit object or point.
///                     @param initDistance The initial distance from the orbit object or point.
///                     @param offset [optional] An offset added to the camera's position.  Default is no offset.
///                     @param locked [optional] Indicates the camera does not receive input from the player.  Default is false.
///                     @see Camera::setOrbitMode())
/// 
/// </summary>
public  void setOrbitPoint(TransformF orbitPoint, float minDistance, float maxDistance, float initDistance, Point3F offset, bool xlocked){
TorqueScriptTemplate.m_ts.fnCamera_setOrbitPoint(_mSimObjectId, orbitPoint.AsString(), minDistance, maxDistance, initDistance, offset.AsString(), xlocked);
}
/// <summary>
/// Set the camera's Euler rotation in radians.
///                    @param rot The rotation in radians in the form of \"x y z\".
///                    @note Rotation around the Y axis is ignored )
/// 
/// </summary>
public  void setRotation(Point3F rot){
TorqueScriptTemplate.m_ts.fnCamera_setRotation(_mSimObjectId, rot.AsString());
}
/// <summary>
/// Set the Newton mode camera speed multiplier when trigger[0] is active.
///                    @param multiplier The speed multiplier to apply.
///                    @note Only used when Camera is in Newton mode.)
/// 
/// </summary>
public  void setSpeedMultiplier(float multiplier){
TorqueScriptTemplate.m_ts.fnCamera_setSpeedMultiplier(_mSimObjectId, multiplier);
}
/// <summary>
/// Set the camera to track a given object.
///                     @param trackObject The object to track.
///                     @param offset [optional] An offset added to the camera's position.  Default is no offset.
///                     @returns false if the given object could not be found.)
/// 
/// </summary>
public  bool setTrackObject(string trackObject, Point3F offset){
return TorqueScriptTemplate.m_ts.fnCamera_setTrackObject(_mSimObjectId, trackObject, offset.AsString());
}
/// <summary>
/// Set if there is a valid editor camera orbit point.
///                    When validPoint is set to false the Camera operates as if it is 
///                    in Fly mode rather than an Orbit mode.
///                    @param validPoint Indicates the validity of the orbit point.
///                    @note Only used when Camera is in Edit Orbit Mode.)
/// 
/// </summary>
public  void setValidEditOrbitPoint(bool validPoint){
TorqueScriptTemplate.m_ts.fnCamera_setValidEditOrbitPoint(_mSimObjectId, validPoint);
}
/// <summary>
/// Set the velocity for the camera.
///                    @param velocity The camera's velocity in the form of \"x y z\".
///                    @note Only affects the Camera when in Newton mode.)
/// 
/// </summary>
public  new  void setVelocity(Point3F velocity){
TorqueScriptTemplate.m_ts.fnCamera_setVelocity(_mSimObjectId, velocity.AsString());
}
}}