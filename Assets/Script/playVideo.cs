using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playVideo : MonoBehaviour
{
    [Header("Camera to follow")]
    public Transform cameraTransform;       // ÍÏÉãÏñ»ú

    [Header("Distance Settings")]
    public float triggerDistance = 6f;
    public float stopDistance = 8f;

    private List<VideoPlayer> spheres = new List<VideoPlayer>();

    void Start()
    {
        spheres.Clear();
        spheres.AddRange(GetComponentsInChildren<VideoPlayer>());

        if (cameraTransform == null && Camera.main != null)
            cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if (cameraTransform == null) return;

        foreach (var vp in spheres)
        {
            if (vp == null) continue;

            float dist = Vector3.Distance(
                cameraTransform.position,
                vp.transform.position
            );

            if (!vp.isPlaying && dist < triggerDistance)
                vp.Play();

            if (vp.isPlaying && dist > stopDistance)
                vp.Stop();
        }
    }
}
