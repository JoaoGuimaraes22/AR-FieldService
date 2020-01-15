using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class NotAppear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myForm;
    private ARTrackedImageManager _manager;

    private void Awake()
    {
        _manager = FindObjectOfType<ARTrackedImageManager>();
        myForm.SetActive(false);
    }

    private void OnEnable()
    {
        _manager.trackedImagesChanged += OnImgChanged;
    }

    private void OnDisable()
    {
        _manager.trackedImagesChanged -= OnImgChanged;
    }

    private void OnImgChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var img in args.added)
        {
            myForm.SetActive(true);
            Debug.Log(img.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
