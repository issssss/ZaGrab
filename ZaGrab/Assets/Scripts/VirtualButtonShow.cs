using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class VirtualButtonShow : MonoBehaviour
{

    public GameObject vbBtnObj;
    string vbName;
    public GameObject buttonPanel;
    TextMesh tekstZan;
    public GameObject model3D;
    Boolean stisnuto = false;
    public GameObject textPanel;
    int brKlik;

    // Use this for initialization
    void Start()
    {
        brKlik = 0;
        //if(buttonPanel.activeInHierarchy)
            //Deactivate();
        vbBtnObj = GameObject.Find("Saznaj");
        buttonPanel = GameObject.Find("Zanimljivosti");
       
    }

    public void OnButtonPressed(Button vb)
    {
        //vbName = vb.VirtualButtonName;
        brKlik++;
        if (stisnuto == false)
            stisnuto = true;
        // else
        //{
        //  buttonPanel.GetComponent<Mesh>().setActive
        //}
        if (model3D.tag == "Katedrala" && brKlik % 2 != 0)
        {
            ukljuci();
            Debug.Log("Model je katedrala");
            TextKatedrala();
            stisnuto = false;

        }
        else iskljuci();

        
        Debug.Log("Button pressed");
        VirtualButtonPressed();
    }

    public void OnButtonReleased(Button vb)
    {
      
        Debug.Log("Button released");
    }

    public void VirtualButtonPressed() { }

    void Text()
    {
       // buttonPanel = GameObject.Find("Zanimljivosti");
        //buttonPanel.SetActive(true);
    }

    void TextKatedrala() {
        buttonPanel.GetComponent<MeshRenderer>().enabled = true;
        buttonPanel.GetComponent<MeshCollider>().enabled = true;

        tekstZan = textPanel.GetComponent<TextMesh>();
        tekstZan.text = "Zanimljivo ;)";
    }
    void ukljuci()
    {
        buttonPanel.GetComponent<MeshRenderer>().enabled = true;
        buttonPanel.GetComponent<MeshCollider>().enabled = true;
        textPanel.GetComponent<MeshRenderer>().enabled = true;
        
    }
    void iskljuci()
    {
        buttonPanel.GetComponent<MeshRenderer>().enabled = false;
        buttonPanel.GetComponent<MeshCollider>().enabled = false;
        textPanel.GetComponent<MeshRenderer>().enabled = false;
    }
}