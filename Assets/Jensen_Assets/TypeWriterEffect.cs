using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour {

    //Code help for text appear code from https://www.youtube.com/watch?time_continue=153&v=1qbjmb_1hV4&feature=emb_logo

    public float delay = 0.1f;
	public string fullText;
	private string currentText = "";
    public AudioClip speech;
    private bool question = false;
    private int correctResponse;
    private ReadInDialogue jsonScript;
    private DioTimeline globalDioTimeline;
    private UIPopUp UIPopUp;
    public int currentDio = 0;

    private void Start()
    {
        jsonScript = FindObjectOfType<ReadInDialogue>();
        globalDioTimeline = FindObjectOfType<DioTimeline>();
        UIPopUp = FindObjectOfType<UIPopUp>();
    }

    // Use this for initialization
    private void OnEnable()
    {
        jsonScript = FindObjectOfType<ReadInDialogue>();
        globalDioTimeline = FindObjectOfType<DioTimeline>();
        UIPopUp = FindObjectOfType<UIPopUp>();

        currentDio = globalDioTimeline.globalDio;

        currentText = "";
        gameObject.GetComponent<Text>().text = currentText;
        fullText = jsonScript.dialogues[currentDio].text;

        if (jsonScript.dialogues[currentDio].type == "question")
        {
            question = true;
        }
        else
        {
            question = false;
        }

        
        correctResponse = jsonScript.dialogues[currentDio].answer;
        

        StartCoroutine(ShowText());
        AudioSource.PlayClipAtPoint(speech, gameObject.transform.position, 2.0f);
    }

    private void Update()
    {
        if (question && UIPopUp.isItem == false)
        {
            if (Input.GetAxisRaw("NumInput1") > 0 && correctResponse == 1)
            {
                fullText = jsonScript.dialogues[currentDio].correctAnswerResponse;
                question = false;
                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].correctAnswerResponse;
            }
            else if (Input.GetAxisRaw("NumInput2") > 0 && correctResponse == 2)
            {
                fullText = jsonScript.dialogues[currentDio].correctAnswerResponse;
                question = false;
                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].correctAnswerResponse;
            }
            else if (Input.GetAxisRaw("NumInput3") > 0 && correctResponse == 3)
            {
                fullText = jsonScript.dialogues[currentDio].correctAnswerResponse;
                question = false;
                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].correctAnswerResponse;
            }
            else if (Input.GetAxisRaw("NumInput4") > 0 && correctResponse == 4)
            {
                fullText = jsonScript.dialogues[currentDio].correctAnswerResponse;
                question = false;
                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].correctAnswerResponse;
            }
            else if (Input.GetAxisRaw("NumInput1") > 0 || Input.GetAxisRaw("NumInput2") > 0 || Input.GetAxisRaw("NumInput3") > 0 || Input.GetAxisRaw("NumInput4") > 0)
            {
                fullText = jsonScript.dialogues[currentDio].incorrectAnswerResponse;
                question = false;
                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].incorrectAnswerResponse;
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
