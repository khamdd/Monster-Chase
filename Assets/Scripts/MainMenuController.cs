using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        int selectedObj = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        Debug.Log(selectedObj);
        GameManager.instance.CharIndex = selectedObj;

        SceneManager.LoadScene("Gameplay");
    }
} // Class
