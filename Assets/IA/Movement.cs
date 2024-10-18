using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    private void Update()
    {
        Vector3 pos = transform.position;
        float step = speed * Time.deltaTime;
        float x = pos.x += (Input.GetAxis("Horizontal")*step);
        float z = pos.z += (Input.GetAxis("Vertical") * step);
        this.transform.position = new Vector3(x, pos.y, z);
    }
}
