using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTriggerScript : MonoBehaviour
{
    public GameObject textBox;

    public TextScriptableObject text1;

    public TextMeshProUGUI textline;

    private IEnumerator dialogueCoroutine;

    public GameObject dialogueTrigger;
    // Start is called before the first frame update
    void Start()
    {
        textBox.gameObject.SetActive(false);
        dialogueCoroutine = DialoguePlay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RenderText(TextScriptableObject textLine)
    {
        textline.text = textLine.writtenText;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(DialoguePlay());
        }
    }

    IEnumerator DialoguePlay()
    {
        yield return new WaitForSeconds(0.2f);
        textBox.gameObject.SetActive(true);
        RenderText(text1);
        yield return new WaitForSeconds(3f);
        textBox.gameObject.SetActive(false);
        yield return null;
    }
}
