using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//this code follows a paper storyboard
//code will be divided into sections of the storyboard

public class AniLoader : MonoBehaviour
{
    //the intro - 1
    public GameObject intro;
    //trash option - 2
    public GameObject trash;
    //play/stop - 3
    public GameObject p_s;
    //block code options - 4
    public GameObject options;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheStart());
    }


//----- 1 -----
    IEnumerator TheStart()
    {
        yield return new WaitForSeconds(1f);
        intro.gameObject.SetActive(true);

        yield return new WaitForSeconds(5.25f);
        StartCoroutine(Trash());
    }

//----- 2 -----
    IEnumerator Trash()
    {
        Destroy(intro);
        yield return new WaitForSeconds(1f);
        trash.gameObject.SetActive(true);

        yield return new WaitForSeconds(7f);
        StartCoroutine(PlayStop());

    }

//----- 3 -----
    IEnumerator PlayStop()
    {
        Destroy(trash);
        yield return new WaitForSeconds(1f);
        p_s.gameObject.SetActive(true);

        yield return new WaitForSeconds(5.25f);
        StartCoroutine(BlockCode());

    }

//----- 4 -----
    IEnumerator BlockCode()
    {
        Destroy(p_s);
        yield return new WaitForSeconds(1f);
        options.gameObject.SetActive(true);

        yield return new WaitForSeconds(5.25f);
        //StartCoroutine(MoveOn2());

    }

    //----- storyboard #6 -----
    /*IEnumerator Science()
    {
        Sbackground.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        planets.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        earth.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        plants.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.5f);

        //go to next board
        StartCoroutine(Technology());
    }*/



    /* //----- storyboard #19 -----
     IEnumerator End()
     {
         //deactivite the previous
         Destroy(blckCode);
         Destroy(robots);
         //start new board
         characters.gameObject.SetActive(true);
         yield return new WaitForSeconds(1.75f);
         bye.gameObject.SetActive(true);
         yield return new WaitForSeconds(10f);

         //load menu again
         SceneManager.LoadScene("StartPage");
     }*/

}
