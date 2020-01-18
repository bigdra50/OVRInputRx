using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class OVRInputRxTest : MonoBehaviour
{
    void Start()
    {
        #region ButtonTest

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.None)
            .Subscribe(_ => { Debug.Log("Press Button None"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.One)
            .Subscribe(_ => { Debug.Log("Press Button One"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Two)
            .Subscribe(_ => { Debug.Log("Press Button Two"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Three)
            .Subscribe(_ => { Debug.Log("Press Button Three"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Four)
            .Subscribe(_ => { Debug.Log("Press Button Four"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Start)
            .Subscribe(_ => { Debug.Log("Press Button Start"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Back)
            .Subscribe(_ => { Debug.Log("Press Button Back"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryShoulder)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryShoulder"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryIndexTrigger"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryHandTrigger)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryHandTrigger"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryThumbstick)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryThumbstick"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryThumbstickUp)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryThumbstickUp"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryThumbstickDown)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryThumbstickDown"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryThumbstickLeft)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryThumbstickLeft"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryThumbstickRight)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryThumbstickRight"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.PrimaryTouchpad)
            .Subscribe(_ => { Debug.Log("Press Button PrimaryTouchpad"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryShoulder)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryShoulder"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryIndexTrigger"); });


        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryHandTrigger)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryHandTrigger"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryThumbstick)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryThumbstick"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryThumbstickUp)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryThumbstickUp"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryThumbstickDown)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryThumbstickDown"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryThumbstickLeft)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryThumbstickLeft"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryThumbstickRight)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryThumbstickRight"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.SecondaryTouchpad)
            .Subscribe(_ => { Debug.Log("Press Button SecondaryTouchpad"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.DpadUp)
            .Subscribe(_ => { Debug.Log("Press Button DpadUp"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.DpadDown)
            .Subscribe(_ => { Debug.Log("Press Button DpadDown"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.DpadLeft)
            .Subscribe(_ => { Debug.Log("Press Button DpadLeft"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.DpadRight)
            .Subscribe(_ => { Debug.Log("Press Button DpadRight"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Up)
            .Subscribe(_ => { Debug.Log("Press Button Up"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Down)
            .Subscribe(_ => { Debug.Log("Press Button Down"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Left)
            .Subscribe(_ => { Debug.Log("Press Button Left"); });

        OVRInputRx.OnPressButtonAsObservable(OVRInput.Button.Right)
            .Subscribe(_ => { Debug.Log("Press Button Right"); });

        #endregion

        #region RawButtonTest

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.None)
            .Subscribe(_ => { Debug.Log("Press RawButton None"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.A)
            .Subscribe(_ => { Debug.Log("Press RawButton A"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.B)
            .Subscribe(_ => { Debug.Log("Press RawButton B"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.X)
            .Subscribe(_ => { Debug.Log("Press RawButton X"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.Y)
            .Subscribe(_ => { Debug.Log("Press RawButton Y"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.Start)
            .Subscribe(_ => { Debug.Log("Press RawButton Start"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.Back)
            .Subscribe(_ => { Debug.Log("Press RawButton Back"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LShoulder)
            .Subscribe(_ => { Debug.Log("Press RawButton LShoulder"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press RawButton LIndexTrigger"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LHandTrigger)
            .Subscribe(_ => { Debug.Log("Press RawButton LHandTrigger"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LThumbstick)
            .Subscribe(_ => { Debug.Log("Press RawButton LThumbstick"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LThumbstickUp)
            .Subscribe(_ => { Debug.Log("Press RawButton LThumbstickUp"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LThumbstickDown)
            .Subscribe(_ => { Debug.Log("Press RawButton LThumbstickDown"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LThumbstickLeft)
            .Subscribe(_ => { Debug.Log("Press RawButton LThumbstickLeft"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LThumbstickRight)
            .Subscribe(_ => { Debug.Log("Press RawButton LThumbstickRight"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.LTouchpad)
            .Subscribe(_ => { Debug.Log("Press RawButton LTouchpad"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RShoulder)
            .Subscribe(_ => { Debug.Log("Press RawButton RShoulder"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press RawButton RIndexTrigger"); });


        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RHandTrigger)
            .Subscribe(_ => { Debug.Log("Press RawButton RHandTrigger"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RThumbstick)
            .Subscribe(_ => { Debug.Log("Press RawButton RThumbstick"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RThumbstickUp)
            .Subscribe(_ => { Debug.Log("Press RawButton RThumbstickUp"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RThumbstickDown)
            .Subscribe(_ => { Debug.Log("Press RawButton RThumbstickDown"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RThumbstickLeft)
            .Subscribe(_ => { Debug.Log("Press RawButton RThumbstickLeft"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RThumbstickRight)
            .Subscribe(_ => { Debug.Log("Press RawButton RThumbstickRight"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.RTouchpad)
            .Subscribe(_ => { Debug.Log("Press RawButton RTouchpad"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.DpadUp)
            .Subscribe(_ => { Debug.Log("Press RawButton DpadUp"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.DpadDown)
            .Subscribe(_ => { Debug.Log("Press RawButton DpadDown"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.DpadLeft)
            .Subscribe(_ => { Debug.Log("Press RawButton DpadLeft"); });

        OVRInputRx.OnPressRawButtonAsObservable(OVRInput.RawButton.DpadRight)
            .Subscribe(_ => { Debug.Log("Press RawButton DpadRight"); });

        #endregion

        #region TouchTest

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.None)
            .Subscribe(_ => { Debug.Log("Press Touch None"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.One)
            .Subscribe(_ => { Debug.Log("Press Touch One"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.Two)
            .Subscribe(_ => { Debug.Log("Press Touch Two"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.Three)
            .Subscribe(_ => { Debug.Log("Press Touch Three"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.Four)
            .Subscribe(_ => { Debug.Log("Press Touch Four"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.PrimaryIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press Touch PrimaryIndexTrigger"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.PrimaryThumbstick)
            .Subscribe(_ => { Debug.Log("Press Touch PrimaryThumbstick"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.PrimaryThumbRest)
            .Subscribe(_ => { Debug.Log("Press Touch PrimaryThumbRest"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.PrimaryTouchpad)
            .Subscribe(_ => { Debug.Log("Press Touch PrimaryTouchpad"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.SecondaryIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press Touch SecondaryIndexTrigger"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.SecondaryThumbstick)
            .Subscribe(_ => { Debug.Log("Press Touch SecondaryThumbstick"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.SecondaryThumbRest)
            .Subscribe(_ => { Debug.Log("Press Touch SecondaryThumbRest"); });

        OVRInputRx.OnPressTouchAsObservable(OVRInput.Touch.SecondaryTouchpad)
            .Subscribe(_ => { Debug.Log("Press Touch SecondaryTouchpad"); });

        #endregion

        #region RawTouchTest

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.None)
            .Subscribe(_ => { Debug.Log("Press RawTouch None"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.A)
            .Subscribe(_ => { Debug.Log("Press RawTouch A"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.B)
            .Subscribe(_ => { Debug.Log("Press RawTouch B"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.X)
            .Subscribe(_ => { Debug.Log("Press RawTouch X"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.Y)
            .Subscribe(_ => { Debug.Log("Press RawTouch Y"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.LIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press RawTouch LIndexTrigger"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.LThumbstick)
            .Subscribe(_ => { Debug.Log("Press RawTouch LThumbstick"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.LThumbRest)
            .Subscribe(_ => { Debug.Log("Press RawTouch LThumbRest"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.LTouchpad)
            .Subscribe(_ => { Debug.Log("Press RawTouch LTouchpad"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.RIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press RawTouch RIndexTrigger"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.RThumbstick)
            .Subscribe(_ => { Debug.Log("Press RawTouch RThumbstick"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.RThumbRest)
            .Subscribe(_ => { Debug.Log("Press RawTouch RThumbRest"); });

        OVRInputRx.OnPressRawTouchAsObservable(OVRInput.RawTouch.RTouchpad)
            .Subscribe(_ => { Debug.Log("Press RawTouch RTouchpad"); });

        #endregion

        #region NearTouch

        OVRInputRx.OnPressNearTouchAsObservable(OVRInput.NearTouch.None)
            .Subscribe(_ => { Debug.Log("Press NearTouch None"); });

        OVRInputRx.OnPressNearTouchAsObservable(OVRInput.NearTouch.PrimaryIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press NearTouch PrimaryIndexTrigger"); });

        OVRInputRx.OnPressNearTouchAsObservable(OVRInput.NearTouch.PrimaryThumbButtons)
            .Subscribe(_ => { Debug.Log("Press NearTouch PrimaryThumbButtons"); });

        OVRInputRx.OnPressNearTouchAsObservable(OVRInput.NearTouch.SecondaryIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press NearTouch SecondaryIndexTrigger"); });

        OVRInputRx.OnPressNearTouchAsObservable(OVRInput.NearTouch.SecondaryThumbButtons)
            .Subscribe(_ => { Debug.Log("Press NearTouch SecondaryThumbButtons"); });

        #endregion

        #region RawNearTouch

        OVRInputRx.OnPressRawNearTouchAsObservable(OVRInput.RawNearTouch.None)
            .Subscribe(_ => { Debug.Log("Press RawNearTouch None"); });

        OVRInputRx.OnPressRawNearTouchAsObservable(OVRInput.RawNearTouch.LIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press RawNearTouch LIndexTrigger"); });

        OVRInputRx.OnPressRawNearTouchAsObservable(OVRInput.RawNearTouch.LThumbButtons)
            .Subscribe(_ => { Debug.Log("Press RawNearTouch LumbButtons"); });

        OVRInputRx.OnPressRawNearTouchAsObservable(OVRInput.RawNearTouch.RIndexTrigger)
            .Subscribe(_ => { Debug.Log("Press RawNearTouch RIndexTrigger"); });

        OVRInputRx.OnPressRawNearTouchAsObservable(OVRInput.RawNearTouch.RThumbButtons)
            .Subscribe(_ => { Debug.Log("Press RawNearTouch RThumbButtons"); });

        #endregion

        #region Axis1DTest

        OVRInputRx.OnPressAxis1DAsObservable(OVRInput.Axis1D.PrimaryIndexTrigger)
            .Subscribe(ovrAxis1D => Debug.Log($"PrimaryIndexTrigger Axis1D Value: {ovrAxis1D}"));

        OVRInputRx.OnPressAxis1DAsObservable(OVRInput.Axis1D.PrimaryHandTrigger)
            .Subscribe(ovrAxis1D => Debug.Log($"PrimaryHandTrigger Axis1D Value: {ovrAxis1D}"));

        OVRInputRx.OnPressAxis1DAsObservable(OVRInput.Axis1D.SecondaryIndexTrigger)
            .Subscribe(ovrAxis1D => Debug.Log($"SecondaryIndexTrigger Axis1D Value: {ovrAxis1D}"));

        OVRInputRx.OnPressAxis1DAsObservable(OVRInput.Axis1D.SecondaryHandTrigger)
            .Subscribe(ovrAxis1D => Debug.Log($"SecondaryHandTrigger Value: {ovrAxis1D}"));

        #endregion

        #region RawAxis1DTest

        OVRInputRx.OnPressRawAxis1DAsObservable(OVRInput.RawAxis1D.LIndexTrigger)
            .Subscribe(ovrRawAxis1D => Debug.Log($"LIndexTrigger RawAxis1D Value: {ovrRawAxis1D}"));

        OVRInputRx.OnPressRawAxis1DAsObservable(OVRInput.RawAxis1D.LHandTrigger)
            .Subscribe(ovrRawAxis1D => Debug.Log($"LHandTrigger RawAxis1D Value: {ovrRawAxis1D}"));

        OVRInputRx.OnPressRawAxis1DAsObservable(OVRInput.RawAxis1D.RIndexTrigger)
            .Subscribe(ovrRawAxis1D => Debug.Log($"RIndexTrigger RawAxis1D Value: {ovrRawAxis1D}"));

        OVRInputRx.OnPressRawAxis1DAsObservable(OVRInput.RawAxis1D.RHandTrigger)
            .Subscribe(ovrRawAxis1D => Debug.Log($"RHandTrigger Value: {ovrRawAxis1D}"));

        #endregion

        #region Axis2DTest

        OVRInputRx.OnPressAxis2DAsObservable(OVRInput.Axis2D.PrimaryThumbstick)
            .Subscribe(ovrAxis2D => Debug.Log($"PrimaryThumbstick Axis2D Value: {ovrAxis2D}"));

        OVRInputRx.OnPressAxis2DAsObservable(OVRInput.Axis2D.PrimaryTouchpad)
            .Subscribe(ovrAxis2D => Debug.Log($"PrimaryTouchpad Axis2D Value: {ovrAxis2D}"));

        OVRInputRx.OnPressAxis2DAsObservable(OVRInput.Axis2D.SecondaryThumbstick)
            .Subscribe(ovrAxis2D => Debug.Log($"SecondaryThumbstick Axis2D Value: {ovrAxis2D}"));

        OVRInputRx.OnPressAxis2DAsObservable(OVRInput.Axis2D.SecondaryTouchpad)
            .Subscribe(ovrAxis2D => Debug.Log($"SecondaryTouchpad Value: {ovrAxis2D}"));

        #endregion

        #region RawAxis2DTest

        OVRInputRx.OnPressRawAxis2DAsObservable(OVRInput.RawAxis2D.LThumbstick)
            .Subscribe(ovrRawAxis2D => Debug.Log($"LThumbstick RawAxis2D Value: {ovrRawAxis2D}"));

        OVRInputRx.OnPressRawAxis2DAsObservable(OVRInput.RawAxis2D.LTouchpad)
            .Subscribe(ovrRawAxis2D => Debug.Log($"LTouchpad RawAxis2D Value: {ovrRawAxis2D}"));

        OVRInputRx.OnPressRawAxis2DAsObservable(OVRInput.RawAxis2D.RThumbstick)
            .Subscribe(ovrRawAxis2D => Debug.Log($"RThumbstick RawAxis2D Value: {ovrRawAxis2D}"));

        OVRInputRx.OnPressRawAxis2DAsObservable(OVRInput.RawAxis2D.RTouchpad)
            .Subscribe(ovrRawAxis2D => Debug.Log($"RTouchpad Value: {ovrRawAxis2D}"));

        #endregion
    }
}