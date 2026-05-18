using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class priority_in100 : MonoBehaviour
{
    public Transform mainCamera;        // 主摄像机
    public Transform canvasParent;      // CanvasManager
    public int normalOrder = 0;         // 默认层级
    public int topOrder = 100;          // 前置层级
    public float radius = 70f;          // 半径70

    private List<Canvas> uiList = new List<Canvas>();

    void Start()
    {
        // 自动找到所有子 Canvas
        uiList.AddRange(canvasParent.GetComponentsInChildren<Canvas>(true));
    }

    void Update()
    {
        if (mainCamera == null) return;

        foreach (var ui in uiList)
        {
            if (ui == null) continue;

            float distance = Vector3.Distance(mainCamera.position, ui.transform.position);

            ui.sortingOrder = (distance <= radius) ? topOrder : normalOrder;
        }
    }
}
