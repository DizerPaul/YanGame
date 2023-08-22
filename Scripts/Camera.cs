using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    public float cameraOffset;

    private void LateUpdate()
    {
        transform.position = new Vector3(_target.transform.position.x + cameraOffset, 0f, -10f);
    }
}
