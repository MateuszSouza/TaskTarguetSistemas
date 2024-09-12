using System.Text;

namespace Task5
{
    public class Reversor
    {
        public Reversor()
        {
            
        }
        public StringBuilder MyReverse(string s) 
        {
            var ReversedString = new StringBuilder(s);
            Console.WriteLine(ReversedString);
            var j = 0;
            for (int i = s.Length-1; i > -1 ; i--)
            {
                
                var letra = s[i];
                ReversedString.Insert(j, letra);
                var posicao = ReversedString.Length - 1;
                ReversedString.Remove(posicao, 1);
                j++;
            }

            return ReversedString; 
        }
    }
}
