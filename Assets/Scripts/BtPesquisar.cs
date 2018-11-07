using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
public class BtPesquisar : MonoBehaviour {

	List<GameObject> markers = new List<GameObject>();
    Text caminhoText;
    public DontDestroyMarkers markers_;

    public void BackToDefaultState()
    {
        markers = markers_.returnListOfMarkers();

        for (int i = 0; i < markers.Count; i++)
        {
            markers[i].GetComponent<Directions>().InsertDirection(-1);
        }

        caminhoText = GameObject.FindGameObjectWithTag("caminhoText").GetComponent<Text>();

        caminhoText.text = "Você ainda não selecionou nenhum caminho.";

    }

}
