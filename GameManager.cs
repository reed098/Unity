using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Hedef;
    public GameObject PrefabCharacter;
    public GameObject DogmaNoktasi;
    public GameObject VarisNoktasi;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(PrefabCharacter, DogmaNoktasi.transform.position, Quaternion.identity);
        }
    }
}
