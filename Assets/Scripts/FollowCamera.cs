using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.XR;
using Valve.VR;
using InputTracking = UnityEngine.XR.InputTracking;

public class FollowCamera : MonoBehaviour
{
    void Start() 
    {
        InputTracking.disablePositionalTracking = false;
        var rotation = Utils.getYAxisRotation(transform.rotation);
        transform.parent.parent.localRotation = Quaternion.Inverse(rotation);

    }

}
