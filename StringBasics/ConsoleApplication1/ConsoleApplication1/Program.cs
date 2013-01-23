using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
bool HasSumOf(int[] array, int sum)
{
  bool result = false;
  int length = array.length;
  for(int i=0; i <; ++i)
  {
      for(intj=i; i<length; ++j)
      {
          if((array[i]+array[j]) == sum ){
             return true;
           };  
      };
  };  
  return result;
}

    }
}




public class ListPair<T>
{
  public List<T> First { get; set; }
  public List<T> Second { get; set; }
}

// Given two lists (and a ListPair<int> class that can hold two lists), returns a list pair containing only the unique elements in each list
public ListPair<int> Unique(List<int> list1, List<int> list2)
{
   int list1Length = list1.length;
   int list2Length = list2.length;
   ListPair<int> result = new ListPair<int>();
   //case list1.length = list2.length
   //     list1.length < list2.length
   //     list2.length > list2.length
   int length = Math.Max(list1.length,list2.length);

   //for(int i=0; i < length;++i)
   //{
   //   if(list1[i] == list2[i])
   //   {
         
   //   }
   //}
  
   return result;
}




string Trim(string source)
{
   string result= string.empty;
   char space = ' '
   char[] stringArray = source.ToCharArray();
   int firstIndex =0;
   int lastIndex = stringArray.length -1;
   //for(firstIndex, lastIndex; firstIndex < lastIndex;  ++fistIndex,--lastIndex)
   //{
   //     i
   //}   

   //bool seenChar = false;
   //for(int i=0; i< string.Array.length; ++i)
   //{
   //   if(stringArray[i] != space)
   //   {
   //      seenChar = true;
         
   //   }  
   //   if(seenChar)
   //   {
   //       result.Add(string[
   //   }
      
      
   //}
   return result;
}
