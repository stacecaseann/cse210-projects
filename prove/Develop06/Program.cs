/*
Some code I added are as follows: 
I added bonus points for reaching a certain amount of goals
For each 10 goals, you get extra points
For each 50 goals, you get extra points
For each 100 goals, you get extra points
When you reach this, I display a fireworks animation

I track how many times eternal goals are completed
I allow you to create Rewards with points and then to spend them

I have the option to set/load a default file because I thought it was annoying to enter the file name
*/
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

    }
}