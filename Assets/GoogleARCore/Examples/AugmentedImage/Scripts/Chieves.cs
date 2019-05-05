using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chieves : MonoBehaviour
{
    //General Variables
    public GameObject achNote;
    public bool achActive = false;
    public GameObject achDesc;

    //Cheives listed
    public GameObject ach01Image;
    public static int ach01Count;
    public int achTrigger = 1;
    public int ach01Code;

    // Update is called once per frame
    void Update()
    {
        ach01Code = PlayerPrefs.GetInt("Ach01");
        if (ach01Count == achTrigger && ach01Code != 1) {
            StartCoroutine(Trigger01Ach());
        }
    }

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new NotImplementedException();
    }

    IEnumerable Trigger01Ach() {
        achActive = true;
        ach01Code = 1;
        PlayerPrefs.SetInt("Ach01", ach01Code);
        ach01Image.SetActive(true);
        achDesc.GetComponent<Text>().text = "Decription of achievment 1";
        achNote.SetActive(true);
        yield return new WaitForSeconds(5);

        achNote.SetActive(false);
        ach01Image.SetActive(false);
        achDesc.GetComponent<Text>().text = "";
        achActive = false;
    }
}
