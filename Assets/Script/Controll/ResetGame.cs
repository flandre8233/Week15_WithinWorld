using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetGame : MonoBehaviour
{
    [SerializeField] EngineSouneChanger EngineSouneChanger;
    // Start is called before the first frame update
    void Start()
    {
        EngineSouneChanger.Stop();
        Invoke("ReSetGmaeee", 5f);
    }

    public void ReSetGmaeee()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
