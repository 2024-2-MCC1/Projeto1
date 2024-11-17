using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour {
    // References to the UI panels and the game level name
    [SerializeField] private string NomeDaCenaParaIr;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;

    // carregar cena
    public void Jogar() {
        SceneManager.LoadScene(NomeDaCenaParaIr);
    }

    // abrir painel
    public void AbrirOpcoes() {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    // fechar painel
    public void FecharOpcoes() {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    // Method to exit the game
    public void SairJogo() {
        Debug.Log("Saindo do Jogo");
        Application.Quit();
    }
}
