using System.Collections.Generic;
using System.Linq;

namespace TextAnalysis
{
    public class Analysis
    {
        public List<string> wordList(string text) // Text that sent as parameter - Split words
        {
            List<string> list = new List<string>();//Words List  
            char[] kar = { ' ', ',' , '.' , '\n' , '\t' , '"' ,
                '“' , ':', ';', '!', '\r', '\\', '\0', '?', '/',
                '*', '+', '&', '\'' , '^', '%','(', ')', '=', '’' , '‘',
                '>', '£', '#', '$', '½', '{', '[', ']', '}', '_',
                '_', '@', '€', '-', 'ß', 'æ', '|', 'é','”'}; /* Split characters */
            foreach (string item in text.Split(kar)) 
            {
                if (item != "")
                {
                    list.Add(item.ToLower());
                }

            }
            return list;
        }
        
        public Dictionary<string, int> mostRepetitive1(string text) //Single words
        {
            int m = 0;
            List<string> list = new List<string>();                  
            List<string> listDistinc = new List<string>();
            Dictionary<string, int> wordKey = new Dictionary<string, int>();
            list = wordList(text); 
            listDistinc = list.Distinct().ToList();
            foreach (string a in listDistinc)
            {
                foreach (string b in list)
                {
                    if (a == b)
                    {
                        m++;
                    }
                }
                wordKey.Add(a, m);
                m = 0;
            }
            return wordKey;
        }
        public Dictionary<string, int> mostRepetitive2(string text) //Binary words
        {
            int m = 0, i;
            List<string> list = new List<string>();
            list = wordList(text);
            List<string> listBinary = new List<string>(); 
            List<string> listDistinc = new List<string>();      
            Dictionary<string, int> wordKey = new Dictionary<string, int>();       

            for (i = 0; i < (list.Count() - 1); i++)
            {
                listBinary.Add(list[i] + " " + list[i + 1]);
            }
            listDistinc = listBinary.Distinct().ToList();

            foreach (string a in listDistinc)
            {
                foreach (string b in listBinary)
                {
                    if (a == b)
                    {
                        m++;
                    }
                }
                wordKey.Add(a, m);
                m = 0;
            }
            return wordKey;
        }
        public Dictionary<string, int> mostRepetitive3(string text) //Triple words
        {
            int m = 0, i;
            List<string> list = new List<string>();
            list = wordList(text);
            List<string> listTriple = new List<string>();
            List<string> listDistinc = new List<string>();           
            Dictionary<string, int> wordKey = new Dictionary<string, int>();          

            for (i = 0; i < (list.Count() - 2); i++)
            {
                listTriple.Add(list[i] + " " + list[i + 1] + " " + list[i + 2]);
            }
            listDistinc = listTriple.Distinct().ToList(); ;

            foreach (string a in listDistinc)
            {
                foreach (string b in listTriple)
                {
                    if (a == b)
                    {
                        m++;
                    }
                }
                wordKey.Add(a, m);
                m = 0;
            }
            return wordKey;
        }
        public Dictionary<string, int> mostRepetitive4(string text) //Quenternary words
        {
            int m = 0, i;
            List<string> list = new List<string>();
            list = wordList(text);
            List<string> listQueternary = new List<string>();
            List<string> listDistinc = new List<string>();          
            Dictionary<string, int> wordKey = new Dictionary<string, int>();       

            for (i = 0; i < (list.Count() - 3); i++)
            {
                listQueternary.Add(list[i] + " " + list[i + 1] + " " + list[i + 2] + " " + list[i + 3]);
            }
            listDistinc = listQueternary.Distinct().ToList(); ;

            foreach (string a in listDistinc)
            {
                foreach (string b in listQueternary)
                {
                    if (a == b)
                    {
                        m++;
                    }
                }
                wordKey.Add(a, m);
                m = 0;
            }
            return wordKey;
        }
        public Dictionary<string, int> mostRepetitive5(string text) //Quintet words
        {
            int m = 0, i;
            List<string> list = new List<string>();
            list = wordList(text);
            List<string> listQuintet = new List<string>(); 
            List<string> listDistinc = new List<string>();         
            Dictionary<string, int> wordKey = new Dictionary<string, int>();       

            for (i = 0; i < (list.Count() - 4); i++)
            {
                listQuintet.Add(list[i] + " " + list[i + 1] + " " + list[i + 2] + " " + list[i + 3] + " " + list[i + 4]);
            }
            listDistinc = listQuintet.Distinct().ToList(); ;

            foreach (string a in listDistinc)
            {
                foreach (string b in listQuintet)
                {
                    if (a == b)
                    {
                        m++;
                    }
                }
                wordKey.Add(a, m);
                m = 0;
            }
            return wordKey;
        }



    }
}
