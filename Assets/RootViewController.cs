using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RootViewController : MonoBehaviour
{
    [Header("Node Views")]
    [SerializeField] private GameObject[] views;

    [Header("RootView Elements")]
    [SerializeField] private TMP_Text versionLabel;


    private void Start()
    {
        // Start with view = 0
        foreach (GameObject v in views)
            v.SetActive(false);
        views[0].SetActive(true);

        // Set Static View Elements
        versionLabel.text = Application.version;
    }
    
}
