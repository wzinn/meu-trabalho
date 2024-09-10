using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class GAMEMANAGE : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVITORIA;
    public int restantes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;

        hud.text = $"moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";
    
        if (restantes <= 0)
        {
            msgVITORIA.text = "parabens!";
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
