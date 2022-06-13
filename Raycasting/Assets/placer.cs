using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placer : MonoBehaviour
{

    public Transform cube;
    public new Camera camera;
    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;
        if (Physics.Raycast(ray, out hitinfo))
        {
            cube.position = hitinfo.point;
            cube.rotation = Quaternion.FromToRotation(Vector3.up, hitinfo.normal);
        }
    }
}
