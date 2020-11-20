using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salva : MonoBehaviour
{
     public Text txt;
     public InputField caixa;
     private float testf;
    
    void Start()
    {
        txt.text = PlayerPrefs.GetFloat("pontos").ToString();
    }
    public void SalvarFloat()
    {
        testf = float.Parse(caixa.text);
        PlayerPrefs.SetFloat("pontos", testf);
       
    }
    
    void Update()
    {
        
    }
}
