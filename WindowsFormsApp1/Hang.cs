/*
 * Authors: Gabe Martinez 
 *  Quinlan Seeberger
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Hang
    {
        /// <summary>
        ///  given word;
        /// </summary>
        string _word;

        /// <summary>
        /// holds the letters of the given word
        /// </summary>
        public Dictionary<int, char> contains = new Dictionary<int, char>();

        
        public void ReadWord (string word)
        {
            contains = new Dictionary<int, char>();
            for (int i = 0; i< word.Length; i++)
            {
                contains.Add(i, word[i]);
            }
        }

       

    }
}
