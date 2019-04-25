using System;

namespace ND2_magicnumber
{
    class Program
    {
        static void Main(string[] args)
        {


              for (int i= 100000; i<166666;i++)
            // (int i = 142856; i < 142858; i++)
            {
                

                int number = i;
                int numberTimes2 = number * 2;
                int numberTimes3 = number * 3;
                int numberTimes4 = number * 4;
                int numberTimes5 = number * 5;
                int numberTimes6 = number * 6;
                int[] numberArrayed = storeNumToArray(number);
                int[] numberTimes2Arrayed = storeNumToArray(numberTimes2);
                int[] numberTimes3Arrayed = storeNumToArray(numberTimes3);
                int[] numberTimes4Arrayed = storeNumToArray(numberTimes4);
                int[] numberTimes5Arrayed = storeNumToArray(numberTimes5);
                int[] numberTimes6Arrayed = storeNumToArray(numberTimes6);
                if (checkIfElemetsDiffer(numberArrayed) == false
                    && checkIfElemetsDiffer(numberTimes2Arrayed) == false
                    && checkIfElemetsDiffer(numberTimes3Arrayed) == false
                    && checkIfElemetsDiffer(numberTimes4Arrayed) == false
                    && checkIfElemetsDiffer(numberTimes5Arrayed) == false
                    && checkIfElemetsDiffer(numberTimes6Arrayed) == false
                    )

                    if (checkIfArraysWithSameElements(numberArrayed, numberTimes2Arrayed) == false 
                        && checkIfArraysWithSameElements(numberArrayed, numberTimes3Arrayed) == false
                        && checkIfArraysWithSameElements(numberArrayed, numberTimes4Arrayed) == false
                        && checkIfArraysWithSameElements(numberArrayed, numberTimes5Arrayed) == false
                        && checkIfArraysWithSameElements(numberArrayed, numberTimes6Arrayed) == false
                        )
                    {
                        Console.WriteLine("The magic number is: "+number);
                        Console.ReadKey();
                    }

                
               

            } 

        }

        static int[] storeNumToArray(int number)
        {
            int[] funcArray = new int[6];
            for (int i = 0; i < 6; i++)
            {
                double power = Math.Pow(10.0, i);
                int intPower = Convert.ToInt32(power);
                funcArray[i] = (number / intPower % 10);        
            }
            return funcArray;
        }

        static bool checkIfElemetsDiffer(int[] array) //true jei pasikartojo tarp masyvo
        {
            bool pasikartojo = false;
            int[] array1 = array;
              int int1 =1;
              int int2 =1;
              int int3 =1;
              int int4 =1;
              int int5 =1;
              int int6 =1;
              int int7 =1;
              int int8 =1;
              int int9 =1;
              int int0 =1;
            
            foreach (int element in array1)
            {



                if (element == 9)
                {

                    if (int9 == 0)
                    {
                        pasikartojo = true;
                    }
                    int9 = 0;
                }

                if (element == 8)
                {

                    if (int8 == 0)
                    {
                        pasikartojo = true;
                    }
                    int8 = 0;
                }

                if (element == 7)
                {

                    if (int7 == 0)
                    {
                        pasikartojo = true;
                    }
                    int7 = 0;
                }

                if (element == 6)
                {

                    if (int6 == 0)
                    {
                        pasikartojo = true;
                    }
                    int6 = 0;
                }

                if (element == 5)
                {

                    if (int5 == 0)
                    {
                        pasikartojo = true;
                    }
                    int5 = 0;
                }

                if (element == 4)
                {

                    if (int4 == 0)
                    {
                        pasikartojo = true;
                    }
                    int4 = 0;
                }

                if (element == 3)
                {

                    if (int3 == 0)
                    {
                        pasikartojo = true;
                    }
                    int3 = 0;
                }

                if (element == 2)
                {

                    if (int2 == 0)
                    {
                        pasikartojo = true;
                    }
                    int2 = 0;
                }

                if (element == 1)
                {

                    if (int1 == 0)
                    {
                        pasikartojo = true;
                    }
                    int1 = 0;
                }

                if (element == 0)
                {

                    if (int0 == 0)
                    {
                        pasikartojo = true;
                    }
                    int0 = 0;
                }

            }

            return pasikartojo;
        }

        static bool checkIfArraysWithSameElements(int[] array1, int[] array2) //true jeigu yra nesutapimas tarp masyvu
        {
            bool thereIsADifferentDigit = false;
            int[] _array1 = array1;
            int[] _array2 = array2;
            
            for (int i =0;i<6;i++)
            {
                int missCounter = 6;
                for (int j = 0; j<6;j++)
                    if (_array1[i] != _array2[j])
                    {
                        missCounter=missCounter-1;
                    }
                if (missCounter < 1)
                    thereIsADifferentDigit = true;

                
            }

            return thereIsADifferentDigit;

        }

    }
}
