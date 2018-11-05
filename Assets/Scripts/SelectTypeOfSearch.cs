using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTypeOfSearch : MonoBehaviour {

    public GameObject goLivro;
    public GameObject goAutor;
    public GameObject goArea;
    public Dropdown ddOption;
    public GameObject search;
	// Use this for initialization
	void Start () {
        SetAllOptionsFalse();
	}

    public void SetAllOptionsFalse()
    {
        goLivro.SetActive(false);
        goAutor.SetActive(false);
        goArea.SetActive(false);
    }
	
	// Update is called once per frame
	public void GetTypeOfOption () {
        switch (ddOption.value)
        {
            //opcao area
            case (0):
                goLivro.SetActive(false);
                goAutor.SetActive(false);
                goArea.SetActive(true);
                search.SetActive(false);
                break;
            //opcao livro
            case (1):
                goLivro.SetActive(true);
                goAutor.SetActive(false);
                goArea.SetActive(false);
                search.SetActive(false);
                break;
            //opcao autor
            case (2):
                goLivro.SetActive(false);
                goAutor.SetActive(true);
                goArea.SetActive(false);
                search.SetActive(false);
                break;
        }
	}
}
