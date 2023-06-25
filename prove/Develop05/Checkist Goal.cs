using System;

public class CheckListGoal : Goal
{

    private int _goalCount;
    private int _completeCount;
    private int _bonus;   

    public CheckListGoal(string name, string description, int points, int goalCount, int bonus): base(name, description, points)
    {
        _goalCount = goalCount;
        _bonus = bonus;

    }
    
    public int GetGoalCount()
    {
        return _goalCount;
    }
    public void SetCompleteCount(int completeCount)
    {
        _completeCount = completeCount;
    }
    public int GetCompleteCount()
    {
        return _completeCount;
    }
    
    public int GetBonus(){
        return _bonus;
    }
    
    public override int RecordEvent()
    {
        _completeCount++;
        if (_completeCount == _goalCount)
        {
            
            return _bonus + GetPoints()  ;
        }
        else
        {
            return GetPoints();
        }

    }
    public override bool isComplete()
    {
        if ( _goalCount == _completeCount)
        {
            
            return true;
        }
        else
        {
            return false;
        }
    }
    
}