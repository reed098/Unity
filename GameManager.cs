using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject VarisNoktasi;
    public int AnlikKarakterSayisi = 1;

    public List<GameObject> Characters;
    void Start()
    {
        
    }

    
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Instantiate(PrefabCharacter, DogmaNoktasi.transform.position, Quaternion.identity);
        //    foreach (var item in Characters)
        //    {
        //        if (!item.activeInHierarchy) //Characters listesinin içinde hiyerarşideki aktif olmayan ilk liste elemanı
        //        {
        //            item.transform.position = DogmaNoktasi.transform.position;
        //            item.SetActive(true);
        //            AnlikKarakterSayisi++;
        //            break; // ilk bulduğu pasif karaktere pozisyon verip aktif etmek için bunu yapıyoruz. Yoksa diğer pasif elemanlara da aynı işlemi uygular.
        //        }
        //    }
        //}
    }

    public void AdamYonetimi(string veri,Transform pozisyon)
    {
        switch (veri)
        {
            case "x2":
                int sayi = 0;
                foreach (var item in Characters)
                {
                    if(sayi < AnlikKarakterSayisi)
                    {
                        if (!item.activeInHierarchy) //Characters listesinin içinde hiyerarşideki aktif olmayan ilk liste elemanı
                        {
                            item.transform.position = pozisyon.position;
                            item.SetActive(true);
                            sayi++;
                        }
                    }
                    else
                    {
                        sayi = 0;
                        break;
                    }

                   
                }
                AnlikKarakterSayisi *= 2;
                break;
        }
    }
}
