using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRules : MonoBehaviour
{

    [SerializeField] private ScoreCounter score;
    [SerializeField] private ScoreCounter bid;
    [SerializeField] private float valueForWin = 0;

    public UnityEvent loseGameEvent;
    public UnityEvent winGameEvent;
    private float TakeValueBid()
    {
        return bid.Score > score.Score ? score.Score : bid.Score;
    }

    public void RightCell()
    {
        score.Add(TakeValueBid());
    }
    
    public void NotRightCell()
    {
        score.TakeAway(TakeValueBid());
    }
    
    public void GetResultGame()
    {
        if(score.Score >= valueForWin)winGameEvent?.Invoke();
        else loseGameEvent?.Invoke();
    }
}
