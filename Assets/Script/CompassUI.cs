using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassUI : MonoBehaviour
{
    public Transform playerCamera;

    void Update()
    {
        if (playerCamera == null) return;

        float yRot = playerCamera.eulerAngles.y;
        transform.localEulerAngles = new Vector3(0, 0, yRot);
    }
}
