 public static void Main(string[] args)
    {
        FollowRightWall();
    }

    public static void FollowRightWall()
    {
        while (!AtGoal())
        {
            if (PeekRight()) 
            {
                if (Peek()) 
                {
                    Move();
                }
                else
                {
                    TurnLeft();
                }
            }
            else
            {
                TurnRight();
                Move();
            }
        }
        Console.WriteLine("Reached the goal!");
    }

/*
while (!AtGoal()){

PerformSequence(new (Action, int)[] {
        (TurnRight, 1),
        (Move, 4),
        (TurnLeft, 1),
        (Move, 4),
        (TurnRight, 1),
        (Move, 1),
        (TurnLeft, 1),
        (Move, 3),
        (TurnRight, 1),
        (Move, 1),
        (TurnLeft, 1),
        (Move, 6),
        (TurnRight, 1),
        (Move, 3),
        (TurnLeft, 1),
        (Move, 4),
        (TurnRight, 1),
        (Move, 4),
        (TurnLeft, 1),
        (Move, 6),
        (TurnRight, 1),
        (Move, 3),
        (TurnLeft, 1),
        (Move, 6),
        (TurnRight, 1),
        (Move, 1),
        (TurnLeft, 1),
        (Move, 3),
        (TurnRight, 1),
        (Move, 1),
        (TurnLeft, 1),
        (Move, 6),
        (TurnRight, 1),
        (Move, 1),
        (TurnLeft, 1),
        (Move, 3),
        (TurnRight, 1),
        (Move, 1),
        (TurnLeft, 1),
        (Move, 3),
        (TurnRight, 1),
        (Move, 1)
    });
}

void PerformSequence((Action, int)[] sequence)
{
    //is an array of tuples, where each tuple represents an action and the number of times that action should be performed.
    foreach ((Action action, int count) in sequence)
    {
        for (int i = 0; i < count; i++)
        {
            action.Invoke();
        }
    }
}
this code is an more hardcode alternative, if the follow right wall function I used is wrong
*/





#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void TurnLeft()
{
    // Perform the equivalent of a left turn (e.g., three right turns)
    Turn();
    Turn();
    Turn();
}



{
    Turn();
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}
void leaveTrailBehindCar()
{
    //leaves a trail behind a car treated as a wall, this prevents the car from going back
}

#endregion