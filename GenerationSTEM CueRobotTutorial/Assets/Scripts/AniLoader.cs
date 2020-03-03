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
    //actions - 5a
    public GameObject actions;
    //actions - 5b
    public GameObject control;
    //code scene - 6
    public GameObject codescene;
    //code scene - 7
    public GameObject bikearea;
    //example - 8
    public GameObject example;
    //their turn - 9
    public GameObject turn;

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

        yield return new WaitForSeconds(5f);
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

        yield return new WaitForSeconds(5.5f);
        StartCoroutine(BlockCode());

    }

//----- 4 -----
    IEnumerator BlockCode()
    {
        Destroy(p_s);
        yield return new WaitForSeconds(1f);
        options.gameObject.SetActive(true);

        yield return new WaitForSeconds(5.25f);
        StartCoroutine(Actions());

    }

//----- 5a -----
    IEnumerator Actions()
    {
        Destroy(options);
        yield return new WaitForSeconds(1f);
        actions.gameObject.SetActive(true);

        yield return new WaitForSeconds(4.80f);
        StartCoroutine(Controls());
    }

//----- 5b -----
    IEnumerator Controls()
    {
        Destroy(actions);
        yield return new WaitForSeconds(1f);
        control.gameObject.SetActive(true);

        yield return new WaitForSeconds(5.25f);
        StartCoroutine(CodeArea());
    }

//----- c -----
    IEnumerator CodeArea()
    {
        Destroy(control);
        yield return new WaitForSeconds(1f);
        codescene.gameObject.SetActive(true);

        yield return new WaitForSeconds(4f);
        StartCoroutine(BikeArea());
    }

    //----- 5b -----
    IEnumerator BikeArea()
    {
        Destroy(codescene);
        yield return new WaitForSeconds(1f);
        bikearea.gameObject.SetActive(true);

        yield return new WaitForSeconds(8f);
        StartCoroutine(ExampleCode());
    }

    //----- 5b -----
    IEnumerator ExampleCode()
    {
        Destroy(bikearea);
        yield return new WaitForSeconds(1f);
        example.gameObject.SetActive(true);

        yield return new WaitForSeconds(10f);
        StartCoroutine(TheEnd());
    }

    //----- 5b -----
    IEnumerator TheEnd()
    {
        Destroy(example);
        yield return new WaitForSeconds(1f);
        turn.gameObject.SetActive(true);

        //yield return new WaitForSeconds(5.25f);
    }

}
