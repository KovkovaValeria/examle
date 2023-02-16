int Max(int arg1, int arg2, int arg3)
{
	int result = arg1;
	if (arg2> result) result = arg2;
	if (arg3> result) result = arg3;
	return result;
}
int[] array = {1,2,3,34,5,9,77,8,9};
int n = array.Length;
int find = 9;
int index = 0;
while (index<n)
{
if (array[index] == find)
{
	Console.WriteLine(index);
	break;
}
	index++;
}
