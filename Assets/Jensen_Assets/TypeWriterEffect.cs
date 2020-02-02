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
    private bool pointsAdded = false;

    private ReadInDialogue jsonScript;
    private DioTimeline globalDioTimeline;
    private UIPopUp UIPopUp;
    private MarriageMeter marriageMeter;
    public int currentDio = 0;

    public GameObject dioImage;

    public Sprite[] spouce1;
    public Sprite[] spouce2;
    public Sprite[] spouce3;

    

    private void Start()
    {
        jsonScript = FindObjectOfType<ReadInDialogue>();
        globalDioTimeline = FindObjectOfType<DioTimeline>();
        UIPopUp = FindObjectOfType<UIPopUp>();
        marriageMeter = FindObjectOfType<MarriageMeter>();
    }

    // Use this for initialization
    private void OnEnable()
    {
        jsonScript = FindObjectOfType<ReadInDialogue>();
        globalDioTimeline = FindObjectOfType<DioTimeline>();
        UIPopUp = FindObjectOfType<UIPopUp>();
        marriageMeter = FindObjectOfType<MarriageMeter>();

        //Spouce Image set code

        if (globalDioTimeline.spouceNum == 1)
        {
            if (marriageMeter.marriageMeter <= 100 && marriageMeter.marriageMeter > 75)
            {
                dioImage.GetComponent<Image>().sprite = spouce1[0];
            }
            else if (marriageMeter.marriageMeter <= 75 && marriageMeter.marriageMeter > 50)
            {
                dioImage.GetComponent<Image>().sprite = spouce1[1];
            }
            else if (marriageMeter.marriageMeter <= 50 && marriageMeter.marriageMeter > 25)
            {
                dioImage.GetComponent<Image>().sprite = spouce1[2];
            }
            else if (marriageMeter.marriageMeter <= 25 && marriageMeter.marriageMeter >= 0)
            {
                dioImage.GetComponent<Image>().sprite = spouce1[3];
            }
        }
        else if (globalDioTimeline.spouceNum == 2)
        {
            if (marriageMeter.marriageMeter <= 100 && marriageMeter.marriageMeter > 75)
            {
                dioImage.GetComponent<Image>().sprite = spouce2[0];
            }
            else if (marriageMeter.marriageMeter <= 75 && marriageMeter.marriageMeter > 50)
            {
                dioImage.GetComponent<Image>().sprite = spouce2[1];
            }
            else if (marriageMeter.marriageMeter <= 50 && marriageMeter.marriageMeter > 25)
            {
                dioImage.GetComponent<Image>().sprite = spouce2[2];
            }
            else if (marriageMeter.marriageMeter <= 25 && marriageMeter.marriageMeter >= 0)
            {
                dioImage.GetComponent<Image>().sprite = spouce2[3];
            }
        }
        else if (globalDioTimeline.spouceNum == 3)
        {
            if (marriageMeter.marriageMeter <= 100 && marriageMeter.marriageMeter > 75)
            {
                dioImage.GetComponent<Image>().sprite = spouce3[0];
            }
            else if (marriageMeter.marriageMeter <= 75 && marriageMeter.marriageMeter > 50)
            {
                dioImage.GetComponent<Image>().sprite = spouce3[1];
            }
            else if (marriageMeter.marriageMeter <= 50 && marriageMeter.marriageMeter > 25)
            {
                dioImage.GetComponent<Image>().sprite = spouce3[2];
            }
            else if (marriageMeter.marriageMeter <= 25 && marriageMeter.marriageMeter >= 0)
            {
                dioImage.GetComponent<Image>().sprite = spouce3[3];
            }
        }

        if (currentDio != globalDioTimeline.globalDio)
        {
            currentDio = globalDioTimeline.globalDio;
            pointsAdded = false;
        }

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
            if (pointsAdded == false)
            {
                marriageMeter.marriageMeter++;
                pointsAdded = true;
            }
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

                marriageMeter.marriageMeter = marriageMeter.marriageMeter + 10;
                pointsAdded = true;

                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].correctAnswerResponse;
            }
            else if (Input.GetAxisRaw("NumInput2") > 0 && correctResponse == 2)
            {
                fullText = jsonScript.dialogues[currentDio].correctAnswerResponse;
                question = false;

                marriageMeter.marriageMeter = marriageMeter.marriageMeter + 10;
                pointsAdded = true;

                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].correctAnswerResponse;
            }
            else if (Input.GetAxisRaw("NumInput3") > 0 && correctResponse == 3)
            {
                fullText = jsonScript.dialogues[currentDio].correctAnswerResponse;
                question = false;

                marriageMeter.marriageMeter = marriageMeter.marriageMeter + 10;
                pointsAdded = true;

                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].correctAnswerResponse;
            }
            else if (Input.GetAxisRaw("NumInput4") > 0 && correctResponse == 4)
            {
                fullText = jsonScript.dialogues[currentDio].correctAnswerResponse;
                question = false;

                marriageMeter.marriageMeter = marriageMeter.marriageMeter + 10;
                pointsAdded = true;

                StartCoroutine(ShowText());
                jsonScript.dialogues[currentDio].text = jsonScript.dialogues[currentDio].correctAnswerResponse;
            }
            else if (Input.GetAxisRaw("NumInput1") > 0 || Input.GetAxisRaw("NumInput2") > 0 || Input.GetAxisRaw("NumInput3") > 0 || Input.GetAxisRaw("NumInput4") > 0)
            {
                fullText = jsonScript.dialogues[currentDio].incorrectAnswerResponse;
                question = false;

                marriageMeter.marriageMeter = marriageMeter.marriageMeter - 10;
                pointsAdded = true;

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
