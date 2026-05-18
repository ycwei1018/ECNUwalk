using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TestSelect : MonoBehaviour
{
    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        Debug.Log("Hover 触发了！");
    }

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log(" Select 触发了！");
    }

    public void OnSelectExited(SelectExitEventArgs args)
    {
        Debug.Log(" Select 结束了！");
    }
}
