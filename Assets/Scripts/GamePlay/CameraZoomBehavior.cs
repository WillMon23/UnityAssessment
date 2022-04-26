using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Changes the camera position based on the aspect ratio 
public class CameraZoomBehavior : MonoBehaviour
{
    //gets a gets a refrence to the camera  
    private Camera _camera;
    //gets the use wanted aspect for the camera 
    [SerializeField]
    private Vector2 _refrenceAspectRatio;
    //Kepts track of the current camera starting position
    private Vector3 _startPos;
    //the value of the aspect of the camera devide by the x by the y 
    private float _refRatio;
    //sets the scale of the zoom 
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
        //Callculates the the ratio 
        double ratio = _refRatio / _camera.aspect;
        ratio = Math.Round(ratio, 4);

        //Callculates the the xoom based of the starting position and the sets scalining 
        Vector3 scaledPosition = Vector3.Scale(_startPos * (float)ratio,_zoomScale);
        //Sets the camera position based off it's scaled position 
        transform.position = scaledPosition;
    }
}
