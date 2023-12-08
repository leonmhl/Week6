



string userName = "Darth Vader";

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length-1]}.");

//a-counter

int counter = 0;

for(int i = 0; i < userName.Length; i++)
{
    if (userName[i] == 'a')
    {
        counter++;
    }
}

Console.WriteLine($"Your name has {counter} a letters");

//replace 
//a - 4

string updatedUserName = userName.Replace('a', '4').Replace('e','3');

Console.WriteLine(updatedUserName);

