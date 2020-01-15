using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetData : MonoBehaviour
{

    public InputField _input;
    public Toggle Validade;
    public Toggle Danos;
    public Toggle Localizacao;
    public Toggle Instrucoes;
    public Text debug;
    public Text debugTwo;
    public void HandleClick()
    {
        string comment = _input.text;
        bool validade = Validade.isOn;
        bool danos = Danos.isOn;
        bool localizacao = Localizacao.isOn;
        bool instrucoes = Instrucoes.isOn;

        debug.text = $"This is the text now: {comment} {validade.ToString()} {danos.ToString()} {localizacao.ToString()} {instrucoes.ToString()}";
        debugTwo.text = $"This is the text now: {comment} {validade.ToString()} {danos.ToString()} {localizacao.ToString()} {instrucoes.ToString()}";




    } 

    // Start is called before the first frame update
    void Start()
    {
        _input = FindObjectOfType<InputField>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
