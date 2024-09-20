namespace Tyuiu.SychevAD.Sprint0.Task7.V0.Lib
{
    public class DataServise
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resultArrays = new int[5];
            for (var i = 0; i < resultArrays.Length; i++)
            {
                resultArrays[i] = numOne[i] + numTwo[i];
            }
            return resultArrays;
        }

    }
}
