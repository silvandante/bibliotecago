using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetArea : MonoBehaviour {

    Conection db = null;
    List<string> nome_areas = new List<string>();
    public Dropdown ddOptions;


    void Start(){
        db = GetComponent<Conection>();

        db.OpenDB("bibliotecago_v01.db");

        nome_areas = db.getAllAreas();

        ddOptions.ClearOptions();
        //Add the options created in the List above
        ddOptions.AddOptions(nome_areas);

        db.CloseDB();
        
    }
    
}
