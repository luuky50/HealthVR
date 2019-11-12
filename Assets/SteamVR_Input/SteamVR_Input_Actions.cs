//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Boolean p_default_InteractUI;
        
        private static SteamVR_Action_Boolean p_default_Teleport;
        
        private static SteamVR_Action_Boolean p_default_GrabPinch;
        
        private static SteamVR_Action_Boolean p_default_GrabGrip;
        
        private static SteamVR_Action_Pose p_default_Pose;
        
        private static SteamVR_Action_Skeleton p_default_SkeletonLeftHand;
        
        private static SteamVR_Action_Skeleton p_default_SkeletonRightHand;
        
        private static SteamVR_Action_Single p_default_Squeeze;
        
        private static SteamVR_Action_Boolean p_default_HeadsetOnHead;
        
        private static SteamVR_Action_Boolean p_default_SnapTurnLeft;
        
        private static SteamVR_Action_Boolean p_default_SnapTurnRight;
        
        private static SteamVR_Action_Vibration p_default_Haptic;
        
        private static SteamVR_Action_Vector2 p_platformer_Move;
        
        private static SteamVR_Action_Boolean p_platformer_Jump;
        
        private static SteamVR_Action_Vector2 p_buggy_Steering;
        
        private static SteamVR_Action_Single p_buggy_Throttle;
        
        private static SteamVR_Action_Boolean p_buggy_Brake;
        
        private static SteamVR_Action_Boolean p_buggy_Reset;
        
        private static SteamVR_Action_Pose p_mixedreality_ExternalCamera;
        
        private static SteamVR_Action_Boolean p_vRInteraction_ACTION;
        
        private static SteamVR_Action_Boolean p_vRInteraction_PICKUP_DROP;
        
        private static SteamVR_Action_Boolean p_vRInteraction_PICKUP;
        
        private static SteamVR_Action_Boolean p_vRInteraction_DROP;
        
        private static SteamVR_Action_Pose p_vRInteraction_Pose;
        
        private static SteamVR_Action_Skeleton p_vRInteraction_SkeletonLeftHand;
        
        private static SteamVR_Action_Skeleton p_vRInteraction_SkeletonRightHand;
        
        private static SteamVR_Action_Single p_vRInteraction_TriggerPressure;
        
        private static SteamVR_Action_Vector2 p_vRInteraction_TouchPosition;
        
        private static SteamVR_Action_Boolean p_vRInteraction_PadTouched;
        
        private static SteamVR_Action_Boolean p_vRInteraction_PadPressed;
        
        private static SteamVR_Action_Boolean p_vRInteraction_Eject;
        
        private static SteamVR_Action_Boolean p_vRInteraction_SlideRelease;
        
        private static SteamVR_Action_Boolean p_vRInteraction_LightToggle;
        
        private static SteamVR_Action_Boolean p_vRInteraction_ScopeToggle;
        
        private static SteamVR_Action_Boolean p_vRInteraction_TELEPORT;
        
        private static SteamVR_Action_Boolean p_vRInteraction_SWITCH;
        
        private static SteamVR_Action_Vibration p_vRInteraction_Haptic;
        
        public static SteamVR_Action_Boolean default_InteractUI
        {
            get
            {
                return SteamVR_Actions.p_default_InteractUI.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_Teleport
        {
            get
            {
                return SteamVR_Actions.p_default_Teleport.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_GrabPinch
        {
            get
            {
                return SteamVR_Actions.p_default_GrabPinch.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_GrabGrip
        {
            get
            {
                return SteamVR_Actions.p_default_GrabGrip.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose default_Pose
        {
            get
            {
                return SteamVR_Actions.p_default_Pose.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Skeleton default_SkeletonLeftHand
        {
            get
            {
                return SteamVR_Actions.p_default_SkeletonLeftHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Skeleton default_SkeletonRightHand
        {
            get
            {
                return SteamVR_Actions.p_default_SkeletonRightHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Single default_Squeeze
        {
            get
            {
                return SteamVR_Actions.p_default_Squeeze.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Boolean default_HeadsetOnHead
        {
            get
            {
                return SteamVR_Actions.p_default_HeadsetOnHead.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_SnapTurnLeft
        {
            get
            {
                return SteamVR_Actions.p_default_SnapTurnLeft.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean default_SnapTurnRight
        {
            get
            {
                return SteamVR_Actions.p_default_SnapTurnRight.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vibration default_Haptic
        {
            get
            {
                return SteamVR_Actions.p_default_Haptic.GetCopy<SteamVR_Action_Vibration>();
            }
        }
        
        public static SteamVR_Action_Vector2 platformer_Move
        {
            get
            {
                return SteamVR_Actions.p_platformer_Move.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Boolean platformer_Jump
        {
            get
            {
                return SteamVR_Actions.p_platformer_Jump.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vector2 buggy_Steering
        {
            get
            {
                return SteamVR_Actions.p_buggy_Steering.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Single buggy_Throttle
        {
            get
            {
                return SteamVR_Actions.p_buggy_Throttle.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Boolean buggy_Brake
        {
            get
            {
                return SteamVR_Actions.p_buggy_Brake.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean buggy_Reset
        {
            get
            {
                return SteamVR_Actions.p_buggy_Reset.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose mixedreality_ExternalCamera
        {
            get
            {
                return SteamVR_Actions.p_mixedreality_ExternalCamera.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_ACTION
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_ACTION.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_PICKUP_DROP
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_PICKUP_DROP.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_PICKUP
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_PICKUP.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_DROP
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_DROP.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose vRInteraction_Pose
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_Pose.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Skeleton vRInteraction_SkeletonLeftHand
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_SkeletonLeftHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Skeleton vRInteraction_SkeletonRightHand
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_SkeletonRightHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Single vRInteraction_TriggerPressure
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_TriggerPressure.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Vector2 vRInteraction_TouchPosition
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_TouchPosition.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_PadTouched
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_PadTouched.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_PadPressed
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_PadPressed.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_Eject
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_Eject.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_SlideRelease
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_SlideRelease.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_LightToggle
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_LightToggle.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_ScopeToggle
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_ScopeToggle.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_TELEPORT
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_TELEPORT.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean vRInteraction_SWITCH
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_SWITCH.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vibration vRInteraction_Haptic
        {
            get
            {
                return SteamVR_Actions.p_vRInteraction_Haptic.GetCopy<SteamVR_Action_Vibration>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.default_InteractUI,
                    SteamVR_Actions.default_Teleport,
                    SteamVR_Actions.default_GrabPinch,
                    SteamVR_Actions.default_GrabGrip,
                    SteamVR_Actions.default_Pose,
                    SteamVR_Actions.default_SkeletonLeftHand,
                    SteamVR_Actions.default_SkeletonRightHand,
                    SteamVR_Actions.default_Squeeze,
                    SteamVR_Actions.default_HeadsetOnHead,
                    SteamVR_Actions.default_SnapTurnLeft,
                    SteamVR_Actions.default_SnapTurnRight,
                    SteamVR_Actions.default_Haptic,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.mixedreality_ExternalCamera,
                    SteamVR_Actions.vRInteraction_ACTION,
                    SteamVR_Actions.vRInteraction_PICKUP_DROP,
                    SteamVR_Actions.vRInteraction_PICKUP,
                    SteamVR_Actions.vRInteraction_DROP,
                    SteamVR_Actions.vRInteraction_Pose,
                    SteamVR_Actions.vRInteraction_SkeletonLeftHand,
                    SteamVR_Actions.vRInteraction_SkeletonRightHand,
                    SteamVR_Actions.vRInteraction_TriggerPressure,
                    SteamVR_Actions.vRInteraction_TouchPosition,
                    SteamVR_Actions.vRInteraction_PadTouched,
                    SteamVR_Actions.vRInteraction_PadPressed,
                    SteamVR_Actions.vRInteraction_Eject,
                    SteamVR_Actions.vRInteraction_SlideRelease,
                    SteamVR_Actions.vRInteraction_LightToggle,
                    SteamVR_Actions.vRInteraction_ScopeToggle,
                    SteamVR_Actions.vRInteraction_TELEPORT,
                    SteamVR_Actions.vRInteraction_SWITCH,
                    SteamVR_Actions.vRInteraction_Haptic};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.default_InteractUI,
                    SteamVR_Actions.default_Teleport,
                    SteamVR_Actions.default_GrabPinch,
                    SteamVR_Actions.default_GrabGrip,
                    SteamVR_Actions.default_Pose,
                    SteamVR_Actions.default_SkeletonLeftHand,
                    SteamVR_Actions.default_SkeletonRightHand,
                    SteamVR_Actions.default_Squeeze,
                    SteamVR_Actions.default_HeadsetOnHead,
                    SteamVR_Actions.default_SnapTurnLeft,
                    SteamVR_Actions.default_SnapTurnRight,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.mixedreality_ExternalCamera,
                    SteamVR_Actions.vRInteraction_ACTION,
                    SteamVR_Actions.vRInteraction_PICKUP_DROP,
                    SteamVR_Actions.vRInteraction_PICKUP,
                    SteamVR_Actions.vRInteraction_DROP,
                    SteamVR_Actions.vRInteraction_Pose,
                    SteamVR_Actions.vRInteraction_SkeletonLeftHand,
                    SteamVR_Actions.vRInteraction_SkeletonRightHand,
                    SteamVR_Actions.vRInteraction_TriggerPressure,
                    SteamVR_Actions.vRInteraction_TouchPosition,
                    SteamVR_Actions.vRInteraction_PadTouched,
                    SteamVR_Actions.vRInteraction_PadPressed,
                    SteamVR_Actions.vRInteraction_Eject,
                    SteamVR_Actions.vRInteraction_SlideRelease,
                    SteamVR_Actions.vRInteraction_LightToggle,
                    SteamVR_Actions.vRInteraction_ScopeToggle,
                    SteamVR_Actions.vRInteraction_TELEPORT,
                    SteamVR_Actions.vRInteraction_SWITCH};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[] {
                    SteamVR_Actions.default_Haptic,
                    SteamVR_Actions.vRInteraction_Haptic};
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[] {
                    SteamVR_Actions.default_Haptic,
                    SteamVR_Actions.vRInteraction_Haptic};
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[] {
                    SteamVR_Actions.default_Pose,
                    SteamVR_Actions.mixedreality_ExternalCamera,
                    SteamVR_Actions.vRInteraction_Pose};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[] {
                    SteamVR_Actions.default_InteractUI,
                    SteamVR_Actions.default_Teleport,
                    SteamVR_Actions.default_GrabPinch,
                    SteamVR_Actions.default_GrabGrip,
                    SteamVR_Actions.default_HeadsetOnHead,
                    SteamVR_Actions.default_SnapTurnLeft,
                    SteamVR_Actions.default_SnapTurnRight,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.vRInteraction_ACTION,
                    SteamVR_Actions.vRInteraction_PICKUP_DROP,
                    SteamVR_Actions.vRInteraction_PICKUP,
                    SteamVR_Actions.vRInteraction_DROP,
                    SteamVR_Actions.vRInteraction_PadTouched,
                    SteamVR_Actions.vRInteraction_PadPressed,
                    SteamVR_Actions.vRInteraction_Eject,
                    SteamVR_Actions.vRInteraction_SlideRelease,
                    SteamVR_Actions.vRInteraction_LightToggle,
                    SteamVR_Actions.vRInteraction_ScopeToggle,
                    SteamVR_Actions.vRInteraction_TELEPORT,
                    SteamVR_Actions.vRInteraction_SWITCH};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[] {
                    SteamVR_Actions.default_Squeeze,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.vRInteraction_TriggerPressure};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[] {
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.vRInteraction_TouchPosition};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[] {
                    SteamVR_Actions.default_SkeletonLeftHand,
                    SteamVR_Actions.default_SkeletonRightHand,
                    SteamVR_Actions.vRInteraction_SkeletonLeftHand,
                    SteamVR_Actions.vRInteraction_SkeletonRightHand};
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.default_InteractUI,
                    SteamVR_Actions.default_Teleport,
                    SteamVR_Actions.default_GrabPinch,
                    SteamVR_Actions.default_GrabGrip,
                    SteamVR_Actions.default_Squeeze,
                    SteamVR_Actions.default_HeadsetOnHead,
                    SteamVR_Actions.default_SnapTurnLeft,
                    SteamVR_Actions.default_SnapTurnRight,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.vRInteraction_ACTION,
                    SteamVR_Actions.vRInteraction_PICKUP_DROP,
                    SteamVR_Actions.vRInteraction_PICKUP,
                    SteamVR_Actions.vRInteraction_DROP,
                    SteamVR_Actions.vRInteraction_TriggerPressure,
                    SteamVR_Actions.vRInteraction_TouchPosition,
                    SteamVR_Actions.vRInteraction_PadTouched,
                    SteamVR_Actions.vRInteraction_PadPressed,
                    SteamVR_Actions.vRInteraction_Eject,
                    SteamVR_Actions.vRInteraction_SlideRelease,
                    SteamVR_Actions.vRInteraction_LightToggle,
                    SteamVR_Actions.vRInteraction_ScopeToggle,
                    SteamVR_Actions.vRInteraction_TELEPORT,
                    SteamVR_Actions.vRInteraction_SWITCH};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_default_InteractUI = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/InteractUI")));
            SteamVR_Actions.p_default_Teleport = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/Teleport")));
            SteamVR_Actions.p_default_GrabPinch = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/GrabPinch")));
            SteamVR_Actions.p_default_GrabGrip = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/GrabGrip")));
            SteamVR_Actions.p_default_Pose = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/default/in/Pose")));
            SteamVR_Actions.p_default_SkeletonLeftHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/default/in/SkeletonLeftHand")));
            SteamVR_Actions.p_default_SkeletonRightHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/default/in/SkeletonRightHand")));
            SteamVR_Actions.p_default_Squeeze = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/default/in/Squeeze")));
            SteamVR_Actions.p_default_HeadsetOnHead = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/HeadsetOnHead")));
            SteamVR_Actions.p_default_SnapTurnLeft = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/SnapTurnLeft")));
            SteamVR_Actions.p_default_SnapTurnRight = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/default/in/SnapTurnRight")));
            SteamVR_Actions.p_default_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Action.Create<SteamVR_Action_Vibration>("/actions/default/out/Haptic")));
            SteamVR_Actions.p_platformer_Move = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/platformer/in/Move")));
            SteamVR_Actions.p_platformer_Jump = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/platformer/in/Jump")));
            SteamVR_Actions.p_buggy_Steering = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/buggy/in/Steering")));
            SteamVR_Actions.p_buggy_Throttle = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/buggy/in/Throttle")));
            SteamVR_Actions.p_buggy_Brake = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/buggy/in/Brake")));
            SteamVR_Actions.p_buggy_Reset = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/buggy/in/Reset")));
            SteamVR_Actions.p_mixedreality_ExternalCamera = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/mixedreality/in/ExternalCamera")));
            SteamVR_Actions.p_vRInteraction_ACTION = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/ACTION")));
            SteamVR_Actions.p_vRInteraction_PICKUP_DROP = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/PICKUP_DROP")));
            SteamVR_Actions.p_vRInteraction_PICKUP = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/PICKUP")));
            SteamVR_Actions.p_vRInteraction_DROP = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/DROP")));
            SteamVR_Actions.p_vRInteraction_Pose = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/VRInteraction/in/Pose")));
            SteamVR_Actions.p_vRInteraction_SkeletonLeftHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/VRInteraction/in/SkeletonLeftHand")));
            SteamVR_Actions.p_vRInteraction_SkeletonRightHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/VRInteraction/in/SkeletonRightHand")));
            SteamVR_Actions.p_vRInteraction_TriggerPressure = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/VRInteraction/in/TriggerPressure")));
            SteamVR_Actions.p_vRInteraction_TouchPosition = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/VRInteraction/in/TouchPosition")));
            SteamVR_Actions.p_vRInteraction_PadTouched = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/PadTouched")));
            SteamVR_Actions.p_vRInteraction_PadPressed = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/PadPressed")));
            SteamVR_Actions.p_vRInteraction_Eject = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/Eject")));
            SteamVR_Actions.p_vRInteraction_SlideRelease = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/SlideRelease")));
            SteamVR_Actions.p_vRInteraction_LightToggle = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/LightToggle")));
            SteamVR_Actions.p_vRInteraction_ScopeToggle = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/ScopeToggle")));
            SteamVR_Actions.p_vRInteraction_TELEPORT = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/TELEPORT")));
            SteamVR_Actions.p_vRInteraction_SWITCH = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/VRInteraction/in/SWITCH")));
            SteamVR_Actions.p_vRInteraction_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Action.Create<SteamVR_Action_Vibration>("/actions/VRInteraction/out/Haptic")));
        }
    }
}
