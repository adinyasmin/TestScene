using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class SceneB : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoSceneA()
    {
        SceneManager.LoadScene("TestA");
    }
}
