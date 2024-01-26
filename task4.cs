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




/*const int MAX_DIRECTIONS = 4;
int turnCount = 0;
while (!AtGoal())

    int availableDirections = CountAvailableDirections(); 

    if (Peek() && availableDirections == 1 )
    {
        Move();
    }
    else
    {
        
        else if (Peek() && availableDirections == 1 )
        {
            Move()
        }
        else if (availableDirections == 3)
        {
            if (turnCount % 2 == 0)
            {
                TurnRight();
                Move();
            }
            else if (turnCount % 1 == 0)
            {
                TurnLeft();
                Move();
            }
            else
            {
                // Go straight
            }
        }
        else if (availableDirections == 4)
        {
           
            if (turnCount % 2 == 0)
            {
                Turn();
            }
        
            else
            {
                Move();
            }
        }

        turnCount++;
    }

    Here is an idea I had to make the car act different based on the amount of turns 
    it made and possible directions to go but It did not let anywherem i am gonna leave it here, 
    maybe I will get some point s for an idea itself.
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