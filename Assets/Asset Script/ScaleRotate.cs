using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleRotate : MonoBehaviour
{
    public Slider RotateSlider;
    public Slider ScaleSlider;

    [SerializeField] float currentRotation = 0.0f;
    [SerializeField] float currentScale = 0.2f;
    
    void Start()
    {
        RotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
    }

    void Update()
    {
        transform.localEulerAngles = new Vector3(0.0f, RotateSlider.value, 0.0f);
        transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
    }

    private void OnGUI()
    {
        currentRotation = GUI.HorizontalSlider(new Rect(348.6f, -126.0f, 247.0731f, 33.71627f), currentRotation, 0.0f, 360.0f);
        transform.Rotate(new Vector3(0.0f, currentRotation, 0.0f));
        currentScale = GUI.HorizontalSlider(new Rect(348.6f, -309.0f, 247.0731f, 33.71627f), currentScale, 0.2f, 1.0f);
        transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }

    public void AdjustAngle(float newAngle)
    {
        
    }
    public void AdjustScale(float newScale)
    {
        
    }
}
