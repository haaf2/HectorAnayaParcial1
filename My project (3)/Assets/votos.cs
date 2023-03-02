using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class votos : MonoBehaviour
{
    int votof=0;
    int votoc=0;
    int conteo = 0;
    [SerializeField] private TMP_Text votosfavor;
    [SerializeField] private TMP_Text votoscontra;
    [SerializeField] private TMP_Text textoinicio;
    [SerializeField] private TMP_Text final;
    [SerializeField] private TMP_Text conteol;
    [SerializeField] private TMP_Text resultado;
    // Start is called before the first frame update
    void Start()
    {
        textoinicio.text = "Listo para la votación";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void votacion(int boton)
    {
        
        if (boton==1)
        {
            votof = votof + 1;
            votosfavor.text = "Cantidad de votos a favor: " + votof;
        }
        if (boton == 2)
        {
            votoc = votoc + 1;
            votoscontra.text = "Cantidad de votos en contra: " + votoc;
        }
        if (boton == 1 || boton == 2)
        {
            conteo = conteo + 1;
            conteol.text = "Registrado voto num: " + conteo;
        }

        if (boton==4)
        {
            votof=0;
            votosfavor.text = "Cantidad de votos a favor: " + votof;
            votoc = 0;
            votoscontra.text = "Cantidad de votos en contra: " + votoc;
            conteo = 0;
            conteol.text = "Registrado voto num: " + conteo;
        }
        if (boton == 3)
        {
            final.text = "Votacion terminada";
            if(votof>votoc)
            {
                resultado.text = "Voto a favor ganó";
            }
            if (votof < votoc)
            {
                resultado.text = "Voto a en contra ganó";
            }
            if (votof == votoc)
            {
                resultado.text = "Empate";
            }

            votof = 0;
            votosfavor.text = "Cantidad de votos a favor: " + votof;
            votoc = 0;
            votoscontra.text = "Cantidad de votos en contra: " + votoc;
            conteo = 0;
            conteol.text = "Registrado voto num: " + conteo;
        }

    }
}
