using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipFaces : MonoBehaviour
{
    void OnEnable()
    {
        InvertSphere();
    }

    void InvertSphere()
    {
        if(this.TryGetComponent(out MeshFilter mesh))
        {
            Vector3[] normals = mesh.mesh.normals;
            for (int i = 0; i < normals.Length; i++)
            {
                normals[i] = -normals[i];
            }
            mesh.mesh.normals = normals;

            int[] triangles = mesh.mesh.triangles;
            for (int i = 0; i < triangles.Length; i += 3)
            {
                int t = triangles[i];
                triangles[i] = triangles[i + 2];
                triangles[i + 2] = t;
            }

            mesh.mesh.triangles = triangles;
        }
    }
}
