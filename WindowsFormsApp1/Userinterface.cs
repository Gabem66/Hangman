/*
   Author: Gabe Martinez
    Quinlan Seeberger

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Userinterface : Form
    {
        public Userinterface()
        {
            InitializeComponent();
        }

        string _word;

        private int _wide = 50;
    
        private readonly Font _font = new Font("Segoe UI", 12, GraphicsUnit.Point);
       
        private readonly Padding _pad = new Padding(5);

        private int wrong =0;

        public int tries = 6;

        

        Hang man = new Hang();
        /// <summary>
        /// controls what happens when you select the new word button
        /// </summary>
        /// <param name="sender">the button being pressed</param>
        /// <param name="e">the event </param>
        private void NewClick(object sender, EventArgs e)
        {
            Textpromt textprompt = new Textpromt();
            string word = _word;
            if (textprompt.ShowDialog(this) == DialogResult.OK)
            {
                _word = textprompt.Word().Trim().ToLower();
            }
            else
            {
                return;
            }
            textprompt.Dispose();
            if (_word == "")
            {
                return;
            }
            else if (_word != word)
            {
                
                uxWord.Controls.Clear();
                NewLetters();
                man.ReadWord(_word);
                for (int i = 0; i < _word.Length; i++)
                {
                    Label slot = new Label();
                    //slot.Text = _word[i].ToString();
                    slot.Text = "_";
                    slot.BackColor = Color.Beige;
                    slot.Margin = new Padding(0);
                    slot.TextAlign = ContentAlignment.MiddleCenter;
                    slot.Font = new Font(FontFamily.GenericMonospace.ToString(), 16);
                    slot.BorderStyle = BorderStyle.FixedSingle;
                    slot.Width = uxWord.Width / _word.Length;
                    slot.Height = uxWord.Height;
                    uxWord.Controls.Add(slot);
                }
                tries = 6;
                uxTries.Text = "Tries Left: " + tries;

            }


        }
        /// <summary>
        /// creates buttons for all the  letters
        /// </summary>
        private void NewLetters()
        {
            uxLetters.Controls.Clear();
            uxLetters.Enabled = true;
            char let = 'a';
            while(let<= 'z')
            {
                Button set = new Button
                {
                    Text = let.ToString(),
                    Width = _wide,
                    Height = _font.Height + _pad.Top,
                    Margin = _pad,
                };
                set.Click += new EventHandler(ButtonClick);//creates the event
                uxLetters.Controls.Add(set);
                let++;
            }

        }

        /// <summary>
        /// controls what happens when one of the buttons are pressed
        /// </summary>
        /// <param name="sender">the trigger for the event </param>
        /// <param name="e">the event </param>
        public void ButtonClick(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            if (pressed != null)
            {
                
                char letter = pressed.Text[0];
                bool found = false;
                
                for( int i = 0; i< _word.Length; i++)
                {
                    if (man.contains.TryGetValue(i, out char le))
                    {
                        int j = 0;
                        foreach (Label l in uxWord.Controls)
                        {
                            if (letter == le && j == i)
                            {
                                l.Text = letter.ToString();
                                found = true;
                            }
                            j++;
                        }
                    }
                }

                GameCheck(found);


                pressed.Enabled = false;

            }




        }

        /// <summary>
        /// checks to see if the game is over either by losing or winning
        /// </summary>
        /// <param name="found"></param>
        private void GameCheck(bool found)
        {
            if (found == false)
            {
                MessageBox.Show("letter not found");
                tries--;
                uxTries.Text = "Tries Left: " + tries;


                if (tries < 1)
                {
                    MessageBox.Show("Game over");
                    int a = 0;
                    foreach (Label l in uxWord.Controls)
                    {
                        l.Text = _word[a].ToString();
                        a++;
                    }
                    uxLetters.Enabled = false;
                }
            }
            else
            {
                int a = 0;
                int i = 0;
                foreach (Label l in uxWord.Controls)
                {
                    char let = l.Text[0];
                    if(let == _word[i])
                    {
                        a++;
                    }
                    i++;
                }

                if (a == _word.Length)
                {
                    
                    MessageBox.Show("You Won!");
                    uxLetters.Enabled = false;
                }
            }
        }

        private void uxGiveUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game over");
            int a = 0;
            foreach (Label l in uxWord.Controls)
            {
                l.Text = _word[a].ToString();
                a++;
            }
            tries = 0;
            uxTries.Text = "Tries Left: " + tries;
            uxLetters.Enabled = false;
        }
    }
}
