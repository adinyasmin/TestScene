using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class SceneA : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoSceneB()
    {
        SceneManager.LoadScene("TestB");
        //test commit dari github browser
    }
    //test dummy
}
