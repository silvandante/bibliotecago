using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetArea : MonoBehaviour {

    List<string> nome_areas = new List<string>();
    public Dropdown ddOptions;


    void Start(){
        SqliteDatabase sqlDB = new SqliteDatabase("bibliotecago_v01.db");
        string query = "SELECT * FROM areas";
        DataTable data = sqlDB.ExecuteQuery(query);
        string name = "";
        foreach (DataRow dr in data.Rows)
        {
            name = (string)dr["are_name"];
            nome_areas.Add(name);
        }

        ddOptions.ClearOptions();
        //Add the options created in the List above
        ddOptions.AddOptions(nome_areas);

    }
    
}
