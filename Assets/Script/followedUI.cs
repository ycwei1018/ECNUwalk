using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followedUI : MonoBehaviour
{
    [Header("Camera to follow")]
    public Transform cameraTransform;       // 拖 Main Camera

    [Header("Distance settings")]
    public float distance;           // UI 到眼睛的距离
    public Vector3 offset = Vector3.zero;   // 上下左右偏移

    void LateUpdate()
    {
        if (cameraTransform == null) return;

        // 跟随位置 - 在摄像机正前方 distance 米处
        transform.position = cameraTransform.position
                           + cameraTransform.forward * distance
                           + offset;

        // 跟随旋转 - 始终正对摄像机方向
        transform.rotation = Quaternion.LookRotation(cameraTransform.forward, cameraTransform.up);
    }
}
