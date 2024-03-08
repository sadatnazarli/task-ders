
//Tapşırıq: 2 array verilmişdir, 2ci arraydəki bütün elementlər həm də 1cidə varsa , true əks halda false çap olunsun.

//Məsələn: int[] 1ciarr = {211,9,-6,12,34,56,32,5,19};

//int[] 2ciArr = {19,-6, 32};

//Cavab-> true

int[] ciarr = {211, 9, -6,12,34,56,32,5,19};
int[] ciArr = {11,-6, 33};

bool result = true;
for (int i = 0; i < ciArr.Length; i++)
{
    bool isExist = false;
    for (int j = 0; j < ciarr.Length; j++)
    {
        if (ciArr[i] == ciarr[j])
        {
            isExist = true;
            break;
        }
    }
    if (!isExist)
    {
        result = false;
        break;
    }
}
Console.WriteLine(result);
