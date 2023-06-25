using System;
using System.Collections.Generic;

partial class Program

{    
    
    static void Main(string[] args)
    {
        
        List<Goal> _goals = new List<Goal>();
        string fileName;
        int _points = 0;
        bool quit = false;
        int GetPoints()
        {
            return _points;
        }

        while (!quit)
        {
            
            Console.WriteLine($"You have {GetPoints()} points. ");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            int option = int.Parse(Console.ReadLine());
            
            
            
            switch (option)
            {                
                case 1:
                    int _option = 0;
                    do
                    {
                        Console.WriteLine("The types of Goals are: ");
                        Console.WriteLine(" 1. Simple Goal");
                        Console.WriteLine(" 2. Eternal Goal");
                        Console.WriteLine(" 3. CheckList Goal");
                        Console.WriteLine("Which type of goal would you like to create? ");

                        _option = int.Parse(Console.ReadLine());
                        Goal _goal = null;
                        Console.Write("what is the name of your goal?");
                        string name = Console.ReadLine();
                        Console.Write("what is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.Write("what is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());

                        switch (_option)
                        {
                            case 1:
                                _goal = new SimpleGoal(name, description, points, false);
                                
                                break;

                            case 2:
                                _goal = new EternalGoal(name, description, points);
                                break;
                            case 3:
                                Console.Write("How many times does this goal need to be acomplished for a bonus? ");
                                int _goalCount = int.Parse(Console.ReadLine());
                                Console.Write("what is the bonus for acomplishing it that many times? ");
                                int _bonus = int.Parse(Console.ReadLine());
                                _goal = new CheckListGoal(name, description, points,_goalCount, _bonus);
                                break;

                            default:
                                Console.WriteLine("Invalid Option!");
                                _option = 0;
                                break;    

                        }
                        _goals.Add(_goal);
                    }    
                    while(_option == 0);        
                        
                   break;
                case 2://controlar que funcione
                    int counter = 0;
                    foreach(Goal goal in _goals)
                    {
                        counter++;
                        string ready = goal.IsComplete() ? "[x]" : "[ ]";
                        string _partComplete = goal is CheckListGoal ? $"--- Currently completed: {((CheckListGoal)goal).GetCompleteCount()}/{((CheckListGoal)goal).GetGoalCount()}" : "";    
                        Console.WriteLine($"{counter}. {ready} {goal.GetName()} ({goal.GetDescription()}){_partComplete}"); 
                            
                            
                    }
                    break;
                case 3:
                    Console.Write("Whats is the filename for the goal file?");
                    fileName = Console.ReadLine();
                    
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine(_points);
                        foreach(Goal goal in _goals)
                        {
                            if(goal is SimpleGoal)
                            {
                                if(goal.IsComplete() == true)
                                {                                        
                                    outputFile.WriteLine($"Simple: {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}, True");
                                }
                                else
                                {
                                    outputFile.WriteLine($"Simple: {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}, False");

                                }
                                                                        
                            }
                            else if(goal is EternalGoal)
                            {
                                outputFile.WriteLine($"Eternal: {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}");
                            }
                            else if(goal is CheckListGoal)
                            {
                                outputFile.WriteLine($"CheckList: {goal.GetName()}, {goal.GetDescription()}, {goal.GetPoints()}, {((CheckListGoal)goal).GetBonus()}, {((CheckListGoal)goal).GetGoalCount()}, {((CheckListGoal)goal).GetCompleteCount()}");
                            }
                        }
                    }
                    
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file?");
                    fileName = Console.ReadLine();
                    string[] data = System.IO.File.ReadAllLines(fileName);
                    _goals.Clear();
                    int _number = 0;
                    foreach(string _data in data)
                    {
                        if (_number == 0)
                        {
                            _points = int.Parse(_data);
                        }
                        else
                        {
                            Goal _goal = null;
                            string[] getItems = _data.Split(":");
                            string[] getName = getItems[1].Split(",");
                            if(getItems[0] == "Simple")
                            {
                                bool _look = getName[3] == "True" ? true : false;
                                _goal = new SimpleGoal(getName[0], getName[1], int.Parse(getName[2]), _look);
                            }
                            else if(getItems[0] == "Eternal")
                            {
                                _goal = new EternalGoal(getName[0], getName[1], int.Parse(getName[2]));
                            }
                            else
                            {
                                _goal = new CheckListGoal(getName[0], getName[1], int.Parse(getName[2]),int.Parse(getName[4]), int.Parse(getName[3]));
                                ((CheckListGoal)_goal).SetCompleteCount(int.Parse(getName[5]));
                            }
                            _goals.Add(_goal);
                        }
                        _number++;
                    }
                    break;
                case 5:
                    int _counter = -1;   
                    Console.WriteLine("The goals are: ");
                    foreach(Goal _goal in _goals)
                    {
                        _counter++;
                        Console.WriteLine($"{_counter}. {_goal.GetName()}");
                    }
                    Console.Write("Which goals did you accomplish? ");
                    int _selected = int.Parse(Console.ReadLine());
                    if(_goals[_selected].IsComplete() == true) 
                    {
                        Console.WriteLine("you already finished this goal");

                    }
                    else
                    {
                        int _accumulatedPoints = _goals[_selected].RecordEvent();
                        Console.WriteLine($"Congratulations! You have earned {_accumulatedPoints} points!");
                        _points += _accumulatedPoints;
                        Console.WriteLine($"You now have {GetPoints()} points.");
                        Console.WriteLine("");
                    }
                    break;
                case 6:
                    Console.WriteLine("Bye");
                    quit = true;
                    return;
                default:
                    Console.WriteLine("You have entered an invalid option.");
                    return;
            }
        }    
    }
}