using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ValueChange : MonoBehaviour {

    private Dropdown areaDropdown;
    public Dropdown subareaDropdown;
    SqliteDatabase sqlDB;
    void Start()
    {
       
        areaDropdown = GetComponent<Dropdown>();

        List<string> nome_areas = new List<string>();

        sqlDB = new SqliteDatabase("bibliotecago_v01.db");
        string query = "SELECT * FROM areas";
        DataTable data = sqlDB.ExecuteQuery(query);
        string name = "";
        foreach (DataRow dr in data.Rows)
        {
            name = (string)dr["are_name"];
            nome_areas.Add(name);
        }
   
        areaDropdown.ClearOptions();
        //Add the options created in the List above
        areaDropdown.AddOptions(nome_areas);
        Debug.Log("Chegou aqui 0");
        
        areaDropdown.onValueChanged.AddListener(delegate
            {
                DropdownValueChanged(areaDropdown);
            });


        Debug.Log("dropdown.value=" + areaDropdown.value);

        string query_ = "SELECT * FROM pequenas_areas WHERE are_id='"+ (areaDropdown.value+1) +"'";
        DataTable data_ = sqlDB.ExecuteQuery(query_);

        List<string> subAreas = new List<string>();
        string name_ = "";
        foreach (DataRow dr in data_.Rows)
        {
            name_ = (string)dr["peq_name"];
            subAreas.Add(name_);
        }

        Debug.Log("subAreas: "+subAreas);

        subareaDropdown.ClearOptions();

        subareaDropdown.AddOptions(subAreas);
        
    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {
        string query_ = "SELECT * FROM pequenas_areas WHERE are_id='" + (change.value + 1) + "'";
        DataTable data_ = sqlDB.ExecuteQuery(query_);

        List<string> subAreas = new List<string>();
        string name_ = "";
        foreach (DataRow dr in data_.Rows)
        {
            name_ = (string)dr["peq_name"];
            subAreas.Add(name_);
        }

        Debug.Log("subAreas: " + subAreas);

        subareaDropdown.ClearOptions();

        subareaDropdown.AddOptions(subAreas);
    }
}
