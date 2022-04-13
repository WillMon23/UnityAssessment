using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraZoomBehavior : MonoBehaviour
{
    private Camera _camera;
    [SerializeField]
    private Vector2 _refrenceAspectRatio;
    private Vector3 _startPos;
    private float _refRatio;
    [SerializeField] Vector3 _zoomScale = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _refRatio = _refrenceAspectRatio.x / _refrenceAspectRatio.y;
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        double ratio = _refRatio / _camera.aspect;
        ratio = Math.Round(ratio, 4);

        Vector3 scaledPosition = Vector3.Scale(_startPos * (float)ratio,_zoomScale);

        transform.position = scaledPosition;
    }
}
