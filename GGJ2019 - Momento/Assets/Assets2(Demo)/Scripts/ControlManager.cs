using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour {

    public GameObject inventoryCanvas;

    [SerializeField] private bool isOpen = false;

    private void Awake()
    {
        inventoryCanvas.SetActive(false);
    }

    private void Update()
    {
        Toggle();

        if (isOpen)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isOpen = false;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isOpen = true;
            }
        }

    }

    private void Toggle()
    {
        if (isOpen)
        {
            inventoryCanvas.gameObject.SetActive(true);
            StopGame();
        }
        else
        {
            inventoryCanvas.gameObject.SetActive(false);
            ResumeGame();
        }
    }

    private void ResumeGame()
    {
        Time.timeScale = 1.0f;
    }

    private void StopGame()
    {
        Time.timeScale = 0.0f;
    }


    #region

    public bool PlayMode()
    {
        if (Time.timeScale == 1.0f)
            return true;
        else
            return false;
    }

    public bool StopMode()
    {
        if (Time.timeScale == 0.0f)
            return true;
        else
            return false;
    }

    #endregion

}
