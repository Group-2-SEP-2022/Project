using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCapture : MonoBehaviour
{
    public PokeprofData pokeprofData;
    public GameObject pokeprof;

    private string pokeball;

    Inventory iD;

    public void Capture() {

        pokeprof = FindInActiveObjectByName(pokeprofData.pokeprofName);

        switch(pokeprofData.pokeprofName) {
            default:
            case "Ivan NOURDIN":            pokeball = "[M] Pokeball";
                                            break;
            case "Giovanni PECCATI":        pokeball = "[M] Special Pokeball";
                                            break;
            case "Anupam SENGUPTA":         pokeball = "[P] Pokeball";
                                            break;
            case "Alexandre TKATCHENKO":    pokeball = "[P] Special Pokeball";
                                            break;
            case "Frank SCHOLZEN":          pokeball = "[E] Pokeball";
                                            break;
            case "Stephan LEYER":           pokeball = "[E] Special Pokeball";
                                            break;                 
            case "Volker MÜLLER":
            case "Alfredo CAPOZUCCA":
            case "Martin THEOBALD":         pokeball = "[CS] Pokeball";
                                            break;
            case "Pascal BOUVRY":           pokeball = "[CS] Special Pokeball";
                                            break;
            case "Gilbert MASSARD":         
            case "Jean Luc BUEB":           pokeball = "[BM] Pokeball";
                                            break;
            case "Iris BEHRMANN":           pokeball = "[BM] Special Pokeball";
                                            break;
        }

        GameObject ID = GameObject.FindGameObjectWithTag("Switch");
        iD = ID.GetComponent<Inventory>();

        foreach(ItemData key in iD.itemDictionary.Keys) {
            if(key.displayName == pokeball) {
                pokeprof.SetActive(true);
            }
        }

    }

    GameObject FindInActiveObjectByName(string name)
{
    Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
    for (int i = 0; i < objs.Length; i++)
    {
        if (objs[i].hideFlags == HideFlags.None)
        {
            if (objs[i].name == name)
            {
                return objs[i].gameObject;
            }
        }
    }
    return null;
}
}
