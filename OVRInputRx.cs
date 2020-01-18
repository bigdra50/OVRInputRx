using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public static class OVRInputRx
{
    enum OVRInputEventType
    {
        Press,
        PressDown,
        PressUp,
    }

    #region Button

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.Button, OVRInput.Controller, bool>> OVR_DELEGATE_BUTTON_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.Button, OVRInput.Controller, bool>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
            {OVRInputEventType.PressDown, OVRInput.GetDown},
            {OVRInputEventType.PressUp, OVRInput.GetUp},
        };

    public static IObservable<Unit> OnPressButtonAsObservable(OVRInput.Button button)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, button);
    }

    public static IObservable<Unit> OnPressButtonDownAsObservable(OVRInput.Button button)
    {
        return GetOrCreateSubject(OVRInputEventType.PressDown, button);
    }

    public static IObservable<Unit> OnPressButtonUpAsObservable(OVRInput.Button button)
    {
        return GetOrCreateSubject(OVRInputEventType.PressUp, button);
    }

    static IObservable<Unit> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.RawButton button)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Where(_ => OVR_DELEGATE_RAWBUTTON_MAP[ovrInputEventType](button, controllerMask)).AsUnitObservable();
    }

    #endregion

    #region RawButton

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.RawButton, OVRInput.Controller, bool>> OVR_DELEGATE_RAWBUTTON_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.RawButton, OVRInput.Controller, bool>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
            {OVRInputEventType.PressDown, OVRInput.GetDown},
            {OVRInputEventType.PressUp, OVRInput.GetUp},
        };

    public static IObservable<Unit> OnPressRawButtonAsObservable(OVRInput.RawButton button)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, button);
    }

    public static IObservable<Unit> OnPressRawButtonDownAsObservable(OVRInput.RawButton button)
    {
        return GetOrCreateSubject(OVRInputEventType.PressDown, button);
    }

    public static IObservable<Unit> OnPressRawButtonUpAsObservable(OVRInput.RawButton button)
    {
        return GetOrCreateSubject(OVRInputEventType.PressUp, button);
    }

    static IObservable<Unit> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.Button button)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Where(_ => OVR_DELEGATE_BUTTON_MAP[ovrInputEventType](button, controllerMask)).AsUnitObservable();
    }

    #endregion

    #region Touch

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.Touch, OVRInput.Controller, bool>> OVR_DELEGATE_TOUCH_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.Touch, OVRInput.Controller, bool>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
            {OVRInputEventType.PressDown, OVRInput.GetDown},
            {OVRInputEventType.PressUp, OVRInput.GetUp},
        };

    public static IObservable<Unit> OnPressTouchAsObservable(OVRInput.Touch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, touch);
    }

    public static IObservable<Unit> OnPressTouchDownAsObservable(OVRInput.Touch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.PressDown, touch);
    }

    public static IObservable<Unit> OnPressTouchUpAsObservable(OVRInput.Touch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.PressUp, touch);
    }

    static IObservable<Unit> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.Touch touch)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Where(_ => OVR_DELEGATE_TOUCH_MAP[ovrInputEventType](touch, controllerMask)).AsUnitObservable();
    }

    #endregion

    #region RawTouch

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.RawTouch, OVRInput.Controller, bool>> OVR_DELEGATE_RAWTOUCH_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.RawTouch, OVRInput.Controller, bool>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
            {OVRInputEventType.PressDown, OVRInput.GetDown},
            {OVRInputEventType.PressUp, OVRInput.GetUp},
        };

    public static IObservable<Unit> OnPressRawTouchAsObservable(OVRInput.RawTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, touch);
    }

    public static IObservable<Unit> OnPressRawTouchDownAsObservable(OVRInput.RawTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.PressDown, touch);
    }

    public static IObservable<Unit> OnPressRawTouchUpAsObservable(OVRInput.RawTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.PressUp, touch);
    }

    static IObservable<Unit> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.RawTouch touch)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Where(_ => OVR_DELEGATE_RAWTOUCH_MAP[ovrInputEventType](touch, controllerMask)).AsUnitObservable();
    }

    #endregion

    #region NearTouch

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.NearTouch, OVRInput.Controller, bool>> OVR_DELEGATE_NEARTOUCH_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.NearTouch, OVRInput.Controller, bool>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
            {OVRInputEventType.PressDown, OVRInput.GetDown},
            {OVRInputEventType.PressUp, OVRInput.GetUp},
        };

    public static IObservable<Unit> OnPressNearTouchAsObservable(OVRInput.NearTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, touch);
    }

    public static IObservable<Unit> OnPressNearTouchDownAsObservable(OVRInput.NearTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.PressDown, touch);
    }

    public static IObservable<Unit> OnPressNearTouchUpAsObservable(OVRInput.NearTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.PressUp, touch);
    }

    static IObservable<Unit> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.NearTouch touch)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Where(_ => OVR_DELEGATE_NEARTOUCH_MAP[ovrInputEventType](touch, controllerMask)).AsUnitObservable();
    }

    #endregion

    #region RawNearTouch

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.RawNearTouch, OVRInput.Controller, bool>> OVR_DELEGATE_RAWNEARTOUCH_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.RawNearTouch, OVRInput.Controller, bool>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
            {OVRInputEventType.PressDown, OVRInput.GetDown},
            {OVRInputEventType.PressUp, OVRInput.GetUp},
        };

    public static IObservable<Unit> OnPressRawNearTouchAsObservable(OVRInput.RawNearTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, touch);
    }

    public static IObservable<Unit> OnPressRawNearTouchDownAsObservable(OVRInput.RawNearTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.PressDown, touch);
    }

    public static IObservable<Unit> OnPressRawNearTouchUpAsObservable(OVRInput.RawNearTouch touch)
    {
        return GetOrCreateSubject(OVRInputEventType.PressUp, touch);
    }

    static IObservable<Unit> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.RawNearTouch touch)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Where(_ => OVR_DELEGATE_RAWNEARTOUCH_MAP[ovrInputEventType](touch, controllerMask)).AsUnitObservable();
    }

    #endregion

    #region Axis1D

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.Axis1D, OVRInput.Controller, float>> OVR_DELEGATE_AXIS1D_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.Axis1D, OVRInput.Controller, float>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
        };

    public static IObservable<float> OnPressAxis1DAsObservable(OVRInput.Axis1D axis1d)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, axis1d);
    }

    static IObservable<float> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.Axis1D axis1d)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Select(ovrAxis1D => OVR_DELEGATE_AXIS1D_MAP[ovrInputEventType](axis1d, controllerMask)).AsObservable<float>();
    }

    #endregion

    #region RawAxis1D

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.RawAxis1D, OVRInput.Controller, float>> OVR_DELEGATE_RAWAXIS1D_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.RawAxis1D, OVRInput.Controller, float>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
        };

    public static IObservable<float> OnPressRawAxis1DAsObservable(OVRInput.RawAxis1D axis1d)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, axis1d);
    }

    static IObservable<float> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.RawAxis1D axis1d)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Select(ovrRawAxis1D => OVR_DELEGATE_RAWAXIS1D_MAP[ovrInputEventType](axis1d, controllerMask))
            .AsObservable<float>();
    }

    #endregion

    #region Axis2D

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.Axis2D, OVRInput.Controller, Vector2>> OVR_DELEGATE_AXIS2D_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.Axis2D, OVRInput.Controller, Vector2>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
        };

    public static IObservable<Vector2> OnPressAxis2DAsObservable(OVRInput.Axis2D axis2d)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, axis2d);
    }

    static IObservable<Vector2> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.Axis2D axis2d)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Select(ovrAxis2D => OVR_DELEGATE_AXIS2D_MAP[ovrInputEventType](axis2d, controllerMask))
            .AsObservable<Vector2>();
    }

    #endregion

    #region RawAxis2D

    static readonly Dictionary<OVRInputEventType, Func<OVRInput.RawAxis2D, OVRInput.Controller, Vector2>> OVR_DELEGATE_RAWAXIS2D_MAP =
        new Dictionary<OVRInputEventType, Func<OVRInput.RawAxis2D, OVRInput.Controller, Vector2>>()
        {
            {OVRInputEventType.Press, OVRInput.Get},
        };

    public static IObservable<Vector2> OnPressRawAxis2DAsObservable(OVRInput.RawAxis2D rawaxis2d)
    {
        return GetOrCreateSubject(OVRInputEventType.Press, rawaxis2d);
    }

    static IObservable<Vector2> GetOrCreateSubject(OVRInputEventType ovrInputEventType, OVRInput.RawAxis2D rawaxis2d)
    {
        var controllerMask = OVRInput.Controller.Active;
        return Observable.EveryUpdate().Select(ovrRawAxis2D => OVR_DELEGATE_RAWAXIS2D_MAP[ovrInputEventType](rawaxis2d, controllerMask))
            .AsObservable<Vector2>();
    }

    #endregion
}