using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public Animator animator;


    public void FadeToLevel(int levelIndex) {
        animator.SetTrigger("FadeOut");
        SceneManager.LoadScene(levelIndex);
    }

    public void QuitButton() {
        Application.Quit();
    }

}
