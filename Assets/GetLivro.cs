using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLivro : MonoBehaviour {

    List<string> nome_livros = new List<string>();
    public InputField bookText;
    public Dropdown ddOptions;
    public GameObject pesquisa;
    public GameObject pesquisaLivro;

    public void GetLivroToDropDown()
    {
        SqliteDatabase sqlDB = new SqliteDatabase("bibliotecago_v01.db");
        string query = "SELECT * FROM livros WHERE liv_name LIKE '%"+bookText.text+"%'";
        DataTable data = sqlDB.ExecuteQuery(query);
        string name = "";
        foreach (DataRow dr in data.Rows)
        {
            name = (string)dr["liv_name"];
            nome_livros.Add(name);
        }

        ddOptions.ClearOptions();
        //Add the options created in the List above
        ddOptions.AddOptions(nome_livros);

        pesquisa.SetActive(false);
        pesquisaLivro.SetActive(true);
    }
}
