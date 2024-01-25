 

 while (!AtGoal())
    {
        if (Peek())
        {
            Move();
        }
        else
        {
            
            if (isRightTurn)
            {
                TurnRight();
            }
            else
            {
                TurnLeft();
            }

           
            isRightTurn = !isRightTurn;
        }
    }


#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void TurnLeft()
{
    // Perform the equivalent of a left turn (e.g., three right turns)
    Turn();
    Turn();
    Turn();
}

void TurnRight()
{
    Turn();
}
void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool isRightTurn = true;
{
    //Returns true if the cell in front of the car after turning 90 degress clockwise is open, otherwise false.
    return true; // Just a placeholder value.
}
bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion