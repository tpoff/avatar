using System.Collections.Generic;
using UnityEngine;

public class HandTrackingMapper : MonoBehaviour
{
    public Transform sourceWrist; // OpenXR hand root
    public Transform targetWrist; // Target model hand root
    public Vector3 rotationOffset = new Vector3(0, -90, 00); // Adjust if needed

    void Start()
    {
        if (sourceWrist == null || targetWrist == null)
        {
            Debug.LogError("HandTrackingMapper: Wrist references not assigned!");
            enabled = false;
            return;
        }
    }

    void Update()
    {
        if (sourceWrist != null && targetWrist != null)
        {
            targetWrist.position = sourceWrist.position;
            targetWrist.rotation = sourceWrist.rotation * Quaternion.Euler(rotationOffset);

            // Thumb
            /*Transform target = targetWrist.Find("R_ThumbMetacarpal");
            Transform source = sourceWrist.Find("R_ThumbMetacarpal");
            target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(rotationOffset);

            target = target.Find("R_ThumbProximal");
            source = source.Find("R_ThumbProximal");
            target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(rotationOffset);

            target = target.Find("R_ThumbDistal");
            source = source.Find("R_ThumbDistal");
            target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(rotationOffset);

            target = target.Find("R_ThumbTip");
            source = source.Find("R_ThumbTip");
            target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(rotationOffset);

            // Index Finger
            target = targetWrist.Find("R_IndexMetacarpal");
            source = sourceWrist.Find("R_IndexMetacarpal");
            target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(rotationOffset);

            target = target.Find("R_IndexProximal");
            source = source.Find("R_IndexProximal");
            target.position = source.position;
            target.rotation = source.rotation;

            target = target.Find("R_IndexIntermediate");
            source = source.Find("R_IndexIntermediate");
            target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(new Vector3(0, 90, 0));

            target = target.Find("R_IndexDistal");
            source = source.Find("R_IndexDistal");
            target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(new Vector3(0, 90, 0));


            // Middle Finger
            target = targetWrist.Find("R_MiddleMetacarpal");
            source = sourceWrist.Find("R_MiddleMetacarpal");
            //target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(rotationOffset);

            target = target.Find("R_MiddleProximal");
            source = source.Find("R_MiddleProximal");
            //target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(new Vector3(0, 90, 0));


            target = target.Find("R_MiddleIntermediate");
            source = source.Find("R_MiddleIntermediate");
            //target.position = source.position;
            //target.rotation = source.rotation;

            target = target.Find("R_MiddleDistal");
            source = source.Find("R_MiddleDistal");
            //target.position = source.position;
            //target.rotation = source.rotation * Quaternion.Euler(new Vector3(0, 90, 0));

            // Ring Finger
            /target = targetWrist.Find("R_RingMetacarpal");
            source = sourceWrist.Find("R_RingMetacarpal");
            //target.position = source.position;
            target.rotation = source.rotation;

            target = target.Find("R_RingProximal");
            source = source.Find("R_RingProximal");
            //target.position = source.position;
            target.rotation = source.rotation;

            target = target.Find("R_RingIntermediate");
            source = source.Find("R_RingIntermediate");
            //target.position = source.position;
            //target.rotation = source.rotation * Quaternion.Euler(new Vector3(0, 90, 0));

            target = target.Find("R_RingDistal");
            source = source.Find("R_RingDistal");
            //target.position = source.position;
            //target.rotation = source.rotation * Quaternion.Euler(new Vector3(0, 90, 0));

            // Little Finger
            target = targetWrist.Find("R_LittleMetacarpal");
            source = sourceWrist.Find("R_LittleMetacarpal");
            //target.position = source.position;
            target.rotation = source.rotation * Quaternion.Euler(rotationOffset);

            target = target.Find("R_LittleProximal");
            source = source.Find("R_LittleProximal");
            //target.position = source.position;
            target.rotation = source.rotation;

            target = target.Find("R_LittleIntermediate");
            source = source.Find("R_LittleIntermediate");
            //target.position = source.position;
            //target.rotation = source.rotation * Quaternion.Euler(new Vector3(0, 90, 0));

            target = target.Find("R_LittleDistal");
            source = source.Find("R_LittleDistal");
            //target.position = source.position;
            //target.rotation = source.rotation * Quaternion.Euler(new Vector3(0, 90, 0));*/


        }
    }
}
