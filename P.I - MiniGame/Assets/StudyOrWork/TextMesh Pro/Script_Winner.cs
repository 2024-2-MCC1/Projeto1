using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scrpt_Winner : MonoBehaviour
{
    public TextMeshProUGUI texto_MALDITO;
    public float teme;
    public float r;
    public float g;
    public float b;
    public float intensity;
    public float regulator;
    public bool a = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (teme >= intensity)
        {
            a = false;
        }
        if (a == true)
        {
            teme += Time.deltaTime * 2f;
        }
        else
        {
            teme -= Time.deltaTime * 2f;
        }
        if (teme <= -1 )
        {
            a = true;
        }
        teme = Mathf.Clamp(teme, -1f, intensity);
        texto_MALDITO.fontMaterial.SetColor(ShaderUtilities.ID_GlowColor, new Color(r, g, b,1) * teme);
    }
}
