using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACartaQueSaiuFoi : MonoBehaviour
{
    string[] cartas = new string[] { "Às de Paus", "Dois de Paus", "Três de Paus", "Quatro de Paus", "Cinco de Paus", "Seis de Paus", "Sete de Paus",
    "Oito de Paus", "Nove de Paus", "Dez de Paus", "Valete de Paus", "Dama de Paus", "Rei de Paus", "Às de Ouros", "Dois de Ouros", "Três de Ouros",
    "Quatro de Ouros", "Cinco de Ouros", "Seis de Ouros", "Sete de Ouros", "Oito de Ouros", "Nove de Ouros", "Dez de Ouros", "Valete de Ouros", "Dama de Ouros",
    "Rei de Ouros", "Às de Espadas", "Dois de Espadas", "Três de Espadas", "Quatro de Espadas", "Cinco de Espadas", "Seis de Espadas", "Sete de Espadas",
    "Oito de Espadas", "Nove de Espadas", "Dez de Espadas", "Valete de Espadas", "Dama de Espadas", "Rei de Espadas", "Às de Copas", "Dois de Copas", "Três de Copas",
    "Quatro de Copas", "Cinco de Copas", "Seis de Copas", "Sete de Copas", "Oito de Copas", "Nove de Copas", "Dez de Copas", "Valete de Copas", "Dama de Copas",
    "Rei de Copas"};

    void Start()
    {
        IniciaJogo();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TiraACartaEImprime();
        }

    }

    void TiraACartaEImprime()
    {
        int indiceDaCartaSorteada = Random.Range(0, cartas.Length); //*.length para saber o tamanho do vetor
        Debug.Log("A carta que saiu foi " + cartas[indiceDaCartaSorteada]);
        Debug.Log("Prime novamente a tecla do espaço para sair outra carta!");
    }

    void IniciaJogo()
    {
        Debug.Log("Olá, vamos jogar um jogo!");
        Debug.Log("O baralho tem " + cartas.Length + " cartas!");
        Debug.Log("Carrega na tecla espaço para sair uma carta!");
    }
}