using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    public Text txt;
    public InputField input;
    public Toggle val;
    public Toggle dan;
    public Toggle loc;
    public Toggle instr;



    // Start is called before the first frame update
    private void Awake()
    {
        txt.text = "This a text";
    }

    public void ChangeText()
    {
        txt.text = $"Working: {input.text}, {val.isOn.ToString()}, {dan.isOn.ToString()}, {loc.isOn.ToString()}, {instr.isOn.ToString()},";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
