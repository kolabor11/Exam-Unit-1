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


void TurnRight()
{
    Turn();
}

void Turn()
{
    // Turns the car 90 deg clockwise.
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