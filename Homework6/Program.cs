// See https://aka.ms/new-console-template for more information

/*TODO: 1) Clean-Up Code
        2) Double Check Code Standards
        3) add descriptions and prompts
        4) handle exceptions
*/

//Console.WriteLine("Hello, World!");


const int FARENHEIGHT_RANGE_COUNT = (100 - 80) + 1;
int methodTest = 0;
System.Console.Write("Please input the number of the method you would like to run (1, 2, 3, or 4):\n>: ");
methodTest = Convert.ToInt32(Console.ReadLine());


switch (methodTest)
{
    case 1:
        //charPosition++;
        ShowCharacter(); //(something, charPosition);
    break;
    case 2:
        System.Console.Write("Please input the wholesale cost of your item, as a double:\n>: ");
        double wsCost = GetDouble();
        System.Console.Write("Please input the markup percent of your item, as an integer:\n>: ");
        int mkPerc = GetInt();
        double retailPrice = CalculateRetail(wsCost, mkPerc);
        System.Console.WriteLine($"The retail price for an item with a wholesale cost of ${wsCost} and a markup percent of {mkPerc}% is " + retailPrice.ToString("C2") +".");
    break;
    case 3:
        int[] tempItems = new int[FARENHEIGHT_RANGE_COUNT];
        //int tempCount = 1;
        int farenTemp = 80;
        for (int f = 0; f < tempItems.Length; f++)
        {
            bool nextFlag = true;

            while (nextFlag == true)
            {
                tempItems[f] = Celcius(farenTemp);
                System.Console.WriteLine($"{farenTemp} F is {tempItems[f]} C");
                farenTemp++;
                if (f < tempItems.Length && f >= 0)
                {
                    nextFlag = false;
                }

            }
        }
    break;
    case 4:
        Console.Write("Input a number : ");
        int uInput = GetInt();

        if (IsPrime(uInput))
            Console.WriteLine(uInput + " is a prime number");
        else
            Console.WriteLine(uInput + " is not a prime number");
    break;
    default:
    break;
}



static void ShowCharacter()//(string something, int charPosition)
{
    System.Console.Write("Please input a String:\n>: ");
    string something = System.Console.ReadLine();
    System.Console.Write("Please input a Positive Integer:\n>: ");
    int charPosition = GetInt();
    System.Console.WriteLine($"The character in position #{charPosition} of the string \"{something}\" is \'{something[charPosition-1]}\'.");
}

static int GetInt()
{
    return Convert.ToInt32(Console.ReadLine());
}

static double GetDouble()
{
    return Convert.ToDouble(Console.ReadLine());
}

static double CalculateRetail(double wsCost, int mkPerc)
{
    double roughPrice = wsCost + (wsCost * (mkPerc / 100));
    return Math.Round(roughPrice, 2);
}


/*
double mCharge = Convert.ToDouble(Console.ReadLine());
//declare constant tax rate
const double TAX_RATE = 0.0675;
//declare tip rate
const double TIP_RATE = 0.20;
//calculate tip amount
double tip = mCharge * TIP_RATE;
//calculate tax amount
double tax = mCharge * TAX_RATE;
//calculate total charge
double subTotal = mCharge + tax + tip;
//calc rounded total to two decimal places
double mTotal = Math.Round(subTotal, 2);
*/



static int Celcius(int farenTemp)
{
    double firstCalc = 5.0 / 9.0 * (farenTemp - 32.0);
    //int secondCalc = 
    return (int)firstCalc;
}
static bool IsPrime(int num)
{
    for (int i = 2; i < num; i++)
        if (num % i == 0)
        {
            return false;
        }
    return true;
}