using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormDisappear : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Form;

    private void Awake()
    {
        Form.SetActive(false);
    }

}
