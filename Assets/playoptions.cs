using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playoptions : MonoBehaviour
{
    public void MoveToScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
}
