using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour {

    //Code help from https://www.youtube.com/watch?time_continue=153&v=1qbjmb_1hV4&feature=emb_logo

    public float delay = 0.1f;
	public string fullText;
	private string currentText = "";
    public AudioClip speech;
    private bool question;
    private int correctResponse;

	// Use this for initialization
    private void OnEnable()
    {
        currentText = "";
        gameObject.GetComponent<Text>().text = currentText;
        fullText = "What's My Name? \n1.Papyrus 2.Sans\n3.Undyne  4.Frisk";
        question = true;
        correctResponse = 2;
        StartCoroutine(ShowText());
        AudioSource.PlayClipAtPoint(speech, gameObject.transform.position, 2.0f);
    }

    private void Update()
    {
        if (question)
        {
            if (Input.GetAxisRaw("NumInput1") > 0 && correctResponse == 1)
            {
                fullText = "Correct!";
                question = false;
                StartCoroutine(ShowText());
            }
            else if (Input.GetAxisRaw("NumInput2") > 0 && correctResponse == 2)
            {
                fullText = "Correct!";
                question = false;
                StartCoroutine(ShowText());
            }
            else if (Input.GetAxisRaw("NumInput3") > 0 && correctResponse == 3)
            {
                fullText = "Correct!";
                question = false;
                StartCoroutine(ShowText());
            }
            else if (Input.GetAxisRaw("NumInput4") > 0 && correctResponse == 4)
            {
                fullText = "Correct!";
                question = false;
                StartCoroutine(ShowText());
            }
            else if (Input.GetAxisRaw("NumInput1") > 0 || Input.GetAxisRaw("NumInput2") > 0 || Input.GetAxisRaw("NumInput3") > 0 || Input.GetAxisRaw("NumInput4") > 0)
            {
                fullText = "Wrong!";
                question = false;
                StartCoroutine(ShowText());
            }
        }
    }

    IEnumerator ShowText(){
		for(int i = 0; i <= fullText.Length; i++)
        {
			currentText = fullText.Substring(0,i);
			gameObject.GetComponent<Text>().text = currentText;
			yield return new WaitForSeconds(delay);
		}
	}
}
