using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageTracker : MonoBehaviour
{
    public GameObject Form;
    private ARTrackedImageManager _artracker;

    private void Awake()
    {
        _artracker = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        _artracker.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        _artracker.trackedImagesChanged -= OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var img in args.added)
        {
            Form.SetActive(true);
            Debug.Log(img.name);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
