// See https://aka.ms/new-console-template for more information

void massage(string massageNow)
{
    Console.WriteLine(massageNow);
}

massage($"Welcome To program \n" +
    "*************************************************** \n"
  + "please enter number: ");

int number;
bool isConvert = int.TryParse(Console.ReadLine(), out number);
if (!isConvert)
{
    massage(" please enter valid number");
    return;
}
int some = 0;
for (int i = 1; i < number; i++)

{
    
    some = i * i;
    if (some == number)
    {
        some = i;
        break;
    }

}

massage("\n Sqrt is " + some);

