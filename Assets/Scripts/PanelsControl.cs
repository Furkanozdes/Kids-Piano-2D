using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelsControl : MonoBehaviour
{
   public GameObject startPanel;

    void Start()
    {
        startPanel.SetActive(true);
    }
    public void ClosePanel()
    {
        startPanel.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }
}
