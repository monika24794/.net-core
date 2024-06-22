namespace CalculatorLogic
{
    public class simpleCalci
    {
        public int AddNos(int  fno, int sno) {
        return fno + sno;
        }
        //out parametr
        public int GetMulandDiv(int fno,int sno ,out int divans) 
        { 
            int mulans=fno * sno;
            divans=fno / sno;
            
            return mulans;
        }
        //call by value

        public void swapNosvalue( int fno,  int sno)
        {
            int temp = fno;
            fno = sno;
            sno = temp;
            Console.WriteLine("call by value");
            Console.WriteLine("value by =" + fno);
            Console.WriteLine("value by =" + sno);
        }

        //call by reference
        public void swapNos(ref int fno,ref int sno)
        {
            int temp = fno;
            fno=sno;
            sno = temp;
            Console.WriteLine("call by reference");
            Console.WriteLine("value by ="+fno);
            Console.WriteLine("value by =" + sno);
        }

        //get value 
        public Tuple <int,int> getMultiplevalue(int fno ,int sno) 
        {
            int min,max;
            if (fno >sno)
            {
                max = fno;
                min = sno;
            }
            else
            {
                max = sno;
                min = fno;
            }
            return new Tuple<int,int>(min,max);
        }
    }
}
