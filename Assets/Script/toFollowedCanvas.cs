using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toFollowedCanvas : MonoBehaviour
{
    public GameObject targetCanvas;   // ÍÏ»­²¼
    private bool isVisible = false;

    public void TogglePanel()
    {
        isVisible = !isVisible;
        targetCanvas.SetActive(isVisible);
    }
}
