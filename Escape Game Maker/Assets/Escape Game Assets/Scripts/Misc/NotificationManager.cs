using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationManager : MonoBehaviour
{

    public static NotificationManager instance;

    public GAui anim;
    public Text text;
    public float delay = 0.5f;

    private string waitingText;

    private bool animating = false;

    private void Start()
    {
        instance = this;
    }

    public void MakeNotification(string text) {
        this.text.text = "";
        this.waitingText = text;
        if (!animating)
        {
            anim.MoveIn();
        }
        else {
            AnimInComplete();
        }
    }

    public void AnimInComplete()
    {
        StartCoroutine(AnimateText(waitingText));
    }

    IEnumerator AnimateText(string text)
    {
        animating = true;       
        //Debug.Log("Animating text!");
        foreach (char letter in text.ToCharArray())
        {
            this.text.text += letter;
            yield return new WaitForSeconds(delay);
        }
        yield return new WaitForSeconds(delay * 2);
        //Debug.Log("Finished Text!");
        animating = false;
        anim.MoveOut();
    }
}