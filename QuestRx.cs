using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class QuestRx : MonoBehaviour
{
    private static QuestRx _instance;

    private static QuestRx Instance
    {
        get
        {
            if (!_instance) _instance = new GameObject("Quest Core").AddComponent<QuestRx>();
            return _instance;
        }
    }

//    public enum Direction
//    {
//        Up,
//        Down,
//        Right,
//        Left,
//    }

    private static IObservable<Unit> updateStream =>
        Instance.UpdateAsObservable();

    public static IObservable<Unit> OnRawAnyButtonPress
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.Get(OVRInput.RawButton.Any))
                .Publish().RefCount();
        }
    }

    #region Right

    #region Button

    public static IObservable<Unit> OnRawAButtonPress
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.Get(OVRInput.RawButton.A))
                .Publish().RefCount();
        }
    }

    public static IObservable<Unit> OnRawAButtonPressDown
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.GetDown(OVRInput.RawButton.A))
                .Publish().RefCount();
        }
    }

    public static IObservable<Unit> OnRawAButtonPressUp
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.GetUp(OVRInput.RawButton.A))
                .Publish().RefCount();
        }
    }

    #endregion
    #region ThumbStick
    public static IObservable<Vector2> RightStickAxis
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.Get(OVRInput.RawAxis2D.RThumbstick) != Vector2.zero)
                .Select(ovr => OVRInput.Get(OVRInput.RawAxis2D.RThumbstick))
                .Publish().RefCount();
        }
    }

    
    public static IObservable<Unit> OnRightStickRightPressDown
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.GetDown(OVRInput.RawButton.RThumbstickRight))
                .Publish().RefCount();
        }
    }
   
    public static IObservable<Unit> OnRightStickLeftPressDown
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.GetDown(OVRInput.RawButton.RThumbstickLeft))
                .Publish().RefCount();
        }
    }
    
    
    public static IObservable<Unit> OnRightStickUpPressDown
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp))
                .Publish().RefCount();
        }
    }
    
    
    public static IObservable<Unit> OnRightStickDownPressDown
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.GetDown(OVRInput.RawButton.RThumbstickDown))
                .Publish().RefCount();
        }
    }
    #endregion
    #region Grip

    #endregion
    #endregion

    #region Left

    #region Button
    
    #endregion
    #region ThumbStick
    public static IObservable<Vector2> LeftStickAxis
    {
        get
        {
            return updateStream.Where(ovr => OVRInput.Get(OVRInput.RawAxis2D.LThumbstick) != Vector2.zero)
                .Select(ovr => OVRInput.Get(OVRInput.RawAxis2D.LThumbstick))
                .Publish().RefCount();
        }
    }
    #endregion
    #region Grip

    

    #endregion
    #endregion

}
