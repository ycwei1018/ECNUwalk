using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class getTextInfo : MonoBehaviour
{
    public GameObject imageObject;  // ÍÏImage

    public void ShowImage()
    {
        if (imageObject != null)
        {
            imageObject.SetActive(!imageObject.activeSelf);
        }
    }
}
