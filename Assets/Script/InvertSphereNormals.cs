using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class InvertSphereNormals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;

        // 1. 翻转法线
        Vector3[] normals = mesh.normals;
        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = -normals[i];
        }
        mesh.normals = normals;

        // 2. 反转三角形顺序
        for (int i = 0; i < mesh.subMeshCount; i++)
        {
            int[] triangles = mesh.GetTriangles(i);
            for (int j = 0; j < triangles.Length; j += 3)
            {
                // 交换两个顶点，改变三角形顺序
                int temp = triangles[j];
                triangles[j] = triangles[j + 1];
                triangles[j + 1] = temp;
            }
            mesh.SetTriangles(triangles, i);
        }

        // 3. 翻转 UV 
        Vector2[] uvs = mesh.uv;
        for (int i = 0; i < uvs.Length; i++)
        {
            uvs[i].x = 1 - uvs[i].x;  // 反转 U 坐标
        }
        mesh.uv = uvs;
    }

}
