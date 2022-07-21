using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "QuizQuestion", fileName = "NewQuestion")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)] 
    [SerializeField] string question = "Question text";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion(){
        return question;
    }

    public string GetAnswer(int index){
        return answers[index];
    }

    public int GetCorrectAnswerIndex(){
        return correctAnswerIndex;
    }

}
