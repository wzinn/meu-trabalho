using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

using TMPro;
public class GAMEMANAGE : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVITORIA;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<moeda>().Length;

        hud.text = $"moedas restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"moedas restantes: {restantes}";
        source.PlayOneShot(clipMoeda);
    
        if (restantes <= 0)
        {
            msgVITORIA.text = "parabens!";
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
